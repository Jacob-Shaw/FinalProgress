﻿using System;
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
        
      
        ///####################################################################################################
        ///################   Hooray for huge constructors! ###################################################
        ///         These are all the steps for ordering Gadgets
        ///         Once done it returns to Main Menu.
        ///####################################################################################################
        //This is the constructor which takes the order type and presents the appropriate order form

        public GadgetOrderForm()
        {
            Console.Clear();
            
            ///Start of the Retail Gadget Order Form
            if (WagCustomerTypeAndOrder.CustomerType == "R")
            {
                //Choose the retail order form
                RetailOrderForm();
                
            }
            else if (WagCustomerTypeAndOrder.CustomerType == "M")///start of manufacturer order form
            {
                ManufacturerOrderForm();
            }


            ///@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@See if same?

            //Choose a size of gadget, s,m,l
            GadgetSizeChoice myGadgetSize = new GadgetSizeChoice(); 
            string userGadgetSizeEntered = myGadgetSize.ChooseGadgetSize();//i now have a size!
            
            int numUserGadgetsEntered;              //i now have a number of gadgets!
            //Select the number of gadgets to buy
            SelectNumberOfGadgets();

            string powerSelection = "";     //i now have a power selection!
            //Select the power source()
            SelectPowerSource();

            

            void RetailOrderForm()
            {

                Console.WriteLine("=============================================================================");
                Console.WriteLine("========================= WAG Gadget Order Form =============================");
                Console.WriteLine("===========================  RETAIL MAIN MENU ===============================");
                Console.WriteLine("=============================================================================");

                Console.WriteLine();
                Console.WriteLine("From this menu, you may enter the SIZE and QUANTITY of Gadgets and, ");
                Console.WriteLine("based on your choice, various selections of switches, buttons, lights,");
                Console.WriteLine("finishes, and power sources are available.");
                Console.WriteLine();
                Console.WriteLine("*NOTES: ");
                Console.WriteLine("     Customization of Gadgets is only available via the Manufacturer option.");
                Console.WriteLine("     Gadgets may be Unfinished, Painted, or Plated.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("                Widgets    Switches    Buttons    Lights    Power Supply");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("Small Gadget:      2          1          2          0         Battery");
                Console.WriteLine();
                Console.WriteLine("Medium Gadget:     5          1          3          3      Battery or Solar");
                Console.WriteLine();
                Console.WriteLine("Large Gadget:     12          2          3          4      Solar or Generator");
                Console.WriteLine();
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
                        //Should drop at this point and go to MM

                    }
                }
                else
                {
                    //Return the number of Gadgets to buy


                }
            }


            void SelectPowerSource()
            {
                /// Prompt user for Gadget power source////////////////////////////////////////////////////

                /// display order details
                

                //Create an instance of 
                //These are the various MasterOrderFormSubmissions
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
            









        }///end of gadget order form
        
    }///end of class gadgets
    
    ///end of namespace
}
