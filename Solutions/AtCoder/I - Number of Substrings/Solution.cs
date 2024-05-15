// I - Number of Substrings

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.AtCoder.NumberofSubstrings;

class Program
{
    //static void Main(string[] args)
    static void Solution()
    {
        string S = Console.ReadLine()!;
        int N = S.Length;

        long result = 0;
        long[] power = new long[N];

        power[0] = 1;
        for (int i = 1; i < N; i++)
        {
            power[i] = (power[i - 1] * 26) % 1000000007;
        }

        long[] hash = new long[N];
        hash[0] = S[0] - 'a';

        for (int i = 1; i < N; i++)
        {
            hash[i] = (hash[i - 1] * 26 + (S[i] - 'a')) % 1000000007;
        }

        for (int len = 1; len <= N; len++)
        {
            long currentHash = hash[len - 1];
            for (int i = len; i < N; i++)
            {
                long prevHash = hash[i - len];
                long subHash = (hash[i] + 1000000007 - (prevHash * power[len]) % 1000000007) % 1000000007;
                if (subHash == currentHash)
                {
                    result++;
                }
            }
        }

        Console.WriteLine(result + N);
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Substrings");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder, ProblemCategory.BeginnerAC);
        }
    }
}