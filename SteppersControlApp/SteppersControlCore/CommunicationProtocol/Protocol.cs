﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteppersControlCore.CommunicationProtocol
{
    public class Protocol
    {
        private static uint lastPacketId = 0;
        public static byte[] PacketHeader = { 0x55, 0x55 };
        public static byte[] PacketEnd = { 0xAA, 0xAA };
        
        public static uint GetPacketId()
        {
            return lastPacketId++;
        }

        public enum CommandStates
        {
            COMMAND_OK,
            COMMAND_BAD_FORMAT,
            COMMAND_DONE
        }

        public enum ResponsesTypes
        {
            DRIVERS_STATES = 0x10,
            COMMAND_STATE_RESPONSE = 0x11,
            TEXT_MESSAGE = 0x12,
        }

        public enum StepperCommands
        {
            GO_UNTIL = 0x09,
            RUN = 0x10,
            MOVE = 0x11,
            STOP = 0x12,
            SET_SPEED = 0x13
        }

        public enum AdditionalCommands
        {
            SET_DEVICE_STATE = 0x14
        }

        public enum CncCommands
        {
            CNC_MOVE = 0x015,
            CNC_SET_SPEED,
            CNC_STOP,
            CNC_HOME,
            CNC_ON_DEVICE,
            CNC_OFF_DEVICE,
            CNC_GO_TO_HAND,
            CNC_GO_TO_PROGRAM
        }

        public enum Direction
        {
            REV = 0x00,
            FWD = 0x01
        }

        public enum CommandType
        {
            WAITING_COMMAND,
            SIMPLE_COMMAND
        }
    }
}