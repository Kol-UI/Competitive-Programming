namespace CompetitiveProgramming.Algorithms;

public class MonotonicStack
{
    private static int[] FindNextGreaterElements(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        Array.Fill(result, -1);

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && nums[i] > nums[stack.Peek()])
            {
                int index = stack.Pop();
                result[index] = nums[i];
            }
            stack.Push(i);
        }

        return result;
    }

    #region LC 496
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> nextGreaterMap = new Dictionary<int, int>();
        Stack<int> monotonicStack = new Stack<int>();

        foreach (int num in nums2)
        {
            while (monotonicStack.Count > 0 && num > monotonicStack.Peek())
            {
                int smallerElement = monotonicStack.Pop();
                nextGreaterMap[smallerElement] = num;
            }

            monotonicStack.Push(num);
        }

        while (monotonicStack.Count > 0)
        {
            nextGreaterMap[monotonicStack.Pop()] = -1;
        }

        int[] result = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++)
        {
            result[i] = nextGreaterMap[nums1[i]];
        }

        return result;
    }
    #endregion
}