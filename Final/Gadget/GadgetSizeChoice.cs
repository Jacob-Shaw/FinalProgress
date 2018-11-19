using System;
using System.Collections.Generic;
using System.Text;

namespace Gadget
{
    public class GadgetSizeChoice
    {
        /// This class simply allows the user to choose the size of the gadget.
      
        public string ChooseGadgetSize()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Please enter SIZE of Gadget:  (S)mall, (M)edium, or (L)arge: ");

            string userGadgetSize = Console.ReadLine().ToUpper();

            while ((userGadgetSize != "S") && (userGadgetSize != "M") && (userGadgetSize != "L"))
            {
                Console.WriteLine();
                Console.WriteLine("You must choose (S), (M), or (L)");
                userGadgetSize = Console.ReadLine().ToUpper();
            }

            switch (userGadgetSize)
            {
                case "S":

                    Console.WriteLine();
                    userGadgetSize = "Small";
                    break;

                case "M":

                    Console.WriteLine();
                    userGadgetSize = "Medium";
                    break;

                case "L":

                    Console.WriteLine();
                    userGadgetSize = "Large";
                    break;
            }
            
            return userGadgetSize;
        }
    }
}
