using System;
using System.Collections;
using System.Linq;
using Final;

namespace WAG
{
    public class WagProductCatalog
    {
        // List of company products
        string[] WagProductsList = new string[] { "Gadget", "Gear", "Spring", "Lever"  };
        
        // Method for displaying the title
        public void displayCatalogTitle()
        {
            Console.Clear();
            Console.WriteLine("=============================================================================");
            Console.WriteLine("========================== WAG PRODUCT LIST =================================");
            Console.WriteLine("=============================================================================");
            Console.WriteLine();
        }
        
        public void displayOrderFormTitle()
        {
            Console.Clear();
            Console.WriteLine("=============================================================================");
            Console.WriteLine("========================== YOUR CURRENT ORDER ===============================");
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
        public void getUserCatalogChoice()
        {
            string userChoice = ""; 
            
            int check = 0;
            
            // Get new input from the customer if the user entry is not a number
            while (!Int32.TryParse(userChoice, out check))
            {
                Console.WriteLine();
                Console.Write("PLEASE SELECT A LINE ITEM NUMBER: ");
                userChoice = Console.ReadLine();
            }
            
            // Less than 0? Let's see if Absolute Value will solve the problem,
            if (check < 0)
            {
                Console.WriteLine("YOU'RE NUMBER WAS LESS THAN 0.");
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
                        
                        ///
                        /// Program returns to this point after ordering or not ordering Gadgets!
                        /// 

                    }
                    catch (InvalidOperationException)
                    {       
                        //Add the product with no order form to the MasterList
                        //  and then go to the Main Menu

                        string checkThisItem2 = WagProductsList.ElementAt(check - 1);
                        
                        WagCustomerTypeAndOrder.MasterOrderForm.Add(checkThisItem2);

                        displayOrderFormTitle();
                        Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
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
                    Console.WriteLine("YOU ENTERED A NEGATIVE NUMBER. CONVERTING TO A POSITIVE NUMBER DID NOT HELP.");
                    Console.WriteLine();

                    // Ask the user to try adding a product again.
                    getUserCatalogChoice();
                }
            }

            
            // If the user selection wa greater than the product list or equal to 0,
            //  then ask then to try selecting again.
            else if ( (check > WagProductsList.Length) || ( check == 0 ))
            {
                displayCatalogTitle();

                presentProducts();
                
                Console.WriteLine();
                Console.WriteLine("THE SELECTION YOU MADE DOES NOT EXIST. PLEASE TRY AGAIN");
                Console.WriteLine();

                getUserCatalogChoice();
            }
            
            //  A valid selection was made!
            else
            {
                //Take customer to order form if one exists, otherwise add product directly to MasterOrderForm.
                
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

                    string priceToDisplay = "";

                    string itemToAdd = "";

                    if (checkThisItem3 == "Gear")
                    {
                        priceToDisplay = ComponentPricing.GearCostPerUnit.ToString();
                    }  
                    if (checkThisItem3 == "Spring")
                    {
                        priceToDisplay = ComponentPricing.SpringCostPerUnit.ToString();
                    }   
                    if (checkThisItem3 == "Lever")
                    {
                        priceToDisplay = ComponentPricing.LeverCostPerUnit.ToString();
                    }

                    itemToAdd = "1  " + checkThisItem3 + " " + priceToDisplay;

                    WagCustomerTypeAndOrder.MasterOrderForm.Add(itemToAdd);
                    

                    displayOrderFormTitle();
                    printItAll();
                    Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
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
            Console.WriteLine("============================= WAG MAIN MENU =================================");
            Console.WriteLine("=============================================================================");
            Console.WriteLine();
            Console.WriteLine("(A) ADD AN ITEM TO YOUR ORDER  ");
            Console.WriteLine("(D) DISPLAY YOUR CURRENT ORDER ");
            Console.WriteLine("(R) REMOVE AN ITEM FROM YOUR ORDER");
            Console.WriteLine("(C) CONFIRM ORDER AND CHECKOUT");
            Console.WriteLine("(X) CANCEL ORDER AND EXIT");
            Console.WriteLine();
            Console.Write("PLEASE MAKE A SELECTION AND THEN PRESS \"ENTER\": " );

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

                    getUserCatalogChoice();

                    break;

                case "D":
                                        // Code to Display the Order Form

                    displayOrderFormTitle();

                    printItAll();       
                    
                    Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
                    Console.ReadKey();
                    Console.Clear();

                    PresentSelectionMenu();

                    break;

                case "R":
                                        // Code to remove the item from the list

                    printItAll();
                    Console.WriteLine();
                    Console.WriteLine("ARE YOU SURE YOU WISH TO REMOVE AN ITEM FROM YOUR ORDER?");
                    Console.Write("(Y) YES -or- PRESS ANY OTHER KEY TO CANCEL, AND THEN PRESS \"ENTER\": ");

                    string removeAnswer = Console.ReadLine();

                    if (removeAnswer.ToUpper() == "Y")
                    {
                        Console.WriteLine("WHICH LINE ITEM NUMBER WOULD YOU LIKE TO REMOVE?");
                        string removeLine = Console.ReadLine();


                        ///Make sure it is a number first!
                        int check = 0;
                        
                        //Get a selection from the customer  //if the user entry is not a number
                        while (!Int32.TryParse(removeLine, out check))
                        {
                            Console.WriteLine("PLEASE SELECT A LINE ITEM NUMBER TO REMOVE: ");
                            userChoice = Console.ReadLine();
                        }
                        
                        int lineItem = Math.Abs(check);
                        
                        if ((lineItem > WagCustomerTypeAndOrder.MasterOrderForm.Count) || (check <= 0))
                        {
                            Console.WriteLine("THE LINE ITEM YOU ENTERED COULD NOT BE FOUND.");
                            Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
                            Console.ReadKey();
                            Console.Clear();
                            PresentSelectionMenu();

                        }
                        else
                        {
                            Console.WriteLine("ARE YOU SURE YOU WISH TO REMOVE LINE ITEM #" + lineItem + "?");
                            Console.Write("(Y) YES -or- PRESS ANY OTHER KEY TO CANCEL, AND THEN PRESS \"ENTER\": ");

                            string confirmRemoval = Console.ReadLine().ToUpper();

                            if (confirmRemoval == "Y")
                            {
                                WagCustomerTypeAndOrder.MasterOrderForm.RemoveAt(lineItem -1);
                                Console.Clear();
                                displayOrderFormTitle();
                                printItAll();
                                Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
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
                    
                case "C":
                                        // Code to Proceed to Checkout

                    OrderCheckout myorderCheckout = new OrderCheckout();
                    
                    break;
                    
                case "X":
                                        // Code to Cancel the order and Exit

                    Console.WriteLine();
                    Console.WriteLine("ARE YOU SURE YOU WISH TO CANCEL YOUR ORDER AND EXIT?");
                    Console.Write("(Y) YES -or- PRESS ANY OTHER KEY TO CANCEL, AND THEN PRESS \"ENTER\": ");

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
        
        // Method to print all of the items in the Master customer order form to the console
        void printItAll()
        {
            Console.Clear();
            displayOrderFormTitle();
            Console.WriteLine();

            // If there are no items in the order form
            if (WagCustomerTypeAndOrder.MasterOrderForm.Count == 0)
            {
                Console.WriteLine("THERE ARE NO ITEMS IN YOUR ORDER.");
                Console.WriteLine();
                Console.WriteLine("PRESS ANY KEY TO CONTINUE...");
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
                    
                    int x = 0;

                    // Print each item in the array that is in the current entry of the order form
                    foreach (Object listItem in ArrayInMasterList )
                    {
                        
                        if (x > 0)  //if it is not looking at the first ellement of the array (a decimal)
                        {
                            Console.Write(listItem + " ");
                        }
                        else
                        {   
                            decimal price = decimal.Parse(listItem.ToString());

                            WagCustomerTypeAndOrder.AddToRunningTotal(price);

                            x++;
                        }
                    }

                    Console.WriteLine();
                    
                }
                else
                {
                    // Print out single string entrys in the order form
                    Console.WriteLine(counter + ". " + entry);
                    
                    //Looks up the price and adds to RunningTotal
                    ProductPricing getPrice = new ProductPricing(entry);
                }

                counter++;
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        
        // Show the company MainMenu
        public WagProductCatalog()
        {
            PresentSelectionMenu();
        }
    }
}
