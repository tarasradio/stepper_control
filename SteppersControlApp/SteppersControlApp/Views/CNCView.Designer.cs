﻿namespace SteppersControlApp.Views
{
    partial class CNCView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CNCView));
            this.programTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.buttonAbortExecution = new System.Windows.Forms.Button();
            this.buttonRunExecution = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonClearFile = new System.Windows.Forms.Button();
            this.buttonTestFile = new System.Windows.Forms.Button();
            this.CNCViewToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.executionProgressBar = new System.Windows.Forms.ProgressBar();
            this.executionStatusLabel = new System.Windows.Forms.Label();
            this.executionProgressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.programTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // programTextBox
            // 
            this.programTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.programTextBox.AutoScrollMinSize = new System.Drawing.Size(267, 14);
            this.programTextBox.BackBrush = null;
            this.programTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.programTextBox.CharHeight = 14;
            this.programTextBox.CharWidth = 8;
            this.programTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.programTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.programTextBox.IsReplaceMode = false;
            this.programTextBox.Location = new System.Drawing.Point(3, 53);
            this.programTextBox.Name = "programTextBox";
            this.programTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.programTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.programTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("programTextBox.ServiceColors")));
            this.programTextBox.Size = new System.Drawing.Size(855, 329);
            this.programTextBox.TabIndex = 5;
            this.programTextBox.Text = "// ВВЕДИТЕ КОД ПРОГРАММЫ ЗДЕСЬ";
            this.programTextBox.Zoom = 100;
            this.programTextBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.ProgramTextBox_TextChanged);
            // 
            // buttonAbortExecution
            // 
            this.buttonAbortExecution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbortExecution.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAbortExecution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbortExecution.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbortExecution.Image")));
            this.buttonAbortExecution.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAbortExecution.Location = new System.Drawing.Point(814, 3);
            this.buttonAbortExecution.Name = "buttonAbortExecution";
            this.buttonAbortExecution.Size = new System.Drawing.Size(44, 44);
            this.buttonAbortExecution.TabIndex = 38;
            this.CNCViewToolTip.SetToolTip(this.buttonAbortExecution, "Прервать выполнение");
            this.buttonAbortExecution.UseVisualStyleBackColor = false;
            this.buttonAbortExecution.Click += new System.EventHandler(this.buttonAbortExecution_Click);
            // 
            // buttonRunExecution
            // 
            this.buttonRunExecution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunExecution.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRunExecution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRunExecution.Image = ((System.Drawing.Image)(resources.GetObject("buttonRunExecution.Image")));
            this.buttonRunExecution.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRunExecution.Location = new System.Drawing.Point(764, 3);
            this.buttonRunExecution.Name = "buttonRunExecution";
            this.buttonRunExecution.Size = new System.Drawing.Size(44, 44);
            this.buttonRunExecution.TabIndex = 39;
            this.CNCViewToolTip.SetToolTip(this.buttonRunExecution, "Запуск программы");
            this.buttonRunExecution.UseVisualStyleBackColor = false;
            this.buttonRunExecution.Click += new System.EventHandler(this.buttonRunProgram_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOpenFile.Location = new System.Drawing.Point(53, 3);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(44, 44);
            this.buttonOpenFile.TabIndex = 40;
            this.CNCViewToolTip.SetToolTip(this.buttonOpenFile, "Открыть файл");
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile.Image")));
            this.buttonSaveFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSaveFile.Location = new System.Drawing.Point(103, 3);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(44, 44);
            this.buttonSaveFile.TabIndex = 41;
            this.CNCViewToolTip.SetToolTip(this.buttonSaveFile, "Сохранить файл");
            this.buttonSaveFile.UseVisualStyleBackColor = false;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonClearFile
            // 
            this.buttonClearFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClearFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonClearFile.Image")));
            this.buttonClearFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClearFile.Location = new System.Drawing.Point(3, 3);
            this.buttonClearFile.Name = "buttonClearFile";
            this.buttonClearFile.Size = new System.Drawing.Size(44, 44);
            this.buttonClearFile.TabIndex = 42;
            this.CNCViewToolTip.SetToolTip(this.buttonClearFile, "Очистить файл");
            this.buttonClearFile.UseVisualStyleBackColor = false;
            this.buttonClearFile.Click += new System.EventHandler(this.buttonClearFile_Click);
            // 
            // buttonTestFile
            // 
            this.buttonTestFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTestFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTestFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonTestFile.Image")));
            this.buttonTestFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTestFile.Location = new System.Drawing.Point(153, 3);
            this.buttonTestFile.Name = "buttonTestFile";
            this.buttonTestFile.Size = new System.Drawing.Size(44, 44);
            this.buttonTestFile.TabIndex = 43;
            this.CNCViewToolTip.SetToolTip(this.buttonTestFile, "Проверить программу");
            this.buttonTestFile.UseVisualStyleBackColor = false;
            this.buttonTestFile.Click += new System.EventHandler(this.buttonTestProgram_Click);
            // 
            // executionProgressBar
            // 
            this.executionProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.executionProgressBar.Location = new System.Drawing.Point(3, 401);
            this.executionProgressBar.Name = "executionProgressBar";
            this.executionProgressBar.Size = new System.Drawing.Size(855, 23);
            this.executionProgressBar.Step = 1;
            this.executionProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.executionProgressBar.TabIndex = 44;
            // 
            // executionStatusLabel
            // 
            this.executionStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.executionStatusLabel.AutoSize = true;
            this.executionStatusLabel.Location = new System.Drawing.Point(3, 385);
            this.executionStatusLabel.Name = "executionStatusLabel";
            this.executionStatusLabel.Size = new System.Drawing.Size(168, 13);
            this.executionStatusLabel.TabIndex = 45;
            this.executionStatusLabel.Text = "Статус выполнения программы";
            // 
            // executionProgressLabel
            // 
            this.executionProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.executionProgressLabel.Location = new System.Drawing.Point(557, 385);
            this.executionProgressLabel.Name = "executionProgressLabel";
            this.executionProgressLabel.Size = new System.Drawing.Size(301, 13);
            this.executionProgressLabel.TabIndex = 46;
            this.executionProgressLabel.Text = "Сколько выполнено команд";
            this.executionProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CNCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.executionProgressLabel);
            this.Controls.Add(this.executionStatusLabel);
            this.Controls.Add(this.executionProgressBar);
            this.Controls.Add(this.buttonTestFile);
            this.Controls.Add(this.buttonClearFile);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonRunExecution);
            this.Controls.Add(this.buttonAbortExecution);
            this.Controls.Add(this.programTextBox);
            this.Name = "CNCView";
            this.Size = new System.Drawing.Size(861, 427);
            ((System.ComponentModel.ISupportInitialize)(this.programTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox programTextBox;
        private System.Windows.Forms.Button buttonAbortExecution;
        private System.Windows.Forms.Button buttonRunExecution;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonClearFile;
        private System.Windows.Forms.Button buttonTestFile;
        private System.Windows.Forms.ToolTip CNCViewToolTip;
        private System.Windows.Forms.ProgressBar executionProgressBar;
        private System.Windows.Forms.Label executionStatusLabel;
        private System.Windows.Forms.Label executionProgressLabel;
    }
}
