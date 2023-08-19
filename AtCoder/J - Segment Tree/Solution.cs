// J - Segment Tree

namespace CompetitiveProgramming.AtCoder.SegmentTree;
using System;
using System.Collections.Generic;

class Program
{
    //static void Main(string[] args)
    static void Solution()
    {
        string[] input = Console.ReadLine()!.Split();
        int N = int.Parse(input[0]);
        int Q = int.Parse(input[1]);

        string[] aValues = Console.ReadLine()!.Split();
        int[] A = new int[N];
        for (int i = 0; i < N; i++)
        {
            A[i] = int.Parse(aValues[i]);
        }

        List<int> results = new();

        for (int q = 0; q < Q; q++)
        {
            string[] query = Console.ReadLine()!.Split();
            int type = int.Parse(query[0]);

            if (type == 2 || type == 3)
            {
                int L = int.Parse(query[1]) - 1;
                int R = int.Parse(query[2]) - 1;

                if (type == 2)
                {
                    int max = int.MinValue;
                    for (int i = L; i <= R; i++)
                    {
                        max = Math.Max(max, A[i]);
                    }
                    results.Add(max);
                }
                else if (type == 3)
                {
                    int X = int.Parse(query[1]) - 1;
                    int V = int.Parse(query[2]);
                    int j = N + 1;
                    for (int i = X; i < N; i++)
                    {
                        if (A[i] >= V)
                        {
                            j = i + 1;
                            break;
                        }
                    }
                    results.Add(j);
                }
            }
            else if (type == 1)
            {
                int X = int.Parse(query[1]) - 1;
                int V = int.Parse(query[2]);
                A[X] = V;
            }
        }

        foreach (int result in results)
        {
            Console.WriteLine(result);
        }
    }
}
