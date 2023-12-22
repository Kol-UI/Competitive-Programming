// 750A - New Year and Hurry



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.NewYearandHurry
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            string[] input = Console.ReadLine()!.Split(' ');
            int problems = int.Parse(input[0]);
            int totalTime = int.Parse(input[1]);

            int timeLeft = 240 - totalTime;
            int solved = 0;

            for (int i = 1; i <= problems; i++)
            {
                int timeNeeded = i * 5;
                if (timeNeeded <= timeLeft)
                {
                    timeLeft -= timeNeeded;
                    solved++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(solved);
        }
    }
}