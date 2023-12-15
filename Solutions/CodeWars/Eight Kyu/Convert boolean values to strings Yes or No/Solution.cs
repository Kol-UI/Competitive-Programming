using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.ConvertbooleanvaluestostringsYesorNo
{
	public class Solution
	{
        // Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.
        public static string boolToWord(bool word)
        {
            if (word == true)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        // Clever
        public static string boolToWordClever(bool word)
        {
            return word ? "Yes" : "No";
        }
    }

    public class Test
    {
        public static bool[] TestConvertbooleanvaluestostringsYesorNo()
        {
            // Case 1
            bool boolCase1 = false;
            string Case1_Result = CodeWars.EightKyu.ConvertbooleanvaluestostringsYesorNo.Solution.boolToWord(boolCase1);

            // Case 1
            bool boolCase2 = true;
            string Case2_Result = CodeWars.EightKyu.ConvertbooleanvaluestostringsYesorNo.Solution.boolToWord(boolCase2);

            // Case 3
            string Case3_Result = CodeWars.EightKyu.ConvertbooleanvaluestostringsYesorNo.Solution.boolToWordClever(boolCase1);

            // Case 4
            string Case4_Result = CodeWars.EightKyu.ConvertbooleanvaluestostringsYesorNo.Solution.boolToWordClever(boolCase2);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Case1_Result, "No"),
                ResultTester.CheckResult<string>(Case2_Result, "Yes"),
                ResultTester.CheckResult<string>(Case3_Result, "No"),
                ResultTester.CheckResult<string>(Case4_Result, "Yes"),
            };
            return results;
        }
    }
}