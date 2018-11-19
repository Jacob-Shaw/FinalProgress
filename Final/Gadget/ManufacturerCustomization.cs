using System;
using WAG;

namespace Gadget
{
    public class ManufacturerCustomization 
    {
        // This will return the gadget with any customized price 
        public IWagProduct CustomizeGadget(IWagProduct GadgetToCustomize, int NumOfGadgets)
        {  
            if (GadgetToCustomize.GetLineItemOrderDetails  == " Large Gadget ")
            {
                // Use of the Decorator Pattern
                GadgetDecorators.Switches AddSwitch = new GadgetDecorators.Switches(GadgetToCustomize);
                GadgetDecorators.Buttons AddButtons = new GadgetDecorators.Buttons(AddSwitch);
                GadgetDecorators.Lights AddLights = new GadgetDecorators.Lights(AddButtons);
                
                IWagProduct myCustomized = AddLights;

                Console.WriteLine("Customization: " + myCustomized.GetLineItemOrderDetails + 
                    " " + myCustomized.GetLineItemPrice);
                
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
