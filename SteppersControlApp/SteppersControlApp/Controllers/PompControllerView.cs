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

namespace SteppersControlApp.Controllers
{
    public partial class PompControllerView : UserControl
    {
        public PompControllerView()
        {
            InitializeComponent();
            if (Core.Pomp != null)
                propertyGrid.SelectedObject = Core.Pomp.Props;
        }

        private void buttonNeedleWashing_Click(object sender, EventArgs e)
        {
            int cycles = (int)editNumberCycles.Value;

            Core.Executor.StartTask(
                () =>
                {
                    Core.CNCExecutor.ExecuteTask(Core.Pomp.Washing(cycles));
                });
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Core.Executor.StartTask(
                () =>
                {
                    Core.CNCExecutor.ExecuteTask(Core.Pomp.Home());
                });
        }

        private void buttonSuction_Click(object sender, EventArgs e)
        {
            int value = (int)editSuctionValue.Value;

            Core.Executor.StartTask(
                () =>
                {
                    Core.CNCExecutor.ExecuteTask(Core.Pomp.Suction(value));
                });
        }

        private void buttonUnsuction_Click(object sender, EventArgs e)
        {
            int value = (int)editSuctionValue.Value;

            Core.Executor.StartTask(
                () =>
                {
                    Core.CNCExecutor.ExecuteTask(Core.Pomp.Unsuction(value));
                });
        }
    }
}
