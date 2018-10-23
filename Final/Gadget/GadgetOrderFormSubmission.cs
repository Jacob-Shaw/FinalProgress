using System;
using System.Collections.Generic;
using System.Text;
using Gadget;
using Widget;

namespace Gadget
{
    public class CompleteGadgetOrderForm
    {
        ///  
        ///This class will clear the screen and based on the gadget "sizeSelected" and "powerSelected" 
        ///display the contents of the current item to add to the Masterorderform


        public void DisplayOrder(int gadgetsOrdered, string sizeSelected, string powerSelected)
        {
            Console.Clear();

            switch (sizeSelected)
            {
                case "Small":
                    Console.WriteLine(" ");



                    ///This is where the creation of the gadget object occurs, so this
                    /// is where the construction information needs to be
                    GadgetSmall mySmallGadget = new GadgetSmall();




                    //Can keep this because it will not change
                    WidgetSmall mySmallWidget = new WidgetSmall();
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("-------------------  Small Gadget -------------------");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Number of Widgets.... " + mySmallGadget.GetNumberOfWidgetsTotal());
                    Console.WriteLine("             (each Widget has " + mySmallWidget.NumOfGears + " gears, "
                                                                       + mySmallWidget.NumOfSprings + " springs, and "
                                                                       + mySmallWidget.NumOfLevers + " lever)");
                    Console.WriteLine();
                    Console.WriteLine("Number of Switches... " + mySmallGadget.NumberOfSwitches);
                    Console.WriteLine("Number of Buttons.... " + mySmallGadget.NumberOfButtons);
                    //Console.WriteLine("Number of Lights..... " + mySmallGadget.NumberOfLights);
                    Console.WriteLine("Power Source......... " + mySmallGadget.PowerSource);


                    //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                    //My addition to this

                    //display the number of gadgets ordered for this addition to the masterorderform 
                    //display the cost of this addition
                    Console.WriteLine();
                    Console.WriteLine("Number of Small Gadgets ordering = " + gadgetsOrdered);
                    Console.WriteLine("Total Price of this item order: " + gadgetsOrdered * 1000);

             ///////////////////ask the user to confirm!!!!!!!!!!!!!
                    
             ////////////////add to order if yes then cs and MM, otherwise cs display Main Menu





                    break;

                case "Medium":
                    Console.WriteLine();




                    GadgetMedium myMediumGadget = new GadgetMedium();




                    //Can keep this because it will not change
                    WidgetMedium myMediumWidget = new WidgetMedium();
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("------------------  Medium Gadget -------------------");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Number of Widgets.... " + myMediumGadget.GetNumberOfWidgetsTotal());
                    Console.WriteLine("             (each Widget has " + myMediumWidget.NumOfGears + " gears, "
                                                                       + myMediumWidget.NumOfSprings + " springs, and "
                                                                       + myMediumWidget.NumOfLevers + " levers)");
                    Console.WriteLine();
                    Console.WriteLine("Number of Switches... " + myMediumGadget.NumberOfSwitches);
                    Console.WriteLine("Number of Buttons.... " + myMediumGadget.NumberOfButtons);
                    Console.WriteLine("Number of Lights..... " + myMediumGadget.NumberOfLights);
                    //Console.WriteLine("Power Source......... " + myMediumGadget.PowerSource); //(backup)
                    Console.WriteLine("Power Source......... " + myMediumGadget.PowerSource);
             



                    //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                    //My addition to this

                    //display the number of gadgets ordered for this addition to the masterorderform 
                    //display the cost of this addition
                    Console.WriteLine();
                    Console.WriteLine("Number of Medium Gadgets ordering = " + gadgetsOrdered);
                    Console.WriteLine("Total Price of this item order: " + gadgetsOrdered * 1000);

            ///////////////////ask the user to confirm!!!!!!!!!!!!!

             ////////////////add to order if yes then cs and MM, otherwise cs display Main Menu



                    break;




                case "Large":
                    Console.WriteLine();






                    //Create
                    GadgetLarge myLargeGadget = new GadgetLarge();

                    //Can keep this because it will not change
                    WidgetLarge myLargeWidget = new WidgetLarge();
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("-------------------  Large Gadget -------------------");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Number of Widgets.... " + myLargeGadget.GetNumberOfWidgetsTotal());
                    Console.WriteLine("             (each Widget has " + myLargeWidget.NumOfGears + " gears, "
                                                                       + myLargeWidget.NumOfSprings + " springs, and "
                                                                       + myLargeWidget.NumOfLevers + " levers)");
                    Console.WriteLine("Number of Switches... " + myLargeGadget.NumberOfSwitches);
                    Console.WriteLine("Number of Buttons.... " + myLargeGadget.NumberOfButtons);
                    Console.WriteLine("Number of Lights..... " + myLargeGadget.NumberOfLights);
                    //Console.WriteLine("Power Source......... " + myLargeGadget.PowerSource); //(backup)
                    Console.WriteLine("Power Source......... " + myLargeGadget.PowerSource);



                    //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                    //My addition to this

                    //display the number of gadgets ordered for this addition to the masterorderform 
                    //display the cost of this addition
                    Console.WriteLine();
                    Console.WriteLine("Number of Large Gadgets ordering = " + gadgetsOrdered);
                    Console.WriteLine("Total Price of this item order: " + gadgetsOrdered * 1000);

             ///////////////////ask the user to confirm!!!!!!!!!!!!!

             ////////////////add to order if yes then cs and MM, otherwise cs display Main Menu





                    break;
            }
        }
    }
}
