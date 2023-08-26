// L - Lazy Segment Tree

using System;
using System.Linq;

namespace CompetitiveProgramming.atcoder.LazySegmentTree
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int Q = int.Parse(input[1]);

            int[] A = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int[] inversions = new int[N];

            for (int i = 1; i < N; i++)
            {
                inversions[i] = inversions[i - 1] + A[i - 1];
            }

            for (int i = 0; i < Q; i++)
            {
                string[] query = Console.ReadLine()!.Split();
                int T = int.Parse(query[0]);
                int L = int.Parse(query[1]);
                int R = int.Parse(query[2]);

                if (T == 1)
                {
                    for (int j = L - 1; j < R; j++)
                    {
                        A[j] = 1 - A[j];
                    }
                }
                else
                {
                    int inversionCount = inversions[R - 1] - (L > 1 ? inversions[L - 2] : 0);
                    int totalCount = R - L + 1;
                    int answer = totalCount - 2 * inversionCount;
                    Console.WriteLine(answer);
                }
            }
        }
    }
}
