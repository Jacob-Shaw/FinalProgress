using System;

namespace Widget
{
    /// <summary>
    /// 
    /// This interface basically says what a Widget should be able to "do".
    /// 
    /// An Interface:
    /// 1. Creates a contract on what methods a Widget must have.
    /// 2. By creating the contract can help the IDE to inform the user what methods are 
    ///         needed in the creation of a new Widget.
    /// 3. Can be used to create a body of methods for creational design pattterns to build from.
    /// 
    /// </summary>
    public interface IWidget 
    {
        void DisplayComponents();
        decimal GetPrice();
    }
}
