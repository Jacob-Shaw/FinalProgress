using System;
using WAG;
using System.Collections;

namespace Gadget
{
    public class GadgetOrderFormSubmission
    {
        ///This class will clear the screen and based on the gadget "sizeSelected",
        /// "powerSelected" create the new Gadget object display the contents of the current item

        public ArrayList OrderFromOrderForm = new ArrayList();

        public void DisplayOrder(int NumberOfGadgets, string sizeSelected)
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

                    OrderSummary(mySmallGadget, NumberOfGadgets);

                    //Ask the user to confirm the order and then return to Main Menu
                    AddItemToOrder(mySmallGadget, NumberOfGadgets);
                    
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

                    OrderSummary(myMediumGadget, NumberOfGadgets);

                    if (WagCustomerTypeAndOrder.CustomerType == "M")
                        CustomizeOrder(myMediumGadget, NumberOfGadgets);
                    else
                        AddItemToOrder(myMediumGadget, NumberOfGadgets);
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

                    OrderSummary(myLargeGadget, NumberOfGadgets);

                    if (WagCustomerTypeAndOrder.CustomerType == "M")
                        CustomizeOrder(myLargeGadget, NumberOfGadgets);
                    else
                        AddItemToOrder(myLargeGadget, NumberOfGadgets);
                    break;
            }
        }

        void OrderSummary(GadgetSmall AddingGadget, int gadgetsOrdered)
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
        }

        void OrderSummary(IWagProduct AddingGadget, int gadgetsOrdered)
        {
            Console.WriteLine();
            Console.WriteLine("Number of " + AddingGadget.GetLineItemOrderDetails + " Gadgets ordering = " + gadgetsOrdered);
            Console.WriteLine();
            Console.Write("Total Price of this item order:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("      $" + gadgetsOrdered * AddingGadget.GetLineItemPrice);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
        }
        
        void AddItemToOrder(IWagProduct AddingGadget, int gadgetsOrdered)
        {
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
                OrderFromOrderForm.Add(gadgetsOrdered * AddingGadget.GetLineItemPrice);
                OrderFromOrderForm.Add(gadgetsOrdered);
                OrderFromOrderForm.Add(AddingGadget.GetLineItemOrderDetails);
                OrderFromOrderForm.Add(gadgetsOrdered * AddingGadget.GetLineItemPrice);  
                
                WagCustomerTypeAndOrder.MasterOrderForm.Add(OrderFromOrderForm);
            }
            else if (gadgetsOrdered == 1138)
            {
                IGottaBadFeelingAboutThis HanSolo = new IGottaBadFeelingAboutThis();
            }
        }
        
        void AddItemToOrder(GadgetSmall AddingGadget, int gadgetsOrdered)
        {
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
                OrderFromOrderForm.Add(" " + AddingGadget.Name);
                OrderFromOrderForm.Add(gadgetsOrdered * AddingGadget.GetPrice());

                WagCustomerTypeAndOrder.MasterOrderForm.Add(OrderFromOrderForm);
            }
        }
        
        void CustomizeOrder(IWagProduct GadgetToCustomize, int NumofGadgets)
        {
            Console.WriteLine();
            Console.WriteLine("Customization is available for this order.");
            Console.WriteLine();
            Console.WriteLine("Would you like to ADD customization to this order?");
            Console.Write("(Y) YES -or- PRESS ANY OTHER KEY TO CANCEL, AND THEN PRESS \"ENTER\": ");
            string customizationAnswer = Console.ReadLine().ToUpper();
            
            if (customizationAnswer == "Y" && WagCustomerTypeAndOrder.CustomerType == "M")
            {
                ManufacturerCustomization Customize = new ManufacturerCustomization();
                AddItemToOrder( Customize.CustomizeGadget(GadgetToCustomize, NumofGadgets), NumofGadgets);
            }
            else
            {
                AddItemToOrder(GadgetToCustomize, NumofGadgets);
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
