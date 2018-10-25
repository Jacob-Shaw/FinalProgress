using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINAL;
using WAG;

namespace Final
{
    public class ProductPricing
    {
        Dictionary<object, decimal> ItemPrices = new Dictionary<object, decimal>();
        
        public ProductPricing( object key )
        {
            ItemPrices.Add("Gear", ComponentPricing.GearCostPerUnit);
            ItemPrices.Add("Lever", ComponentPricing.SpringCostPerUnit);
            ItemPrices.Add("Spring", ComponentPricing.LeverCostPerUnit);

            
            if ( ItemPrices.TryGetValue(key, out WagCustomerTypeAndOrder.RunningTotal) == true)
            {
                WagCustomerTypeAndOrder.AddToRunningTotal(ItemPrices[key]);
            }
        }
    }
}
