﻿namespace SteppersControlApp.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.connectionState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonUpdateList = new System.Windows.Forms.ToolStripButton();
            this.selectPort = new System.Windows.Forms.ToolStripComboBox();
            this.editBaudrate = new System.Windows.Forms.ToolStripComboBox();
            this.buttonConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonShowControlPanel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonStartDemo = new System.Windows.Forms.ToolStripButton();
            this.buttonAbortExecution = new System.Windows.Forms.ToolStripButton();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.devicesTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.sensorsTabPage = new System.Windows.Forms.TabPage();
            this.cncTabPage = new System.Windows.Forms.TabPage();
            this.armTabPage = new System.Windows.Forms.TabPage();
            this.tranporterTabPage = new System.Windows.Forms.TabPage();
            this.rotorTabPage = new System.Windows.Forms.TabPage();
            this.loadTabPage = new System.Windows.Forms.TabPage();
            this.pompTabPage = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.demoTabPage = new System.Windows.Forms.TabPage();
            this.steppersGridView = new SteppersControlApp.Views.SteppersGridView();
            this.devicesControlView = new SteppersControlApp.Views.DevicesControlView();
            this.sensorsView = new SteppersControlApp.Views.SensorsView();
            this.cncView = new SteppersControlApp.Views.CNCView();
            this.armControllerView = new SteppersControlApp.ControllersViews.ArmControllerView();
            this.transporterControllerView = new SteppersControlApp.ControllersViews.TransporterControllerView();
            this.rotorControllerView = new SteppersControlApp.ControllersViews.RotorControllerView();
            this.loadControllerView = new SteppersControlApp.ControllersViews.LoadControllerView();
            this.pompControllerView = new SteppersControlApp.ControllersViews.PompControllerView();
            this.additionalMovesView = new SteppersControlApp.ControllersViews.AdditionalMovesView();
            this.demoExecutorView = new SteppersControlApp.ControllersViews.DemoExecutorView();
            this.logView = new SteppersControlApp.Views.LogView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.devicesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.sensorsTabPage.SuspendLayout();
            this.cncTabPage.SuspendLayout();
            this.armTabPage.SuspendLayout();
            this.tranporterTabPage.SuspendLayout();
            this.rotorTabPage.SuspendLayout();
            this.loadTabPage.SuspendLayout();
            this.pompTabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.connectionState.Size = new System.Drawing.Size(101, 17);
            this.connectionState.Text = "НЕ ПОДКЛЮЧЕН";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(125, 17);
            this.toolStripStatusLabel1.Text = "Статус подключения:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.connectionState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 606);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(911, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonUpdateList,
            this.selectPort,
            this.editBaudrate,
            this.buttonConnect,
            this.toolStripSeparator1,
            this.buttonShowControlPanel,
            this.toolStripSeparator2,
            this.buttonStartDemo,
            this.buttonAbortExecution});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(911, 35);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip";
            // 
            // buttonUpdateList
            // 
            this.buttonUpdateList.BackColor = System.Drawing.Color.Teal;
            this.buttonUpdateList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdateList.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateList.Image")));
            this.buttonUpdateList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonUpdateList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonUpdateList.Margin = new System.Windows.Forms.Padding(3, 1, 2, 2);
            this.buttonUpdateList.Name = "buttonUpdateList";
            this.buttonUpdateList.Padding = new System.Windows.Forms.Padding(2);
            this.buttonUpdateList.Size = new System.Drawing.Size(141, 32);
            this.buttonUpdateList.Text = "Поиск портов (F5)";
            this.buttonUpdateList.Click += new System.EventHandler(this.buttonUpdateList_Click);
            // 
            // selectPort
            // 
            this.selectPort.DropDownWidth = 121;
            this.selectPort.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.selectPort.Name = "selectPort";
            this.selectPort.Size = new System.Drawing.Size(100, 35);
            // 
            // editBaudrate
            // 
            this.editBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.editBaudrate.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.editBaudrate.Name = "editBaudrate";
            this.editBaudrate.Size = new System.Drawing.Size(80, 35);
            this.editBaudrate.ToolTipText = "Скорость соединения (бод/сек)";
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonConnect.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConnect.Image = ((System.Drawing.Image)(resources.GetObject("buttonConnect.Image")));
            this.buttonConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 1, 2, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Padding = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Size = new System.Drawing.Size(122, 32);
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
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
            this.buttonShowControlPanel.Size = new System.Drawing.Size(149, 32);
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
            this.buttonStartDemo.Size = new System.Drawing.Size(93, 32);
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
            this.buttonAbortExecution.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.buttonAbortExecution.Name = "buttonAbortExecution";
            this.buttonAbortExecution.Padding = new System.Windows.Forms.Padding(2);
            this.buttonAbortExecution.Size = new System.Drawing.Size(116, 32);
            this.buttonAbortExecution.Text = "Прервать (F8)";
            this.buttonAbortExecution.Click += new System.EventHandler(this.abortExecutionButton_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.devicesTabPage);
            this.mainTabControl.Controls.Add(this.sensorsTabPage);
            this.mainTabControl.Controls.Add(this.cncTabPage);
            this.mainTabControl.Controls.Add(this.armTabPage);
            this.mainTabControl.Controls.Add(this.tranporterTabPage);
            this.mainTabControl.Controls.Add(this.rotorTabPage);
            this.mainTabControl.Controls.Add(this.loadTabPage);
            this.mainTabControl.Controls.Add(this.pompTabPage);
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.demoTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(3, 3);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(905, 416);
            this.mainTabControl.TabIndex = 15;
            // 
            // devicesTabPage
            // 
            this.devicesTabPage.Controls.Add(this.splitContainer);
            this.devicesTabPage.Location = new System.Drawing.Point(4, 22);
            this.devicesTabPage.Name = "devicesTabPage";
            this.devicesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.devicesTabPage.Size = new System.Drawing.Size(897, 390);
            this.devicesTabPage.TabIndex = 0;
            this.devicesTabPage.Text = "Двигатели и устройства";
            this.devicesTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(6, 6);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer.Panel1.Controls.Add(this.steppersGridView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.devicesControlView);
            this.splitContainer.Size = new System.Drawing.Size(885, 378);
            this.splitContainer.SplitterDistance = 573;
            this.splitContainer.TabIndex = 18;
            // 
            // sensorsTabPage
            // 
            this.sensorsTabPage.Controls.Add(this.sensorsView);
            this.sensorsTabPage.Location = new System.Drawing.Point(4, 22);
            this.sensorsTabPage.Name = "sensorsTabPage";
            this.sensorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sensorsTabPage.Size = new System.Drawing.Size(879, 378);
            this.sensorsTabPage.TabIndex = 10;
            this.sensorsTabPage.Text = "Датчики";
            this.sensorsTabPage.UseVisualStyleBackColor = true;
            // 
            // cncTabPage
            // 
            this.cncTabPage.Controls.Add(this.cncView);
            this.cncTabPage.Location = new System.Drawing.Point(4, 22);
            this.cncTabPage.Name = "cncTabPage";
            this.cncTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cncTabPage.Size = new System.Drawing.Size(879, 378);
            this.cncTabPage.TabIndex = 1;
            this.cncTabPage.Text = "Программное управление";
            this.cncTabPage.UseVisualStyleBackColor = true;
            // 
            // armTabPage
            // 
            this.armTabPage.Controls.Add(this.armControllerView);
            this.armTabPage.Location = new System.Drawing.Point(4, 22);
            this.armTabPage.Name = "armTabPage";
            this.armTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.armTabPage.Size = new System.Drawing.Size(879, 378);
            this.armTabPage.TabIndex = 2;
            this.armTabPage.Text = "Рука";
            this.armTabPage.UseVisualStyleBackColor = true;
            // 
            // tranporterTabPage
            // 
            this.tranporterTabPage.Controls.Add(this.transporterControllerView);
            this.tranporterTabPage.Location = new System.Drawing.Point(4, 22);
            this.tranporterTabPage.Name = "tranporterTabPage";
            this.tranporterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tranporterTabPage.Size = new System.Drawing.Size(879, 378);
            this.tranporterTabPage.TabIndex = 4;
            this.tranporterTabPage.Text = "Конвейер";
            this.tranporterTabPage.UseVisualStyleBackColor = true;
            // 
            // rotorTabPage
            // 
            this.rotorTabPage.Controls.Add(this.rotorControllerView);
            this.rotorTabPage.Location = new System.Drawing.Point(4, 22);
            this.rotorTabPage.Name = "rotorTabPage";
            this.rotorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rotorTabPage.Size = new System.Drawing.Size(879, 378);
            this.rotorTabPage.TabIndex = 3;
            this.rotorTabPage.Text = "Ротор";
            this.rotorTabPage.UseVisualStyleBackColor = true;
            // 
            // loadTabPage
            // 
            this.loadTabPage.Controls.Add(this.loadControllerView);
            this.loadTabPage.Location = new System.Drawing.Point(4, 22);
            this.loadTabPage.Name = "loadTabPage";
            this.loadTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loadTabPage.Size = new System.Drawing.Size(879, 378);
            this.loadTabPage.TabIndex = 5;
            this.loadTabPage.Text = "Загрузка";
            this.loadTabPage.UseVisualStyleBackColor = true;
            // 
            // pompTabPage
            // 
            this.pompTabPage.Controls.Add(this.pompControllerView);
            this.pompTabPage.Location = new System.Drawing.Point(4, 22);
            this.pompTabPage.Name = "pompTabPage";
            this.pompTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pompTabPage.Size = new System.Drawing.Size(879, 378);
            this.pompTabPage.TabIndex = 6;
            this.pompTabPage.Text = "Насос";
            this.pompTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.additionalMovesView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(879, 378);
            this.tabPage1.TabIndex = 8;
            this.tabPage1.Text = "Сложные движения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // demoTabPage
            // 
            this.demoTabPage.Controls.Add(this.demoExecutorView);
            this.demoTabPage.Location = new System.Drawing.Point(4, 22);
            this.demoTabPage.Name = "demoTabPage";
            this.demoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.demoTabPage.Size = new System.Drawing.Size(879, 378);
            this.demoTabPage.TabIndex = 9;
            this.demoTabPage.Text = "Демо";
            this.demoTabPage.UseVisualStyleBackColor = true;
            // 
            // steppersGridView
            // 
            this.steppersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.steppersGridView.Location = new System.Drawing.Point(3, 3);
            this.steppersGridView.Name = "steppersGridView";
            this.steppersGridView.Size = new System.Drawing.Size(567, 372);
            this.steppersGridView.TabIndex = 11;
            // 
            // devicesControlView
            // 
            this.devicesControlView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devicesControlView.Location = new System.Drawing.Point(3, 3);
            this.devicesControlView.Name = "devicesControlView";
            this.devicesControlView.Size = new System.Drawing.Size(302, 372);
            this.devicesControlView.TabIndex = 17;
            // 
            // sensorsView
            // 
            this.sensorsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sensorsView.Location = new System.Drawing.Point(6, 6);
            this.sensorsView.Name = "sensorsView";
            this.sensorsView.Size = new System.Drawing.Size(792, 366);
            this.sensorsView.TabIndex = 19;
            // 
            // cncView
            // 
            this.cncView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cncView.Location = new System.Drawing.Point(6, 6);
            this.cncView.Name = "cncView";
            this.cncView.Size = new System.Drawing.Size(792, 366);
            this.cncView.TabIndex = 0;
            // 
            // armControllerView
            // 
            this.armControllerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armControllerView.Location = new System.Drawing.Point(6, 6);
            this.armControllerView.Name = "armControllerView";
            this.armControllerView.Size = new System.Drawing.Size(792, 366);
            this.armControllerView.TabIndex = 0;
            // 
            // transporterControllerView
            // 
            this.transporterControllerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transporterControllerView.Location = new System.Drawing.Point(6, 6);
            this.transporterControllerView.Name = "transporterControllerView";
            this.transporterControllerView.Size = new System.Drawing.Size(792, 366);
            this.transporterControllerView.TabIndex = 0;
            // 
            // rotorControllerView
            // 
            this.rotorControllerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotorControllerView.Location = new System.Drawing.Point(6, 6);
            this.rotorControllerView.Name = "rotorControllerView";
            this.rotorControllerView.Size = new System.Drawing.Size(792, 366);
            this.rotorControllerView.TabIndex = 0;
            // 
            // loadControllerView
            // 
            this.loadControllerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadControllerView.Location = new System.Drawing.Point(6, 6);
            this.loadControllerView.Name = "loadControllerView";
            this.loadControllerView.Size = new System.Drawing.Size(792, 366);
            this.loadControllerView.TabIndex = 0;
            // 
            // pompControllerView
            // 
            this.pompControllerView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pompControllerView.Location = new System.Drawing.Point(6, 6);
            this.pompControllerView.Name = "pompControllerView";
            this.pompControllerView.Size = new System.Drawing.Size(792, 366);
            this.pompControllerView.TabIndex = 0;
            // 
            // additionalMovesView
            // 
            this.additionalMovesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalMovesView.Location = new System.Drawing.Point(6, 6);
            this.additionalMovesView.Name = "additionalMovesView";
            this.additionalMovesView.Size = new System.Drawing.Size(792, 366);
            this.additionalMovesView.TabIndex = 0;
            // 
            // demoExecutorView
            // 
            this.demoExecutorView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.demoExecutorView.Location = new System.Drawing.Point(6, 6);
            this.demoExecutorView.Name = "demoExecutorView";
            this.demoExecutorView.Size = new System.Drawing.Size(792, 366);
            this.demoExecutorView.TabIndex = 0;
            // 
            // logView
            // 
            this.logView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logView.Location = new System.Drawing.Point(3, 3);
            this.logView.Name = "logView";
            this.logView.Size = new System.Drawing.Size(905, 139);
            this.logView.TabIndex = 13;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
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
            this.splitContainer1.Size = new System.Drawing.Size(911, 571);
            this.splitContainer1.SplitterDistance = 422;
            this.splitContainer1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 628);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
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
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.sensorsTabPage.ResumeLayout(false);
            this.cncTabPage.ResumeLayout(false);
            this.armTabPage.ResumeLayout(false);
            this.tranporterTabPage.ResumeLayout(false);
            this.rotorTabPage.ResumeLayout(false);
            this.loadTabPage.ResumeLayout(false);
            this.pompTabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private Views.SteppersGridView steppersGridView;
        private Views.LogView logView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonUpdateList;
        private System.Windows.Forms.ToolStripComboBox selectPort;
        private System.Windows.Forms.ToolStripButton buttonConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonShowControlPanel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage devicesTabPage;
        private System.Windows.Forms.TabPage cncTabPage;
        private Views.CNCView cncView;
        private System.Windows.Forms.ToolStripComboBox editBaudrate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Views.DevicesControlView devicesControlView;
        private System.Windows.Forms.TabPage armTabPage;
        private System.Windows.Forms.TabPage rotorTabPage;
        private System.Windows.Forms.TabPage tranporterTabPage;
        private System.Windows.Forms.TabPage loadTabPage;
        private System.Windows.Forms.TabPage pompTabPage;
        private ControllersViews.ArmControllerView armControllerView;
        private System.Windows.Forms.ToolStripButton buttonAbortExecution;
        private ControllersViews.TransporterControllerView transporterControllerView;
        private ControllersViews.RotorControllerView rotorControllerView;
        private ControllersViews.LoadControllerView loadControllerView;
        private ControllersViews.PompControllerView pompControllerView;
        private System.Windows.Forms.TabPage tabPage1;
        private ControllersViews.AdditionalMovesView additionalMovesView;
        private System.Windows.Forms.ToolStripButton buttonStartDemo;
        private System.Windows.Forms.TabPage demoTabPage;
        private ControllersViews.DemoExecutorView demoExecutorView;
        private System.Windows.Forms.TabPage sensorsTabPage;
        private Views.SensorsView sensorsView;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

