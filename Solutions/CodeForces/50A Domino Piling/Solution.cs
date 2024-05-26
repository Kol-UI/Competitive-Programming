// 50A Domino Piling

/*
You are given a rectangular board of M × N squares. Also you are given an unlimited number of standard domino pieces of 2 × 1 squares. You are allowed to rotate the pieces. You are asked to place as many dominoes as possible on the board so as to meet the following conditions:

1. Each domino completely covers two squares.

2. No two dominoes overlap.

3. Each domino lies entirely inside the board. It is allowed to touch the edges of the board.

Find the maximum number of dominoes, which can be placed under these restrictions.

Input
In a single line you are given two integers M and N — board sizes in squares (1 ≤ M ≤ N ≤ 16).

Output
Output one number — the maximal number of dominoes, which can be placed.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.DominoPiling;
    // Solution
    /*
    public static void Main()
    {
        string[] dimensions = Console.ReadLine().Split();
        int M = int.Parse(dimensions[0]);
        int N = int.Parse(dimensions[1]);

        int maxDominoes = (M * N) / 2;
        Console.WriteLine(maxDominoes);
    }
    */

    // Test
    public class Test
    {
        public static int TestDominoPiling(string[] dimensions)
        {
            string[] parts = dimensions[0].Split();
            int M = int.Parse(parts[0]);
            int N = int.Parse(parts[1]);

            int maxDominoes = (M * N) / 2;
            return maxDominoes;
        }

        public static bool[] TestCases()
        {
            string[] case1 = new string[] { "2 4", };
            string[] case2 = new string[] { "3 3", };
            string[] case3 = new string[] { "1 5", };
            string[] case4 = new string[] { "1 6", };
            string[] case5 = new string[] { "14 15", };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Test.TestDominoPiling(case1), 4),
                ResultTester.CheckResult<int>(Test.TestDominoPiling(case2), 4),
                ResultTester.CheckResult<int>(Test.TestDominoPiling(case3), 2),
                ResultTester.CheckResult<int>(Test.TestDominoPiling(case4), 3),
                ResultTester.CheckResult<int>(Test.TestDominoPiling(case5), 105),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Domino Piling");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeForces, ProblemCategory.CF800, Test.TestCases());
        }
    }