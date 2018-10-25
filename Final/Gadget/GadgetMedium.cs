using System;
using System.Collections.Generic;
using System.Text;
using WAG;

namespace Gadget
{
    public class GadgetMedium : GadgetWithLights
    {
        public override string Name { get { return "Medium Gadget"; } }
        
        public override int NumberOfSmallWidgets { get; set; } = 2;
        public override int NumberOfMediumWidgets { get; set; } = 2;
        public override int NumberOfLargeWidgets { get; set; } = 1;
        
        public override int NumberOfSwitches { get; set; } = 1;
        public override int NumberOfButtons { get; set; } = 3;
        public override int NumberOfLights { get; set; } = 3;


        //If it has a field you do not know what to set it to, ask for it in the constructor.
        public override string PowerSource { get; set; }
        
        
        public string UserPowerSourceMedium()
        {
            Console.WriteLine();
            Console.Write("Please select a (B)ATTERY or (S)OLAR power source for your Medium Gadget(s):  ");
                        
            string userPowerSourceString = Console.ReadLine().ToUpper();

            while ((userPowerSourceString != "B") && (userPowerSourceString != "S"))
            {
                Console.WriteLine();
                Console.Write("You must choose (B) or (S) : ");
                userPowerSourceString = Console.ReadLine().ToUpper();
            }

            return userPowerSourceString;
        }

        
        //Constructor which guides the user to enter the power choice selection
        public GadgetMedium()
        {
            string powerSource = UserPowerSourceMedium();
            
                if (powerSource == "B")
                {
                    this.PowerSource = "BATTERY";
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
