using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class Time
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


        public static int Convert_sec(Time a)
        {
           
            int Hseca;
            Hseca = a.Hours * 3600 + a.Minutes * 60 + a.Seconds;
            return Hseca;
        }
        public static Time Convert_time(int a)
        {
            Time c = new Time();
            c.Hours = a / 3600;
            c.Minutes = a % 3600 / 60;
            c.Seconds = a % 60;
            return c;
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
            int b =Convert_sec(a);
            ++b;
            Time c=Convert_time(b);
            return c;
        }
        public static Time operator --(Time a)
        {
            int b = Convert_sec(a);
            --b;
            Time c = Convert_time(b);
            return c;
        }
        public static Time operator +(Time a, Time b)
        {
            Time c;
            int Hseca, Hsecb;
            Hseca = Convert_sec(a);
            Hsecb = Convert_sec(b);
            Hseca = Hseca + Hsecb;
            c = Convert_time(Hseca);
            return c;
        }
        public static Time operator +(int a, Time b)
        {
            Time c;
            int Hseca;
            Hseca = Convert_sec(b);
            Hseca = Hseca + a * 60;
            c = Convert_time(Hseca);
            return c;
        }
        public static Time operator +(Time b, int a)
        {
            Time c;
            int Hseca;
            Hseca = Convert_sec(b);
            Hseca = Hseca + a * 60;
            c = Convert_time(Hseca);
            return c;
        }
        public static Time operator -(Time a, Time b)
        {
            Time c;
            int Hseca,Hsecb;
            Hseca = Convert_sec(a);
            Hsecb = Convert_sec(b);
            Hseca = Hseca -Hsecb;
            c = Convert_time(Hseca);
            return c;
        }
        public static Time operator -(Time a, int b)
        {
            Time c;
            int Hseca;
            Hseca = Convert_sec(a);
            Hseca = Hseca -b * 60 ;
            c = Convert_time(Hseca);
            return c;
        }
        public static Time operator -( int b,Time a)
        {
            Time c ;
            int Hseca;
            Hseca = Convert_sec(a);
            Hseca = b*60-Hseca;
            c = Convert_time(Hseca);           
            return c;
        }
        public static Time operator /(Time a, int b)
        {



            Time c = new Time();
            int Hseca;            
            Hseca = Convert_sec(a); ;
            
            Hseca = Hseca / b;

            c.Hours = (Hseca ) / 3600;
            c.Minutes = ((Hseca )% 3600)/60;
            c.Seconds = (Hseca)%60;





            return c;




        }
    }
}