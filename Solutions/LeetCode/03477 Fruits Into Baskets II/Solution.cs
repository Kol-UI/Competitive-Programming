// Fruits Into Baskets II
namespace CompetitiveProgramming.LeetCode.FruitsIntoBasketsII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
    {
        int placed = 0;
        bool[] vis = new bool[baskets.Length];

        for(int i = 0; i < fruits.Length; i++)
        {
            for(int j = 0 ; j < baskets.Length; j++)
            {
                if(baskets[j] >= fruits[i] && vis[j] == false)
                {
                    placed++;
                    vis[j] = true;
                    break;
                }
            }
        }
        return fruits.Length - placed;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Fruits Into Baskets II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}