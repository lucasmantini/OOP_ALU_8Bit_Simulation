using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC
{
    class Subtrator
    {
        XOR x1 = new XOR();
        XOR x2 = new XOR();
     
        AND a1 = new AND();
        AND a2 = new AND();
        AND a3 = new AND();

        OR o1 = new OR();
        OR o2 = new OR();


        public bool Subtrair(bool a, bool b) 
        {
            bool saida;

            saida = x1.Portas2(x2.Portas2(a, b), ALU_8BITS.vai1_sub);
            ALU_8BITS.vai1_sub = o1.Portas2(o2.Portas2(a1.Portas2(b, ALU_8BITS.vai1_sub), a2.Portas2(ALU_8BITS.vai1_sub, !a)), a3.Portas2(b, !a));

            return saida;
        }
    }
}
