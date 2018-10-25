using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;


namespace sssssssssssssssssssssssssssssssssssssssssssssssssssssss
{
    public class OrderCart
    {
        /// <summary>
        /// This class is not active!!!!!!!!!!!!!not used!!!!!!!!!!!!!!!!!! Comment out the whole class (gut it) make it the order form/cart
        /// </summary>
        

        //Variables include # of Gadgets, Power Source, and Finish Option
        public void MyOrderCart(int numUserGadgetsEntered, string powerSelection)
        {
            string powerSelectionString = ""; 

            switch (powerSelection)
            {
                case "B":
                    powerSelectionString = "Battery";
                    break;

                case "S":
                    powerSelectionString = "Solar";
                    break;

                case "G":
                    powerSelectionString = "Generator";
                    break;
            }

            Console.WriteLine("Hey how are you");

            Console.WriteLine("You ordered " + numUserGadgetsEntered + " gadget(s), having power source of " + powerSelectionString);
            Console.WriteLine("Order summary is as follows:");
            Console.WriteLine("\n\n");
          
        }
        
    }
}
