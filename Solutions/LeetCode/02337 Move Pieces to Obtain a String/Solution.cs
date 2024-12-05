// Move Pieces to Obtain a String

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MovePiecestoObtainaString
{
    public class Solution
    {
        public bool CanChange(string start, string target)
        {
            int left = 0, right = 0;
            int n = start.Length;

            while (left < n || right < n)
            {
                while (left < n && start[left] == '_') left++;
                while (right < n && target[right] == '_') right++;

                if (left == n || right == n)
                    return left == right;

                if (start[left] != target[right])
                    return false;

                if ((start[left] == 'R' && left > right) || (start[left] == 'L' && left < right))
                    return false;

                left++;
                right++;
            }

            return true;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Move Pieces to Obtain a String");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}