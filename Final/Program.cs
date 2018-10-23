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
    {




        static void Main(string[] args)
        {
            //// 1. Display the WAG welcome
            CompanyIntro companyIntro = new CompanyIntro();  //Displays the intro
            companyIntro.Intro();
            

            //// 2. Get the user type
            WagCustomerTypeAndOrder newCustomerOrder = new WagCustomerTypeAndOrder();  //creates orderform
            
            
            //// 3. Present the products for something to add to cart
            WagProductCatalog ProductMenu = new WagProductCatalog();

            

            /////@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            ///                             Unused code below!
            /////@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            ///                                 End of Program
            /////@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@




            






            /*
            
            OrderCart myCurrentOrder = new OrderCart();
            myCurrentOrder.MyOrderCart(numUserGadgetsEntered, powerSelection);

            DisplayPricing myPriceDisplay = new DisplayPricing();
            myPriceDisplay.DisplayCurrentOrder(userGadgetSizeEntered, numUserGadgetsEntered, powerSelection);
          
            

            /*
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

            */
        }
    }
}