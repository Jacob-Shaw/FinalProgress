using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final;

namespace Decorator
{
    public abstract class GadgetOrderDecorator : IWagProductDecorator
    {
        protected IWagProductDecorator tempOrder;

        
        public GadgetOrderDecorator(IWagProductDecorator newOrder)
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
