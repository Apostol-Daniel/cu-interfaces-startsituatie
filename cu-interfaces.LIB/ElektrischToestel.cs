using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cu_interfaces.LIB
{
    public abstract class ElektrischToestel
    {
        public string LivingRoom { get; private set; }

        public ElektrischToestel(string livingRoom)
        {
            LivingRoom = livingRoom;
        }
    }
}
