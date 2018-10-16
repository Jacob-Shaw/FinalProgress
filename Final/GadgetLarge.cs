using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    public class GadgetLarge : GadgetSmall
    {
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
        }
    }
}

