using cu_interfaces.LIB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cu_interfaces.LIB.Klassen
{
    public class Radio : ElektrischToestel ,IPower
    {

        public bool IsOn { get; set; }
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
    }
}
