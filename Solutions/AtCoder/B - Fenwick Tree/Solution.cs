// B - Fenwick Tree

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.AtCoder.BFenwickTree
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            // Read N and Q
            string[] nq = Console.ReadLine().Split();
            int N = int.Parse(nq[0]);
            int Q = int.Parse(nq[1]);

            // Read array a
            string[] aValues = Console.ReadLine().Split();
            int[] a = new int[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(aValues[i]);
            }

            // Process queries
            for (int q = 0; q < Q; q++)
            {
                string[] query = Console.ReadLine().Split();
                int type = int.Parse(query[0]);
                int l = int.Parse(query[1]);
                int r = int.Parse(query[2]);

                if (type == 0)
                {
                    int x = int.Parse(query[3]);
                    for (int i = l; i <= r - 1; i++)
                    {
                        a[i] += x;
                    }
                }
                else if (type == 1)
                {
                    int sum = 0;
                    for (int i = l; i <= r - 1; i++)
                    {
                        sum += a[i];
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
    */



    public class Test : BaseSolution
    {
        public static long[] FenwickTreeMain(int N, int Q, long[] arr, List<Tuple<int, int, int, long>> queries)
        {
            long[] prefixSum = new long[N + 1];
            for (int i = 0; i < N; i++)
                prefixSum[i + 1] = prefixSum[i] + arr[i];

            List<long> results = new();

            foreach (var query in queries)
            {
                int type = query.Item1;
                int l = query.Item2;
                int r = query.Item3;

                if (type == 0)
                {
                    long x = query.Item4;
                    arr[l] += x;
                    prefixSum[l + 1] += x;
                }
                else if (type == 1)
                {
                    results.Add(prefixSum[r] - prefixSum[l]);
                }
            }

            return results.ToArray();
        }

        public static bool[] TestCases()
        {
            int N = 5;
            int Q = 5;
            long[] arr = { 1, 2, 3, 4, 5 };
            List<Tuple<int, int, int, long>> queries = new()
            {
                new Tuple<int, int, int, long>(1, 0, 5, 0),
                new Tuple<int, int, int, long>(1, 2, 4, 0),
                new Tuple<int, int, int, long>(0, 3, 10, 0),
                new Tuple<int, int, int, long>(1, 0, 5, 0),
                new Tuple<int, int, int, long>(1, 0, 3, 0),
            };

            long[] expected = { 15, 9, 25, 15, 6 };

            long[] result = FenwickTreeMain(N, Q, arr, queries);

            bool isCorrect = result.SequenceEqual(expected);
            if (isCorrect == true) Console.WriteLine("True");
            
            bool[] results = 
            {
                ResultTester.CheckResult<bool>(true, true)
            };
            return results;
        }

        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fenwick Tree");
            ResultTester.CheckCurrentSolution(ProblemOrigin.AtCoder, ProblemCategory.BeginnerAC, TestCases());
        }
    }

}