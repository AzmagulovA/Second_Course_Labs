using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab10;
using Lab12;
//using Lab10;

namespace Lab14
{
    class Program
    {
        static void AddETF(Dictionary<int,Person> list)
        {
            Person a = new Person(17, "Borya", true);//age name gender_m
            Student b = new Student(3, 18, "Artyom", true);
            Student e = new Student(2, 19, "Arthur", true);//exp age name gender_m
            Employee c = new Employee(180, 4, 56, "Elena", false);//numb exp age name gender_m
            Teacher d = new Teacher(5, 322, 6, 45, "Nikolay", true);//groups numb exp ....
            list.Add(1,a);
            list.Add(2,b);
            list.Add(3,c);
            list.Add(4,d);
            list.Add(5,e);
        }
        static void AddGNF(Dictionary<int,Person> list)
        {
            Person a = new Person(16, "Irina", false);
            Student b = new Student(2, 19, "Arthur", true);
            Employee c = new Employee(181, 4, 55, "Masha", false);
            Teacher d = new Teacher(3, 321, 6, 47, "Alex", true);
            list.Add(1,a);
            list.Add(2,b);
            list.Add(3,c);
            list.Add(4,d);
        }
        static int Take_el(int a, int b)
        {
            bool ok;
            int Op;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out Op);
                if (!ok) Console.WriteLine("Error! Неверно ведено число.");
                if ((Op > b) || (Op < a)) Console.WriteLine("Error!Такой операции нет. Повторите попытку");
            } while ((!ok) || (Op > b) || (Op < a));
            return Op;
        }
        static int LINQMax(List<Dictionary<int, Person>> list)
        {
            int res=0;
            res = (from grouppe in list from pe in grouppe select pe.Value.Age).Max();
            return res;
        }
        static int MaxR(List<Dictionary<int, Person>> list)
        {
            int res = 0;
            res = list.SelectMany(f => f.Values).Max<Person>(x => x.Age);
            return res;
        }

        static void LINQAgreg(List<Dictionary<int,Person>> list )
        {
            
            int op = 0; 
            while (op != 3)
            {
                Console.WriteLine("________________________________________________________");
                Console.WriteLine("Выборка самого великовозрастного человека в университете");
                Console.WriteLine("1) LINQ запрос");
                Console.WriteLine("2) Метод расширения");
                Console.WriteLine("3) Назад");
                op= Take_el(1, 3); 
                int ress=0;

               
                //(from grouppe in q from pe in grouppe where pe is Book select pe.Price).Average()
                if (op == 1)
                {//Вывод всех студентов 
                    //Console.WriteLine("(from grouppe in list from pe in grouppe where pe is Person select pe.Age).Max()");
                    ress = LINQMax(list);
                }
                if (op == 2)
                {
                    // Console.WriteLine("list.SelectMany(f => f).Max<Person>(x => x.Age);");

                    ress = MaxR(list);//Max<Person>(x => x.Age);
                }

               // foreach (IExecutable person in list)
                    Console.WriteLine(ress);
            }            
        }
        static void PrintVuz(List<Dictionary<int,Person>> list)
        {
            var ress = (from grouppe in list from pe in grouppe  select pe);
            foreach (var el in ress) { Console.WriteLine(el.Value); Console.WriteLine(); };

        }
        static IEnumerable<Person> LINQNameA(List<Dictionary<int, Person>> list)
        {
            //List<Person> res =new List<Person>();
            IEnumerable<Person> res = from grouppe in list from pe in grouppe where pe.Value.Name.StartsWith("A") select pe.Value; 
            return res;
        }
        static IEnumerable<Person> RNameA(List<Dictionary<int, Person>> list)
        {
            //List<Person> res =new List<Person>();
            IEnumerable<Person> res = list.SelectMany(f => f.Values).Where(p => p.Name.StartsWith("A"));
            return res;
        }
        static void LINQVib(List<Dictionary<int,Person>> list)
        {

            int op = 0;
            while (op != 3)
            {
                Console.WriteLine("_____________________________");
                Console.WriteLine("Выборка людей с Именем на <А>");
                Console.WriteLine("1) LINQ запрос");
                Console.WriteLine("2) Метод расширения");
                Console.WriteLine("3) Назад");
                op = Take_el(1, 3);               
                if (op == 1)
                {
                    IEnumerable<Person> res = LINQNameA(list);
                    foreach (var el in res) { Console.WriteLine(el); Console.WriteLine(); }
                }
                if (op == 2)
                {
                    //Console.WriteLine("list.SelectMany(f => f).Max<Person>(x => x.Age);");
                    IEnumerable<Person> ress = RNameA(list);
                    foreach (var el in ress)
                    {
                     
                        Console.WriteLine(el);
                        Console.WriteLine();
                    }
                }                            
            }
        }
        static IEnumerable<IGrouping<bool, KeyValuePair<int, Person>>>  LINQGroupZ(List<Dictionary<int, Person>> list)
        {
            IEnumerable<IGrouping<bool, KeyValuePair<int, Person>>> res = from grouppe in list from pe in grouppe group pe by pe.Value.Gender_m == true;
            return res;
        }
        static IEnumerable<IGrouping<bool, Person>> RGroup(List<Dictionary<int, Person>> list)
        {

            //List<Person> res =new List<Person>();
            IEnumerable<IGrouping<bool, Person>> res = list.SelectMany(f => f.Values).GroupBy(p => p.Gender_m);
            return res;
        }
        static void LINQGroup(List<Dictionary<int,Person>> list)
        {

            int op = 0;
            while (op != 3)
            {
                Console.WriteLine("_____________________________");
                Console.WriteLine("Группировка людей по полу");
                Console.WriteLine("1) LINQ запрос");
                Console.WriteLine("2) Метод расширения");
                Console.WriteLine("3) Назад");
                op = Take_el(1, 3);
                if (op == 1)
                {
                    var res = LINQGroupZ(list);
                    foreach (var el in res) 
                    {
                        Console.WriteLine(el.Key);
                        foreach (var p in el)
                        {
                            Console.WriteLine(p.Value);
                            Console.WriteLine();
                        }
                    }
                }
                if (op == 2)
                {
                    //Console.WriteLine("list.SelectMany(f => f).Max<Person>(x => x.Age);");
                    var ress = RGroup(list);
                    foreach (var el in ress)
                    {
                        Console.WriteLine(el.Key);
                        foreach (var p in el)
                        {
                            Console.WriteLine(p);
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
        static void LINQSchet(List<Dictionary<int,Person>> list)
        {

            int op = 0;
            while (op != 3)
            {
                Console.WriteLine("_______________________");
                Console.WriteLine("Подсчет людей вузе");
                Console.WriteLine("1) LINQ запрос");
                Console.WriteLine("2) Метод расширения");
                Console.WriteLine("3) Назад");
                op = Take_el(1, 3);
                if (op == 1)
                {
                    int res = (from grouppe in list from pe in grouppe  select pe.Value).Count<Person>();
                    
                        Console.WriteLine(res);
                }
                if (op == 2)
                {
                    //Console.WriteLine("list.SelectMany(f => f).Max<Person>(x => x.Age);");
                    int ress = (list.SelectMany(f => f.Values).Select(p => p)).Count<Person>();
                   
                        Console.WriteLine(ress);
                }
            }
        }

        static void LINQOperac(List<Dictionary<int,Person>> list)
        {

            int op = 0;
            while (op != 3)
            {
                Console.WriteLine("_______________________");
                Console.WriteLine("Пересечение множеств");
                Console.WriteLine("1) LINQ запрос");
                Console.WriteLine("2) Метод расширения");
                Console.WriteLine("3) Назад");
                op = Take_el(1, 3);
                if (op == 1)
                {
                    var res = (from grouppe in list[0] select grouppe.Value).Intersect(from grouppe in list[1] select grouppe.Value);
                    foreach (var el in res)
                        Console.WriteLine(el);
                }
                if (op == 2)
                {
                   
                    var ress = (list[0].Select(f => f.Value).Intersect(list[1].Select(f => f.Value)));

                    foreach (var el in ress)
                        Console.WriteLine(el);
                }
            }
        }

        static void Main(string[] args)
        {
            List<Dictionary<int,Person>> Vuz = new List<Dictionary<int,Person>> ();
           Dictionary<int,Person> ETF = new Dictionary<int,Person>();
            Dictionary<int,Person> GNF = new Dictionary<int,Person>();

            AddETF(ETF);
            AddGNF(GNF);
            Vuz.Add(ETF);
            Vuz.Add(GNF);
            int op = 0;
            while (op != 7)
            {

                Console.WriteLine("__________________________________________");
                Console.WriteLine("1) Выборка данных");
                Console.WriteLine("2) Получение счетчика ");
                Console.WriteLine("3) Использование операций над множествами ");
                Console.WriteLine("4) Агрегирование данных.");
                Console.WriteLine("5) Группировка людей по полу");
                Console.WriteLine("6) Вывод участников вуза");
                Console.WriteLine("7) Назад");

                op = Take_el(1, 7);
                if (op == 1)
                {
                    LINQVib(Vuz);
                }
                if (op == 2)
                {
                    LINQSchet(Vuz);
                }
                if (op == 3)
                {
                    LINQOperac(Vuz);
                }
                if (op==4) 
                {
                    LINQAgreg(Vuz); 
                }
                if (op == 5)
                {
                   LINQGroup(Vuz);
                }
                if (op == 6)
                {
                    PrintVuz(Vuz);
                }
                MyCollection<Person> help = new MyCollection<Person>();
                //int h = Shcet(help);
                //help.Shcet();
                
            }
            
            
            Console.ReadKey();


        }
    }
}
