// Filling Bookcase Shelves

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FillingBookcaseShelves
{
    public class Solution 
    {
        public int MinHeightShelves(int[][] books, int shelfWidth) 
        {
            int numberOfBooks = books.Length;
            int[] minHeightForBooks = new int[numberOfBooks + 1];
            Array.Fill(minHeightForBooks, int.MaxValue);
            minHeightForBooks[0] = 0;

            for (int i = 1; i <= numberOfBooks; i++) 
            {
                int currentShelfWidth = 0;
                int currentMaxHeight = 0;

                for (int j = i; j > 0; j--) 
                {
                    int bookWidth = books[j - 1][0];
                    int bookHeight = books[j - 1][1];

                    currentShelfWidth += bookWidth;

                    if (currentShelfWidth > shelfWidth)
                    {
                        break;
                    }

                    currentMaxHeight = Math.Max(currentMaxHeight, bookHeight);
                    minHeightForBooks[i] = Math.Min(minHeightForBooks[i], minHeightForBooks[j - 1] + currentMaxHeight);
                }
            }

            return minHeightForBooks[numberOfBooks];
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Filling Bookcase Shelves");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}