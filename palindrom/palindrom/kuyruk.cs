using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
     class kuyruk
    {
        ArrayList list;

        public kuyruk()
        {
            list = new ArrayList();                
        }
        public void enqueue(object item)
        {
            list.Add(item);
        }
        public object dequeue()
        {
            object obj = list[0];
            list.RemoveAt(0);
            return obj;
        }
        public void clear()
        {
            list.Clear();
        }

        public int count
        { 
            get { return list.Count; }
        }

    }
}
