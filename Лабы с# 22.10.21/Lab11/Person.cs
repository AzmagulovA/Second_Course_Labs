using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Person : IExecutable, IComparable, ICloneable
    {
        private int age = 0;
        private string name = "";
        private bool gender_m = false;
        static private int count = 0;

        ///public bool ContainsKey(TKey key);
        public string ToString(Person a)
        {
            string S = a.Age + a.Name + Gender_m;
            return S;
        }
        public override bool Equals(object other)
        {
            var x = other as Person;
            return this.Age == x.Age &&
                   this.Name == x.Name &&
                  
                   this.Gender_m == x.Gender_m;
        }
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
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        public int CompareTo(object obj)//реализация интерфейса
        {
            Person temp = (Person)obj;//приведение к типу Person
            if (String.Compare(this.name, temp.name) > 0) return 1;
            if (String.Compare(this.name, temp.name) < 0) return -1;
            return 0;
        }
        public virtual object Clone()
        {
           
            return (new Person(Age, Name, Gender_m));

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
            Name = m;
            Gender_m = s;
            count++;
        }
        public virtual void print()
        {
            Console.WriteLine($"Имя:{Name}");
            Console.WriteLine($"Возраст:{Age}");
            if (gender_m == true)
            {
                Console.WriteLine($"Пол: Мужской");
            }
            else
            {
                Console.WriteLine($"Пол: Женский");
            }
            Console.WriteLine();

        }



        public virtual void print_W()//Метод для вывода имен всех лиц женского рода
        {
            if (gender_m != true)
            {
                Console.WriteLine($"Имя:{Name}");
            }
        }
        public virtual void print_M()//Метод для вывода имен всех лиц мужского рода
        {
            if (gender_m == true)
            {
                Console.WriteLine($"Имя:{Name}");
            }
        }
        public virtual void print_fifty()//Метод для вывода всех лиц, старше 50 лет
        {
            if (Age > 50)
            {
                Console.WriteLine($"Имя:{Name}");
            }
        }


    }

}
