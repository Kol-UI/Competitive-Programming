// Check If N and Its Double Exist

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CheckIfNandItsDoubleExist
{
    /*
        Given an array arr of integers, check if there exist two indices i and j such that :

        i != j
        0 <= i, j < arr.length
        arr[i] == 2 * arr[j]
        

        Example 1:
        Input: arr = [10,2,5,3]
        Output: true
        Explanation: For i = 0 and j = 2, arr[i] == 10 == 2 * 5 == 2 * arr[j]
        
        Example 2:
        Input: arr = [3,1,7,11]
        Output: false
        Explanation: There is no i and j that satisfy the conditions.
    */
    public class Solution
    {
        public static bool CheckIfExist(int[] arr)
        {
            var hashSet = new HashSet<int>();
            foreach (var n in arr)
            {
                if (hashSet.Contains(n * 2) || ( (n % 2) == 0 && hashSet.Contains(n / 2)))
                {
                    return true;
                }
                hashSet.Add(n);
            }
            return false;
        }
    }

    public class Test
    {
        public static bool[] TestCheckIfNandItsDoubleExist()
        {
            // Case 1
            int[] arr2346_1 = {10,2,5,3};
            bool result2346_1 = Solution.CheckIfExist(arr2346_1);
            
            // Case 2
            int[] arr2346_2 = {3,1,7,11};
            bool result2346_2 = Solution.CheckIfExist(arr2346_2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result2346_1, true),
                ResultTester.CheckResult<bool>(result2346_2, false)
            };
            return results;
        }
    }
}