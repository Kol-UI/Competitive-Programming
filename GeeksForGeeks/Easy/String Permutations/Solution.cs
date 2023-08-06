// String Permutations

/*
Given a string S. The task is to find all permutations (need not be different) of a given string.

Example 1:

Input:
S = AAA
Output: AAA AAA AAA AAA AAA AAA
Explanation: There are total 6 permutations, as given in the output.
Example 2:

Input:
S = ABSG
Output: ABGS ABSG AGBS AGSB ASBG ASGB
BAGS BASG BGAS BGSA BSAG BSGA GABS
GASB GBAS GBSA GSAB GSBA SABG SAGB
SBAG SBGA SGAB SGBA
Explanation: There are total 24 permutations, as given in the output.
Your Task:
This is a function problem. You only need to complete the function permutation that takes S as parameter and returns the list of permutations in lexicographically increasing order. The newline is automatically added by driver code.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Easy.StringPermutations
{
    public class Solution
    {
        public static List<string> Permutation(string S)
        {
            List<string> result = new();
            GeneratePermutations(S.ToCharArray(), 0, result);
            result.Sort();
            return result;
        }

        private static void GeneratePermutations(char[] arr, int index, List<string> result)
        {
            if (index == arr.Length - 1)
            {
                result.Add(new string(arr));
                return;
            }
            for (int i = index; i < arr.Length; i++)
            {
                Swap(arr, index, i);
                GeneratePermutations(arr, index + 1, result);
                Swap(arr, index, i);
            }
        }

        private static void Swap(char[] arr, int i, int j)
        {
            (arr[j], arr[i]) = (arr[i], arr[j]);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            List<string> list1 = new()
            {
                "AAA", "AAA", "AAA", "AAA", "AAA", "AAA"
            };

            List<string> list2 = new()
            {
                "ABGS", "ABSG", "AGBS", "AGSB", "ASBG", "ASGB",
                "BAGS", "BASG", "BGAS", "BGSA", "BSAG", "BSGA",
                "GABS", "GASB", "GBAS", "GBSA", "GSAB", "GSBA",
                "SABG", "SAGB", "SBAG", "SBGA", "SGAB", "SGBA"
            };
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<List<string>>(Solution.Permutation("AAA"), list1),
                ResultTester.CheckResult<List<string>>(Solution.Permutation("ABSG"), list2),
            };
            return results;
        }
    }
}