using HWPatterns2_Adapter.Adaptee.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns2_Adapter.Adaptee
{
    class Camel : IAnimal
    {
        public string Name { get; set; }
        public Camel()
        {
            Name = "Camel";
        }
        public string Move()
        {
            return "We are moving on a camel";
        }
    }
}
