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
            //////Start of the Retail Gadget Order Form
            Console.Clear();

            /////Select the appropriate order form
            selectOrderForm();
            
            /////Choose a size of gadget, s,m,l
            ///This will be used to select the gadget size
            GadgetSizeChoice myGadgetSize = new GadgetSizeChoice(); 
            string userGadgetSizeEntered = myGadgetSize.ChooseGadgetSize();//i now have a size!

            /////Select the number of gadgets to buy
            int numUserGadgetsEntered;              //i now have a number of gadgets!
            SelectNumberOfGadgets();

            //////Select the power source()
           // string GadgetSelection = "";     //i now have a power selection!  NO I DON'T!!!
            CreateGadgetSelection(userGadgetSizeEntered);    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            ///!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            /////Once the power selection is made 

            

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

            void RetailOrderForm()
            {

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
            
            void SelectNumberOfGadgets()
            {
                //Prompt user to enter number of Gadgets to order
                Console.WriteLine();
                Console.WriteLine("Place order for how many " + userGadgetSizeEntered + " Gadgets?");
                Console.WriteLine();


                String Result = Console.ReadLine();


                while (!Int32.TryParse(Result, out numUserGadgetsEntered))
                {
                    Console.WriteLine("Please enter a number.");

                    Result = Console.ReadLine();
                }
                if (numUserGadgetsEntered < 0)
                {
                    Console.WriteLine("You entered a negative number.  Converting to positive.");
                    numUserGadgetsEntered = Math.Abs(numUserGadgetsEntered);
                }
                else if (numUserGadgetsEntered == 0)
                {
                    Console.WriteLine("Are you sure you meant to order 0?");
                    Console.WriteLine("(Y) Yes   (N) No");

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
            


            //////@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            ///                 Getting rid of this
          


            void CreateGadgetSelection( string gadgetSizeToCreate )
            {
                /// Let's create the Gadget!
                ///
                ///@@@@@@@@@@@@@@@@@@@@@@  and perhaps we can add to arraylist from here
                ///

                CompleteGadgetOrderForm gadgetOrderSummary = new CompleteGadgetOrderForm();


                switch (userGadgetSizeEntered)
                {
                    case "Small":
                        gadgetOrderSummary.DisplayOrder(numUserGadgetsEntered, userGadgetSizeEntered, "B");
                        powerSelection = "B";
                        break;

                    case "Medium":
                        PowerSource selectedPowerSourceMedium = new PowerSource();
                        string powerMedium = selectedPowerSourceMedium.UserPowerSourceMedium();
                        powerSelection = powerMedium;/////////////////////////////////////////////////////

                        gadgetOrderSummary.DisplayOrder(numUserGadgetsEntered, userGadgetSizeEntered, powerMedium);
                        break;

                    case "Large":
                        PowerSource selectedPowerSourceLarge = new PowerSource();
                        string powerLarge = selectedPowerSourceLarge.UserPowerSourceLarge(); 
                        powerSelection = powerLarge;//////////////////////////////////////////////////////

                        gadgetOrderSummary.DisplayOrder(numUserGadgetsEntered, userGadgetSizeEntered, powerLarge);
                        break;
                }
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

                //delete this after adding Manufacturer option code
                Environment.Exit(0);
            }
            /// end of manufactuer order form
            
            

        }

        
        ///end of gadget order form

    }///end of class gadgets

    ///end of namespace
}
