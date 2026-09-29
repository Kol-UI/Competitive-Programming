// Check if There Is a Valid Parentheses String Path
namespace CompetitiveProgramming.LeetCode.CheckifThereIsaValidParenthesesStringPath;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool HasValidPath(char[][] grid)
    {
     	int n = grid.Length;
		int m = grid[0].Length;
		int tp = n + m - 2;

		if(tp % 2 == 0 | grid[0][0] == ')' | grid[n-1][m-1] == '(')
			return false;
		List<List<List<int>>> matrix = new List<List<List<int>>>();
		for(int i = 0; i < n; i++)
		{
			List<List<int>> a = new List<List<int>>();
			for(int j = 0; j < m; j++)
			{
				List<int> b = new List<int>();
				a.Add(b);
			}
			matrix.Add(a);
		}
		matrix[0][0].Add(1);
		int steps = 1;
		while(steps <= tp)
		{
			int i = steps < (n - 1) ? steps : n - 1; 
			int j = steps - i; 
			int maxSteps = tp - steps;
			for(;i >= 0 & j < m;)
			{

				int addy = grid[i][j] == '(' ? 1 : -1;
				if(i > 0)
				{
					foreach(int num in matrix[i-1][j])
					{
						int endnum = num + addy;
						if(endnum >= 0 & endnum <= maxSteps & !matrix[i][j].Contains(endnum))
						{
							matrix[i][j].Add(endnum);
						}
					}
				}
				if(j > 0)
				{
					foreach(int num in matrix[i][j-1])
					{
						int endnum = num + addy;
						if(endnum >= 0 & endnum <= maxSteps & !matrix[i][j].Contains(endnum))
						{
							matrix[i][j].Add(endnum);
						}
					}
				}
				i--; j++;
			}
			steps++;
		}
		return matrix[n-1][m-1].Contains(0); 
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if There Is a Valid Parentheses String Path");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}