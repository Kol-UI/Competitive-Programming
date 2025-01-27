// Course Schedule IV

namespace CompetitiveProgramming.LeetCode.CourseScheduleIV;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private int[,] memoizationTable = new int[0, 0];

    public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries)
    {
        memoizationTable = new int[numCourses, numCourses];
        var adjacencyList = BuildAdjacencyList(numCourses, prerequisites);

        return queries.Select(query => IsPrerequisite(adjacencyList, query[0], query[1])).ToList();
    }

    private List<List<int>> BuildAdjacencyList(int numCourses, int[][] prerequisites)
    {
        var adjList = Enumerable.Range(0, numCourses)
                                .Select(_ => new List<int>())
                                .ToList();

        foreach (var prerequisite in prerequisites)
        {
            adjList[prerequisite[0]].Add(prerequisite[1]);
        }

        return adjList;
    }

    private bool IsPrerequisite(List<List<int>> adjList, int start, int end)
    {
        if (start == end) return true;
        if (memoizationTable[start, end] != 0) return memoizationTable[start, end] == 1;

        foreach (var neighbor in adjList[start])
        {
            if (IsPrerequisite(adjList, neighbor, end))
            {
                memoizationTable[start, end] = 1;
                return true;
            }
        }

        memoizationTable[start, end] = -1;
        return false;
    }
}


public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Course Schedule IV");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}