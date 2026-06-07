Convert an Array to List and Convert a List to an Array.
```cs

public class ArraytoListandListtoArray
{
    public static int[] ConvertListToArray(List<int> list)
    {
        if (list == null || list.Count == 0) return [];
        
        int[] array = new int[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            array[i] = list[i];
        }
        return array;
    }

    public static List<int> ConvertArrayToList(int[] array)
    {
        if (array == null || array.Length == 0) return [];

        List<int> list = [];
        foreach (int item in array)
        {
            list.Add(item);
        }
        return list;
    }

    // Linq Approach
    public static int[] ConvertWithLinq(List<int> list) => list.ToArray();
    public static List<int> ConvertWithLinq(int[] array) => array.ToList();
}```