// Queue Reconstruction by Height
namespace CompetitiveProgramming.LeetCode.QueueReconstructionbyHeight;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[][] ReconstructQueue(int[][] people)
    {
        IOrderedEnumerable<int[]> oderedPeople = people.OrderByDescending(person => person[0]).ThenBy(person => person[1]);
        List<int[]> results = new();
        foreach (int[] person in oderedPeople)
        {
            results.Insert(person[1], person);
        }

        return results.ToArray();
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Queue Reconstruction by Height");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}