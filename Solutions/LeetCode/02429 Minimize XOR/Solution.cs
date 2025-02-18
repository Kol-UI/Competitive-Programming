// Minimize XOR

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MinimizeXOR;

public class Solution
{
    public int MinimizeXor(int num1, int num2)
    {
        int res = 0;
        int c = 0;
        for(int i = 0; i < 32; i ++){
            int mask = 1 << i;
            if((num2 & mask) != 0) c ++;
        }
        for(int i = 31; i >= 0; i--){
            int mask = 1 << i;
            if((num1 & mask) != 0){
                res |= mask;
                c--;
                if(c == 0) return res;
            }
        }
        int a = 0;
        while(c > 0){
            int mask = 1 << a;
            if((mask & res) == 0){
                res |= mask;
                c--;
            }
            a++;
        }
        return res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinimizeXor(3,5), 3),
            ResultTester.CheckResult<int>(solution.MinimizeXor(1,12), 3)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimize XOR");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}