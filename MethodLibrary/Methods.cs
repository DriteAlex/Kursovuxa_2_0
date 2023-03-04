using System;

namespace MethodLibrary
{
    public class Methods
    {
        double xStart;
        double xEnd;
        double eps;
        double step;
        public int n;
        public double[] mass;
        public Methods()
        {
            Console.WriteLine("Введите данные для ряда:");

            /*Console.Write("X начальное = ");
             double xStart = Convert.ToDouble(Console.ReadLine());

             Console.Write("X конечное = ");
             double xEnd = Convert.ToDouble(Console.ReadLine());

             Console.Write("eps (точность) = ");
             double eps = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Шаг для изменения X = ");
             double step = Convert.ToDouble(Console.ReadLine());
            */

            xStart = -0.9;
            xEnd = 0.9;
            eps = 0.001;
            step = 0.1;

            n = (int)((xEnd - xStart) / step + 1);

            mass = new double[n];
        }

        public void ShowData()
        {
            for (int i = 0; i < mass.Length; i++)
            {
                double checkFormul = CheckControlFormul();
                Console.WriteLine($@"Формула для элемента {i + 1}: {checkFormul:f6}");

                double sum = CalculateSumSeries();
                mass[i] = sum;
                Console.WriteLine($@"Сумма элемента {i + 1}: {mass[i]:f6}");
                Console.WriteLine();
            }
        }

        public double CalculateSumSeries()
        {
            double sumSeries = xStart;
            double x = xStart;
            double element;

            double a, b;// переменные для расчёта формулы суммы ряда
            a = 3;
            b = 8;

            double znak = 1;

            do
            {
                znak *= -1;
                x *= xStart;
                element = znak * (a / b * x);
                sumSeries += element;

                a *= a + 4;
                b *= b + 4;
            }
            while (Math.Abs(element) > eps);

            if (xStart < xEnd)
            {
                xStart += step;
            }
            return sumSeries;
        }


        public double CheckControlFormul()
        {
            double checkFormul = 4 * Math.Pow(1 + xStart, 0.25) - 4;
            return checkFormul;
        }




    }
}
