using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    public class CollectionHandlerEventArgs : EventArgs//Класс для передачи информации о событии
    {
        public string CollectionName { get; set; }//имя коллекции
        public string Info { get; set; }//информация об изменении

        public object Vehicl { get; set; }//ссылка на объект с которым связаны изменения
        public override string ToString()
        {
            return string.Format($"имя коллекции:  { CollectionName } ; тип изменений:  { Info } ;  данные объекта с которым связаны изменения: { Vehicl.ToString() } ");


        }

       // return string.Format($"Имя:{Name}\nВозраст:{ Age}\nПол::Женский\nГод обучения:{Exp}\nНомер сотрудника:{Numb}");
        public CollectionHandlerEventArgs(string name, string info, object vehicle)
        {
            CollectionName = name;
            Info = info;
            Vehicl = vehicle;
        }

    }
}
