using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.EvenorOdd
{
	public class Solution
	{
        // Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
        public static string EvenOrOdd(int number)
        {
            if(number %2 == 0)
            {
                Console.WriteLine("Number {0} is even", number);
                return "Even";
            }
            else
            {
                Console.WriteLine("Number {0} is odd", number);
                return "Odd";
            }
        }
    }

    public class Test
    {
        public static bool[] TestEvenorOdd()
        {
            System.Random random = new System.Random();

            // Case 1
            int case1IntEvenOrOdd = 2;
            string Case1_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case1IntEvenOrOdd);

            // Case 2
            int case2IntEvenOrOdd = 0;
            string Case2_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case2IntEvenOrOdd);

            // Case 3
            int case3IntEvenOrOdd = 1;
            string Case3_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case3IntEvenOrOdd);

            // Case 4
            int case4IntEvenOrOdd = 7;
            string Case4_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case4IntEvenOrOdd);

            // Case 5
            int case5IntEvenOrOdd = -1;
            string Case5_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case5IntEvenOrOdd);

            // Case 6
            int case6IntEvenOrOdd = 1545452;
            string Case6_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case6IntEvenOrOdd);

            // Case 7
            int case7IntEvenOrOdd = 17;
            string Case7_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case7IntEvenOrOdd);

            // Case 8
            int case8IntEvenOrOdd = 78;
            string Case8_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case8IntEvenOrOdd);

            // Case 9
            int case9IntEvenOrOdd = -123;
            string Case9_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case9IntEvenOrOdd);

            // Case 10
            int case10IntEvenOrOdd = -456;
            string Case10_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case10IntEvenOrOdd);

            // Case 11
            int case11IntEvenOrOdd = 74156741;
            string Case11_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case11IntEvenOrOdd);

            // Case 12
            int case12IntEvenOrOdd = random.Next(1, 10);
            string Case12_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case12IntEvenOrOdd);

            // Case 13
            int case13IntEvenOrOdd = random.Next(1, 100);
            string Case13_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case13IntEvenOrOdd);

            // Case 14
            int case14IntEvenOrOdd = random.Next();
            string Case14_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case14IntEvenOrOdd);

            // Case 15
            int case15IntEvenOrOdd = random.Next();
            string Case15_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case15IntEvenOrOdd);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Case1_EvenOrOdd_Result, Case1_EvenOrOdd_Result),
                ResultTester.CheckResult<string>(Case2_EvenOrOdd_Result, Case2_EvenOrOdd_Result),
                ResultTester.CheckResult<string>(Case3_EvenOrOdd_Result, Case3_EvenOrOdd_Result),
                ResultTester.CheckResult<string>(Case4_EvenOrOdd_Result, Case4_EvenOrOdd_Result),
                ResultTester.CheckResult<string>(Case5_EvenOrOdd_Result, Case5_EvenOrOdd_Result),
                ResultTester.CheckResult<string>(Case6_EvenOrOdd_Result, Case6_EvenOrOdd_Result),
                ResultTester.CheckResult<string>(Case7_EvenOrOdd_Result, Case7_EvenOrOdd_Result),
                ResultTester.CheckResult<string>(Case8_EvenOrOdd_Result, Case8_EvenOrOdd_Result),
                ResultTester.CheckResult<string>(Case9_EvenOrOdd_Result, Case9_EvenOrOdd_Result),
                ResultTester.CheckResult<string>(Case10_EvenOrOdd_Result, Case10_EvenOrOdd_Result),
                ResultTester.CheckResult<string>(Case11_EvenOrOdd_Result, Case11_EvenOrOdd_Result),
                ResultTester.CheckResult<string>(Case12_EvenOrOdd_Result, Case12_EvenOrOdd_Result),
                ResultTester.CheckResult<string>(Case13_EvenOrOdd_Result, Case13_EvenOrOdd_Result),
                ResultTester.CheckResult<string>(Case14_EvenOrOdd_Result, Case14_EvenOrOdd_Result),
                ResultTester.CheckResult<string>(Case15_EvenOrOdd_Result, Case15_EvenOrOdd_Result),
            };
            return results;
        }
    }
}