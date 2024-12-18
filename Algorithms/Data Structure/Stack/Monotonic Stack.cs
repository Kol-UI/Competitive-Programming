namespace CompetitiveProgramming.Algorithms;

public class MonotonicStack
{
    public bool IsMonotonicStack(Stack<int> stack, bool isAscending)
    {
        if (stack == null || stack.Count == 0) return true;

        int previous = stack.Pop();

        while (stack.Count > 0)
        {
            int current = stack.Pop();

            if (isAscending && current < previous) return false; // Increasing
            if (!isAscending && current > previous) return false; // Decreasing

            previous = current;
        }

        return true;
    }

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

    #region LC 1475
    public int[] FinalPrices(int[] prices)
    {
        int n = prices.Length;
        int[] result = new int[n];
        Array.Copy(prices, result, n);

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && prices[i] <= prices[stack.Peek()])
            {
                int j = stack.Pop();
                result[j] = prices[j] - prices[i];
            }
            stack.Push(i);
        }

        return result;
    }
    #endregion

    #region LC 739
    public int[] DailyTemperatures(int[] temperatures)
    {
        int n = temperatures.Length;
        int[] result = new int[n];
        Stack<int> monotonicStack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (monotonicStack.Count > 0 && temperatures[i] > temperatures[monotonicStack.Peek()])
            {
                int index = monotonicStack.Pop();
                result[index] = i - index;
            }
            monotonicStack.Push(i);
        }

        return result;
    }
    #endregion
}