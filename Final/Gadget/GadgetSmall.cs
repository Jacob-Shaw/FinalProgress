using System;
using System.Collections.Generic;
using System.Text;
using WAG;
using Widget;
using FINAL;

namespace Gadget
{
    public class GadgetSmall : GadgetAbstract, IWagProduct
    {
        public override string Name { get { return "Small Gadget"; } }

        public override int NumberOfSmallWidgets { get; set; } = 1;
        public override int NumberOfMediumWidgets { get; set; } = 1;
        public override int NumberOfSwitches { get; set; } = 1;
        public override int NumberOfButtons { get; set; } = 2;
        public override string PowerSource { get; set; } = "Battery";
        
        /*
        public override decimal GetPrice()
        {
            WidgetSmall SmallWidgetPrice = new WidgetSmall();
            WidgetMedium MediumWidgetPrice = new WidgetMedium();

            
            return ((NumberOfSmallWidgets * SmallWidgetPrice.GetPrice()) +
                       (NumberOfMediumWidgets * MediumWidgetPrice.GetPrice()) +
                       (NumberOfSwitches * ComponentPricing.SwitchCostPerUnit) +
                       (NumberOfButtons * ComponentPricing.ButtonCostPerUnit) +
                       (ComponentPricing.GetPowerSourcePrice(PowerSource)));
        }
        */
    }
}
