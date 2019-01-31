using HWPatterns3_Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns3_Decorator.Decorator
{
    abstract class DriverDecorator:Driver
    {
        protected Driver driver;
        public DriverDecorator(Driver driver)
        {
            this.driver = driver;
        }
        public override string Drive()
        {
            return driver.Drive();
        }
    }
}
