using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAG;

namespace Gadget
{
    /// <summary>
    /// This abstract class describes what a basic Gadget "is".
    /// It can include fields, properties and methods.
    /// It can not be instantiated. No object can be directly created from it.
    /// </summary>
    
    public abstract class GadgetAbstract : IGadget, IWagProduct
    {
        //Auto-Implemented Properties
        //Best used when no special "get" or "set" will be implemented
        //The developer does not have to consider this
        public string Finish { get; set; } = "unfinished";  
        
        //Making these abstract will force the developer to create the 
        //  inheriting classes with thought to it's construction
        public abstract string Name { get; } 
        
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
