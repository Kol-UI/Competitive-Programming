// Number of Lines To Write String
namespace CompetitiveProgramming.LeetCode.NumberofLinesToWriteString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] NumberOfLines(int[] widths, string s)
    {
        int[] result = new int[2];
        result[0] = 1;
        int pixels = 0;
        foreach(char ch in s)
        {
            int width = widths[ch - 'a'];

            if(pixels + width > 100)
            {
                result[0]++;
                pixels = 0;
            }
            pixels += width;
        }

        result[1] = pixels;
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        int[] ints1 = new int[]{10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10};
        int[] ints2 = new int[]{4,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10};
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int[]>(solution.NumberOfLines(ints2, "bbbcccdddaaa"), new int[]{2,4}),
            ResultTester.CheckResult<int[]>(solution.NumberOfLines(ints1, "abcdefghijklmnopqrstuvwxyz"), new int[]{3,60}),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Lines To Write String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}