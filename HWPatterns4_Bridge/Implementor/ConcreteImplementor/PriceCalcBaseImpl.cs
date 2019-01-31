using HWPatterns4_Bridge.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns4_Bridge.Implementor.ConcreteImplementor
{
    class PriceCalcBaseImpl : PriceCalcImpl
    {
        public PriceCalcBaseImpl(Dictionary<uint, decimal> price) : base(price)
        {

        }
        public override decimal GetProductPrice(uint itemId)
        {
            return price[itemId];
        }

        public override decimal GetShippingPrice(string shippingTo)
        {
            return 0;
        }
    }
}
