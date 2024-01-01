// Restoring Three Numbers

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.RestoringThreeNumbers
{
    public class Program
    {
        //public static void Main(string[] args)
        public static void Solution()
        {
            string[] input = Console.ReadLine()!.Split();
            int[] numbers = new int[4];

            for (int i = 0; i < 4; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            Array.Sort(numbers);

            int a = numbers[3] - numbers[0];
            int b = numbers[3] - numbers[1];
            int c = numbers[3] - numbers[2];

            Console.WriteLine($"{a} {b} {c}");
        }
    }
}