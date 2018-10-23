using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gadget;

namespace WAG
{
    public class WagProductCatalog
    {
        // List of company products
        string[] WagProductsList = new string[] { "Gadget", "Other Item For Sale No Order Form" };

        
        // Method for displaying the title
        public void displayCatalogTitle()
        {
            Console.Clear();
            Console.WriteLine("=============================================================================");
            Console.WriteLine("========================== WAG Product Catalog ==============================");
            Console.WriteLine("=============================================================================");
            Console.WriteLine();
        }
        
        public void displayOrderFormTitle()
        {
            Console.Clear();
            Console.WriteLine("=============================================================================");
            Console.WriteLine("============================ WAG Order Form =================================");
            Console.WriteLine("=============================================================================");
            Console.WriteLine();
        }

        // Method for displaying the Products Listed at top of this class
        public void presentProducts()
        {
            int counter = 1;

            foreach (string product in WagProductsList)
            {
                Console.WriteLine(counter + ". " + product);
                counter++;
            }
        }
        
        /// Method for asking and getting the user choice from the products menu
        public void getUserChoice()
        {
            Console.WriteLine();
            
            string userChoice = ""; 
            
            int check = 0;

            
            // Get new input from the customer if the user entry is not a number
            while (!Int32.TryParse(userChoice, out check))
            {
                Console.WriteLine("Please select a product number from the catalog: ");
                userChoice = Console.ReadLine();
            }

            
            // Less than 0? Let's see if Absolute Value will solve the problem,
            if (check < 0)
            {
                Console.WriteLine("You're number was less than 0.");
                check = Math.Abs(check);
               
                // If converting to a positive number gives a proper selection
                if ((check <= WagProductsList.Length) && (check != 0))
                {
                    
                    try  // Try to see if there is a related order form
                    {
                        int checkNumber = check;

                        string checkThisItem = WagProductsList.ElementAt(checkNumber -1 );
                        
                        // Remove all the spaces from the product name
                        checkThisItem = checkThisItem.Replace(" ", String.Empty);
                        
                        // Perform this LINQ to see if the product name + OrderForm exists in our application
                        var IteminQuestion = checkThisItem + "OrderForm";
                        var ItemWeAreTryingToCreate = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                                                       from type in assembly.GetTypes()
                                                       where type.Name == IteminQuestion
                                                       select type).FirstOrDefault();
                        
                        ///See if there is a class order form with name of ItemWeAreTryingToCreate exists 
                        ///-- if so, then use order form, otherwise add directly to masterlist
                        if (ItemWeAreTryingToCreate == null) throw new InvalidOperationException(); 

                        //This will create the new instance
                        object newType = Activator.CreateInstance(ItemWeAreTryingToCreate);


                        ///Now it is special order form time!
                        ///In the constructor for the special order forms:
                        ///Display the info, collect choices, add to masterorderform
                        ///do retail first
                        ///
                        /// Program returns to this point after ordering or not ordering Gadgets!!!!!
                        /// 

                    }
                    catch (InvalidOperationException)
                    {       
                        //Add the product with no order form to the MasterList
                        //  and then go to the Main Menu

                        string checkThisItem2 = WagProductsList.ElementAt(check - 1);
                        
                        WagCustomerTypeAndOrder.MasterOrderForm.Add(checkThisItem2);

                        displayOrderFormTitle();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        PresentSelectionMenu();
                    }
                    finally
                    {
                        // Code in this block will always execute.
                    }
                }
                else
                {      // The user selection ended up being greater than the length of the list.
                    displayCatalogTitle();

                    presentProducts();

                    Console.WriteLine();
                    Console.WriteLine("You entered a negative number.  Converting to positive did not help.");
                    Console.WriteLine();

                    // Ask the user to try adding a product again.
                    getUserChoice();
                }
            }

            
            // If the user selection wa greater than the product list or equal to 0,
            //  then ask then to try selecting again.
            else if ( (check > WagProductsList.Length) || ( check == 0 ))
            {
                displayCatalogTitle();

                presentProducts();
                
                Console.WriteLine();
                Console.WriteLine("The selection you have made does not exist.");
                Console.WriteLine();

                getUserChoice();
            }
            
