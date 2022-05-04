using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab12;


namespace Lab13
{
   
    public class MyCollect<T>:MyCollection<T> where T : ICloneable, new()
    {
       
        public delegate void CollectionHandler(object source, CollectionHandlerEventArgs args);//делегат (ссылка на функцию)
        
        public event CollectionHandler CollectionCountChanged;//происходит при добавлении нового элемента или при удалении элемента из 
        public event CollectionHandler CollectionReferenceChanged;  //объекту коллекции присваивается новое значение       

        public virtual void OnCollectionCountChanged(object source, CollectionHandlerEventArgs args)//обработчик события CollectionCountChanged
        {
            if (CollectionCountChanged != null)//проверка на наличие ссылки
                CollectionCountChanged(source, args);//вызов метода из внешнего кода
        }
        //обработчик события OnCollectionReferenceChanged
        public virtual void OnCollectionReferenceChanged(object source, CollectionHandlerEventArgs args)
        {
            if (CollectionReferenceChanged != null)
                CollectionReferenceChanged(source, args);

            //CollectionReferenceChanged?.Invoke(source, args);
        }




        
        //string name;
        public string Name
        {
            get;set;
        }
        public MyCollect(string name): base() //Создание пустой коллекции
        {
            
            Name = name;
        }
        public override T this[int index]
        {
            get
            {
                return base[index];
            }
            set
            {
                OnCollectionReferenceChanged(this, new CollectionHandlerEventArgs(this.Name, "changed", this[index]));
                base[index] = value;
            }

        }

        public override void AddPointToEnd(T d)
        {
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.Name, "add", d));
            base.AddPointToEnd(d);
           

        }


        public override void DellPoint(int t) {
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.Name, "delete", this[t]));
            base.DellPoint(t);
           
        }
       /* bool Remove(int t)
        {
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(this.Name, "delete", this[t]));
            if ((t >= Count) || (t < 0))
            {
                return false;
            }
            if (t == 0)
            {
                beg = beg.next;
                Count--;
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
                Count--;
            }
            return true;
            

        }*/

    }
}
