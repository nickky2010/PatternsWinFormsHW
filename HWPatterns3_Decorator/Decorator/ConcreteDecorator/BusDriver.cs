using HWPatterns3_Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns3_Decorator.Decorator.ConcreteDecorator
{
    class BusDriver:DriverDecorator
    {
        public BusDriver(Driver driver) : base(driver)
        {

        }
        string addBusDrive()
        {
            return "I drive a bus.";
        }
        public override string Drive()
        {
            return base.Drive() + addBusDrive();
        }
    }
}
