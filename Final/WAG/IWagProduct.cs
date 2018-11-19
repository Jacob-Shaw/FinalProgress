using System;

namespace WAG
{
    public interface IWagProduct
    {
        string GetLineItemOrderDetails { get; }

        decimal GetLineItemPrice { get; }
    }
}
