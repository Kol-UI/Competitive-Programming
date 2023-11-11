// Calculate Function


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.CalculateFunction;

class Program
{
    //static void Main()
    static void Solution()
    {
        long n = long.Parse(Console.ReadLine()!);

        long result = (n % 2 == 0) ? n / 2 : -(n + 1) / 2;

        Console.WriteLine(result);
    }
}
