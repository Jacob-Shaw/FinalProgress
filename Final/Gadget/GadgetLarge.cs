using System;
using System.Collections.Generic;
using System.Text;

namespace Gadget
{
    /// <summary>
    /// This class describes the GadgetSmall!!!!!!!!!!!!!!!Should inherit from Gadget
    /// </summary>

    public class GadgetLarge : GadgetWithLights
    {

        public override string Name { get { return "Large Gadget"; } }

        public override int NumberOfWidgets { get; set; } = 12;
        public override int NumberOfSwitches { get; set; } = 2;
        public override int NumberOfButtons { get; set; } = 3;
        public override int NumberOfLights { get; set; } = 4;
        public override decimal Price { get; set; } = 50m;


        public override string PowerSource { get; set; }


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


        public GadgetLarge()
        {
            string powerSource = UserPowerSourceLarge();

            if (powerSource == "G")
            {
                this.PowerSource = "Generator";
            }
            else
            {
                this.PowerSource = "Solar";
            }
        }

        ///---------------------------------------------------old below----------------------------------------
        /*

        //Override auto properties with new default values
        public override int NumOfWidgets  { get; set; }  = 12;
        public override int NumOfSwitches { get; set; }  = 2;
        public override int NumOfButtons  { get; set; }  = 3;
        public override int NumOfLights   { get; set; }  = 4;

        public string _powerSource = "";  //TO-DO: will add user ability to choose power source ("Generator or Solar")

        /* (backup)
        private string _powerSource = "Generator or Solar";  //TO-DO: will add user ability to choose power source

        public new string PowerSource
        {
            get
            {
                return _powerSource;
            }
        }
        */

            /*
        public string ReturnPowerSource(string userEnteredPower)
        {
            if (userEnteredPower == "G")
            {
                return "Generator";
            }
            else
            {
                return "Solar";
            }
        

        */
    }
}

