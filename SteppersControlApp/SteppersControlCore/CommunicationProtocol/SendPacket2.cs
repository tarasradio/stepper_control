﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteppersControlCore.CommunicationProtocol
{
    public class SendPacket2
    {
        private byte[] _buffer;
        const uint idLength = 4;

        public SendPacket2(int dataLength)
        {
            _buffer = new byte[dataLength + idLength];
        }

        public void SetPacketId(uint packetId)
        {
            byte[] packetIdBytes = BitConverter.GetBytes(packetId);
            Array.Copy(packetIdBytes, 0, _buffer, 0, idLength);
        }

        public void SetData(int bytePosition, byte data)
        {
            _buffer[idLength + bytePosition] = data;
        }

        public void SetData(int bytePosition, byte[] data)
        {
            Array.Copy(data, 0, _buffer, idLength + bytePosition, data.Length);
        }

        public byte[] GetBytes()
        {
            return _buffer;
        }
    }
}
