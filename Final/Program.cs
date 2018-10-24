using WAG;
using Gadget;
using Widget;


namespace FINAL
{
    class Program
    {




        static void Main(string[] args)
        {

            /*

            ///Small Widget test

            WidgetSmall SmallTestWidget = new WidgetSmall();

            SmallTestWidget.DisplayComponents();

            System.Console.WriteLine(SmallTestWidget.NumOfGears);
            System.Console.WriteLine(SmallTestWidget.NumOfLevers);
            System.Console.WriteLine(SmallTestWidget.NumOfSprings);

            System.Console.WriteLine(SmallTestWidget.GetPrice());

            */






            /*
            ///Medium Gadget Test
            GadgetMedium MediumTestGadget = new GadgetMedium();

            MediumTestGadget.DisplayName();

            MediumTestGadget.DisplayComponents();

            System.Console.WriteLine(MediumTestGadget.GetNumberOfWidgetsTotal());

            System.Console.WriteLine(MediumTestGadget.GetPrice());

            MediumTestGadget.DisplayPriceDollars();

            */

            /*
            ///Small Gadget Test
            GadgetSmall SmallTestGadget = new GadgetSmall();

            SmallTestGadget.DisplayName();

            SmallTestGadget.DisplayComponents();
            
            System.Console.WriteLine(SmallTestGadget.GetNumberOfWidgetsTotal());

            System.Console.WriteLine(SmallTestGadget.GetPrice()); 

            SmallTestGadget.DisplayPriceDollars();
            */









            //// 1. Display the WAG welcome
            CompanyIntro companyIntro = new CompanyIntro();  //Displays the intro
            companyIntro.Intro();
            

            //// 2. Get the user type
            WagCustomerTypeAndOrder newCustomerOrder = new WagCustomerTypeAndOrder();  //creates orderform
            
            
            //// 3. Present the products for something to add to cart
            WagProductCatalog ProductMenu = new WagProductCatalog();

            

            /////@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            ///                             Unused code below!
            /////@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            ///                                 End of Program
            /////@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@




            






            /*
            
            OrderCart myCurrentOrder = new OrderCart();
            myCurrentOrder.MyOrderCart(numUserGadgetsEntered, powerSelection);

            DisplayPricing myPriceDisplay = new DisplayPricing();
            myPriceDisplay.DisplayCurrentOrder(userGadgetSizeEntered, numUserGadgetsEntered, powerSelection);
          
            

            /*
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue with another order, or Q + ENTER to quit...");
            Console.WriteLine();


            ///May have to keep this here at all times, to exit program or put in method
            string userInput = Console.ReadLine().ToUpper();
            if (userInput == "Q")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
            }

            */
        }
    }
}