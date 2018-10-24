﻿using System;
using System.Collections.Generic;
using System.Text;
using Gadget;
using Widget;
using WAG;
using System.Collections;

namespace Gadget
{
    public class CompleteGadgetOrderForm
    {
        ///  
        ///This class will clear the screen and
        ///based on the gadget "sizeSelected" and "powerSelected" create the new Gadget object
        ///display the contents of the current item
        ///
        ///********Allow for customization IF POSSIBLE!***************88
        ///                 USE THE DECORATOR
        ///                 
        /// 
        ///add to the Masterorderform



        public ArrayList OrderFromOrderForm = new ArrayList();

        public void DisplayOrder(int gadgetsOrdered, string sizeSelected)
        {


            switch (sizeSelected)
            {
                case "Small":
                    Console.Clear();

                    // This is the Small Gadget we are creating
                    GadgetSmall mySmallGadget = new GadgetSmall();

                    //This is used for pricing
                    //WidgetSmall mySmallWidget = new WidgetSmall();

                    // Display the Form
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("-------------------  Small Gadget -------------------");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine();

                    mySmallGadget.DisplayComponents();
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------");


                    //display the number of gadgets ordered for this addition to the masterorderform 
                    //display the cost of this addition
                    Console.WriteLine();
                    Console.WriteLine("Number of Small Gadgets ordering =   " + gadgetsOrdered);
                    Console.WriteLine();
                    Console.Write("Total Price of this item order:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("      $" + gadgetsOrdered * mySmallGadget.GetPrice());
                    Console.ForegroundColor = ConsoleColor.White;
                    

                    //This is where we ask the customer to confirm the order
                    ////////////////add to order if yes then cs and MM, otherwise cs display Main Menu

                    Console.WriteLine("Add this item to your order?");
                    Console.WriteLine("(Y) Yes  -or-  or Press any other key to Cancel this order.");

                    string userConfirmOrder = Console.ReadLine().ToUpper();

                    if (userConfirmOrder == "Y")
                    {


                        //Add item to order
                        //Price first, Then the rest as it will display
                        OrderFromOrderForm.Add(gadgetsOrdered * mySmallGadget.GetPrice());
                        OrderFromOrderForm.Add(gadgetsOrdered);
                        OrderFromOrderForm.Add(mySmallGadget.Name);

                        WagCustomerTypeAndOrder.MasterOrderForm.Add(OrderFromOrderForm);

                        //WagCustomerTypeAndOrder.OrderFromOrderForm.Clear();
                        
                        /*
                        WagCustomerTypeAndOrder.OrderFromOrderForm.Add();
                        WagCustomerTypeAndOrder.OrderFromOrderForm.Add();
                        WagCustomerTypeAndOrder.OrderFromOrderForm.Add();
                        WagCustomerTypeAndOrder.OrderFromOrderForm.Add();
                        WagCustomerTypeAndOrder.OrderFromOrderForm.Add();
                        WagCustomerTypeAndOrder.OrderFromOrderForm.Add();
                        */

                    }

                    break;

















                case "Medium":
                    Console.WriteLine();

                    GadgetMedium myMediumGadget = new GadgetMedium();

                    //Can keep this because it will not change
                    WidgetMedium myMediumWidget = new WidgetMedium();
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("------------------  Medium Gadget -------------------");
                    Console.WriteLine("-----------------------------------------------------");




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

        /*public void AddToOrder(string x)
        {
            //WagCustomerTypeAndOrder.OrderFromOrderForm.Add(x);
            //WagCustomerTypeAndOrder.OrderFromOrderForm.AddRange(1, 2, 3, 4, 5, 6);
        }
        */
    }
}
