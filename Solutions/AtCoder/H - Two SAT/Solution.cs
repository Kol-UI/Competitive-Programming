// H - Two SAT
using System;
using System.Collections.Generic;
namespace CompetitiveProgramming.AtCoder.TwoSAT;
class Program
{
    //static void Main(string[] args)
    static void Solution()
    {
        string[] nd = Console.ReadLine()!.Split();
        int N = int.Parse(nd[0]);
        int D = int.Parse(nd[1]);

        List<int> coordinates = new();
        bool possible = true;

        for (int i = 0; i < N; i++)
        {
            string[] xy = Console.ReadLine()!.Split();
            int X = int.Parse(xy[0]);
            int Y = int.Parse(xy[1]);

            if (X + D <= Y)
            {
                coordinates.Add(Y);
            }
            else if (X - D >= coordinates[coordinates.Count - 1])
            {
                coordinates.Add(X);
            }
            else
            {
                possible = false;
                break;
            }
        }

        if (possible)
        {
            Console.WriteLine("Yes");
            foreach (int coord in coordinates)
            {
                Console.WriteLine(coord);
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
