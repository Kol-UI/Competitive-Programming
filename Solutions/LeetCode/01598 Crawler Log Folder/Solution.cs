// Crawler Log Folder

using System.Collections;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CrawlerLogFolder
{
    public class Solution
    {
        public static int MinOperations(string[] logs)
        {
            Stack stack = new Stack();
            foreach(string path in logs)
            {
                if(path == "../" && Convert.ToBoolean(stack.Count)) stack.Pop();
                if(path != "./" && path != "../") stack.Push(path);
            }
            return stack.Count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinOperations(new string[]{"d1/","d2/","../","d21/","./"}), 2),
                ResultTester.CheckResult<int>(Solution.MinOperations(new string[]{"d1/","d2/","./","d3/","../","d31/"}), 3),
                ResultTester.CheckResult<int>(Solution.MinOperations(new string[]{"d1/","../","../","../"}), 0),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Crawler Log Folder");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}