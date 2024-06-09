// Determine if Two Trees are Identical


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Easy.DetermineifTwoTreesareIdentical
{
    /*
    class Solution
    {
        public bool isIdentical(Node r1, Node r2)
        {
            if (r1 == null && r2 == null)
            {
                return true;
            }
            
            if (r1 == null || r2 == null)
            {
                return false;
            }
            
            if (r1.data != r2.data)
            {
                return false;
            }
            
            return isIdentical(r1.left, r2.left) && isIdentical(r1.right, r2.right);
        }
    }
    */

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Determine if Two Trees are Identical");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks, ProblemCategory.EasyGFG);
        }
    }
}
