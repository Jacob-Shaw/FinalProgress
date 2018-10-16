using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    class PowerSource
    {
        public string UserPowerSourceMedium()
        {
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
