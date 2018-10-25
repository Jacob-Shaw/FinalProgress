using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAG;
using Final;
using Widget;

namespace Gadget
{
    /// <summary>
    /// This abstract class describes what a basic Gadget "is".
    /// It can include fields, properties and methods.
    /// It can not be instantiated. No object can be directly created from it.
    /// </summary>
    
    public abstract class GadgetAbstract : IGadget
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
            // These are used to get the #of components (gears, springs, levers)
            WidgetSmall SmallWidget = new WidgetSmall();
            WidgetMedium MediumWidget = new WidgetMedium();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Number of Small Widgets: ");
            Console.CursorLeft = 30;
            Console.WriteLine( this.NumberOfSmallWidgets );
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("      Composed of:");

            Console.CursorLeft = 4;
            Console.Write("# of Gears....." + SmallWidget.NumOfGears + "\n");
            Console.CursorLeft = 5;
            Console.Write("# of Springs.." + SmallWidget.NumOfSprings + "\n");
            Console.CursorLeft = 6;
            Console.Write("# of Levers.." + SmallWidget.NumOfLevers + "\n");
            Console.WriteLine();
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Number of Medium Widgets: ");
            Console.CursorLeft = 30;
            Console.WriteLine( this.NumberOfMediumWidgets );
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("      Composed of:");

            
            Console.CursorLeft = 4;
            Console.Write("# of Gears....." + MediumWidget.NumOfGears + "\n");
            Console.CursorLeft = 5;
            Console.Write("# of Springs.." + MediumWidget.NumOfSprings + "\n");
            Console.CursorLeft = 6;
            Console.Write("# of Levers.." + MediumWidget.NumOfLevers + "\n");
            Console.WriteLine();
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Number of Switches: ");
            Console.CursorLeft = 30;
            Console.WriteLine( this.NumberOfSwitches );
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Number of Buttons: ");
            Console.CursorLeft = 30;
            Console.WriteLine( this.NumberOfButtons );
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Power Source: ");
            Console.CursorLeft = 30;
            Console.WriteLine( this.PowerSource );
            Console.ForegroundColor = ConsoleColor.White;

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
