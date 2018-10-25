﻿using System;
using Gadget;
using Widget;
using WAG;
using System.Collections;
using System.Threading.Tasks;
using System.Threading;
using Final;

namespace Gadget
{
    public class GadgetOrderFormSubmission
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
                    
                    CustomizeOrder(myMediumGadget);
                    AddItemToOrder(gadgetsOrdered, myMediumGadget);////////////if customizing will be different

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
                    
                    AddItemToOrder(gadgetsOrdered, myLargeGadget);////////////if customizing will be different
                    
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
            else if (gadgetsOrdered == 1138)
            {
                IGottaBadFeelingAboutThis HanSolo = new IGottaBadFeelingAboutThis();
            }




        }

        void CustomizeOrder(IWagProductDecorator GadgetToCustomize)
        {
            Console.WriteLine();
            Console.WriteLine("Customization is available for this order.");
            Console.WriteLine();
            Console.WriteLine("Would you like to customize this order?");
            Console.Write("(Y) YES -or- PRESS ANY OTHER KEY TO CANCEL, AND THEN PRESS \"ENTER\": ");
            string customizationAnswer = Console.ReadLine();

            if(customizationAnswer == "Y")
            {
                ManufacturerCustumization Customize = new ManufacturerCustumization();
                Customize.CustomizeGadget(GadgetToCustomize);
            }
        }



    }








































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































    

    public class IGottaBadFeelingAboutThis
    {
        public IGottaBadFeelingAboutThis()
        {

            //   “I find your lack of faith disturbing.” — Darth Vader
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    Console.Beep(440, 500); Console.Beep(440, 500); Console.Beep(440, 500); Console.Beep(349, 350); Console.Beep(523, 150); Console.Beep(440, 500); Console.Beep(349, 350); Console.Beep(523, 150); Console.Beep(440, 1000); Console.Beep(659, 500); Console.Beep(659, 500); Console.Beep(659, 500); Console.Beep(698, 350); Console.Beep(523, 150); Console.Beep(415, 500); Console.Beep(349, 350); Console.Beep(523, 150); Console.Beep(440, 1000); Console.Beep(880, 500); Console.Beep(440, 350); Console.Beep(440, 150); Console.Beep(880, 500); Console.Beep(830, 250); Console.Beep(784, 250); Console.Beep(740, 125); Console.Beep(698, 125); Console.Beep(740, 250); Console.Beep(455, 250); Console.Beep(622, 500); Console.Beep(587, 250); Console.Beep(554, 250); Console.Beep(523, 125); Console.Beep(466, 125); Console.Beep(523, 250); Console.Beep(349, 125); Console.Beep(415, 500); Console.Beep(349, 375); Console.Beep(440, 125); Console.Beep(523, 500); Console.Beep(440, 375); Console.Beep(523, 125); Console.Beep(659, 1000); Console.Beep(880, 500); Console.Beep(440, 350); Console.Beep(440, 150); Console.Beep(880, 500); Console.Beep(830, 250); Console.Beep(784, 250); Console.Beep(740, 125); Console.Beep(698, 125); Console.Beep(740, 250); Console.Beep(455, 250); Console.Beep(622, 500); Console.Beep(587, 250); Console.Beep(554, 250); Console.Beep(523, 125); Console.Beep(466, 125); Console.Beep(523, 250); Console.Beep(349, 250); Console.Beep(415, 500); Console.Beep(349, 375); Console.Beep(523, 125); Console.Beep(440, 500); Console.Beep(349, 375); Console.Beep(261, 125); Console.Beep(440, 1000);
        }           
    }
}
