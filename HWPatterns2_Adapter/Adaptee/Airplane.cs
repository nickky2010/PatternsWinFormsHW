using HWPatterns2_Adapter.Adaptee.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns2_Adapter.Adaptee
{
    class Airplane : IAviation
    {
        public string Name { get; set; }
        public Airplane()
        {
            Name = "Airplane";
        }

        public string Fly()
        {
            return "We are moving on a airplane";
        }
    }
}
