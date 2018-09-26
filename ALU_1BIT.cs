using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC
{
    class ALU_1BIT
    {
        bool D0, D1, D2, D3, D4, D5, D6, D7; //Para usar no decodificador

        Decodificador d = new Decodificador();
        //Portas
        AND c1 = new AND();
        OR c2 = new OR();
        XOR c3 = new XOR();
        NOT c4 = new NOT();
        NOT c5 = new NOT();
        Somador c6 = new Somador();
        Subtrator c7 = new Subtrator(); //p7 Subtrair
        Comparador c8 = new Comparador();//p8 Comparar
        //Saídas
        AND s0 = new AND();
        AND s1 = new AND();
        AND s2 = new AND();
        AND s3 = new AND();
        AND s4 = new AND();
        AND s5 = new AND();
        AND s6 = new AND();
        AND s7 = new AND();
        //AGRUPAR PARA OR FINAL
        OR o1 = new OR();
        OR o2 = new OR();
        OR o3 = new OR();
        OR o4 = new OR();

        public bool ALU_1(bool a, bool b, bool[] F)
        {
            bool p0, p1, p2, p3, p4, p5, p6, p7, S;

            d.Decodificar(F, out D0, out D1, out D2, out D3, out D4, out D5, out D6, out D7);

            p0 = s0.Portas2(c1.Portas2(a, b), D0);
            p1 = s1.Portas2(c2.Portas2(a, b), D1);
            p2 = s2.Portas2(c3.Portas2(a, b), D2);
            p3 = s3.Portas2(c4.negar(a), D3);
            p4 = s4.Portas2(c5.negar(b), D4);
            p5 = s5.Portas2(c6.Somar(a, b), D5);
            p6 = s6.Portas2(c7.Subtrair(a, b), D6);
            p7 = s7.Portas2(c8.Comparar(a, b), D7);

            S = o1.Portas2(p0, p1) | o2.Portas2(p2, p3) | o3.Portas2(p4, p5) | o4.Portas2(p6, p7); //OR COM AS 8 SAIDAS DA ULA
            return S; //Retornar OR com todos os objetos s
        }

    }
}
