// A - Disjoint Set Union

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.AtCoder.ADisjointSetUnion
{
    // Solution
    /*
    class Program
    {
        static int[]? parent;
        
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int Q = int.Parse(input[1]);

            parent = new int[N];
            for (int i = 0; i < N; i++)
                parent[i] = i;

            for (int i = 0; i < Q; i++)
            {
                string[] query = Console.ReadLine().Split();
                int t = int.Parse(query[0]);
                int u = int.Parse(query[1]);
                int v = int.Parse(query[2]);

                if (t == 0)
                    Union(u, v);
                else
                    Console.WriteLine(Find(u) == Find(v) ? 1 : 0);
            }
        }

        static int Find(int x)
        {
            if (parent![x] != x)
                parent[x] = Find(parent[x]);
            return parent[x];
        }

        static void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX != rootY)
                parent![rootX] = rootY;
        }
    }
    */

    // Test
    public class Solution
    {
        static int[]? parent;

        public static bool DisjointSetUnion(string[] input, int[] expected)
        {
            int currentIndex = 0;

            int N = int.Parse(input[0].Split()[0]);
            int Q = int.Parse(input[0].Split()[1]);

            parent = new int[N];
            for (int i = 0; i < N; i++)
                parent[i] = i;

            for (int i = 1; i <= Q; i++)
            {
                string[] query = input[i].Split();
                int t = int.Parse(query[0]);
                int u = int.Parse(query[1]);
                int v = int.Parse(query[2]);

                if (t == 0)
                    Union(u, v);
                else
                {
                    int result = Find(u) == Find(v) ? 1 : 0;
                    if (result != expected[currentIndex])
                    {
                        Console.WriteLine($"Test case {i} failed. Expected: {expected[currentIndex]}, Actual: {result}");
                        return false;
                    }
                    currentIndex++;
                }
            }

            return true;
        }

        public static int Find(int x)
        {
            if (parent![x] != x)
                parent[x] = Find(parent[x]);
            return parent[x];
        }

        public static void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX != rootY)
                parent![rootX] = rootY;
        }

        
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string[] input =
            {
                "4 7",
                "1 0 1",
                "0 0 1",
                "0 2 3",
                "1 0 1",
                "1 1 2",
                "0 0 2",
                "1 1 3"
            };

            int[] expected = { 0, 1, 0, 1 };

            bool result = Solution.DisjointSetUnion(input, expected);
            bool[] results = new bool[] { result };
            return results;
        }
    }
}