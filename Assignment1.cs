using System;


namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("ENTER SIZE");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER CHARACTERS A or P");
            char[,] room = new char[n, n];
            int plus = 0, cross = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    room[i, j] = Convert.ToChar(Console.ReadLine().ToUpper());

                }
            }
            if (n > 2)
            {
                for (int i = 1; i < n - 1; i++)
                {
                    for (int j = 1; j < n - 1; j++)
                    {
                        if (checkplus(room, i, j) == true)
                        {
                            plus++;
                            Console.WriteLine("PLUS AT " + seatno(n, i, j) + "," + seatno(n, i - 1, j) + "," + seatno(n, i + 1, j) + "," + seatno(n, i, j + 1) + "," + seatno(n, i, j - 1));

                        }
                        if (checkcross(room, i, j) == true)
                        {
                            cross++;
                            Console.WriteLine("CROSS AT " + seatno(n, i, j) + "," + seatno(n, i - 1, j - 1) + "," + seatno(n, i - 1, j + 1) + "," + seatno(n, i + 1, j + 1) + "," + seatno(n, i + 1, j - 1));
                        }

                    }
                }
                Console.WriteLine("number of plus " + plus);
                Console.WriteLine("number of cross " + cross);
                
            }
            else
                Console.WriteLine("NO CROSS OR PLUS CAN BE FORMED");
            Console.ReadKey();
        }
        static int seatno(int n,int i,int j)
        {
            return (n*i) + (j + 1);
        }
        static bool checkplus(char [,]room,int i,int j)
        {
            if (room[i, j] == 'A' && room[i - 1, j] == 'A' && room[i + 1, j] == 'A' && room[i, j - 1] == 'A' && room[i, j + 1] == 'A')
                return true;
            else
                return false;
        }
        static bool checkcross(char[,] room, int  i, int j)
        {
            if (room[i, j] == 'A' && room[i - 1, j-1] == 'A' && room[i - 1, j+1] == 'A' && room[i+1, j - 1] == 'A' && room[i+1, j + 1] == 'A')
                return true;
            else
                return false;
        }
    }
}
