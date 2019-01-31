using HWPatterns4_Bridge.Clients;
using HWPatterns4_Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns4_Bridge.Abstractions.RefinedAbstractions
{
    class RefinedPriceCalc : PriceCalc
    {
        public RefinedPriceCalc(PriceCalcImpl imp) :base(imp)
        {

        }
        public override void AddProduct(uint itemId, uint itemQuantity)
        {
            decimal price = priceCalcImpl.GetProductPrice(itemId);
            products.Add(new ProductInCart { Id = itemId, Price = price, Quantity = itemQuantity });
        }

        public override decimal GetTotalPrice(string shippingTo)
        {
            return (products.Sum(p => p.Price) + priceCalcImpl.GetShippingPrice(shippingTo));
        }
    }
}
