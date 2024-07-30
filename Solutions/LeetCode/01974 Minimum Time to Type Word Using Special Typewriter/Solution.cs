// Minimum Time to Type Word Using Special Typewriter

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumTimetoTypeWordUsingSpecialTypewriter
{
    public class Solution
    {
        public int MinTimeToType(string word)
        {
            int totalTime = 0;
            char currentChar = 'a';

            foreach (char targetChar in word)
            {
                totalTime += GetTimeToMove(currentChar, targetChar);
                currentChar = targetChar;
            }

            return totalTime + word.Length;
        }

        private int GetTimeToMove(char from, char to)
        {
            int distance = Math.Abs(from - to);
            return Math.Min(distance, 26 - distance);
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Time to Type Word Using Special Typewriter");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}