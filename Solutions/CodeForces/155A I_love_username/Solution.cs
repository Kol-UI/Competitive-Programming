// 155A - I_love_\%username\%


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.Iloveusername
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] songs = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            int min = songs[0];
            int max = songs[0];
            int amazingCount = 0;

            for (int i = 1; i < n; i++)
            {
                if (songs[i] < min)
                {
                    min = songs[i];
                    amazingCount++;
                }
                else if (songs[i] > max)
                {
                    max = songs[i];
                    amazingCount++;
                }
            }

            Console.WriteLine(amazingCount);
        }
    }
}