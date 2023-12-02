// Hit the Lottery



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.HittheLottery
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            int n = int.Parse(Console.ReadLine()!);

            int[] bills = new int[] { 100, 20, 10, 5, 1 };
            int count = 0;

            foreach (int bill in bills)
            {
                count += n / bill;
                n %= bill;
            }

            Console.WriteLine(count);
        }
    }
}