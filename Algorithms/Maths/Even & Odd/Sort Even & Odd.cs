namespace CompetitiveProgramming.Algorithms;

public class SortEvenOddInArrayLinq
{
    public static int[] SortEvenOdd(int[] numbers)
    {
        if (numbers == null) return [];

        // OrderBy + IsEven
        return numbers.OrderBy(n => n % 2 != 0).ToArray();
    }
}

public class SortEvenOddInArray
{
    public static int[] SortEvenOdd(int[] numbers)
    {
        if (numbers == null) return [];

        int[] result = new int[numbers.Length];
        int left = 0;
        int right = numbers.Length - 1;

        foreach (int n in numbers)
        {
            // Bitwise for perf
            if ((n & 1) == 0)
                result[left++] = n;  // left even
            else
                result[right--] = n; // right odds
        }

        return result;
    }
}