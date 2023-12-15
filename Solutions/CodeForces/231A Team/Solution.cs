using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.Team
{
    // Solution Part
    /*
    class Solution
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
    
            int problemsImplemented = 0;
    
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
    
                int petya = int.Parse(input[0]);
                int vasya = int.Parse(input[1]);
                int tonya = int.Parse(input[2]);
    
                int sureCount = petya + vasya + tonya;
    
                if (sureCount >= 2)
                {
                    problemsImplemented++;
                }
            }
    
            Console.WriteLine(problemsImplemented);
        }
    }
    */


    // Test Part 
    public class Test
    {
        public static int TeamTestCase(int n, string[] testCase)
        {
            //int n = 3;
            int problemsImplemented = 0;

            for (int i = 0; i < n; i++)
            {
                //string[] input = Console.ReadLine().Split();
                string[] input = testCase[i].Split();

                int petya = int.Parse(input[0]);
                int vasya = int.Parse(input[1]);
                int tonya = int.Parse(input[2]);
    
                int sureCount = petya + vasya + tonya;
    
                if (sureCount >= 2)
                {
                    problemsImplemented++;
                }
            }

            return problemsImplemented;
        }

        public static bool[] TestTeam()
        {
            string[] input = new string[]
            {
                "1 1 0",
                "1 1 1",
                "1 0 0"
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Test.TeamTestCase(3, input), 2),
            };
            return results;
        }
    }
}