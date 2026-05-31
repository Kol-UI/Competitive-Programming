Check if an array contains duplicates by using an HashSet. If the HashSet size is different than array size, then the array contains duplicates.
```cs
public class ContainsDuplicatesHashSet
{
    public static bool ContainsDuplicates(int[] arr)
    {
        if (arr.Length <= 1) return false;

        return new HashSet<int>(arr).Count != arr.Length;
    }
}```