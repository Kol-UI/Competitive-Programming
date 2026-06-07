Rotate Array :

You are given an integer array nums, rotate the array to the right by k steps, where k is non-negative.


Example 1:

Input: nums = [1,2,3,4,5,6,7,8], k = 4

Output: [5,6,7,8,1,2,3,4]

Explanation:

rotate 1 steps to the right: [8,1,2,3,4,5,6,7]

rotate 2 steps to the right: [7,8,1,2,3,4,5,6]

rotate 3 steps to the right: [6,7,8,1,2,3,4,5]

rotate 4 steps to the right: [5,6,7,8,1,2,3,4]


Example 2:

Input: nums = [1000,2,4,-3], k = 2

Output: [4,-3,1000,2]

Explanation:
rotate 1 steps to the right: [-3,1000,2,4]

rotate 2 steps to the right: [4,-3,1000,2]



```cs
// Approches from worst to best

// Brute Force Approch
public class RotateArrayBruteForce
{
    /*
        [1, 2, 3, 4]
        [1, 2, 3, 3] -> [1, 2, 2, 3] -> [1, 1, 2, 3]
        [4, 1, 2, 3]
    */
    public void Rotate(int[] nums, int k)
    {
        int len = nums.Length;
        if (len == 0 || k % len == 0) return;
        k %= len;

        while (k > 0)
        {
            int tmp = nums[len - 1];
            for (int i = len - 1; i > 0; i--)
            {
                nums[i] = nums[i - 1];
            }
            nums[0] = tmp;
            k--;
        }
    }
}

// Queue Approch
public class RotateArrayQueue()
{
    public void Rotate(int[] nums, int k)
    {
        int len = nums.Length;
        if (len == 0 || k % len == 0) return;
        k = k % len;
        Queue<int> q = new Queue<int>(nums);

        // Perform k rotations : Dequeue from front, Enqueue to rear
        int rotationsToPerform = len - k;
        for (int i = 0; i < rotationsToPerform; i++)
        {
            int element = q.Dequeue(); // Element from the front
            q.Enqueue(element); // Move it to the back
        }

        // Update the original array with the rotated elements from the Queue
        for (int i = 0; i < len; i++)
        {
            nums[i] = q.Dequeue();
        }
    }
}

// Linq Approch (not in place)
public class RotateArrayLinq()
{
    public void Rotate(int[] nums, int k)
    {
        int len = nums.Length;
        if (len == 0 || k % len == 0) return;
        k = k % len;
        // Calculate the number of elements to skip from the start
        int countToSkip = len - k;

        // Take the last k elements and then concatenate the remaining elements
        var rotatedArray = nums.Skip(countToSkip)
                            .Concat(nums.Take(countToSkip))
                            .ToArray();

        // Copy the rotated array back into the original array (required since Linq creates a new collection)
        for (int i = 0; i < len; i++) nums[i] = rotatedArray[i];
    }
}

// IEnumerable (Manual Manipulation) Approch
public class RotateArrayIEnumerable()
{
    // The rotation involves placing elements from index (i + n - k) % n at index i
    // Since we must not use Skip/Concat, we manually build the new array
    public void Rotate(int[] nums, int k)
    {
        int len = nums.Length;
        if (len == 0 || k % len == 0) return;
        k = k % len;
        var rotatedList = new List<int>(len);

        // Elements that move from the END to the START
        for (int i = len - k; i < len; i++)
        {
            rotatedList.Add(nums[i]);
        }

        // Elements that move from the START to the END
        for (int i = 0; i < len - k; i++)
        {
            rotatedList.Add(nums[i]);
        }

        // Copy the rotated list back into the original array
        for (int i = 0; i < len; i++)
        {
            nums[i] = rotatedList[i];
        }
    }
}

// Extra Space Approch (using an Auxiliary array)
public class RotateArrayExtraSpace
{
    public void Rotate(int[] nums, int k)
    {
        int len = nums.Length;
        int[] tmp = new int[len];

        // Rotation formula
        for (int i = 0; i < len; i++)
        {
            tmp[(i + k) % len] = nums[i];
        }

        // Copying back
        for (int i = 0; i < len; i++)
        {
            nums[i] = tmp[i];
        }
    }
}

// One Liner Approch
public class RotateArrayOneLiner
{
    public void Rotate(int[] nums, int k)
    {
        int len = nums.Length;
        if (len == 0) return;
        k %= len;

        int[] rotated = new int[len];
        Array.Copy(nums, len - k, rotated, 0, k); // Get the last k elements
        Array.Copy(nums, 0, rotated, k, len - k); // Get the first n−k elements
        Array.Copy(rotated, nums, len); // Final copy back
    }
}

// Cyclic Traversal Approch
public class RotateArrayCyclicTraversal
{
    /*
        The algorithm starts at an index and follows the rotation path (shifting by k)
        until it returns to the starting index,
        placing each element in its final position during the traversal.
        By continuing this process for new, unvisited starting indices until all elements have been moved,
        the array is rotated without using any auxiliary storage.

        0 -> 4	[1,2,3,4,1,6]
        4 -> 2	[1,2,5,4,1,6]
        2 -> 0	[3,2,5,4,1,6]
    */
    public void Rotate(int[] nums, int k)
    {
        int len = nums.Length;
        if (len == 0) return;
        k %= len;
        int count = 0;

        for (int start = 0; count < len; start++)
        {
            int current = start;
            int prev = nums[start];
            do
            {
                int nextIdx = (current + k) % len;
                (prev, nums[nextIdx]) = (nums[nextIdx], prev);
                current = nextIdx;
                count++;
            } while (start != current);
        }
    }
}

// Two Pointers Approch
public class RotateArrayTwoPointers()
{
    /*
        Reverse the entire array.

        Reverse the first k elements.

        Reverse the remaining n−k elements.
    */
    public void Rotate(int[] nums, int k)
    {
        int len = nums.Length;
        // No rotation needed
        if (len == 0 || k % len == 0) return;

        // Normalize k : k should be less than len
        k = k % len;

        // Helper function to reverse a section of the array
        void Reverse(int start, int end)
        {
            while (start < end)
            {
                (nums[end], nums[start]) = (nums[start], nums[end]);
                start++;
                end--;
            }
        }

        // Step 1: [1,2,3,4,5,6,7,8] -> [8,7,6,5,4,3,2,1]
        Reverse(0, len - 1);

        // Step 2: [8,7,6,5,4,3,2,1] (k = 4) -> [5,6,7,8,4,3,2,1]
        Reverse(0, k - 1);

        // Step 3: [5,6,7,8,4,3,2,1] -> [5,6,7,8,1,2,3,4]
        Reverse(k, len - 1);
    }
}
```