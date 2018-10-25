using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public interface IWagProductDecorator
    {
        string GetLineItemOrderDetails { get; }

        decimal GetLineItemPrice { get; }
    }
}
