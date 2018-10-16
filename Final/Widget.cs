using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    public abstract class Widget : IWidget
    {
        /* (backup) don't want to define values here?
        public int _numOfGears = 2;
        public int _numOfSprings = 3;
        public int _numOfLevers = 1;
        */

        /*
        public int _numOfGears;
        public int _numOfSprings;
        public int _numOfLevers;
        */

        public int _numOfGearsSmall = 2;
        public int _numOfSpringsSmall = 3;
        public int _numOfLeversSmall = 1;

        public int _numOfGearsMedium = 4;
        public int _numOfSpringsMedium = 5;
        public int _numOfLeversMedium = 3;

        public int _numOfGearsLarge = 9;
        public int _numOfSpringsLarge = 4;
        public int _numOfLeversLarge = 2;

        public virtual void DisplaySmallWidgetComponents()
        {
            //do we or do we not need "this."?
            Console.WriteLine("Gears: " + this._numOfGearsSmall);
            Console.WriteLine("Springs: " + this._numOfSpringsSmall);
            Console.WriteLine("Levers: " + _numOfLeversSmall);
        }

        public virtual void DisplayMediumWidgetComponents()
        {
            //do we or do we not need "this."?
            Console.WriteLine("Gears: " + this._numOfGearsMedium);
            Console.WriteLine("Springs: " + this._numOfSpringsMedium);
            Console.WriteLine("Levers: " + _numOfLeversMedium);
        }

        public virtual void DisplayLargeWidgetComponents()
        {
            //do we or do we not need "this."?
            Console.WriteLine("Gears: " + this._numOfGearsLarge);
            Console.WriteLine("Springs: " + this._numOfSpringsLarge);
            Console.WriteLine("Levers: " + _numOfLeversLarge);
        }
    }
}
