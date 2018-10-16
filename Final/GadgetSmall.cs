using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    public class GadgetSmall
    {
        private int _numOfWidgets  = 2;
        private int _numOfSwitches = 1;
        private int _numOfButtons  = 2;
        private int _numOfLights   = 0;
        private string _powerSource = "Battery";

        public virtual int NumOfWidgets
        {
            set
            {
                this._numOfWidgets = value;
            }
            get
            {
                return _numOfWidgets;
            }
        }

        public virtual int NumOfSwitches
        {
            set
            {
                this._numOfSwitches = value;
            }
            get
            {
                return _numOfSwitches;
            }
        }

        public virtual int NumOfButtons
        {
            set
            {
                this._numOfButtons = value;
            }
            get
            {
                return _numOfButtons;
            }
        }

        public virtual int NumOfLights
        {
            set
            {
                this._numOfLights = value;
            }
            get
            {
                return _numOfLights;
            }
        }

        public string PowerSource
        {
            get
            {
                return _powerSource;
            }
        }
    }
}
