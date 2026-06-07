Two Integer Sum II :
Given an array of integers numbers that is sorted in non-decreasing order.

Return the indices (1-indexed) of two numbers, [index1, index2], such that they add up to a given target number target and index1 < index2.

Note that index1 and index2 cannot be equal, therefore you may not use the same element twice.

There will always be exactly one valid solution.


Example 1:

Input: numbers = [1,2,3,4], target = 3

Output: [1,2]

Explanation:

The sum of 1 and 2 is 3.

Since we are assuming a 1-indexed array, index1 = 1, index2 = 2. We return [1, 2].



```cs
// Two Pointers Approch
public class TwoIntegerSumIITwoPointers
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int len = numbers.Length;
        int left = 0, right = len - 1;

        while (left < right)
        {
            int current = numbers[left] + numbers[right];
            if (current == target) return [left + 1, right + 1];
            else if (current < target) left++;
            else right--;
        }

        return [0, 0];
    }
}

// Brute Force Approch
public class TwoIntegerSumIIBruteForce
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int len = numbers.Length;
        for (int i = 0; i < len; i++)
        {
            for (int j = i + 1; j < len; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    return new int[] { i + 1, j + 1 };
                }
            }
        }
        return new int[0];
    }
}

// Binary Search Approch
public class TwoIntegerSumIIBinarySearch
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int len = numbers.Length;
        for (int i = 0; i < len; i++)
        {
            int left = i + 1, right = len - 1;
            int tmp = target - numbers[i];
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (numbers[mid] == tmp)
                {
                    return [i + 1, mid + 1];
                }
                else if (numbers[mid] < tmp)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
        return new int[0];
    }
    // For each numbers[i] the goal is to find the second number who is egal to target when adding numbers[i] (tmp)
    // mid is used to eliminate half of the array,
    // we go left or right from mid
}

// Set Approch
public class TwoIntegerSumIISet
{
    public int[] TwoSum(int[] numbers, int target)
    {
        Dictionary<int, int> set = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            int tmp = target - numbers[i];
            if (set.ContainsKey(tmp))
            {
                return new int[] { set[tmp], i + 1 };
            }
            set[numbers[i]] = i + 1;
        }
        return new int[0];
    }
    /*
        [1, 2, 3, 4], target = 3

        i = 0
            tmp = 3 - 1 = 2
            dictionary does not have 2
            add numbers[0] (1) and index 1 into dictionary
            set = {1: 1}

        i = 1
            tmp = 3 - 2 = 1
            dictionary have 1
            return : [set[1], i + 1] -> [1, 2]
    */
}
```