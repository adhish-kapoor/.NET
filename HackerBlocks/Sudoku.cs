using System;

namespace SudokuSolver
{
    class Program
    {
        static bool CanPlace(int [,]a,int r,int c,int n,int number)
        {
            for(int i=0;i<n;i++)
            {
                if (a[r, i] == number)
                    return false;
                if (a[i, c] == number)
                    return false;
            }
            int  sqrtn = (int)(Math.Sqrt(n));
            int smallblockR = r - r % sqrtn;
            int smallblockC = c - c % sqrtn;

            for(int i=smallblockR;i<smallblockR+sqrtn;i++)
            {
                for(int j=smallblockC;j<smallblockC+sqrtn;j++)
                {
                    if (a[i, j] == number)
                        return false;
                }
            }
            return true;
        }
       static bool sudoku(int [,]a,int r,int c,int n)
        {
            if (r >= n)
                return true;
            if (c >= n)
                return sudoku(a, r + 1, 0, n);
            if(a[r,c]!=0)
            {
                return sudoku(a, r, c + 1, n);
            }
            for(int i=1;i<=n;i++)
            {
                if(CanPlace(a,r,c,n,i))
                {
                    a[r, c] = i;
                    bool next = sudoku(a, r, c+1, n);
                    if (next)
                        return true;
                    a[r, c] = 0;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
           for(int i=0;i<n;i++)
            {
                string text = Console.ReadLine();
                string[] numbers = text.Split(' ');
                for(int j=0;j<n;j++)
                {
                    a[i, j] = int.Parse(numbers[j]);
                }
            }


            bool success= sudoku(a,0,0,n);
            if (success)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("This sudoku can't be solved");
            //Console.ReadKey();
        }

        }
    }
