// Maximum Average Pass Ratio

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumAveragePassRatio
{
    public class Solution
    {
        public double MaxAverageRatio(int[][] classes, int extraStudents)
        {
            var totalClasses = classes.Length;
            var queue = new PriorityQueue<(double pass, double total), double>();

            foreach (var cls in classes)
            {
                queue.Enqueue((cls[0], cls[1]), PassRatio(cls[0], cls[1]));
            }

            while (extraStudents-- > 0)
            {
                var (pass, total) = queue.Dequeue();
                queue.Enqueue((pass + 1, total + 1), PassRatio(pass + 1, total + 1));
            }

            double sum = 0;

            while (queue.Count > 0)
            {
                var (pass, total) = queue.Dequeue();
                sum += pass / total;
            }

            return sum / totalClasses;
        }

        public double PassRatio(double pass, double total)
        {
            return pass / total - (pass + 1) / (total + 1);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Average Pass Ratio");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}