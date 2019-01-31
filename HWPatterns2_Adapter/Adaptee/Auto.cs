using HWPatterns2_Adapter.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns2_Adapter.Adaptee
{
    class Auto : ITransport
    {
        public string Name { get; set; }
        public Auto()
        {
            Name = "Automobile";
        }
        public string Drive()
        {
            return "We are moving by car";
        }
    }
}
