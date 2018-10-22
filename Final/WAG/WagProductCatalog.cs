using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAG
{
    public class WagProductCatalog
    {
        //List of company products
        string[] WagProductsList = new string[] { "Gadget", "Test Class", "Gadget", "UnknownItem" }; 




        ///Method for displaying the title
        ///
        public void displayCatalogTitle()
        {
            Console.Clear();
            Console.WriteLine("=============================================================================");
            Console.WriteLine("========================== WAG Product Catalog ==============================");
            Console.WriteLine("=============================================================================");
            Console.WriteLine();

            ///@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            ///
            



        }


        ///Method for displaying the Products
        public void presentProducts()
        {
            int counter = 1;

            foreach (string product in WagProductsList)
            {
                Console.WriteLine(counter + ". " + product);
                counter++;
            }
        }

        public void getUserChoice()
        {
            Console.WriteLine();
            Console.WriteLine("Please select a product number from the catalog: ");
            
            string userChoice = ""; // Console.ReadLine();
            
            int check = 0;

            //Get a selection from the customer  //if the user entry is not a number
            while (!Int32.TryParse(userChoice, out check))
            {
                userChoice = Console.ReadLine();
                Console.WriteLine("Please enter a number.");
            }

            //Less than 0? let's see if Absolute Valu will solve the problem
            if (check < 0)
            {
                check = Math.Abs(check);
                
                Console.WriteLine("number was less than 0");
                
                //If a proper selection was made
                if ((check <= WagProductsList.Length) && (check != 0))
                {
                    ///@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


                    try
                    {
                        int checkNumber = check - 1;

                        string checkThisItem = WagProductsList.ElementAt(checkNumber);

                        // string removeAllSpaces = "This is a test";
                        checkThisItem = checkThisItem.Replace(" ", String.Empty);




                        var IteminQuestion = checkThisItem;
                        var ItemWeAreTryingToCreate = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                                                       from type in assembly.GetTypes()
                                                       where type.Name == IteminQuestion
                                                       select type).FirstOrDefault();

                        if (ItemWeAreTryingToCreate == null) throw new InvalidOperationException("Valid type not found.");

                        object newType = Activator.CreateInstance(ItemWeAreTryingToCreate);


                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("I am sorry, that product is no longer available.");
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
                //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                ///Take customer to order form if one exists, otherwise add product to customer order form
                ///Check to see if the item has an orderform, if yes then load that orderform by it's number
                ///

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
                    ///Code for if there is no order form

                    Console.WriteLine("I need to add this item to the order form pronto!");
                }
                finally
                {

                }

            }

        }

        /// Show the company catalog, allow the customer to choose item to purchase
        public WagProductCatalog()
        {
            displayCatalogTitle();

            presentProducts();

            getUserChoice();


            
            //could have a switch that checks for products needing special order forms, if not then
            //default constructor for product list

            /*
            switch (switch_on)
            {
                default:
            }
            */


        }
    }
}
