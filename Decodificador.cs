using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC
{
    class Decodificador
    {
        AND a0 = new AND();
        AND a1 = new AND();
        AND a2 = new AND();
        AND a3 = new AND();
        AND a4 = new AND();
        AND a5 = new AND();
        AND a6 = new AND();
        AND a7 = new AND();

        NOT n0 = new NOT();
        NOT n1 = new NOT();
        NOT n2 = new NOT();

        public void Decodificar(bool[] F, out bool D0, out bool D1, out bool D2, out bool D3, out bool D4, out bool D5, out bool D6, out bool D7)
        {
            D0 = a0.Portas3(n2.negar(F[2]), n1.negar(F[1]), n0.negar(F[0])); //000
            D1 = a1.Portas3(n2.negar(F[2]), n1.negar(F[1]), F[0]); //001
            D2 = a2.Portas3(n2.negar(F[2]), F[1], n0.negar(F[0])); //010
            D3 = a3.Portas3(n2.negar(F[2]), F[1], F[0]);//011
            D4 = a4.Portas3(F[2], n1.negar(F[1]), n0.negar(F[0]));//100
            D5 = a5.Portas3(F[2], n1.negar(F[1]), F[0]);//101
            D6 = a6.Portas3(F[2], F[1], n0.negar(F[0]));//110
            D7 = a7.Portas3(F[2], F[1], F[0]); //111           

        }
    }
}
