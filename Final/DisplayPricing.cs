using System;
using System.Collections.Generic;
using System.Text;
using Gadget;
using FINAL;

namespace Final
{
    public class DisplayPricing
    {
        ///@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        ////// This class will display your current order and !!!!!!!!!!!!!!!!!!!Should add to cart afterwards
        ///@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        ///@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


        public void DisplayCurrentOrder(string size, int numberOfUnits, string power)
        {
            /*



            ComponentPricing myPrices = new ComponentPricing();

            switch (size)
            {
                case "Small":
                    GadgetSmall mySmallGadget = new GadgetSmall();

                    Console.WriteLine("Widget (cost per unit * unit-per-gadget-size * units purchased)");
                    Console.WriteLine("  - Small Widget .... " + mySmallGadget.Price + " * " + mySmallGadget.NumberOfWidgets + " * " + numberOfUnits + " = " 
                        + (mySmallGadget.Price * mySmallGadget.NumberOfWidgets * numberOfUnits).ToString("F2"));

                    Console.WriteLine();

                    Console.WriteLine("Gadget Components (cost per unit * Gadgets * units purchased)");
                    Console.WriteLine("  - Switch .......... " + myPrices.SwitchCostPerUnit + " * " + mySmallGadget.NumberOfSwitches + " * " + numberOfUnits + " = "
                        + (myPrices.SwitchCostPerUnit * mySmallGadget.NumberOfSwitches * numberOfUnits).ToString("F2"));
                    decimal mySmallSwitchCost = (myPrices.SwitchCostPerUnit * mySmallGadget.NumberOfSwitches * numberOfUnits);

                    Console.WriteLine("  - Button .......... " + myPrices.ButtonCostPerUnit + " * " + mySmallGadget.NumberOfButtons + " * " + numberOfUnits + " = "
                        + (myPrices.ButtonCostPerUnit * mySmallGadget.NumberOfButtons * numberOfUnits).ToString("F2"));
                    decimal mySmallButtonCost = (myPrices.ButtonCostPerUnit * mySmallGadget.NumberOfButtons * numberOfUnits);

                    Console.WriteLine("  - Light ........... " + myPrices.LightCostPerUnit + " * " + " * " + numberOfUnits + " = "
                        + (myPrices.LightCostPerUnit * numberOfUnits).ToString("F2"));
                    decimal mySmallLightCost = (myPrices.LightCostPerUnit * numberOfUnits);

                    Console.WriteLine();
                    Console.WriteLine("Power Supplies (cost per unit * units purchased)");
                    Console.WriteLine("  - Battery ......... " + myPrices.BatteryCostPerUnit + " * " + numberOfUnits + " = "
                        + myPrices.BatteryCostPerUnit * numberOfUnits);
                    decimal mySmallBatteryCost = (myPrices.BatteryCostPerUnit * numberOfUnits);

                    Console.WriteLine("\n\n");
                    Console.WriteLine("Subtotal = " + (mySmallWidgetCost + mySmallSwitchCost + mySmallButtonCost + mySmallLightCost + mySmallBatteryCost).ToString("C"));
                    break;

                case "Medium":
                    GadgetMedium myMediumGadget = new GadgetMedium();

                    Console.WriteLine("Widget (cost per unit * unit-per-gadget-size * number of units purchased)");
                    Console.WriteLine("  - Medium Widget ... " + myMediumGadget.Price + " * " + myMediumGadget.NumberOfWidgets + " * " + numberOfUnits + " = "
                        + (myMediumGadget.Price * myMediumGadget.NumberOfWidgets * numberOfUnits).ToString("F2"));
                    decimal myMediumWidgetCost = myMediumGadget.Price * myMediumGadget.NumberOfWidgets * numberOfUnits;
                    Console.WriteLine();

                    Console.WriteLine("Gadget Components (cost per unit * number for Gadget * number of units purchased)");
                    Console.WriteLine("  - Switch .......... " + myPrices.SwitchCostPerUnit + " * " + myMediumGadget.NumberOfSwitches + " * " + numberOfUnits + " = "
                        + (myPrices.SwitchCostPerUnit * myMediumGadget.NumberOfSwitches * numberOfUnits).ToString("F2"));
                    decimal myMediumSwitchCost = (myPrices.SwitchCostPerUnit * myMediumGadget.NumberOfSwitches * numberOfUnits);

                    Console.WriteLine("  - Button .......... " + myPrices.ButtonCostPerUnit + " * " + myMediumGadget.NumberOfButtons + " * " + numberOfUnits + " = "
                        + (myPrices.ButtonCostPerUnit * myMediumGadget.NumberOfButtons * numberOfUnits).ToString("F2"));
                    decimal myMediumButtonCost = (myPrices.ButtonCostPerUnit * myMediumGadget.NumberOfButtons * numberOfUnits);

                    Console.WriteLine("  - Light ........... " + myPrices.LightCostPerUnit + " * " + myMediumGadget.NumberOfLights + " * " + numberOfUnits + " = "
                        + (myPrices.LightCostPerUnit * myMediumGadget.NumberOfLights * numberOfUnits).ToString("F2"));
                    decimal myMediumLightCost = (myPrices.LightCostPerUnit * myMediumGadget.NumberOfLights * numberOfUnits);

                    if(power == "B")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Power Supplies (cost per unit * number of units purchased)");
                        Console.WriteLine("  - Battery ......... " + myPrices.BatteryCostPerUnit + " * " + numberOfUnits + " = "
                            + myPrices.BatteryCostPerUnit * numberOfUnits);
                        decimal myMediumBatteryCost = (myPrices.BatteryCostPerUnit * numberOfUnits);

                        Console.WriteLine("\n\n");
                        Console.WriteLine("Subtotal = " + (myMediumWidgetCost + myMediumSwitchCost + myMediumButtonCost + myMediumLightCost + myMediumBatteryCost).ToString("C"));
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Power Supplies (cost per unit * number of units purchased)");
                        Console.WriteLine("  - Solar ..--....... " + myPrices.SolarCostPerUnit + " * " + numberOfUnits + " = "
                            + myPrices.SolarCostPerUnit * numberOfUnits);
                        decimal myMediumSolarCost = (myPrices.SolarCostPerUnit * numberOfUnits);

                        Console.WriteLine("\n\n");
                        Console.WriteLine("Subtotal = " + (myMediumWidgetCost + myMediumSwitchCost + myMediumButtonCost + myMediumLightCost + myMediumSolarCost).ToString("C"));
                        break;
                    }

                case "Large":
                    GadgetLarge myLargeGadget = new GadgetLarge();

                    Console.WriteLine("Widget (cost per unit * unit-per-gadget-size * number of units purchased)");//////
                    Console.WriteLine("  - Large Widget .... " + myPrices.SwitchCostPerUnit+ " * " + myLargeGadget.NumberOfWidgets + " * " + numberOfUnits + " = "
                        + (myPrices.LargeWidgetCost * myLargeGadget.NumberOfWidgets * numberOfUnits).ToString("F2"));
                    decimal myLargeWidgetCost = myPrices.LargeWidgetCost * myLargeGadget.NumberOfWidgets * numberOfUnits;
                    Console.WriteLine();

                    Console.WriteLine("Gadget Components (cost per unit * number for Gadget * number of units purchased)");
                    Console.WriteLine("  - Switch .......... " + myPrices.SwitchCostPerUnit + " * " + myLargeGadget.NumberOfSwitches + " * " + numberOfUnits + " = "
                        + (myPrices.SwitchCostPerUnit * myLargeGadget.NumberOfSwitches * numberOfUnits).ToString("F2"));
                    decimal myLargeSwitchCost = (myPrices.SwitchCostPerUnit * myLargeGadget.NumberOfSwitches * numberOfUnits);

                    Console.WriteLine("  - Button .......... " + myPrices.ButtonCostPerUnit + " * " + myLargeGadget.NumberOfButtons + " * " + numberOfUnits + " = "
                        + (myPrices.ButtonCostPerUnit * myLargeGadget.NumberOfButtons * numberOfUnits).ToString("F2"));
                    decimal myLargeButtonCost = (myPrices.ButtonCostPerUnit * myLargeGadget.NumberOfButtons * numberOfUnits);

                    Console.WriteLine("  - Light ........... " + myPrices.LightCostPerUnit + " * " + myLargeGadget.NumberOfLights + " * " + numberOfUnits + " = "
                        + (myPrices.LightCostPerUnit * myLargeGadget.NumberOfLights * numberOfUnits).ToString("F2"));
                    decimal myLargeLightCost = (myPrices.LightCostPerUnit * myLargeGadget.NumberOfLights * numberOfUnits);

                    if (power == "G")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Power Supplies (cost per unit * number of units purchased)");
                        Console.WriteLine("  - Generator ......... " + myPrices.GeneratorCostPerUnit + " * " + numberOfUnits + " = "
                            + myPrices.GeneratorCostPerUnit * numberOfUnits);
                        decimal myLargeGeneratorCost = (myPrices.GeneratorCostPerUnit * numberOfUnits);

                        Console.WriteLine("\n\n");
                        Console.WriteLine("Subtotal = " + (myLargeWidgetCost + myLargeSwitchCost + myLargeButtonCost + myLargeLightCost + myLargeGeneratorCost).ToString("C"));
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Power Supplies (cost per unit * number of units purchased)");
                        Console.WriteLine("  - Solar ........... " + myPrices.SolarCostPerUnit + " * " + numberOfUnits + " = "
                            + myPrices.SolarCostPerUnit * numberOfUnits);
                        decimal myLargeSolarCost = (myPrices.SolarCostPerUnit * numberOfUnits);

                        Console.WriteLine("\n\n");
                        Console.WriteLine("Subtotal = " + (myLargeWidgetCost + myLargeSwitchCost + myLargeButtonCost + myLargeLightCost + myLargeSolarCost).ToString("C"));
                        break;
                    }
            } */
        }
    }
}
