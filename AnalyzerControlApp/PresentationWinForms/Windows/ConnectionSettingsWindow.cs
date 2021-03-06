﻿using AnalyzerService;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationWinForms.Forms
{
    public partial class ConnectionSettingsWindow : Form
    {
        private Analyzer analyzer;

        public ConnectionSettingsWindow()
        {
            InitializeComponent();
        }

        public void Init(Analyzer analyzer)
        {
            this.analyzer = analyzer;
            
            updateControlsState();
            updateFromSavedPreferences();
            rescanOpenPorts();
        }

        private void buttonUpdatePorts_Click(object sender, EventArgs e)
        {
            rescanOpenPorts();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (Analyzer.Serial.IsOpen()) {
                Analyzer.Serial.Close();
                // Тут останавливалось обновление таблиц

                rescanOpenPorts();
            } else {
                string portName = selectPort.SelectedItem.ToString();
                int baudrate = int.Parse(selectBaudrate.SelectedItem.ToString());

                if (Analyzer.Serial.Open(portName, baudrate)) {
                    Logger.Debug("Открытие подключения - подключение к " + portName + " открыто");

                    // Тут запускалось обновление таблиц
                } else {
                    Logger.Debug("Открытие подключения - Ошибка при подключении!");
                }
            }

            updateControlsState();
        }

        private void rescanOpenPorts()
        {
            selectPort.Items.Clear();

            String[] portsNames = Analyzer.Serial.GetAvailablePorts();

            if (portsNames.Length != 0)
            {
                selectPort.Items.AddRange(portsNames);
                Logger.Debug("Поиск портов - найдены открытые порты");
                selectPort.SelectedIndex = 0;
            }
            else
            {
                Logger.Debug("Поиск портов - открытых портов не найдено");
                selectPort.SelectedText = "";
            }

            buttonConnect.Visible = (portsNames.Length != 0);
            selectBaudrate.SelectedIndex = selectBaudrate.Items.Count - 1;
        }

        private void updateControlsState()
        {
            UpdateStatusState();

            buttonUpdatePorts.Visible = !Analyzer.Serial.IsOpen();
            selectPort.Enabled = !Analyzer.Serial.IsOpen();
            selectBaudrate.Enabled = !Analyzer.Serial.IsOpen();
        }

        private void UpdateStatusState()
        {
            if (Analyzer.Serial.IsOpen())
            {
                buttonConnect.Text = "Отключение";
                connectionStatus.Text = $"Установленно соединение с { Analyzer.Serial.PortName }.";
                connectionStatus.ForeColor = Color.DarkGreen;
            }
            else
            {
                buttonConnect.Text = "Подключение";
                connectionStatus.Text = "Соединение не установлено.";
                connectionStatus.ForeColor = Color.Brown;
            }
        }

        private void buttonSavePreferences_Click(object sender, EventArgs e)
        {
            // Здесь нужно выполнить сохранение выбранных настроек подключения
            string portName = selectPort.SelectedItem.ToString();
            int baudrate = int.Parse(selectBaudrate.SelectedItem.ToString());

            analyzer.Options.PortName = portName;
            analyzer.Options.Baudrate = baudrate;

            analyzer.SaveConfiguration("AnalyzerServiceConfiguration");

            updateFromSavedPreferences();
        }

        private void updateFromSavedPreferences()
        {
            savedPort.Text = analyzer.Options.PortName;
            savedBaudrate.Text = analyzer.Options.Baudrate.ToString();
        }
    }
}
