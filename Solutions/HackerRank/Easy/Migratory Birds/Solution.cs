// Migratory Birds

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.HackerRank.MigratoryBirds
{
    class Result
    {
        public static int migratoryBirds(List<int> arr)
        {
            int[] counts = new int[6];
            foreach (int type in arr)
            {
                counts[type]++;
            }

            int maxCount = counts.Max();

            for (int i = 1; i < counts.Length; i++)
            {
                if (counts[i] == maxCount)
                {
                    return i;
                }
            }

            return -1;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Migratory Birds");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerRank, ProblemCategory.EasyHR);
        }
    }
}