using System;
using System.Collections.Generic;
namespace Nagarrobank
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, Queue<string>> sd = new SortedDictionary<int, Queue<string>>();
            Console.WriteLine("Enter number of customers to be served");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter 1 for privileged user.\nEnter 2 for normal user.");
                int priority = int.Parse(Console.ReadLine());
                
                string name = Console.ReadLine();
               if(sd.ContainsKey(priority))
                    sd[priority].Enqueue(name);
               else
                {
                    var tempQueue = new Queue<string>();
                    tempQueue.Enqueue(name);
                    sd.Add(priority, tempQueue);

                }
                

            }
            foreach(var i in sd)
            {
                if(i.Value==null || i.Value.Count == 0)
                {
                    continue;
                }
                int length = i.Value.Count;
                for(var counter = 0; counter < length; counter ++)//for serving all customers of a given priority
                {
                    var customer = i.Value.Dequeue();
                    Console.WriteLine(customer);
                }
            }
            Console.ReadKey();
        }
    }
}
