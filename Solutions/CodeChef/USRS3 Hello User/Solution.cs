// USRS3 Hello User

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.HelloUser
{
    // Solution
    /*
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            Console.WriteLine( "Hello " + userName );
        }
    }
    */

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Hello User");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}