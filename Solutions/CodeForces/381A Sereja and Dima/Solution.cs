// Sereja and Dima


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.SerejaandDima
{
    public class Program
    {
        //public static void Main()
        public static void Solution()
        {
            int n = int.Parse(Console.ReadLine()!);
            string[] cards = Console.ReadLine()!.Split(' ');

            int left = 0;
            int right = n - 1;
            int sereja = 0;
            int dima = 0;

            bool serejaTurn = true;

            while (left <= right)
            {
                int leftCard = int.Parse(cards[left]);
                int rightCard = int.Parse(cards[right]);

                if (serejaTurn)
                {
                    sereja += Math.Max(leftCard, rightCard);
                }
                else
                {
                    dima += Math.Max(leftCard, rightCard);
                }

                if (leftCard > rightCard)
                {
                    left++;
                }
                else
                {
                    right--;
                }

                serejaTurn = !serejaTurn;
            }

            Console.WriteLine($"{sereja} {dima}");
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sereja and Dima");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}