using HWPatterns1_AbstractFactory.Clients.ProductAuto;
using HWPatterns1_AbstractFactory.Clients.ProductMotocycle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns1_AbstractFactory.Factory
{
    public interface IFactory
    {
        Motocycle CreateMotocycle(string color, string model);
        Auto CreateAuto(string color, string engineType);
        string Name { get; set; }
        List<string> Production { get; set; }

    }
}
