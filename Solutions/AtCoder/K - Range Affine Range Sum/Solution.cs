// K - Range Affine Range Sum

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.AtCoder.RangeAffineRangeSum
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int Q = int.Parse(input[1]);

            int[] a = new int[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine()!);
            }

            long[] sum = new long[N + 1];
            for (int i = 0; i < N; i++)
            {
                sum[i + 1] = (sum[i] + a[i]) % 998244353;
            }

            for (int i = 0; i < Q; i++)
            {
                string[] query = Console.ReadLine()!.Split();
                int type = int.Parse(query[0]);

                if (type == 1)
                {
                    int l = int.Parse(query[1]);
                    int r = int.Parse(query[2]);
                    long answer = (sum[r] - sum[l] + 998244353) % 998244353;
                    Console.WriteLine(answer);
                }
                else
                {
                    int l = int.Parse(query[1]);
                    int r = int.Parse(query[2]);
                    int b = int.Parse(query[3]);
                    int c = int.Parse(query[4]);
                    for (int j = l; j < r; j++)
                    {
                        a[j] = (int)(((long)b * a[j] + c) % 998244353);
                    }
                    sum[l + 1] = (sum[l + 1] + a[l]) % 998244353;
                    for (int j = l + 2; j <= r; j++)
                    {
                        sum[j] = (sum[j] + (long)a[j - 1]) % 998244353;
                    }
                }
            }
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Range Affine Range Sum");
            ResultTester.SpecialTestCase(ProblemOrigin.AtCoder, ProblemCategory.BeginnerAC);
        }
    }
}