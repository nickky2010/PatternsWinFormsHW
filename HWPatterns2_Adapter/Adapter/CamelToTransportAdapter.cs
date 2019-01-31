using HWPatterns2_Adapter.Adaptee;
using HWPatterns2_Adapter.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns2_Adapter.Adapter
{
    class CamelToTransportAdapter : ITransport
    {
        Camel camel;
        public CamelToTransportAdapter(Camel camel)
        {
            this.camel = camel;
        }
        public string Drive()
        {
            return camel.Move();
        }
    }
}
