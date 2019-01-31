using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HWPatterns1_AbstractFactory.Clients.ProductMotocycle
{
    public class GasolineMotocycle : Motocycle
    {
        public GasolineMotocycle(string color, string model)
            : base(color, model)
        {
            engineType = "gasoline";
        }

    }
}