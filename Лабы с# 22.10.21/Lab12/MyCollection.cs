using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
     class MyCollection<T>
    {

        Point<T> beg = null;
       

       

        public MyCollection() //Создание пустой коллекции
        {
            beg = new Point<T>();
            Point<T> p = beg;
        }
        public MyCollection(int capacity)//Cоздание коллекции емкостью capacity
         {
            beg = new Point<T>();
            Point<T> p = beg;
            for(int i = 0; i < capacity; i++)
            {
                Point<T> temp = new Point<T>();
                p.next = temp;
                p = temp;
            }


        }
        public int Length(MyCollection<T> c)//  Колличество элементов коллекции
        {
            int length=0;
            Point<T> p = c.beg;
            while (p != null)
            {
                length++;
                p = p.next;

            }
                return length;
        }
        public MyCollection(MyCollection<T> c) //создание коллекции с элементами коллекции с
        {
            beg = new Point<T>();
            Point<T> p = c.beg;
            Point<T> helper = c.beg;
            for (int i = 0; i < Length(c); i++)
            {
                Point<T> temp = helper.next;
                p.next = temp;
                p = temp;
            }
        }



    }
}
