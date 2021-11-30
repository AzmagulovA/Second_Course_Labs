using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person[] mas = new Person[4];
            //List < Person > mas= new List<Person>();
            
            Person a = new Person(17,"Myotra",false);
           
            Student b = new Student(3,18,"Artyom",true);
            Employee c = new Employee(180, 4, 27, "Elena", false);
            Teacher d = new Teacher(5, 322, 6, 45, "Nikolay", true);

            //Person[] mas = new Person[4];
            //array[0] = o1;
            object[] mas = { a, b, c, d };
            mas[1] = b;
            mas[2] = c;
            mas[3] = a;
            mas[4] = d;
            Console.WriteLine(mas[3].Name);

            Console.ReadKey();
        }
    }
}
