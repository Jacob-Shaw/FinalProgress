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
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            //// 1. Display the WAG welcome
            CompanyIntro companyIntro = new CompanyIntro();
            companyIntro.Intro();

            //// 2. Create the customer order form, Get the user type
            WagCustomerOrderForm newCustomerOrder = new WagCustomerOrderForm();


            

            //// 3. Present the products
            WagProductCatalog ProductMenu = new WagProductCatalog();


            TheOrderForm.customerOrder.Add(Gadget);   ///Hallelujah!
            WagCustomerOrderForm.MEcustomerOrder.Add(Gadget);


            //string orderType = userOrderType.GetOrderType();
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Add Item menu if possible
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Generalize orderform following
            //// Get the order form details based on Order Type choice Retail or Manufacturer
            /// Create the Universal Orderform, place it here, remove Gadget orderforms



            /// Present the user with the Company Item list Menu for sale(only gadgets now, Small, Medium, Large
            /// Place the Item List here
            /// user chooses item
            /// 
            /// 
            /// 
            /// Go to the GadgetOrderForm taking info and be able to work thru the one order form for gadgets
            //GadgetOrderForm myOrder = new GadgetOrderForm();
            //myOrder.UserOrderForm(orderType);

            ///Selections from the Gadget Order Form  go to the Universal Order Form
            
            ///Once the order of a gadget is complete and added to the cart:
            ///Prompt the user to add anything else to order.
            ///***At any time the user should be able to cancel order, prompt "are you sure" which returns to Welcome screen
            ///***At any time exit
            ///***If the user is done, proceed to customer check out ----   ***See below***
            ///***If the user would like to continue to order, return to Company Item menu
            ///         continue to add more items
            ///***User should be able to append what they have ordered
            
            
            ///////////Currently working here 10-18---working out flow in english!!!!!!!!!!!!!!!!!!!!!!!***********

            /*  
            
            OrderCart myCurrentOrder = new OrderCart();
            myCurrentOrder.MyOrderCart(numUserGadgetsEntered, powerSelection);

            DisplayPricing myPriceDisplay = new DisplayPricing();
            myPriceDisplay.DisplayCurrentOrder(userGadgetSizeEntered, numUserGadgetsEntered, powerSelection);
          
            */
            
            






            ///This is part of the story, keep!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
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
                //Final();
            }

            
        }
    }
}