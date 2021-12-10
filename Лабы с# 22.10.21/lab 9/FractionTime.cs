using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class FractionTime
    {
        private int size = 0;
        public Time[] arr;
        static private int count = 0;
        public int Size
        {
            get { return size; }
            set { if (value < 0) { size = 0; } else { size = value; } }
        }
        ~FractionTime()
        {
            count--;
        }
        public FractionTime()
        {
            arr = new Time[0];
        }
       static public int take_el()
        {
            bool ok;
            int h;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out h);
                if (!ok) Console.WriteLine("Error! Неверно введено число");

            } while (!ok);
            return h;
        }
        public FractionTime( bool e)
        {
            bool ok;
            byte h;
            do
            {
                Console.WriteLine("Введите количество элементов массива(max 255)");
                ok = byte.TryParse(Console.ReadLine(), out h);
                if (!ok) Console.WriteLine("Error! Неверно введено число");
               
            } while (!ok) ;

            Size = h;
            arr = new Time[h];
            int b, c, d;
            Time a;
            if (e == true)
            {
                for (int i = 0; i < Size; i++)
                {
                    Console.WriteLine("Hour?");                                    
                    b = take_el();
                    Console.WriteLine("Min?");
                    c = take_el();
                    Console.WriteLine("Sec?");
                    d = take_el();
                    a = new Time(b, c, d);
                    arr[i] = a;
                }
            }
            else
            {
                Random rnd;
                rnd = new Random();

                for (int i = 0; i < Size; i++)
                {
                    b = rnd.Next(0, 255);
                    c = rnd.Next(0, 255);
                    d = rnd.Next(0, 255);
                    a = new Time(b, c, d);
                    arr[i] = a;
                }
            }
            count++;
        }
        public Time this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
        public void print()
        {
            Time a;

            for (int i = 0; i < Size; i++)
            {
                a = this[i];
                Console.Write($"arr[{i}]==");
                a.print();
            }
        }
        public Time midlle()
        {
            Time b;
            b = new Time();
            for (int i = 0; i < Size; i++)
            {
                b = b + this[i];
            }
            b = b/Size;
            return b;
        }


    }
}
