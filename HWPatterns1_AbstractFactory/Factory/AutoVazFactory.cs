using HWPatterns1_AbstractFactory.Clients.ProductAuto;
using HWPatterns1_AbstractFactory.Clients.ProductMotocycle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns1_AbstractFactory.Factory
{
    public class AutoVazFactory : IFactory
    {
        public string Name { get; set; }
        public List<string> Production { get; set; }

        public AutoVazFactory()
        {
            Name = "AutoVAZ";
            Production = new List<string>();
            Production.Add("Automobile");
            Production.Add("Motocycle");
        }

        public Auto CreateAuto(string color, string engineType)
        {
            if (engineType == "gasoline")
            {
                return new GasolineAutomobile(color, "AutoVAZ Niva");
            }
            else if (engineType == "diesel")
            {
                return new DieselAutomobile(color, "AutoVAZ Shniva");
            }
            return null;
        }

        public Motocycle CreateMotocycle(string color, string engineType)
        {
            if (engineType == "gasoline")
            {
                return new GasolineMotocycle(color, "AutoVAZ");
            }
            else if (engineType == "diesel")
            {
                return new DieselMotocycle(color, "AutoVAZ");
            }
            return null;
        }
    }
}
