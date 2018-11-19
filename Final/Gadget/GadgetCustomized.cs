using System;

namespace Gadget
{
    public class GadgetCustomized : GadgetWithLights
    {
        public override string Name { get { return "Customized Gadget"; } }

        public override int NumberOfSmallWidgets { get; set; } = 0;
        public override int NumberOfMediumWidgets { get; set; } = 0;
        public override int NumberOfLargeWidgets { get; set; } = 0;
        public override int NumberOfSwitches { get; set; } = 0;
        public override int NumberOfButtons { get; set; } = 0;
        public override int NumberOfLights { get; set; } = 0;
        
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
    }
}
