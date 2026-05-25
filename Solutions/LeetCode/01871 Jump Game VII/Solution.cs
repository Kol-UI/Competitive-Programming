// Jump Game VII
namespace CompetitiveProgramming.LeetCode.JumpGameVII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CanReach(string s, int minJump, int maxJump)
    {
        int last = s.Length-1;
        if(s[last] == '1') return false;

        Queue<int> zerosIndices = new();
        zerosIndices.Enqueue(last);

        for(int i=s.Length-2; i>=0; i--){
            if(s[i] == '1') continue;

            int min = i+minJump, max = i+maxJump;

            while(zerosIndices.Count > 0 && zerosIndices.Peek() > max){
                zerosIndices.Dequeue();
            }

            while(zerosIndices.Count > 0 && zerosIndices.Peek() >= min){
                zerosIndices.Enqueue(i);
                break;
            }
        }

        while(zerosIndices.Count > 1){
            zerosIndices.Dequeue();
        }

        return zerosIndices.Count > 0 && zerosIndices.Peek() == 0;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.CanReach("011010", 2, 3), true),
            ResultTester.CheckResult<bool>(solution.CanReach("01101110", 2, 3), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Jump Game VII");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}