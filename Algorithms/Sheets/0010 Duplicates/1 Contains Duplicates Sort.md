Check if an array contains duplicates by sorting a copy of the array. Then for each value we look the next is egal. If there are egal then the array contains duplicates.
```cs
public class ContainsDuplicatesSort
{
    public static bool ContainsDuplicates(int[] arr)
    {
        if (arr.Length <= 1) return false;

        int[] sorted = (int[])arr.Clone();
        Array.Sort(sorted);

        for (int i = 1; i < sorted.Length; i++)
        {
            if (sorted[i] == sorted[i - 1]) return true;
        }

        return false;
    }
}```