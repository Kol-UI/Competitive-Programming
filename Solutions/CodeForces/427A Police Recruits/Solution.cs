// Police Recruits


using System;
using System.Collections.Generic;
using System.Linq;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.PoliceRecruits
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            int n = int.Parse(Console.ReadLine()!);
            string[] events = Console.ReadLine()!.Split();

            int availablePolice = 0;
            int untreatedCrimes = 0;

            foreach (var e in events)
            {
                int eventValue = int.Parse(e);
                
                if (eventValue > 0)
                {
                    availablePolice += eventValue;
                }
                else if (availablePolice > 0)
                {
                    availablePolice--;
                }
                else
                {
                    untreatedCrimes++;
                }
            }

            Console.WriteLine(untreatedCrimes);
        }
    }


    public class Test
    {
        public static int PoliceRecruits(int n, string[] events)
        {
            int availablePolice = 0;
            int untreatedCrimes = 0;

            foreach (var e in events)
            {
                int eventValue = int.Parse(e);
                
                if (eventValue > 0)
                {
                    availablePolice += eventValue;
                }
                else if (availablePolice > 0)
                {
                    availablePolice--;
                }
                else
                {
                    untreatedCrimes++;
                }
            }

            return untreatedCrimes;
        }

        public static bool[] TestCases()
        {
            int n1 = 5;
            string[] events1 = new string[] { "-1", "-1", "1", "1", "-1" };
            int n2 = 4;
            string[] events2 = new string[] { "1", "1", "1", "1" };
            int n3 = 6;
            string[] events3 = new string[] { "-1", "-1", "-1", "1", "1", "1" };
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Test.PoliceRecruits(n1, events1), 2),
                ResultTester.CheckResult<int>(Test.PoliceRecruits(n2, events2), 0),
                ResultTester.CheckResult<int>(Test.PoliceRecruits(n3, events3), 3),
            };
            return results;
        }
    }
}