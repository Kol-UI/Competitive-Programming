// Distribute Candies

/*
Alice has n candies, where the ith candy is of type candyType[i]. Alice noticed that she started to gain weight, so she visited a doctor.

The doctor advised Alice to only eat n / 2 of the candies she has (n is always even). Alice likes her candies very much, and she wants to eat the maximum number of different types of candies while still following the doctor's advice.

Given the integer array candyType of length n, return the maximum number of different types of candies she can eat if she only eats n / 2 of them.

 

Example 1:

Input: candyType = [1,1,2,2,3,3]
Output: 3
Explanation: Alice can only eat 6 / 2 = 3 candies. Since there are only 3 types, she can eat one of each type.

Example 2:

Input: candyType = [1,1,2,3]
Output: 2
Explanation: Alice can only eat 4 / 2 = 2 candies. Whether she eats types [1,2], [1,3], or [2,3], she still can only eat 2 different types.

Example 3:

Input: candyType = [6,6,6,6]
Output: 1
Explanation: Alice can only eat 4 / 2 = 2 candies. Even though she can eat 2 candies, she only has 1 type.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DistributeCandies
{
    public class Solution
    {
        public static int DistributeCandies(int[] candyType) 
        {
            int max = candyType.Length / 2;
            HashSet<int> hashSet = new();
            int n = 0;

            for (int i = 0; i < candyType.Length; i++)
            {
                if (hashSet.Contains(candyType[i])) 
                {
                    continue;
                }

                n++;

                if (n >= max)
                {
                    break;
                }

                hashSet.Add(candyType[i]);
            }

            return n;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] candyType1 = {1,1,2,2,3,3};
            int[] candyType2 = {1,1,2,3};
            int[] candyType3 = {6,6,6,6};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.DistributeCandies(candyType1), 3),
                ResultTester.CheckResult<int>(Solution.DistributeCandies(candyType2), 2),
                ResultTester.CheckResult<int>(Solution.DistributeCandies(candyType3), 1),
            };
            return results;
        }
    }
}