using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int q = 21, w = 8; 
             Console.WriteLine(q/w + " с остатком " + q%w);
             Console.ReadKey();*/
            int n, d1, d2, d3;
            String s;
            byte w;
            Array[] r;

      
            Console.WriteLine("Введите число: ");
            s = Console.ReadLine();
            n = Convert.ToInt32(s);
            d1 = n / 100;
            d2 = (n / 10) % 10;
            d3 = n % 10;

            Console.WriteLine(d1 + d2 + d3);
            Console.ReadKey();
        }
    }
}
