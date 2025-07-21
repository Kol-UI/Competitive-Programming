// Separate Squares I
namespace CompetitiveProgramming.LeetCode.SeparateSquaresI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private double GetValid(double baseLine, int[][] squares)
    {
        double areaU = 0, areaB = 0;
        foreach(int[] sq in squares)
        {
            int y = sq[1], size = sq[2];
            double area = (double)size*size;

            if(baseLine <= y)
                areaU += area;
            else if(baseLine >= y+size)
                areaB += area;
            else
            {
                double abovePart = (y+size)-baseLine;
                double belowPart = baseLine-y;
                areaU += abovePart*size;
                areaB += belowPart *size;
            }
        }

        return areaU-areaB;
    }
    public double SeparateSquares(int[][] squares) {
        double low = 0, high = 2 * Math.Pow(10, 9);
        double delta = 1/Math.Pow(10, 9);

        for(int i = 0; i < 100; i ++)
        {
            double mid = (low+high)*0.5;
            double diff = GetValid(mid, squares);
            if(diff > delta)
                low = mid;
            else
                high = mid;
        }

        return high;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Separate Squares I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}