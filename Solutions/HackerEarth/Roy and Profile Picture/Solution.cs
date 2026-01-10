// Roy and Profile Picture
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.RoyandProfilePicture
{
    class RoyAndProfilePicture
    {
        //static void Main()
        static void MainSolution()
        {
            string cropCase = "CROP IT";
            string uploadCase = "UPLOAD ANOTHER";
            string acceptedCase = "ACCEPTED";

            int l = int.Parse(Console.ReadLine()!);
            int t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                string[] dimensions = Console.ReadLine()!.Split(' ');
                int m = int.Parse(dimensions[0]);
                int n = int.Parse(dimensions[1]);

                if (m < l || n < l)
                {
                    Console.WriteLine(uploadCase);
                }
                else if (m == n)
                {
                    Console.WriteLine(acceptedCase);
                }
                else
                {
                    Console.WriteLine(cropCase);
                }
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Roy and Profile Picture");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}