using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HWPatterns1_AbstractFactory.Clients.ProductMotocycle
{
    //конкретная реализация абстрактного продукта мотоцикл: дизельный
    public class DieselMotocycle : Motocycle
    {
        public DieselMotocycle(string color, string model)
            : base(color, model)
        {
            engineType = "diesel";
        }
    }
}