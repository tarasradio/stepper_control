#include "command_executor.hpp"
#include "protocol.hpp"

#include "steppers.hpp"
#include "sensors.hpp"
#include "devices.hpp"

void readPacket();
void processPacket();
void executeCommand(uint8_t *buffer, uint8_t bufferLength);

void executeGoUntilCommand(uint8_t *packet, uint8_t packetLength);
void executeRunCommand(uint8_t *packet, uint8_t packetLength);
void executeMoveCommand(uint8_t *packet, uint8_t packetLength);
void executeStopCommand(uint8_t *packet, uint8_t packetLength);
void executeSetSpeedCommand(uint8_t *packet, uint8_t packetLength);
void executeSetDeviceStateCommand(uint8_t *packet, uint8_t packetLength);

void executeCncMoveCommand(uint8_t *packet, uint8_t packetLength);
void executeCncHomeCommand(uint8_t *packet, uint8_t packetLength);
void executeCncSetSpeedCommand(uint8_t *packet, uint8_t packetLength);

void printCommandStateResponse(uint32_t commandId, uint8_t commandState);
void printMessage(String messageText);
void printSteppersStates();

uint8_t incomingBuffer[64];
uint8_t currentBufferByte = 0;

uint8_t steppersForMove[18];
uint8_t countMoveSteppers = 0;

uint8_t getSteppersInMove()
{
  uint8_t steppersInMove = 0;
  for (int i = 0; i < countMoveSteppers; i++)
  {
    uint8_t stepper = steppersForMove[i];
    uint16_t stepperStatus = getStepper(stepper).getStatus() & STATUS_MOT_STATUS;

    if (stepperStatus != 0)
      steppersInMove++;
  }

  return steppersInMove;
}

uint32_t lastCommandId = 0;
uint8_t waitForCommandDone = 0;

//TODO: добавить проверку не завершенных команд
void addCommandForWait(uint32_t commandId)
{
  lastCommandId = commandId;
  waitForCommandDone = 1;
}

void executionMainLoop()
{
  readPacket();
  processPacket();
  printSteppersStates();

  if (waitForCommandDone != 0) // Есть команды, ожидающие завершения
  {
    if (getSteppersInMove() == 0) // Моторы завершили движение
    {
      printCommandStateResponse(lastCommandId, COMMAND_DONE);
      waitForCommandDone = 0;
    }
  }
}

void readPacket()
{
  currentBufferByte = 0;
  uint8_t countBytes = Serial.available();
  if (countBytes > 0)
  {
    while (countBytes != 0)
    {
      incomingBuffer[currentBufferByte++] = Serial.read();
      countBytes--;
    }
  }
}

enum ReceiveState
{
  RECEIVING_HEADER,
  RECEIVING_BODY
};

uint8_t packetBuffer[64];

void processPacket()
{
  uint8_t i = 0;

  uint8_t state = RECEIVING_HEADER;
  uint8_t currentHeaderByte = 0;
  uint8_t currentEndByte = 0;
  uint8_t currentPacketByte = 0;

  while (i != currentBufferByte)
  {
    switch (state)
    {
    case RECEIVING_HEADER:
    {
      if (incomingBuffer[i] == packetHeader[currentHeaderByte])
        currentHeaderByte++;
      else
        currentHeaderByte = 0;

      if (currentHeaderByte == packetHeaderLength)
      {
        state = RECEIVING_BODY;
        currentEndByte = 0;
        currentPacketByte = 0;
      }
    }
    break;
    case RECEIVING_BODY:
    {
      packetBuffer[currentPacketByte++] = incomingBuffer[i];

      if (incomingBuffer[i] == packetEnd[currentEndByte])
        currentEndByte++;
      else
        currentEndByte = 0;

      if (currentEndByte == packetEndLength)
      {
        currentHeaderByte = 0;
        state = RECEIVING_HEADER;

        uint8_t packetLength = currentPacketByte - packetEndLength;

        executeCommand(packetBuffer, packetLength);
      }
    }
    break;
    }
    i++;
  }
}

