// Distribute Candies to People

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DistributeCandiestoPeople
{
    public class Solution
    {
        public static int[] DistributeCandies(int candies, int num_people)
        {
            int[] result = new int[num_people];
            int personPosition = 1;
            int iteration = 1;
            int candyToGive = 0;

            while (candies > 0)
            {
                candyToGive = (iteration - 1) * num_people + personPosition;
                candyToGive = candyToGive >= candies ? candies : candyToGive;

                result[personPosition - 1] += candyToGive; 
                candies -= candyToGive;
                personPosition++;

                if (personPosition > num_people)
                {
                    personPosition = 1;
                    iteration++;
                }
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.DistributeCandies(7, 4), new int[]{1,2,3,1}),
                ResultTester.CheckResult<int[]>(Solution.DistributeCandies(10, 3), new int[]{5,2,3}),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1103");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}