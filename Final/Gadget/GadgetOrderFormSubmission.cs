using System;
using Gadget;
using Widget;
using WAG;
using System.Collections;

namespace Gadget
{
    public class CompleteGadgetOrderForm
    {
        ///This class will clear the screen and based on the gadget "sizeSelected",
        /// "powerSelected" create the new Gadget object display the contents of the current item

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

                    // Use the object's method to display the pricing
                    mySmallGadget.DisplayComponents();

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------");
                    
                    //Ask the user to confirm the order and then return to Main Menu
                    AddItemToOrder(gadgetsOrdered, mySmallGadget);
                    
                    break;
                    
                case "Medium":

                    Console.Clear();

                    GadgetMedium myMediumGadget = new GadgetMedium();
                    
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("------------------  Medium Gadget -------------------");
                    Console.WriteLine("-----------------------------------------------------");

                    myMediumGadget.DisplayComponents();

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------");
                    
                    AddItemToOrder(gadgetsOrdered, myMediumGadget);

                    break;
                    
                case "Large":

                    Console.Clear();
                    
                    GadgetLarge myLargeGadget = new GadgetLarge();
                    
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("-------------------  Large Gadget -------------------");
                    Console.WriteLine("-----------------------------------------------------");

                    myLargeGadget.DisplayComponents();

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------");
                    
                    AddItemToOrder(gadgetsOrdered, myLargeGadget);
                    
                    break;
            }
        }
        
        void AddItemToOrder(int gadgetsOrdered, GadgetAbstract AddingGadget)
        {
            Console.WriteLine();
            Console.WriteLine("Number of " + AddingGadget + " Gadgets ordering = " + gadgetsOrdered);
            Console.WriteLine();
            Console.Write("Total Price of this item order:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("      $" + gadgetsOrdered * AddingGadget.GetPrice());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Add this item to your order?");
            Console.WriteLine();
            Console.WriteLine("(Y) Yes  -or-  or Press any other key to Cancel this order.");

            string userConfirmOrder = Console.ReadLine().ToUpper();

            if (userConfirmOrder == "Y")
            {
                OrderFromOrderForm.Add(gadgetsOrdered * AddingGadget.GetPrice());
                OrderFromOrderForm.Add(gadgetsOrdered);
                OrderFromOrderForm.Add(AddingGadget.Name);

                WagCustomerTypeAndOrder.MasterOrderForm.Add(OrderFromOrderForm);
            }
        }
    }
}
