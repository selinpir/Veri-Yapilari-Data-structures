using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_kod
{
    internal class stack
    {
        private int p_index; //stack pointer
        private ArrayList list; // stack i tutması için bir arraylist

        public stack()
        { 
        list=new ArrayList();
            p_index = -1;
        }
        public void push (object item)
        {
            list.Add(item);
            p_index++;

        }
        public object pop () //parametre almasına gerek yok en yukaridaki değeri döndürür.
        {
            object obj = list[p_index];
            list.RemoveAt(p_index);
            p_index--;
            return obj ;
        }
        public void clear()
        { 
            list.Clear();
            p_index = -1; //index sıfırlanır.
        }

        public int count
        {
            get{ return list.Count; } //stack boyutu döndürülür.
        }

    }
    
}
