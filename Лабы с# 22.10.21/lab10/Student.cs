using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Student : Person
    {
        private int exp=0;
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
        public Student(int ex,int age, string name, bool gender_m):
            base(age,name,gender_m)
        {
            Exp = ex;
        }
    }
}
