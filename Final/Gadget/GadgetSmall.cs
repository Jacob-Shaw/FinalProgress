using System;
using System.Collections.Generic;
using System.Text;
using WAG;

namespace Gadget
{
    public class GadgetSmall : GadgetAbstract, IWagProduct
    {
        public override string Name { get { return "Small Gadget"; } }

        public override int NumberOfWidgets { get; set; } = 2;
        public override int NumberOfSwitches { get; set; } = 1;
        public override int NumberOfButtons { get; set; } = 2;
        public override string PowerSource { get; set; } = "Battery";
        
        public override decimal Price { get { return 25.00m; } set { } }
    }
}
