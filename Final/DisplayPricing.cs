using System;
using System.Collections.Generic;
using System.Text;

namespace week1.FINAL
{
    public class DisplayPricing
    {
        public void DisplayCurrentOrder(string size, int numberOfUnits, string power)
        {
            Pricing myPrices = new Pricing();

            switch (size)
            {
                case "Small":
                    GadgetSmall mySmallGadget = new GadgetSmall();

                    Console.WriteLine("Widget (cost per unit * unit-per-gadget-size * number of units purchased)");
                    Console.WriteLine("  - Small Widget .... " + myPrices.SmallWidgetCost + " * " + mySmallGadget.NumOfWidgets + " * " + numberOfUnits + " = " 
                        + (myPrices.SmallWidgetCost * mySmallGadget.NumOfWidgets * numberOfUnits).ToString("F2"));
                    double mySmallWidgetCost = myPrices.SmallWidgetCost * mySmallGadget.NumOfWidgets * numberOfUnits;
                    Console.WriteLine();

                    Console.WriteLine("Gadget Components (cost per unit * number for Gadget * number of units purchased)");
                    Console.WriteLine("  - Switch .......... " + myPrices.SwitchCostPerUnit + " * " + mySmallGadget.NumOfSwitches + " * " + numberOfUnits + " = "
                        + (myPrices.SwitchCostPerUnit * mySmallGadget.NumOfSwitches * numberOfUnits).ToString("F2"));
                    double mySmallSwitchCost = (myPrices.SwitchCostPerUnit * mySmallGadget.NumOfSwitches * numberOfUnits);

                    Console.WriteLine("  - Button .......... " + myPrices.ButtonCostPerUnit + " * " + mySmallGadget.NumOfButtons + " * " + numberOfUnits + " = "
                        + (myPrices.ButtonCostPerUnit * mySmallGadget.NumOfButtons * numberOfUnits).ToString("F2"));
                    double mySmallButtonCost = (myPrices.ButtonCostPerUnit * mySmallGadget.NumOfButtons * numberOfUnits);

                    Console.WriteLine("  - Light ........... " + myPrices.LightCostPerUnit + " * " + mySmallGadget.NumOfLights + " * " + numberOfUnits + " = "
                        + (myPrices.LightCostPerUnit * mySmallGadget.NumOfLights * numberOfUnits).ToString("F2"));
                    double mySmallLightCost = (myPrices.LightCostPerUnit * mySmallGadget.NumOfLights * numberOfUnits);

                    Console.WriteLine();
                    Console.WriteLine("Power Supplies (cost per unit * number of units purchased)");
                    Console.WriteLine("  - Battery ......... " + myPrices.BatteryCostPerUnit + " * " + numberOfUnits + " = "
                        + myPrices.BatteryCostPerUnit * numberOfUnits);
                    double mySmallBatteryCost = (myPrices.BatteryCostPerUnit * numberOfUnits);

                    Console.WriteLine("\n\n");
                    Console.WriteLine("Subtotal = " + (mySmallWidgetCost + mySmallSwitchCost + mySmallButtonCost + mySmallLightCost + mySmallBatteryCost).ToString("C"));
                    break;

                case "Medium":
                    GadgetMedium myMediumGadget = new GadgetMedium();

                    Console.WriteLine("Widget (cost per unit * unit-per-gadget-size * number of units purchased)");
                    Console.WriteLine("  - Medium Widget ... " + myPrices.MediumWidgetCost + " * " + myMediumGadget.NumOfWidgets + " * " + numberOfUnits + " = "
                        + (myPrices.MediumWidgetCost * myMediumGadget.NumOfWidgets * numberOfUnits).ToString("F2"));
                    double myMediumWidgetCost = myPrices.MediumWidgetCost * myMediumGadget.NumOfWidgets * numberOfUnits;
                    Console.WriteLine();

                    Console.WriteLine("Gadget Components (cost per unit * number for Gadget * number of units purchased)");
                    Console.WriteLine("  - Switch .......... " + myPrices.SwitchCostPerUnit + " * " + myMediumGadget.NumOfSwitches + " * " + numberOfUnits + " = "
                        + (myPrices.SwitchCostPerUnit * myMediumGadget.NumOfSwitches * numberOfUnits).ToString("F2"));
                    double myMediumSwitchCost = (myPrices.SwitchCostPerUnit * myMediumGadget.NumOfSwitches * numberOfUnits);

                    Console.WriteLine("  - Button .......... " + myPrices.ButtonCostPerUnit + " * " + myMediumGadget.NumOfButtons + " * " + numberOfUnits + " = "
                        + (myPrices.ButtonCostPerUnit * myMediumGadget.NumOfButtons * numberOfUnits).ToString("F2"));
                    double myMediumButtonCost = (myPrices.ButtonCostPerUnit * myMediumGadget.NumOfButtons * numberOfUnits);

                    Console.WriteLine("  - Light ........... " + myPrices.LightCostPerUnit + " * " + myMediumGadget.NumOfLights + " * " + numberOfUnits + " = "
                        + (myPrices.LightCostPerUnit * myMediumGadget.NumOfLights * numberOfUnits).ToString("F2"));
                    double myMediumLightCost = (myPrices.LightCostPerUnit * myMediumGadget.NumOfLights * numberOfUnits);

                    if(power == "B")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Power Supplies (cost per unit * number of units purchased)");
                        Console.WriteLine("  - Battery ......... " + myPrices.BatteryCostPerUnit + " * " + numberOfUnits + " = "
                            + myPrices.BatteryCostPerUnit * numberOfUnits);
                        double myMediumBatteryCost = (myPrices.BatteryCostPerUnit * numberOfUnits);

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
                        double myMediumSolarCost = (myPrices.SolarCostPerUnit * numberOfUnits);

                        Console.WriteLine("\n\n");
                        Console.WriteLine("Subtotal = " + (myMediumWidgetCost + myMediumSwitchCost + myMediumButtonCost + myMediumLightCost + myMediumSolarCost).ToString("C"));
                        break;
                    }

                case "Large":
                    GadgetLarge myLargeGadget = new GadgetLarge();

                    Console.WriteLine("Widget (cost per unit * unit-per-gadget-size * number of units purchased)");
                    Console.WriteLine("  - Large Widget .... " + myPrices.LargeWidgetCost + " * " + myLargeGadget.NumOfWidgets + " * " + numberOfUnits + " = "
                        + (myPrices.LargeWidgetCost * myLargeGadget.NumOfWidgets * numberOfUnits).ToString("F2"));
                    double myLargeWidgetCost = myPrices.LargeWidgetCost * myLargeGadget.NumOfWidgets * numberOfUnits;
                    Console.WriteLine();

                    Console.WriteLine("Gadget Components (cost per unit * number for Gadget * number of units purchased)");
                    Console.WriteLine("  - Switch .......... " + myPrices.SwitchCostPerUnit + " * " + myLargeGadget.NumOfSwitches + " * " + numberOfUnits + " = "
                        + (myPrices.SwitchCostPerUnit * myLargeGadget.NumOfSwitches * numberOfUnits).ToString("F2"));
                    double myLargeSwitchCost = (myPrices.SwitchCostPerUnit * myLargeGadget.NumOfSwitches * numberOfUnits);

                    Console.WriteLine("  - Button .......... " + myPrices.ButtonCostPerUnit + " * " + myLargeGadget.NumOfButtons + " * " + numberOfUnits + " = "
                        + (myPrices.ButtonCostPerUnit * myLargeGadget.NumOfButtons * numberOfUnits).ToString("F2"));
                    double myLargeButtonCost = (myPrices.ButtonCostPerUnit * myLargeGadget.NumOfButtons * numberOfUnits);

                    Console.WriteLine("  - Light ........... " + myPrices.LightCostPerUnit + " * " + myLargeGadget.NumOfLights + " * " + numberOfUnits + " = "
                        + (myPrices.LightCostPerUnit * myLargeGadget.NumOfLights * numberOfUnits).ToString("F2"));
                    double myLargeLightCost = (myPrices.LightCostPerUnit * myLargeGadget.NumOfLights * numberOfUnits);

                    if (power == "G")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Power Supplies (cost per unit * number of units purchased)");
                        Console.WriteLine("  - Generator ......... " + myPrices.GeneratorCostPerUnit + " * " + numberOfUnits + " = "
                            + myPrices.GeneratorCostPerUnit * numberOfUnits);
                        double myLargeGeneratorCost = (myPrices.GeneratorCostPerUnit * numberOfUnits);

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
                        double myLargeSolarCost = (myPrices.SolarCostPerUnit * numberOfUnits);

                        Console.WriteLine("\n\n");
                        Console.WriteLine("Subtotal = " + (myLargeWidgetCost + myLargeSwitchCost + myLargeButtonCost + myLargeLightCost + myLargeSolarCost).ToString("C"));
                        break;
                    }
            }
        }
    }
}
