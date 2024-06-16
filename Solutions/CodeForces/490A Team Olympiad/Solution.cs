// Team Olympiad

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.TeamOlympiad
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] skills = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            List<int> programmers = new List<int>();
            List<int> mathematicians = new List<int>();
            List<int> athletes = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (skills[i] == 1)
                    programmers.Add(i + 1);
                else if (skills[i] == 2)
                    mathematicians.Add(i + 1);
                else if (skills[i] == 3)
                    athletes.Add(i + 1);
            }

            int teamsCount = Math.Min(programmers.Count, Math.Min(mathematicians.Count, athletes.Count));

            Console.WriteLine(teamsCount);
            for (int i = 0; i < teamsCount; i++)
            {
                Console.WriteLine($"{programmers[i]} {mathematicians[i]} {athletes[i]}");
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Team Olympiad");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}