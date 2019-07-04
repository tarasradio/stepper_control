﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteppersControlCore.CommunicationProtocol.Responses
{
    public enum StepperState
    {
        STOPPED = (0x0000) << 5,
        ACCELERATION = (0x0001) << 5,
        DECELERATION = (0x0002) << 5,
        CONSTANT_SPEED = (0x0003) << 5
    }

    public enum DriverState
    {
        STATUS_HIZ = 0x0001,            // high when bridges are in HiZ mode
        STATUS_BUSY = 0x0002,           // mirrors BUSY pin
        STATUS_SW_F = 0x0004,           // low when switch open, high when closed
        STATUS_SW_EVN = 0x0008,         // active high, set on switch falling edge,
                                        //  cleared by reading STATUS
        STATUS_DIR = 0x0010,            // Indicates current motor direction.
                                        //  High is FWD, Low is REV.
        STATUS_NOTPERF_CMD = 0x0080,    // Last command not performed.
        STATUS_WRONG_CMD = 0x0100,      // Last command not valid.
        STATUS_UVLO = 0x0200,           // Undervoltage lockout is active
        STATUS_TH_WRN = 0x0400,         // Thermal warning
        STATUS_TH_SD = 0x0800,          // Thermal shutdown
        STATUS_OCD = 0x1000,            // Overcurrent detected
        STATUS_STEP_LOSS_A = 0x2000,    // Stall detected on A bridge
        STATUS_STEP_LOSS_B = 0x4000,    // Stall detected on B bridge
        STATUS_SCK_MOD = 0x8000,        // Step clock mode is active
        STATUS_MOT_STATUS = 0x0060      // field mask
    }

    public class SteppersStatesResponse
    {
        byte[] _buffer;

        public SteppersStatesResponse(byte[] buffer)
        {
            _buffer = new byte[buffer.Length - 1];
            Array.Copy(buffer, 1, _buffer, 0, _buffer.Length - 1);
        }

        public UInt16[] GetStates()
        {
            if((_buffer.Length) % 2 != 0)
            {
                return null;
            }
            UInt16[] states = new UInt16[_buffer.Length / 2];

            for(int  i = 0; i < _buffer.Length; i += 2)
            {
                UInt16 state = BitConverter.ToUInt16(_buffer, i);
                states[i / 2] = state;
            }

            return states;
        }
    }
}
