﻿namespace PresentationWinForms.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.connectionState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonShowControlPanel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonStartDemo = new System.Windows.Forms.ToolStripButton();
            this.buttonAbortExecution = new System.Windows.Forms.ToolStripButton();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.devicesTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cncTabPage = new System.Windows.Forms.TabPage();
            this.armTabPage = new System.Windows.Forms.TabPage();
            this.tranporterTabPage = new System.Windows.Forms.TabPage();
            this.rotorTabPage = new System.Windows.Forms.TabPage();
            this.loadTabPage = new System.Windows.Forms.TabPage();
            this.pompTabPage = new System.Windows.Forms.TabPage();
            this.demoTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sensorsView = new PresentationWinForms.Views.SensorsView();
            this.steppersGridView = new PresentationWinForms.Views.SteppersView();
            this.devicesControlView = new PresentationWinForms.Views.DevicesView();
            this.cncView = new PresentationWinForms.Views.CNCView();
            this.armControllerView = new PresentationWinForms.UnitsViews.NeedleUnitView();
            this.transporterControllerView = new PresentationWinForms.UnitsViews.ConveyorUnitView();
            this.rotorControllerView = new PresentationWinForms.UnitsViews.RotorUnitView();
            this.loadControllerView = new PresentationWinForms.UnitsViews.ChargeUnitView();
            this.pompControllerView = new PresentationWinForms.UnitsViews.PompUnitView();
            this.demoExecutorView = new PresentationWinForms.UnitsViews.DemoExecutorView();
            this.logView = new PresentationWinForms.Views.LogView();
            this.buttonConnection = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.devicesTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.cncTabPage.SuspendLayout();
            this.armTabPage.SuspendLayout();
            this.tranporterTabPage.SuspendLayout();
            this.rotorTabPage.SuspendLayout();
            this.loadTabPage.SuspendLayout();
            this.pompTabPage.SuspendLayout();
            this.demoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionState
            // 
            this.connectionState.ForeColor = System.Drawing.Color.Brown;
            this.connectionState.Name = "connectionState";
            this.connectionState.Size = new System.Drawing.Size(127, 20);
            this.connectionState.Text = "НЕ ПОДКЛЮЧЕН";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(154, 20);
            this.toolStripStatusLabel1.Text = "Статус подключения:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.connectionState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 789);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1185, 26);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonConnection,
            this.toolStripSeparator1,
            this.buttonShowControlPanel,
            this.toolStripSeparator2,
            this.buttonStartDemo,
            this.buttonAbortExecution});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1185, 35);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // buttonShowControlPanel
            // 
            this.buttonShowControlPanel.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonShowControlPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowControlPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonShowControlPanel.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowControlPanel.Image")));
            this.buttonShowControlPanel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonShowControlPanel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonShowControlPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.buttonShowControlPanel.Name = "buttonShowControlPanel";
            this.buttonShowControlPanel.Padding = new System.Windows.Forms.Padding(2);
            this.buttonShowControlPanel.Size = new System.Drawing.Size(181, 32);
            this.buttonShowControlPanel.Text = "Панель управления";
            this.buttonShowControlPanel.Click += new System.EventHandler(this.buttonShowControlPanel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // buttonStartDemo
            // 
            this.buttonStartDemo.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonStartDemo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStartDemo.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartDemo.Image")));
            this.buttonStartDemo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonStartDemo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonStartDemo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.buttonStartDemo.Name = "buttonStartDemo";
            this.buttonStartDemo.Padding = new System.Windows.Forms.Padding(2);
            this.buttonStartDemo.Size = new System.Drawing.Size(110, 32);
            this.buttonStartDemo.Text = "Демо (F7)";
            this.buttonStartDemo.Click += new System.EventHandler(this.buttonStartDemo_Click);
            // 
            // buttonAbortExecution
            // 
            this.buttonAbortExecution.BackColor = System.Drawing.Color.Red;
            this.buttonAbortExecution.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAbortExecution.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbortExecution.Image")));
            this.buttonAbortExecution.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonAbortExecution.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAbortExecution.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.buttonAbortExecution.Name = "buttonAbortExecution";
            this.buttonAbortExecution.Padding = new System.Windows.Forms.Padding(2);
            this.buttonAbortExecution.Size = new System.Drawing.Size(138, 32);
            this.buttonAbortExecution.Text = "Прервать (F8)";
            this.buttonAbortExecution.Click += new System.EventHandler(this.abortExecutionButton_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.devicesTabPage);
            this.mainTabControl.Controls.Add(this.cncTabPage);
            this.mainTabControl.Controls.Add(this.armTabPage);
            this.mainTabControl.Controls.Add(this.tranporterTabPage);
            this.mainTabControl.Controls.Add(this.rotorTabPage);
            this.mainTabControl.Controls.Add(this.loadTabPage);
            this.mainTabControl.Controls.Add(this.pompTabPage);
            this.mainTabControl.Controls.Add(this.demoTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(4, 4);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1177, 550);
            this.mainTabControl.TabIndex = 15;
            // 
            // devicesTabPage
            // 
            this.devicesTabPage.Controls.Add(this.tableLayoutPanel1);
            this.devicesTabPage.Location = new System.Drawing.Point(4, 25);
            this.devicesTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.devicesTabPage.Name = "devicesTabPage";
            this.devicesTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.devicesTabPage.Size = new System.Drawing.Size(1169, 521);
            this.devicesTabPage.TabIndex = 0;
            this.devicesTabPage.Text = "Двигатели и устройства";
            this.devicesTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.sensorsView, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.steppersGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.devicesControlView, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 7);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1151, 499);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // cncTabPage
            // 
            this.cncTabPage.Controls.Add(this.cncView);
            this.cncTabPage.Location = new System.Drawing.Point(4, 25);
            this.cncTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cncTabPage.Name = "cncTabPage";
            this.cncTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cncTabPage.Size = new System.Drawing.Size(1169, 521);
            this.cncTabPage.TabIndex = 1;
            this.cncTabPage.Text = "Программное управление";
            this.cncTabPage.UseVisualStyleBackColor = true;
            // 
            // armTabPage
            // 
            this.armTabPage.Controls.Add(this.armControllerView);
            this.armTabPage.Location = new System.Drawing.Point(4, 25);
            this.armTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.armTabPage.Name = "armTabPage";
            this.armTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.armTabPage.Size = new System.Drawing.Size(1169, 521);
            this.armTabPage.TabIndex = 2;
            this.armTabPage.Text = "Рука";
            this.armTabPage.UseVisualStyleBackColor = true;
            // 
            // tranporterTabPage
            // 
            this.tranporterTabPage.Controls.Add(this.transporterControllerView);
            this.tranporterTabPage.Location = new System.Drawing.Point(4, 25);
            this.tranporterTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tranporterTabPage.Name = "tranporterTabPage";
            this.tranporterTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tranporterTabPage.Size = new System.Drawing.Size(1169, 521);
            this.tranporterTabPage.TabIndex = 4;
            this.tranporterTabPage.Text = "Конвейер";
            this.tranporterTabPage.UseVisualStyleBackColor = true;
            // 
            // rotorTabPage
            // 
            this.rotorTabPage.Controls.Add(this.rotorControllerView);
            this.rotorTabPage.Location = new System.Drawing.Point(4, 25);
            this.rotorTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rotorTabPage.Name = "rotorTabPage";
            this.rotorTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rotorTabPage.Size = new System.Drawing.Size(1169, 521);
            this.rotorTabPage.TabIndex = 3;
            this.rotorTabPage.Text = "Ротор";
            this.rotorTabPage.UseVisualStyleBackColor = true;
            // 
            // loadTabPage
            // 
            this.loadTabPage.Controls.Add(this.loadControllerView);
            this.loadTabPage.Location = new System.Drawing.Point(4, 25);
            this.loadTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadTabPage.Name = "loadTabPage";
            this.loadTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadTabPage.Size = new System.Drawing.Size(1169, 521);
            this.loadTabPage.TabIndex = 5;
            this.loadTabPage.Text = "Загрузка";
            this.loadTabPage.UseVisualStyleBackColor = true;
            // 
            // pompTabPage
            // 
            this.pompTabPage.Controls.Add(this.pompControllerView);
            this.pompTabPage.Location = new System.Drawing.Point(4, 25);
            this.pompTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pompTabPage.Name = "pompTabPage";
            this.pompTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pompTabPage.Size = new System.Drawing.Size(1169, 521);
            this.pompTabPage.TabIndex = 6;
            this.pompTabPage.Text = "Насос";
            this.pompTabPage.UseVisualStyleBackColor = true;
            // 
            // demoTabPage
            // 
            this.demoTabPage.Controls.Add(this.demoExecutorView);
            this.demoTabPage.Location = new System.Drawing.Point(4, 25);
            this.demoTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.demoTabPage.Name = "demoTabPage";
            this.demoTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.demoTabPage.Size = new System.Drawing.Size(1169, 521);
            this.demoTabPage.TabIndex = 9;
            this.demoTabPage.Text = "Демо";
            this.demoTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainTabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.logView);
            this.splitContainer1.Size = new System.Drawing.Size(1185, 754);
            this.splitContainer1.SplitterDistance = 557;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 16;
            // 
            // sensorsView
            // 
            this.sensorsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sensorsView.Location = new System.Drawing.Point(809, 5);
            this.sensorsView.Margin = new System.Windows.Forms.Padding(5);
            this.sensorsView.Name = "sensorsView";
            this.sensorsView.Size = new System.Drawing.Size(337, 489);
            this.sensorsView.TabIndex = 20;
            // 
            // steppersGridView
            // 
            this.steppersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.steppersGridView.Location = new System.Drawing.Point(5, 5);
            this.steppersGridView.Margin = new System.Windows.Forms.Padding(5);
            this.steppersGridView.Name = "steppersGridView";
            this.steppersGridView.Size = new System.Drawing.Size(507, 489);
            this.steppersGridView.TabIndex = 11;
            // 
            // devicesControlView
            // 
            this.devicesControlView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devicesControlView.Location = new System.Drawing.Point(522, 5);
            this.devicesControlView.Margin = new System.Windows.Forms.Padding(5);
            this.devicesControlView.Name = "devicesControlView";
            this.devicesControlView.Size = new System.Drawing.Size(277, 489);
            this.devicesControlView.TabIndex = 17;
            // 
            // cncView
            // 
            this.cncView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cncView.Location = new System.Drawing.Point(8, 7);
            this.cncView.Margin = new System.Windows.Forms.Padding(5);
            this.cncView.Name = "cncView";
            this.cncView.Size = new System.Drawing.Size(1151, 499);
            this.cncView.TabIndex = 0;
            // 
            // armControllerView
            // 
            this.armControllerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armControllerView.Location = new System.Drawing.Point(8, 7);
            this.armControllerView.Margin = new System.Windows.Forms.Padding(5);
            this.armControllerView.Name = "armControllerView";
            this.armControllerView.Size = new System.Drawing.Size(1151, 499);
            this.armControllerView.TabIndex = 0;
            // 
            // transporterControllerView
            // 
            this.transporterControllerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transporterControllerView.Location = new System.Drawing.Point(8, 7);
            this.transporterControllerView.Margin = new System.Windows.Forms.Padding(5);
            this.transporterControllerView.Name = "transporterControllerView";
            this.transporterControllerView.Size = new System.Drawing.Size(1151, 499);
            this.transporterControllerView.TabIndex = 0;
            // 
            // rotorControllerView
            // 
            this.rotorControllerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotorControllerView.Location = new System.Drawing.Point(8, 7);
            this.rotorControllerView.Margin = new System.Windows.Forms.Padding(5);
            this.rotorControllerView.Name = "rotorControllerView";
            this.rotorControllerView.Size = new System.Drawing.Size(1151, 499);
            this.rotorControllerView.TabIndex = 0;
            // 
            // loadControllerView
            // 
            this.loadControllerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadControllerView.Location = new System.Drawing.Point(8, 7);
            this.loadControllerView.Margin = new System.Windows.Forms.Padding(5);
            this.loadControllerView.Name = "loadControllerView";
            this.loadControllerView.Size = new System.Drawing.Size(1151, 499);
            this.loadControllerView.TabIndex = 0;
            // 
            // pompControllerView
            // 
            this.pompControllerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pompControllerView.Location = new System.Drawing.Point(8, 7);
            this.pompControllerView.Margin = new System.Windows.Forms.Padding(5);
            this.pompControllerView.Name = "pompControllerView";
            this.pompControllerView.Size = new System.Drawing.Size(1151, 499);
            this.pompControllerView.TabIndex = 0;
            // 
            // demoExecutorView
            // 
            this.demoExecutorView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.demoExecutorView.Location = new System.Drawing.Point(8, 7);
            this.demoExecutorView.Margin = new System.Windows.Forms.Padding(5);
            this.demoExecutorView.Name = "demoExecutorView";
            this.demoExecutorView.Size = new System.Drawing.Size(1151, 499);
            this.demoExecutorView.TabIndex = 0;
            // 
            // logView
            // 
            this.logView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logView.Location = new System.Drawing.Point(4, 4);
            this.logView.Margin = new System.Windows.Forms.Padding(5);
            this.logView.Name = "logView";
            this.logView.Size = new System.Drawing.Size(1177, 184);
            this.logView.TabIndex = 13;
            // 
            // buttonConnection
            // 
            this.buttonConnection.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonConnection.ForeColor = System.Drawing.Color.White;
            this.buttonConnection.Image = ((System.Drawing.Image)(resources.GetObject("buttonConnection.Image")));
            this.buttonConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonConnection.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Padding = new System.Windows.Forms.Padding(2);
            this.buttonConnection.Size = new System.Drawing.Size(138, 32);
            this.buttonConnection.Text = "Подключение";
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 815);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Steppers control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.devicesTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cncTabPage.ResumeLayout(false);
            this.armTabPage.ResumeLayout(false);
            this.tranporterTabPage.ResumeLayout(false);
            this.rotorTabPage.ResumeLayout(false);
            this.loadTabPage.ResumeLayout(false);
            this.pompTabPage.ResumeLayout(false);
            this.demoTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripStatusLabel connectionState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Views.SteppersView steppersGridView;
        private Views.LogView logView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonShowControlPanel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage devicesTabPage;
        private System.Windows.Forms.TabPage cncTabPage;
        private Views.CNCView cncView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Views.DevicesView devicesControlView;
        private System.Windows.Forms.TabPage armTabPage;
        private System.Windows.Forms.TabPage rotorTabPage;
        private System.Windows.Forms.TabPage tranporterTabPage;
        private System.Windows.Forms.TabPage loadTabPage;
        private System.Windows.Forms.TabPage pompTabPage;
        private UnitsViews.NeedleUnitView armControllerView;
        private System.Windows.Forms.ToolStripButton buttonAbortExecution;
        private UnitsViews.ConveyorUnitView transporterControllerView;
        private UnitsViews.RotorUnitView rotorControllerView;
        private UnitsViews.ChargeUnitView loadControllerView;
        private UnitsViews.PompUnitView pompControllerView;
        private System.Windows.Forms.ToolStripButton buttonStartDemo;
        private System.Windows.Forms.TabPage demoTabPage;
        private UnitsViews.DemoExecutorView demoExecutorView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Views.SensorsView sensorsView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripButton buttonConnection;
    }
}
