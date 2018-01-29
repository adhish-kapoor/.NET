using System;

namespace Knightmoves
{
    class Program
    {
       static bool canplace(int [,]a,int r,int c,int n)
        {
            if (r >= 0 && r < n && c >= 0 && c < n && a[r, c] == 0)
                return true;
            else
                return false;
        }
       static bool knight(int [,]a,int r,int c,int movenumber,int n)
        {
            if (movenumber >= 64)
                return true;
            int[] rowdir = {+2,+1,-1,-2,-2,-1,+1,+2 };
            int[] coldir = {+1,+2,+2,+1,-1,-2,-2,-1 };
            //new cell from current
            for(int dir=0;dir<8;dir++)
            {
                int nextcellrow = r + rowdir[dir];
                int nextcellcol = c + coldir[dir];
                if(canplace(a,nextcellrow,nextcellcol,n))
                {
                    a[nextcellrow, nextcellcol] = movenumber;
                    bool success = knight(a, nextcellrow, nextcellcol, movenumber + 1,n);

                    if(success)
                    {
                        return true;
                    }
                    a[nextcellrow, nextcellcol] = 0;//reset changes made above
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];

            bool success = knight(a, 0, 0, 1,n);//first move
            if(success)
            {
                for(int i=0;i<n;i++)
                {
                    for(int j=0;j<n;j++)
                    {
                        Console.Write(a[i,j]+" ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Sorry");
            }
            Console.ReadKey();
        }
    }
}