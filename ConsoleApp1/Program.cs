using System;
using MethodLibrary;

namespace ConsoleApp1
{
    internal class Program
    {
        static readonly Random rnd = new Random();
        static void Main()
        {
            var data = new Methods();
            Massives.n = data.n;
            /////////Массив A//////////
            data.ShowData();

            /////////Массив B//////////
            var massiveB = Massives.CreateMassive(() => rnd.Next(-15, 45));
            massiveB.ShowMassive("Массив B");

            /////////Массив C//////////
            Console.WriteLine("\n\n\n");
            int[,] trans = massiveB.TranspotionMassive();
            trans.ShowMassive("Транспонированная матрица");

            double[,] massiveC = trans.MultiplyMassives(data.mass);
            massiveC.ShowMassive("Массив C");

            /////////Массив Y//////////



            Console.ReadKey();
        }
    }
}
