using System;
using System.Collections.Generic;
using System.Text;

namespace Gadget
{
    /// <summary>
    /// This is the concrete class GadgetSmall.
    /// 
    /// </summary>

    public class GadgetSmall : GadgetAbstract
    {
        /*
        private int _numOfWidgets = 2;
        private int _numOfSwitches = 1;
        private int _numOfButtons = 2;
        //private string _powerSource = "Battery";
        */

        public override string Name { get { return "Small Gadget"; } }

        public override int NumberOfWidgets { get; set; } = 2;
        public override int NumberOfSwitches { get; set; } = 1;
        public override int NumberOfButtons { get; set; } = 2;
        public override string PowerSource { get; set; } = "battery";
        
        public override decimal Price { get { return 25.00m; } set { } }
    }
}
