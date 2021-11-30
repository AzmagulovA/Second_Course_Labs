using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Teacher:Employee
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
        public Teacher(int Group,int numb, int ex, int age, string name, bool gender_m) :
            base(numb,ex, age, name, gender_m)
        {
            Groups = Group;
        }
    }
}
