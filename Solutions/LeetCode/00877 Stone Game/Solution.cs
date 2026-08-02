// Stone Game
namespace CompetitiveProgramming.LeetCode.StoneGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool StoneGame(int[] piles)
    {
        var priorityQueue = new PriorityQueue<int, int>(
            Comparer<int>.Create((first, second) => second - first));

        foreach(int pile in piles)
        {
            priorityQueue.Enqueue(pile, pile);
        }

        int totalOfAlice = 0;
        int totalOfBob = 0;
        bool turnOfAlice = true;
        while(priorityQueue.Count > 0)
        {
            int pile = priorityQueue.Dequeue();

            if(turnOfAlice)
            {
                totalOfAlice += pile;
            }
            else
            {
                totalOfBob += pile;
            }

            turnOfAlice = !turnOfAlice;
        }
        return totalOfAlice > totalOfBob;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.StoneGame([5,3,4,5]), true),
            ResultTester.CheckResult<bool>(solution.StoneGame([3,7,2,3]), true),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Stone Game");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}