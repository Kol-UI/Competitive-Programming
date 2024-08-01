// Repeated DNA Sequences

/*
The DNA sequence is composed of a series of nucleotides abbreviated as 'A', 'C', 'G', and 'T'.

For example, "ACGAATTCCG" is a DNA sequence.
When studying DNA, it is useful to identify repeated sequences within the DNA.

Given a string s that represents a DNA sequence, return all the 10-letter-long sequences (substrings) that occur more than once in a DNA molecule. You may return the answer in any order.

 

Example 1:

Input: s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT"
Output: ["AAAAACCCCC","CCCCCAAAAA"]

Example 2:

Input: s = "AAAAAAAAAAAAA"
Output: ["AAAAAAAAAA"]
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RepeatedDNASequences
{
    public class Solution
    {
        public static IList<string> FindRepeatedDnaSequences(string s)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for(int i = 0; i < s.Length - 9; i++)
            {
                string key = s.Substring(i, 10);

                if (dict.ContainsKey(key))
                    dict[key]++;

                else
                    dict.Add(key, 1);
            }

            IList<string> result = new List<string>();
            
            foreach(var item in dict)
            {
                if(item.Value > 1)
                {
                    result.Add(item.Key);
                }
            }
            
            return result; 
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            IList<string> result1 = new List<string>
            {
                "AAAAACCCCC",
                "CCCCCAAAAA"
            };

            IList<string> result2 = new List<string>
            {
                "AAAAAAAAAA",
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<string>>(Solution.FindRepeatedDnaSequences("AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT"), result1),
                ResultTester.CheckResult<IList<string>>(Solution.FindRepeatedDnaSequences("AAAAAAAAAAAAA"), result2),
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Repeated DNA Sequences");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}