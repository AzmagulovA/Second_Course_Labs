using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Teacher : Employee
    {
        public int groups;
        public int Groups
        {
            get { return groups; }
            set
            {
                if (value < 0)
                {
                    groups = 0;
                }
                else
                {
                    groups = value;
                }
            }

        }
        public Teacher()
        {
            Exp = 0;
            Age = 0;
            Name = "";
            Gender_m = false;
            Numb = 0;
            Groups = 0;
        }
        public Teacher(int Group, int numb, int ex, int age, string name, bool gender_m) :
            base(numb, ex, age, name, gender_m)
        {
            Groups = Group;
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
            Console.WriteLine($"Количество групп:{Groups}");
            Console.WriteLine();

        }

    }
}
