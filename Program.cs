using System;
using System.Collections.Generic;
using CompetitiveProgramming.CoderByte;
using CompetitiveProgramming.LeetCode;
using CompetitiveProgramming.CodeWars;

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
            CountDigitOneFunc();
            ContainsDuplicateFunc();
            MaxIceCreamFunc();
            TopKFrequentFunc();
            LongestPathWithDifferentAdjacentCharactersFunc();
            LexicographicallySmallestEquivalentStringFunc();
            FlipStringtoMonotoneIncreasingFunc();
            SearchA2DMatrixFunc();
            InsertIntervalFunc();
            BestTimetoBuyandSellStockFunc();
            FirstUniqueCharacterinaStringFunc();
            SingleNumberFunc();
            MaxSubarraySumCircularFunc();
            SubarraySumFunc();
            SubarraysDivByKFunc();
            FindJudgeFunc();
            RestoreIpAddressesFunc();
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
            Title("70 Climbing Stairs");
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

        private static void CountDigitOneFunc()
        {
            Space();
            Title("Count Digit One");
            // Case 1
            int Case1_233 = 1;
            int Case1_233_Result = LeetCode.NumberofDigitOne.Solution.CountDigitOne(Case1_233);
            Console.WriteLine(Case1_233_Result);
            // Case 2
            int Case2_233 = 13;
            int Case2_233_Result = LeetCode.NumberofDigitOne.Solution.CountDigitOne(Case2_233);
            Console.WriteLine(Case2_233_Result);
            // Case 3
            int Case3_233 = 0;
            int Case3_233_Result = LeetCode.NumberofDigitOne.Solution.CountDigitOne(Case3_233);
            Console.WriteLine(Case3_233_Result);
        }

        private static void ContainsDuplicateFunc()
        {
            Space();
            Title("Contains Duplicate");
            // Case 1
            int[] Case1_217 = {1, 2, 3, 1};
            bool Case1_217_Result = LeetCode.ContainsDuplicate.Solution.ContainsDuplicate(Case1_217);
            Console.WriteLine(Case1_217_Result);
            // Case 2
            int[] Case2_217 = { 1, 2, 3, 4 };
            bool Case2_217_Result = LeetCode.ContainsDuplicate.Solution.ContainsDuplicate(Case2_217);
            Console.WriteLine(Case2_217_Result);
            // Case 2
            int[] Case3_217 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            bool Case3_217_Result = LeetCode.ContainsDuplicate.Solution.ContainsDuplicate(Case3_217);
            Console.WriteLine(Case3_217_Result);
        }

        private static void MaxIceCreamFunc()
        {
            Space();
            Title("Max Ice Cream");
            // Case 1
            int[] Case1_1833 = { 1, 2, 3, 1 };
            int CoinsCase1 = 7;
            int Case1_1833_Result = LeetCode.MaximumIceCreamBars.Solution.MaxIceCream(Case1_1833, CoinsCase1);
            Console.WriteLine(Case1_1833_Result);
            // Case 2
            int[] Case2_1833 = { 10, 6, 8, 7, 7, 8 };
            int CoinsCase2 = 5;
            int Case2_1833_Result = LeetCode.MaximumIceCreamBars.Solution.MaxIceCream(Case2_1833, CoinsCase2);
            Console.WriteLine(Case2_1833_Result);
            // Case 3
            int[] Case3_1833 = { 1, 6, 3, 1, 2, 5 };
            int CoinsCase3 = 20;
            int Case3_1833_Result = LeetCode.MaximumIceCreamBars.Solution.MaxIceCream(Case3_1833, CoinsCase3);
            Console.WriteLine(Case3_1833_Result);
        }

        private static void TopKFrequentFunc()
        {
            Space();
            Title("Top K Frequent");
            // Case 1
            int[] Case1_347 = { 1, 2, 4 };
            int KCase1 = 2;
            int Case1_347_Result = LeetCode.MaximumIceCreamBars.Solution.MaxIceCream(Case1_347, KCase1);
            Console.WriteLine(Case1_347_Result);
            // Case 2
            int[] Case2_347 = { 1, 1, 1, 2, 2, 3 };
            int KCase2 = 2;
            int Case2_347_Result = LeetCode.MaximumIceCreamBars.Solution.MaxIceCream(Case2_347, KCase2);
            Console.WriteLine(Case2_347_Result);
            // Case 3
            int[] Case3_347 = { 1 };
            int KCase3 = 1;
            int Case3_347_Result = LeetCode.MaximumIceCreamBars.Solution.MaxIceCream(Case3_347, KCase3);
            Console.WriteLine(Case3_347_Result);
        }

        private static void LongestPathWithDifferentAdjacentCharactersFunc()
        {
            Space();
            Title("Longest Path With Different Adjacent Characters");
            // Case 1
            int[] Case1_2246 = { -1, 0, 0, 0 };
            string s1 = "abacbe";
            int Case1_2246_Result = LeetCode.LongestPathWithDifferentAdjacentCharacters.Solution.LongestPath(Case1_2246, s1);
            Console.WriteLine(Case1_2246_Result);
            // Case 2
            int[] Case2_2246 = { 1, 1, 1, 2, 2, 3 };
            string s2 = "aabc";
            int Case2_2246_Result = LeetCode.LongestPathWithDifferentAdjacentCharacters.Solution.LongestPath(Case2_2246, s2);
            Console.WriteLine(Case2_2246_Result);
        }

        private static void LexicographicallySmallestEquivalentStringFunc()
        {
            Space();
            Title("Lexicographically Smallest Equivalent String");
            // Case 1
            string Case1_s1 = "parker";
            string Case1_s2 = "morris";
            string Case1_baseStr = "parser";
            string Case1_1061_Result = LeetCode.LexicographicallySmallestEquivalentString.Solution.SmallestEquivalentString(Case1_s1, Case1_s2, Case1_baseStr);
            Console.WriteLine(Case1_1061_Result);
            // Case 2
            string Case2_s1 = "hello";
            string Case2_s2 = "world";
            string Case2_baseStr = "hold";
            string Case2_1061_Result = LeetCode.LexicographicallySmallestEquivalentString.Solution.SmallestEquivalentString(Case2_s1, Case2_s2, Case2_baseStr);
            Console.WriteLine(Case2_1061_Result);
            // Case 3
            string Case3_s1 = "leetcode";
            string Case3_s2 = "programs";
            string Case3_baseStr = "sourcecode";
            string Case3_1061_Result = LeetCode.LexicographicallySmallestEquivalentString.Solution.SmallestEquivalentString(Case3_s1, Case3_s2, Case3_baseStr);
            Console.WriteLine(Case3_1061_Result);
        }

        private static void FlipStringtoMonotoneIncreasingFunc()
        {
            Space();
            Title("Flip String to Monotone Increasing");
            // Case 1
            string Case1_926 = "00110";
            int Case1_926_Result = LeetCode.FlipStringtoMonotoneIncreasing.Solution.MinFlipsMonoIncr(Case1_926);
            Console.WriteLine(Case1_926_Result);
            // Case 2
            string Case2_926 = "010110";
            int Case2_926_Result = LeetCode.FlipStringtoMonotoneIncreasing.Solution.MinFlipsMonoIncr(Case2_926);
            Console.WriteLine(Case2_926_Result);
            // Case 3
            string Case3_926 = "00011000";
            int Case3_926_Result = LeetCode.FlipStringtoMonotoneIncreasing.Solution.MinFlipsMonoIncr(Case3_926);
            Console.WriteLine(Case3_926_Result);
        }

        private static void SearchA2DMatrixFunc()
        {
            Space();
            Title("Search a Matrix");
            int[][] Matrix74 = new int[][]
            {
                new int[] { 1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 60 }
            };
            // Case 1
            int Case1_74_Target = 3;
            bool Case1_74_Result = LeetCode.Searcha2DMatrix.Solution.SearchMatrix(Matrix74, Case1_74_Target);
            Console.WriteLine(Case1_74_Result);
            // Case 2
            int Case2_74_Target = 13;
            bool Case2_74_Result = LeetCode.Searcha2DMatrix.Solution.SearchMatrix(Matrix74, Case2_74_Target);
            Console.WriteLine(Case2_74_Result);
        }

        private static void InsertIntervalFunc()
        {
            Space();
            Title("Insert Interval");
            // Case 1
            int[][] intervalsCase1_57 = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 6, 9 }
            };
            int[] newIntervalsCase1_57 = { 2, 5 };
            int[][] Case1_57_Result = LeetCode.InsertInterval.Solution.Insert(intervalsCase1_57, newIntervalsCase1_57);
            // Case 2
            int[][] intervalsCase2_57 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 5 },
                new int[] { 6, 7 },
                new int[] { 8, 10 },
                new int[] { 12, 16 }
            };
            int[] newIntervalsCase2_57 = { 4, 8 };
            int[][] Case2_57_Result = LeetCode.InsertInterval.Solution.Insert(intervalsCase2_57, newIntervalsCase2_57);
        }

        private static void BestTimetoBuyandSellStockFunc()
        {
            Space();
            Title("Best Time to Buy and Sell Stock");
            // Case 1
            int[] pricesCase1_121 = { 7, 1, 5, 3, 6, 4 };
            int Case1_121_Result = LeetCode.BestTimetoBuyandSellStock.Solution.MaxProfit(pricesCase1_121);
            Console.WriteLine(Case1_121_Result);
            // Case 2
            int[] pricesCase2_121 = { 7, 6, 4, 3, 1 };
            int Case2_121_Result = LeetCode.BestTimetoBuyandSellStock.Solution.MaxProfit(pricesCase2_121);
            Console.WriteLine(Case2_121_Result);
        }

        private static void FirstUniqueCharacterinaStringFunc()
        {
            Space();
            Title("First Unique Character in a String");
            // Case 1
            string stringCase1_387 = "leetcode";
            int Case1_387_Result = LeetCode.FirstUniqueCharacterinaString.Solution.FirstUniqChar(stringCase1_387);
            Console.WriteLine(Case1_387_Result);
            // Case 2
            string stringCase2_387 = "loveleetcode";
            int Case2_387_Result = LeetCode.FirstUniqueCharacterinaString.Solution.FirstUniqChar(stringCase2_387);
            Console.WriteLine(Case2_387_Result);
            // Case 3
            string stringCase3_387 = "aabb";
            int Case3_387_Result = LeetCode.FirstUniqueCharacterinaString.Solution.FirstUniqChar(stringCase3_387);
            Console.WriteLine(Case3_387_Result);
        }

        private static void SingleNumberFunc()
        {
            Space();
            Title("Single Number");
            // Case 1
            int[] numsCase1_136 = { 2, 2, 1 };
            int Case1_136_Result = LeetCode.SingleNumber.Solution.SingleNumber(numsCase1_136);
            Console.WriteLine(Case1_136_Result);
            // Case 2
            int[] numsCase2_136 = { 4, 1, 2, 1, 2 };
            int Case2_136_Result = LeetCode.SingleNumber.Solution.SingleNumber(numsCase2_136);
            Console.WriteLine(Case2_136_Result);
            // Case 3
            int[] numsCase3_136 = { 1 };
            int Case3_136_Result = LeetCode.SingleNumber.Solution.SingleNumber(numsCase3_136);
            Console.WriteLine(Case3_136_Result);
        }

        private static void MaxSubarraySumCircularFunc()
        {
            Space();
            Title("Max Subarray Sum Circular");
            // Case 1
            int[] numsCase1_918 = { 1, -2, 3, -2 };
            int Case1_918_Result = LeetCode.MaximumSumCircularSubarray.Solution.MaxSubarraySumCircular(numsCase1_918);
            Console.WriteLine(Case1_918_Result);
            // Case 2
            int[] numsCase2_918 = { 5, -3, 5 };
            int Case2_918_Result = LeetCode.MaximumSumCircularSubarray.Solution.MaxSubarraySumCircular(numsCase2_918);
            Console.WriteLine(Case2_918_Result);
            // Case 3
            int[] numsCase3_918 = { -3, -2, -3 };
            int Case3_918_Result = LeetCode.MaximumSumCircularSubarray.Solution.MaxSubarraySumCircular(numsCase3_918);
            Console.WriteLine(Case3_918_Result);
        }

        private static void SubarraySumFunc()
        {
            Space();
            Title("Subarray Sum");
            // Case 1
            int[] numsCase1_560 = { 1, 1, 1 };
            int kCase1 = 2;
            int Case1_560_Result = LeetCode.SubarraySumEqualsK.Solution.SubarraySum(numsCase1_560, kCase1);
            Console.WriteLine(Case1_560_Result);
            // Case 2
            int[] numsCase2_560 = { 1, 2, 3 };
            int kCase2 = 3;
            int Case2_560_Result = LeetCode.SubarraySumEqualsK.Solution.SubarraySum(numsCase2_560, kCase2);
            Console.WriteLine(Case2_560_Result);
        }

        private static void SubarraysDivByKFunc()
        {
            Space();
            Title("Subarrays Div By K");
            // Case 1
            int[] numsCase1_974 = { 4, 5, 0, -2, -3, 1 };
            int kCase1 = 5;
            int Case1_974_Result = LeetCode.SubarraySumEqualsK.Solution.SubarraySum(numsCase1_974, kCase1);
            Console.WriteLine(Case1_974_Result);
            // Case 2
            int[] numsCase2_974 = { 5 };
            int kCase2 = 9;
            int Case2_974_Result = LeetCode.SubarraySumEqualsK.Solution.SubarraySum(numsCase2_974, kCase2);
            Console.WriteLine(Case2_974_Result);
        }

        private static void FindJudgeFunc()
        {
            Space();
            Title("Find Judge");
            // Case 1
            int[][] trustCase1_997 = new int[][]
            {
                new int[] { 1, 2 }
            };
            int Case1_997 = 2;
            int Case1_997_Result = LeetCode.FindtheTownJudge.Solution.FindJudge(Case1_997, trustCase1_997);
            Console.WriteLine(Case1_997_Result);
            // Case 2
            int[][] trustCase2_997 = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 2, 3 }
            };
            int Case2_997 = 3;
            int Case2_997_Result = LeetCode.FindtheTownJudge.Solution.FindJudge(Case2_997, trustCase2_997);
            Console.WriteLine(Case2_997_Result);
            // Case 3
            int[][] trustCase3_997 = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 2, 3 },
                new int[] { 3, 1 }
            };
            int Case3_997 = 3;
            int Case3_997_Result = LeetCode.FindtheTownJudge.Solution.FindJudge(Case3_997, trustCase3_997);
            Console.WriteLine(Case3_997_Result);
        }

        private static void RestoreIpAddressesFunc()
        {
            Space();
            Title("Restore Ip Addresses");
            // Case 1
            string Case1_93 = "25525511135";
            IList<string> Case1_93_Result = LeetCode.RestoreIPAddresses.Solution.RestoreIpAddresses(Case1_93);
            foreach (var s in Case1_93_Result)
            {
                Console.Write("{0} ", s);
            }
            Space();
            // Case 2
            string Case2_93 = "0000";
            IList<string> Case2_93_Result = LeetCode.RestoreIPAddresses.Solution.RestoreIpAddresses(Case2_93);
            foreach (var s in Case2_93_Result)
            {
                Console.Write("{0} ", s);
            }
            Space();
            // Case 3
            string Case3_93 = "101023";
            IList<string> Case3_93_Result = LeetCode.RestoreIPAddresses.Solution.RestoreIpAddresses(Case3_93);
            foreach (var s in Case3_93_Result)
            {
                Console.Write("{0} ", s);
            }
            Space();
        }

    }
}