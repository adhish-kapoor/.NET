using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                Console.WriteLine("Enter a number");
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                    throw new ArithmeticException();

                Console.WriteLine(Math.Sqrt(n));
                
            }
            catch(FormatException)
            {
                Console.WriteLine("Wrong format");
            }
            catch(Exception ex)
            {
               
                    Console.WriteLine("Invalid number");

            }
            finally
            {
                Console.WriteLine("Good bye");
            }
            Console.ReadKey();
        }
    }
}