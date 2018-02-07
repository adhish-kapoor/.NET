using System;

namespace memoization
{
    class Program
    {
        static int maxval(int []a,int n)
        {
            if (n <= 0)                               //length 0 no profit
                return 0;
            int max = int.MinValue;

            for (int i=0;i<n;i++)
            max= Math.Max(max, (a[i] + maxval(a, n-i-1)));//recursive call with current cut + remaining

            return max;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());

            int ans = maxval(a, n);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
