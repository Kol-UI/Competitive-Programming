// Age Limit


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.AgeLimit
{
    /*
    public static void Main()
	{
		int t = int.Parse(Console.ReadLine());
	    for (int i = 0; i < t; i = i+1)
	    {
	        string[] examXYA = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(examXYA[0]);
	        int y = Convert.ToInt32(examXYA[1]);
	        int a = Convert.ToInt32(examXYA[2]);
		
		    if(a >= x && a < y) Console.WriteLine("YES");
		    else Console.WriteLine("NO");
	    }
	}
    */

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Age Limit");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.BeginnerCC);
        }
    }
}