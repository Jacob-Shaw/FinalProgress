using System;
using System.Collections.Generic;
using System.Text;

namespace SSSSSSSSSSS
{
    class PowerSource
    {
        /// <summary>
        /// @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        ///                 Look at the Namespace, unused
        /// 
        /// 
        /// 
        /// This class asks the user to select the power source type and 
        /// returns B or S for Medium/    G or S for Large
        /// </summary>
        /// <returns></returns>



        public string UserPowerSourceMedium()
        {
            //Prompt user for powersource type
            Console.WriteLine();
            Console.WriteLine("Please select power source for Medium Gadget(s):  (B)attery or (S)olar");
            Console.WriteLine();
            
            string userPowerSourceString = Console.ReadLine().ToUpper();
            
            while ((userPowerSourceString != "B") && (userPowerSourceString != "S"))
            {
                Console.WriteLine("You must choose (B) or (S)");
                userPowerSourceString = Console.ReadLine().ToUpper();
            }

            return userPowerSourceString;
        }





        public string UserPowerSourceLarge()
        {
            //Prompt user for powersource type
            Console.WriteLine();
            Console.WriteLine("Please select power source for Large Gadget(s):  (G)enerator or (S)olar");
            Console.WriteLine();

            string userPowerSourceString = Console.ReadLine().ToUpper();

            while ((userPowerSourceString != "G") && (userPowerSourceString != "S"))
            {
                Console.WriteLine("You must choose (G) or (S)");
                userPowerSourceString = Console.ReadLine().ToUpper();
            }

            return userPowerSourceString;
        }
           
    }
}
