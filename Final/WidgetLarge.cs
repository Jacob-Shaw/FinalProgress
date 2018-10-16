using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    /* (backup)
    public class WidgetLarge : WidgetSmall
    {
        //Override auto properties with new default values
        public override int NumOfGears { get; set; } = 9;
        public override int NumOfSprings { get; set; } = 4;
        public override int NumOfLevers { get; set; } = 2;
    }
    */

    public class WidgetLarge : Widget
    {
        /* (backup)
        //Override auto properties with new default values
        public override int NumOfGears   { get; set; } = 9;
        public override int NumOfSprings { get; set; } = 4;
        public override int NumOfLevers  { get; set; } = 2;
        */

        public WidgetLarge()
        {
            //Console.WriteLine("WidgetLarge default constructor");
        }

        public virtual int NumOfGears
        {
            set
            {
                this._numOfGearsLarge = value;
            }
            get
            {
                return _numOfGearsLarge;
            }
        }

        public virtual int NumOfSprings
        {
            set
            {
                this._numOfSpringsLarge = value;
            }
            get
            {
                return _numOfSpringsLarge;
            }
        }

        public virtual int NumOfLevers
        {
            set
            {
                this._numOfLeversLarge = value;
            }
            get
            {
                return _numOfLeversLarge;
            }
        }
    }
}
