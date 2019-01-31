using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns2_Adapter.Adaptee.Interfaces
{
    public interface IAnimal
    {
        string Name { get; set; }

        string Move();
    }
}
