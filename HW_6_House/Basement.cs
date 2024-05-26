using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_House
{
    public class Basement : IPart
    {               
        public bool IsBuilt { get; set;}
        public void Build()
        {
            IsBuilt = true;
        }

    }
}
