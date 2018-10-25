using System;
using Gadget;
using Widget;
using WAG;
using System.Collections;
using System.Threading.Tasks;

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

                    GadgetMedium myMediumGadget = new GadgetMedium();

                    Console.Clear();

                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("------------------  Medium Gadget -------------------");
                    Console.WriteLine("-----------------------------------------------------");

                    myMediumGadget.DisplayComponents();

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------");
                    
                    AddItemToOrder(gadgetsOrdered, myMediumGadget);

                    break;
                    
                case "Large":
                    
                    GadgetLarge myLargeGadget = new GadgetLarge();

                    Console.Clear();

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
            Console.WriteLine("Number of " + AddingGadget.Name + " Gadgets ordering = " + gadgetsOrdered);
            Console.WriteLine();
            Console.Write("Total Price of this item order:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("      $" + gadgetsOrdered * AddingGadget.GetPrice());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();


            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@  Like the color choice below for other forms ?????????????????????
            
            Console.WriteLine("Add this item to your order?");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("(Y) Yes ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("-or- Press any other key to ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Cancel");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(", and then press \"Enter\": ");
            
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
