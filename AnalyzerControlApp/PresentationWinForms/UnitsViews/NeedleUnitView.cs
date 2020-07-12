﻿using AnalyzerConfiguration.ControllersConfiguration;
using AnalyzerControlCore;
using System;
using System.Windows.Forms;

namespace PresentationWinForms.UnitsViews
{
    public partial class NeedleUnitView : UserControl
    {
        public NeedleUnitView()
        {
            InitializeComponent();
            if(Core.Needle != null)
                propertyGrid.SelectedObject = Core.Needle.Config;
        }

        private void buttonHomeRotator_Click(object sender, EventArgs e)
        {
            Core.Executor.StartTask(
                () =>
                {
                    Core.Needle.HomeRotator();
                });
        }

        private void turnOnTubeButton_Click(object sender, EventArgs e)
        {
            Core.Executor.StartTask(
                () =>
                {
                    Core.Needle.HomeAll();
                    Core.Needle.TurnToTubeAndWaitTouch();
                });
        }

        private void moveOnWashingButton_Click(object sender, EventArgs e)
        {
            Core.Executor.StartTask(
                () =>
                {
                    Core.Needle.HomeAll();
                    Core.Needle.TurnAndGoDownToWashing();
                });
        }

        private void buttonTurnToCartridge_Click(object sender, EventArgs e)
        {
            CartridgeCell cell = CartridgeCell.WhiteCell;

            if(selectFirstCell.Checked)
            {
                cell = CartridgeCell.FirstCell;
            }
            else if(selectSecondCell.Checked)
            {
                cell = CartridgeCell.SecondCell;
            }
            else if(selectThirdCell.Checked)
            {
                cell = CartridgeCell.ThirdCell;
            }

            Core.Executor.StartTask(
                () =>
                {
                    Core.Needle.HomeAll();
                    Core.Needle.TurnToCartridge(cell);
                });
        }

        private void buttonGoDownAndBrokeCartridge_Click(object sender, EventArgs e)
        {
            CartridgeCell cell = CartridgeCell.WhiteCell;

            if (selectFirstCell.Checked)
            {
                cell = CartridgeCell.FirstCell;
            }
            else if (selectSecondCell.Checked)
            {
                cell = CartridgeCell.SecondCell;
            }
            else if (selectThirdCell.Checked)
            {
                cell = CartridgeCell.ThirdCell;
            }

            Core.Executor.StartTask(
                () =>
                {
                    Core.Needle.GoDownAndPierceCartridge(cell);
                });
        }

        private void buttonHomeLift_Click(object sender, EventArgs e)
        {
            Core.Executor.StartTask(
                () =>
                {
                    Core.Needle.HomeLift();
                });
        }
    }
}