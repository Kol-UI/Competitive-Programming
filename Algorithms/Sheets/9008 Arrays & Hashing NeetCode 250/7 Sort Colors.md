You are given an array nums consisting of n elements where each element is an integer representing a color:

0 represents red

1 represents white

2 represents blue

Your task is to sort the array in-place such that elements of the same color are grouped together and arranged in the order: red (0), white (1), and then blue (2).

You must not use any built-in sorting functions to solve this problem.


Example 1:

Input: nums = [1,0,1,2]

Output: [0,1,1,2]


Example 2:

Input: nums = [2,1,0]

Output: [0,1,2]


Constraints:

1 <= nums.length <= 300.

0 <= nums[i] <= 2.


Follow up: Could you come up with a one-pass algorithm using only constant extra space?




Built-in Approach

```cs
public class SortColorsBuiltIn
{
    public void SortColors(int[] nums) => Array.Sort(nums);
}
```



Counting Approach

```cs
public class SortColorsCounting
{
    public void SortColors(int[] nums)
    {
        int[] count = new int[3]; // number of occurrences
        foreach (int i in nums)
        {
            count[i]++;
        }

        // recreate array
        int index = 0;
        for (int i = 0; i < 3; i++)
        {
            while (count[i]-- > 0)
            {
                nums[index++] = i;
            }
        }
    }
}
```



Dutch National Flag Algorithm Approach

```cs
public class SortColorsDNF
{
    public void SortColors(int[] nums)
    {
        if (nums == null || nums.Length == 0) return;

        int low = 0;
        int mid = 0;
        int high = nums.Length - 1;

        while (mid <= high)
        {
            switch (nums[mid])
            {
                case 0:
                    (nums[low], nums[mid]) = (nums[mid], nums[low]);
                    low++;
                    mid++;
                    break;
                case 1:
                    mid++;
                    break;
                case 2:
                    (nums[mid], nums[high]) = (nums[high], nums[mid]);
                    high--;
                    break;
            }
        }

        /*
            Reminder Dutch National Flag Algorithm :
            while mid < high
            switch mid
            - swap low mid | low++ mid++
            - mid++
            - swap mid high | high--
        */
    }
}
```