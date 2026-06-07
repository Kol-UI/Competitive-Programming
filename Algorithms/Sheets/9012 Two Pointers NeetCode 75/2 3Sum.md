3Sum :


Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] where nums[i] + nums[j] + nums[k] == 0, and the indices i, j and k are all distinct.

The output should not contain any duplicate triplets.

You may return the output and the triplets in any order.


Example 1:

Input: nums = [-1,0,1,2,-1,-4]

Output: [[-1,-1,2],[-1,0,1]]

Explanation:

nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.

nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.

nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.

The distinct triplets are [-1,0,1] and [-1,-1,2].


Example 2:

Input: nums = [0,1,1]

Output: []

Explanation: The only possible triplet does not sum up to 0.


Example 3:

Input: nums = [0,0,0]

Output: [[0,0,0]]

Explanation: The only possible triplet sums up to 0.



```cs
public class ThreeSumTwoPointers
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        // Step 1 : Sort
        Array.Sort(nums);
        int n = nums.Length;
        List<List<int>> result = new();

        // Step 2 : Main Loop
        for (int i = 0; i < n; i++)
        {
            // Step 2A : if first element positive break
            // since array is sorted, sum will be 0
            if (nums[i] > 0) 
                break;

            // Step 2B : manage i duplicates
            if (i > 0 && nums[i] == nums[i - 1]) 
                continue;

            // Step 3 : Two Pointers
            int left = i + 1;
            int right = n - 1;
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum > 0)
                {
                    // Sum too high : decrease highest number
                    right--;
                }
                else if (sum < 0)
                {
                    // Sum too low : increase lowest number
                    left++;
                }
                else // sum == 0 (triplet found)
                {
                    // add triplet to result
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;
                    right--;

                    // manage left & right duplicates
                    while (left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }
                    while (left < right && nums[right] == nums[right + 1])
                    {
                        right--;
                    }
                }
            }
        }

        return result;
    }
}
```