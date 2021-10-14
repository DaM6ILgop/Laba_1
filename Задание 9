using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9_Новое
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3;
            Console.WriteLine("Введите значение a1 = ");
            a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение a2 = ");
            a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение a3 = ");
            a3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b1 = ");
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b2 = ");
            b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b3 = ");
            b3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение c1 = ");
            c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение c2 = ");
            c2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение c3 = ");
            c3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение d1 = ");
            d1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение d2 = ");
            d2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение d3 = ");
            d3 = double.Parse(Console.ReadLine());

            double delta = (a1 * b2 * c3) + (b1 * c2 * a3) + (c1 * a2 * b3) - (c1 * b2 * a3) - (a1 * c2 * b3) - (b1 * a2 * c3);
            if (delta != 0)
            {
                double delta1 = (d1 * b2 * c3) + (b1 * c2 * d3) + (c1 * d2 * b3) - (c1 * b2 * d3) - (d1 * c2 * b3) - (b1 * d2 * c3);
                double delta2 = (a1 * d2 * c3) + (d1 * c2 * a3) + (c1 * a2 * d3) - (c1 * d2 * a3) - (a1 * c2 * d3) - (d1 * a2 * c3);
                double delta3 = (a1 * b2 * d3) + (b1 * d2 * a3) + (d1 * a2 * b3) - (d1 * b2 * a3) - (a1 * d2 * b3) - (b1 * a2 * d3);
                double x, y, z;
                x = delta1 / delta;
                y = delta2 / delta;
                z = delta3 / delta;
                Console.WriteLine($"X = {x}; Y = {y}; Z = {z}.");
            }
            else
            {
                Console.WriteLine("Введено неверное значение! Определитель равен нулю!");
            }

        }
    }
}
