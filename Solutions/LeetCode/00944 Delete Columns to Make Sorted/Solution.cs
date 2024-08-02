using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DeleteColumnstoMakeSorted
{
	public class Solution
	{
        //You are given an array of n strings strs, all of the same length.

        //The strings can be arranged such that there is one on each line, making a grid.
        //For example, strs = ["abc", "bce", "cae"] can be arranged as:
        //abc
        //bce
        //cae
        //You want to delete the columns that are not sorted lexicographically. In the above example (0-indexed), columns 0 ('a', 'b', 'c') and 2 ('c', 'e', 'e') are sorted while column 1 ('b', 'c', 'a') is not, so you would delete column 1.
        //Return the number of columns that you will delete.

        //Example 1:

        //Input: strs = ["cba","daf","ghi"]
        //        Output: 1
        //Explanation: The grid looks as follows:
        //  cba
        //  daf
        //  ghi
        //Columns 0 and 2 are sorted, but column 1 is not, so you only need to delete 1 column.

        //Example 2:

        //Input: strs = ["a","b"]
        //        Output: 0
        //Explanation: The grid looks as follows:
        //  a
        //  b
        //Column 0 is the only column and is sorted, so you will not delete any columns.

        //Example 3:

        //Input: strs = ["zyx","wvu","tsr"]
        //        Output: 3
        //Explanation: The grid looks as follows:
        //  zyx
        //  wvu
        //  tsr
        //All 3 columns are not sorted, so you will delete all 3.


        // Brut Force Solution
        public static int MinDeletionSize(string[] strs)
        {
            int result = 0;
            for (int c = 0; c < strs[0].Length; ++c)
                for (int i = 1; i < strs.Length; ++i)
                    if (strs[i - 1][c] > strs[i][c])
                    {
                        result += 1;
                        break;
                    }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestDeleteColumnstoMakeSorted()
        {
            string[] strs1 = new string[] { "cba", "daf", "ghi" };
            int output1 = 1;

            string[] strs2 = new string[] { "a", "b" };
            int output2 = 0;

            string[] strs3 = new string[] { "zyx", "wvu", "tsr" };
            int output3 = 3;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinDeletionSize(strs1), output1),
                ResultTester.CheckResult<int>(Solution.MinDeletionSize(strs2), output2),
                ResultTester.CheckResult<int>(Solution.MinDeletionSize(strs3), output3),
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Delete Columns to Make Sorted");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestDeleteColumnstoMakeSorted());
        }
    }
}