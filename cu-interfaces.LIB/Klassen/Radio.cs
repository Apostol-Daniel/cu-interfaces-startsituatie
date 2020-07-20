using cu_interfaces.LIB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cu_interfaces.LIB.Klassen
{
    public class Radio : ElektrischToestel ,IPower, IVolume
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
            if(CurrentVolume > 100)
            {
                CurrentVolume = 100;
            }
        }

        public void VolumeDown()
        {
            if(CurrentVolume < 0)
            {
                CurrentVolume = 0;
            }
        }
    }
}
