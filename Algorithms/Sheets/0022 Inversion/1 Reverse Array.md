Reverse Array

```cs
// Problem: Reverse Array
// Given an array of integers, return it reversed.
// Multiple approaches are shown: built-in, LINQ, manual in-place, manual new array, recursive, stack-based.
public class ReverseArray
{
    // Approach 1: Built-in Array.Reverse (in-place)
    public static int[] ReverseBuiltIn(int[] arr)
    {
        int[] copy = (int[])arr.Clone();
        Array.Reverse(copy);
        return copy;
    }

    // Approach 2: LINQ .Reverse()
    public static int[] ReverseLinq(int[] arr)
    {
        return arr.Reverse().ToArray();
    }

    // Approach 3: Manual two-pointer swap, in-place
    public static int[] ReverseInPlace(int[] arr)
    {
        int[] copy = (int[])arr.Clone();
        int left = 0;
        int right = copy.Length - 1;
        while (left < right)
        {
            (copy[left], copy[right]) = (copy[right], copy[left]);
            left++;
            right--;
        }
        return copy;
    }

    // Approach 4: Manual, build a new array by copying from the end
    public static int[] ReverseNewArray(int[] arr)
    {
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }
        return result;
    }

    // Approach 5: Recursive swap
    public static int[] ReverseRecursive(int[] arr)
    {
        int[] copy = (int[])arr.Clone();
        ReverseRecursiveHelper(copy, 0, copy.Length - 1);
        return copy;
    }

    private static void ReverseRecursiveHelper(int[] arr, int left, int right)
    {
        if (left >= right) return;
        (arr[left], arr[right]) = (arr[right], arr[left]);
        ReverseRecursiveHelper(arr, left + 1, right - 1);
    }

    // Approach 6: Stack-based (push all, then pop)
    public static int[] ReverseWithStack(int[] arr)
    {
        var stack = new Stack<int>();
        foreach (int n in arr)
        {
            stack.Push(n);
        }

        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = stack.Pop();
        }
        return result;
    }
}```