// Rabbits in Forest
namespace CompetitiveProgramming.LeetCode.RabbitsinForest;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
public class Solution
{
    public int NumRabbits(int[] answers) 
    {
        Dictionary<int,int> freq = new();
        int count = 0;

        foreach(int i in answers)
        {
            if(i == 0) count++;
            else
            {
                freq.TryAdd(i, 0);
                freq[i]++;
            } 
        }

        foreach(var k in freq.Keys)
        {
            int add = freq[k]/(k + 1) * (k + 1);
            if(freq[k] % (k + 1) > 0) add += (k + 1);
            count += add;
        }
        return count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.NumRabbits(new[] {1,1,2}), 5),
            ResultTester.CheckResult<int>(solution.NumRabbits(new[] {10,10,10}), 11),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Rabbits in Forest");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}