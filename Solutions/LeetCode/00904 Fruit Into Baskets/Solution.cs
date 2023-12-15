using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FruitIntoBaskets
{
    public class Solution
    {
        // You are visiting a farm that has a single row of fruit trees arranged from left to right. The trees are represented by an integer array fruits where fruits[i] is the type of fruit the ith tree produces.

        // You want to collect as much fruit as possible. However, the owner has some strict rules that you must follow:

        // You only have two baskets, and each basket can only hold a single type of fruit. There is no limit on the amount of fruit each basket can hold.
        // Starting from any tree of your choice, you must pick exactly one fruit from every tree (including the start tree) while moving to the right. The picked fruits must fit in one of your baskets.
        // Once you reach a tree with fruit that cannot fit in your baskets, you must stop.
        // Given the integer array fruits, return the maximum number of fruits you can pick.

        // Example 1:
        // Input: fruits = [1,2,1]
        // Output: 3
        // Explanation: We can pick from all 3 trees.
        
        // Example 2:
        // Input: fruits = [0,1,2,2]
        // Output: 3
        // Explanation: We can pick from trees [1,2,2].
        // If we had started at the first tree, we would only pick from trees [0,1].
        
        // Example 3:
        // Input: fruits = [1,2,3,2,2]
        // Output: 4
        // Explanation: We can pick from trees [2,3,2,2].
        // If we had started at the first tree, we would only pick from trees [1,2].

        public static int TotalFruit(int[] fruits)
        {
            Dictionary<int, int> types = new();
            int result = 0;
            for (int left = 0, right = 0; right < fruits.Length; right++)
            {
                types[fruits[right]] = right;
                
                while (left < right && types.Count > 2)
                {
                    if (types[fruits[left]] == left)
                    {
                        types.Remove(fruits[left]);
                    }
                    left++;                
                }

                result = Math.Max(result, right - left + 1);            
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestFruitIntoBaskets()
        {
            // Case 1
            int[] arrayCase1_904 = { 1, 2, 1 };
            int Case1_904_Result = Solution.TotalFruit(arrayCase1_904);

            // Case 2
            int[] arrayCase2_904 = { 0, 1, 2, 2 };
            int Case2_904_Result = Solution.TotalFruit(arrayCase2_904);

            // Case 3
            int[] arrayCase3_904 = { 1, 2, 3, 2, 2 };
            int Case3_904_Result = Solution.TotalFruit(arrayCase3_904);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_904_Result, 3),
                ResultTester.CheckResult<int>(Case2_904_Result, 3),
                ResultTester.CheckResult<int>(Case3_904_Result, 4)
            };

            return results;
        }
    }
}

