using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab10;
namespace MyTest10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CloneTest()
        {
            Person p1 = new Person { Name = "Tom", Age = 23 };
            Person p2 = (Person)p1.Clone();
            p2.Name = "Alice";
            Assert.AreEqual("Tom", p1.Name);
        }
        [TestMethod]
        public void Konstr()
        {
            Person p1 = new Person (-5,"Olga",true);
           
            Assert.AreEqual(0, p1.Age);
        }
        [TestMethod]
        public void SortIcomparable()
        {
            IExecutable[] m = new IExecutable[4];//Массив элементов типа IExecutable
            Person a = new Person(17, "Borya", false);
            Student b = new Student(-3, 18, "Artyom", true);
            Employee c = new Employee(180, 4, 27, "Elena", false);
            Teacher d = new Teacher(5, 322, 6, 45, "Nikolay", true);
            m[0] = d;
            m[1] = b;
            m[2] = c;
            m[3] = a;
           
            Person[] people = new Person[4];
            for (int i = 0; i < 4; i++)
            {
                people[i] = (Person)m[i];
            }
            Array.Sort(people);
            Assert.AreEqual("Artyom", people[0].Name);
        }
        [TestMethod]
        public void SortICompare()
        {
            IExecutable[] m = new IExecutable[4];//Массив элементов типа IExecutable
            Person a = new Person(17, "Borya");
            Student b = new Student(3, 18, "Artyom", true);
            Employee c = new Employee(180, 4, 27, "Lena", false);
            Teacher d = new Teacher(-1, -3, 6, 45, "Nikolay", true);
            m[0] = d;
            m[1] = b;
            m[2] = c;
            m[3] = a;

            Person[] people = new Person[4];
            for (int i = 0; i < 4; i++)
            {
                people[i] = (Person)m[i];
            }
            Array.Sort(people, new SortByName());
            Assert.AreEqual("Lena", people[0].Name);
        }
        [TestMethod]
        public void Get_Gender()
        {
            Person a = new Person(3);
            bool b;
            b = a.Gender_m;
            Assert.AreEqual(false, b);
        }
        [TestMethod]
        public void Use_Help()
        {
            Helper p5 = new Helper { Name = "Tom", Age = 23, Work = new Company { Name = "Microsoft" } };
           Helper p6=(Helper)p5.Clone();
            p6.Work.Name = "Google";
            p6.Name = "Alice";

            Assert.AreEqual("Google", p5.Work.Name);
        }
    }
}