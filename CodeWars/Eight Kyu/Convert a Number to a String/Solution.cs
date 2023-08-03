// We need a function that can transform a number (integer) into a string.
// What ways of achieving this do you know?

// Examples (input --> output):
// 123  --> "123"
// 999  --> "999"
// -100 --> "-100"

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.ConvertaNumbertoaString
{
	public class Solution
	{
        public static string NumberToString(int num)
        {
            return num.ToString();
        }
    }

    public class Test
    {
        public static bool[] TestConvertaNumbertoaString()
        {
            System.Random random = new System.Random();

            // Case 1
            int case1IntToString = 123;
            string Case1_IntToString_Result = Solution.NumberToString(case1IntToString);

            // Case 2
            int case2IntToString = 999;
            string Case2_IntToString_Result = Solution.NumberToString(case2IntToString);

            // Case 3
            int case3IntToString = -100;
            string Case3_IntToString_Result = Solution.NumberToString(case3IntToString);

            // Case 4
            int case4IntToString = 67;
            string Case4_IntToString_Result = Solution.NumberToString(case4IntToString);

            // Case 5
            int case5IntToString = 79585;
            string Case5_IntToString_Result = Solution.NumberToString(case5IntToString);

            // Case 6
            int case6IntToString = 1 + 2;
            string Case6_IntToString_Result = Solution.NumberToString(case6IntToString);

            // Case 7
            int case7IntToString = 1 - 2;
            string Case7_IntToString_Result = Solution.NumberToString(case7IntToString);

            // Case 8
            int case8IntToString = random.Next();
            string Case8_IntToString_Result = Solution.NumberToString(case8IntToString);

            // Case 9
            int case9IntToString = random.Next();
            string Case9_IntToString_Result = Solution.NumberToString(case9IntToString);

            // Case 10
            int case10IntToString = random.Next();
            string Case10_IntToString_Result = Solution.NumberToString(case10IntToString);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Case1_IntToString_Result, case1IntToString.ToString()),
                ResultTester.CheckResult<string>(Case2_IntToString_Result, case2IntToString.ToString()),
                ResultTester.CheckResult<string>(Case3_IntToString_Result, case3IntToString.ToString()),
                ResultTester.CheckResult<string>(Case4_IntToString_Result, case4IntToString.ToString()),
                ResultTester.CheckResult<string>(Case5_IntToString_Result, case5IntToString.ToString()),
                ResultTester.CheckResult<string>(Case6_IntToString_Result, case6IntToString.ToString()),
                ResultTester.CheckResult<string>(Case7_IntToString_Result, case7IntToString.ToString()),
                ResultTester.CheckResult<string>(Case8_IntToString_Result, case8IntToString.ToString()),
                ResultTester.CheckResult<string>(Case9_IntToString_Result, case9IntToString.ToString()),
                ResultTester.CheckResult<string>(Case10_IntToString_Result, case10IntToString.ToString()),

            };
            return results;
        }
    }
}