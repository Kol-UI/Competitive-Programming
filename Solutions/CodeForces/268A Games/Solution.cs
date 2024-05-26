// 268A - Games



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.Games
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            int n = int.Parse(Console.ReadLine()!);

            Dictionary<int, int> home = new();
            Dictionary<int, int> away = new();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                int homeColor = int.Parse(input[0]);
                int awayColor = int.Parse(input[1]);

                if (!home.ContainsKey(homeColor))
                {
                    home[homeColor] = 0;
                }

                home[homeColor]++;

                if (!away.ContainsKey(awayColor))
                {
                    away[awayColor] = 0;
                }

                away[awayColor]++;
            }

            int count = 0;

            foreach (var pair in home)
            {
                if (away.ContainsKey(pair.Key))
                {
                    count += pair.Value * away[pair.Key];
                }
            }

            Console.WriteLine(count);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Games");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}