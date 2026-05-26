Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.

 

Example 1:

Input: nums = [4,3,2,7,8,2,3,1]

Output: [5,6]


Example 2:

Input: nums = [1,1]

Output: [2]


```cs
// Brute Force Approch
// Slow for bigger arrays
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var result = new List<int>();
        int n = nums.Length;

        for (int i = 1; i <= n; i++)
        {
            bool found = false;

            for (int j = 0; j < n; j++)
            {
                if (nums[j] == i)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
                result.Add(i);
        }

        return result;
    }
}

// Extra Array Approch
// But use extra memory
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        int n = nums.Length;
        bool[] seen = new bool[n + 1];

        foreach (int num in nums)
            seen[num] = true;

        var result = new List<int>();
        for (int i = 1; i <= n; i++)
            if (!seen[i])
                result.Add(i);

        return result;
    }
}

// Linq / HashSet Approch
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        int n = nums.Length;
        var set = nums.ToHashSet();

        return Enumerable
            .Range(1, n)
            .Where(x => !set.Contains(x))
            .ToList();
    }
}

// Optimal Approch
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var result = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0)
                nums[index] = -nums[index];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
                result.Add(i + 1);
        }

        return result;
    }
}

// Cycle Sort Approch
public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        int i = 0;
        while (i < nums.Length)
        {
            int correctIndex = nums[i] - 1;
            if (nums[i] != nums[correctIndex])
            {
                int temp = nums[i];
                nums[i] = nums[correctIndex];
                nums[correctIndex] = temp;
            }
            else
            {
                i++;
            }
        }

        var result = new List<int>();
        for (i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1)
                result.Add(i + 1);
        }

        return result;
    }
}

```