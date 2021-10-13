using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            float a11, a21, a31, a12, a22, a32, a13, a23, a33, a14, a24, a34, ax, ay, az, ad, x, y, z;
            Console.WriteLine("Дана система из трех уравнений вида ax+by+cz=d");
            Console.WriteLine("Введите a1");
            a11 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите a2");
            a21 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите a3");
            a31 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите b1");
            a12 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите b2");
            a22 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите b3");
            a32 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите c1");
            a13 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите c2");
            a23 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите c3");
            a33 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите d1");
            a14 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите d2");
            a24 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите d3");
            a34 = float.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели:");
            Console.WriteLine($"{a11}x{a12}+{a13}y+z={a14}");
            Console.WriteLine($"{a21}x{a22}+{a23}y+z={a24}");
            Console.WriteLine($"{a31}x{a32}+{a33}y+z={a34}");
            ax = a11 * a21 / a11;
            ay = a12 * a21 / a11;
            az = a13 * a21 / a11;
            ad = a14 * a21 / a11;
            a21 = a21 - ax;
            a22 = a22 - ay;
            a23 = a23 - az;
            a24 = a24 - ad;
            ax = a11 * a31 / a11;
            ay = a12 * a31 / a11;
            az = a13 * a31 / a11;
            ad = a14 * a31 / a11;
            a31 = a31 - ax;
            a32 = a32 - ay;
            a33 = a33 - az;
            a34 = a34 - ad;
            ay = a22 * a32 / a22;
            az = a23 * a32 / a22;
            ad = a24 * a32 / a22;
            a32 = a32 - ay;
            a33 = a33 - az;
            a34 = a34 - ad;
            z = a34 / a33;
            y = (a24 - a23 * z) / a22;
            x = (a14 - a13 * z - a12 * y) / a11; 
             Console.WriteLine($"Ответ: x={x};y={y};z={z}");


        }
    }
}
