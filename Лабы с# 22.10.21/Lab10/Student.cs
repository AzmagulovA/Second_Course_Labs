using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
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
        public Student(int ex, int age, string name, bool gender_m) :
            base(age, name, gender_m)
        {
            Exp = ex;
        }
        

        public override void Print()
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
