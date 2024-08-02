// Sort the People



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SortthePeople
{
    public class Solution
    {
        public static string[] SortPeople(string[] names, int[] heights)
        {
            Array.Sort(heights, names);
            Array.Reverse(names);
            return names;
        }

        public static string[] SortPeople2(string[] names, int[] heights)
        {
            string[] namesSorted = new string[names.Length];

            Dictionary<int, string> dictionaryNames = new Dictionary<int, string>();

            for (int i = 0; i < heights.Length; i++)
            {
                dictionaryNames.Add(heights[i], names[i]);
            }

            Array.Sort(heights);

            int laps = 0;

            for (int i = heights.Length - 1; i >= 0 ; i--)
            {
                namesSorted[laps] = dictionaryNames[heights[i]];
                laps++;
            }

            return namesSorted;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string[] names1 = {"Mary","John","Emma"};
            int[] heights1 = {180,165,170};

            string[] names2 = {"Alice","Bob","Bob"};
            int[] heights2 = {155,185,150};

            string[] expected1 = {"Mary","Emma","John"};
            string[] expected1_2 = {"John","Emma","Mary"};
            string[] expected2 = {"Bob","Alice","Bob"};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string[]>(Solution.SortPeople(names1, heights1), expected1),
                ResultTester.CheckResult<string[]>(Solution.SortPeople(names2, heights2), expected2),
                ResultTester.CheckResult<string[]>(Solution.SortPeople2(names1, heights1), expected1_2),
                ResultTester.CheckResult<string[]>(Solution.SortPeople2(names2, heights2), expected2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort the People");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}