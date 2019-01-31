using HWPatterns4_Bridge.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns4_Bridge.Implementor.ConcreteImplementor
{
    class PriceCalcShippingImpl : PriceCalcImpl
    {
        public PriceCalcShippingImpl(Dictionary<uint, decimal> price) : base(price)
        {

        }
        protected static Dictionary<string, decimal> shippingPrice = new Dictionary<string, decimal>
        {
            ["Gomel"] = 0.5m,
            ["Minsk"] = 15m,
            ["Brest"] = 25m,
            ["Vitebsk"] = 20m
        };
        public static Dictionary<string, decimal> ShippingPrice { get => shippingPrice; }
        public override decimal GetProductPrice(uint itemId)
        {
            return price[itemId];
        }

        public override decimal GetShippingPrice(string shippingTo)
        {
            return shippingPrice[shippingTo];
        }
    }
}
