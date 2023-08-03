using System;
using System.Linq;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.FindMaximumandMinimumValuesofaList
{
	public class Solution
	{
        public static int Min(int[] list)
        {
            return list.Min();
        }

        public static int Max(int[] list)
        {
            return list.Max();
        }
    }

    public class Test
    {
        public static bool[] TestFindMaximumandMinimumValuesofaList()
        {
            System.Random random = new System.Random();

            // Case 1
            int[] Case1 = { 1, -4, 7, 12};
            int minCase1 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case1);
            int maxCase1 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case1);

            // Case 2
            int[] Case2 = { 26, 7, 7, 8, 7, 30};
            int minCase2 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case2);
            int maxCase2 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case2);

            // Case 3
            int[] Case3 = { -2, -6, -17, -3, -8, -9, -10};
            int minCase3 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case3);
            int maxCase3 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case3);

            // Case 4
            int value1 = random.Next();
            int value2 = random.Next();
            int value3 = random.Next();
            int value4 = random.Next();
            int value5 = random.Next();
            int[] Case4 = { value1, value2, value3, value4, value5 };
            int minCase4 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case4);
            int maxCase4 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case4);

            // Case 5
            int value6 = random.Next(-100, -1);
            int value7 = random.Next(-100, -1);
            int value8 = random.Next(-100, -1);
            int value9 = random.Next(-100, -1);
            int value10 = random.Next(-100, -1);
            int[] Case5 = { value6, value7, value8, value9, value10 };
            int minCase5 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case5);
            int maxCase5 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case5);

            // Case 6
            int[] Case6 = { 1, 2, 3, 4, 5 };
            int minCase6 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case6);
            int maxCase6 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case6);

            // Case 7
            int[] Case7 = { 6, 7, 8, 9, 0 };
            int minCase7 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case7);
            int maxCase7 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case7);
            
            // Case 8
            int[] Case8 = Case1.Union(Case2).Union(Case3).Union(Case4).Union(Case5).Union(Case6).Union(Case7).ToArray();
            int minCase8 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case8);
            int maxCase8 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case8);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(minCase1, minCase1),
                ResultTester.CheckResult<int>(minCase2, minCase2),
                ResultTester.CheckResult<int>(minCase3, minCase3),
                ResultTester.CheckResult<int>(minCase4, minCase4),
                ResultTester.CheckResult<int>(minCase5, minCase5),
                ResultTester.CheckResult<int>(minCase6, minCase6),
                ResultTester.CheckResult<int>(minCase7, minCase7),
                ResultTester.CheckResult<int>(minCase8, minCase8),
                ResultTester.CheckResult<int>(maxCase1, maxCase1),
                ResultTester.CheckResult<int>(maxCase2, maxCase2),
                ResultTester.CheckResult<int>(maxCase3, maxCase3),
                ResultTester.CheckResult<int>(maxCase4, maxCase4),
                ResultTester.CheckResult<int>(maxCase5, maxCase5),
                ResultTester.CheckResult<int>(maxCase6, maxCase6),
                ResultTester.CheckResult<int>(maxCase7, maxCase7),
                ResultTester.CheckResult<int>(maxCase8, maxCase8),
            };
            return results;
        }
    }
}

