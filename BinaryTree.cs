using System;
using System.Collections.Generic;
namespace BSTtraversal
{
    class Program
    {
        public class node
        {
            public node left { get; set; }
            public node right { get; set; }
            public int info { get; set; }
        }
        
        public static void preorder(node temp)
        {

            if (temp == null)
                return;
            Console.Write(temp.info + " ");
            preorder(temp.left);
            preorder(temp.right);
        }
        public static void preorder1(node temp, int[] a)
        {
            int sum = 0;
            if (temp == null)
                return;
            for (int i = 0; i < a.Length; i++)
            {
                if (temp.info < a[i])
                    sum += a[i];
            }
            temp.info += sum;
            Console.Write(temp.info + " ");
            preorder1(temp.left, a);
            preorder1(temp.right, a);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter number of nodes ");
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                string text = Console.ReadLine();
                string[] numbers = text.Split(' ');
                for (int i = 0; i < numbers.Length; i++)
                    a[i] = int.Parse(numbers[i]);
                node root = new node();
                node temp1 = new node();
                node temp;
                for (int i = 0; i < n; i++)
                {
                    temp = new node();
                    temp.info = a[i];
                    temp.right = null;
                    temp.left = null;

                    if (i == 0)
                        root = temp;
                    else
                    {
                        temp1 = root;

                        while (true)
                        {
                            if (temp.info >= temp1.info)
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
               // preorder(temp);
               // Console.WriteLine();
                // preorder1(temp, a);

                
                //topview of a binary tree
                //height of a binary tree
                //checking if a binary tree is balanced
                Console.WriteLine();
            }
             Console.ReadKey();
        }
    }
}
