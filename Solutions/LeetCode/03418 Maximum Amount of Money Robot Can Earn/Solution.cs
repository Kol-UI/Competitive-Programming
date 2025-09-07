// Maximum Amount of Money Robot Can Earn
namespace CompetitiveProgramming.LeetCode.MaximumAmountofMoneyRobotCanEarn;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximumAmount(int[][] coins)
    {
        var aux = CreateAuxArray(coins);

        for (int i = 1; i < aux.Length; i++)
        {
            aux[i][0][2] = aux[i - 1][0][2] + coins[i][0];
        
            aux[i][0][1] = aux[i - 1][0][1] + coins[i][0];
            var aux1 = aux[i - 1][0][2];
            aux[i][0][1] = Math.Max(aux[i][0][1], aux1);
        
            aux[i][0][0] = aux[i - 1][0][0] + coins[i][0];
            var aux0 = aux[i - 1][0][1];
            aux[i][0][0] = Math.Max(aux[i][0][0], aux0);
        }

        for (int j = 1; j < aux[0].Length; j++)
        {
            aux[0][j][2] = aux[0][j - 1][2] + coins[0][j];
        
            aux[0][j][1] = aux[0][j - 1][1] + coins[0][j];
            var aux1 = aux[0][j - 1][2];
            aux[0][j][1] = Math.Max(aux[0][j][1], aux1);
        
            aux[0][j][0] = aux[0][j - 1][0] + coins[0][j];
            var aux0 = aux[0][j - 1][1];
            aux[0][j][0] = Math.Max(aux[0][j][0], aux0);
        }

        for (int i = 1; i < aux.Length; i++)
        {
            for (int j = 1; j < aux[i].Length; j++)
            {
                aux[i][j][2] = Math.Max(aux[i - 1][j][2], aux[i][j - 1][2]) + coins[i][j];
        
                aux[i][j][1] = Math.Max(aux[i - 1][j][1], aux[i][j - 1][1]) + coins[i][j];
                var aux1 = Math.Max(aux[i - 1][j][2], aux[i][j - 1][2]);
                aux[i][j][1] = Math.Max(aux[i][j][1], aux1);
        
                aux[i][j][0] = Math.Max(aux[i - 1][j][0], aux[i][j - 1][0]) + coins[i][j];
                var aux0 = Math.Max(aux[i - 1][j][1], aux[i][j - 1][1]);
                aux[i][j][0] = Math.Max(aux[i][j][0], aux0);
            }
        }
        var lastCell = aux[aux.Length - 1][aux[aux.Length - 1].Length - 1];
        var rs = Math.Max(Math.Max(lastCell[0], lastCell[1]), lastCell[1]);
        return rs;
    }
    
    private int[][][] CreateAuxArray(int[][] coins)
    {
        var rs = new int[coins.Length][][];
        for (int i = 0; i < rs.Length; i++)
        {
            rs[i] = new int[coins[i].Length][];
            for (int j = 0; j < rs[i].Length; j++)
            {
                rs[i][j] = new int[3];
            }
        }
        rs[0][0][0] = coins[0][0];
        rs[0][0][1] = Math.Max(coins[0][0], 0);
        rs[0][0][2] = coins[0][0];
        return rs;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Amount of Money Robot Can Earn");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}