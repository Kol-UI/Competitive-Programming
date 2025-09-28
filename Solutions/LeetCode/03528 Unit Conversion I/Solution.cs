// Unit Conversion I
namespace CompetitiveProgramming.CodeForces.UnitConversionI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] BaseUnitConversions(int[][] conversions)
    {
         var dic = CreateAuxiliaryDictionary(conversions);
         var level = new List<int> { 0 };
         var rs = new int[conversions.Length + 1];
         rs[0] = 1;
         while (level.Count > 0)
         {
             var level2 = new List<int>();
             for (int i = 0; i < level.Count; i++)
             {
                 if (dic.ContainsKey(level[i]))
                 {
                     for (int j = 0; j < dic[level[i]].Count; j++)
                     {
                         var target = dic[level[i]][j][0];
                         rs[target] = (int)(dic[level[i]][j][1] * (long)rs[level[i]]% 1_000_000_007);
                         level2.Add(target);
                     }
                 }
             }
             level = level2;
         }
         return rs;
    }

    private Dictionary<int, List<int[]>> CreateAuxiliaryDictionary(int[][] conversions)
    {
        var rs = new Dictionary<int, List<int[]>>();
        for (int i = 0; i < conversions.Length; i++)
        {
            if (!rs.ContainsKey(conversions[i][0]))
            {
                rs.Add(conversions[i][0], new List<int[]> { new[] { conversions[i][1], conversions[i][2] } });
            }
            else
            {
                rs[conversions[i][0]].Add(new[] { conversions[i][1], conversions[i][2] } );
            }
        }
        return rs;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Unit Conversion I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}