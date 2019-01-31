using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HWPatterns1_AbstractFactory.Clients;


namespace HWPatterns1_AbstractFactory.Clients.ProductMotocycle
{
    //абстракция продукта 1
    public abstract class Motocycle : Client
    {
        private string color;
        protected string engineType;
        string model;

        public Motocycle(string color, string model)
        {
            this.color = color;
            this.model = model;
        }

        public override string ToString()
        {
            return model + " motocycle color " + color+" type engine "+engineType;
        }
    }
}