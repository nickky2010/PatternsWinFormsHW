using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns1_AbstractFactory.Clients.ProductAuto
{
    public class DieselAutomobile : Auto
    {
        public DieselAutomobile(string color, string model)
            : base(color, model)
        {
            engineType = "diesel";
        }
    }
}
