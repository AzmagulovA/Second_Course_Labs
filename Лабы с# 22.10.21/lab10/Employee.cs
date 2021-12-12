using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Employee : Student
    {
        public int numb;
        public int Numb
        {
            get { return numb; }
            set
            {
                if (value < 0)
                {
                    numb = 0;
                }
                else
                {
                    numb = value;
                }
            }

        }
        public Employee(int numb,int ex, int age, string name, bool gender_m):
            base(ex,age, name, gender_m)
        {
            Numb = numb;
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
            Console.WriteLine($"Номер сотрудника:{Numb}");
            Console.WriteLine();

        }
    }
}
