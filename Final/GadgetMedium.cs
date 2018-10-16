using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    public class GadgetMedium : GadgetSmall
    {
        //Override auto properties with new default values
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
    }
}
