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
        string[] WagProductsList = new string[] { "Gadgets" };


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
            Console.WriteLine("Please select a product from the catalog: ");
            string userChoice = ""; // Console.ReadLine();

            int check = 0;

            while (!Int32.TryParse(userChoice, out check))
            {
                Console.WriteLine("Please enter a number for your selection.");

                userChoice = Console.ReadLine();
            }

            if (check < 0)
            {
                Console.WriteLine("You entered a negative number.  Converting to positive.");
                check = Math.Abs(check);
            }
            else if ( (check > WagProductsList.Length) || ( check == 0 ))
            {
                Console.WriteLine("The selection you have made does not exist.");
                    getUserChoice();
            }
            else
            {

            }

        }

        /// Show the company catalog, allow the customer to choose item to purchase
        public WagProductCatalog()
        {
            Console.Clear();
            Console.WriteLine("=============================================================================");
            Console.WriteLine("========================== WAG Product Catalog ==============================");
            Console.WriteLine("=============================================================================");
            Console.WriteLine();

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
