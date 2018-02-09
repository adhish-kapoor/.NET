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
        
        public static node balancedBST(int []a,int beg,int end){
            if(beg>end)
            return null;
            
            int mid=(beg+end)/2;
            node temp=newnode(a[mid]);
            
            temp.left=balancedBST(a,beg,mid-1);
            temp.right=balancedBST(a,mid+1,end);
            
            return temp;
        }

        public static node newnode(int data)
        {
            node temp = new node();
            temp.info = data;
            temp.left = null;
            temp.right = null;

            return temp;
        }

        static void Main(string[] args)
        {
                int t = int.Parse(Console.ReadLine());
                while (t-- > 0)
                {
                    int n = int.Parse(Console.ReadLine());
                    int[] a = new int[n];
                    string text = Console.ReadLine();
                    string[] numbers = text.Split(' ');
                    for (int i = 0; i < numbers.Length; i++)
                    a[i] = int.Parse(numbers[i]);

                
                node temp=balancedBST(a,0,n-1);
                preorder(temp);
                
                Console.WriteLine();
            }
           // Console.ReadKey();
        }
    }
}
