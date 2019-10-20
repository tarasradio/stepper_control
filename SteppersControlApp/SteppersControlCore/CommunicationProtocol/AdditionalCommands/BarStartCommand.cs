﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteppersControlCore.CommunicationProtocol.AdditionalCommands
{
    public class BarStartCommand : AbstractCommand, IDeviceCommand
    {
        public BarStartCommand() : base()
        {

        }

        public byte[] GetBytes()
        {
            SendPacket2 packet = new SendPacket2(1);
            packet.SetPacketId(_commandId);

            packet.SetData(0, (byte)Protocol.AdditionalCommands.BAR_START);

            return packet.GetBytes();
        }

        public new Protocol.CommandTypes GetType()
        {
            return Protocol.CommandTypes.SIMPLE_COMMAND;
        }
    }
}