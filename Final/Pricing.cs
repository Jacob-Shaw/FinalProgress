using System;
using System.Collections.Generic;
using System.Text;

namespace FINAL
{
    public static class ComponentPricing
    {
        // This class holds the componenet prices for building Widgets and Gadgets
        //Widget Components
        

        // Components
        public static decimal SwitchCostPerUnit { get; set; } = 4.99m;
        public static decimal ButtonCostPerUnit { get; set; } = 1.87m;
        public static decimal BatteryCostPerUnit { get; set; } = 6.32m;
        public static decimal GearCostPerUnit { get; set; } = 1.32m;
        public static decimal SpringCostPerUnit { get; set; } = 0.52m;
        public static decimal LeverCostPerUnit { get; set; } = 3.10m;
        public static decimal LightCostPerUnit { get; set; } = 4.76m;
        public static decimal SolarCostPerUnit { get; set; } = 20.21m;
        public static decimal GeneratorCostPerUnit { get; set; } = 64.10m;

        public static decimal GetPowerSourcePrice(string powerSource)
        {
            switch (powerSource)
            {
                case("Battery"):

                    return BatteryCostPerUnit;

                case ("Solar"):

                    return SolarCostPerUnit;

                case ("Generator"):

                    return GeneratorCostPerUnit;

                default:

                    return 0m;
            }
        }
    }
}
