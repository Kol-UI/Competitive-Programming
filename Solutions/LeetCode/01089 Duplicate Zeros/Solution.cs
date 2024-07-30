// Duplicate Zeros

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DuplicateZeros
{
    public class Solution
    {
        public void DuplicateZeros(int[] arr)
        {
            int length = arr.Length;
            int possibleDups = 0;
            int lastIndex = length - 1;

            for (int i = 0; i <= lastIndex - possibleDups; i++)
            {
                if (arr[i] == 0)
                {
                    if (i == lastIndex - possibleDups)
                    {
                        arr[lastIndex] = 0;
                        lastIndex -= 1;
                        break;
                    }
                    possibleDups++;
                }
            }

            int newLength = lastIndex - possibleDups;

            for (int i = newLength; i >= 0; i--)
            {
                if (arr[i] == 0)
                {
                    arr[i + possibleDups] = 0;
                    possibleDups--;
                    arr[i + possibleDups] = 0;
                }
                else
                {
                    arr[i + possibleDups] = arr[i];
                }
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Duplicate Zeros");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}