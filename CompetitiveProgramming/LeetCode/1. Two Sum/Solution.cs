using System;
namespace CompetitiveProgramming.LeetCode.TwoSum
{
	public class Solution
	{
        public int[] TwoSum(int[] nums, int target)
        {
            int[] temp = new int[2];
            if (nums == null || nums.Length < 2)
            {
                return new int[2];
            }
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        temp[0] = i;
                        temp[1] = j;
                        break;
                    }
                }
            }
            return temp;
        }

        // Best
        public int[] TwoSumDic(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
            {
                return new int[2];
            }
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, dic[target - nums[i]] };
                }
                else if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }

            return new int[2];
        }

        public int[]? TwoSumRetry(int[] nums, int target)
        {
            for (int i = nums.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (nums[i] + nums[i - j] == target && i != i - j)
                    {
                        nums = new int[2];
                        nums[0] = i - j;
                        nums[1] = i;
                        return nums;
                    }
                }
            }
            return null;
        }
    }
}

