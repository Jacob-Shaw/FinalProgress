using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAG;
using FINAL;
using Widget;

namespace Gadget
{
    /// <summary>
    /// This abstract class describes what a basic Gadget "is".
    /// It can include fields, properties and methods.
    /// It can not be instantiated. No object can be directly created from it.
    /// </summary>
    
    public abstract class GadgetAbstract : IGadget, IWagProduct
    {
        //Making these abstract will force the developer to create the 
        //  inheriting classes with thought to it's construction
        public abstract string Name { get; }
        public abstract string PowerSource { get; set; }
        public abstract int NumberOfSmallWidgets { get; set; }
        public abstract int NumberOfMediumWidgets { get; set; }
        public abstract int NumberOfSwitches { get; set; }  
        public abstract int NumberOfButtons { get; set; }

        
        //Methods
        public virtual void DisplayComponents()
        {
            Console.WriteLine("Small Widgets: " + this.NumberOfSmallWidgets);
            Console.WriteLine("Medium Widgets: " + this.NumberOfMediumWidgets);
            Console.WriteLine("Swithes: " + this.NumberOfSwitches);
            Console.WriteLine("Buttons: " + this.NumberOfButtons);
            Console.WriteLine("PowerSource: " + this.PowerSource);
        }

        // There is a default for calculating the total number of 
        //  Widgets so making it virtual allows the developer to change it
        //  while letting it default to the set calculation without the
        //  developer being prompted to provide a necessary override
        public virtual int GetNumberOfWidgetsTotal()
        {
            return ( NumberOfSmallWidgets + NumberOfMediumWidgets );
        }

        public virtual void DisplayName()
        {
            Console.WriteLine(Name);
        }

        public virtual decimal GetPrice()
        {
            WidgetSmall SmallWidgetPrice = new WidgetSmall();
            WidgetMedium MediumWidgetPrice = new WidgetMedium();


            return ((NumberOfSmallWidgets * SmallWidgetPrice.GetPrice()) +
                       (NumberOfMediumWidgets * MediumWidgetPrice.GetPrice()) +
                       (NumberOfSwitches * ComponentPricing.SwitchCostPerUnit) +
                       (NumberOfButtons * ComponentPricing.ButtonCostPerUnit) +
                       (ComponentPricing.GetPowerSourcePrice(PowerSource)));
        }

        public virtual void DisplayPriceDollars()
        {
            Console.WriteLine("$" + this.GetPrice());
        }
    }
}
