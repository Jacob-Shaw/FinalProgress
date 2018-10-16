using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{

    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!could be a static class
    public class WagIntro
    {
        public string OrderType()
        {
            Console.WriteLine("=============================================================================");
            Console.WriteLine("=========================== Welcome to WAG!!!! ==============================");
            Console.WriteLine("=============================================================================");

            Console.WriteLine();
            Console.WriteLine("Please select order type:  (R)etail or (M)anufacturer");
            Console.WriteLine();

            string userOrderTypeString = Console.ReadLine().ToUpper();

            while ((userOrderTypeString != "M") && (userOrderTypeString != "R"))
            {
                Console.WriteLine("You must choose (R) or (M)");
                userOrderTypeString = Console.ReadLine().ToUpper();
            }

            Console.Clear();
            return userOrderTypeString;
        }

    }
}
