using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace linked_list___baglı_liste
{
    internal class linkedlist
    {
        node head;
        public linkedlist()
        { head = null; }

        public void basaEkle(int deger)
        {
            node gecici = new node(deger);
            gecici.Sonraki = head;
            head = gecici;
            
        }
        
        public void sonaEkle(int deger) 
        {
            node gecici = new node(deger);
            if (head == null)
                head= gecici;
            else
            {
                node iterator = head;
                while(iterator.Sonraki!=null)
                {
                    iterator= iterator.Sonraki;
                }
                iterator.Sonraki = gecici;

            }
        }

        //sıralı ekleme
        public void siraliEkle(int deger)
        {
            node gecici=new node(deger);

            if(head == null)
            {
                gecici.Sonraki = head;
                head = gecici;
            }
            else
            {
                node iterator = head;
                while(iterator.Sonraki!=null && iterator.Sonraki.Deger<=deger)
                { 
                    iterator= iterator.Sonraki;
                }
                gecici.Sonraki= iterator.Sonraki;
                iterator.Sonraki = gecici;

            }
        }
        public void bastansil()
        {
            if(head == null)
            { Console.WriteLine("liste boş.");
            }
            else
            {
                head = head.Sonraki;

            }
        }

        public void sondansil()
        {
            if (head == null)
            {
                Console.WriteLine("liste boş.");
            }
            else if(head.Sonraki == null)
            {
                head = null;
            }
            else
            {
                node iterator = head;
                node onceki = head;

                while(iterator != null)
                {
                    onceki = iterator;
                    iterator=iterator.Sonraki;                    
                }
                onceki.Sonraki = null;
            }

        }
        public void goster()
        {
            if(head ==null)
            {
                Console.WriteLine("Liste Boş.");

            }
            else
            {
                node iterator= head;
                while(iterator!=null)
                {
                    Console.Write(iterator.Deger+ " - ");
                    iterator = iterator.Sonraki;

                }
                



            }
        }
    }
}
