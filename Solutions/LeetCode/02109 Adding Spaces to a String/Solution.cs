// Adding Spaces to a String

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AddingSpacestoaString
{
    public class Solution
    {
        public string AddSpaces(string s, int[] spaces)
        {
            char[] result = new char[s.Length + spaces.Length];
            int left = 0;
            int right = 0;

            foreach (int spacePos in spaces)
            {
                while (left < spacePos)
                {
                    result[right++] = s[left++];
                }
                result[right++] = ' ';
            }

            while (left < s.Length)
            {
                result[right++] = s[left++];
            }

            return new string(result);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Adding Spaces to a String");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}