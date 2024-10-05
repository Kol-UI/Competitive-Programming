// Clear Digits

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ClearDigits
{
    public class Solution
    {
        public string ClearDigits(string s)
        {
            List<char> charList = s.ToList();
            
            while (ContainsDigit(charList))
            {
                RemoveDigitAndLeftCharacter(charList);
            }

            return new string(charList.ToArray());
        }

        private bool ContainsDigit(List<char> charList)
        {
            return charList.Any(c => char.IsDigit(c));
        }

        private void RemoveDigitAndLeftCharacter(List<char> charList)
        {
            for (int i = 0; i < charList.Count; i++)
            {
                if (char.IsDigit(charList[i]))
                {
                    int nonDigitIndex = FindClosestNonDigitToLeft(charList, i);
                    
                    charList.RemoveAt(i);

                    if (nonDigitIndex != -1)
                    {
                        charList.RemoveAt(nonDigitIndex);
                    }

                    break;
                }
            }
        }

        private int FindClosestNonDigitToLeft(List<char> charList, int digitIndex)
        {
            for (int i = digitIndex - 1; i >= 0; i--)
            {
                if (!char.IsDigit(charList[i]))
                {
                    return i;
                }
            }
            return -1;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Clear Digits");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}