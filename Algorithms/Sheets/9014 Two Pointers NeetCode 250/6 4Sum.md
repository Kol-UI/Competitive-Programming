4Sum :

You are given an integer array nums of size n, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:

0 <= a, b, c, d < n

a, b, c, and d are distinct.

nums[a] + nums[b] + nums[c] + nums[d] == target

You may return the answer in any order.

Note: [1,0,3,2] and [3,0,1,2] are considered as same quadruplets.


Example 1:

Input: nums = [3,2,3,-3,1,0], target = 3

Output: [[-3,0,3,3],[-3,1,2,3]]


Example 2:

Input: nums = [1,-1,1,-1,1,-1], target = 2

Output: [[-1,1,1,1]]



```cs
// Two Pointers
public class TwoPointers4Sum()
{
    public List<List<int>> FourSum(int[] nums, int target)
    {
        // Step 1 Sort
        Array.Sort(nums);
        int len = nums.Length;
        var result = new List<List<int>>();

        // Step 2 Loop & Manage Duplicates
        for (int a = 0; a < len - 3; a++)
        {
            // Manage duplicates
            // If i > 0 (is not the first element) and
            // the current element is identical to the previous element,
            // we skip to the next iteration, this avoids redundant quadruplets
            if (a > 0 && nums[a] == nums[a - 1]) continue;
            // a + 1 because b > a
            for (int b = a + 1; b < len - 2; b++)
            {
                // Manage duplicates
                if (b > a + 1 && nums[b] == nums[b - 1]) continue;

                // last 2 numbers are found with pointers
                // 'left' & 'right' starts at b + 1 et len - 1.
                // it ensure a < b < c < d

                // Step 3 Two Pointers
                long requiredSum = (long)target - nums[a] - nums[b];
                int c = b + 1; // left
                int d = len - 1; // right

                while (c < d)
                {
                    long currentPairSum = (long)nums[c] + nums[d];
                    if (currentPairSum == requiredSum)
                    {
                        // Quadruplet found
                        result.Add(new List<int> { nums[a], nums[b], nums[c], nums[d] });
                        while (c < d && nums[c] == nums[c + 1]) c++;
                        while (c < d && nums[d] == nums[d - 1]) d--;
                        c++;
                        d--;
                    }
                    else if (currentPairSum < requiredSum) c++;
                    else d--;
                }
            }
        }

        return result;
    }
}
```