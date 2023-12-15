using System;
using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class Test
    {
        public static bool[] TestStringrepeat()
        {
            
            // Case 1
            int[] case1_SquareNSum = {};
            int case1_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(case1_SquareNSum);

            // Case 2
            int[] case2_SquareNSum = { 1, 2, 2 };
            int case2_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(case2_SquareNSum);

            // Case 3
            int[] case3_SquareNSum = { 1, 2 };
            int case3_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(case3_SquareNSum);

            // Case 4
            int[] case4_SquareNSum = { 5, 3, 4 };
            int case4_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(case4_SquareNSum);

            // Case 5
            int[] case5_SquareNSum = Program.GenerateRandomNumber(10, 100);
            int case5_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(case5_SquareNSum);

            // Case 6
            int[] Case6_SquareNSum = Program.GenerateRandomNumber(10, 100);
            int Case6_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(Case6_SquareNSum);

            // Case 7
            int[] Case7_SquareNSum = Program.GenerateRandomNumber(10, 100);
            int Case7_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(Case7_SquareNSum);

            // Case 8
            int[] Case8_SquareNSum = Program.GenerateRandomNumber(10, 100);
            int Case8_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(Case8_SquareNSum);

            // Case 9
            int[] Case9_SquareNSum = Program.GenerateRandomNegativeNumber(100);
            int Case9_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(Case9_SquareNSum);

            // Case 10
            int[] Case10_SquareNSum = Program.GenerateRandomNegativeNumber(100);
            int Case10_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(Case10_SquareNSum);

            // Case 11
            int[] Case11_SquareNSum = Program.GenerateRandomNegativeNumber(100);
            int Case11_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(Case11_SquareNSum);

            // Case 12
            int[] Case12_SquareNSum = Program.GenerateRandomNegativeNumber(100);
            int Case12_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(Case12_SquareNSum);

            // Case 1 Clever
            int[] case1_SquareNSumClever = {};
            int case1_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(case1_SquareNSumClever);

            // Case 2 Clever
            int[] case2_SquareNSumClever = { 1, 2, 2 };
            int case2_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(case2_SquareNSumClever);

            // Case 3 Clever
            int[] case3_SquareNSumClever = { 1, 2 };
            int case3_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(case3_SquareNSumClever);

            // Case 4 Clever
            int[] case4_SquareNSumClever = { 5, 3, 4 };
            int case4_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(case4_SquareNSumClever);

            // Case 5 Clever
            int[] case5_SquareNSumClever = Program.GenerateRandomNumber(10, 100);
            int case5_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(case5_SquareNSumClever);

            // Case 6 Clever
            int[] Case6_SquareNSumClever = Program.GenerateRandomNumber(10, 100);
            int Case6_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(Case6_SquareNSumClever);

            // Case 7 Clever
            int[] Case7_SquareNSumClever = Program.GenerateRandomNumber(10, 100);
            int Case7_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(Case7_SquareNSumClever);

            // Case 8 Clever
            int[] Case8_SquareNSumClever = Program.GenerateRandomNumber(10, 100);
            int Case8_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(Case8_SquareNSumClever);

            // Case 9 Clever
            int[] Case9_SquareNSumClever = Program.GenerateRandomNegativeNumber(100);
            int Case9_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(Case9_SquareNSumClever);

            // Case 10 Clever
            int[] Case10_SquareNSumClever = Program.GenerateRandomNegativeNumber(100);
            int Case10_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(Case10_SquareNSumClever);

            // Case 11 Clever
            int[] Case11_SquareNSumClever = Program.GenerateRandomNegativeNumber(100);
            int Case11_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(Case11_SquareNSumClever);

            // Case 12 Clever
            int[] Case12_SquareNSumClever = Program.GenerateRandomNegativeNumber(100);
            int Case12_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(Case12_SquareNSumClever);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(case1_SquareNSumResult, 0),
                ResultTester.CheckResult<int>(case2_SquareNSumResult, 9),
                ResultTester.CheckResult<int>(case3_SquareNSumResult, 5),
                ResultTester.CheckResult<int>(case4_SquareNSumResult, 50),
                ResultTester.CheckResult<int>(case5_SquareNSumResult, case5_SquareNSumResult),
                ResultTester.CheckResult<int>(Case6_SquareNSumResult, Case6_SquareNSumResult),
                ResultTester.CheckResult<int>(Case7_SquareNSumResult, Case7_SquareNSumResult),
                ResultTester.CheckResult<int>(Case8_SquareNSumResult, Case8_SquareNSumResult),
                ResultTester.CheckResult<int>(Case9_SquareNSumResult, Case9_SquareNSumResult),
                ResultTester.CheckResult<int>(Case10_SquareNSumResult, Case10_SquareNSumResult),
                ResultTester.CheckResult<int>(Case11_SquareNSumResult, Case11_SquareNSumResult),
                ResultTester.CheckResult<int>(Case12_SquareNSumResult, Case12_SquareNSumResult),
                ResultTester.CheckResult<int>(case1_SquareNSumResultClever, 0),
                ResultTester.CheckResult<int>(case2_SquareNSumResultClever, 9),
                ResultTester.CheckResult<int>(case3_SquareNSumResultClever, 5),
                ResultTester.CheckResult<int>(case4_SquareNSumResultClever, 50),
                ResultTester.CheckResult<int>(case5_SquareNSumResultClever, case5_SquareNSumResultClever),
                ResultTester.CheckResult<int>(Case6_SquareNSumResultClever, Case6_SquareNSumResultClever),
                ResultTester.CheckResult<int>(Case7_SquareNSumResultClever, Case7_SquareNSumResultClever),
                ResultTester.CheckResult<int>(Case8_SquareNSumResultClever, Case8_SquareNSumResultClever),
                ResultTester.CheckResult<int>(Case9_SquareNSumResultClever, Case9_SquareNSumResultClever),
                ResultTester.CheckResult<int>(Case10_SquareNSumResultClever, Case10_SquareNSumResultClever),
                ResultTester.CheckResult<int>(Case11_SquareNSumResultClever, Case11_SquareNSumResultClever),
                ResultTester.CheckResult<int>(Case12_SquareNSumResultClever, Case12_SquareNSumResultClever),
            };
            return results;
        }
    }
}