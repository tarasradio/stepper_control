﻿using System.Collections.Generic;

namespace AnalyzerCommunication.CommunicationProtocol.CncCommands
{
    public class MoveCncCommand : SteppersCncCommand, IRemoteCommand
    {
        public MoveCncCommand(Dictionary<int, int> steppers) : base(steppers, Protocol.CncCommands.CNC_MOVE) { }

        public new Protocol.CommandTypes GetType()
        {
            return Protocol.CommandTypes.WAITING_COMMAND;
        }
    }
}
