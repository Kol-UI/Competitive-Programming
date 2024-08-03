// Minimum Amount of Time to Collect Garbage

/*
You are given a 0-indexed array of strings garbage where garbage[i] represents the assortment of garbage at the ith house. garbage[i] consists only of the characters 'M', 'P' and 'G' representing one unit of metal, paper and glass garbage respectively. Picking up one unit of any type of garbage takes 1 minute.

You are also given a 0-indexed integer array travel where travel[i] is the number of minutes needed to go from house i to house i + 1.

There are three garbage trucks in the city, each responsible for picking up one type of garbage. Each garbage truck starts at house 0 and must visit each house in order; however, they do not need to visit every house.

Only one garbage truck may be used at any given moment. While one truck is driving or picking up garbage, the other two trucks cannot do anything.

Return the minimum number of minutes needed to pick up all the garbage.

 

Example 1:

Input: garbage = ["G","P","GP","GG"], travel = [2,4,3]
Output: 21
Explanation:
The paper garbage truck:
1. Travels from house 0 to house 1
2. Collects the paper garbage at house 1
3. Travels from house 1 to house 2
4. Collects the paper garbage at house 2
Altogether, it takes 8 minutes to pick up all the paper garbage.
The glass garbage truck:
1. Collects the glass garbage at house 0
2. Travels from house 0 to house 1
3. Travels from house 1 to house 2
4. Collects the glass garbage at house 2
5. Travels from house 2 to house 3
6. Collects the glass garbage at house 3
Altogether, it takes 13 minutes to pick up all the glass garbage.
Since there is no metal garbage, we do not need to consider the metal garbage truck.
Therefore, it takes a total of 8 + 13 = 21 minutes to collect all the garbage.

Example 2:

Input: garbage = ["MMM","PGM","GP"], travel = [3,10]
Output: 37
Explanation:
The metal garbage truck takes 7 minutes to pick up all the metal garbage.
The paper garbage truck takes 15 minutes to pick up all the paper garbage.
The glass garbage truck takes 15 minutes to pick up all the glass garbage.
It takes a total of 7 + 15 + 15 = 37 minutes to collect all the garbage.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumAmountofTimetoCollectGarbage
{
    public class Solution
    {
        public static int GarbageCollection(string[] garbage, int[] travel)
        {
            int[] distances = new int[garbage.Length];
            int distanceDone = 0;

            Dictionary<char, int[]> dictionary = new Dictionary<char, int[]>()
            {
                { 'M', new int[2] },
                { 'G', new int[2] },
                { 'P', new int[2] }
            };

            for(int i = 0; i < garbage.Length; i++)
            {
                distances[i] = distanceDone;
                foreach(char c in garbage[i])
                {
                    dictionary[c][0]++;
                    dictionary[c][1] = i;
                }

                if(i < travel.Length)
                {
                    distanceDone += travel[i];
                }
            }

            int result = 0;

            foreach(char c in dictionary.Keys)
            {
                result += dictionary[c][0];
                result += distances[dictionary[c][1]];
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string[] garbage1 = {"G","P","GP","GG"}; 
            int[] travel1 = {2,4,3};
            string[] garbage2 = {"MMM","PGM","GP"};
            int[] travel2 = {3,10};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.GarbageCollection(garbage1, travel1), 21),
                ResultTester.CheckResult<int>(Solution.GarbageCollection(garbage2, travel2), 37),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimum Amount of Time to Collect Garbage");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}