            //  A valid selection was made!
            else
            {
                ///Take customer to order form if one exists, otherwise add product directly to MasterOrderForm.
                
                try
                {
                    //Number to be used in checking user choice in Product Catalog
                    int checkNumber = check - 1;

                    string checkThisItem = WagProductsList.ElementAt(checkNumber); 
                    
                    //Remove any spaces in the name
                    checkThisItem = checkThisItem.Replace(" ", String.Empty);
                    
                    //The following code checks to see if there is a class with the product choice name + OrderForm
                    var IteminQuestion = checkThisItem + "OrderForm";
                    var ItemWeAreTryingToCreate = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                                                   from type in assembly.GetTypes()
                                                   where type.Name == IteminQuestion
                                                   select type).FirstOrDefault();

                    ///See if there is a class order form with name of ItemWeAreTryingToCreate exists 
                    ///-- if so, then use order form, otherwise add directly to masterlist
                    if (ItemWeAreTryingToCreate == null) throw new InvalidOperationException("Valid type not found.");

                    object newType = Activator.CreateInstance(ItemWeAreTryingToCreate);

                    ///Now it is special order form time!
                    ///In the constructor for the special order forms:
                    ///Display the info, collect choices, add to masterorderform
                    ///do retail first
                    ///
                    /// Program returns to this point after ordering or not ordering Gadgets!!!!!
                    /// 

                    Console.Clear();
                    PresentSelectionMenu();
                    
                }
                catch (InvalidOperationException)
                {

                    // Adding the correctly entered item number to the MasterOrderForm directly 
                    //   because it has no special order form.
                    
                    string checkThisItem3 = WagProductsList.ElementAt(check - 1);
                    
                    WagCustomerTypeAndOrder.MasterOrderForm.Add(checkThisItem3);


                    displayOrderFormTitle();
                    printItAll();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    PresentSelectionMenu();

                }
                finally
                {

                }
            }
        }

        
        private void PresentSelectionMenu()
        {
            Console.WriteLine("=============================================================================");
            Console.WriteLine("============================= WAG Main Menu =================================");
            Console.WriteLine("=============================================================================");
            Console.WriteLine();
            Console.WriteLine("(A) Add an item to your order  ");
            Console.WriteLine("(D) Display your current order");
            Console.WriteLine("(R) Remove an item from your order form");
            Console.WriteLine("(P) Proceed to confirm your order for checkout");
            Console.WriteLine("(X) Cancel the order and exit");
            Console.WriteLine();
            Console.WriteLine("Please make a selection:");

            string userChoice = Console.ReadLine();
            
            //Get a selection from the customer 
            //Customer may Add an item, Display the current order, Remove an item,   
            //          Proceed to customer checkout, or Cancel the order and exit

            switch (userChoice.ToUpper())
            {
                case "A":
                                        // Code to Add a new product to the Order Form

                    Console.Clear();

                    displayCatalogTitle();

                    presentProducts();

                    getUserChoice();

                    break;

                case "D":
                                        // Code to Display the Order Form

                    displayOrderFormTitle();

                    printItAll();       
                    
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();

                    PresentSelectionMenu();

                    break;

                case "R":
                                        // Code to remove the item from the list

                    printItAll();
                    Console.WriteLine();
                    Console.WriteLine("Are you sure you wish to remove an item from your order?");
                    Console.WriteLine("(Y) Yes  -or-  or Press any other key to return to Main Menu. ");
                    string removeAnswer = Console.ReadLine();

                    if (removeAnswer.ToUpper() == "Y")
                    {
                        Console.WriteLine("Which Line item would you like to remove?");
                        string removeLine = Console.ReadLine();


                        ///Make sure it is a number first!
                        int check = 0;


                        //Get a selection from the customer  //if the user entry is not a number
                        while (!Int32.TryParse(removeLine, out check))
                        {
                            Console.WriteLine("Please select a line item from the order: ");
                            userChoice = Console.ReadLine();
                        }
                        
                        int lineItem = Math.Abs(check);
                        
                        if ((lineItem > WagCustomerTypeAndOrder.MasterOrderForm.Count) || (check <= 0))
                        {
                            Console.WriteLine("The line item you entered could not be found.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            PresentSelectionMenu();

                        }
                        else
                        {
                            Console.WriteLine("Are you sure you wish to remove line item #" + lineItem + "?");
                            Console.WriteLine("(Y) Yes  -or-  or Press any other key to return to Main Menu. ");

                            string confirmRemoval = Console.ReadLine().ToUpper();

                            if (confirmRemoval == "Y")
                            {
                                WagCustomerTypeAndOrder.MasterOrderForm.RemoveAt(lineItem -1);
                                Console.Clear();
                                displayOrderFormTitle();
                                printItAll();
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                Console.Clear();
                                PresentSelectionMenu();
                            }
                            else
                            {
                                Console.Clear();
                                PresentSelectionMenu();
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        PresentSelectionMenu(); 
                    }
                    
                    break;
                    
///@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

                case "P":
                                        // Code to Proceed to Checkout





                    break;
                    
                case "X":
                                        // Code to Cancel the order and Exit

                    Console.WriteLine();
                    Console.WriteLine("Are you sure you wish to cancel your order and exit?");
                    Console.WriteLine("(Y) Yes  -or-  or Press any other key to return to Main Menu. ");

                    string exitAnswer = Console.ReadLine();

                    if (exitAnswer.ToUpper() == "Y")
                        Environment.Exit(0);
                    else
                    {
                        Console.Clear();
                        PresentSelectionMenu();
                    }
                    break;

                default:
                                        // Code to execute if no proper selection was made.

                    Console.Clear();

                    PresentSelectionMenu();

                    break;
            }
        }
        
        // Method to print all of the items in the customer order to the console
        void printItAll()
        {
            Console.Clear();
            displayOrderFormTitle();
            Console.WriteLine();

            // If there are no items in the order form
            if (WagCustomerTypeAndOrder.MasterOrderForm.Count == 0)
            {
                Console.WriteLine("There are no items in your order.");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                PresentSelectionMenu();
            }
               
            int counter = 1;

            // Print everything in the order form
            foreach (Object entry in WagCustomerTypeAndOrder.MasterOrderForm)
            {
                // We will use this to check if there is an array in the order form array
                ArrayList ArrayInMasterList = entry as ArrayList;

                // Check to see if the current entry is an array
                if (ArrayInMasterList != null)
                {
                    Console.Write(counter + ". ");

                    // Print each item in the array that is in the curretn entry of the order form
                    foreach (Object listItem in ArrayInMasterList)
                    {
                        Console.Write(listItem + " ");
                    }

                    Console.WriteLine();
                }
                else
                {
                    // Print out single string entrys in the order form
                    Console.WriteLine(counter + ". " + entry);
                }

                counter++;
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        
        /// Show the company MainMenu
        public WagProductCatalog()
        {
            PresentSelectionMenu();
        }
    }
}
