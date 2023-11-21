// Divisibility Problem


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.DivisibilityProblem
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            int testCases = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < testCases; i++)
            {
                string[] inputs = Console.ReadLine()!.Split();
                int firstNumber = int.Parse(inputs[0]);
                int secondNumber = int.Parse(inputs[1]);
                int difference;
                
                if (firstNumber % secondNumber == 0)
                {
                    difference = 0;
                }
                else
                {
                    difference = secondNumber - (firstNumber % secondNumber);
                }
                
                Console.WriteLine(difference);
            }
        }
    }
}