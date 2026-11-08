// Minimum Rotations to Dial a Number I
namespace CompetitiveProgramming.LeetCode.MinimumRotationstoDialaNumberI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinRotations(string s)
    {
        int rotations = 0, pointer = 0;
        foreach (char c in s)
        {
            int d = c - '0', diff = d - pointer;
            if (diff >= 0)
            {
                if (diff > 5)
                    rotations += 10 - diff;
                else
                    rotations += diff;
            }
            else
            {
                if (diff < -5)
                    rotations += diff + 10;
                else
                    rotations -= diff;
            }
            pointer = d;
        }
        return rotations;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinRotations("0192837465"), 25),
            ResultTester.CheckResult<int>(solution.MinRotations("1200210200"), 12),
            ResultTester.CheckResult<int>(solution.MinRotations(""), 0),
            ResultTester.CheckResult<int>(solution.MinRotations("0"), 0),
            ResultTester.CheckResult<int>(solution.MinRotations("0000000000"), 0),
            ResultTester.CheckResult<int>(solution.MinRotations("3"), 3),
            ResultTester.CheckResult<int>(solution.MinRotations("5"), 5),
            ResultTester.CheckResult<int>(solution.MinRotations("6"), 4),
            ResultTester.CheckResult<int>(solution.MinRotations("9"), 1),
            ResultTester.CheckResult<int>(solution.MinRotations("55555"), 5),
            ResultTester.CheckResult<int>(solution.MinRotations("1234567890"), 10),
            ResultTester.CheckResult<int>(solution.MinRotations("9876543210"), 10),
            ResultTester.CheckResult<int>(solution.MinRotations("05050505"), 35),
            ResultTester.CheckResult<int>(solution.MinRotations("28"), 6),
            ResultTester.CheckResult<int>(solution.MinRotations("82"), 6),
            ResultTester.CheckResult<int>(solution.MinRotations("37"), 7),
            ResultTester.CheckResult<int>(solution.MinRotations("73"), 7),
            ResultTester.CheckResult<int>(solution.MinRotations("5959"), 17),
            ResultTester.CheckResult<int>(solution.MinRotations("19"), 3),
            ResultTester.CheckResult<int>(solution.MinRotations("91"), 3),
            ResultTester.CheckResult<int>(solution.MinRotations("46"), 6),
            ResultTester.CheckResult<int>(solution.MinRotations("64"), 6)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Rotations to Dial a Number I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}