void executeCommand(uint8_t *packet, uint8_t packetLength)
{
  byte commandType = packet[0];
  switch (commandType)
  {
    case CMD_GO_UNTIL:
    {
      executeGoUntilCommand(packet + 1, packetLength - 1);
    }
    break;
    case CMD_RUN:
    {
      executeRunCommand(packet + 1, packetLength - 1);
    }
    break;
    case CMD_MOVE:
    {
      executeMoveCommand(packet + 1, packetLength - 1);
    }
    break;
    case CMD_STOP:
    {
      executeStopCommand(packet + 1, packetLength - 1);
    }
    break;
    case CMD_SET_SPEED:
    {
      executeSetSpeedCommand(packet + 1, packetLength - 1);
    }
    break;
    case CMD_SET_DEVICE_STATE:
    {
      executeSetDeviceStateCommand(packet + 1, packetLength - 1);
    }
    break;
    case CNC_MOVE:
    {
      executeCncMoveCommand(packet + 1, packetLength - 1);
    }
    break;
    case CNC_SET_SPEED:
    {
      executeCncSetSpeedCommand(packet + 1, packetLength - 1);
    }
    break;
    case CNC_HOME:
    {
      executeCncHomeCommand(packet + 1, packetLength - 1);
    }
    break;
    default:
    {
      printMessage("Unknown command!");
    }
    break;
  }
}

uint32_t readLong(uint8_t *buffer)
{
  return *((unsigned long *)(buffer));
}

String messageToSend = "";

void executeGoUntilCommand(uint8_t *packet, uint8_t packetLength)
{
  uint8_t stepper = packet[0];
  uint8_t direction = packet[1];
  uint32_t fullSpeed = readLong(packet + 2);

  uint32_t packetId = readLong(packet + 6);

  printCommandStateResponse(packetId, COMMAND_OK);

  countMoveSteppers = 1;
  steppersForMove[0] = stepper;

  addCommandForWait(packetId);

  messageToSend = "[Go until] ";
  messageToSend += "stepper = " + String(stepper);
  messageToSend += ", dir = " + String(direction);
  messageToSend += ", speed = " + String(fullSpeed);

  getStepper(stepper).goUntil(RESET_ABSPOS, direction, fullSpeed);

  printMessage(messageToSend);
  messageToSend = "";
}

void executeRunCommand(uint8_t *packet, uint8_t packetLength)
{
  uint8_t stepper = packet[0];
  uint8_t direction = packet[1];
  uint32_t fullSpeed = readLong(packet + 2);

  uint32_t packetId = readLong(packet + 6);
  printCommandStateResponse(packetId, COMMAND_OK);

  messageToSend = "[Run] ";
  messageToSend += "stepper = " + String(stepper);
  messageToSend += ", dir = " + String(direction);
  messageToSend += ", speed = " + String(fullSpeed);

  getStepper(stepper).run(direction, fullSpeed);

  printMessage(messageToSend);
  messageToSend = "";
}

void executeMoveCommand(uint8_t *packet, uint8_t packetLength)
{
  uint8_t stepper = packet[0];
  uint8_t direction = packet[1];
  uint32_t steps = readLong(packet + 2);

  uint32_t packetId = readLong(packet + 6);

  printCommandStateResponse(packetId, COMMAND_OK);

  countMoveSteppers = 1;
  steppersForMove[0] = stepper;

  addCommandForWait(packetId);

  messageToSend = "[Move] ";
  messageToSend += "stepper = " + String(stepper);
  messageToSend += ", dir = " + String(direction);
  messageToSend += ", steps = " + String(steps);

  getStepper(stepper).move(direction, steps);

  printMessage(messageToSend);
  messageToSend = "";
}

void executeStopCommand(uint8_t *packet, uint8_t packetLength)
{
  uint8_t stepper = packet[0];
  uint8_t stopType = packet[1];

  uint32_t packetId = readLong(packet + 2);
  printCommandStateResponse(packetId, COMMAND_OK);

  messageToSend = "[Stop] ";
  messageToSend += "stepper = " + String(stepper);
  messageToSend += ", stopType = ";

  switch (stopType)
  {
  case STOP_SOFT:
  {
    messageToSend += "SOFT";
    getStepper(stepper).softStop();
  }
  break;
  case STOP_HARD:
  {
    messageToSend += "HARD";
    getStepper(stepper).hardStop();
  }
  break;
  }
  printMessage(messageToSend);
  messageToSend = "";
}

void executeSetSpeedCommand(uint8_t *packet, uint8_t packetLength)
{
  uint8_t stepper = packet[0];
  uint32_t fullSpeed = readLong(packet + 1);

  uint32_t packetId = readLong(packet + 5);
  printCommandStateResponse(packetId, COMMAND_OK);

  messageToSend = "[Set speed] ";
  messageToSend += "stepper = " + String(stepper);
  messageToSend += ", speed = " + String(fullSpeed);

  getStepper(stepper).setMaxSpeed(fullSpeed);
  getStepper(stepper).setFullSpeed(fullSpeed);

  printMessage(messageToSend);
  messageToSend = "";
}

