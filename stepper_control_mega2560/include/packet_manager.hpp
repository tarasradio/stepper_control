#ifndef packet_manager_hpp
#define packet_manager_hpp

#include <Arduino.h>
#include "command_executor2.hpp"

class PacketManager
{
private:
    CommandExecutor2 _commandExecutor;
public:
    PacketManager(CommandExecutor2 & );
    void ReadPacket();

    void tryPacketBuild(uint8_t bufferPosition);
    void findByteStuffingPacket();
    static void printMessage(const String & messageText);
    static void printBarCode(const String & barCode);
};

#endif