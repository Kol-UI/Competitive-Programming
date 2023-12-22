// Sum of Round Numbers



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.SumofRoundNumbers
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            int t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine()!);
                List<int> roundNumbers = new List<int>();
                int div = 1;

                while (n > 0)
                {
                    int digit = n % 10;
                    if (digit != 0)
                    {
                        roundNumbers.Add(digit * div);
                    }
                    n /= 10;
                    div *= 10;
                }

                Console.WriteLine(roundNumbers.Count);
                Console.WriteLine(string.Join(" ", roundNumbers));
            }
        }
    }
}