// Find the K-Beauty of a Number
namespace CompetitiveProgramming.LeetCode.FindtheKBeautyofaNumber;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int DivisorSubstrings(int num, int k) 
    {
        string str = Convert.ToString(num);
        int sol = 0;
        for(int i = 0; i < str.Length - k + 1; i++)
        {
            int temp = 0;
            int _k = k - 1;
            for(int j = 0; j < k; j++, _k--)
                temp += (int)Math.Pow(10, _k) * (str[i + j] - 48);
            if(temp > 0 && num % temp == 0)
                sol++;
        }
        return sol;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.DivisorSubstrings(240, 2), 2),
            ResultTester.CheckResult<int>(solution.DivisorSubstrings(430043, 2), 2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the K-Beauty of a Number");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}