// Arrival of the General

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.ArrivaloftheGeneral
{
    public class Program
    {
        //public static void Main(string[] args)
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine()!);
            string[] soldiers = Console.ReadLine()!.Split();

            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 0; i < n; i++)
            {
                int height = int.Parse(soldiers[i]);

                if (int.Parse(soldiers[i]) > int.Parse(soldiers[maxIndex]))
                {
                    maxIndex = i;
                }

                if (int.Parse(soldiers[i]) <= int.Parse(soldiers[minIndex]))
                {
                    minIndex = i;
                }
            }

            int moves = maxIndex + (n - 1 - minIndex);
            
            if (maxIndex > minIndex)
            {
                moves--;
            }

            Console.WriteLine(moves);
        }
    }
}