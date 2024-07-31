// Remove All Adjacent Duplicates In String

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RemoveAllAdjacentDuplicatesInString
{
    public class Solution 
    {
        public string RemoveDuplicates(string input) 
        {
            StringBuilder result = new StringBuilder();

            foreach (char currentChar in input) 
            {
                if (result.Length > 0 && result[result.Length - 1] == currentChar) 
                {
                    result.Length--;
                }
                else 
                {
                    result.Append(currentChar);
                }
            }

            return result.ToString();
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove All Adjacent Duplicates In String");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}