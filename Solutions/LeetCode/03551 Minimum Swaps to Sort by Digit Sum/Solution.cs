// Minimum Swaps to Sort by Digit Sum
namespace CompetitiveProgramming.LeetCode.MinimumSwapstoSortbyDigitSum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinSwaps(int[] nums)
    {
        var sortedIndices = CreateSortedIndices(nums);
        var cycles = GetCycles(sortedIndices);
        return cycles.Sum();
    }

    private List<int> GetCycles(int[] sortedIndices)
    {
        var result = new List<int>();
        var visited = new bool[sortedIndices.Length];
        for (int i = 0; i < visited.Length; i++)
        {
            if (!visited[i])
            {
                result.Add(GetCycleLength(i, visited, sortedIndices));
            }
        }
        return result;
    }

    private int GetCycleLength(int index, bool[] visited, int[] sortedIndices)
    {
        var result = 0;
        do{
            visited[index] = true;
            result++;
            index = sortedIndices[index];
        }while(!visited[index]);
        result--;
        return result;
    }

    private int[] CreateSortedIndices(int[] nums)
    {
        var aux = new (int val, int index)[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            aux[i] = (nums[i], i);
        }
        aux = aux.OrderBy(p => DigitSum(p.val)).ThenBy(p => p.val).ToArray();
        var result = new int[aux.Length];
        for (int i = 0; i < aux.Length; i++)
        {
            result[i] = aux[i].index;
        }
        return result;
    }
    
    private int DigitSum(int n)
    {
        var result = 0;
        while (n > 0)
        {
            result += n % 10;
            n /= 10;
        }
        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Swaps to Sort by Digit Sum");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}