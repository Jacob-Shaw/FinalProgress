using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAG
{
    public interface IWagProduct
    {
        string GetLineItemOrderDetails { get; }

        decimal GetLineItemPrice { get; }
    }
}
