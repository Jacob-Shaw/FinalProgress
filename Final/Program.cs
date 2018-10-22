using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using week1.FINAL;
using FINAL;
using WAG;
using Gadget;


namespace FINAL
{
    class Program
    {/// <summary>
    /// This should read like a story.//////////////////////////////////////////////////////////////////////////////////////
    /// Comment, Create Objects, Code Calls
    /// </summary>
    
        static void Main(string[] args)
        {
            //// 1. Display the WAG welcome
            CompanyIntro companyIntro = new CompanyIntro();  //Displays the intro
            companyIntro.Intro();


            ///@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            ///                      Test Space
            ///@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@






            


            ///@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@



            //// 2. Get the user type
            WagCustomerTypeAndOrder newCustomerOrder = new WagCustomerTypeAndOrder();  //creates orderform
            ///I can add simple items by doing this:
            ///   WagCustomerTypeAndOrder.CustomerOrderForm.Add("Something");
            ///Or complex items by doing this:
            ///     WagCustomerTypeAndOrder.OrderFromOrderForm.Add("Something");
            ///     WagCustomerTypeAndOrder.OrderFromOrderForm.Add("Something2");
            ///     WagCustomerTypeAndOrder.OrderFromOrderForm.Add("Something3");
            ///     
            ///     then I add all of this to the MasterOrderForm

            
         
            //// 3. Present the products for something to add to cart
            WagProductCatalog ProductMenu = new WagProductCatalog();

            
            /// Go to the GadgetOrderForm taking info and be able to work thru the one order form for gadgets
            //GadgetOrderForm myOrder = new GadgetOrderForm();
            //myOrder.UserOrderForm(orderType);

            ///Selections from the Gadget Order Form  go to the Universal Order Form

            ///Once the order of a gadget is complete and added to the cart:
            ///Prompt the user to add anything else to order.
            
            
            /*  
            
            OrderCart myCurrentOrder = new OrderCart();
            myCurrentOrder.MyOrderCart(numUserGadgetsEntered, powerSelection);

            DisplayPricing myPriceDisplay = new DisplayPricing();
            myPriceDisplay.DisplayCurrentOrder(userGadgetSizeEntered, numUserGadgetsEntered, powerSelection);
          
            */

            
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue with another order, or Q + ENTER to quit...");
            Console.WriteLine();


            ///May have to keep this here at all times, to exit program or put in method
            string userInput = Console.ReadLine().ToUpper();
            if (userInput == "Q")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
            }

        }
    }
}