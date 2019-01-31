using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns3_Decorator.Component
{
    abstract class Driver
    {
        public string Name { get; set; }
        public abstract string Drive();
    }
}
