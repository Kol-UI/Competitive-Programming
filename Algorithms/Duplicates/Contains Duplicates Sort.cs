namespace CompetitiveProgramming.Algorithms;
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
}