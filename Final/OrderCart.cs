using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
//using week1.Fundamentals;

namespace week1.FINAL
{
    public class OrderCart
    {
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

            Console.WriteLine("You ordered " + numUserGadgetsEntered + " gadget(s), having power source of " + powerSelectionString);
            Console.WriteLine("Order summary is as follows:");
            Console.WriteLine("\n\n");

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
