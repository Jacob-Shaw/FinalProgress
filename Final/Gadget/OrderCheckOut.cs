using System;
using System.Collections.Generic;
using System.Text;
using Gadget;
using Widget;

namespace Gadget
{
    public class OrderCheckOut
    {
        ///  DisplayOrder used as a method call 
        ///This class will clear the screen and based on the gadget "sizeSelected" and "powerSelected" 
        ///display the contents 


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
                    Console.WriteLine("Number of Widgets.... " + mySmallGadget.NumberOfWidgets);
                    Console.WriteLine("             (each Widget has " + mySmallWidget.NumOfGears + " gears, "
                                                                       + mySmallWidget.NumOfSprings + " springs, and "
                                                                       + mySmallWidget.NumOfLevers + " lever)");
                    Console.WriteLine();
                    Console.WriteLine("Number of Switches... " + mySmallGadget.NumberOfSwitches);
                    Console.WriteLine("Number of Buttons.... " + mySmallGadget.NumberOfButtons);
                    //Console.WriteLine("Number of Lights..... " + mySmallGadget.NumberOfLights);
                    Console.WriteLine("Power Source......... " + mySmallGadget.PowerSource);
                    break;

                case "Medium":
                    Console.WriteLine();

                    GadgetMedium myMediumGadget = new GadgetMedium();
                    WidgetMedium myMediumWidget = new WidgetMedium();
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("------------------  Medium Gadget -------------------");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Number of Widgets.... " + myMediumGadget.NumberOfWidgets);
                    Console.WriteLine("             (each Widget has " + myMediumWidget.NumOfGears + " gears, "
                                                                       + myMediumWidget.NumOfSprings + " springs, and "
                                                                       + myMediumWidget.NumOfLevers + " levers)");
                    Console.WriteLine();
                    Console.WriteLine("Number of Switches... " + myMediumGadget.NumberOfSwitches);
                    Console.WriteLine("Number of Buttons.... " + myMediumGadget.NumberOfButtons);
                    Console.WriteLine("Number of Lights..... " + myMediumGadget.NumberOfLights);
                    //Console.WriteLine("Power Source......... " + myMediumGadget.PowerSource); //(backup)
                    Console.WriteLine("Power Source......... " + myMediumGadget.PowerSource);
                    break;

                case "Large":
                    Console.WriteLine();

                    GadgetLarge myLargeGadget = new GadgetLarge();
                    WidgetLarge myLargeWidget = new WidgetLarge();
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("-------------------  Large Gadget -------------------");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Number of Widgets.... " + myLargeGadget.NumberOfWidgets);
                    Console.WriteLine("             (each Widget has " + myLargeWidget.NumOfGears + " gears, "
                                                                       + myLargeWidget.NumOfSprings + " springs, and "
                                                                       + myLargeWidget.NumOfLevers + " levers)");
                    Console.WriteLine("Number of Switches... " + myLargeGadget.NumberOfSwitches);
                    Console.WriteLine("Number of Buttons.... " + myLargeGadget.NumberOfButtons);
                    Console.WriteLine("Number of Lights..... " + myLargeGadget.NumberOfLights);
                    //Console.WriteLine("Power Source......... " + myLargeGadget.PowerSource); //(backup)
                    Console.WriteLine("Power Source......... " + myLargeGadget.PowerSource);
                    break;
            }
        }
    }
}
