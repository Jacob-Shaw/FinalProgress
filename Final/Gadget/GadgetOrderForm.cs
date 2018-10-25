using System;
using System.Collections.Generic;
using System.Text;
using WAG;

namespace Gadget
{
    /// <summary>
    /// This order form has two order forms
    /// </summary>
   
    public class GadgetOrderForm
    {
        private const string _retailOrder = "R";
        private const string _manufacturerOrder = "M";
        
      
        public GadgetOrderForm()
        {
            // 1. Start of the Retail Gadget Order Form
            Console.Clear();

            // 2. Select the appropriate order form R or M 
            // 2b. Present the correct order form
            selectOrderForm();     //********************************************Needed Info  R or M  
            
            // 3. Select the gadget size s,m,l
            GadgetSizeChoice myGadgetSize = new GadgetSizeChoice(); 
            string userGadgetSizeEntered = myGadgetSize.ChooseGadgetSize();   //*********Needed Info   //i now have a gadget size! (((  Add to OrderForm Array -- 1.)))

            // 4. Select the number of gadgets to buy
            int numUserGadgetsEntered; //*********************************Needed Info     //i now have a number of gadgets!
            SelectNumberOfGadgets();

            // 5. Create a gadget (For medium and large power choice is in constructor. If retail, just add finish with decorator. If Manufacturer allow to use decorator to add Finish, number of appropriate stuff. ---Depends on S, M, or L Gadget
            CreateGadgetSelection(userGadgetSizeEntered);    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                                                                                                                         //                         1           2                          3                                 4                  5                6                         7
            // 6. Show what the customer has chosen to buy for this line item to be entered into MasterOrderForm array with price. Example :   Unfinished     Large      GADGET WITH     Solar       POWER SOURCE        +2 switches         +3 buttons       +5 lights      = $       10000.50

            // 7. Ask customer to approve adding to MasterOrderForm

            // 8. Return to MainMenu (This should happen automatically at end )
            

            void selectOrderForm()
            {
                if (WagCustomerTypeAndOrder.CustomerType == "R")
                {
                    //Choose the retail order form
                    RetailOrderForm();

                }
                else if (WagCustomerTypeAndOrder.CustomerType == "M")///start of manufacturer order form
                {
                    ManufacturerOrderForm();
                }
            }

            
            
            void SelectNumberOfGadgets()
            {
                //Prompt user to enter number of Gadgets to order
                Console.WriteLine();
                Console.Write("Select NUMBER of " + userGadgetSizeEntered + " Gadgets to order: ");
                
                String Result = Console.ReadLine();

                Console.WriteLine();

                while (!Int32.TryParse(Result, out numUserGadgetsEntered))
                {
                    Console.Write("Please enter a number: ");

                    Result = Console.ReadLine();
                }
                if (numUserGadgetsEntered < 0)
                {
                    Console.WriteLine("You entered a negative number.  Converting to positive.");
                    numUserGadgetsEntered = Math.Abs(numUserGadgetsEntered);
                }
                else if (numUserGadgetsEntered == 0)
                {
                    Console.WriteLine("Are you sure you meant to order 0? ");
                    Console.WriteLine("(Y) Yes      (Any other key) No ");

                    string confirm0 = Console.ReadLine().ToUpper();

                    if (confirm0 == "Y")
                    {
                        //Should drop at this point and go to Main Menu

                    }
                    else
                    {
                        SelectNumberOfGadgets();
                    }
                }
            }
            
            
            void CreateGadgetSelection( string gadgetSizeToCreate )
            {
                // Based on previously chosen size of Gadget and the quantity chosen, 
                //    use gadgetOrderSummary to create an object of that type (and display all 
                //     information formatted nicely and ask the user if they agree to add this to
                //     the MasterOrderForm)

                CompleteGadgetOrderForm gadgetOrderSummary = new CompleteGadgetOrderForm();


                switch (userGadgetSizeEntered)
                {
                    case "Small":

                        gadgetOrderSummary.DisplayOrder(numUserGadgetsEntered, userGadgetSizeEntered);
                        
                        break;

                    case "Medium":
                        
                        gadgetOrderSummary.DisplayOrder(numUserGadgetsEntered, userGadgetSizeEntered);

                        break;

                    case "Large":
                      
                        gadgetOrderSummary.DisplayOrder(numUserGadgetsEntered, userGadgetSizeEntered);

                        break;
                }
            }



            void RetailOrderForm()
            {
                //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@  Make this dynamically grab the numbers
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=============================================================================");
                Console.WriteLine("========================= WAG Gadget Order Form =============================");
                Console.WriteLine("===========================  RETAIL MAIN MENU ===============================");
                Console.WriteLine("=============================================================================");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("                Widgets    Switches    Buttons    Lights     Power Supply");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("Small Gadget:      2          1          2          0          Battery");
                Console.WriteLine();
                Console.WriteLine("Medium Gadget:     5          1          3          3      Battery or Solar");
                Console.WriteLine();
                Console.WriteLine("Large Gadget:     12          2          3          4      Solar or Generator");
                Console.WriteLine();
                Console.WriteLine();

            }


            void ManufacturerOrderForm()
            {
                Console.WriteLine("=============================================================================");
                Console.WriteLine("============================= WAG Order Form ================================");
                Console.WriteLine("========================  MANUFACTURER MAIN MENU ============================");
                Console.WriteLine("=============================================================================");

                Console.WriteLine();
                Console.WriteLine("................Jacob's stuff....................");
                Console.WriteLine();


                //#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@    Copy above order form!
                //                                   Add customization





                //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@delete this after adding Manufacturer option code   Does it exit automatically?
                Environment.Exit(0);
            }
            /// end of manufactuer order form
            
            

        }

        
        ///end of gadget order form

    }///end of class gadgets

    ///end of namespace
}
