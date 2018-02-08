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

        public static node newnode(int data)
        {
            node temp = new node();
            temp.info = data;
            temp.left = null;
            temp.right = null;

            return temp;
        }

        public static int search(int []ino,int beg,int end,int val)
        {
            int i;
            for(i=beg;i<=end;i++)
            {
                if (ino[i] == val)
                    break;
            }
            return i;
        }

        public static node create1(int[] ino, int[] post,int beg,int end,ref int pind)
        {
            if (end < beg)
                return null;
            node temp = newnode(post[pind]);
            pind--;

            if (beg == end)
                return temp;
            int inoind = search(ino,beg, end, temp.info);//finding index in inorder array

            temp.right = create1(ino, post, inoind + 1, end, ref pind);//right subtree
            temp.left = create1(ino, post, beg , inoind-1, ref pind);//left subtree

            return temp;

        }

        public static node create(int []ino,int[]post,int n)
        {
            int pind = n - 1;
            return create1(ino, post, 0, n - 1, ref pind);
        }

        static void Main(string[] args)
        {
                int t = int.Parse(Console.ReadLine());
                while (t-- > 0)
                {
                    int n = int.Parse(Console.ReadLine());
                    int[] ino = new int[n];
                    int[] post = new int[n];
                    string text = Console.ReadLine();
                    string[] numbers = text.Split(' ');
                    for (int i = 0; i < numbers.Length; i++)
                    ino[i] = int.Parse(numbers[i]);

                string text1 = Console.ReadLine();
                string[] numbers1 = text1.Split(' ');
                for (int i = 0; i < numbers1.Length; i++)
                    post[i] = int.Parse(numbers1[i]);

                node temp=create(ino, post, n);
                preorder(temp);
            }
           // Console.ReadKey();
        }
    }
}
