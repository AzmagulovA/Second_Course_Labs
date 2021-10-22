using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rest, x, y;
            bool ok;
            Console.WriteLine("Проверка вхождения координаты в область(x < 5)&&(y<5) ");
           
            do
            {
                do
                {
                    Console.Write("x?");
                    ok = int.TryParse(Console.ReadLine(), out x);
                    if (!ok) Console.WriteLine("Error! Try again.");
                } while (!ok);
                do
                {
                    Console.Write("y?");
                    ok = int.TryParse(Console.ReadLine(), out y);
                    if (!ok) Console.WriteLine("Error! Try again.");
                } while (!ok);


                Console.WriteLine($"{(x >= 0) && (x <= 5) && (y <= 5) && (y >= 0)}");
                do
                {
                    Console.Write("Нажмите 1 для повторения программы ");
                    Console.WriteLine($"Для выхода нажмите любую другую клавишу");
                    ok = int.TryParse(Console.ReadLine(), out rest);
                    if (rest != 1)
                    {
                        Environment.Exit(0);
                    }
                    if (!ok) Console.WriteLine("Error! Try again.");
                } while (!ok);
              


            } while (rest == 1);
           // Console.ReadKey();
        }
        

    }
}
