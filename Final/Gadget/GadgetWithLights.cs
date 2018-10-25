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
            WidgetSmall SmallWidget = new WidgetSmall();
            WidgetMedium MediumWidget = new WidgetMedium();
            WidgetLarge LargeWidget = new WidgetLarge();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Number of Small Widgets: ");
            Console.CursorLeft = 30;
            Console.WriteLine(this.NumberOfSmallWidgets);
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
            Console.WriteLine(this.NumberOfMediumWidgets);
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
            Console.Write("Number of Large Widgets: ");
            Console.CursorLeft = 30;
            Console.WriteLine(this.NumberOfLargeWidgets);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("      Composed of:");


            Console.CursorLeft = 4;
            Console.Write("# of Gears....." + LargeWidget.NumOfGears + "\n");
            Console.CursorLeft = 5;
            Console.Write("# of Springs.." + LargeWidget.NumOfSprings + "\n");
            Console.CursorLeft = 6;
            Console.Write("# of Levers.." + LargeWidget.NumOfLevers + "\n");
            Console.WriteLine();
            Console.WriteLine();
            

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Number of Switches: ");
            Console.CursorLeft = 30;
            Console.WriteLine(this.NumberOfSwitches);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Number of Buttons: ");
            Console.CursorLeft = 30;
            Console.WriteLine(this.NumberOfButtons);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Number of Lights: ");
            Console.CursorLeft = 30;
            Console.WriteLine(this.NumberOfLights);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Power Source: ");
            Console.CursorLeft = 30;
            Console.WriteLine(this.PowerSource);
            Console.ForegroundColor = ConsoleColor.White;
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
