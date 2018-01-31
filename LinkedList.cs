using System;

namespace LinkedList1
{
    class Program
    {
        public class node

        {

            public node link { get; set; }

            public int info { get; set; }

        }
        public static node mergelists(node a,node b)
        {
            if (a == null)
                return b;
            if (b == null)
                return a;
           node temp = null;

            if(a.info<=b.info)
            {
                temp = a;
                temp.link = mergelists(a.link, b);

            }
            else
            {
                temp = b;
                temp.link = mergelists(a, b.link);
            }
            return temp;
        }
        public static node middle(node temp)
        {
            node fast = temp;
            node slow = temp;
            while(fast.link!=null && fast.link.link!=null)
            {
                slow = slow.link;
                fast = fast.link.link;

            }
            return slow;
        }
        public static node mergesort(node temp)
        {
            if (temp == null || temp.link == null)
                return temp;
            node mid = middle(temp);
            node a = temp;
            node b = mid.link;
            mid.link = null;
            a = mergesort(a);
            b = mergesort(b);

            return mergelists(a, b);
        }
        public static void delete(ref node temp,int pos,ref node start)
        {
            if(pos==1)
            {
                start = temp.link;
                temp = null;
            }
            else
            {
                for(int i=0;i<pos-2;i++)
                {
                    temp = temp.link;
                }
                node todel = temp.link;
               todel= null;
                temp.link = temp.link.link;
            }
        }
        
        public static node reverse(node head)
        {
            node temp = head;
            node prev = null;
            node next = null;

            while (temp != null)
            {
                next = temp.link;
                temp.link = prev;
                prev = temp;
                temp = next;

            }

            return prev;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //int pos = int.Parse(Console.ReadLine());//pos to delete element
            string text = Console.ReadLine();


            string[] numbers = text.Split(' ');
            int[] arr = new int[numbers.Length];
            for(int i=0;i<numbers.Length;i++)
            {
                arr[i] = int.Parse(numbers[i]);
            }
            node temp;
            node temp2 = new node();
            node start = new node();
            node newhead = new node();
            for (int i = 0; i < numbers.Length; i++)
            {
                temp = new node();
                temp.info = arr[i];
                temp.link = null;

                if (i == 0)
                {
                    start = temp;
                    temp2 = temp;
                }
                else
                {
                    temp2.link = temp;
                    temp2 = temp;
                }

            }
            temp = start;
            // newhead = reverse(temp);
            //delete(ref temp, pos,ref start);
            newhead = mergesort(temp);
            
            while (newhead != null)
            {
                Console.Write(newhead.info + " ");
                newhead = newhead.link;
            }
            Console.ReadKey();

        }
    }
}
