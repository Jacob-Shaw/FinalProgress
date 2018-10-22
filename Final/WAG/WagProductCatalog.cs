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
        //List of company products
        string[] WagProductsList = new string[] { "Gadget", "Other Item For Sale No Order Form" };

        
        ///Method for displaying the title
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
            Console.WriteLine("========================== WAG Order Form ===================================");
            Console.WriteLine("=============================================================================");
            Console.WriteLine();
        }

        ///Method for displaying the Products Listed at top of this class
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

            
            //Get a selection from the customer  //if the user entry is not a number
            while (!Int32.TryParse(userChoice, out check))
            {
                Console.WriteLine("Please select a product number from the catalog: ");
                userChoice = Console.ReadLine();
            }

            
            //Less than 0? let's see if Absolute Value will solve the problem
            if (check < 0)
            {
                
                check = Math.Abs(check);
                
                Console.WriteLine("You're number was less than 0.");
                
                

                //If converting to a positive number gives a proper selection
                if ((check <= WagProductsList.Length) && (check != 0))
                {


                    try
                    {
                        int checkNumber = check;


                        string checkThisItem = WagProductsList.ElementAt(checkNumber -1 );


                        // Remove all the spaces
                        checkThisItem = checkThisItem.Replace(" ", String.Empty);



                        //
                        var IteminQuestion = checkThisItem + "OrderForm";
                        var ItemWeAreTryingToCreate = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                                                       from type in assembly.GetTypes()
                                                       where type.Name == IteminQuestion
                                                       select type).FirstOrDefault();


                        ///See if there is a class order form with name of ItemWeAreTryingToCreate which was user choice 
                        ///-- if so, then use order form, otherwise add directly to masterlist
                        if (ItemWeAreTryingToCreate == null) throw new InvalidOperationException(); //remove itemnf

                        object newType = Activator.CreateInstance(ItemWeAreTryingToCreate);
                        
                    }
                    

                    catch (InvalidOperationException)
                    {       
                        //Add the product with no order form to the MasterList

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

                    }










                    //Take customer to order form if one exists, otherwise add product to customer order form
                }
                //Selection ended up being greater than the length of the list
                else
                {
                    displayCatalogTitle();

                    presentProducts();

                    Console.WriteLine();
                    Console.WriteLine("You entered a negative number.  Converting to positive did not help.");
                    Console.WriteLine();

                    getUserChoice();
                }
            }





            // Greater than the product list or equal to 0? Bad!
            else if ( (check > WagProductsList.Length) || ( check == 0 ))
            {
                displayCatalogTitle();

                presentProducts();
                
                Console.WriteLine();
                Console.WriteLine("The selection you have made does not exist.");
                Console.WriteLine();

                getUserChoice();
            }


            //A good selection was made!
            else
            {
                ///Take customer to order form if one exists, otherwise add product to MasterOrderForm
                
                try
                {
                    //Number to be used in checking user choice in Product Catalog
                    int checkNumber = check - 1;

                    string checkThisItem = WagProductsList.ElementAt(checkNumber); 
                    
                    //Remove any spaces in the name
                    checkThisItem = checkThisItem.Replace(" ", String.Empty);
                    
                    //The following code checks to see if there is a class with the product choice name
                    var IteminQuestion = checkThisItem + "OrderForm";
                    var ItemWeAreTryingToCreate = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                                                   from type in assembly.GetTypes()
                                                   where type.Name == IteminQuestion
                                                   select type).FirstOrDefault();

                    if (ItemWeAreTryingToCreate == null) throw new InvalidOperationException("Valid type not found.");

                    object newType = Activator.CreateInstance(ItemWeAreTryingToCreate);
                    
                }
                catch (InvalidOperationException)
                {

                    ///Adding the correctly entered item number to the MasterOrderForm directly 
                    ///   becuase it has no special order form
                    
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
            Console.WriteLine("========================== WAG Selection Menu ===============================");
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
            
            //Get a selection from the customer -------ActionMenu
            //Customer may Add an item, Display the current order, Remove an item,   
            //          Proceed to customer checkout, or Cancel the order and exit

            switch (userChoice.ToUpper())
            {
                case "A":
                    Console.Clear();

                    displayCatalogTitle();

                    presentProducts();

                    getUserChoice();

                    break;

                case "D":

                    displayOrderFormTitle();
                    printItAll();                    
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    PresentSelectionMenu();

                    break;

                case "R":
                    ///Code to remove the item from the list
                    ///

                    printItAll();
                    Console.WriteLine();
                    Console.WriteLine("Are you sure you wish to remove an item from your order?");
                    Console.WriteLine("(Y) Yes   (N) No");
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



                        if ((lineItem > WagProductsList.Length) || (check <= 0))
                        {
                            Console.WriteLine("The line item you entered could not be found.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            printItAll();
                            PresentSelectionMenu();

                        }
                        else
                        {
                            Console.WriteLine("Are you sure you wish to remove line item #" + lineItem + "?");
                            Console.WriteLine("(Y) Yes   (N) No");
                
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




                        // WagCustomerTypeAndOrder.MasterOrderForm.RemoveAt(int index);

                    }
                    else
                    {
                        Console.Clear();
                        PresentSelectionMenu(); 
                    }


                        





                    break;
                    

                case "P":

                    break;

                case "X":
                    Console.WriteLine();
                    Console.WriteLine("Are you sure you wish to cancel your order and exit?");
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
                    Console.Clear();
                    PresentSelectionMenu();
                    break;
            }
        

            
        }




        void printItAll()
        {

            Console.Clear();
            displayOrderFormTitle();
            Console.WriteLine();

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

            foreach (Object entry in WagCustomerTypeAndOrder.MasterOrderForm)
            {
                ArrayList ArrayInMasterList = entry as ArrayList;

                if (ArrayInMasterList != null)
                {
                    Console.Write(counter + ". ");

                    foreach (Object thingy in ArrayInMasterList)
                    {
                        Console.Write(thingy + " ");
                    }

                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine(counter + ". " + entry);
                }

                counter++;
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        
        /// Show the company catalog, allow the customer to choose item to purchase
        public WagProductCatalog()
        {
            PresentSelectionMenu();
        }
    }
}
