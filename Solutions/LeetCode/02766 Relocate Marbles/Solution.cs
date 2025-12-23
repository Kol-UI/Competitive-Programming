// Relocate Marbles
namespace CompetitiveProgramming.LeetCode.RelocateMarbles;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<int> RelocateMarbles(int[] initial, int[] source, int[] destination)
    {
        HashSet<int> positions = new HashSet<int>(initial);

        for (int i = 0; i < source.Length; i++)
        {
            if (positions.Remove(source[i]))
            {
                positions.Add(destination[i]);
            }
        }

        return positions.OrderBy(x => x).ToList();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();

        int[] initial1 = {1, 6, 7, 8};
        int[] source1 = {1, 7, 2};
        int[] destination1 = {2, 9, 5};
        IList<int> expected1 = new List<int> {5, 6, 8, 9};

        int[] initial2 = {1, 1, 3, 3};
        int[] source2 = {1, 3};
        int[] destination2 = {2, 2};
        IList<int> expected2 = new List<int> {2};

        bool[] results = new bool[]
        {
            ResultTester.CheckResult<IList<int>>(solution.RelocateMarbles(initial1, source1, destination1), expected1),
            ResultTester.CheckResult<IList<int>>(solution.RelocateMarbles(initial2, source2, destination2), expected2),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Relocate Marbles");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}