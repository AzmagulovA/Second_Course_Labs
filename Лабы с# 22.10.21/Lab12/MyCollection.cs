using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.GC;
using System.Threading.Tasks;
using Lab10;

namespace Lab12
{
     class MyCollection<T>:IEnumerable<T> where T : ICloneable, new()
    {

        Point<T> beg = null;
        int count;

        public int Count
        {
            get { return count; }
            set
            {
                if (value < 0)
                {
                    count = 0;
                }
                else
                {
                    count = value;
                }
            }
        }
        class MyNumerator<T> : IEnumerator<T> where T : ICloneable, new()
        {
            Point<T> beg;
            Point<T> current;
           
            public T Current { get { return current.data; } }
            object IEnumerator.Current { get { return current; } }
           
            public void Dispose()
            {

            }
            
            public bool MoveNext()
            {
                if (current == null)
                    current = beg;
                else current=current.next;
                return current != null;
            }
            public void Reset()
            {
                current = this.beg;
            }
           
        }

      


        public MyCollection() //Создание пустой коллекции
        {
            beg = null;
            count = 0;
        }

       
        public int Length//  Колличество элементов коллекции
        {
            get
            {
                if (beg == null) return 0;
                int len = 0;
                Point<T> p = beg;
                while (p != null)
                {
                    p = p.next;
                    len++;

                }
                return len;
            
            }
        }
        public MyCollection(int capacity)//Cоздание коллекции емкостью capacity
        {
            
                beg = new Point<T>();
                Point<T> p = beg;
                for (int i = 0; i < capacity; i++)
                {
                    Point<T> temp = new Point<T>();
                    p.next = temp;
                    p = temp;

                }
                Count = capacity;
            
            


        }
        public MyCollection(MyCollection<T> c) //создание коллекции с элементами коллекции  с глубоким копированием 
        {

            
            beg = (Point<T>)c.beg.Clone();
            Point<T> p = beg;
            Point<T> helper = c.beg;
           

            for (int i = 0; i < c.Length-1; i++)
            {
               
                p.next= (Point<T>)helper.next.Clone();
                p = p.next;
                helper= helper.next;
                
            }
            count = c.count;
            /*Point<T> node = new Point<T>();
           
            count = c.count;

            Point<T> c_node = c.beg;
            node.data = c_node.data;
            beg= node;
            beg.next = node;
            c_node = c.beg.next;
            while (c_node != null)
            {
                Point<T> new_node = new Point<T>(c_node.data);
                node.next = new_node;
                node = new_node;
                c_node = c_node.next;
                count++;
            }*/
        }
        public void AddPointToEnd(T d)
        {
            Point<T> temp = new Point<T>(d);
            if (beg == null)
            {
                beg = temp;
                return;
            }
            Point<T> p = beg;
            while (p.next != null)
            {

                p = p.next;

            }
            p.next = temp;
            p = temp;
            count++;



        }
        public MyCollection<T> PovKop()//Поверхностное копирование
        {
            MyCollection<T> res = new MyCollection<T>();
            res.beg = beg;
            Point<T> p = res.beg;
            Point<T> helper = beg;


            for (int i = 0; i < Length - 1; i++)
            {

                p.next = helper.next;
                p = p.next;
                helper = helper.next;


            }
            return res;
        }
        public MyCollection<T> Clon()//Клонирование
        {
            MyCollection<T> res = new MyCollection<T>();
            res.beg = (Point<T>)beg.Clone();
            Point<T> p = res.beg;
            Point<T> helper = beg;


            for (int i = 0; i < Length - 1; i++)
            {

                p.next = (Point<T>)helper.next.Clone();
                p = p.next;
                helper = helper.next;


            }
            return res;
        }
        public void PrintList()
        {
            if (beg == null)
            {
                Console.WriteLine("Collection empty");

            }
            Point<T> p = beg;
            while (p != null)
            {
                Console.WriteLine(p);
                p = p.next;

            }
            Console.WriteLine();
        }
       
        public void DellPoint(int t)
        {
            
            if (t == 0)
            {
                beg = beg.next;
                count--;
            }
            if (t > 0)
            {
                Point<T> temp = new Point<T>();
                temp = beg;
                int i = 0;
                Point<T> helper = new Point<T>();
                Point<T> helpersec = new Point<T>();
                while ((temp != null) && (i != t))
                {
                    helper = temp;
                    temp = temp.next;
                    i++;

                }
                if (temp != null)
                {
                    helpersec = temp.next;
                    temp = helper;
                    temp.next = helpersec;
                }
                count--;
            }
        
        
        }
        public int SearchEl(T d)
        {
            int numb = 0;
            Point<T> p = new Point<T>();
            p = beg;
            while (p != null)
            {
                if (p.data.ToString() == d.ToString())
                {
                    return numb;
                }
                p = p.next;
                numb++; 
            }
            return -1;

        
        }
        public void Delete_Memory()
        {
            beg = null;
            count = 0;
            GC.Collect();
        }


            public IEnumerator<T> GetEnumerator()
        {
            Point<T> current = beg;
            while(current != null)
            {
                yield return current.data;
                current = current.next; 
            }
        }
          IEnumerator IEnumerable.GetEnumerator()
        {
            //return GetEnumerator();
            throw new NotImplementedException();
        }



    }
}
