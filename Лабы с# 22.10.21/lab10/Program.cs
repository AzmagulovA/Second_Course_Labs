using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int size = 4;
            
            IExecutable[] m=new IExecutable[size];//Массив элементов типа IExecutable
            Person a = new Person(17, "Borya", false);
            Student b = new Student(3, 18, "Artyom", true);
            Employee c = new Employee(180, 4, 27, "Elena", false);
            Teacher d = new Teacher(5, 322, 6, 45, "Nikolay", true);
            m[0] = d;
            m[1] = b;
            m[2] = c;
            m[3] = a;         
            Console.WriteLine($"Мой вывод");
            for (int i = 0; i < 4; i++)
            {
                m[i].print();//Вывод элементов массива 
            }
            Person[] people = new Person[size] ;
           for(int i=0; i < size; i++)
            {
                people[i]=(Person)m[i];
            }
            Array.Sort(people);//Сортировка элементов методом Icomparable
            foreach (Person p in people)
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
                // p.print();
            }
            Console.WriteLine();    
            for (int i = 0; i < size; i++)
            {
                people[i] = (Person)m[i];
            }
            Array.Sort(people, new PeopleComparer());//Сортировка элементов массива IExecutable по размеру имени элемента(ICompare )
            foreach (Person p in people)
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
               // p.print();
            }

            Person p3 = new Person { Name = "Tom", Age = 23 };
            Person p4 = p3;
            p4.Name = "Alice";
            Console.WriteLine(p3.Name); // Alice, а должно вывестись Tom

            Person p1 = new Person { Name = "Tom", Age = 23 };
            Person p2 = (Person)p1.Clone();
            p2.Name = "Alice";
            Console.WriteLine(p1.Name); // Tom

           
            Console.ReadKey();
        }
    }
}
