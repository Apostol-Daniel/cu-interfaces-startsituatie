using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cu_interfaces.LIB.Interfaces;

namespace cu_interfaces.LIB.Klassen
{
    public class Televisie : ElektrischToestel, IPower
    {
        public bool IsOn { get; set; }

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
    }
}
