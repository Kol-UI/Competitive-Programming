// Do Not Be Distracted

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.DoNotBeDistracted
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int t = int.Parse(Console.ReadLine()!);
            List<string> results = new List<string>();

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine()!);
                string tasks = Console.ReadLine()!;
                results.Add(IsSuspicious(tasks) ? "NO" : "YES");
            }

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        private static bool IsSuspicious(string tasks)
        {
            HashSet<char> seenTasks = new HashSet<char>();
            char lastTask = tasks[0];
            seenTasks.Add(lastTask);

            for (int i = 1; i < tasks.Length; i++)
            {
                if (tasks[i] != lastTask)
                {
                    if (seenTasks.Contains(tasks[i]))
                    {
                        return true;
                    }
                    seenTasks.Add(tasks[i]);
                    lastTask = tasks[i];
                }
            }

            return false;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Do Not Be Distracted");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}