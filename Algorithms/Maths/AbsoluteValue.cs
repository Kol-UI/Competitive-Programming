namespace CompetitiveProgramming.Algorithms;

public class AbsoluteValue
{
    // -1, 2, -3, 4, -5 => 1 2 3 4 5 => 15
    private static int GetAbsoluteSum(int[] a) => a.Select(Math.Abs).Sum();
}