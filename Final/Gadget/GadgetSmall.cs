using System;
using System.Collections.Generic;
using System.Text;
using WAG;
using Widget;
using Final;

namespace Gadget
{
    public class GadgetSmall : GadgetAbstract
    {
        public override string Name { get { return "Small Gadget"; } }

        public override int NumberOfSmallWidgets { get; set; } = 1;
        public override int NumberOfMediumWidgets { get; set; } = 1;
        public override int NumberOfSwitches { get; set; } = 1;
        public override int NumberOfButtons { get; set; } = 2;
        public override string PowerSource { get; set; } = "Battery";
    }
}
