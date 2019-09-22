﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SteppersControlCore.CommunicationProtocol;
using SteppersControlCore.CommunicationProtocol.AdditionalCommands;
using SteppersControlCore.CommunicationProtocol.CncCommands;
using SteppersControlCore.CommunicationProtocol.StepperCommands;

using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;

namespace SteppersControlCore.Controllers
{
    public class TransporterControllerPropetries
    {
        [Category("1. Двигатели")]
        [DisplayName("Двигатель вращения пробирки")]
        public int TurnTubeStepper { get; set; } = 5;
        [Category("1. Двигатели")]
        [DisplayName("Двигатель движения пробирок")]
        public int TransporterStepper { get; set; } = 6;

        [Category("2. Шаги")]
        [DisplayName("Шагов для сдвига на одну пробирку")]
        public int StepsOneTube { get; set; } = 6400;
        [Category("2. Шаги")]
        [DisplayName("Шагов для вращения пробирки")]
        public int StepsToTurnTube { get; set; } = 10000;

        [Category("3. Скорость")]
        [DisplayName("Скорость вращения пробирки")]
        public int SpeedToTurnTube { get; set; } = 30;

        public TransporterControllerPropetries()
        {

        }
    }

    public class TransporterController : Controller
    {
        string filename = "TransporterControllerProps.xml";
        public TransporterControllerPropetries Props { get; set; }

        public TransporterController() : base()
        {
            Props = new TransporterControllerPropetries();
        }

        public void WriteXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(TransporterControllerPropetries));

            TextWriter writer = new StreamWriter(filename);
            ser.Serialize(writer, Props);
            writer.Close();
        }

        //Чтение насроек из файла
        public void ReadXml()
        {
            if (File.Exists(filename))
            {
                XmlSerializer ser = new XmlSerializer(typeof(TransporterControllerPropetries));
                TextReader reader = new StreamReader(filename);
                Props = ser.Deserialize(reader) as TransporterControllerPropetries;
                reader.Close();
            }
            else
            {
                //можно написать вывод сообщения если файла не существует
            }
        }

        public List<IAbstractCommand> PrepareBeforeScanning()
        {
            List<IAbstractCommand> commands = new List<IAbstractCommand>();
            
            commands.Add(new SetSpeedCommand(Props.TransporterStepper, 100));

            // Обнуление ленты конвеера
            steppers = new Dictionary<int, int>() { { Props.TransporterStepper, 50 } };
            commands.Add(new HomeCncCommand(steppers));

            // Сдвиг на пол пробирки
            steppers = new Dictionary<int, int>() { { Props.TransporterStepper, Props.StepsOneTube / 2 } };
            commands.Add(new MoveCncCommand(steppers));

            return commands;
        }

        public enum ShiftType
        {
            HalfTube,
            OneTube
        };

        // Сдвиг
        public List<IAbstractCommand> Shift(bool reverse, ShiftType shiftType = ShiftType.OneTube)
        {
            List<IAbstractCommand> commands = new List<IAbstractCommand>();
            
            commands.Add(new SetSpeedCommand(Props.TransporterStepper, 50));

            int steps = Props.StepsOneTube;

            if (shiftType == ShiftType.HalfTube) steps /= 2;
            if (reverse) steps *= -1;

            steppers = new Dictionary<int, int>() { { Props.TransporterStepper, steps } };
            commands.Add(new MoveCncCommand(steppers));

            return commands;
        }

        public List<IAbstractCommand> TurnAndScanTube()
        {
            List<IAbstractCommand> commands = new List<IAbstractCommand>();
            
            // Сканирование пробирки
            commands.Add(new BarStartCommand());

            // Вращение пробирки
            commands.Add(new SetSpeedCommand(Props.TurnTubeStepper, (uint)Props.SpeedToTurnTube));

            steppers = new Dictionary<int, int>() { { Props.TurnTubeStepper, Props.StepsToTurnTube } };
            commands.Add(new MoveCncCommand(steppers));

            return commands;
        }
    }
}
