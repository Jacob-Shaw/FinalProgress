using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Gadget;


namespace WAG
{
    /// <summary>
    /// This IS the customer order form                          ------Looks Good-------
    /// </summary>
    
    public static class WagCustomerTypeAndOrder
    {
        public static string CustomerType = "";

        public static ArrayList MasterOrderForm = new ArrayList();
        //public ArrayList OrderFromOrderForm = new ArrayList();

        //public static decimal AmountInQuestion;

        public static decimal RunningTotal;
        
        public static void GetOrderType()
        { 
            // Ask the user to specify the order type, Retail or Manufacturer.
            Console.WriteLine();
            Console.WriteLine("PLEASE SELECT ORDER TYPE:  (R)ETAIL or (M)ANUFACTURER: _");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     *Note customization of certain products may");
            Console.WriteLine("         only be available to Manufacturers.");
            Console.CursorTop = 4;
            Console.CursorLeft = 55;


            // Change the respone to a capital letter and compare to available types 
            string userOrderTypeString = Console.ReadLine().ToUpper();

            // Ask the user to reenter the order type if the user made an invalid choice
            while ((userOrderTypeString != "M") && (userOrderTypeString != "R"))
            {
                Console.WriteLine("You must choose (R) or (M).");
                userOrderTypeString = Console.ReadLine().ToUpper();
            }

            // Clear the screen and return the user order type
            Console.Clear();

            CustomerType = userOrderTypeString;

            //return userOrderTypeString;
        }

        public static void AddToRunningTotal(decimal price)
        {
            RunningTotal += price;
        }
    }
}

