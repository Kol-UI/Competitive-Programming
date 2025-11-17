// The Celebrity Problem
namespace CompetitiveProgramming.GeeksForGeeks.Medium.TheCelebrityProblem;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
public class Solution1
{
    public int celebrity(int[,] mat)
    {
        int badResult = -1;
        int n = mat.GetLength(0);
        int[] indegree = new int[n];
        int[] outdegree = new int[n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int x = mat[i, j];
                outdegree[i] += x;
                indegree[j] += x;
            }
        }

        for (int i = 0; i < n; i++)
            if (indegree[i] == n - 1 && outdegree[i] == 0)
                return i;

        return badResult;
    }
}

public class Solution2
{
    public int celebrity(int[,] mat)
    {
        int n = mat.GetLength(0);
        Stack<int> stack = new();

        for (int i = 0; i < n; i++)
            stack.Push(i);

        while (stack.Count > 1)
        {
            int a = stack.Pop();
            int b = stack.Pop();

            if (mat[a, b] != 0)
            {
                stack.Push(b);
            }
            else
            {
                stack.Push(a);
            }
        }

        if (stack.Count == 0)
            return -1;

        int c = stack.Pop();

        for (int i = 0; i < n; i++)
        {
            if (i == c)
                continue;

            if (mat[c, i] != 0 || mat[i, c] == 0)
                return -1;
        }

        return c;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("The Celebrity Problem");
        ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks, ProblemCategory.MediumGFG);
    }
}