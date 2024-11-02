// Decode the Message

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DecodetheMessage
{
    public class Solution
    {
        public string DecodeMessage(string key, string message)
        {
            StringBuilder sb = new StringBuilder();
            char[] keyToActual = new char[128];
            keyToActual[' '] = ' ';
            char currChar = 'a';

            foreach (char c in key.ToCharArray())
                if (keyToActual[c] == 0)
                    keyToActual[c] = currChar++;

            foreach(char c in message.ToCharArray())
                sb.Append(keyToActual[c]);

            return sb.ToString();
        }
    }
    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(solution.DecodeMessage("the quick brown fox jumps over the lazy dog", "vkbs bs t suepuv"), "this is a secret"),
                ResultTester.CheckResult<string>(solution.DecodeMessage("eljuxhpwnyrdgtqkviszcfmabo", "zwx hnfx lqantp mnoeius ycgk vcnjrdb"), "the five boxing wizards jump quickly")
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Decode the Message");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}