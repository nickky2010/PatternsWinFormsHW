using HWPatterns4_Bridge.Clients;
using HWPatterns4_Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns4_Bridge.Abstractions
{
    abstract class PriceCalc
    {
        protected PriceCalcImpl priceCalcImpl;// мост - агрегация абстракции реализации
        public PriceCalcImpl PriceCalcImpl
        {
            set { priceCalcImpl = value; }
        }
        static public List<ProductInCart> products = new List<ProductInCart>();
        public PriceCalc(PriceCalcImpl imp)
        {
            priceCalcImpl = imp;
        }
        public abstract void AddProduct(uint itemId, uint itemQuantity);
        public abstract decimal GetTotalPrice(string shippingTo);
    }
}
