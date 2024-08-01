// Text Justification

/*
Given an array of strings words and a width maxWidth, format the text such that each line has exactly maxWidth characters and is fully (left and right) justified.

You should pack your words in a greedy approach; that is, pack as many words as you can in each line. Pad extra spaces ' ' when necessary so that each line has exactly maxWidth characters.

Extra spaces between words should be distributed as evenly as possible. If the number of spaces on a line does not divide evenly between words, the empty slots on the left will be assigned more spaces than the slots on the right.

For the last line of text, it should be left-justified, and no extra space is inserted between words.

Note:

A word is defined as a character sequence consisting of non-space characters only.
Each word's length is guaranteed to be greater than 0 and not exceed maxWidth.
The input array words contains at least one word.
 

Example 1:

Input: words = ["This", "is", "an", "example", "of", "text", "justification."], maxWidth = 16
Output:
[
   "This    is    an",
   "example  of text",
   "justification.  "
]

Example 2:

Input: words = ["What","must","be","acknowledgment","shall","be"], maxWidth = 16
Output:
[
  "What   must   be",
  "acknowledgment  ",
  "shall be        "
]
Explanation: Note that the last line is "shall be    " instead of "shall     be", because the last line must be left-justified instead of fully-justified.
Note that the second line is also left-justified because it contains only one word.

Example 3:

Input: words = ["Science","is","what","we","understand","well","enough","to","explain","to","a","computer.","Art","is","everything","else","we","do"], maxWidth = 20
Output:
[
  "Science  is  what we",
  "understand      well",
  "enough to explain to",
  "a  computer.  Art is",
  "everything  else  we",
  "do                  "
]
*/

using System;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.TextJustification
{
    public class Solution
    {
        public static IList<string> FullJustify(string[] words, int maxWidth)
        {
            List<string> result = new List<string>();
            int startIndex = 0;

            while (startIndex < words.Length)
            {
                int endIndex = GetEndIndex(words, startIndex, maxWidth);
                int spaceCount = endIndex - startIndex;

                StringBuilder line = new StringBuilder();

                if (spaceCount == 0 || endIndex == words.Length - 1)
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        line.Append(words[i]);
                        if (i < endIndex)
                        {
                            line.Append(' ');
                        }
                    }
                    line.Append(' ', maxWidth - line.Length);
                }
                else
                {
                    int totalSpaces = maxWidth - CalculateWordLength(words, startIndex, endIndex);
                    int spacesBetweenWords = totalSpaces / spaceCount;
                    int extraSpaces = totalSpaces % spaceCount;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        line.Append(words[i]);
                        if (i < endIndex)
                        {
                            int spaces = spacesBetweenWords + (extraSpaces > 0 ? 1 : 0);
                            line.Append(' ', spaces);
                            extraSpaces--;
                        }
                    }
                }

                result.Add(line.ToString());
                startIndex = endIndex + 1;
            }

            return result;
        }

        private static int GetEndIndex(string[] words, int startIndex, int maxWidth)
        {
            int endIndex = startIndex;
            int lineLength = words[startIndex].Length;

            while (endIndex + 1 < words.Length && lineLength + words[endIndex + 1].Length + 1 <= maxWidth)
            {
                endIndex++;
                lineLength += words[endIndex].Length + 1;
            }

            return endIndex;
        }

        private static int CalculateWordLength(string[] words, int startIndex, int endIndex)
        {
            int length = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                length += words[i].Length;
            }
            return length;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string[] words1 = new string[] { "This", "is", "an", "example", "of", "text", "justification." };
            int maxWidth1 = 16;
            IList<string> results1 = new List<string>
            {
                "This    is    an",
                "example  of text",
                "justification.  "
            };

            string[] words2 = new string[] { "What","must","be","acknowledgment","shall","be" };
            int maxWidth2 = 16;
            IList<string> results2 = new List<string>
            {
                "What   must   be",
                "acknowledgment  ",
                "shall be        "
            };

            string[] words3 = new string[] { "Science","is","what","we","understand","well","enough","to","explain","to","a","computer.","Art","is","everything","else","we","do" };
            int maxWidth3 = 20;
            IList<string> results3 = new List<string>
            {
                "Science  is  what we",
                "understand      well",
                "enough to explain to",
                "a  computer.  Art is",
                "everything  else  we",
                "do                  "
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<string>>(Solution.FullJustify(words1, maxWidth1), results1),
                ResultTester.CheckResult<IList<string>>(Solution.FullJustify(words2, maxWidth2), results2),
                ResultTester.CheckResult<IList<string>>(Solution.FullJustify(words3, maxWidth3), results3),
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Text Justification");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}