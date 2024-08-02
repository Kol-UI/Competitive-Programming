// Find Words That Can Be Formed by Characters




using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindWordsThatCanBeFormedbyCharacters
{
    public class Solution
    {
        private static Dictionary<char, int> Helper(string word)
        {
            Dictionary<char, int> myDictionary = new Dictionary<char, int>();
            foreach (char c in word)
            {
                if (myDictionary.ContainsKey(c))
                {
                    myDictionary[c] += 1;
                }
                else
                {
                    myDictionary[c] = 1;
                }
            }
            return myDictionary;
        }

        public static int CountCharacters(string[] words, string chars)
        {
            int result = 0;
            foreach (string word in words)
            {
                int check = 0;
                Dictionary<char, int> current = Helper(word);
                foreach (var entry in current)
                {
                    if (entry.Value <= chars.Count(c => c == entry.Key))
                    {
                        check = 1;
                    }
                    else
                    {
                        check = 0;
                        break;
                    }
                }
                if (check == 1)
                {
                    result += word.Length;
                }
            }
            return result;
        }
    }


    public class Test
    {
        public static bool[] TestCases()
        {
            string[] words1_1 = {"cat","bt","hat","tree"};
            string chars2_1 = "atach";

            string[] words1_2 = {"hello","world","leetcode"};
            string chars2_2 = "welldonehoneyr";

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountCharacters(words1_1, chars2_1), 6),
                ResultTester.CheckResult<int>(Solution.CountCharacters(words1_2, chars2_2), 10),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1160");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}