using System;
using System.Collections.Generic;
namespace traversaloftree
{
    class Program
    {
        public class node
        {
            public node left { get; set; }
            public node right { get; set; }
            public int info { get; set; }
        }
        Queue<node> q = new Queue<node>();
        static void levelorder(node temp)
        {
            q.Enqueue(temp);


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of nodes ");
            int n = int.Parse(Console.ReadLine());
           
            node root = new node();
            node temp1 = new node();
            node temp = new node();
            for (int i=0;i<n;i++)
            {
                
                temp.info  = int.Parse(Console.ReadLine());
                temp.right = null;
                temp.left = null;

                if (i == 0)
                    root = temp;
                else
                {
                    temp1 = root;

                    while(true)
                    {
                        if(temp.info>=temp1.info)
                        {
                            if (temp1.right == null)
                                break;
                            temp1 = temp1.right;
                        }
                        else
                        {
                            if (temp1.left == null)
                                break;
                            temp1 = temp1.left;
                        }

                    }
                    if (temp.info >= temp1.info)
                        temp1.right = temp;
                    else
                        temp1.left = temp;

                }

            }
            temp = root;
            levelorder(temp);
            Console.ReadKey();
        }
    }
}
