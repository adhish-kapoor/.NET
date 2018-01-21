using System;

namespace TryCatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range of numbers ");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            ReadNumber(start, end);
        }
        public static void ReadNumber(int start, int end)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Enter a number ");
                    int n = int.Parse(Console.ReadLine());
                    try
                    {
                        if (n > end || n < start)
                            throw new ArgumentOutOfRangeException();
                        else
                        {
                            Console.WriteLine(n);
                            Console.WriteLine();
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Number out of range\n");
                    }
                }
            }
            finally
            {
                Console.WriteLine("Thank you");
            }

            Console.ReadKey();
        }
    }
}
