using cu_interfaces.LIB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cu_interfaces.LIB.Klassen
{
    public class Radio : ElektrischToestel ,IPower, IVolume,ICheckBroadCastConnection
    {

        public bool IsOn { get; set; }
        public int CurrentVolume { get; private set; } = 50;

        public Radio(string livingRoom) : base(livingRoom)
        {

        }

        public string PowerOff()
        {
            IsOn = false;
            return $"Radio {LivingRoom} is uit";
        }

        public string PowerOn()
        {
            IsOn = true;
            return $"Radio {LivingRoom} is aan";
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
            CurrentVolume -= 10;
            if(CurrentVolume < 0)
            {
                CurrentVolume = 0;
            }
        }

        static Random rnd = new Random();
        private bool IsFmWorking()
        {
            int trueOrFalse = rnd.Next(2);
            return Convert.ToBoolean(trueOrFalse);
        }

        private bool IsAntennaExtended()
        {
            int trueOrFalse = rnd.Next(2);
            return Convert.ToBoolean(trueOrFalse);
        }

        public string CheckBroadCastConnection()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"======Testing {this.GetType().Name} {LivingRoom}======");
            stringBuilder.AppendLine("Is antenna extened? Checking antenna.\nPlease wait.");
            stringBuilder.AppendLine($"Antenna  test returns {IsAntennaExtended()}");

            stringBuilder.AppendLine("Is FM working? Checking FM.\nPlease wait.");
            stringBuilder.AppendLine($"Fm  test returns {IsFmWorking()}");
            stringBuilder.AppendLine($"===End of test {this.GetType().Name}{LivingRoom}==={Environment.NewLine}");

            return stringBuilder.ToString();

        }
    }
}
