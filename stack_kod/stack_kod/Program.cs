using stack_kod;
using System;
namespace Program
{
    class program
    {
        static void Main(string[] args) 
        {
            /* stack stk = new stack();
             string cikan;
             stk.push(4);
             Console.WriteLine("4 eklendi.Stack boyutu "+ stk.count);
             stk.push(5);
             Console.WriteLine("5 eklendi.Stack boyutu " + stk.count);
             stk.push(6);
             Console.WriteLine("6 eklendi.Stack boyutu " + stk.count);
             cikan= stk.pop().ToString();
             Console.WriteLine(cikan + " çıkarıldı.Stack boyutu " + stk.count);
             cikan = stk.pop().ToString();
             Console.WriteLine(cikan + " çıkarıldı.Stack boyutu " + stk.count);
             cikan = stk.pop().ToString();
             Console.WriteLine(cikan + " çıkarıldı.Stack boyutu " + stk.count);
             stk.push(9);
             Console.WriteLine("9 eklendi.Stack boyutu " + stk.count);
             stk.clear();
             Console.WriteLine("stack temizlendi. Stack boyutu" + stk.count);
             stk.push(12);
             Console.WriteLine("12 eklendi.Stack boyutu " + stk.count);
              */


            //palindrom örnek
            stack stk = new stack();
            Console.WriteLine("bir kelime giriniz");
            string kelime = Console.ReadLine();

            bool palindromMu = true;

            for (int i = 0; i < kelime.Length; i++)
            {
                stk.push(kelime.Substring(i, 1)); // kelimenin karakterleri parçalandı ve stacke eklendi
            }

            int pozisyon = 0;
            string karakter;
            while(stk.count > 0) 
            {
                karakter = stk.pop().ToString();

                if(kelime.Substring(pozisyon,1)!=karakter)
                {
                    palindromMu = false;
                    break;
                }
                pozisyon++;

            }
            if (palindromMu)
            {
                Console.WriteLine(kelime + " bir palindrom kelimedir.");
            }
            else
            {
                Console.WriteLine(kelime + " bir palindrom kelime değildir.");
            }
        }


    }
}