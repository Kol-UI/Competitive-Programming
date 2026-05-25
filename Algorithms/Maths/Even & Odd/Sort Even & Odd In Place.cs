namespace CompetitiveProgramming.Algorithms;

// Two Pointers Approach
public class SortEvenOddInPlace
{
    public static void SortEvenOdd(int[] numbers)
    {
        if (numbers == null || numbers.Length <= 1) return;

        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            // move left hile we find even numbers (bitwise)
            while (left < right && (numbers[left] & 1) == 0)
            {
                left++;
            }

            // move right while we find odd numbers (bitwise)
            while (left < right && (numbers[right] & 1) != 0)
            {
                right--;
            }

            // if pointers didn't met, we swap
            if (left < right)
            {
                (numbers[right], numbers[left]) = (numbers[left], numbers[right]); // tuple swap
                left++;
                right--;
            }
        }
    }
}