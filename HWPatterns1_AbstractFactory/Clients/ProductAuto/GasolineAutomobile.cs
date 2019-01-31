using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns1_AbstractFactory.Clients.ProductAuto
{
    class GasolineAutomobile : Auto
    {
        public GasolineAutomobile(string color, string model)
            : base(color, model)
        {
            engineType = "gasoline";
        }
    }
}
