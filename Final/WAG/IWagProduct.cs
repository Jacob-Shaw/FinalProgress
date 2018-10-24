using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL
{
    public interface IWagProduct
    {
        string GetLineItemOrderDetails { get; }

        decimal GetLineItemPrice { get; }
    }
}
