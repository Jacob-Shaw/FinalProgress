using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final;
using WAG;

namespace Gadget
{
    public class ManufacturerCustomization 
    {
        //WagProductDecorator myProductOrder = new GadgetLarge();     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@



        // This will return the gadget with any customized price 
        public IWagProduct CustomizeGadget(IWagProduct GadgetToCustomize, int NumOfGadgets)
        {

            Console.WriteLine(GadgetToCustomize.GetLineItemPrice + "   Price of gadgetTocustomize");


            if (GadgetToCustomize.GetLineItemOrderDetails  == " Large Gadget ")
            {
                GadgetDecorators.Switches AddSwitch = new GadgetDecorators.Switches(GadgetToCustomize);
                



                GadgetDecorators.Buttons AddButtons = new GadgetDecorators.Buttons(AddSwitch);
               



                GadgetDecorators.Lights AddLights = new GadgetDecorators.Lights(AddButtons);





                ////////////////////////// @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@2
            

                ////////////////////////////////////////////////////!
                IWagProduct myCustomized = AddLights;

                Console.WriteLine(" custom = " + myCustomized.GetLineItemOrderDetails + " " + myCustomized.GetLineItemPrice);
                




                return myCustomized;
            }
            if (GadgetToCustomize.GetLineItemOrderDetails == " Medium Gadget ")
            {
                GadgetDecorators.Buttons AddButtons = new GadgetDecorators.Buttons(GadgetToCustomize);

                return AddButtons;
            }
            else
            {
                return null;
            }



            


        } 
    }
}
