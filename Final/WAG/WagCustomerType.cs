using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Gadget;
using Final;


namespace WAG
{
    /// <summary>
    /// This class get's the customer type.                      
    /// </summary>
    
    public static class WagCustomerType
    {
        public static string CustomerType = "";

        //public ArrayList OrderFromOrderForm = new ArrayList();

        //public static decimal AmountInQuestion;
        

       
        
        public static void GetCustomerType()
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


            //SpecialEffects specialEffects = new SpecialEffects();
            //specialEffects.Blink("     *Note customization of certain products may \n");
            //specialEffects.Blink("         only be available to Manufacturers.");
            Console.WriteLine("     *Note customization of certain products may");
            Console.WriteLine("         only be available to Manufacturers.");

            Console.CursorLeft = 0;
            Console.CursorTop = 4;
            Console.CursorLeft = 55;


            // Change the response of R or M to a capital letter and compare to available types 
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
        }
    }
}

