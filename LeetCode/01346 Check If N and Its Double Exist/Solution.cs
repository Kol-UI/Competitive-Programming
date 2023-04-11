// Check If N and Its Double Exist

using System;
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
}