using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    //note that medium and large should implement Widget and not WidgetSmall.cs
    public class WidgetSmall : Widget
    {
        /* (backup) value n/a to be set here?
        private new int _numOfGears;
        private new int _numOfSprings;
        private new int _numOfLevers;
        */

        public WidgetSmall()
        {
            //Console.WriteLine("WidgetSmall default constructor");
        }

        public virtual int NumOfGears
        {
            set
            {
                this._numOfGearsSmall = value;
            }
            get
            {
                return _numOfGearsSmall;
            }
        }

        public virtual int NumOfSprings
        {
            set
            {
                this._numOfSpringsSmall = value;
            }
            get
            {
                return _numOfSpringsSmall;
            }
        }

        public virtual int NumOfLevers
        {
            set
            {
                this._numOfLeversSmall = value;
            }
            get
            {
                return _numOfLeversSmall;
            }
        }
    }
}
