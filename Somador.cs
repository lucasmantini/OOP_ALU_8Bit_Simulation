using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC
{
    class Somador
    {
        XOR x1 = new XOR();
        XOR x2 = new XOR();

        OR o1 = new OR();

        AND a1 = new AND();
        AND a2 = new AND();
        AND a3 = new AND();

        public bool Somar(bool a, bool b)
        {
            bool saida, transporte;

            transporte = ALU_8BITS.vai1;

            saida = x2.Portas2(x1.Portas2(a, b), transporte);
            ALU_8BITS.vai1 = o1.Portas3(a1.Portas2(b, transporte), a2.Portas2(a, transporte), a3.Portas2(a, b));

            return saida;
        }
    }
}
