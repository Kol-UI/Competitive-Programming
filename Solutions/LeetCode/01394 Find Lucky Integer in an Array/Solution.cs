using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindLuckyIntegerinanArray
{
	public class Solution
    {
        // Given an array of integers arr, a lucky integer is an integer that has a frequency in the array equal to its value.
        // Return the largest lucky integer in the array. If there is no lucky integer return -1.

        // Example 1:

        // Input: arr = [2,2,3,4]
        // Output: 2
        // Explanation: The only lucky number in the array is 2 because frequency[2] == 2.
        
        // Example 2:

        // Input: arr = [1,2,2,3,3,3]
        // Output: 3
        // Explanation: 1, 2 and 3 are all lucky numbers, return the largest of them.
        
        // Example 3:

        // Input: arr = [2,2,2,3,3]
        // Output: -1
        // Explanation: There are no lucky numbers in the array.

        public static int FindLucky(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (var i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    map[arr[i]]++;
                }
                else map.Add(arr[i], 1);
            }
            var lucky = map.Where(x => x.Key == x.Value);

            return lucky.Count() > 0 ? lucky.Max(x=>x.Value) : -1;
        }

    }

    public class Test
    {
        public static bool[] TestFindLuckyIntegerinanArray()
        {
            System.Random random = new System.Random();

            // Case 1
            int[] arrCase1_1394 = { 2, 2, 3, 4 };
            int Case1_1394_Result = Solution.FindLucky(arrCase1_1394);

            // Case 2
            int[] arrCase2_1394 = { 1, 2, 2, 3, 3, 3 };
            int Case2_1394_Result = Solution.FindLucky(arrCase2_1394);

            // Case 3
            int[] arrCase3_1394 = { 2, 2, 2, 3, 3 };
            int Case3_1394_Result = Solution.FindLucky(arrCase3_1394);
            
            // Case 4
            int value1 = random.Next(1, 5);
            int value2 = random.Next(1, 5);
            int value3 = random.Next(1, 5);
            int value4 = random.Next(1, 5);
            int[] arrCase4_1394 = { value1, value2, value3, value4 };
            int Case4_1394_Result = Solution.FindLucky(arrCase4_1394);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_1394_Result, 2),
                ResultTester.CheckResult<int>(Case2_1394_Result, 3),
                ResultTester.CheckResult<int>(Case3_1394_Result, -1),
                ResultTester.CheckResult<int>(Case4_1394_Result, Case4_1394_Result)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Lucky Integer in an Array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestFindLuckyIntegerinanArray());
        }
    }
}