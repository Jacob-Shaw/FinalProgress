using WAG;
using System;


namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set the screen
            Console.WindowLeft = 0;
            Console.WindowTop = 0;
            Console.SetWindowSize(80, 50);
            
            // Display the company welcome
            CompanyIntro companyIntro = new CompanyIntro();  
            companyIntro.Intro();

            // Get the user type
            WagCustomerTypeAndOrder.GetOrderType();

            // Present the products for something to add to cart
            WagProductCatalog ProductMenu = new WagProductCatalog();
            
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}