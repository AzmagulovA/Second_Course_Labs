using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__9
{
    class Program
    {
        static Time plus_sec(Time b, int a)
        {
            return new Time 
            {
                Seconds = (a + b.Seconds) % 60,
                Minutes = (b.Minutes + (a + b.Seconds) / 60) % 60,
                Hours = b.Hours + (b.Minutes + (a + b.Seconds) / 60) / 60,
            };
        }
        
        static void Main(string[] args)
        {
            Time res=new Time();
            Console.WriteLine(res.Minutes);
            Console.WriteLine(res.bool_q());
            res = new Time(5,59,59);
            

           res.print();
            int s;
            bool ok;
            do
            {
                Console.WriteLine("sec?");
                ok = int.TryParse(Console.ReadLine(), out s);
            } while (!ok);
            Console.WriteLine("Результат добавления секунд к типу Time");     
             res = res.pl_sec(s);
            res.print();
            Console.WriteLine("Повторное прибавление введенного числа. Результат:");
            res=plus_sec(res, s);
            res.print();
            ++res;
            res++;
            res.print();
            --res;
            res--;
            --res;
            res.print();
            Console.WriteLine($"Количество созданных экзепляров класса: ");
            res.print_count();
            Console.ReadKey();
        }
        
    }
    
}

