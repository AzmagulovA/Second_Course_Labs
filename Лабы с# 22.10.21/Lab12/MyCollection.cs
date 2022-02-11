using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
     class MyCollection<T>:IEnumerable<T>
    {


        class MyNumerator<T> : IEnumerator<T>
        {
            Point<T> beg;
            Point<T> current;
            public MyNumerator(MyCollection<T> list)
            {
                beg = list.beg;
                current = null;
            }
            public T Current => current.data;
            object IEnumerator.Current => current;
            public void Dispose()
            {

            }
            public bool MoveNext()
            {
                if (current == null)
                {
                    current = beg;
                }
                else
                    current = current.next;
                return current != null;
            }

        }
        Point<T> beg = null;


    }
}
