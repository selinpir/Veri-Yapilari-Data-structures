using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kuyruk kyrk = new kuyruk();
            stack stk = new stack();

            Console.WriteLine("bir kelime giriniz");
            string kelime = Console.ReadLine();
            for (int i = 0; i < kelime.Length; i++)
            {
                stk.push(kelime.Substring(i, 1));
                kyrk.enqueue(kelime.Substring(i, 1));

            }

            bool palindromMu = true;
            int pozisyon = 0;

            while (stk.count > 0)
            {
                string stack_karakteri = stk.pop().ToString();
                string queue_karakter = kyrk.dequeue().ToString();
                if (stack_karakteri != queue_karakter)
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


            return;

        }
         
    }
}
