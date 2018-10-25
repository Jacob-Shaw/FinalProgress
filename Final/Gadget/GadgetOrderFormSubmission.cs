using System;
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
                    Console.WriteLine();
                    Console.WriteLine();

                    AddItemToOrder(gadgetsOrdered, mySmallGadget);




                    /*


                    //This is where we ask the customer to confirm the order
                    ////////////////add to order if yes then cs and MM, otherwise cs display Main Menu

                    Console.WriteLine("Add this item to your order?");
                    Console.WriteLine();
                    Console.WriteLine("(Y) Yes  -or-  or Press any other key to Cancel this order.");

                    string userConfirmOrder = Console.ReadLine().ToUpper();

                    if (userConfirmOrder == "Y")
                    {
                        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ Duplicate this to med and large

                        //Add item to order
                        //Price first, Then the rest as it will display
                        OrderFromOrderForm.Add(gadgetsOrdered * mySmallGadget.GetPrice());
                        OrderFromOrderForm.Add(gadgetsOrdered);
                        OrderFromOrderForm.Add(mySmallGadget.Name);

                        WagCustomerTypeAndOrder.MasterOrderForm.Add(OrderFromOrderForm);

                        

                    }


        */


                    break;


                   











                    

                case "Medium":

                    Console.Clear();

                    GadgetMedium myMediumGadget = new GadgetMedium();
                    

                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("------------------  Medium Gadget -------------------");
                    Console.WriteLine("-----------------------------------------------------");

                    myMediumGadget.DisplayComponents();
                    

                    //display the number of gadgets ordered for this addition to the masterorderform 
                    //display the cost of this addition
                    Console.WriteLine();
                    Console.WriteLine("Number of Medium Gadgets ordering = " + gadgetsOrdered);
                    Console.Write("Total Price of this item order:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("      $" + gadgetsOrdered * myMediumGadget.GetPrice());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine();


                    ///////////////////ask the user to confirm!!!!!!!!!!!!!

                    ////////////////add to order if yes then cs and MM, otherwise cs display Main Menu


                    break;


                    

                case "Large":

                    Console.Clear();
                    
                    GadgetLarge myLargeGadget = new GadgetLarge();
                    
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("-------------------  Large Gadget -------------------");
                    Console.WriteLine("-----------------------------------------------------");

                    myLargeGadget.DisplayComponents();
                    
                    Console.WriteLine();
                    Console.WriteLine("Number of Large Gadgets ordering = " + gadgetsOrdered);
                    Console.WriteLine();
                    Console.Write("Total Price of this item order:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("      $" + gadgetsOrdered * myLargeGadget.GetPrice());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine();


                    ///////////////////ask the user to confirm!!!!!!!!!!!!!

                    ////////////////add to order if yes then cs and MM, otherwise cs display Main Menu


                    break;
            }

            
          
        }


        void AddItemToOrder(int gadgetsOrdered, GadgetAbstract AddingGadget)
        {

            Console.WriteLine("Add this item to your order?");
            Console.WriteLine();
            Console.WriteLine("(Y) Yes  -or-  or Press any other key to Cancel this order.");

            string userConfirmOrder = Console.ReadLine().ToUpper();

            if (userConfirmOrder == "Y")
            {


                //Add item to order
                //Price first, Then the rest as it will display
                OrderFromOrderForm.Add(gadgetsOrdered * AddingGadget.GetPrice());
                OrderFromOrderForm.Add(gadgetsOrdered);
                OrderFromOrderForm.Add(AddingGadget.Name);

                WagCustomerTypeAndOrder.MasterOrderForm.Add(OrderFromOrderForm);

            }

        }


    }
}
