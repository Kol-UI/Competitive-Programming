using System;
namespace CompetitiveProgramming.LeetCode.PrimeSubtractionOperation
{
    /*
        You are given a 0-indexed integer array nums of length n.
        You can perform the following operation as many times as you want:
        Pick an index i that you haven’t picked before, and pick a prime p strictly less than nums[i], then subtract p from nums[i].
        Return true if you can make nums a strictly increasing array using the above operation and false otherwise.
        A strictly increasing array is an array whose each element is strictly greater than its preceding element.

        Example 1:
        Input: nums = [4,9,6,10]
        Output: true
        Explanation: In the first operation: Pick i = 0 and p = 3, and then subtract 3 from nums[0], so that nums becomes [1,9,6,10].
        In the second operation: i = 1, p = 7, subtract 7 from nums[1], so nums becomes equal to [1,2,6,10].
        After the second operation, nums is sorted in strictly increasing order, so the answer is true.
        
        Example 2:
        Input: nums = [6,8,11,12]
        Output: true
        Explanation: Initially nums is sorted in strictly increasing order, so we don't need to make any operations.
        
        Example 3:
        Input: nums = [5,8,3]
        Output: false
        Explanation: It can be proven that there is no way to perform operations to make nums sorted in strictly increasing order, so the answer is false.
    */
    public class Solution
    {
        private static bool IsPrime(int value)
        {
            if (value <= 1)
            {
                return false;
            }

            if (value % 2 == 0)
            {
                return value == 2;
            }

            int sqrt = (int)(Math.Sqrt(value) + 0.1);

            for (int d = 3; d <= sqrt; d += 2)
            {
                if (value % d == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool PrimeSubOperation(int[] nums)
        {
            if (nums[0] >= 3)
            {
                for (int p = nums[0] - 1; p >= 2; --p)
                {
                    if (IsPrime(p))
                    {
                        nums[0] -= p;
                        break;
                    } 
                }  
            }
                
            
            for (int i = 1; i < nums.Length; ++i)
            {
                if (nums[i] <= nums[i - 1])
                {
                    return false;
                }
                else 
                {
                    for (int sub = nums[i] - nums[i - 1] - 1; sub >= 2; --sub)
                    {
                        if (IsPrime(sub))
                        {
                            nums[i] -= sub;
                            break;
                        }
                    }
                }       
            }
            
            return true;         
        }
    }
}

