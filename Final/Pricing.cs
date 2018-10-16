using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    public class Pricing
    {
        //Gadget Components
        private double _switchCostPerUnit    = 10.99;
        private double _buttonCostPerUnit    = 20.87;
        private double _lightCostPerUnit     = 30.76;

        //Power Supplies
        private double _batteryCostPerUnit   = 500.32;
        private double _solarCostPerUnit     = 900.21;
        private double _generatorCostPerUnit = 1100.10;

        //Widget Cost per Size
        private double _smallWidget          = 12.65;
        private double _mediumWidget         = 14.54;
        private double _largeWidget          = 16.43;

        public virtual double SwitchCostPerUnit
        {
            set
            {
                this._switchCostPerUnit = value;
            }
            get
            {
                return _switchCostPerUnit;
            }
        }

        public virtual double ButtonCostPerUnit
        {
            set
            {
                this._buttonCostPerUnit = value;
            }
            get
            {
                return _buttonCostPerUnit;
            }
        }

        public virtual double LightCostPerUnit
        {
            set
            {
                this._lightCostPerUnit = value;
            }
            get
            {
                return _lightCostPerUnit;
            }
        }

        public virtual double SmallWidgetCost
        {
            set
            {
                this._smallWidget = value;
            }
            get
            {
                return _smallWidget;
            }
        }

        public virtual double MediumWidgetCost
        {
            set
            {
                this._mediumWidget = value;
            }
            get
            {
                return _mediumWidget;
            }
        }

        public virtual double LargeWidgetCost
        {
            set
            {
                this._largeWidget = value;
            }
            get
            {
                return _largeWidget;
            }
        }

        public virtual double BatteryCostPerUnit
        {
            set
            {
                this._batteryCostPerUnit = value;
            }
            get
            {
                return _batteryCostPerUnit;
            }
        }

        public virtual double SolarCostPerUnit
        {
            set
            {
                this._solarCostPerUnit = value;
            }
            get
            {
                return _solarCostPerUnit;
            }
        }

        public virtual double GeneratorCostPerUnit
        {
            set
            {
                this._generatorCostPerUnit = value;
            }
            get
            {
                return _generatorCostPerUnit;
            }
        }
    }
}
