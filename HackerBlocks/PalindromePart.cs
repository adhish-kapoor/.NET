//minimum cuts to form palindrome substrings
using System;

namespace palindromepart
{
    class Program
    {
        static void Main(string[] args)
        {
            int t=int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                string a = Console.ReadLine();
                int la = a.Length;
                bool[,] dp=new bool[la+1,la+1];
                int[,] cuts = new int[la + 1, la + 1];

                for(int i=0;i<la;i++)
                {
                    dp[i, i] = true; //diagonal elements
                    cuts[i, i] = 0;
                }
                for(int l = 2; l <= la; l++)
                {
                    for(int i=0;i<la-l+1;i++)
                    {
                        int j = i + l - 1;

                        if (l == 2)
                        {
                            if (a[i] == a[j]) //two characters same
                                dp[i, j] = true;
                        }
                        else
                        {
                            if (a[i] == a[j] && dp[i + 1,j - 1] == true)
                                dp[i, j] = true;
                        }
                        if (dp[i, j] == true)
                            cuts[i, j] = 0;
                        else
                        {
                            cuts[i, j] = int.MaxValue;
                            for(int k = i; k <= j; k++)
                            {
                                cuts[i, j] = Math.Min(cuts[i, j], cuts[i, k] + cuts[k + 1,j] + 1);
                            }
                        }
                            
                    }
                }
                Console.WriteLine(cuts[0, la - 1]);
                
            }
            Console.ReadKey();
        }
    }
}
