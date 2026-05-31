namespace CompetitiveProgramming.Algorithms;

public class RemoveDuplicatesFromSortedArray
{
    public static int[] RemoveDuplicates(int[] arr)
    {
        if (arr.Length == 0) return [];

        int k = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[i - 1])
            {
                arr[k] = arr[i];
                k++;
            }
        }

        return arr[..k]; // slice [1, 2, 3]
    }
    /*
        arr = [1, 1, 2, 3, 3]

        step 1 : arr[1]==arr[0] → duplicates, we skip
        [1, 1, 2, 3, 3]
        k=1

        step 2 : arr[2]!=arr[1] → unique, we write at k=1
        [1, 2, 2, 3, 3]
            k=2

        step 3 : arr[3]!=arr[2] → unique, we write at k=2
        [1, 2, 3, 3, 3]
               k=3

        step 4 : arr[4]==arr[3] → duplicates, we skip
        [1, 2, 3, 3, 3]
               k=3 (not changed)
    */
    
    public static int[] RemoveWithHashSet(int[] arr) => new HashSet<int>(arr).ToArray();

    public static int[] RemoveWithLinq(int[] arr) =>  arr.Distinct().ToArray();
}