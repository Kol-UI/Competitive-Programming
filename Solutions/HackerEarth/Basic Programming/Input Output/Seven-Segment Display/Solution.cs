// Seven-Segment Display
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.SevenSegmentDisplay
{
    class Solution
    {
        //static void Main()
        static void MainSolution()
        {
            var d = new System.Collections.Generic.Dictionary<char, int>
            {
                {'0', 6},
                {'1', 2},
                {'2', 5},
                {'3', 5},
                {'4', 4},
                {'5', 5},
                {'6', 6},
                {'7', 3},
                {'8', 7},
                {'9', 6}
            };

            int t = int.Parse(Console.ReadLine()!);

            for (int _ = 0; _ < t; _++)
            {
                string n = Console.ReadLine()!;
                int noOfMatchstick = 0;

                foreach (char digit in n)
                {
                    noOfMatchstick += d[digit];
                }

                string number = "";

                if (noOfMatchstick % 2 == 0)
                {
                    int x = noOfMatchstick / 2;
                    for (int i = 0; i < x; i++)
                    {
                        number += "1";
                    }
                }
                else
                {
                    int x = (noOfMatchstick - 3) / 2;
                    number = "7";
                    for (int i = 0; i < x; i++)
                    {
                        number += "1";
                    }
                }

                Console.WriteLine(number);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Seven-Segment Display");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}