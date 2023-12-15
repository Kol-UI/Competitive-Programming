// Multiples of 3 or 5



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.ProjectEuler.Multiplesof3or5;

class Program
{
    public static int Solution()
    {
        int upperLimit = 1000;
        int result = SumMultiples(upperLimit);
        return result;
    }

    public static int SumMultiples(int limit)
    {
        int sum = 0;

        for (int i = 1; i < limit; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }

        return sum;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(Program.Solution(), Program.Solution())
        };
        return results;
    }
}