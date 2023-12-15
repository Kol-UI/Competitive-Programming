// George and Accommodation



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.GeorgeandAccommodation
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            int n = int.Parse(Console.ReadLine()!);
            int count = 0;
            const int SpaceGeorgeAndAlex = 2;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                int p = int.Parse(input[0]);
                int q = int.Parse(input[1]);

                if (q - p >= SpaceGeorgeAndAlex)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }

    public class Test
    {
        public static int Solution(int n, int[][] rooms)
        {
            int count = 0;
            const int SpaceGeorgeAndAlex = 2;

            for (int i = 0; i < n; i++)
            {
                int p = rooms[i][0];
                int q = rooms[i][1];

                if (q - p >= SpaceGeorgeAndAlex)
                {
                    count++;
                }
            }

            return count;
        }

        public static bool[] TestCases()
        {
            int[][] testCases1 =
            {
                new int[] {1, 3},
                new int[] {2, 4},
                new int[] {3, 5}
            };

            int[][] testCases2 =
            {
                new int[] {1, 3},
                new int[] {2, 4},
                new int[] {3, 4}
            };

            int[][] testCases3 =
            {
                new int[] {1, 2},
                new int[] {3, 4},
                new int[] {5, 6}
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Test.Solution(testCases1.Length, testCases1), 3),
                ResultTester.CheckResult<int>(Test.Solution(testCases2.Length, testCases2), 2),
                ResultTester.CheckResult<int>(Test.Solution(testCases3.Length, testCases3), 0),
            };
            return results;
        }
    }
}