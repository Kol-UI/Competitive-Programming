// Beginner Series #1 School Paperwork

/*
Your classmates asked you to copy some paperwork for them. You know that there are 'n' classmates and the paperwork has 'm' pages.

Your task is to calculate how many blank pages do you need. If n < 0 or m < 0 return 0.

Example:
n= 5, m=5: 25
n=-5, m=5:  0
*/

using System;
using System.Linq;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeWars.EightKyu.BeginnerSeries1SchoolPaperwork
{
    public class Solution
    {
        public static int Paperwork(int n, int m)
        {
            if (n < 0 || m < 0) return 0;
            return n * m;
        }

        public static int PaperworkOneLine(int n, int m) => (n > 0 && m > 0) ? m * n : 0;
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.Paperwork(5,5), 25),
                ResultTester.CheckResult<int>(Solution.Paperwork(5,-5), 0),
                ResultTester.CheckResult<int>(Solution.Paperwork(-5,-5), 0),
                ResultTester.CheckResult<int>(Solution.Paperwork(-5,5), 0),
                ResultTester.CheckResult<int>(Solution.Paperwork(5,0), 0),
                ResultTester.CheckResult<int>(Solution.Paperwork(-5,-5), 0),

                ResultTester.CheckResult<int>(Solution.PaperworkOneLine(5,5), 25),
                ResultTester.CheckResult<int>(Solution.PaperworkOneLine(5,-5), 0),
                ResultTester.CheckResult<int>(Solution.PaperworkOneLine(-5,-5), 0),
                ResultTester.CheckResult<int>(Solution.PaperworkOneLine(-5,5), 0),
                ResultTester.CheckResult<int>(Solution.PaperworkOneLine(5,0), 0),
                ResultTester.CheckResult<int>(Solution.PaperworkOneLine(-5,-5), 0),
            };

            return results;
        }
    }
}