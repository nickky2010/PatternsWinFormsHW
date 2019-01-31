using HWPatterns2_Adapter.Adaptee;
using HWPatterns2_Adapter.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns2_Adapter.Adapter
{
    class AirplaneToTransportAdapter : ITransport
    {
        Airplane airplane;
        public AirplaneToTransportAdapter(Airplane airplane)
        {
            this.airplane = airplane;
        }
        public string Drive()
        {
            return airplane.Fly();
        }
    }
}
