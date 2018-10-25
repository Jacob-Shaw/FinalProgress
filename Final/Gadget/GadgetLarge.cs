using System;
using System.Collections.Generic;
using System.Text;
using WAG;

namespace Gadget
{
    public class GadgetLarge : GadgetWithLights
    {
        public override string Name { get { return "Large Gadget"; } }

        public override int NumberOfSmallWidgets { get; set; } = 12;
        public override int NumberOfMediumWidgets { get; set; } = 12;
        public override int NumberOfLargeWidgets { get; set; } = 12;
        public override int NumberOfSwitches { get; set; } = 2;
        public override int NumberOfButtons { get; set; } = 3;
        public override int NumberOfLights { get; set; } = 4;
        

        public override string PowerSource { get; set; }


        public string UserPowerSourceLarge()
        {
            Console.WriteLine();
            Console.Write("Please select (G)ENERATOR or (S)OLAR power source for your Large Gadget(s): ");
            

            string userPowerSourceString = Console.ReadLine().ToUpper();

            while ((userPowerSourceString != "G") && (userPowerSourceString != "S"))
            {
                Console.WriteLine();
                Console.Write("You must choose (G) or (S) :");
                userPowerSourceString = Console.ReadLine().ToUpper();
            }

            return userPowerSourceString;
        }

        //Constructor which guides the user to enter the power choice selection
        public GadgetLarge()
        {
            string powerSource = UserPowerSourceLarge();

            if (powerSource == "G")
            {
                this.PowerSource = "GENERATOR";
            }
            else if (powerSource == "S")
            {
                this.PowerSource = "SOLAR";
            }
            else
            {
                this.PowerSource = "UNKNOWN";
            }
        }
    }
}

