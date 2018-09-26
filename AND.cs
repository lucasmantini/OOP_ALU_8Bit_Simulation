using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC
{
    class AND:Portas
    {
        public override bool Portas2(bool a, bool b)
        {
            return (a & b);
        }

        public bool Portas3(bool a, bool b, bool c)
        {
            return (a & b & c);
        }
    }
}
