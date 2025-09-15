// Maximum Number of Words You Can Type


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumNumberofWordsYouCanType
{
    public class Solution
    {
        public static int CanBeTypedWords(string text, string brokenLetters)
        {
            if(string.IsNullOrEmpty(text))
            {
                return 0;
            }

            char[] broken = brokenLetters.ToCharArray();
            int count = 0;
            string[] word = text.Split(" ");

            for(int i = 0;i < word.Length; i++)
            {
                foreach(var j in broken)
                {
                    if(word[i].Contains(j))
                    {
                        count++;
                        break;
                    }
                }
            }
            return word.Length-count;
        }
    }

    public class Solution_MaximumNumberofWordsYouCanType_BruteForce
    {
        public int CanBeTypedWords(string text, string brokenLetters)
        {
            if (text == null || text.Length == 0) return 0;
            string[] words = text.Split(' ');
            int canBeTyped = words.Length;
            foreach (string word in words)
            {
                bool hasBrokenLetter = false;
                foreach (char brokenLetter in brokenLetters)
                {
                    if (word.Contains(brokenLetter))
                    {
                        hasBrokenLetter = true;
                        break;
                    }
                }
                if (hasBrokenLetter) canBeTyped--;
            }
            return canBeTyped;
        }
    }

    public class Solution_MaximumNumberofWordsYouCanType_Hashing
    {
        public int CanBeTypedWords(string text, string brokenLetters)
        {
            if (text == null || text.Length == 0) return 0;
            string[] words = text.Split(' ');
            int canBeTyped = words.Length;
            HashSet<char> hashing = new(brokenLetters);
            foreach (string word in words)
            {
                foreach (char c in word)
                {
                    if (hashing.Contains(c))
                    {
                        canBeTyped--;
                        break;
                    }
                }
            }
            return canBeTyped;
        }
    }

    public class Solution_MaximumNumberofWordsYouCanType_HashingLinq
    {
        public int CanBeTypedWords(string text, string brokenLetters)
        {
            if (string.IsNullOrEmpty(text)) return 0;
            var broken = new HashSet<char>(brokenLetters);
            return text.Split(' ').Count(word => !word.Any(c => broken.Contains(c)));
        }
    }


    public class Test
    {
        public static bool[] TestCases()
        {
            Solution_MaximumNumberofWordsYouCanType_BruteForce bf = new();
            Solution_MaximumNumberofWordsYouCanType_Hashing hashing = new();
            Solution_MaximumNumberofWordsYouCanType_HashingLinq hashingLinq = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CanBeTypedWords("hello world", "ad"), 1),
                ResultTester.CheckResult<int>(Solution.CanBeTypedWords("leet code", "lt"), 1),
                ResultTester.CheckResult<int>(Solution.CanBeTypedWords("leet code", "e"), 0),
                ResultTester.CheckResult<int>(bf.CanBeTypedWords("hello world", "ad"), 1),
                ResultTester.CheckResult<int>(bf.CanBeTypedWords("leet code", "lt"), 1),
                ResultTester.CheckResult<int>(bf.CanBeTypedWords("leet code", "e"), 0),
                ResultTester.CheckResult<int>(hashing.CanBeTypedWords("hello world", "ad"), 1),
                ResultTester.CheckResult<int>(hashing.CanBeTypedWords("leet code", "lt"), 1),
                ResultTester.CheckResult<int>(hashing.CanBeTypedWords("leet code", "e"), 0),
                ResultTester.CheckResult<int>(hashingLinq.CanBeTypedWords("hello world", "ad"), 1),
                ResultTester.CheckResult<int>(hashingLinq.CanBeTypedWords("leet code", "lt"), 1),
                ResultTester.CheckResult<int>(hashingLinq.CanBeTypedWords("leet code", "e"), 0),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1935");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}