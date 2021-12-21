using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Student : Person
    {
        private int exp = 0;
        public int Exp
        {
            get { return exp; }
            set
            {
                if (value < 0)
                {
                    exp = 0;
                }
                else
                {
                    exp = value;
                }
            }

        }
        public override bool Equals(object other)
        {
            var x = other as Student;
            return this.Age == x.Age &&
                   this.Name == x.Name &&
                   this.Exp==x.Exp &&
                   this.Gender_m == x.Gender_m;

        }
        public override object Clone()
        {
           return(new Student (Exp,Age,Name,Gender_m)) ;
        }
        public Person BasePerson
        {
            get
            {
                return new Person(Age,Name, Gender_m);//возвращает объект базового класса
            }
        }
        public Student()
        {
            Exp = 0;
            Age = 0;
            Name="";
            Gender_m=false;
        }
        public Student(int ex, int age, string name, bool gender_m) :
            base(age, name, gender_m)
        {
            Exp = ex;
        }


        public override void print()
        {
            Console.WriteLine($"Имя:{Name}");
            Console.WriteLine($"Возраст:{Age}");
            if (Gender_m == true)
            {
                Console.WriteLine($"Пол: Мужской");
            }
            else
            {
                Console.WriteLine($"Пол: Женский");
            }
            Console.WriteLine($"Год обучения:{Exp}");
            Console.WriteLine();

        }
    }
}
