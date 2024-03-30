// Marathon

namespace CompetitiveProgramming.CodeForces.Marathon
{
    using System;

    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            long t = long.Parse(Console.ReadLine()!);
            while (t-- > 0)
            {
                string[] input = Console.ReadLine()!.Split();
                long a = long.Parse(input[0]);
                long b = long.Parse(input[1]);
                long c = long.Parse(input[2]);
                long d = long.Parse(input[3]);

                Console.WriteLine((b > a ? 1 : 0) + (c > a ? 1 : 0) + (d > a ? 1 : 0));
            }
        }
    }
}