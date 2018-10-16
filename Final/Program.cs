using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

using week1.FINAL;

namespace week1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Display the WAG welcome, and prompt
             * the user to choose the order type
            */

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!split greeting and customer order form
            WagIntro myWagIntro = new WagIntro();
            string userOrderType = myWagIntro.OrderType();


            /*
             * Display the order form details based on Order Type choice
            */

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Present Item menu
            //Then use the order form to start the order
            OrderForm myOrder = new OrderForm();
            myOrder.UserOrderForm(userOrderType);


            /* 
             * Prompt user for Gadget size
            */
            #region GadgetSize
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
            #endregion


            /*
             * Prompt user to enter number of Gadgets to order
            */
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Should probably ask how many of these to order last 
            #region GadgetNumber
            Console.WriteLine();
            Console.WriteLine("Place order for how many " + userGadgetSizeEntered + " Gadgets ? ");
            Console.WriteLine();


            int numUserGadgetsEntered;

            String Result = Console.ReadLine();

            while (!Int32.TryParse(Result, out numUserGadgetsEntered))
            {
                Console.WriteLine("Not a valid number, try again.");

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
            */
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

                case "Large":
                    PowerSource selectedPowerSourceLarge = new PowerSource();
                    string powerLarge = selectedPowerSourceLarge.UserPowerSourceLarge();
                    powerSelection = powerLarge;

                    myCheckOut.DisplayOrder(userGadgetSizeEntered, powerLarge);
                    break;
            }
            #endregion

            #region UnsuedInterfaceCode
            /*
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            WidgetSmall mySmallWidget1 = new WidgetSmall();
            mySmallWidget1.DisplaySmallWidgetComponents();     //this works because WidgetSmall.cs automatically inherits from the abstract Widget.cs
            Console.WriteLine();
            Console.WriteLine();
            WidgetMedium myMediumWidget1 = new WidgetMedium();
            myMediumWidget1.DisplayMediumWidgetComponents();   //this works because WidgetMedium.cs automatically inherits from the abstract Widget.cs
            Console.WriteLine();
            Console.WriteLine();
            WidgetLarge myLargeWidget1 = new WidgetLarge();
            myLargeWidget1.DisplayLargeWidgetComponents();     //this works because WidgetLarge.cs automatically inherits from the abstract Widget.cs
            Console.WriteLine();
            Console.WriteLine();
            */
            #endregion


            Console.WriteLine(" ");
            Console.WriteLine(" ");

            #region OrderCart            
            OrderCart myCurrentOrder = new OrderCart();
            myCurrentOrder.MyOrderCart(numUserGadgetsEntered, powerSelection);

            DisplayPricing myPriceDisplay = new DisplayPricing();
            myPriceDisplay.DisplayCurrentOrder(userGadgetSizeEntered, numUserGadgetsEntered, powerSelection);
            #endregion


            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue with another order, or Q + ENTER to quit...");
            Console.WriteLine();

            string userInput = Console.ReadLine().ToUpper();
            if (userInput == "Q")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                //Final();
            }
        }
    }
}