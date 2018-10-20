using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;


namespace week1.FINAL
{
    public class OrderCart
    {
        /// <summary>
        /// This class is not active!!!!!!!!!!!!!not used!!!!!!!!!!!!!!!!!! Comment out the whole class (gut it) make it the order form/cart
        /// </summary>
        /// <param name="numUserGadgetsEntered"></param>
        /// <param name="powerSelection"></param>

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
          
            
            
            
            
            
            //// Below was never touched by me
            ///









            /*
            List<Widget> myWidgets = new List<Widget>();
            myWidgets.Add(new WidgetSmall());
            myWidgets.Add(new WidgetMedium());

            foreach (Widget myStuff in myWidgets)
            {
                //Console.WriteLine(dinosaur);
                Console.WriteLine("My Order = " + myStuff);
            }
            */

            /*
            List<Dinosaur> myDinos = new List<Dinosaur>();
            myDinos.Add(new Dinosaur() { Size = 50, Teeth = "Serrated", Skin = true });
            myDinos.Add(new Pterodactyl() { Size = 25, Teeth = "Sharp" });
            myDinos.Add(new Dinosaur.Raptor() { Size = 10, Teeth = "Serrated", Skin = false });

            foreach (Dinosaur dinosaur in myDinos)
            {
                //Console.WriteLine(dinosaur);
                Console.WriteLine(dinosaur.Size);
            } 
            */
        }
        
    }
}
