// A Needle in the Haystack

/*

Can you find the needle in the haystack?

Write a function findNeedle() that takes an array full of junk but containing one "needle"

After your function finds the needle it should return a message (as a string) that says:

"found the needle at position " plus the index it found the needle, so:
["hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk"] --> "found the needle at position 5" 

*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.ANeedleintheHaystack
{
    public class Solution
    {
        public static string FindNeedle(object[] haystack)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] != null && haystack[i].ToString() == "needle")
                {
                    return $"found the needle at position {i}";
                }
            }

            return "needle not found";
        }

        public static string FindNeedleBestPractices(object[] haystack)
        {
            return "found the needle at position " + Array.IndexOf(haystack,"needle");
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            var haystack_1 = new object[]{'3', "123124234", null!, "needle", "world", "hay", 2, '3', true, false};
            var haystack_2 = new object[]{"283497238987234", "a dog", "a cat", "some random junk", "a piece of hay", "needle", "something somebody lost a while ago"};
            var haystack_3 = new object[]{1,2,3,4,5,6,7,8,8,7,5,4,3,4,5,6,67,5,5,3,3,4,2,34,234,23,4,234,324,324,"needle",1,2,3,4,5,5,6,5,4,32,3,45,54};
            
            string expected1 = "found the needle at position 3";
            string expected2 = "found the needle at position 5";
            string expected3 = "found the needle at position 30";

            string result1 = Solution.FindNeedle(haystack_1);
            string result2 = Solution.FindNeedle(haystack_2);
            string result3 = Solution.FindNeedle(haystack_3);
            string result4 = Solution.FindNeedleBestPractices(haystack_1);
            string result5 = Solution.FindNeedleBestPractices(haystack_2);
            string result6 = Solution.FindNeedleBestPractices(haystack_3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(result1, expected1),
                ResultTester.CheckResult<string>(result2, expected2),
                ResultTester.CheckResult<string>(result3, expected3),
                ResultTester.CheckResult<string>(result4, expected1),
                ResultTester.CheckResult<string>(result5, expected2),
                ResultTester.CheckResult<string>(result6, expected3),
                ResultTester.CheckResult<string>(result1, result4),
                ResultTester.CheckResult<string>(result2, result5),
                ResultTester.CheckResult<string>(result3, result6),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("A Needle in the Haystack");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestCases());
        }
    }
}