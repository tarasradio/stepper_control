﻿using System;

namespace AnalyzerCommunication.CommunicationProtocol.Responses
{
    public class CommandStateResponse : AbstaractResponse
    {
        public CommandStateResponse(byte[] buffer) : base(buffer) { }

        public uint GetCommandId()
        {
            uint id = BitConverter.ToUInt32(buffer, 1);
            return id;
        }

        public Protocol.CommandStates GetCommandState()
        {
            return (Protocol.CommandStates)buffer[0];
        }
    }
}