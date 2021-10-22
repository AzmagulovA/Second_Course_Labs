using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 1000f;
           float b = 0.0001f;
            float c = (float)Math.Pow(a + b, 2);
            float d = (float)Math.Pow(a, 2);
            float e = (float)2 * a * b;
            float g = (float)Math.Pow(b, 2);
            float h = (float)(d + e);
            float i = (float)(c -h);
            float j = (float)(i / g);
           

            
           Console.WriteLine($"float a=1000, float b=0,0001");
           Console.WriteLine($"1)(a+b)^2={c}");
           Console.WriteLine($"2)a^2+2*a*b={h}");
           Console.WriteLine($"3)(a+b)^2-(a^2+2*a*b))={i}");
            Console.Write($"4)((a+b)^2-(a^2+2*a*b))/b^2 ,float a=1000,float b=0.0001 ==\n{j}\n");
           

            Console.WriteLine("_______________________________________________________________");
           double a1 = 1000;
            double b1 = 0.0001;
            double c1 = Math.Pow(a1 + b1, 2);
            double d1 = Math.Pow(a1, 2);
            double e1 = 2 * a1 * b1;
            double g1 = Math.Pow(b1, 2);
            double h1 = d1 + e1;
            double i1 = c1 - h1;

            Console.WriteLine($"double a=1000, double b=0,0001");
            Console.WriteLine($"1)(a+b)^2={c1}");
            Console.WriteLine($"2)a^2+2*a*b={h1}");
            Console.WriteLine($"3)(a+b)^2-(a^2+2*a*b))={i1}");
            Console.Write($"4)((a+b)^2-(a^2+2*a*b))/b^2 ,double a=1000,double b=0.0001 ==\n{i1 / g1}\n");

            Console.ReadKey();


        }
    }
}
