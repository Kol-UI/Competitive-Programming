// Find Intersection

/*
Have the function FindIntersection(strArr) read the array of strings stored in strArr which will contain 2 elements: the first element will represent a list of comma-separated numbers sorted in ascending order, the second element will represent a second list of comma-separated numbers (also sorted). Your goal is to return a comma-separated string containing the numbers that occur in elements of strArr in sorted order. If there is no intersection, return the string false.
*/

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CoderByte.FindIntersection
{
    class MainClass
    {
        public static string FindIntersection(string[] strArr)
        {
            int[] arr1 = strArr[0].Split(',').Select(int.Parse).ToArray();
            int[] arr2 = strArr[1].Split(',').Select(int.Parse).ToArray();

            var intersection = arr1.Intersect(arr2);

            string result = string.Join(",", intersection);

            return result.Any() ? result : "false";
        }
    }

    // TEST
    public class Test
    {
        public static bool[] TestCases()
        {
            string[] Case1 = {"1, 3, 4, 7, 13", "1, 2, 4, 13, 15"};
            string[] Case2 = {"1, 3, 9, 10, 17, 18", "1, 4, 9, 10"};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(MainClass.FindIntersection(Case1), "1,4,13"),
                ResultTester.CheckResult<string>(MainClass.FindIntersection(Case2), "1,9,10"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Intersection");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CoderByte, ProblemCategory.EasyCB, Test.TestCases());
        }
    }
}