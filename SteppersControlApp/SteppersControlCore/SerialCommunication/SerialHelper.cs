﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;

using SteppersControlCore.Interfaces;

namespace SteppersControlCore.SerialCommunication
{
    public class SerialHelper : ISerialHelper
    {
        PackageReceiver _packageReceiver;

        SerialPort _serialPort;

        public SerialHelper(PackageReceiver packageReceiver)
        {
            _packageReceiver = packageReceiver;
            _serialPort = new SerialPort();
            _serialPort.DataReceived += Port_DataReceived;
        }

        public bool OpenConnection(string portName, int baudrate)
        {
            bool success = false;

            _serialPort = new SerialPort(portName);
            _serialPort.BaudRate = baudrate;
            _serialPort.DataBits = 8;
            _serialPort.DataReceived += Port_DataReceived;

            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.NewLine = "\r";

            try
            {
                _serialPort.Open();
            }
            catch (UnauthorizedAccessException)
            {
                Logger.AddMessage($"Ошибка при открытии порта {portName}");
            }


            if (_serialPort.IsOpen)
            {
                success = true;
            }

            return success;
        }

        public void Disconnect()
        {
            try
            {
                _serialPort.Close();
            }
            catch (System.IO.IOException)
            {
                Logger.AddMessage($"Ошибка при закрытии порта {_serialPort.PortName}");
            }
        }

        public void CloseConnection()
        {
            _serialPort.Close();
        }

        public bool IsConnected()
        {
            return _serialPort.IsOpen;
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buffer = new byte[_serialPort.BytesToRead];
            _serialPort.Read(buffer, 0, buffer.Length);
            _packageReceiver.FindPacket(buffer);
            //_packageReceiver.HandleData(buffer);
        }

        public void SendPacket(byte[] packet)
        {
            byte[] wrappedPacket = ByteStuffing.WrapPacket(packet);

            SendBytes(wrappedPacket);
        }

        private void SendBytes(byte[] bytes)
        {
            try
            {
                _serialPort.Write(bytes, 0, bytes.Length);
            }
            catch (Exception)
            {
                Logger.AddMessage("Ошибка записи в порт");
            }
        }

        public string[] GetAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }
    }
}
