using System;
namespace kuyruk_queue
{
    class program
    {
        static void Main(string[] args) 
        { 
        kuyruk queue= new kuyruk();
            string cikarilan;

        queue.enqueue(1);
        Console.WriteLine("1 eklendi. Sıra sayısı:" + queue.count);
        queue.enqueue(5);
        Console.WriteLine("5 eklendi. Sıra sayısı:" + queue.count);
        queue.enqueue(8);
        Console.WriteLine("8 eklendi. Sıra sayısı:" + queue.count);
        queue.enqueue(10);
        Console.WriteLine("10 eklendi. Sıra sayısı:" + queue.count);

        cikarilan= queue.dequeue().ToString();
        Console.WriteLine(cikarilan +" silindi. Sıra sayısı:"+ queue.count);
            
        queue.clear();
        Console.WriteLine("Sıra temizlendi.Sıra sayısı:"+ queue.count);
           
        queue.enqueue(38);
        Console.WriteLine("38 eklendi. Sıra sayısı:" + queue.count);
        }




    }

}
