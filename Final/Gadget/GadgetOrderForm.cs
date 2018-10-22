using System;
using System.Collections.Generic;
using System.Text;
using WAG;

namespace Gadget
{
    /// <summary>
    /// This order form has two order forms///I need to add to decorator
    /// </summary>
    ///////////////////////////////////////////////////////split these up

    public class GadgetOrderForm
    {

        /// Move customer choice to the Universal Order Form/////////////////////////////////////////////////////
        private const string _retailOrder = "R";
        private const string _manufacturerOrder = "M";



        /// <summary>
        /// Below will be the Gadget Order Form 
        /// </summary>
      

        public void RetailOrderForm()
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
        }

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Add my code below
        ///for the decorator

        public void ManufacturerOrderForm()
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

        public GadgetOrderForm()
        {
            Console.WriteLine("You have reached the Gadget order form constructor");

            if (WagCustomerType.CustomerType == "R")
            {
                RetailOrderForm();
            }
            else if (WagCustomerType.CustomerType == "M")
            {
                ManufacturerOrderForm();
            }

        }
/*



            GadgetSizeChoice myGadgetSize = new GadgetSizeChoice();

            string userGadgetSizeEntered = myGadgetSize.ChooseGadgetSize();

            switch (userGadgetSizeEntered)
            {
                case "S":
                    userGadgetSizeEntered = "Small";
                    break;

                case "M":
                    userGadgetSizeEntered = "Medium";
                    break;

                case "L":
                    userGadgetSizeEntered = "Large";
                    break;
            }



            /*
             * Prompt user to enter number of Gadgets to order
            */
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Should probably ask how many of these to order last 

        /*

                    #region GadgetNumber
                    Console.WriteLine();
                    Console.WriteLine("Place order for how many " + userGadgetSizeEntered + " Gadgets ? ");

                    Console.WriteLine();


                    int numUserGadgetsEntered;

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
                    #endregion


                    /*
                     * Prompt user for Gadget power source, and display order details



                    #region PowerSourceAndDetails
                    string powerSelection = "";

                    OrderCheckOut myCheckOut = new OrderCheckOut();

                    switch (userGadgetSizeEntered)
                    {
                        case "Small":
                            myCheckOut.DisplayOrder(userGadgetSizeEntered, "B");
                            powerSelection = "B";
                            break;

                        case "Medium":
                            PowerSource selectedPowerSourceMedium = new PowerSource();
                            string powerMedium = selectedPowerSourceMedium.UserPowerSourceMedium();
                            powerSelection = powerMedium;

                            myCheckOut.DisplayOrder(userGadgetSizeEntered, powerMedium);
                            break;
                            ///******************************************************************************************************************
                        case "Large":
                            PowerSource selectedPowerSourceLarge = new PowerSource();
                            string powerLarge = "Tango";// selectedPowerSourceLarge.UserPowerSourceLarge();  ///
                            powerSelection = powerLarge;

                            myCheckOut.DisplayOrder(userGadgetSizeEntered, powerLarge);
                            break;
                    }
                    #endregion


            */

    }
    
}
