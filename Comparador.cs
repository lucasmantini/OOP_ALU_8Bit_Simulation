using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC
{
    class Comparador
    {

        XOR x = new XOR();
        NOT n = new NOT();

        public bool Comparar(bool a, bool b)
        {
            bool saida;

            saida = n.negar(x.Portas2(a, b));

            return saida;
        }

    }
}
