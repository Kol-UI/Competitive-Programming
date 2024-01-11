// Problemsolving Log

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.ProblemsolvingLog
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
                string s = Console.ReadLine()!;

                int solvedProblems = CountSolvedProblems(n, s);
                Console.WriteLine(solvedProblems);
            }
        }

        static int CountSolvedProblems(int n, string s)
        {
            int[] cnt = new int[26];

            for (int i = 0; i < n; i++)
            {
                cnt[s[i] - 'A']++;
            }

            int ct = 0;

            for (int i = 0; i < cnt.Length; i++)
            {
                if (cnt[i] >= i + 1)
                    ct++;
            }

            return ct;
        }
    }
}