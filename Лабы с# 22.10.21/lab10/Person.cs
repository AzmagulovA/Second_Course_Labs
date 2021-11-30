using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Person
    {
        private int age = 0;
        private string name = "";
        private bool gender_m = false;
        static private int count = 0;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }
        public string  Name
        {
            get => name;
            set
            {
               
                    name = value;
                
            }
        }

        public bool Gender_m
        {
            get => gender_m;
            set
            {
                if (value == true)
                {
                    gender_m = true;
                }
                else
                {
                    gender_m = false;
                }
            }
        }
        ~Person()
        {
            count--;
        }
        public Person()//Конструктор без параметров
        {
            Age = 0;
            Name = "";
            Gender_m = false;
            count++;
        }
        public Person(int h)//С параметром 
        {
            Age = h;
            Name = "";
            Gender_m = false;
            count++;
        }
        public Person(int h, string m)
        {
            Age = h;
            Name = m;
            Gender_m = false;
            count++;
        }
        public Person(int h, string m, bool s)
        {
            Age = h;
            Name =m;
            Gender_m = s;
            count++;
        }

    }
}
