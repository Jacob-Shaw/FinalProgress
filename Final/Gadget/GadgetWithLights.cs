using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadget
{
    public abstract class GadgetWithLights : GadgetAbstract
    {
        public abstract int NumberOfLights { get; set; }
    }
}
