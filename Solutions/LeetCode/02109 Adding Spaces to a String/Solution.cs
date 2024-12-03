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
            int writePos = 0;
            int readPos = 0;
            
            foreach (int spacePos in spaces)
            {
                while (readPos < spacePos)
                {
                    result[writePos++] = s[readPos++];
                }
                result[writePos++] = ' ';
            }
            
            while (readPos < s.Length)
            {
                result[writePos++] = s[readPos++];
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