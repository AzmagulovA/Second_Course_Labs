using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа__9
{
    class Time
    {

        private int hours = 0;
        private int minutes = 0;
        private int seconds = 0;
        static private int count = 0;
        public int Hours
        {
            get { return hours; }
            set
            {
                if (value < 0)
                {
                    hours = 0;
                }
                else
                {
                    hours = value;
                }
            }
        }
        public int Minutes
        {
            get => minutes;
            set
            {
                if (value < 0)
                {
                    minutes = 0;
                }
                else
                {
                    minutes = value;
                }
            }
        }

        public int Seconds
        {
            get => seconds;
            set
            {
                if (value < 0)
                {
                    seconds = 0;
                }
                else
                {
                    seconds = value;
                }
            }
        }



        ~Time()
        {
            count--;
        }
        public Time()//Конструктор без параметров
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
            count++;
        }
        public Time(int h)//С параметром 
        {
            Hours = h;
            Minutes = 0;
            Seconds = 0;
            count++;
        }
        public Time(int h, int m)
        {
            Hours = h + (m / 60);
            Minutes = m % 60;
            Seconds = 0;
            count++;
        }
        public Time(int h, int m, int s)
        {
            Hours = h + (m + (s / 60)) / 60;
            Minutes = (m + (s / 60)) % 60;
            Seconds = s % 60;
            count++;
        }
        public Time pl_sec(int a)
        {
            return new Time
            {

                Seconds = (a + Seconds) % 60,
                Minutes = (Minutes + (a + Seconds) / 60) % 60,
                Hours = Hours + (Minutes + (a + Seconds) / 60) / 60
            };
        }
        public void print()
        {
            Console.WriteLine($"{Hours} :{Minutes} :{Seconds}");

        }
        public void print_count()
        {
            Console.WriteLine(count);
        }

        public static explicit operator int(Time t)
        {
            return t.Minutes;
        }
        public static implicit operator bool(Time t)
        {
            return t.Hours == 0 && t.Minutes == 0;
        }
        public static Time operator ++(Time a)
        {

            return new Time
            {
                Seconds = a.Seconds,
                Minutes = ++a.Minutes % 60,
                Hours = a.Hours + ++a.Minutes / 60
            };
        }
        public static Time operator --(Time a)
        {
            int min;
            
            if (--a.Minutes < 0)
            {
                min = 0;
            }
            else
            {
                min = --a.Minutes;
            }
            return new Time
            {

                Seconds = a.Seconds,
                Minutes = min % 60,
                Hours = a.Hours
            };
        }
        public static Time operator +(Time a,Time b)
        {


            return new Time
            {
                Seconds = (b.Seconds + a.Seconds) % 60,
                Minutes = (a.Minutes+b.Minutes + (b.Seconds + a.Seconds) / 60) % 60,
               Hours = a.Hours+b.Hours +( a.Minutes + b.Minutes + (b.Seconds + a.Seconds) / 60)/60


            };
           
            
        }
        public static Time operator +(int a, Time b)
        {


            return new Time
            {
                Seconds = b.Seconds ,
                Minutes = (a + b.Minutes ) % 60,
                Hours =  b.Hours + ((a + b.Minutes ) / 60) / 60


            };


        }
        public static Time operator +( Time b,int a)
        {


            return new Time
            {
                Seconds = b.Seconds,
                Minutes = (a + b.Minutes) % 60,
                Hours = b.Hours + ((a + b.Minutes) / 60) / 60


            };


        }
        public static Time operator -(Time a, Time b)
        {


            
            Time c=new Time();
            int Hseca;
            int Hsecb;
            
            Hseca =a.Hours*3600+a.Minutes*60+a.Seconds;
            Hsecb = b.Hours * 3600 + b.Minutes * 60 + b.Seconds;
            if (Hseca > Hsecb)
            {
                c.Hours = (Hseca - Hsecb)/3600;
                c.Minutes = (Hseca - Hsecb)/60;
                c.Seconds = (Hseca -Hsecb);  
            }
           

           

            return c;

            


        }


    }
}