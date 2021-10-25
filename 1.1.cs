using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int m, n, x,rest;
            bool ok;
           
            do
            {
                do
                {
                    Console.Write("n?");
                    ok = int.TryParse(Console.ReadLine(), out n);
                    if (!ok) Console.WriteLine("Error! Try again.");
                } while (!ok);
                do
                {
                    Console.Write("m?");
                    ok = int.TryParse(Console.ReadLine(), out m);
                    if (!ok) Console.WriteLine("Error! Try again.");
                } while (!ok);
                Console.Write($"1) n={n} m={m}  n+++m={n++ + m}\n");
                Console.Write($"   n={n} m={m}\n");
                Console.Write($"2) n={n} m={m}  m-->n={m-- > n}\n");
                Console.Write($"   n={n} m={m}\n");
                Console.Write($"3) n={n} m={m}  n-->m={n-- > m}\n");
                Console.Write($"   n={n} m={m}\n");
                Console.WriteLine($"4)sin(x)+x^3+1/(x^2+1)");
                do
                {
                    Console.Write("x?");
                    ok = int.TryParse(Console.ReadLine(), out x);
                    if (!ok) Console.WriteLine("Error! Try again.");
                } while (!ok);
                Console.WriteLine($"sin(x)+x^3+1/(x^2+1), x={x}\n{Math.Sin(x * Math.PI / 180) + Math.Pow(x, 3) + (1 / (Math.Pow(x, 2) + 1))}");


                do
                {
                    Console.WriteLine($"Нажмите 1 для повторного запуска программы");
                    Console.WriteLine($"Для выхода нажмите любую другую клавишу");
                    
                        ok = int.TryParse(Console.ReadLine(), out rest);
                    if (rest != 1)
                    {
                        Environment.Exit(0);
                    }
                    if (!ok) Console.WriteLine("Error! Try again.");
                } while (!ok);
                


            }
            while (rest == 1);
            
            

        }
    }
    
}
