using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadget
{
    /// <summary>
    /// 
    /// This interface basically says what a Gadget should be able to "do".
    /// 
    /// An Interface:
    /// 1. Creates a contract on what methods a Gadget must have.
    /// 2. By creating the contract can help the IDE to inform the user what methods are 
    ///         needed in the creation of a new Gadget.
    /// 3. Can be used to create a body of methods for creational design pattterns to build from.
    /// 
    /// </summary>


    interface IGadget
    {
        void DisplayName();
        void DisplayComponents();
        void DisplayPriceDollars();
    }
}
