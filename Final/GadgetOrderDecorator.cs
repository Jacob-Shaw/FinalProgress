using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINAL;

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
