using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
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
            Console.WriteLine($"Использовние конструктора без параметров(res):{res.Hours}:{res.Minutes}:{res.Seconds} "); 
            
            res = new Time(5);
            Console.WriteLine($"Использовние конструктора с 1 параметром(res):{res.Hours}:{res.Minutes}:{res.Seconds} ");

            res = new Time(5, 59);
            Console.WriteLine($"Использовние конструктора с 2 параметрами(res):");
            res.print();
            res = new Time(5, 59, 59);
            Console.WriteLine($"Использовние конструктора с 3 параметрами(res):");
            res.print();
            Console.WriteLine($"Добавление секунд методом класса (1): ");
            res = res.pl_sec(1);
            res.print();
            Console.WriteLine($"Добавление секунд статической функцией(60): ");
            res = plus_sec(res,60);
            res.print();
            Console.WriteLine($"Количество созданных компонентов класса: ");
            res.print_count();
            Console.WriteLine($"Префиксное вычитание и префиксное прибавление секунд: ");
            --res;
            res.print();
            ++res;
            res.print();
            Console.WriteLine($"Постфиксное вычитание и постфиксное прибавление секунд: ");
            Time ser;
            ser=res--;
            ser.print();
            res.print();
            ser=res++;
            ser.print();
            res.print();
            ser = new Time();
            Console.WriteLine($"Операции приведения типа:{(int)res}   {(bool)ser}");
            Console.WriteLine($"Бинарные операции: левостороннее и правостороннее сложение(+5)");
            res = res + 5;
            res.print();
            res = 5+ res;
            res.print();
            Console.WriteLine($"Бинарные операции: левостороннее и правостороннее вычитание(-5)");            
            res = res-5;
            res.print();
            Console.Write($"5-Time=");
            res = 5-res;
            res.print();
            Console.WriteLine($"Работа с FractionTime");
            FractionTime mas = new FractionTime();
            Console.WriteLine($"Использовние конструктора без параметров(mas). Size:={mas.Size} ");

            Console.WriteLine($"Создание массива методом ручного ввода");
            mas = new FractionTime(true);//Создание массива методом ручного ввода
            mas.print();

            Console.WriteLine($"Среднее арифметичекое");
            Time d = mas.midlle();
            d.print();

            Console.WriteLine($"Создание массива методом ДСЧ");
            mas = new FractionTime(false);//Создание массива методом ДСЧ
            mas.print();

           d = mas[0];
            Console.WriteLine($"Использование индексатора mas(0)=");
            d.print();
           




            Console.ReadKey();
        }

    }

}