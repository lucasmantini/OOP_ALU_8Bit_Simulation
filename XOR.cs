using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC
{
    class XOR : Portas
    {
        AND a1 = new AND();
        AND a2 = new AND();
        NOT n1 = new NOT();
        NOT n2 = new NOT();
        OR o1 = new OR();

        public override bool Portas2(bool a, bool b)
        {
            bool saida;

            saida = o1.Portas2(a1.Portas2(n1.negar(a), b), a2.Portas2(a, n2.negar(b)));


            return (saida);
        }
    }
}
