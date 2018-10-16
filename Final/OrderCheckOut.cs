using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    public class OrderCheckOut
    {
        public void DisplayOrder(string sizeSelected, string powerSelected)
        {
            Console.Clear();

            switch (sizeSelected)
            {
                case "Small":
                    Console.WriteLine(" ");

                    GadgetSmall mySmallGadget = new GadgetSmall();
                    WidgetSmall mySmallWidget = new WidgetSmall();
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("-------------------  Small Gadget -------------------");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Number of Widgets.... " + mySmallGadget.NumOfWidgets);
                    Console.WriteLine("(each Widget has " + mySmallWidget.NumOfGears + " gears, "
                                                                       + mySmallWidget.NumOfSprings + " springs, and "
                                                                       + mySmallWidget.NumOfLevers + " lever)");
                    Console.WriteLine();
                    Console.WriteLine("Number of Switches... " + mySmallGadget.NumOfSwitches);
                    Console.WriteLine("Number of Buttons.... " + mySmallGadget.NumOfButtons);
                    Console.WriteLine("Number of Lights..... " + mySmallGadget.NumOfLights);
                    Console.WriteLine("Power Source......... " + mySmallGadget.PowerSource);
                    break;

                case "Medium":
                    Console.WriteLine();

                    GadgetMedium myMediumGadget = new GadgetMedium();
                    WidgetMedium myMediumWidget = new WidgetMedium();
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("------------------  Medium Gadget -------------------");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Number of Widgets.... " + myMediumGadget.NumOfWidgets);
                    Console.WriteLine("(each Widget has " + myMediumWidget.NumOfGears + " gears, "
                                                                       + myMediumWidget.NumOfSprings + " springs, and "
                                                                       + myMediumWidget.NumOfLevers + " levers)");
                    Console.WriteLine();
                    Console.WriteLine("Number of Switches... " + myMediumGadget.NumOfSwitches);
                    Console.WriteLine("Number of Buttons.... " + myMediumGadget.NumOfButtons);
                    Console.WriteLine("Number of Lights..... " + myMediumGadget.NumOfLights);
                    //Console.WriteLine("Power Source......... " + myMediumGadget.PowerSource); //(backup)
                    Console.WriteLine("Power Source......... " + myMediumGadget.ReturnPowerSource(powerSelected));
                    break;

                case "Large":
                    Console.WriteLine();

                    GadgetLarge myLargeGadget = new GadgetLarge();
                    WidgetLarge myLargeWidget = new WidgetLarge();
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("-------------------  Large Gadget -------------------");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Number of Widgets.... " + myLargeGadget.NumOfWidgets);
                    Console.WriteLine();
                    Console.WriteLine("(each Widget has " + myLargeWidget.NumOfGears + " gears, "
                                                                       + myLargeWidget.NumOfSprings + " springs, and "
                                                                       + myLargeWidget.NumOfLevers + " levers)");
                    Console.WriteLine("Number of Switches... " + myLargeGadget.NumOfSwitches);
                    Console.WriteLine("Number of Buttons.... " + myLargeGadget.NumOfButtons);
                    Console.WriteLine("Number of Lights..... " + myLargeGadget.NumOfLights);
                    //Console.WriteLine("Power Source......... " + myLargeGadget.PowerSource); //(backup)
                    Console.WriteLine("Power Source......... " + myLargeGadget.ReturnPowerSource(powerSelected));
                    break;
            }
        }
    }
}
