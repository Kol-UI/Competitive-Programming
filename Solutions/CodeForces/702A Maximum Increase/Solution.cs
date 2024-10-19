// Maximum Increase

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.MaximumIncrease
{
    class Program
    {
        //static void Main(string[] args)
        static void MainSolution()
        {
            int n = ReadInt();
            int pRead = ReadInt();
            int cLength = 0;
            int mLength = 0;

            for (int i = 1; i < n; i++)
            {
                int cRead = ReadInt();
                if (pRead < cRead)
                {
                    cLength++;
                    mLength = Math.Max(cLength, mLength);
                }
                else
                {
                    cLength = 0;
                }
                pRead = cRead;
            }

            Console.WriteLine(mLength + 1);
        }

        static int ReadInt()
        {
            int number = 0;
            int sign = 1;
            int c;
            while ((c = Console.Read()) < '0' || c > '9')
            {
                if (c == '-') sign = -1;
            }
            do
            {
                number = number * 10 + (c - '0');
            } while ((c = Console.Read()) >= '0' && c <= '9');
            return number * sign;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Increase");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}