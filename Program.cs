using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, g;
            Console.WriteLine("Введите число x ");
            r = double.Parse(Console.ReadLine());
            g = 3 * Math.Pow(r, 4) - 5 * Math.Pow(r, 3) + 2 * Math.Pow(r, 2) - r + 7;
            Console.WriteLine(g);






        }
    }
}
