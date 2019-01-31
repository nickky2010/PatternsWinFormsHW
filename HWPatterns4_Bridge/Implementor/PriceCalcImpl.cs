using HWPatterns4_Bridge.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns4_Bridge.Implementor
{
    abstract class PriceCalcImpl
    {
        protected Dictionary<uint, decimal> price;
        public PriceCalcImpl(Dictionary<uint, decimal> price)
        {
            this.price = price;
        }
        public abstract decimal GetProductPrice(uint itemId);
        public abstract decimal GetShippingPrice(string shippingTo);
    }
}