// Lexicographically Smallest String After a Swap

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LexicographicallySmallestStringAfteraSwap
{
    public class Solution
    {
        public string GetSmallestString(string s)
        {
            var evenDigits = new HashSet<char> { '0', '2', '4', '6', '8' };
            var oddDigits = new HashSet<char> { '1', '3', '5', '7', '9' };

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (HasSameParity(s[i], s[i + 1], evenDigits, oddDigits) && ShouldSwap(s[i], s[i + 1]))
                {
                    return SwapCharacters(s, i);
                }
            }

            return s;
        }

        private bool ShouldSwap(char ch0, char ch1)
        {
            return ch0 > ch1;
        }

        private bool HasSameParity(char ch0, char ch1, HashSet<char> evenDigits, HashSet<char> oddDigits)
        {
            return (evenDigits.Contains(ch0) && evenDigits.Contains(ch1)) ||
                (oddDigits.Contains(ch0) && oddDigits.Contains(ch1));
        }

        private string SwapCharacters(string s, int index)
        {
            return s.Substring(0, index) + s[index + 1] + s[index] + s.Substring(index + 2);
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Lexicographically Smallest String After a Swap");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}