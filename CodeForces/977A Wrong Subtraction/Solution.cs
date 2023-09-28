// Wrong Subtraction


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.WrongSubtraction;

using System;

class Program
{
    //static void Main()
    static void Solution()
    {
        string[] input = Console.ReadLine()!.Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);

        for (int i = 0; i < k; i++)
        {
            if (n % 10 == 0)
            {
                n /= 10;
            }
            else
            {
                n--;
            }
        }

        Console.WriteLine(n);
    }
}
