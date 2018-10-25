using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final;

namespace WAG
{
    public abstract class WagProductDecorator : IWagProduct
    {
        //This is the type found here in the abstact class implementing the specic interface
        protected IWagProduct tempOrder;


        public WagProductDecorator(IWagProduct newOrder)
        {
            tempOrder = newOrder;
        }

        public virtual string GetLineItemOrderDetails
        {
            get { return tempOrder.GetLineItemOrderDetails; }
        }

        //Abstract class so does not get counted
        public virtual decimal GetLineItemPrice
        {
            get { return tempOrder.GetLineItemPrice; }
        }
    }
}
