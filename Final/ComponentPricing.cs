using System;

namespace Final
{
    public static class ComponentPricing
    {
        // This class holds the componenet prices for building Widgets and Gadgets
       
        // Components
        public static decimal SwitchCostPerUnit { get; set; } = .19m;
        public static decimal ButtonCostPerUnit { get; set; } = .20m;
        public static decimal BatteryCostPerUnit { get; set; } = 6.32m;
        public static decimal GearCostPerUnit { get; set; } = .18m;
        public static decimal SpringCostPerUnit { get; set; } = 0.16m;
        public static decimal LeverCostPerUnit { get; set; } = .40m;
        public static decimal LightCostPerUnit { get; set; } = .26m;
        public static decimal SolarCostPerUnit { get; set; } = 12.21m;
        public static decimal GeneratorCostPerUnit { get; set; } = 51.51m;

        
        public static decimal GetPowerSourcePrice(string powerSource)
        {
            switch (powerSource.ToUpper())
            {
                case("BATTERY"):

                    return BatteryCostPerUnit;

                case ("SOLAR"):

                    return SolarCostPerUnit;

                case ("GENERATOR"):

                    return GeneratorCostPerUnit;

                default:

                    return 0m;
            }
        }   
    }
}
