Find all duplicates in array and return every position that contain a duplicate. Ex : [1, 2, 3, 3, 4, 5, 5] returns [3,6]
```cs
public class FindAllDuplicates
{
    public static List<int> FindDuplicateIndexes(int[] arr)
    {
        HashSet<int> seen = new();
        List<int> duplicateIndexes = new();

        for (int i = 0; i < arr.Length; i++)
        {
            // If we have already seen this number, we add the current index to the list
            if (seen.Contains(arr[i]))
            {
                duplicateIndexes.Add(i);
            }
            else
            {
                seen.Add(arr[i]);
            }
        }

        return duplicateIndexes;
    }
}```