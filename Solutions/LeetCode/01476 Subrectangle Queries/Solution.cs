// Subrectangle Queries
namespace CompetitiveProgramming.LeetCode.SubrectangleQueries;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class SubrectangleQueries
{
    private int[][] rectangle = new int[][] { };

    public SubrectangleQueries(int[][] rectangle)
    {
        this.rectangle = rectangle;
    }

    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
    {
        for (int i = row1; i <= row2; i++)
        {
            for (int j = col1; j <= col2; j++)
            {
                rectangle[i][j] = newValue;
            }
        }
    }

    public int GetValue(int row, int col) => rectangle[row][col];
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Subrectangle Queries");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}