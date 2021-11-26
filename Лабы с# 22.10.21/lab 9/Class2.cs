using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__9
{
    internal class FractionTime
    {
        private int size = 0;
        public Time [] arr;
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
        public FractionTime(int h,bool e)

        { 
            Size= h;
           arr=new Time[h] ;
            int b, c, d;
            Time a;
            if (e == true)
            {
                for (int i = 0; i < Size; i++)
                {
                    b = Convert.ToInt32(Console.ReadLine());
                    c = Convert.ToInt32(Console.ReadLine());
                    d = Convert.ToInt32(Console.ReadLine());
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
        public void print(FractionTime a)
        {

            for(int i=0; i < Size; i++)
            {
                Console.WriteLine($"arr[{i}]=={this[i]}");
            }
        }
        public Time midle(FractionTime a)
        {
            Time b;
            b=new Time();
            for (int i = 0; i < Size; i++)
            {
                b=b+this[i];
            }
            return b;
        }


    }
}
