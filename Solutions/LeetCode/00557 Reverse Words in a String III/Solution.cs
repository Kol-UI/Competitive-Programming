// Reverse Words in a String III

/*
Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

 

Example 1:

Input: s = "Let's take LeetCode contest"
Output: "s'teL ekat edoCteeL tsetnoc"

Example 2:

Input: s = "God Ding"
Output: "doG gniD"
*/

using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ReverseWordsinaStringIII
{
    public class Solution
    {
        // Two Pointers
        public static string ReverseWords(string s)
        {
            string[] words = s.Split(" ");
        
            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                int l = 0, h = chars.Length - 1;
                while (l < h)
                {
                    (chars[l], chars[h]) = (chars[h], chars[l]);
                    l++;
                    h--;
                }

                words[i] = new string(chars);
            }

            return String.Join(" ", words);
        }
    }

    public class AlternativeSolution
    {
        public static string ReverseWords(string s)
        {
            var arrayOfWords = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder reversedString = new StringBuilder("");

            foreach (var word in arrayOfWords)
            {            
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);

                reversedString.Append(" " + new string(charArray));
            }

            string result = reversedString.ToString().Substring(1);

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestReverseWordsinaStringIII()
        {
            string case1_557 = "Let's take LeetCode contest";
            string case2_557 = "God Ding";
            string output1_557 = "s'teL ekat edoCteeL tsetnoc";
            string output2_557 = "doG gniD";

            string result1 = Solution.ReverseWords(case1_557);
            string result2 = Solution.ReverseWords(case2_557);

            string AlternativeResult1 = AlternativeSolution.ReverseWords(case1_557);
            string AlternativeResult2 = AlternativeSolution.ReverseWords(case2_557);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(result1, output1_557),
                ResultTester.CheckResult<string>(result2, output2_557),
                ResultTester.CheckResult<string>(AlternativeResult1, output1_557),
                ResultTester.CheckResult<string>(AlternativeResult2, output2_557)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("557");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestReverseWordsinaStringIII());
        }
    }
}