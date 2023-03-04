using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLibrary
{
    public class MassiveB
    {
        int n = 0; //размерность массива
        int[,] massB;
        public MassiveB(int n)
        {
            this.n = n;
        }

        public void CreateMassiveB()
        {
            massB = new int[n, n];
            Random rnd = new Random();

            for (int i = 0; i < massB.Length; i++)
            {
                for (int j = 0; j < massB.Length; j++)
                {
                    massB[i, j] = rnd.Next(-15, 45);
                }
            }
        }

        public void ShowMassiveB()
        {
            /*
            for (int i = 0; i < massB.Length; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < massB.Length; j++)
                {
                    Console.WriteLine($@"{massB[i,j]}");
                }
            }*/

             
            foreach (int x in massB)
            {
                Console.WriteLine();
                foreach (int y in x)
                    Console.Write(y + " ");
            }
        }
    }
}
