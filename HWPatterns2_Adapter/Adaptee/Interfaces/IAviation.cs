using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns2_Adapter.Adaptee.Interfaces
{
    public interface IAviation
    {
        string Name { get; set; }
        string Fly();

    }
}
