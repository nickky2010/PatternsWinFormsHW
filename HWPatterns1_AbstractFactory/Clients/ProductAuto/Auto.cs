using HWPatterns1_AbstractFactory.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HWPatterns1_AbstractFactory.Clients.ProductAuto
{
    public abstract class  Auto:Client//AbstractProductB
    {
        string color;
        string model;
        protected string engineType;
        public Auto(string color, string model)
        {
            this.color = color;
            this.model = model;
        }


        public override string ToString()
        {
            return model+" automobile "+color+" "+engineType;
        }
    }
}
