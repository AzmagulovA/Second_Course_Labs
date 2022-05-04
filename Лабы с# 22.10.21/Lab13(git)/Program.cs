using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab10;
using Lab12;
namespace Lab13
{
    
    class Program
    {
        static Journal joun1 = new Journal();
        static Journal joun2 = new Journal();
        static void Display1(object sourse,CollectionHandlerEventArgs e)//метод реагирующий на событие (подписка)
        {
            Console.WriteLine(e.ToString());
            JournalEntry je = new JournalEntry(e.CollectionName, e.Info, e.Vehicl);
            joun1.Add(je);
        }
        static void Display2(object sourse, CollectionHandlerEventArgs e)//метод реагирующий на событие
        {
            Console.WriteLine(e.ToString());
            JournalEntry je = new JournalEntry(e.CollectionName, e.Info, e.Vehicl);
            joun2.Add(je);
        }
        static void Main(string[] args)
        {
            //delegate CollectionHandler;
            MyCollect<Person> first = new MyCollect<Person>("first");
            MyCollect<Person> second = new MyCollect<Person>("second");
            
            first.CollectionCountChanged += Display1;//подписка на метод
            first.CollectionReferenceChanged += Display1;

            second.CollectionReferenceChanged += Display2;
            second.CollectionReferenceChanged += Display1;


            Person one= new Person(17, "Galina", false);
            Person two = new Person(18, "Irina", false);
            Person three = new Person(50, "Lena", false);

            first.AddPointToEnd(one);              
            first.DellPoint(0);
            //first[0]=three;
            second.AddPointToEnd(one);
            second.AddPointToEnd(two);
            
            second[0] = three;

            Console.WriteLine("Первый журнал !!!!!");
            for (int i = 0; i < joun1.Count; i++)
                Console.WriteLine(joun1[i]);

            Console.WriteLine("Второй журнал !!!!!");
            for (int i = 0; i < joun2.Count; i++)
                Console.WriteLine(joun2[i]);

            Console.ReadKey();
            //second.CollectionReferenceChanged += new CollectionHandler(joun1.CollectionReferenceChanged);


        }
    }
}
