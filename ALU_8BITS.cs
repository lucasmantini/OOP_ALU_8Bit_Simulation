using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC
{
    class ALU_8BITS
    {
        public static bool vai1;
        public static bool vai1_sub;

        ALU_1BIT a0 = new ALU_1BIT();
        ALU_1BIT a1 = new ALU_1BIT();
        ALU_1BIT a2 = new ALU_1BIT();
        ALU_1BIT a3 = new ALU_1BIT();
        ALU_1BIT a4 = new ALU_1BIT();
        ALU_1BIT a5 = new ALU_1BIT();
        ALU_1BIT a6 = new ALU_1BIT();
        ALU_1BIT a7 = new ALU_1BIT();
   
        bool[] Saida = new bool[8];

        public bool[] ALU8(bool[] A, bool[] B, bool[] F, bool sub)
        {
            if (sub)
            {
                Saida[0] = !a0.ALU_1(A[0], B[0], F);
                Saida[1] = !a1.ALU_1(A[1], B[1], F);
                Saida[2] = !a2.ALU_1(A[2], B[2], F);
                Saida[3] = !a3.ALU_1(A[3], B[3], F);
                Saida[4] = !a4.ALU_1(A[4], B[4], F);
                Saida[5] = !a5.ALU_1(A[5], B[5], F);
                Saida[6] = !a6.ALU_1(A[6], B[6], F);
                Saida[7] = !a7.ALU_1(A[7], B[7], F);
            }
            else
            {
                Saida[0] = a0.ALU_1(A[0], B[0], F);
                Saida[1] = a1.ALU_1(A[1], B[1], F);
                Saida[2] = a2.ALU_1(A[2], B[2], F);
                Saida[3] = a3.ALU_1(A[3], B[3], F);
                Saida[4] = a4.ALU_1(A[4], B[4], F);
                Saida[5] = a5.ALU_1(A[5], B[5], F);
                Saida[6] = a6.ALU_1(A[6], B[6], F);
                Saida[7] = a7.ALU_1(A[7], B[7], F);
            }

            return Saida;
        }

        public bool comparar(bool[] vetor)
        {
            int cont = 0;

            for (int i= 0; i < vetor.Length; i++)
            {
                if (vetor[i])
                {
                    cont++;
                }
            }

            if(cont == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
