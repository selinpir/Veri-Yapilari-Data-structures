using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list___baglı_liste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            linkedlist liste = new linkedlist();
            Console.WriteLine("başa ekle 3 sayı");
            liste.basaEkle(9);
            liste.basaEkle(41);
            liste.basaEkle(22);
            liste.goster();
            Console.WriteLine();

            Console.WriteLine("baştan sil 2 sayı");
            liste.bastansil();
            liste.bastansil();
            liste.goster();
            Console.WriteLine();

            Console.WriteLine("sona ekle 3 sayı");
            liste.sonaEkle(36);
            liste.sonaEkle(48);
            liste.sonaEkle(54);
            liste.goster();
            Console.WriteLine();

            //sıralanmış şekilde ekler
            Console.WriteLine("sıralayarak ekle 3 sayı");
            liste.siraliEkle(89);
            liste.siraliEkle(999);
            liste.siraliEkle(19);
            liste.goster();
            Console.WriteLine();

            liste.sondansil();
            liste.sondansil();
            liste.sondansil();
            liste.sondansil();
            liste.sondansil();
            liste.sondansil();
            liste.sondansil();
            liste.sondansil();
            liste.basaEkle(1);
            liste.goster();

            Console.WriteLine();
          //  Console.ReadLine();

        }
    }
}
