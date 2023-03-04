using System;

namespace MethodLibrary
{
    static public class Massives
    {
        public static int n;

        static public T[,] CreateMassive<T>(Func<T> rnd)
        {
            var arr = new T[n,n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    arr[i, j] = rnd.Invoke();

            return arr;
        }
        static public void ShowMassive<T>(this T[,] mass, string message)
        {
            Console.WriteLine($"{message}\n\n");

            int i = 1;
            foreach (var x in mass)
            {
                var str = $"{x:f2}";
                if (i % n != 0)
                {
                    switch (str.Length)
                    {
                        case 1:
                            Console.Write($@"|     {str}|");
                            break;
                        case 2:
                            Console.Write($@"|    {str}|");
                            break;
                        case 3:
                            Console.Write($@"|   {str}|");
                            break;
                        case 4:
                            Console.Write($@"|  {str}|");
                            break;
                        case 5:
                            Console.Write($@"| {str}|");
                            break;
                        case 6:
                            Console.Write($@"|{str}|");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($@"| {str} |");
                }
                i++;
            }
        }

        static public int[,] TranspotionMassive(this int[,] mass)
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

        static public double[,] MultiplyMassives(this int[,] trans, double[] massA)
        {
            var massiveC = new double[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    massiveC[i, j] = trans[i, j] * massA[i];

            return massiveC;
        }

        static int[] ViborSort(int[] mas)
        {

            for (int i = 0; i < mas.Length - 1; i++)
            {
                //поиск минимального числа
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                //обмен элементов
                int temp = mas[min];
                mas[min] = mas[i];
                mas[i] = temp;
            }
            return mas;
        }
    }
}
