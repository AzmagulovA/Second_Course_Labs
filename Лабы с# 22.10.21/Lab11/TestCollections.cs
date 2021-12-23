using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;



namespace Lab11
{
    public class TestCollections
    {
        public List<Person> fir;
        public  List<string> sec;      
        public  Dictionary<Person, Student> three;
        public  Dictionary<string,Student> four;
        public List<Student> set_hide;
        public int Count { get; set; }


        public TestCollections()
        {

            fir = new List<Person>()  ;
           
            sec = new List<string>() { };
            three = new Dictionary<Person, Student>();
            four = new Dictionary<string, Student>();
            set_hide = new List<Student>();
        }
        public void Add(int num)
        {
            int count = 0;
            while (count != num)
            {

                Student guy = (Student)RandomFactory.GetRandom(0) ;
                Person pe = guy.BasePerson;
                if (!four.ContainsKey(pe.Name) && !three.ContainsKey(pe))
                {
                    fir.Add(pe);
                    sec.Add(pe.Name);
                    three.Add(pe, guy);
                    four.Add(pe.Name, guy);                                  
                    set_hide.Add(guy);
                    count++;
                }
                Count = set_hide.Count;
            }

            Count = set_hide.Count;
        }
        public bool Del(Student b)
        {
            if (set_hide.Contains(b))
            {
                fir.Remove(b.BasePerson);
                sec.Remove(b.BasePerson.Name);
                three.Remove(b.BasePerson);
                four.Remove(b.BasePerson.Name);
                set_hide.Remove(b);
                Count = fir.Count;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Analis()
        {
            Stopwatch time = new Stopwatch();
            Student stfirst = (Student)set_hide[0].Clone();
            Student stlast = (Student)set_hide[set_hide.Count - 1].Clone();
            Student stcenter = (Student)set_hide[set_hide.Count / 2].Clone();
            Student stnan = (Student)RandomFactory.GetRandom(0);
            Person pefirst = stfirst.BasePerson;
            Person pelast = stlast.BasePerson;
            Person pecenter = stlast.BasePerson;
            Person penan = stnan.BasePerson;
            string sfirst = stfirst.Name;
            string slast = stlast.Name;
            string scenter = stcenter.Name;
            string snan = stnan.Name;
            bool isfind;
            //List<T> Person
            time.Start();
            isfind = fir.Contains(fir[0]);//Порядковое сравнение (от первого к последнему символу) Линейный поиск
            time.Stop();
            Console.WriteLine($"Первый        , List<T>                        : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = fir.Contains(fir[fir.Count() - 1]);
            time.Stop();
            Console.WriteLine($"Последний     , List<T>                        : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");


            time.Restart();
            isfind = fir.Contains(fir[fir.Count()/2]);
            time.Stop();
            Console.WriteLine($"Средний       , List<T>                        : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = fir.Contains(penan);
            time.Stop();
            Console.WriteLine($"Несуществующий, List<T>                        : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");


            //LinkedList<string>
            time.Restart();
            isfind = sec.Contains(sec[0]);
            time.Stop();
            Console.WriteLine($"Первый        , List<string>                   : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = sec.Contains(sec[sec.Count() - 1]);
            time.Stop();
            Console.WriteLine($"Последний     , List<string>                   : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = sec.Contains(sec[sec.Count()/2]);
            time.Stop();
            Console.WriteLine($"Средний       , List<string>                   : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = sec.Contains(snan);
            time.Stop();
            Console.WriteLine($"Несуществующий, List<string>                   : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            //SortedDictionary<TKey,TValue> Key Person,Student(b)
            time.Restart();
            isfind = three.ContainsKey(pefirst);
            time.Stop();
            Console.WriteLine($"Первый        , Dictionary<TKey,TValue> Key    : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = three.ContainsKey(pelast);
            time.Stop();
            Console.WriteLine($"Последний     , Dictionary<TKey,TValue> Key    : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = three.ContainsKey(pecenter);
            time.Stop();
            Console.WriteLine($"Средний       , Dictionary<TKey,TValue> Key    : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = three.ContainsKey(penan);
            time.Stop();
            Console.WriteLine($"Несуществующий, Dictionary<TKey,TValue> Key    : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            //SortedDictionary<TKey,TValue> Value Person,Student(b)
            time.Restart();
            isfind = three.ContainsValue(stfirst);
            time.Stop();
            Console.WriteLine($"Первый        , Dictionary<TKey,TValue> Value  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = three.ContainsValue(stlast);
            time.Stop();
            Console.WriteLine($"Последний     , Dictionary<TKey,TValue> Value  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = three.ContainsValue(stcenter);
            time.Stop();
            Console.WriteLine($"Средний       , Dictionary<TKey,TValue> Value  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = three.ContainsValue(stnan);
            time.Stop();
            Console.WriteLine($"Несуществующий, Dictionary<TKey,TValue> Value  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            //SortedDictionary<string,TValue> Key
            time.Restart();
            isfind = four.ContainsKey(sfirst);
            time.Stop();
            Console.WriteLine($"Первый        , Dictionary<string,TValue> Key  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = four.ContainsKey(slast);
            time.Stop();
            Console.WriteLine($"Последний     , Dictionary<string,TValue> Key  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = four.ContainsKey(scenter);
            time.Stop();
            Console.WriteLine($"Средний       , Dictionary<string,TValue> Key  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = four.ContainsKey(snan);
            time.Stop();
            Console.WriteLine($"Несуществующий, Dictionary<string,TValue> Key  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            //SortedDictionary<string,TValue> Value
            time.Restart();
            isfind = four.ContainsValue(stfirst);
            time.Stop();
            Console.WriteLine($"Первый        , Dictionary<string,TValue> Value: {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = four.ContainsValue(stlast);
            time.Stop();
            Console.WriteLine($"Последний     , Dictionary<string,TValue> Value: {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = four.ContainsValue(stcenter);
            time.Stop();
            Console.WriteLine($"Средний       , Dictionary<string,TValue> Value: {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = four.ContainsValue(stnan);
            time.Stop();
            Console.WriteLine($"Несуществующий, Dictionary<string,TValue> Value: {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");
        }
       
        public void Full_List(TestCollections a)
        {

            List<Person> fir = new List<Person>();

            List<string> sec = new List<string>();
            Dictionary<Person, Student> three = new Dictionary<Person, Student>();
            Dictionary<string, Person> four = new Dictionary<string, Person>();
           
        }

    }
   
}

