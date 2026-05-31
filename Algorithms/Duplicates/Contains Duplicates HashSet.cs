namespace CompetitiveProgramming.Algorithms;
public class ContainsDuplicatesHashSet
{
    public static bool ContainsDuplicates(int[] arr)
    {
        if (arr.Length <= 1) return false;

        return new HashSet<int>(arr).Count != arr.Length;
    }
}