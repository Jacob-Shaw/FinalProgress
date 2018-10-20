using System;
using System.Collections.Generic;
using System.Text;

namespace Gadget
{
    public class GadgetSizeChoice
    {

        /// <summary>
        /// This class simply allows the user to choose the size of the gadget//May refactor---Put into gadget orderform
        /// </summary>
        /// <returns></returns>
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

            return userGadgetSize;
        }
    }
}
