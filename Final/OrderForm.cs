using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    public class OrderForm
    {
        private const string _retailOrder       = "R";
        private const string _manufacturerOrder = "M";

        public void UserOrderForm(string userOrderType)
        {
            if(userOrderType == _retailOrder)
            {
                Console.WriteLine("=============================================================================");
                Console.WriteLine("============================= WAG Order Form ================================");
                Console.WriteLine("===========================  RETAIL MAIN MENU ===============================");
                Console.WriteLine("=============================================================================");

                Console.WriteLine();
                Console.WriteLine("From this menu, you may enter the SIZE and QUANTITY of Gadgets and, ");
                Console.WriteLine("based on your choice, various selections of switches, buttons, lights,");
                Console.WriteLine("finishes, and power sources are available.");
                Console.WriteLine();
                Console.WriteLine("*** NOTE: Customization is only available via the Manufacturer option ***");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Small Gadget defaults:");
                Console.WriteLine(" -- 2 Widgets, 1 Switch, 2 Buttons, 0 Lights");
                Console.WriteLine(" -- Power Supply = Battery");
                Console.WriteLine();
                Console.WriteLine("Medium Gadget defaults:");
                Console.WriteLine(" -- 5 Widgets, 1 Switch, 3 Buttons, 3 Lights");
                Console.WriteLine(" -- Power Supply = Battery or Solar");
                Console.WriteLine();
                Console.WriteLine("Large Gadget defaults:");
                Console.WriteLine(" -- 12 Widgets, 2 Switches, 3 Buttons, 4 Lights");
                Console.WriteLine(" -- Power Supply = Solar or Generator");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("* Any of the above come with your choice of finish -- Plain, Painted, or Plated");
            }

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            else
            {
                Console.WriteLine("=============================================================================");
                Console.WriteLine("============================= WAG Order Form ================================");
                Console.WriteLine("========================  MANUFACTURER MAIN MENU ============================");
                Console.WriteLine("=============================================================================");

                Console.WriteLine();
                Console.WriteLine("................Jacob's stuff....................");
                Console.WriteLine();

                //delete this after adding Manufacturer option code
                Environment.Exit(0);
            }

        }
    }
}
