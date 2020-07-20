using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cu_interfaces.LIB.Interfaces;

namespace cu_interfaces.LIB.Klassen
{
    public class Televisie : ElektrischToestel, IPower,IVolume,ICheckBroadCastConnection
    {
        public bool IsOn { get; set; }
        public int CurrentVolume { get; private set; } = 50;

        public Televisie(string livingRoom) : base(livingRoom)
        {

        }

        public string PowerOff()
        {
            IsOn = false;
            return $"Tv {LivingRoom} is uit";
        }

        public string PowerOn()
        {
            IsOn = true;
            return $"Tv {LivingRoom} is aan";
        }

        public void VolumeUp()
        {
            CurrentVolume += 10;
            if(CurrentVolume > 100)
            {
                CurrentVolume = 100;
            }
        }

        public void VolumeDown()
        {
            CurrentVolume += -10;
            if(CurrentVolume < 0)
            {
                CurrentVolume = 0;
            }
        }

        static Random rnd = new Random();

        private bool IsCoaxCableConnected()
        {
            int trueOrFalse = rnd.Next(2);
            return Convert.ToBoolean(trueOrFalse);
        }

        private bool IsSignalAvailable() 
        {
            int trueOfFalse = rnd.Next(2);
            return Convert.ToBoolean(trueOfFalse);
        }
        
        private bool IsSignalStrengthOK()
        {
            int trueOrFalse = rnd.Next(20);
            return Convert.ToBoolean(trueOrFalse);
        }

        public string CheckBroadCastConnection()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"======Testing {this.GetType().Name} {LivingRoom}======");
            stringBuilder.AppendLine("Is COAX connected? Checking connection.\nPlease wait.");
            stringBuilder.AppendLine($"COAX test returns {IsCoaxCableConnected()}{Environment.NewLine}");

            stringBuilder.AppendLine("Is signal available? Checking sigal.\nPlease wait.");
            stringBuilder.AppendLine($"Signal test return {IsSignalAvailable()}");
            stringBuilder.AppendLine($"Signal strenght test returns {IsSignalStrengthOK()}");
            stringBuilder.AppendLine($"===End of test {this.GetType().Name}{LivingRoom}==={Environment.NewLine}");

            return stringBuilder.ToString();
        }
    }
}
