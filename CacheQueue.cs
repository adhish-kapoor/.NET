using System;
using System.Collections.Generic;
namespace Cachequeue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<object> q = new Queue<object>();
            Console.WriteLine("Enter cache size");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                object data = Console.ReadLine();

                q.Enqueue(data);
            }
            while (true) { 
                
                    q.Dequeue();
                    Console.WriteLine("Enter new data to be inserted");
                    object newdata = Console.ReadLine();
                    q.Enqueue(newdata);

                Console.WriteLine("New cache becomes");
                foreach(object i in q)
                {
                    Console.WriteLine(i);
                }
                
                Console.WriteLine("Write exit to break");
                    
                if (Console.ReadLine() == "exit")
                    break;
                else 
                {
                    continue;
                }
                
            }
        }
    }
}
