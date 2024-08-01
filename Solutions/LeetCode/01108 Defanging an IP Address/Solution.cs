using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DefanginganIPAddress
{
	public class Solution
    {
        // Given a valid (IPv4) IP address, return a defanged version of that IP address.
        // A defanged IP address replaces every period "." with "[.]".

        // Example 1:

        // Input: address = "1.1.1.1"
        // Output: "1[.]1[.]1[.]1"
        
        // Example 2:

        // Input: address = "255.100.50.0"
        // Output: "255[.]100[.]50[.]0"

        public static string DefangIPaddr(string address)
        {
            string result = "";
            for(int i = 0; i < address.Length; i++)
            {
                if(address[i] == '.')
                {
                    result += "[.]";
                    continue;
                }
                result += address[i];
            }
            return result;
        }

    }


    public class Test
    {
        public static bool[] TestDefanginganIPAddress()
        {
            // Case 1
            string Case1_1108 = "1.1.1.1";
            string expected1 = "1[.]1[.]1[.]1";
            string Case1_1108_Result = Solution.DefangIPaddr(Case1_1108);

            // Case 2
            string Case2_1108 = "255.100.50.0";
            string expected2 = "255[.]100[.]50[.]0";
            string Case2_1108_Result = Solution.DefangIPaddr(Case2_1108);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Case1_1108_Result, expected1),
                ResultTester.CheckResult<string>(Case2_1108_Result, expected2),
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Defanging an IP Address");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestDefanginganIPAddress());
        }
    }
}