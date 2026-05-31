namespace CompetitiveProgramming.Algorithms;
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
}