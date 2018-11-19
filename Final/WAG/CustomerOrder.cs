using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAG
{
    class CustomerOrder
    {

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////WAs this used?
        /// </summary>
        public static ArrayList MasterOrderForm = new ArrayList();

        public static decimal RunningTotal;

        public static void AddToRunningTotal(decimal price)
        {
            RunningTotal += price;
        }
    }
}
