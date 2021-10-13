using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Второе_задание_по_лабе_из_личных
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, c, m;

            Console.WriteLine("Введите Х");
            x = double.Parse(Console.ReadLine());

            if (x > 0)//Проверка на отличие от нуля 
            {

                Console.WriteLine("Введите Х");
                x = double.Parse(Console.ReadLine());


            }
            else {
                Console.WriteLine("Введите число отличное от нуля");
                Console.ReadLine();
            }

            Console.WriteLine("Введите C");
                c = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите M"); 
                m = double.Parse(Console.ReadLine());      

            double z;
            z = Math.Sin(x) / Math.Sqrt(Math.Pow(m, 2) + Math.Pow(Math.Sin(x), 2)) - c * m * Math.Log(m * x);
                Console.WriteLine($"Ответ {z}");
            Console.WriteLine("Переходим к следующим действиям --->");


            Console.WriteLine("Введите число А");
                double a = double.Parse(Console.ReadLine());

             Console.WriteLine("Введите число B"); 
                double b = double.Parse(Console.ReadLine());
            
            double e = 2.7, s;//Ввод константы е
            s = Math.Pow(e, -a * x) * Math.Sqrt(x + 1) + Math.Pow(e, -b * x) * Math.Sqrt(x + 1.5);
            Console.WriteLine($"Ответ: {s}");
            Console.ReadLine();

        }
    }
}
