// Maximum Employees to Be Invited to a Meeting

namespace CompetitiveProgramming.LeetCode.MaximumEmployeestoBeInvitedtoaMeeting;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximumInvitations(int[] favorite)
    {
        Queue<int> queue = new Queue<int>();
        int n = favorite.Length;
        int[] inDegree = new int[n];
        int[] chainLengths = new int[n];
        bool[] visited = new bool[n];
        int maxCycle = 0;
        int totalChains = 0;

        for (int i = 0; i < n; i++)
        {
            inDegree[favorite[i]]++;
        }

        for (int i = 0; i < n; i++)
        {
            if (inDegree[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        while (queue.Count > 0)
        {
            int node = queue.Dequeue();
            visited[node] = true;
            int next = favorite[node];
            chainLengths[next] = chainLengths[node] + 1;
            inDegree[next]--;
            if (inDegree[next] == 0)
            {
                queue.Enqueue(next);
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (!visited[i])
            {
                int current = i;
                int cycleLength = 0;
                while (!visited[current])
                {
                    visited[current] = true;
                    current = favorite[current];
                    cycleLength++;
                }

                if (cycleLength == 2)
                {
                    totalChains += 2 + chainLengths[i] + chainLengths[favorite[i]];
                }
                else
                {
                    maxCycle = Math.Max(maxCycle, cycleLength);
                }
            }
        }

        return Math.Max(maxCycle, totalChains);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Employees to Be Invited to a Meeting");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}