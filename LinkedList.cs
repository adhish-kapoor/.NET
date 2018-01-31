using System;

namespace LinkedList1
{
    class Program
    {
        public class node

        {

            public node link { get; set; }

            public string info { get; set; }

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
            int pos = int.Parse(Console.ReadLine());//pos to delete element
            string text = Console.ReadLine();


            string[] numbers = text.Split(' ');
            

            node temp;
            node temp2 = new node();
            node start = new node();
            node newhead = new node();
            for (int i = 0; i < numbers.Length; i++)
            {
                temp = new node();
                temp.info = numbers[i];
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
             delete(ref temp, pos,ref start);
            newhead = start;
            while (newhead != null)
            {
                Console.Write(newhead.info + " ");
                newhead = newhead.link;
            }
            Console.ReadKey();

        }
    }
}
