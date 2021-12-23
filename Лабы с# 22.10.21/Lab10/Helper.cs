using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Helper : ICloneable
    {
        
        public string Name{ get; set; }
        public int  Age { get; set; }
        public Company Work { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
