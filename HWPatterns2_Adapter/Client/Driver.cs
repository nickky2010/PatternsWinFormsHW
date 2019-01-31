using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns2_Adapter.Clients
{
    class Driver // client
    {
        public string Travel(ITransport transport)
        {
            return transport.Drive();
        }
    }
}
