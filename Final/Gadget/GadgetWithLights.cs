using FINAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Widget;

namespace Gadget
{
    public abstract class GadgetWithLights : GadgetAbstract
    {
        public abstract int NumberOfLargeWidgets { get; set; }
        public abstract int NumberOfLights { get; set; }

        // Using "new" with virtual to override GadgetAbstract definition and allow for classes
        //      that extend this one to override
        public new virtual void DisplayComponents()
        {
            Console.WriteLine("Small Widgets: " + this.NumberOfSmallWidgets);
            Console.WriteLine("Medium Widgets: " + this.NumberOfMediumWidgets);
            Console.WriteLine("Large Widgets: " + this.NumberOfLargeWidgets);
            Console.WriteLine("Swithes: " + this.NumberOfSwitches);
            Console.WriteLine("Buttons: " + this.NumberOfButtons);
            Console.WriteLine("Lights: " + this.NumberOfLights);
            Console.WriteLine("PowerSource: " + this.PowerSource);
        }
        
        public new virtual int GetNumberOfWidgetsTotal()
        {
            return ( NumberOfSmallWidgets + NumberOfMediumWidgets + NumberOfLargeWidgets );
        }

        public new virtual decimal GetPrice()
        {
            WidgetSmall SmallWidgetPrice = new WidgetSmall();
            WidgetMedium MediumWidgetPrice = new WidgetMedium();
            WidgetLarge LargeWidgetPrice = new WidgetLarge();

            return ((NumberOfSmallWidgets * SmallWidgetPrice.GetPrice()) +
                       (NumberOfMediumWidgets * MediumWidgetPrice.GetPrice()) +
                       (NumberOfLargeWidgets * LargeWidgetPrice.GetPrice()) +
                       (NumberOfSwitches * ComponentPricing.SwitchCostPerUnit) +
                       (NumberOfButtons * ComponentPricing.ButtonCostPerUnit) +
                       (NumberOfLights * ComponentPricing.LightCostPerUnit) +
                       (ComponentPricing.GetPowerSourcePrice(PowerSource)));
        }

        //Even though this method looks the same as the GadgetAbstract implementation,
        //  it is necessary to override it so it will point to this class' implementation with "new"
        public new virtual void DisplayPriceDollars()
        {
            Console.WriteLine("$" + this.GetPrice());
        }
    }
}
