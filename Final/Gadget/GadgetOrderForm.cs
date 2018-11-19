using System;
using WAG;

namespace Gadget
{
    // This order form has two order forms.
   
    public class GadgetOrderForm
    {
        private const string _retailOrder = "R";
        private const string _manufacturerOrder = "M";
        public string MyFinish = "Unfinished";
        
      
        public GadgetOrderForm()
        {
            // 1. Start of the Retail Gadget Order Form
            Console.Clear();

            // 2. Select the appropriate order form R or M 
            // 2b. Present the correct order form
            selectOrderForm();     
            
            // 3. Select the gadget size s,m,l
            GadgetSizeChoice myGadgetSize = new GadgetSizeChoice(); 
            string userGadgetSizeEntered = myGadgetSize.ChooseGadgetSize();  

            // 4. Select the number of gadgets to buy
            int numUserGadgetsEntered; 
            SelectNumberOfGadgets();

            // 5. Create a gadget 
            CreateGadgetSelection(userGadgetSizeEntered);    
            
            void selectOrderForm()
            {
                if (WagCustomerTypeAndOrder.CustomerType == "R")
                {
                    //Choose the retail order form
                    RetailOrderForm();

                }
                else if (WagCustomerTypeAndOrder.CustomerType == "M")
                {
                    ManufacturerOrderForm();
                }
            }

            void SelectNumberOfGadgets()
            {
                //Prompt user to enter number of Gadgets to order
                Console.WriteLine();
                Console.Write("Select NUMBER of " + userGadgetSizeEntered + " Gadgets to order: ");
                
                String Result = Console.ReadLine();

                Console.WriteLine();

                while (!Int32.TryParse(Result, out numUserGadgetsEntered))
                {
                    Console.Write("Please enter a number: ");

                    Result = Console.ReadLine();
                }
                if (numUserGadgetsEntered < 0)
                {
                    Console.WriteLine("You entered a negative number.  Converting to positive.");
                    numUserGadgetsEntered = Math.Abs(numUserGadgetsEntered);
                }
                else if (numUserGadgetsEntered == 0)
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
                        SelectNumberOfGadgets();
                    }
                }
            }
            
            
            void CreateGadgetSelection( string gadgetSizeToCreate )
            {
                // Based on previously chosen size of Gadget and the quantity chosen, 
                //    use gadgetOrderSummary to create an object of that type (and display all 
                //     information formatted nicely and ask the user if they agree to add this to
                //     the MasterOrderForm)

                GadgetOrderFormSubmission gadgetOrderSummary = new GadgetOrderFormSubmission();
                
                switch (userGadgetSizeEntered)
                {
                    case "Small":

                        gadgetOrderSummary.DisplayOrder(numUserGadgetsEntered, userGadgetSizeEntered);
                        
                        break;

                    case "Medium":
                        
                        gadgetOrderSummary.DisplayOrder(numUserGadgetsEntered, userGadgetSizeEntered);

                        break;

                    case "Large":
                      
                        gadgetOrderSummary.DisplayOrder(numUserGadgetsEntered, userGadgetSizeEntered);

                        break;
                }
            }
            
            void RetailOrderForm()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("================================================================================");
                Console.WriteLine("========================= " +
                    "WAG Gadget Order Form" +
                    " ================================");
                Console.WriteLine("===========================  " +
                    "RETAIL MAIN MENU" +
                    " ==================================");
                Console.WriteLine("================================================================================");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("                Widgets    Switches    Buttons    Lights     Power Supply");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("Small Gadget:      2          1          2          0          Battery");
                Console.WriteLine();
                Console.WriteLine("Medium Gadget:     5          1          3          3      Battery or Solar");
                Console.WriteLine();
                Console.WriteLine("Large Gadget:     12          2          3          4      Solar or Generator");
                Console.WriteLine();
                Console.WriteLine();

            }


            void ManufacturerOrderForm()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("================================================================================");
                Console.Write("============================= ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("WAG ORDER FORM");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ===================================");
                Console.Write("========================");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("  MANUFACTURER MAIN MENU");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ===============================");
                Console.WriteLine("================================================================================");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                Console.WriteLine("                Widgets    Switches    Buttons    Lights     Power Supply");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("Small Gadget:      2          1          2          0          Battery");
                Console.WriteLine();
                Console.WriteLine("Medium Gadget:     5          1          3          3      Battery or Solar");
                Console.WriteLine();
                Console.WriteLine("Large Gadget:     12          2          3          4      Solar or Generator");
                Console.WriteLine();
                Console.WriteLine();
                
            }
        }
    }
}
