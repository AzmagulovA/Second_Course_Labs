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
                    sec.Add(pe.Name);
                    four.Add(pe.Name, guy);
                    three.Add(pe, guy);
                    fir.Add(pe);
                    set_hide.Add(guy);
                    count++;
                }
                Count = set_hide.Count;
            }

            Count = set_hide.Count;
        }
        public void Analis()
        {
            Stopwatch time = new Stopwatch();
            Student bfirst = (Student)set_hide[0].Clone() ;
            Student blast = (Student)set_hide[set_hide.Count - 1].Clone();
            Student bcenter = (Student)set_hide[set_hide.Count / 2].Clone();
            Student bnan = (Student)RandomFactory.GetRandom(0);
            Person pefirst = bfirst.BasePerson;
            Person pelast = blast.BasePerson;
            Person pecenter = blast.BasePerson;
            Person penan = bnan.BasePerson;
            string sfirst = bfirst.Name;
            string slast = blast.Name;
            string scenter = bcenter.Name;
            string snan = bnan.Name;
            bool isfind;
            //LinkedList<T>
            time.Start();
            isfind = fir.Contains(pefirst);
            time.Stop();
            Console.WriteLine($"Первый        , LinkedList<T>                        : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = fir.Contains(pelast);
            time.Stop();
            Console.WriteLine($"Последний     , LinkedList<T>                        : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = fir.Contains(pecenter);
            time.Stop();
            Console.WriteLine($"Средний       , LinkedList<T>                        : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = fir.Contains(penan);
            time.Stop();
            Console.WriteLine($"Несуществующий, LinkedList<T>                        : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            //LinkedList<string>
            time.Restart();
            isfind = sec.Contains(sfirst);
            time.Stop();
            Console.WriteLine($"Первый        , LinkedList<string>                   : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = sec.Contains(slast);
            time.Stop();
            Console.WriteLine($"Последний     , LinkedList<string>                   : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = sec.Contains(scenter);
            time.Stop();
            Console.WriteLine($"Средний       , LinkedList<string>                   : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = sec.Contains(snan);
            time.Stop();
            Console.WriteLine($"Несуществующий, LinkedList<string>                   : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            //SortedDictionary<TKey,TValue> Key
            time.Restart();
            isfind = three.ContainsKey(pefirst);
            time.Stop();
            Console.WriteLine($"Первый        , SortedDictionary<TKey,TValue> Key    : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = three.ContainsKey(pelast);
            time.Stop();
            Console.WriteLine($"Последний     , SortedDictionary<TKey,TValue> Key    : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = three.ContainsKey(pecenter);
            time.Stop();
            Console.WriteLine($"Средний       , SortedDictionary<TKey,TValue> Key    : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = three.ContainsKey(penan);
            time.Stop();
            Console.WriteLine($"Несуществующий, SortedDictionary<TKey,TValue> Key    : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            //SortedDictionary<TKey,TValue> Value
            time.Restart();
            isfind = three.ContainsValue(bfirst);
            time.Stop();
            Console.WriteLine($"Первый        , SortedDictionary<TKey,TValue> Value  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = three.ContainsValue(blast);
            time.Stop();
            Console.WriteLine($"Последний     , SortedDictionary<TKey,TValue> Value  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = three.ContainsValue(bcenter);
            time.Stop();
            Console.WriteLine($"Средний       , SortedDictionary<TKey,TValue> Value  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = three.ContainsValue(bnan);
            time.Stop();
            Console.WriteLine($"Несуществующий, SortedDictionary<TKey,TValue> Value  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            //SortedDictionary<string,TValue> Key
            time.Restart();
            isfind = four.ContainsKey(sfirst);
            time.Stop();
            Console.WriteLine($"Первый        , SortedDictionary<string,TValue> Key  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = four.ContainsKey(slast);
            time.Stop();
            Console.WriteLine($"Последний     , SortedDictionary<string,TValue> Key  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = four.ContainsKey(scenter);
            time.Stop();
            Console.WriteLine($"Средний       , SortedDictionary<string,TValue> Key  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = four.ContainsKey(snan);
            time.Stop();
            Console.WriteLine($"Несуществующий, SortedDictionary<string,TValue> Key  : {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            //SortedDictionary<string,TValue> Value
            time.Restart();
            isfind = four.ContainsValue(bfirst);
            time.Stop();
            Console.WriteLine($"Первый        , SortedDictionary<string,TValue> Value: {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = four.ContainsValue(blast);
            time.Stop();
            Console.WriteLine($"Последний     , SortedDictionary<string,TValue> Value: {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = four.ContainsValue(bcenter);
            time.Stop();
            Console.WriteLine($"Средний       , SortedDictionary<string,TValue> Value: {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");

            time.Restart();
            isfind = four.ContainsValue(bnan);
            time.Stop();
            Console.WriteLine($"Несуществующий, SortedDictionary<string,TValue> Value: {time.ElapsedTicks.ToString().PadRight(6)}, result={isfind}");
        }
        /* public bool Del(Student b)
         {
             if (set_hide.Contains(b))
             {
                 fir.Remove(b.BasePerson);
                 sec.Remove(b.BasePerson.Name);
                 three.Remove(b.BasePerson);
                 four.Remove(b.BasePerson.Name);
                 set_hide.Remove(b);
                 Count = set1.Count;
                 return true;
             }
             else
             {
                 return false;
             }
         }*/
        public void Full_List(TestCollections a)
        {

            List<Person> fir = new List<Person>();

            List<string> sec = new List<string>();
            Dictionary<Person, Student> three = new Dictionary<Person, Student>();
            Dictionary<string, Person> four = new Dictionary<string, Person>();
           
        }

    }
   
}

