using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
     class Point<T>:ICloneable where T:ICloneable,new()
    {
        public T data;
        public Point<T> next;

        public Point()
        {
            data=default(T);
            next = null;
        }
        public Point(T d)
        {
            data = d;
            next = null;
        }
        public override string ToString()
        {
            return data.ToString()+" ";
        }
        public object Clone()
        {
            return new Point<T> { data =(T)data.Clone(), next=this.next };
        }


    }
}
