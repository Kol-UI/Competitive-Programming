using System;
using System.Linq;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.RemoveStringSpaces
{
    /*
        Write a function that removes the spaces from the string, then return the resultant string.
        Examples:

        Input -> Output
        "8 j 8   mBliB8g  imjB8B8  jl  B" -> "8j8mBliB8gimjB8B8jlB"
        "8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd" -> "88Bifk8hB8BB8BBBB888chl8BhBfd"
        "8aaaaa dddd r     " -> "8aaaaaddddr"
    */
	public class Solution
	{
        public static string NoSpace(string input)
        {
            return new string(input.ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray());
        } 
    }

    public class Test
    {
        public static bool[] TestRemoveStringSpaces()
        {
            // Case 1
            string Case1 = "8 j 8   mBliB8g  imjB8B8  jl  B";
            string Case1_Result = Solution.NoSpace(Case1);

            // Case 2
            string Case2 = "8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd";
            string Case2_Result = Solution.NoSpace(Case2);

            // Case 3
            string Case3 = "8aaaaa dddd r     ";
            string Case3_Result = Solution.NoSpace(Case3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Case1_Result, "8j8mBliB8gimjB8B8jlB"),
                ResultTester.CheckResult<string>(Case2_Result, "88Bifk8hB8BB8BBBB888chl8BhBfd"),
                ResultTester.CheckResult<string>(Case3_Result, "8aaaaaddddr"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove String Spaces");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestRemoveStringSpaces());
        }
    }
}