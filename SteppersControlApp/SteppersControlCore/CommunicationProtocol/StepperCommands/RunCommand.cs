﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteppersControlCore.CommunicationProtocol.StepperCommands
{
    public class RunCommand : AbstractCommand, ICommand
    {
        private byte _stepper;
        private Protocol.Direction _direction;
        private uint _speed;

        public RunCommand(int stepper, Protocol.Direction direction, uint speed, uint packetId) : base(packetId, Protocol.CommandType.SIMPLE_COMMAND)
        {
            _stepper = (byte)stepper;
            _direction = direction;
            _speed = speed;
        }

        public byte[] GetBytes()
        {
            byte[] speedBytes = BitConverter.GetBytes(_speed);

            SendPacket packet = new SendPacket(7);
            packet.SetPacketId(PacketId);

            packet.SetData(0, (byte)Protocol.StepperCommands.RUN);
            packet.SetData(1, _stepper);
            packet.SetData(2, (byte)_direction);
            packet.SetData(3, speedBytes);

            return packet.GetBytes();
        }
    }
}