﻿using System;
using System.Collections.Generic;
using CompetitiveProgramming.CoderByte;
using CompetitiveProgramming.LeetCode;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClimbingStairsFunc();
            AddTwoIntegersFunc();
            FirstFactorialFunc();
            FirstReverseFunc();
            ReplaceWithAlphabetPositionFunc();
            GrasshopperSummationFunc();
            NumberOfStepsFunc();
            SumArrayFunc();
            LongestCommonSubsequenceFunc();
            RemoveFirstandLastCharacterFunc();
            ItIsIsogramFunc();
        }

        public static void Space()
        {
            Console.WriteLine();
        }

        public static void Title(string StringTitle)
        {
            Space();
            Console.WriteLine("--- {0} ---", StringTitle);
        }
            
        private static void ClimbingStairsFunc()
        {
            Space();
            Title("70. Climbing Stairs");
            // Climbing Stairs
            // Case 1
            int Case1_70 = LeetCode.ClimbingStairs.Solution.ClimbStairs(2);
            Console.WriteLine(Case1_70);
            // Case 2
            int Case2_70 = LeetCode.ClimbingStairs.Solution.ClimbStairs(3);
            Console.WriteLine(Case2_70);
            // Case 3
            int Case3_70 = LeetCode.ClimbingStairs.Solution.ClimbStairs(40);
            Console.WriteLine(Case3_70);
        }

        private static void AddTwoIntegersFunc()
        {
            Space();
            Title("2235. Add Two Integers");
            // Add Two Intergers
            // Case 1
            int Case1_2235 = LeetCode.AddTwoIntegers.Solution.Sum(12, 5);
            Console.WriteLine(Case1_2235);
            // Case 2
            int Case2_2235 = LeetCode.AddTwoIntegers.Solution.Sum(-10, 4);
            Console.WriteLine(Case2_2235);
        }

        private static void FirstFactorialFunc()
        {
            Space();
            Title("First Factorial");
            // First Factorial
            // Case 1
            int Case1_FirstFactorial = CoderByte.FirstFactorial.Solution.FirstFactorial(4);
            Console.WriteLine(Case1_FirstFactorial);
            // Case 2
            int Case2_FirstFactorial = CoderByte.FirstFactorial.Solution.FirstFactorial(8);
            Console.WriteLine(Case2_FirstFactorial);
        }

        private static void FirstReverseFunc()
        {
            Space();
            Title("First Reverse");
            // First Reverse
            // Case 1
            string Case1_FirstReverse = CoderByte.FirstReverse.Solution.FirstReverseFunc("Test");
            Console.WriteLine(Case1_FirstReverse);
            // Case 2
            string Case2_FirstReverse = CoderByte.FirstReverse.Solution.FirstReverseFunc("Code");
            Console.WriteLine(Case2_FirstReverse);
        }

        private static void ReplaceWithAlphabetPositionFunc()
        {
            Space();
            Title("Replace With Alphabet Position");
            // Case 1
            string Case1_ReplaceWithAlphabetPosition = CodeWars.SixKyu.ReplaceWithAlphabetPosition.Solution.AlphabetPosition("Test");
            Console.WriteLine(Case1_ReplaceWithAlphabetPosition);
        }

        private static void GrasshopperSummationFunc()
        {
            Space();
            Title("Grasshopper Summation");
            // Case 1
            int Case1_Grasshopper_Summation = CodeWars.EightKyu.GrasshopperSummation.Solution.summation(3);
            Console.WriteLine(Case1_Grasshopper_Summation);
            // Case 2
            int Case2_Grasshopper_Summation = CodeWars.EightKyu.GrasshopperSummation.Solution.summation(2);
            Console.WriteLine(Case2_Grasshopper_Summation);
            // Case 3
            int Case3_Grasshopper_Summation = CodeWars.EightKyu.GrasshopperSummation.Solution.summation(8);
            Console.WriteLine(Case3_Grasshopper_Summation);
        }

        private static void NumberOfStepsFunc()
        {
            Space();
            Title("Number of Steps to Reduce a Number to Zero");
            // Case 1
            int Case1_NumberOfSteps = LeetCode.NumberofStepstoReduceaNumbertoZero.Solution.NumberOfSteps(14);
            Console.WriteLine(Case1_NumberOfSteps);
            // Case 2
            int Case2_NumberOfSteps = LeetCode.NumberofStepstoReduceaNumbertoZero.Solution.NumberOfSteps(8);
            Console.WriteLine(Case2_NumberOfSteps);
            // Case 3
            int Case3_NumberOfSteps = LeetCode.NumberofStepstoReduceaNumbertoZero.Solution.NumberOfSteps(123);
            Console.WriteLine(Case3_NumberOfSteps);
        }

        private static void SumArrayFunc()
        {
            Space();
            Title("Sum Array");
            // Case 1
            double[] sumArrayCase1 = { 10, 20, 30, 40 };
            double sumArrayResultCase1 = CodeWars.EightKyu.SumArray.Solution.SumArray(sumArrayCase1);
            Console.WriteLine(sumArrayResultCase1);
            // Case 2
            double[] sumArrayCase2 = Array.Empty<double>();
            double sumArrayResultCase2 = CodeWars.EightKyu.SumArray.Solution.SumArray(sumArrayCase2);
            Console.WriteLine(sumArrayResultCase2);
            // Case 3
            double[] sumArrayCase3 = { 0 };
            double sumArrayResultCase3 = CodeWars.EightKyu.SumArray.Solution.SumArray(sumArrayCase3);
            Console.WriteLine(sumArrayResultCase3);
            // Case 4
            double[] sumArrayCase4 = { 1, 5.2, 4, 0, -1 };
            double sumArrayResultCase4 = CodeWars.EightKyu.SumArray.Solution.SumArray(sumArrayCase4);
            Console.WriteLine(sumArrayResultCase4);
        }

        private static void LongestCommonSubsequenceFunc()
        {
            Space();
            Title("Longest Common Subsequence");
            // Case 1
            string Case1Text1 = "test"; string Case1Text2 = "tesabcde";
            int Case1Result = LeetCode.LongestCommonSubsequence.Solution.LongestCommonSubsequence(Case1Text1, Case1Text2);
            Console.WriteLine(Case1Result);
        }

        private static void RemoveFirstandLastCharacterFunc()
        {
            Space();
            Title("Remove First and Last Character");
            // Case 1
            string Case1 = "test";
            string Case1Result = CodeWars.EightKyu.RemoveFirstandLastCharacter.Solution.Remove_char(Case1);
            Console.WriteLine(Case1Result);
        }

        private static void ItIsIsogramFunc()
        {
            Space();
            Title("It is an Isogram");
            // Case 1
            string Case1_Isogram = "test";
            bool Case1_IsogramResult = CodeWars.SevenKyu.Isograms.Solution.IsIsogram(Case1_Isogram);
            Console.WriteLine(Case1_IsogramResult);
            // Case 2
            string Case2_Isogram = "machine";
            bool Case2_IsogramResult = CodeWars.SevenKyu.Isograms.Solution.IsIsogram(Case2_Isogram);
            Console.WriteLine(Case2_IsogramResult);
            // Case 3
            string Case3_Isogram = "moose";
            bool Case3_IsogramResult = CodeWars.SevenKyu.Isograms.Solution.IsIsogram(Case3_Isogram);
            Console.WriteLine(Case3_IsogramResult);
            // Case 4
            string Case4_Isogram = "aba";
            bool Case4_IsogramResult = CodeWars.SevenKyu.Isograms.Solution.IsIsogram(Case4_Isogram);
            Console.WriteLine(Case4_IsogramResult);
            // Case 5
            string Case5_Isogram = "csharp";
            bool Case5_IsogramResult = CodeWars.SevenKyu.Isograms.Solution.IsIsogram(Case5_Isogram);
            Console.WriteLine(Case5_IsogramResult);
        }
    }
}