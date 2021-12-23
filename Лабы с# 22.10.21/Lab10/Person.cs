using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Person: IExecutable, IComparable, ICloneable
    {
        private int age = 0;
        private string name = "";
        private bool gender_m = false;
       
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
        public int CompareTo(object obj)//реализация интерфейса
        {
            Person temp = (Person)obj;//приведение к типу Person
            if (String.Compare(this.name, temp.name) > 0) return 1;//сортировка элементов типа string используя стандартый compare(comparer)
            if (String.Compare(this.name, temp.name) < 0) return -1;
            return 0;
        }
        public object Clone()
        {
            return new Person { Name = this.Name, Age = this.Age };
        }
       
        public Person()//Конструктор без параметров
        {
            Age = 0;
            Name = "";
            Gender_m = false;
          
        }
        public Person(int h)//С параметром 
        {
            Age = h;
            Name = "";
            Gender_m = false;
          
        }
        public Person(int h, string m)
        {
            Age = h;
            Name = m;
            Gender_m = false;
           
        }
        public Person(int h, string m, bool s)
        {
            Age = h;
            Name = m;
            Gender_m = s;
           
        }
        public virtual void PrintYoungPeople()
        {
            if (Age < 40)
            {
                Console.WriteLine($"Имя:{Name}");
                Console.WriteLine($"Возраст:{Age}");
                Console.WriteLine();
            }
          
        }
        public virtual  void  Print()
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
            if (Age>50)
                {
                Console.WriteLine($"Имя:{Name}");
            }
        }


    }

}
