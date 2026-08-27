namespace CompetitiveProgramming.Algorithms;

public class ReverseArrayInPlace
{
    // Approach 1: Built-in Array.Reverse (truly in-place)
    public static void ReverseBuiltIn(int[] arr)
    {
        Array.Reverse(arr);
    }

    // Approach 2: Two-pointer swap with a while loop
    public static void ReverseTwoPointers(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left < right)
        {
            (arr[left], arr[right]) = (arr[right], arr[left]);
            left++;
            right--;
        }
    }

    // Approach 3: For loop swapping only the first half
    public static void ReverseForLoop(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n / 2; i++)
        {
            (arr[i], arr[n - 1 - i]) = (arr[n - 1 - i], arr[i]);
        }
    }

    // Approach 4: Recursive in-place swap
    public static void ReverseRecursive(int[] arr)
    {
        ReverseRecursiveHelper(arr, 0, arr.Length - 1);
    }

    private static void ReverseRecursiveHelper(int[] arr, int left, int right)
    {
        if (left >= right) return;
        (arr[left], arr[right]) = (arr[right], arr[left]);
        ReverseRecursiveHelper(arr, left + 1, right - 1);
    }

    // Approach 5: XOR swap trick, no temp variable used
    public static void ReverseXorSwap(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left < right)
        {
            // skip XOR swap if same index to avoid zeroing the value
            if (left != right)
            {
                arr[left] ^= arr[right];
                arr[right] ^= arr[left];
                arr[left] ^= arr[right];
            }
            left++;
            right--;
        }
    }
}