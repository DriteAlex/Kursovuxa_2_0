using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodLibrary;

namespace ConsoleApp1
{
    internal class Program
    {
        static readonly Random rnd = new Random();
        static void Main(string[] args)
        {
            /////////Массив A//////////
            Methods sumSeries = new Methods();
            int n = sumSeries.SetData();
            sumSeries.ShowData();

            /////////Массив B//////////
            Massives massB = new Massives(n);
            int[,] massiveB = new int[n, n];
            massiveB = massB.CreateMassive(massiveB, () => rnd.Next(-15, 45));
            massB.ShowMassive(massiveB, "Массив B");

            /////////Массив C//////////
            Console.WriteLine(@"


");
            Massives massC = new Massives(n);
            int[,] trans = massC.TranspotionMassive(massiveB);
            massC.ShowMassive(trans, "Транспонированная матрица");

            double[,] massiveC = massC.MultiplyMassives(trans, sumSeries.mass);
            massC.ShowMassive(massiveC, "Массив C");

            /////////Массив Y//////////



            Console.ReadKey();
        }
    }
}
