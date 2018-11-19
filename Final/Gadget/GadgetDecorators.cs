using System;
using Final;
using WAG;

namespace Gadget
{
    public class GadgetDecorators
    {
        public class Switches : WagProductDecorator
        {
            public int NumOfSwitches { get; set; }
            
            string _name = (" Switch(es)");

            public Switches(IWagProduct newOrder) : base(newOrder)
            {
                Console.Write("How many Switches would you like to add to each gadget?");

                string Result = Console.ReadLine();
                
                Console.WriteLine();
                
                int numOfSwitches = 0;
                
                getSwitches();

                this.NumOfSwitches = numOfSwitches;

                void getSwitches()
                {
                    while (!Int32.TryParse(Result, out numOfSwitches))
                    {
                        Console.Write("Please enter a number: ");

                        Result = Console.ReadLine();
                    }
                    if (numOfSwitches < 0)
                    {
                        Console.WriteLine("You entered a negative number.  Converting to positive.");
                        numOfSwitches = Math.Abs(numOfSwitches);
                    }
                    else if (numOfSwitches == 0)
                    {
                        Console.WriteLine("Are you sure you meant to order 0? ");
                        Console.WriteLine("(Y) Yes      (Any other key) No ");

                        string confirm0 = Console.ReadLine().ToUpper();

                        if (confirm0 == "Y")
                        {
                            //Should drop at this point and go to Main Menu
                        }
                        else
                        {
                            getSwitches();
                        }
                    }
                    else //A good selection was made.
                    {
                        _name = (numOfSwitches + _name);
                    }
                }
                
                Console.WriteLine("Switches Added");
            }

            public override string GetLineItemOrderDetails {
                get { return tempOrder.GetLineItemOrderDetails + " " + this._name + " "; } }
            
            public override decimal GetLineItemPrice {
                get { return tempOrder.GetLineItemPrice + (NumOfSwitches * ComponentPricing.SwitchCostPerUnit); } }
            
        }

        public class Buttons : WagProductDecorator
        {
            string _name = " Button(s)";

            public int NumOfButtons { get; set; }


            public Buttons(IWagProduct newOrder) : base(newOrder)
            {
                Console.Write("How many Buttons would you like to add to each gadget?");

                string Result = Console.ReadLine();
                
                Console.WriteLine();
                
                int numOfButtons = 0;
                
                getButtons();
                this.NumOfButtons = numOfButtons;
                void getButtons()
                {
                    while (!Int32.TryParse(Result, out numOfButtons))
                    {
                        Console.Write("Please enter a number: ");

                        Result = Console.ReadLine();
                    }
                    if (numOfButtons < 0)
                    {
                        Console.WriteLine("You entered a negative number.  Converting to positive.");
                        numOfButtons = Math.Abs(numOfButtons);
                    }
                    else if (numOfButtons == 0)
                    {
                        Console.WriteLine("Are you sure you meant to order 0? ");
                        Console.WriteLine("(Y) Yes      (Any other key) No ");

                        string confirm0 = Console.ReadLine().ToUpper();

                        if (confirm0 == "Y")
                        {
                            //Should drop at this point and go to Main Menu

                        }
                        else
                        {
                            getButtons();
                        }
                    }
                    else //good number entered
                    {
                        _name = (numOfButtons + _name);
                    }
                }

                Console.WriteLine("Buttons Added");
            }

            public override string GetLineItemOrderDetails {
                get { return tempOrder.GetLineItemOrderDetails + " " + this._name + " "; } }
            
            public override decimal GetLineItemPrice {
                get { return tempOrder.GetLineItemPrice + (NumOfButtons * ComponentPricing.ButtonCostPerUnit); } }
        }

        public class Lights : WagProductDecorator
        {
            int numOfLights;
            string _name = " Light(s)";

            public int NumOfLights { get; set; }

            public Lights(IWagProduct newOrder) : base(newOrder)
            {
                Console.Write("How many Lights would you like to add to each gadget?");

                string Result = Console.ReadLine();
                
                Console.WriteLine();
                
                int numOfButtons = 0;
                
                getLights();

                this.NumOfLights = numOfButtons;
                void getLights()
                {
                    while (!Int32.TryParse(Result, out numOfLights))
                    {
                        Console.Write("Please enter a number: ");

                        Result = Console.ReadLine();
                    }
                    if (numOfLights < 0)
                    {
                        Console.WriteLine("You entered a negative number.  Converting to positive.");
                        numOfLights = Math.Abs(numOfLights);
                    }
                    else if (numOfLights == 0)
                    {
                        Console.WriteLine("Are you sure you meant to order 0? ");
                        Console.WriteLine("(Y) Yes      (Any other key) No ");

                        string confirm0 = Console.ReadLine().ToUpper();

                        if (confirm0 == "Y")
                        {
                            //Should drop at this point and go to Main Menu

                        }
                        else
                        {
                            getLights();
                        }
                    }
                    else //good number entered
                    {
                        _name = (numOfLights + _name);
                    }
                }
                
                Console.WriteLine("Lights Added");
            }
            public override string GetLineItemOrderDetails {
                get { return tempOrder.GetLineItemOrderDetails + this._name + " "; } }
            
            public override decimal GetLineItemPrice {
                get { return tempOrder.GetLineItemPrice + (NumOfLights * ComponentPricing.LightCostPerUnit); } }
        }
    }
}
