using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns3_Decorator.Component.ConcreteComponent
{
    class CarDriver:Driver
    {
        public override string Drive()
        {
            return "I " + Name + ", car driver. I move. Vzzzz!!!";
        }
    }
}
