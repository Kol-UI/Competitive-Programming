// Design Neighbor Sum Service
namespace CompetitiveProgramming.LeetCode.DesignNeighborSumService;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

#pragma warning disable CS8625
public class NeighborSum
{
    int[][] gridCopy = null;
    int dimension = 0;

    public NeighborSum(int[][] grid)
    {
        gridCopy = grid;
        dimension = gridCopy.GetLength(0);
    }

    public int AdjacentSum(int value)
    {
        (int, int) valueLocation = ValueLocation(value);

        (int, int) leftLocation = (valueLocation.Item1 - 1, valueLocation.Item2);
        (int, int) rightLocation = (valueLocation.Item1 + 1, valueLocation.Item2);
        (int, int) topLocation = (valueLocation.Item1, valueLocation.Item2 - 1);
        (int, int) bottomLocation = (valueLocation.Item1, valueLocation.Item2 + 1);

        int result = 0;

        if (ValidateLocation(leftLocation))
        {
            result += ValueAtLocation(leftLocation);
        }
        if (ValidateLocation(rightLocation))
        {
            result += ValueAtLocation(rightLocation);
        }
        if (ValidateLocation(topLocation))
        {
            result += ValueAtLocation(topLocation);
        }
        if (ValidateLocation(bottomLocation))
        {
            result += ValueAtLocation(bottomLocation);
        }

        return result;
    }

    public int DiagonalSum(int value)
    {
        (int, int) valueLocation = ValueLocation(value);

        (int, int) topLeftLocation = (valueLocation.Item1 - 1, valueLocation.Item2 - 1);
        (int, int) topRightLocation = (valueLocation.Item1 + 1, valueLocation.Item2 - 1);
        (int, int) bottomLeftLocation = (valueLocation.Item1 - 1, valueLocation.Item2 + 1);
        (int, int) bottomRightLocation = (valueLocation.Item1 + 1, valueLocation.Item2 + 1);

        int result = 0;

        if (ValidateLocation(topLeftLocation))
        {
            result += ValueAtLocation(topLeftLocation);
        }
        if (ValidateLocation(topRightLocation))
        {
            result += ValueAtLocation(topRightLocation);
        }
        if (ValidateLocation(bottomLeftLocation))
        {
            result += ValueAtLocation(bottomLeftLocation);
        }
        if (ValidateLocation(bottomRightLocation))
        {
            result += ValueAtLocation(bottomRightLocation);
        }

        return result;
    }

    public (int, int) ValueLocation(int value)
    {
        for (int i = 0; i < dimension; i++)
        {
            for (int j = 0; j < dimension; j++)
            {
                int currentLocationValue = gridCopy[i][j];
                if (currentLocationValue == value)
                {
                    return (i, j);
                }
            }
        }

        throw new Exception();
    }

    public bool ValidateLocation((int, int) location)
    {
        if (location.Item1 >= 0 && location.Item1 < dimension
            && location.Item2 >= 0 && location.Item2 < dimension)
        {
            return true;
        }

        return false;
    }

    public int ValueAtLocation((int, int) location)
    {
        return gridCopy[location.Item1][location.Item2];
    }
}
#pragma warning restore CS8625
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Design Neighbor Sum Service");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}