using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_House
{
    public interface IPart
    {       
        bool IsBuilt {  get; }
        void Build();
    }
}
