using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAG;

namespace Gadget
{
    ///***********************************************************************
    /// <summary>
    /// This abstract class describes what a basic Gadget "is".
    /// It can include fields, properties and methods.
    /// It can not be instantiated. No object can be directly created from it.
    /// </summary>
    /// **********************************************************************

    public abstract class Gadget : IGadget, IWagProduct
    {
        /*
        //Fields
        private int _numOfWidgets; 
        private int _numOfSwitches;
        private int _numOfButtons;
        private string _powerSource;
        private decimal _price;
        */

        //When some are different than others         if will be used by constructor for base object          at creation
        //Auto-Implemented Properties
        //Best used when no special "get" or "set" will be implemented
        //The developer does not have to consider this
        public string Finish { get; set; } = "unfinished";  //wont be used by constructor for base object/can be set /has default



        //When they default to a value
        //Properties
        //Making these abstract will force a name and price to be created. ***These 6 pushed into child classes.***
        public abstract string Name { get; }  //identifier

        //The developer should look at these
        public abstract string PowerSource { get; set; }  
        public abstract int NumberOfWidgets { get; set; }  
        public abstract int NumberOfSwitches { get; set; }  
        public abstract int NumberOfButtons { get; set; }   
        public abstract decimal Price { get; set; }  


        //Methods
        public void DisplayComponents()
        {
            Console.WriteLine("Widgets: " + this.NumberOfWidgets);
            Console.WriteLine("Swithes: " + this.NumberOfSwitches);
            Console.WriteLine("Buttons: " + this.NumberOfButtons);
            Console.WriteLine("PowerSource: " + this.PowerSource);
        }

        public void DisplayName()
        {
            Console.WriteLine(Name);
        }

        public void DisplayPriceDollars()
        {
            Console.WriteLine("$" + this.Price);
        }
    }
}
