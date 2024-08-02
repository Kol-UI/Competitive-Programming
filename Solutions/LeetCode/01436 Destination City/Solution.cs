// Destination City



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DestinationCity
{
    public class Solution
    {
        public static string DestCity(IList<IList<string>> paths)
        {
            HashSet<string> set = new();

            for(int i = 0; i < paths.Count; i++)
            {
                set.Add(paths[i][1]);
            }
            
            for(int i = 0; i < paths.Count; i++)
            {
                if(set.Contains(paths[i][0]))
                {
                    set.Remove(paths[i][0]);
                }
            }
            
            return set.FirstOrDefault()!;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            IList<IList<string>> paths1 = new List<IList<string>>()
            {
                new List<string>() { "London", "New York" },
                new List<string>() { "New York", "Lima" },
                new List<string>() { "Lima", "Sao Paulo" }
            };

            IList<IList<string>> paths2 = new List<IList<string>>()
            {
                new List<string>() { "B", "C" },
                new List<string>() { "D", "B" },
                new List<string>() { "C", "A" }
            };

            IList<IList<string>> paths3 = new List<IList<string>>()
            {
                new List<string>() { "A", "Z" }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.DestCity(paths1), "Sao Paulo"),
                ResultTester.CheckResult<string>(Solution.DestCity(paths2), "A"),
                ResultTester.CheckResult<string>(Solution.DestCity(paths3), "Z"),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Destination City");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}