using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLibrary
{
    public class Massives:Methods
    {
        int n = 0; //размерность массива
        public Massives(int n)
        {
            this.n = n;
            
        }

        public int[,] CreateMassive(int[,] mass)
        {
            mass = new int[n, n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = rnd.Next(-15, 45);
                }
            }
            return mass;
        }

        public double[,] CreateMassive(double[,]mass)
        {
            mass = new double[n, n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = rnd.Next(-15, 45);
                }
            }
            return mass;
        }

        public void ShowMassive(int[,] mass,string message)
        {
            Console.WriteLine($@"{message}

");
            int i = 1;
            foreach (var x in mass)
            {
                string str = x.ToString();
                if (i % n != 0)
                {
                    switch (str.Length)
                    {
                        case 1:
                            Console.Write($@"|   {str}|");
                            i++;
                            break;
                        case 2:
                            Console.Write($@"|  {str}|");
                            i++;
                            break;
                        case 3:
                            Console.Write($@"| {str}|");
                            i++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($@"| {str} |");
                    i++;
                }
            }
        }

        public void ShowMassive(double[,] mass,string message)
        {
            Console.WriteLine($@"{message}

");
            int i = 1;
            foreach (var x in mass)
            {
                string str = x.ToString();
                str = $"{x:f2}";
                if (i % n != 0)
                {
                    switch (str.Length)
                    {
                        case 1:
                            Console.Write($@"|     {str}|");
                            i++;
                            break;
                        case 2:
                            Console.Write($@"|    {str}|");
                            i++;
                            break;
                        case 3:
                            Console.Write($@"|   {str}|");
                            i++;
                            break;
                        case 4:
                            Console.Write($@"|  {str}|");
                            i++;
                            break;
                        case 5:
                            Console.Write($@"| {str}|");
                            i++;
                            break;
                        case 6:
                            Console.Write($@"|{str}|");
                            i++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($@"| {str} |");
                    i++;
                }
            }
        }

        public int[,] TranspotionMassive(int[,] mass)
        {
            int[,] trans = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    trans[i, j] = mass[j, i];
                }
            }
            return trans;
        }

        public double[,] MultiplyMassives(int[,] trans, double[] massA)
        {
            double[,] massiveC = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    massiveC[i, j] = trans[i, j] * massA[i];
                }
            }
            return massiveC;
        }

    }
}
