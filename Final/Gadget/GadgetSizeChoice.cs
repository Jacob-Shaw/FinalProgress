using System;
using System.Collections.Generic;
using System.Text;

namespace Gadget
{
    public class GadgetSizeChoice
    {
        /// <summary>
        /// This class simply allows the user to choose the size of the gadget
        /// </summary>
      
        public string ChooseGadgetSize()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter SIZE of Gadget:  (S)mall, (M)edium, or (L)arge");

            string userGadgetSize = Console.ReadLine().ToUpper();

            while ((userGadgetSize != "S") && (userGadgetSize != "M") && (userGadgetSize != "L"))
            {
                Console.WriteLine("You must choose (S), (M), or (L)");
                userGadgetSize = Console.ReadLine().ToUpper();
            }

            switch (userGadgetSize)
            {
                case "S":
                    userGadgetSize = "Small";
                    break;

                case "M":
                    userGadgetSize = "Medium";
                    break;

                case "L":
                    userGadgetSize = "Large";
                    break;
            }
            
            return userGadgetSize;
        }
    }
}
