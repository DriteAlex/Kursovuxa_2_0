using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodLibrary
{
    public class Methods
    {
        double xStart;
        double xEnd;
        double eps;
        double step;
        int n = 0;
        public double[] mass;
        public int SetData()
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

            n = 0;//размерность массива
            double arraySize = xStart;//переменная для подсчёта размерности массива

            for (int i = 0; arraySize < xEnd; i++)
            {
                arraySize += step;
                n++;
            }

            mass = new double[n];
            return n;
        }

        public void ShowData()
        {
            for (int i = 0; i < mass.Length; i++)
            {
                double checkFormul = CheckControlFormul();
                Console.WriteLine($@"Формула для элемента {i + 1}: {checkFormul:f6}");

                double sum = CalculateSumSeries();
                mass[i] = sum;
                Console.WriteLine($@"Сумма элемента {i + 1}: {mass[i]:f6}  
");
            }
        }

        public double CalculateSumSeries()
        {
            double sumSeries = 0;
            double x = xStart;
            double element = 1;

            double a, b;// переменные для расчёта формулы суммы ряда
            a = 3;
            b = 8;

            double znak = 1;

            for (int i = 1; Math.Abs(element)>eps; i++)
            {
                if (i==1)
                {
                    element = xStart;
                    //Console.WriteLine($@" X({i}) = {element}");
                    sumSeries +=element;
                }

                if (i > 1)
                {
                    znak *= -1;
                    x *= xStart;

                    element = znak*((a / b) * x);
                    //Console.WriteLine($@" X({i}) = {element}");
                    sumSeries += element;

                    a *= 4 * (i+2) - 5;
                    b *= 4*(i+2);
                }
            }

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
