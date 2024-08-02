using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SuccessfulPairsofSpellsandPotions
{
    // Successful Pairs of Spells and Potions
    /*
        You are given two positive integer arrays spells and potions, of length n and m respectively, where spells[i] represents the strength of the ith spell and potions[j] represents the strength of the jth potion.
        You are also given an integer success. A spell and potion pair is considered successful if the product of their strengths is at least success.
        Return an integer array pairs of length n where pairs[i] is the number of potions that will form a successful pair with the ith spell.

        Example 1:
        Input: spells = [5,1,3], potions = [1,2,3,4,5], success = 7
        Output: [4,0,3]
        Explanation:
        - 0th spell: 5 * [1,2,3,4,5] = [5,10,15,20,25]. 4 pairs are successful.
        - 1st spell: 1 * [1,2,3,4,5] = [1,2,3,4,5]. 0 pairs are successful.
        - 2nd spell: 3 * [1,2,3,4,5] = [3,6,9,12,15]. 3 pairs are successful.
        Thus, [4,0,3] is returned.
        
        Example 2:
        Input: spells = [3,1,2], potions = [8,5,8], success = 16
        Output: [2,0,2]
        Explanation:
        - 0th spell: 3 * [8,5,8] = [24,15,24]. 2 pairs are successful.
        - 1st spell: 1 * [8,5,8] = [8,5,8]. 0 pairs are successful. 
        - 2nd spell: 2 * [8,5,8] = [16,10,16]. 2 pairs are successful. 
        Thus, [2,0,2] is returned.
    */

    public class Solution
    {
        // Binary Search
        public static int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            Array.Sort(potions);
            var result = new List<int>();
            for(int i = 0; i < spells.Length; i++)
            {
                int start = 0;
                int end = potions.Length - 1;
                while(start <= end)
                {
                    int mid = start + (end - start)/2;
                    long currStrength = (long)potions[mid]* (long)spells[i];
                    if( currStrength >= success)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                result.Add(potions.Length - start);
            }
            return result.ToArray();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int[] spells2300_1 = {5,1,3};
            int[] potions2300_1 = {1,2,3,4,5};
            long success2300_1 = 7;
            int[] result2300_1 = Solution.SuccessfulPairs(spells2300_1, potions2300_1, success2300_1);

            // Case 2
            int[] spells2300_2 = {3,1,2};
            int[] potions2300_2 = {8,5,8};
            long success2300_2 = 16;
            int[] result2300_2 = Solution.SuccessfulPairs(spells2300_2, potions2300_2, success2300_2);

            int[] output1_2300 = {4,0,3};
            int[] output2_2300 = {2,0,2};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result2300_1, output1_2300),
                ResultTester.CheckResult<int[]>(result2300_2, output2_2300)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Successful Pairs of Spells and Potions");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}