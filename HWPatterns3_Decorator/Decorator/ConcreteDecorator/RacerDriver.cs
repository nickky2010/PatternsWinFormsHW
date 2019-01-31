using HWPatterns3_Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns3_Decorator.Decorator.ConcreteDecorator
{
    class RacerDriver:DriverDecorator
    {
        public RacerDriver(Driver driver) : base(driver)
        {

        }
        string addRaceDrive()
        {
            return "I am a racer, and I drive very quickly.";
        }
        public override string Drive()
        {
            return base.Drive() + addRaceDrive();
        }
    }
}
