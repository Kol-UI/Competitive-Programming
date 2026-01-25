// Exclusive Time of Functions
namespace CompetitiveProgramming.LeetCode.ExclusiveTimeofFunctions;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] ExclusiveTime(int n, IList<string> logs)
    {
        int[] result = new int[n];
        Stack<int> stack = new();
        int previous = 0;

        foreach (string log in logs)
        {
            // "0:start:2" -> ["0", "start", "2"]
            string[] logString = log.Split(':');
            int functionID = int.Parse(logString[0]);
            string call = logString[1];
            int timestamp = int.Parse(logString[2]);

            if (call == "start")
            {
                if (stack.Count > 0)
                {
                    // if function already running then add
                    result[stack.Peek()] += timestamp - previous;
                }
                // add id
                stack.Push(functionID);
                // update
                previous = timestamp;
            }
            else
            {
                // end
                // pop ended function
                int currentId = stack.Pop();
                result[currentId] += timestamp - previous + 1;
                previous = timestamp + 1;
            }
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.ExclusiveTime(2, ["0:start:0","1:start:2","1:end:5","0:end:6"]), [3,4]),
            ResultTester.CheckResult<int[]>(solution.ExclusiveTime(2, ["0:start:0","0:start:2","0:end:5","1:start:6","1:end:6","0:end:7"]), [7,1]),
            ResultTester.CheckResult<int[]>(solution.ExclusiveTime(1, ["0:start:0","0:start:2","0:end:5","0:start:6","0:end:6","0:end:7"]), [8]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Exclusive Time of Functions");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}