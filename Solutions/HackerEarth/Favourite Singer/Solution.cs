// Favourite Singer

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.FavouriteSinger
{
    public class Test
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            long n = long.Parse(Console.ReadLine()!);
            long[] songIds = Console.ReadLine()!.TrimEnd().Split(' ').Select(long.Parse).ToArray();
            var result = CountMostFrequentSongs(songIds);
            Console.WriteLine(result);
        }

        private static int CountMostFrequentSongs(long[] songs)
        {
            var frequency = new Dictionary<long, int>();
            foreach (var song in songs)
            {
                if (frequency.ContainsKey(song))
                {
                    frequency[song]++;
                }
                else
                {
                    frequency[song] = 1;
                }
            }

            int maxCount = frequency.Values.Max();
            return frequency.Count(kvp => kvp.Value == maxCount);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Favourite Singer");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}