void executeSetDeviceStateCommand(uint8_t *packet, uint8_t packetLength)
{
  uint8_t device = packet[0];
  uint8_t state = packet[1];

  uint32_t packetId = readLong(packet + 2);
  printCommandStateResponse(packetId, COMMAND_OK);

  messageToSend = "[Set device state] ";
  messageToSend += "device = " + String(device);
  messageToSend += ", state = " + String(state);

  device_set_state(device, state);

  printMessage(messageToSend);
  messageToSend = "";
}

void executeCncMoveCommand(uint8_t *packet, uint8_t packetLength)
{
  uint8_t countOfSteppers = packet[0];

  uint32_t packetId = readLong(packet + countOfSteppers * 6 + 1);

  printCommandStateResponse(packetId, COMMAND_OK);

  countMoveSteppers = countOfSteppers;

  messageToSend = "[CNC Move] ";
  messageToSend += "Steppers = " + String(countOfSteppers);
  printMessage(messageToSend);

  for (int i = 0; i < countOfSteppers; i++)
  {
    uint8_t stepper = packet[i * 6 + 1];
    uint8_t direction = packet[i * 6 + 2];
    uint32_t steps = readLong(packet + i * 6 + 3);
    
    steppersForMove[i] = stepper;

    messageToSend = "[ stepper = " + String(stepper);
    messageToSend += ", dir = " + String(direction);
    messageToSend += ", steps = " + String(steps) + "] ";

    getStepper(stepper).move(direction, steps);

    printMessage(messageToSend);
  }

  addCommandForWait(packetId);

  messageToSend = "";
}

void executeCncHomeCommand(uint8_t *packet, uint8_t packetLength)
{
  uint8_t countOfSteppers = packet[0];

  uint32_t packetId = readLong(packet + countOfSteppers * 6 + 1);

  printCommandStateResponse(packetId, COMMAND_OK);

  countMoveSteppers = countOfSteppers;

  messageToSend = "[CNC Home] ";
  messageToSend += "Steppers = " + String(countOfSteppers);
  printMessage(messageToSend);

  for (int i = 0; i < countOfSteppers; i++)
  {
    uint8_t stepper = packet[i * 6 + 1];
    uint8_t direction = packet[i * 6 + 2];
    uint32_t fullSpeed = readLong(packet + i * 6 + 3);
    
    steppersForMove[i] = stepper;

    messageToSend = "[ stepper = " + String(stepper);
    messageToSend += ", dir = " + String(direction);
    messageToSend += ", fullSpeed = " + String(fullSpeed) + "] ";

    getStepper(stepper).goUntil(RESET_ABSPOS, direction, fullSpeed);

    printMessage(messageToSend);
  }

  addCommandForWait(packetId);

  messageToSend = "";
}

void executeCncSetSpeedCommand(uint8_t *packet, uint8_t packetLength)
{
  uint8_t countOfSteppers = packet[0];
  
  uint32_t packetId = readLong(packet + countOfSteppers * 5 + 1);

  printCommandStateResponse(packetId, COMMAND_OK);

  messageToSend = "[CNC Set speed] ";
  messageToSend += "Steppers = " + String(countOfSteppers);
  printMessage(messageToSend);

  for (int i = 0; i < countOfSteppers; i++)
  {
    uint8_t stepper = packet[i * 5 + 1];
    uint32_t fullSpeed = readLong(packet + i * 5 + 2);

    messageToSend = "[ stepper = " + String(stepper);
    messageToSend += ", fullSpeed = " + String(fullSpeed) + "] ";

    getStepper(stepper).setMaxSpeed(fullSpeed);
    getStepper(stepper).setFullSpeed(fullSpeed);

    printMessage(messageToSend);
  }

  messageToSend = "";
}

void printCommandStateResponse(uint32_t commandId, uint8_t commandState)
{
  Serial.write(packetHeader, packetHeaderLength);
  Serial.write(COMMAND_STATE);
  Serial.write(commandState);
  Serial.write((byte *)&commandId, sizeof(commandId));
  Serial.write(packetEnd, packetEndLength);
}

void printMessage(String messageText)
{
  Serial.write(packetHeader, packetHeaderLength);
  Serial.write(TEXT_MESSAGE);
  Serial.println(messageText);
  Serial.write(packetEnd, packetEndLength);
}

void printSteppersStates()
{
  Serial.write(packetHeader, packetHeaderLength);
  Serial.write(STEPPERS_STATES);
  for (uint8_t i = 0; i < 18; i++)
  {
    uint16_t stepperStatus = getStepper(i).getStatus();
    Serial.write((byte *)&stepperStatus, sizeof(stepperStatus));
  }
  Serial.write(packetEnd, packetEndLength);
}