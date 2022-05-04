using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    public class Journal
    {
        int count;
        public int Count { get { return count; } }
        List<JournalEntry> history;
        public void Add(JournalEntry je)
        {
            history.Add(je);
            count++;
        }
        public JournalEntry this[int index]
        {
            get => history[index];
        }
        public Journal()
        {
            history = new List<JournalEntry>();
            count = 0;
        }

        

    }
}
