// Opposites Attract

/*
Timmy & Sarah think they are in love, but around where they live, they will only know once they pick a flower each. If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.

Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.
*/
using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.OppositesAttract
{
    public class Solution
    {
        public static bool lovefunc1(int flower1, int flower2)
        { 
            // Check if one flower has an even number of petals and the other has an odd number of petals
            return (flower1 % 2 == 0 && flower2 % 2 != 0) || (flower1 % 2 != 0 && flower2 % 2 == 0);
        }

        public static bool lovefunc2(int flower1, int flower2)
        { 
            return flower1 % 2 != flower2 % 2 ;
        }

        public static bool lovefunc3(int flower1, int flower2)
        { 
            return (flower1 + flower2) % 2 == 1;
        }
    }

    public class Test
    {
        public static bool[] TestOppositesAttract()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.lovefunc1(1,4), true),
                ResultTester.CheckResult<bool>(Solution.lovefunc1(2,2), false),
                ResultTester.CheckResult<bool>(Solution.lovefunc1(0,1), true),
                ResultTester.CheckResult<bool>(Solution.lovefunc1(0,0), false),
                ResultTester.CheckResult<bool>(Solution.lovefunc1(5,5), false),
                ResultTester.CheckResult<bool>(Solution.lovefunc2(1,4), true),
                ResultTester.CheckResult<bool>(Solution.lovefunc2(2,2), false),
                ResultTester.CheckResult<bool>(Solution.lovefunc2(0,1), true),
                ResultTester.CheckResult<bool>(Solution.lovefunc2(0,0), false),
                ResultTester.CheckResult<bool>(Solution.lovefunc2(5,5), false),
                ResultTester.CheckResult<bool>(Solution.lovefunc3(1,4), true),
                ResultTester.CheckResult<bool>(Solution.lovefunc3(2,2), false),
                ResultTester.CheckResult<bool>(Solution.lovefunc3(0,1), true),
                ResultTester.CheckResult<bool>(Solution.lovefunc3(0,0), false),
                ResultTester.CheckResult<bool>(Solution.lovefunc3(5,5), false),
            };

            Random rnd = new Random();

            // Loop Tests

            for (int i = 0; i < 100; i++)
            {
                int flower1 = rnd.Next(100);
                int flower2 = rnd.Next(100);
                bool expected = flower1 % 2 != flower2 % 2;
                bool rndResult = ResultTester.CheckResult<bool>(Solution.lovefunc1(flower1, flower2), expected);
                results.Append(rndResult);
            }

            for (int i = 0; i < 100; i++)
            {
                int flower1 = rnd.Next(100);
                int flower2 = rnd.Next(100);
                bool expected = flower1 % 2 != flower2 % 2;
                bool rndResult = ResultTester.CheckResult<bool>(Solution.lovefunc2(flower1, flower2), expected);
                results.Append(rndResult);
            }

            for (int i = 0; i < 100; i++)
            {
                int flower1 = rnd.Next(100);
                int flower2 = rnd.Next(100);
                bool expected = flower1 % 2 != flower2 % 2;
                bool rndResult = ResultTester.CheckResult<bool>(Solution.lovefunc3(flower1, flower2), expected);
                results.Append(rndResult);
            }
            
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Opposites Attract");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestOppositesAttract());
        }
    }
}