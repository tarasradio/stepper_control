﻿using AnalyzerCommunication.CommunicationProtocol.Responses;
using AnalyzerControlCore;
using PresentationWinForms.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationWinForms.Views
{
    public delegate void SelectionChangedDelegate(int position);

    public partial class SteppersView : UserControl
    {
        public event SelectionChangedDelegate StepperChanged;

        string[] GridHeaders = { "#", "Название", "Статус", "Концевик" };

        int Columns = 4;

        Timer updateTimer = new Timer();

        private static object locker = new object();

        bool gridFilled = false;

        public SteppersView()
        {
            InitializeComponent();
            drawGrid();

            updateTimer.Interval = 100;
            updateTimer.Tick += UpdateTimer_Tick;
        }

        public void StartUpdate()
        {
            updateTimer.Start();
        }

        public void StopUpdate()
        {
            updateTimer.Stop();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            ShowStates();
        }

        private void drawGrid()
        {
            DataGridViewStyler.StyleGrid(SteppersGridView);

            SteppersGridView.ColumnCount = Columns;

            for (int i = 0; i < Columns; i++)
                SteppersGridView.Columns[i].HeaderText = GridHeaders[i];
            
            SteppersGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SteppersGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SteppersGridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SteppersGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            SteppersGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SteppersGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            SteppersGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SteppersGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FillGrid()
        {
            if (Core.AppConfig == null)
                return;

            SteppersGridView.RowCount = Core.AppConfig.Steppers.Count;

            for(int i = 0; i < Core.AppConfig.Steppers.Count; i++)
            {
                SteppersGridView[0, i].Value = Core.AppConfig.Steppers[i].Number;
                SteppersGridView[1, i].Value = Core.AppConfig.Steppers[i].Name;
            }

            gridFilled = true;
        }

        public void UpdateInformation()
        {
            FillGrid();
        }

        public void ShowStates()
        {
            ushort[] states = Core.GetSteppersStates();

            for (int i = 0; i < 18; i++)
            {
                string stateStr = "Остановлен";
                if ((states[i] & (ushort)DriverState.STATUS_MOT_STATUS) == (ushort)StepperState.ACCELERATION)
                    stateStr = "Ускорение";
                if ((states[i] & (ushort)DriverState.STATUS_MOT_STATUS) == (ushort)StepperState.DECELERATION)
                    stateStr = "Замедление";
                if ((states[i] & (ushort)DriverState.STATUS_MOT_STATUS) == (ushort)StepperState.CONSTANT_SPEED)
                    stateStr = "В движении";
                SteppersGridView[2, i].Value = stateStr;

                if ((states[i] & (ushort)DriverState.STATUS_SW_F) != 0)
                {
                    SteppersGridView[3, i].Value = "Нажат";
                    SteppersGridView[3, i].Style.BackColor = Color.Red;
                }
                else
                {
                    SteppersGridView[3, i].Value = "Отпущен";
                    SteppersGridView[3, i].Style.BackColor = Color.GreenYellow;
                }
            }
        }
        
        private void steppersGrid_SelectionChanged(object sender, EventArgs e)
        {
            int index = SteppersGridView.CurrentRow.Index;
            if (gridFilled == false)
                return;
            
            int stepper = (int)(SteppersGridView[0, SteppersGridView.CurrentRow.Index].Value);
            StepperChanged(stepper);
        }
    }
}