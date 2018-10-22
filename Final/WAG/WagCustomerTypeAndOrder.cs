﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Gadget;


namespace WAG
{
    /// <summary>
    /// This IS the customer order form                          ------Looks Good-------
    /// </summary>
    
    public class WagCustomerTypeAndOrder
    {
        public static string CustomerType = ""; 
        
        public static ArrayList MasterOrderForm = new ArrayList(); 
        public static ArrayList OrderFromOrderForm = new ArrayList();

        

        public WagCustomerTypeAndOrder()
        {
            CustomerType = GetOrderType();
        }

        
        public string GetOrderType()
        { 
            // Ask the user to specify the order type, Retail or Manufacturer.
            Console.WriteLine();
            Console.WriteLine("Please select order type:  (R)etail or (M)anufacturer");
            Console.WriteLine();


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
            return userOrderTypeString;
        }
        
    }
}
