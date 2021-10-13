using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a;
            string b;
            Console.WriteLine("Введите трехзначное число:");
            a = int.Parse(Console.ReadLine());
            b = a.ToString();


            char[] inputarray = b.ToCharArray();
            Array.Reverse(inputarray);
            string output = new string(inputarray);
            Console.WriteLine(output);

        }
    } 
}
   