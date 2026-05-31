You are given an array of integers where every element appears exactly twice except for one. Your task is to find the element that appears only once.
```cs
public class SingleNumber
{
    public static int FindSingleElement(int[] nums)
    {
        int result = 0;
        foreach (int num in nums)
        {
            result ^= num; // XOR Operator
        }
        return result;
    }
}```