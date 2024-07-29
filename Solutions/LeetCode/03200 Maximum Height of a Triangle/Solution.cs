// Maximum Height of a Triangle

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumHeightofaTriangle
{
    public class Solution
    {
        public int MaxHeightOfTriangle(int red, int blue)
        {
            return Math.Max(CalculateMaxHeight(red, blue), CalculateMaxHeight(blue, red));
        }

        private int CalculateMaxHeight(int primaryColor, int secondaryColor)
        {
            int height = 0;
            int rowCount = 1;
            bool usePrimaryColor = true;

            while (true)
            {
                if (usePrimaryColor)
                {
                    if (primaryColor < rowCount) break;
                    primaryColor -= rowCount;
                }
                else
                {
                    if (secondaryColor < rowCount) break;
                    secondaryColor -= rowCount;
                }

                height++;
                rowCount++;
                usePrimaryColor = !usePrimaryColor;
            }

            return height;
        }
    }
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Height of a Triangle");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}