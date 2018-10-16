using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    /* (backup)
    public class WidgetMedium : WidgetSmall
    {
        //Override auto properties with new default values
        public override int NumOfGears { get; set; } = 4;
        public override int NumOfSprings { get; set; } = 5;
        public override int NumOfLevers { get; set; } = 3;
    }
    */

    public class WidgetMedium : Widget
    {
        public WidgetMedium()
        {
            //Console.WriteLine("WidgetMedium default constructor");
        }

        public virtual int NumOfGears
        {
            set
            {
                this._numOfGearsMedium = value;
            }
            get
            {
                return _numOfGearsMedium;
            }
        }

        public virtual int NumOfSprings
        {
            set
            {
                this._numOfSpringsMedium = value;
            }
            get
            {
                return _numOfSpringsMedium;
            }
        }

        public virtual int NumOfLevers
        {
            set
            {
                this._numOfLeversMedium = value;
            }
            get
            {
                return _numOfLeversMedium;
            }
        }
    }
}
