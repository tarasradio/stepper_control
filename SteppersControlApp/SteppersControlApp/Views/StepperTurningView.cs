﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SteppersControlCore;
using SteppersControlCore.CommunicationProtocol;
using SteppersControlCore.SerialCommunication;
using SteppersControlCore.CommunicationProtocol.StepperCommands;

namespace SteppersControlApp.Views
{
    public partial class StepperTurningView : UserControl
    {
        private Stepper _stepperParams = null;
        bool isLoading = false;

        public StepperTurningView()
        {
            InitializeComponent();
        }

        public void SetStepperParams(Stepper stepperParams)
        {
            _stepperParams = stepperParams;
            UpdateInformation();
        }

        public void ChangeStepperParams(Stepper stepperParams)
        {
            SaveInformation();
            SetStepperParams(stepperParams);
        }

        public void SaveInformation()
        {
            if (isLoading)
                return;
            if (Core.Settings == null)
                return;

            _stepperParams.Reverse = checkReverse.Checked;
            _stepperParams.Name = editStepperName.Text;
            _stepperParams.NumberSteps = (uint)editNumberSteps.Value;
            _stepperParams.FullSpeed = (uint)editFullSpeed.Value;
        }
        
        public void UpdateInformation()
        {
            isLoading = true;
            if (Core.Settings == null)
                return;

            bool isReverse = _stepperParams.Reverse;
            checkReverse.Checked = isReverse;

            if(isReverse)
            {
                buttonFwd.BackColor = Color.White;
                buttonRev.BackColor = Color.GreenYellow;
            }
            else
            {
                buttonFwd.BackColor = Color.GreenYellow;
                buttonRev.BackColor = Color.White;
            }

            editStepperName.Text = _stepperParams.Name;
            editNumberSteps.Value = _stepperParams.NumberSteps;
            editFullSpeed.Value = _stepperParams.FullSpeed;
            isLoading = false;
        }

        private void checkReverse_CheckedChanged(object sender, EventArgs e)
        {
            SaveInformation();
            UpdateInformation();
        }

        private void buttonRev_Click(object sender, EventArgs e)
        {
            int countSteps = (int)editNumberSteps.Value;
            if (setNumberSteps.Checked)
                move(Protocol.Direction.REV, countSteps);
            else
                run(Protocol.Direction.REV);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopCommand.StopType type = StopCommand.StopType.SOFT_STOP;
            Core.Serial.SendPacket(new StopCommand(_stepperParams.Number, type).GetBytes());
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            bool isReverse = _stepperParams.Reverse;
            Protocol.Direction direction = isReverse ? Protocol.Direction.REV : Protocol.Direction.FWD;
            goHome(direction);
        }

        private void buttonFwd_Click(object sender, EventArgs e)
        {
            int countSteps = (int)editNumberSteps.Value;
            if (setNumberSteps.Checked)
                move(Protocol.Direction.FWD, countSteps);
            else
                run(Protocol.Direction.FWD);
        }

        private void move(Protocol.Direction direction, int countSteps)
        {
            int speed = (int)editFullSpeed.Value;
            int stepper = _stepperParams.Number;
            Core.Serial.SendPacket(new StopCommand(stepper, StopCommand.StopType.SOFT_STOP).GetBytes());
            Core.Serial.SendPacket(new SetSpeedCommand(stepper, (uint)speed).GetBytes());
            countSteps = direction == Protocol.Direction.FWD ? countSteps : -countSteps;
            Core.Serial.SendPacket(new MoveCommand(stepper, countSteps).GetBytes());
        }

        private void run(Protocol.Direction direction)
        {
            int speed = (int)editFullSpeed.Value;
            int stepper = _stepperParams.Number;
            Core.Serial.SendPacket(new StopCommand(stepper, StopCommand.StopType.SOFT_STOP).GetBytes());
            speed = direction == Protocol.Direction.FWD ? speed : -speed;
            Core.Serial.SendPacket(new RunCommand(stepper, speed).GetBytes());
        }

        private void goHome(Protocol.Direction direction)
        {
            int speed = (int)editFullSpeed.Value;
            int stepper = _stepperParams.Number;
            Core.Serial.SendPacket(new StopCommand(stepper, StopCommand.StopType.SOFT_STOP).GetBytes());
            speed = direction == Protocol.Direction.FWD ? speed : -speed;
            Core.Serial.SendPacket(new HomeCommand(stepper, speed).GetBytes());
        }

        private void editNumberSteps_ValueChanged(object sender, EventArgs e)
        {
            SaveInformation();
        }

        private void editFullSpeed_ValueChanged(object sender, EventArgs e)
        {
            SaveInformation();
        }

        private void editStepperName_TextChanged(object sender, EventArgs e)
        {
            SaveInformation();
        }
    }
}
