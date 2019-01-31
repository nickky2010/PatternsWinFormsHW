using HWPatterns1_AbstractFactory.Clients.ProductAuto;
using HWPatterns1_AbstractFactory.Clients.ProductMotocycle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns1_AbstractFactory.Factory
{
    public class VWFactory : IFactory
    {
        public string Name { get; set; }
        public List<string> Production { get; set; }

        public VWFactory()
        {
            Name = "Volkswagen";
            Production = new List<string>();
            Production.Add("Automobile");
            Production.Add("Motocycle");
        }
        public Auto CreateAuto(string color, string engineType)
        {
            if (engineType == "gasoline")
            {
                return new GasolineAutomobile(color, "VW Polo");
            }
            else if (engineType == "diesel")
            {
                return new DieselAutomobile(color, "VW Passat");
            }
            return null;
        }

        public Motocycle CreateMotocycle(string color, string engineType)
        {
            if (engineType == "gasoline")
            {
                return new GasolineMotocycle(color, "VW");
            }
            //else if(engineType == "diesel")
            //{
            //return new DieselMotocycle(color, "VW");
            //}
            return null;
        }
    }
}
