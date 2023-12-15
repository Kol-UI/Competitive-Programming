// Elephant

using System;
using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.Elephant;
class Program
{
    //static void Main()
    static void Solution()
    {
        int x = int.Parse(Console.ReadLine()!);
        int steps = (x + 4) / 5;

        Console.WriteLine(steps);
    }
}