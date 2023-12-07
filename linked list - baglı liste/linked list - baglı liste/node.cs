using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list___baglı_liste
{
    internal class node
    {
        int value;

        public int Deger
        {
            get {  return this.value; }
            set { this.value = value; }

        }

        //node= düğüm
        node sonraki;
        public node Sonraki
        {
            get { return sonraki; }
            set { sonraki = value; }
        }

        public node (int deger)
        {
            value = deger;
            sonraki = null;
            
        }
    
    }
}
