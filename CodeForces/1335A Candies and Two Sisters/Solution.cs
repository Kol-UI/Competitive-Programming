// 1335A - Candies and Two Sisters



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.CandiesandTwoSisters
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            int t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine()!);
                int result = (n - 1) / 2;
                Console.WriteLine(result);
            }
        }
    }

}