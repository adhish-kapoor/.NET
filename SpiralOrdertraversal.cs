using System;

using System.Collections.Generic;

namespace SpiralOrderTraversal

{

    class Program

    {

        public class node

        {

            public node left { get; set; }

            public node right { get; set; }

            public int info { get; set; }

        }
        Stack<node> s1 = new Stack<node>();
        Stack<node> s2 = new Stack<node>();

        void spiralorder(node temp)

        {
           
            s1.Push(temp);

            while(s1.Count!=0 || s2.Count!=0)
            {
                while(s1.Count!=0)
                {
                    node top = s1.Peek();
                    s1.Pop();
                    Console.WriteLine(top.info);
                    
                    if (top.right!=null)
                        s2.Push(top.right);
                    if(top.left!=null)
                        s2.Push(top.left);
                }
                while (s2.Count != 0)
                {

                    node top = s2.Peek();
                    s2.Pop();
                    Console.WriteLine(top.info);
                   
                    if (top.left!=null)
                        s1.Push(top.left);
                    if (top.right!=null)
                        s1.Push(top.right);
                }


            }



        }

        static void Main(string[] args)

        {

            Console.WriteLine("Enter number of nodes ");

            int n = int.Parse(Console.ReadLine());



            node root = new node();

            node temp1 = new node();

            node temp;

            for (int i = 0; i < n; i++)

            {

                temp = new node();

                temp.info = int.Parse(Console.ReadLine());

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

            Program p = new Program();

            p.spiralorder(temp);



            Console.ReadKey();

        }

    }

}
