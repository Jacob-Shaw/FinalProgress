using System;
using System.Collections.Generic;
using System.Text;
using WAG;

namespace Gadget
{

    /// <summary>
    /// This class describes GadgetMedium
    /// </summary>


    public class GadgetMedium : GadgetWithLights, IWagProduct
    {

        public override string Name { get { return "Medium Gadget"; } }

        
        public override int NumberOfWidgets { get; set; } = 5;
        public override int NumberOfSwitches { get; set; } = 1;
        public override int NumberOfButtons { get; set; } = 2;
        public override int NumberOfLights { get; set; } = 3;
        public override decimal Price { get; set; } = 50m;


        //If it has a field you do not know what to set it to, put it in the constructor.
        public override string PowerSource { get; set; }

        //I must create the constructor because PowerSource must be set.







        public string UserPowerSourceMedium()
        {

            /// This could be part of the order form!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Console.WriteLine();
            Console.WriteLine("Please select power source for Medium Gadget(s):  (B)attery or (S)olar");
            Console.WriteLine();

            
            ///This should be the implementations, methods called
            string userPowerSourceString = Console.ReadLine().ToUpper();

            while ((userPowerSourceString != "B") && (userPowerSourceString != "S"))
            {
                Console.WriteLine("You must choose (B) or (S)");
                userPowerSourceString = Console.ReadLine().ToUpper();
            }

            return userPowerSourceString;
        }






        public GadgetMedium()
        {
            string powerSource = UserPowerSourceMedium();

            
                if (powerSource == "B")
                {
                    this.PowerSource = "Battery";
                }
                else
                {
                    this.PowerSource = "Solar";
                }
            
        }



        ///-------------------------------------------OLD Below-----------------------------------------------

        /*
        public override int NumOfWidgets  { get; set; } = 5;
        public override int NumOfSwitches { get; set; } = 1;
        public override int NumOfButtons  { get; set; } = 3;
        public override int NumOfLights   { get; set; } = 3;

        public string _powerSource = "";  //TO-DO: will add user ability to choose power source ("Battery or Solar")


        /* (backup)
        private string _powerSource = "Battery or Solar";  //TO-DO: will add user ability to choose power source

        public new string PowerSource
        {
            get
            {
                return _powerSource;
            }
        }
        */


        /*
    public string ReturnPowerSource (string userEnteredPower)
    {
        if (userEnteredPower == "B")
        {
            return "Battery";
        }
        else
        {
            return "Solar";
        }
    }


    */



    }
}
