﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteppersControlCore.CommunicationProtocol.CncCommands
{
    public class HomeCncCommand : AbstractCommand, ICommand
    {
        private Dictionary<int, int> _speeds;

        public HomeCncCommand(Dictionary<int, int> speeds, uint packetId) : base(packetId, Protocol.CommandType.WAITING_COMMAND)
        {
            _speeds = speeds;
        }

        public byte[] GetBytes()
        {
            SendPacket packet = new SendPacket(_speeds.Count * 6 + 2);
            packet.SetPacketId(PacketId);

            packet.SetData(0, (byte)Protocol.CncCommands.CNC_HOME);
            packet.SetData(1, (byte)_speeds.Count);

            int i = 0;

            foreach (var stepper in _speeds.Keys)
            {
                packet.SetData(i * 6 + 2, (byte)stepper);

                int speed = _speeds[stepper];

                Protocol.Direction direction = Protocol.Direction.FWD;
                if (speed < 0)
                    direction = Protocol.Direction.REV;

                packet.SetData(i * 6 + 3, (byte)direction);
                byte[] speedBytes = BitConverter.GetBytes((uint)Math.Abs(speed));
                packet.SetData(i * 6 + 4, speedBytes);
                i++;
            }
            return packet.GetBytes();
        }
    }
}