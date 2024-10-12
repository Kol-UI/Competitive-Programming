// Divide Intervals Into Minimum Number of Groups

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DivideIntervalsIntoMinimumNumberofGroups
{
    public class Solution
    {
        public int MinGroups(int[][] intervals)
        {
        int max = 0; 
            foreach (var inter in intervals){
                max = Math.Max(max, inter[1]);
            }

            int[] line =new int[max+2];
            foreach (var inter in intervals){
                line[inter[0]]++;
                line[inter[1] + 1]--;
            }
            int maxOverlap = 0;
            int currOverlap = 0;
            for (int i = 0; i < line.Length; i++){
                currOverlap += line[i];
                maxOverlap = Math.Max(maxOverlap, currOverlap);
            }

            return maxOverlap;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Divide Intervals Into Minimum Number of Groups");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}