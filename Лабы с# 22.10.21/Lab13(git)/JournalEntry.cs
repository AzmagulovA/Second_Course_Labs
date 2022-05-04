using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    public class JournalEntry//хранит информацию о изменении коллекции
    {
        public string Name{ get; set; }
        public string Change { get; set; }

        public object Data { get; set; }
        public JournalEntry(string name,string change,object data)
        {
            Name = name;
            Change = change;
            Data = data;
        }
        public override string ToString()
        {
            return string.Format($"имя коллекции: ' { Name } '; тип изменений: ' { Change } ' данные объекта с которым связаны изменения: {  Data } ");
            
        }
    }
}
