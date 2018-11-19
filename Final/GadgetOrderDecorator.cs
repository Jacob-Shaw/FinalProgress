using System;
using WAG;

namespace Decorator
{
    public abstract class GadgetOrderDecorator : IWagProduct
    {
        protected IWagProduct tempOrder;

        
        public GadgetOrderDecorator(IWagProduct newOrder)
        {
            tempOrder = newOrder;
        }

        public virtual string GetLineItemOrderDetails
        {
            get { return tempOrder.GetLineItemOrderDetails; }
        }

        public virtual decimal GetLineItemPrice
        {
            get { return tempOrder.GetLineItemPrice; }
        }
    }
}
