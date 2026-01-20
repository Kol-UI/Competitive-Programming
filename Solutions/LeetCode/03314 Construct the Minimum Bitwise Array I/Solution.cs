// Construct the Minimum Bitwise Array I
namespace CompetitiveProgramming.LeetCode.ConstructtheMinimumBitwiseArrayI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] MinBitwiseArray(IList<int> nums)
    {
        int size = 1000, len = nums.Count;
        int[] ors = Enumerable.Repeat(-1, size + 1).ToArray();

        for (int i = 0; i < size; i++)
        {
            int curOR = i | (i + 1);
            if (curOR <= size && ors[curOR] == -1)
                ors[curOR] = i;
        }

        int[] res = new int[len];
        for (int i = 0; i < len; i++)
        {
            int id = nums[i];
            res[i] = ors[id];
        }

        return res;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Construct the Minimum Bitwise Array I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}