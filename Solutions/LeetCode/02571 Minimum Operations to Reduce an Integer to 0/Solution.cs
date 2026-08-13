// Minimum Operations to Reduce an Integer to 0
namespace CompetitiveProgramming.LeetCode.MinimumOperationstoReduceanIntegertoZero;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinOperations(int arrayLength)
    {
        int numOperations = 0;

        while (arrayLength > 0)
        {
            if ((arrayLength & 3) == 3)
            {
                arrayLength++;
                numOperations++;
            } 
            else
            {
                numOperations += arrayLength & 1;
                arrayLength >>= 1;
            }
        }

        return numOperations;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Reduce an Integer to 0");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}