// Length of Longest V-Shaped Diagonal Segment
namespace CompetitiveProgramming.LeetCode.LengthofLongestVShapedDiagonalSegment;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public int LenOfVDiagonal(int[][] grid) 
    {
        int n=grid.Length, m=grid[0].Length, maxScore=-1, maxPossible=Math.Max(n, m)-1;
        for(int y=0; y<n; y++)
        {
            var row=grid[y];
            for(int x=0; x<m; x++)
            {
                if(row[x]==1)
                {
                    for(int d=0, dy=1, dx=1;;)
                    {
                        int score=Score(y, x, dy, dx);
                        if(score>maxScore) if(score==maxPossible) return 1+score; else maxScore=score;
                        if(++d==4) break;
                        (dy, dx)=(dx, -1*dy);
                    }
                }
            }
        }
        return 1+maxScore;

        int Score(int y, int x, int dy, int dx, bool canTurn=true, int z=2)
        {
            y+=dy; if(y<0 || y>=n) return 0;
            x+=dx; if(x<0 || x>=m || grid[y][x]!=z) return 0;
            int score=Score(y, x, dy, dx, canTurn, 2-z);
            if(canTurn)
            {
                score=Math.Max(score, Score(y, x, dx, -1*dy, false, 2-z));
            }
            return 1+score;
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Length of Longest V-Shaped Diagonal Segment");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}