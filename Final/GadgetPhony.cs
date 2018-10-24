using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadget

{
    class GadgetPhony : GadgetAbstract
    {
        public override string Name { get { return "Phony Gadget"; } }

        public override int NumberOfSmallWidgets { get; set; } = 1;
        public override int NumberOfMediumWidgets { get; set; } = 1;
        public override int NumberOfSwitches { get; set; } = 1;
        public override int NumberOfButtons { get; set; } = 2;
        public override string PowerSource { get; set; } = "Quantum";
    }
}
