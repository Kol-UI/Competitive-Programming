using System;
namespace CompetitiveProgramming.CodeWars.EightKyu.SquareNSum
{
    // Complete the square sum function so that it squares each number passed into it and then sums the results together.

    // yield return new TestCaseData(new int[] {1,2,2}).Returns(9);
    // yield return new TestCaseData(new int[] {1,2}).Returns(5);
    // yield return new TestCaseData(new int[] {5,3,4}).Returns(50);
    // yield return new TestCaseData(new int[] {}).Returns(0);

    public static class Kata
    {
        public static int SquareSum(int[] numbers)
        { 
            int total = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
            total += numbers[i] * numbers[i];
            }
            return total;
        }

        // Clever
        public static int SquareSumClever(int[] n) => n.Sum(i => i * i);
    }
}