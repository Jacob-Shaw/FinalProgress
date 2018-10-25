using FINAL;
using System;
using System.Collections.Generic;
using System.Text;
using WAG;

namespace Widget 
{
    /// <summary>
    /// This abstract class describes what a basic Gadget "is".
    /// It can include fields, properties and methods.
    /// It can not be instantiated. No object can be directly created from it.
    /// </summary>
    public abstract class WidgetAbstract : IWidget, IWagProductDecorator
    {
        /// By making these Auto-Implemented properties abstract we are helping to
        /// to tell the developer to set the values when creating a new Widget.
        public abstract int NumOfGears { get; set; }
        public abstract int NumOfSprings { get; set; }
        public abstract int NumOfLevers { get; set; }
        public abstract string Name { get; } 
            
        
        //For Decorator
        public decimal GetLineItemPrice { get { return GetPrice(); } }
        public string GetLineItemOrderDetails { get { return  (" +1 " + this.Name ); } }

        /// By creating this method we are giving all Widgets a method to
        /// meet the neeeds of IWidget. By being virtual, all Widgets which
        /// inherit from this class may override it with their own implementation.
        public virtual void DisplayComponents()
        {
            Console.WriteLine("Gears: " + this.NumOfGears);
            Console.WriteLine("Springs: " + this.NumOfSprings);
            Console.WriteLine("Levers: " + this.NumOfLevers);
        }

        public decimal GetPrice()
        {
            return ((NumOfGears * ComponentPricing.GearCostPerUnit) +
                        (NumOfSprings * ComponentPricing.SpringCostPerUnit) +
                        (NumOfLevers * ComponentPricing.LeverCostPerUnit));
        }




    }
}
