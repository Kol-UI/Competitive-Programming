using System;
using System.Collections.Generic;
using CompetitiveProgramming.CoderByte;
using CompetitiveProgramming.LeetCode;
using CompetitiveProgramming.CodeWars;

namespace CompetitiveProgramming.TestDrivenDevelopment
{
    public class CSharpTDD
    {
        public static void StartAllTDD()
        {
            // All CoderByte Solutions
            CoderByteTests();

            // All CodeWars Solutions
            CodeWarsTests();

            // All LeetCode Solutions
            LeetCodeTests();

            // Current Testing Solution
            CurrentTests();
        }

        
        private static void CodeWarsTests()
        {
            // 8 Kyu
            EightKyuTests();

            // 7 Kyu
            SevenKyuTests();

            // 6 Kyu
            SixKyuTests();
        }


        private static void LeetCodeTests()
        {
            // Easy 
            EasyLeetCodeTests();

            // Medium
            MediumLeetCodeTests();

            // Hard
            HardLeetCodeTests();
        }


        // 8 KYU
        private static void EightKyuTests()
        {
            GrasshopperSummationFunc();
            SumArrayFunc();
            RemoveFirstandLastCharacterFunc();
            MakeNegativeFunc();
            RemoveExclamationMarksFunc();
            FindMinAndMaxOfListFunc();
            StringRepeatFunc();
            SumOfPositiveFunc();
            ConvertbooleanvaluestostringsYesorNoFunc();
            ConvertaNumbertoaStringFunc();
            EvenOrOddFunc();
        }


        // 7 KYU
        private static void SevenKyuTests()
        {
            ItIsIsogramFunc();
        }


        // 6 KYU
        private static void SixKyuTests()
        {
            ReplaceWithAlphabetPositionFunc();
        }


        // EASY LEETCODE
        private static void EasyLeetCodeTests()
        {
            ClimbingStairsFunc();
            AddTwoIntegersFunc();
            NumberOfStepsFunc();
            ContainsDuplicateFunc();
            BestTimetoBuyandSellStockFunc();
            FirstUniqueCharacterinaStringFunc();
            SingleNumberFunc();
            FindJudgeFunc();
            ShuffleTheArrayFunc();
            CountOddNumbersInAnIntervalRangeFunc();
            AddBinaryFunc();
            DefanginganIPAddressFunc();
            FindLuckyIntegerinanArrayFunc();
            SearchInsertPositionFunc();
            FindtheIndexoftheFirstOccurrenceinaStringFunc();
            KthMissingPositiveNumberFunc();
            ConvertSortedArraytoBinarySearchTree();
        }


        // MEDIUM LEETCODE
        private static void MediumLeetCodeTests()
        {
            LongestCommonSubsequenceFunc();
            MaxIceCreamFunc();
            TopKFrequentFunc();
            LexicographicallySmallestEquivalentStringFunc();
            FlipStringtoMonotoneIncreasingFunc();
            SearchA2DMatrixFunc();
            InsertIntervalFunc();
            MaxSubarraySumCircularFunc();
            SubarraySumFunc();
            SubarraysDivByKFunc();
            RestoreIpAddressesFunc();
            SnakesAndLaddersFunc();
            FindClosestNodetoGivenTwoNodesFunc();
            FruitIntoBasketsFunc();
            JumpGameIIFunc();
            AsFarfromLandasPossibleFunc();
            ShortestPathWithAlternatingColorsFunc();
            MinimumFuelCosttoReporttotheCapitalFunc();
            SingleElementinaSortedArrayFunc();
            CapacityToShipPackagesWithinDDaysFunc();
            SortanArrayFunc();
            StringCompressionFunc();
            MinimumTimetoCompleteTripsFunc();
            KokoEatingBananasFunc();
        }


        // HARD LEETCODE
        private static void HardLeetCodeTests()
        {
            CountDigitOneFunc();
            LongestPathWithDifferentAdjacentCharactersFunc();
            CheckifPointIsReachableFunc();
            NamingaCompanyFunc();
            IPOFunc();
            EditDistanceFunc();
            CountSubarraysWithFixedBoundsFunc();
            JumpGameIVFunc();
        }


        // CODERBYTE
        private static void CoderByteTests()
        {
            FirstFactorialFunc();
            FirstReverseFunc();
        }


        private static void ClimbingStairsFunc()
        {
            Program.Space();
            Program.Title("70 Climbing Stairs");
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
            Program.Space();
            Program.Title("2235. Add Two Integers");
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
            Program.Space();
            Program.Title("First Factorial");
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
            Program.Space();
            Program.Title("First Reverse");
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
            Program.Space();
            Program.Title("Replace With Alphabet Position");

            // Case 1
            string Case1_ReplaceWithAlphabetPosition = CodeWars.SixKyu.ReplaceWithAlphabetPosition.Solution.AlphabetPosition("Test");
            Console.WriteLine(Case1_ReplaceWithAlphabetPosition);
        }


        private static void GrasshopperSummationFunc()
        {
            Program.Space();
            Program.Title("Grasshopper Summation");

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
            Program.Space();
            Program.Title("Number of Steps to Reduce a Number to Zero");

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
            Program.Space();
            Program.Title("Sum Array");

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
            Program.Space();
            Program.Title("Longest Common Subsequence");

            // Case 1
            string Case1Text1 = "test"; string Case1Text2 = "tesabcde";
            int Case1Result = LeetCode.LongestCommonSubsequence.Solution.LongestCommonSubsequence(Case1Text1, Case1Text2);
            Console.WriteLine(Case1Result);
        }


        private static void RemoveFirstandLastCharacterFunc()
        {
            Program.Space();
            Program.Title("Remove First and Last Character");

            // Case 1
            string Case1 = "test";
            string Case1Result = CodeWars.EightKyu.RemoveFirstandLastCharacter.Solution.Remove_char(Case1);
            Console.WriteLine(Case1Result);
        }


        private static void ItIsIsogramFunc()
        {
            Program.Space();
            Program.Title("It is an Isogram");

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
            Program.Space();
            Program.Title("Count Digit One");

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
            Program.Space();
            Program.Title("Contains Duplicate");

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
            Program.Space();
            Program.Title("Max Ice Cream");

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
            Program.Space();
            Program.Title("Top K Frequent");

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
            Program.Space();
            Program.Title("Longest Path With Different Adjacent Characters");

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
            Program.Space();
            Program.Title("Lexicographically Smallest Equivalent String");

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
            Program.Space();
            Program.Title("Flip String to Monotone Increasing");

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
            Program.Space();
            Program.Title("Search a Matrix");

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
            Program.Space();
            Program.Title("Insert Interval");

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
            Program.Space();
            Program.Title("Best Time to Buy and Sell Stock");

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
            Program.Space();
            Program.Title("First Unique Character in a String");

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
            Program.Space();
            Program.Title("Single Number");

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
            Program.Space();
            Program.Title("Max Subarray Sum Circular");

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
            Program.Space();
            Program.Title("Subarray Sum");

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
            Program.Space();
            Program.Title("Subarrays Div By K");

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
            Program.Space();
            Program.Title("Find Judge");

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
            Program.Space();
            Program.Title("Restore Ip Addresses");

            // Case 1
            string Case1_93 = "25525511135";
            IList<string> Case1_93_Result = LeetCode.RestoreIPAddresses.Solution.RestoreIpAddresses(Case1_93);
            foreach (var s in Case1_93_Result)
            {
                Console.Write("{0} ", s);
            }
            Program.Space();

            // Case 2
            string Case2_93 = "0000";
            IList<string> Case2_93_Result = LeetCode.RestoreIPAddresses.Solution.RestoreIpAddresses(Case2_93);
            foreach (var s in Case2_93_Result)
            {
                Console.Write("{0} ", s);
            }
            Program.Space();

            // Case 3
            string Case3_93 = "101023";
            IList<string> Case3_93_Result = LeetCode.RestoreIPAddresses.Solution.RestoreIpAddresses(Case3_93);
            foreach (var s in Case3_93_Result)
            {
                Console.Write("{0} ", s);
            }
            Program.Space();
        }


        private static void CheckifPointIsReachableFunc()
        {
            Program.Space();
            Program.Title("Check if Point Is Reachable");

            // Case 1
            int case1_targetX = 6;
            int case1_targetY = 9;
            bool Case1_2543_Result = LeetCode.CheckifPointIsReachable.Solution.IsReachable(case1_targetX, case1_targetY);
            Console.WriteLine(Case1_2543_Result);

            // Case 2
            int case2_targetX = 4;
            int case2_targetY = 7;
            bool Case2_2543_Result = LeetCode.CheckifPointIsReachable.Solution.IsReachable(case2_targetX, case2_targetY);
            Console.WriteLine(Case2_2543_Result);
        }


        private static void SnakesAndLaddersFunc()
        {
            Program.Space();
            Program.Title("Snakes And Ladders");

            // Case 1
            int[][] boardCase1_909 = new int[][]
            {
                new int[] { -1,-1,-1,-1,-1,-1 },
                new int[] { -1, -1, -1, -1, -1, -1 },
                new int[] { -1,-1,-1,-1,-1,-1 },
                new int[] { -1,35,-1,-1,13,-1 },
                new int[] { -1,-1,-1,-1,-1,-1 },
                new int[] { -1,15,-1,-1,-1,-1 }
            };
            int Case1_909_Result = LeetCode.SnakesandLadders.Solution.SnakesAndLadders(boardCase1_909);
            Console.WriteLine(Case1_909_Result);

            // Case 2
            int[][] boardCase2_909 = new int[][]
            {
                new int[] { -1,-1 },
                new int[] { -1, 3 },
            };
            int Case2_909_Result = LeetCode.SnakesandLadders.Solution.SnakesAndLadders(boardCase2_909);
            Console.WriteLine(Case2_909_Result);
        }


        private static void FindClosestNodetoGivenTwoNodesFunc()
        {
            Program.Space();
            Program.Title("Find Closest Node to Given Two Nodes");

            // Case 1
            int[] edgesCase1_2359 = { 2, 2, 3, -1 };
            int node1Case1_2359 = 0;
            int node2Case1_2359 = 1;
            int Case1_2359_Result = LeetCode.FindClosestNodetoGivenTwoNodes.Solution.ClosestMeetingNode(edgesCase1_2359, node1Case1_2359, node2Case1_2359);
            Console.WriteLine(Case1_2359_Result);

            // Case 2
            int[] edgesCase2_2359 = { 1, 2, -1 };
            int node1Case2_2359 = 0;
            int node2Case2_2359 = 2;
            int Case2_2359_Result = LeetCode.FindClosestNodetoGivenTwoNodes.Solution.ClosestMeetingNode(edgesCase2_2359, node1Case2_2359, node2Case2_2359);
            Console.WriteLine(Case2_2359_Result);
        }


        private static void ShuffleTheArrayFunc()
        {
            Program.Space();
            Program.Title("Shuffle The Array");

            // Case 1
            int[] arrayCase1_1470 = { 2, 5, 1, 3, 4, 7 };
            int nCase1_1470 = 3;
            int[] Case1_1470_Result = LeetCode.ShuffletheArray.Solution.Shuffle(arrayCase1_1470, nCase1_1470);
            Program.PrintArray(Case1_1470_Result);

            // Case 2
            int[] arrayCase2_1470 = { 1, 2, 3, 4, 4, 3, 2, 1 };
            int nCase2_1470 = 4;
            int[] Case2_1470_Result = LeetCode.ShuffletheArray.Solution.Shuffle(arrayCase2_1470, nCase2_1470);
            Program.PrintArray(Case2_1470_Result);
            
            // Case 3
            int[] arrayCase3_1470 = { 1, 1, 2, 2 };
            int nCase3_1470 = 2;
            int[] Case3_1470_Result = LeetCode.ShuffletheArray.Solution.Shuffle(arrayCase3_1470, nCase3_1470);
            Program.PrintArray(Case3_1470_Result);
        }


        private static void CountOddNumbersInAnIntervalRangeFunc()
        {
            Program.Space();
            Program.Title("Count Odd Numbers in an Interval Range");

            // Case 1
            int lowCase1_1523 = 3;
            int highCase1_1523 = 7;
            int Case1_1523_Result = LeetCode.CountOddNumbersinanIntervalRange.Solution.CountOdds(lowCase1_1523, highCase1_1523);
            Console.WriteLine(Case1_1523_Result);

            // Case 2
            int lowCase2_1523 = 8;
            int highCase2_1523 = 10;
            int Case2_1523_Result = LeetCode.CountOddNumbersinanIntervalRange.Solution.CountOdds(lowCase2_1523, highCase2_1523);
            Console.WriteLine(Case2_1523_Result);

            // Case 3
            int lowCase3_1523 = 21;
            int highCase3_1523 = 22;
            int Case3_1523_Result = LeetCode.CountOddNumbersinanIntervalRange.Solution.CountOdds(lowCase3_1523, highCase3_1523);
            Console.WriteLine(Case3_1523_Result);
        }


        private static void FruitIntoBasketsFunc()
        {
            Program.Space();
            Program.Title("Fruit Into Baskets");

            // Case 1
            int[] arrayCase1_904 = { 1, 2, 1 };
            int Case1_904_Result = LeetCode.FruitIntoBaskets.Solution.TotalFruit(arrayCase1_904);
            Console.WriteLine(Case1_904_Result);

            // Case 2
            int[] arrayCase2_904 = { 0, 1, 2, 2 };
            int Case2_904_Result = LeetCode.FruitIntoBaskets.Solution.TotalFruit(arrayCase2_904);
            Console.WriteLine(Case2_904_Result);

            // Case 3
            int[] arrayCase3_904 = { 1, 2, 3, 2, 2 };
            int Case3_904_Result = LeetCode.FruitIntoBaskets.Solution.TotalFruit(arrayCase3_904);
            Console.WriteLine(Case3_904_Result);
        }


        private static void JumpGameIIFunc()
        {
            Program.Space();
            Program.Title("Jump Game II");

            // Case 1
            int[] arrayCase1_45 = { 2, 3, 1, 1, 4};
            int Case1_45_Result = LeetCode.JumpGameII.Solution.Jump(arrayCase1_45);
            Console.WriteLine(Case1_45_Result);

            // Case 2
            int[] arrayCase2_45 = { 2, 3, 0, 1, 4};
            int Case2_45_Result = LeetCode.JumpGameII.Solution.Jump(arrayCase2_45);
            Console.WriteLine(Case2_45_Result);
        }


        private static void EvenOrOddFunc()
        {
            Program.Space();
            Program.Title("Even or Odd");
            System.Random random = new System.Random();

            // Case 1
            int case1IntEvenOrOdd = 2;
            string Case1_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case1IntEvenOrOdd);

            // Case 2
            int case2IntEvenOrOdd = 0;
            string Case2_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case2IntEvenOrOdd);

            // Case 3
            int case3IntEvenOrOdd = 1;
            string Case3_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case3IntEvenOrOdd);

            // Case 4
            int case4IntEvenOrOdd = 7;
            string Case4_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case4IntEvenOrOdd);

            // Case 5
            int case5IntEvenOrOdd = -1;
            string Case5_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case5IntEvenOrOdd);

            // Case 6
            int case6IntEvenOrOdd = 1545452;
            string Case6_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case6IntEvenOrOdd);

            // Case 7
            int case7IntEvenOrOdd = 17;
            string Case7_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case7IntEvenOrOdd);

            // Case 8
            int case8IntEvenOrOdd = 78;
            string Case8_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case8IntEvenOrOdd);

            // Case 9
            int case9IntEvenOrOdd = -123;
            string Case9_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case9IntEvenOrOdd);

            // Case 10
            int case10IntEvenOrOdd = -456;
            string Case10_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case10IntEvenOrOdd);

            // Case 11
            int case11IntEvenOrOdd = 74156741;
            string Case11_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case11IntEvenOrOdd);

            // Case 12
            int case12IntEvenOrOdd = random.Next(1, 10);
            string Case12_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case12IntEvenOrOdd);

            // Case 13
            int case13IntEvenOrOdd = random.Next(1, 100);
            string Case13_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case13IntEvenOrOdd);

            // Case 14
            int case14IntEvenOrOdd = random.Next();
            string Case14_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case14IntEvenOrOdd);

            // Case 15
            int case15IntEvenOrOdd = random.Next();
            string Case15_EvenOrOdd_Result = CodeWars.EightKyu.EvenorOdd.Solution.EvenOrOdd(case15IntEvenOrOdd);
        }

        private static void NamingaCompanyFunc()
        {
            Program.Space();
            Program.Title("Naming a Company");

            // Case 1
            string[] arrayCase1_2306 = { "coffee", "donuts", "time", "toffee"};
            long Case1_2306_Result = LeetCode.NamingaCompany.Solution.DistinctNames(arrayCase1_2306);
            Console.WriteLine(Case1_2306_Result);

            // Case 2
            string[] arrayCase2_2306 = { "lack", "back"};
            long Case2_2306_Result = LeetCode.NamingaCompany.Solution.DistinctNames(arrayCase2_2306);
            Console.WriteLine(Case2_2306_Result);
        }


        private static void AsFarfromLandasPossibleFunc()
        {
            Program.Space();
            Program.Title("As Far from Land as Possible");

            // Case 1
            int[][] gridCase1_1162 = new int[][]
            {
                new int[] {1, 0, 1},
                new int[] {0, 0, 0},
                new int[] {1, 0, 1}
            };
            int Case1_1162_Result = LeetCode.AsFarfromLandasPossible.Solution.MaxDistance(gridCase1_1162);
            Console.WriteLine(Case1_1162_Result);

            // Case 2
            int[][] gridCase2_1162 = new int[][]
            {
                new int[] {1, 0, 0},
                new int[] {0, 0, 0},
                new int[] {0, 0, 0}
            };
            int Case2_1162_Result = LeetCode.AsFarfromLandasPossible.Solution.MaxDistance(gridCase2_1162);
            Console.WriteLine(Case2_1162_Result);
        }


        private static void ShortestPathWithAlternatingColorsFunc()
        {
            Program.Space();
            Program.Title("Shortest Path With Alternating Colors");

            // Case 1
            int nCase1_1129 = 3;
            int[][] redEdgesCase1_1129 = new int[][]
            {
                new int[] {0, 1},
                new int[] {1, 2}
            };
            int[][] blueEdgesCase1_1129 = new int[][] { };
            int[] Case1_1129_Result = LeetCode.ShortestPathwithAlternatingColors.Solution.ShortestAlternatingPaths(nCase1_1129, redEdgesCase1_1129, blueEdgesCase1_1129);
            Program.PrintArray(Case1_1129_Result);

            // Case 2
            int nCase2_1129 = 3;
            int[][] redEdgesCase2_1129 = new int[][]
            {
                new int[] {0, 1}
            };
            int[][] blueEdgesCase2_1129 = new int[][]
            {
                new int[] {2, 1}
            };
            int[] Case2_1129_Result = LeetCode.ShortestPathwithAlternatingColors.Solution.ShortestAlternatingPaths(nCase2_1129, redEdgesCase2_1129, blueEdgesCase2_1129);
            Program.PrintArray(Case2_1129_Result);

            // Case 3
            int nCase3_1129 = 7;
            int[][] redEdgesCase3_1129 = new int[][]
            {
                new int[] {0, 1},
                new int[] {0, 2},
                new int[] {1, 4},
                new int[] {1, 2},
                new int[] {2, 3}
            };
            int[][] blueEdgesCase3_1129 = new int[][]
            {
                new int[] {1, 2},
                new int[] {2, 5},
                new int[] {3, 6}
            };
            int[] Case3_1129_Result = LeetCode.ShortestPathwithAlternatingColors.Solution.ShortestAlternatingPaths(nCase3_1129, redEdgesCase3_1129, blueEdgesCase3_1129);
            Program.PrintArray(Case3_1129_Result);
        }


        private static void MinimumFuelCosttoReporttotheCapitalFunc()
        {
            Program.Space();
            Program.Title("Minimum Fuel Cost to Report to the Capital");

            // Case 1
            int[][] roadsCase1_2477 = new int[][]
            {
                new int[] {0, 1},
                new int[] {0, 2},
                new int[] {0, 3}
            };
            int seatsCase1_2477 = 5;
            long Case1_2477_Result = LeetCode.MinimumFuelCosttoReporttotheCapital.Solution.MinimumFuelCost(roadsCase1_2477, seatsCase1_2477);
            Console.WriteLine(Case1_2477_Result);

            // Case 2
            int[][] roadsCase2_2477 = new int[][]
            {
                new int[] {3, 1},
                new int[] {3, 2},
                new int[] {1, 0},
                new int[] {0, 4},
                new int[] {0, 5},
                new int[] {4, 6}
            };
            int seatsCase2_2477 = 2;
            long Case2_2477_Result = LeetCode.MinimumFuelCosttoReporttotheCapital.Solution.MinimumFuelCost(roadsCase2_2477, seatsCase2_2477);
            Console.WriteLine(Case2_2477_Result);

            // Case 3
            int[][] roadsCase3_2477 = new int[][] { };
            int seatsCase3_2477 = 1;
            long Case3_2477_Result = LeetCode.MinimumFuelCosttoReporttotheCapital.Solution.MinimumFuelCost(roadsCase3_2477, seatsCase3_2477);
            Console.WriteLine(Case3_2477_Result);
        }


        private static void AddBinaryFunc()
        {
            Program.Space();
            Program.Title("Add Binary");

            // Case 1
            string aCase1_67 = "11";
            string bCase1_67 = "1";
            string Case1_67_Result = LeetCode.AddBinary.Solution.AddBinary(aCase1_67, bCase1_67);
            Console.WriteLine(Case1_67_Result);

            // Case 2
            string aCase2_67 = "1010";
            string bCase2_67 = "1011";
            string Case2_67_Result = LeetCode.AddBinary.Solution.AddBinary(aCase2_67, bCase2_67);
            Console.WriteLine(Case2_67_Result);
        }


        private static void ConvertaNumbertoaStringFunc()
        {
            Program.Space();
            Program.Title("Convert a Number to a String");
            System.Random random = new System.Random();

            // Case 1
            int case1IntToString = 123;
            string Case1_IntToString_Result = CodeWars.EightKyu.ConvertaNumbertoaString.Solution.NumberToString(case1IntToString);
            Console.WriteLine(Case1_IntToString_Result);

            // Case 2
            int case2IntToString = 999;
            string Case2_IntToString_Result = CodeWars.EightKyu.ConvertaNumbertoaString.Solution.NumberToString(case2IntToString);
            Console.WriteLine(Case2_IntToString_Result);

            // Case 3
            int case3IntToString = -100;
            string Case3_IntToString_Result = CodeWars.EightKyu.ConvertaNumbertoaString.Solution.NumberToString(case3IntToString);
            Console.WriteLine(Case3_IntToString_Result);

            // Case 4
            int case4IntToString = 67;
            string Case4_IntToString_Result = CodeWars.EightKyu.ConvertaNumbertoaString.Solution.NumberToString(case4IntToString);
            Console.WriteLine(Case4_IntToString_Result);

            // Case 5
            int case5IntToString = 79585;
            string Case5_IntToString_Result = CodeWars.EightKyu.ConvertaNumbertoaString.Solution.NumberToString(case5IntToString);
            Console.WriteLine(Case5_IntToString_Result);

            // Case 6
            int case6IntToString = 1 + 2;
            string Case6_IntToString_Result = CodeWars.EightKyu.ConvertaNumbertoaString.Solution.NumberToString(case6IntToString);
            Console.WriteLine(Case6_IntToString_Result);

            // Case 7
            int case7IntToString = 1 - 2;
            string Case7_IntToString_Result = CodeWars.EightKyu.ConvertaNumbertoaString.Solution.NumberToString(case7IntToString);
            Console.WriteLine(Case7_IntToString_Result);

            // Case 8
            int case8IntToString = random.Next();
            string Case8_IntToString_Result = CodeWars.EightKyu.ConvertaNumbertoaString.Solution.NumberToString(case8IntToString);
            Console.WriteLine(Case8_IntToString_Result);

            // Case 9
            int case9IntToString = random.Next();
            string Case9_IntToString_Result = CodeWars.EightKyu.ConvertaNumbertoaString.Solution.NumberToString(case9IntToString);
            Console.WriteLine(Case9_IntToString_Result);

            // Case 10
            int case10IntToString = random.Next();
            string Case10_IntToString_Result = CodeWars.EightKyu.ConvertaNumbertoaString.Solution.NumberToString(case10IntToString);
            Console.WriteLine(Case10_IntToString_Result);
        }


        private static void DefanginganIPAddressFunc()
        {
            Program.Space();
            Program.Title("Defanging an IP Address");

            // Case 1
            string Case1_1108 = "1.1.1.1";
            string Case1_1108_Result = LeetCode.DefanginganIPAddress.Solution.DefangIPaddr(Case1_1108);
            Console.WriteLine(Case1_1108_Result);

            // Case 2
            string Case2_1108 = "255.100.50.0";
            string Case2_1108_Result = LeetCode.DefanginganIPAddress.Solution.DefangIPaddr(Case2_1108);
            Console.WriteLine(Case2_1108_Result);
        }


        private static void FindLuckyIntegerinanArrayFunc()
        {
            Program.Space();
            Program.Title("Find Lucky Integer in an Array");
            System.Random random = new System.Random();

            // Case 1
            int[] arrCase1_1394 = { 2, 2, 3, 4 };
            int Case1_1394_Result = LeetCode.FindLuckyIntegerinanArray.Solution.FindLucky(arrCase1_1394);
            Console.WriteLine(Case1_1394_Result);

            // Case 2
            int[] arrCase2_1394 = { 1, 2, 2, 3, 3, 3 };
            int Case2_1394_Result = LeetCode.FindLuckyIntegerinanArray.Solution.FindLucky(arrCase2_1394);
            Console.WriteLine(Case2_1394_Result);

            // Case 3
            int[] arrCase3_1394 = { 2, 2, 2, 3, 3 };
            int Case3_1394_Result = LeetCode.FindLuckyIntegerinanArray.Solution.FindLucky(arrCase3_1394);
            Console.WriteLine(Case3_1394_Result);
            
            // Case 4
            int value1 = random.Next(1, 5);
            int value2 = random.Next(1, 5);
            int value3 = random.Next(1, 5);
            int value4 = random.Next(1, 5);
            int[] arrCase4_1394 = { value1, value2, value3, value4 };
            int Case4_1394_Result = LeetCode.FindLuckyIntegerinanArray.Solution.FindLucky(arrCase4_1394);
            Console.WriteLine(Case4_1394_Result);
        }


        private static void ConvertbooleanvaluestostringsYesorNoFunc()
        {
            Program.Space();
            Program.Title("Convert boolean values to strings Yes or No");

            // Case 1
            bool boolCase1 = false;
            string Case1_Result = CodeWars.EightKyu.ConvertbooleanvaluestostringsYesorNo.Solution.boolToWord(boolCase1);
            Console.WriteLine(Case1_Result);

            // Case 1
            bool boolCase2 = true;
            string Case2_Result = CodeWars.EightKyu.ConvertbooleanvaluestostringsYesorNo.Solution.boolToWord(boolCase2);
            Console.WriteLine(Case2_Result);

            // Case 3
            string Case3_Result = CodeWars.EightKyu.ConvertbooleanvaluestostringsYesorNo.Solution.boolToWordClever(boolCase1);
            Console.WriteLine(Case1_Result);

            // Case 4
            string Case4_Result = CodeWars.EightKyu.ConvertbooleanvaluestostringsYesorNo.Solution.boolToWordClever(boolCase2);
            Console.WriteLine(Case4_Result);
        }


        private static void SumOfPositiveFunc()
        {
            Program.Space();
            Program.Title("Sum Of Positive");
            System.Random random = new System.Random();

            // Case 1
            int[] arrCase1 = { 1, 2, 3, 4, 5};
            int Case1_Result = CodeWars.EightKyu.Sumofpositive.Solution.PositiveSum(arrCase1);
            Console.WriteLine(Case1_Result);

            // Case 2
            int[] arrCase2 = { 1, -2, 3, 4, 5};
            int Case2_Result = CodeWars.EightKyu.Sumofpositive.Solution.PositiveSum(arrCase2);
            Console.WriteLine(Case2_Result);

            // Case 3
            int[] arrCase3 = { -1, 2, 3, 4, -5};
            int Case3_Result = CodeWars.EightKyu.Sumofpositive.Solution.PositiveSum(arrCase3);
            Console.WriteLine(Case3_Result);

            // Case 4
            int[] arrCase4 = {};
            int Case4_Result = CodeWars.EightKyu.Sumofpositive.Solution.PositiveSum(arrCase4);
            Console.WriteLine(Case4_Result);

            // Case 5
            int value1 = random.Next(-5, 5);
            int value2 = random.Next(-5, 5);
            int value3 = random.Next(-5, 5);
            int value4 = random.Next(-5, 5);
            int value5 = random.Next(-5, 5);
            int[] arrCase5 = { value1, value2, value3, value4, value5};
            int Case5_Result = CodeWars.EightKyu.Sumofpositive.Solution.PositiveSum(arrCase5);
            Console.WriteLine(Case5_Result);

            // Case 6
            int[] arrCase6 = { 1, -4, 7, 12};
            int Case6_Result = CodeWars.EightKyu.Sumofpositive.Solution.PositiveSum(arrCase6);
            Console.WriteLine(Case6_Result);

            // Clever
            // Case 1
            int Case1_CleverResult = CodeWars.EightKyu.Sumofpositive.Solution.CleverPositiveSum(arrCase1);
            Console.WriteLine(Case1_CleverResult);

            // Case 2
            int Case2_CleverResult = CodeWars.EightKyu.Sumofpositive.Solution.CleverPositiveSum(arrCase2);
            Console.WriteLine(Case2_CleverResult);

            // Case 3
            int Case3_CleverResult = CodeWars.EightKyu.Sumofpositive.Solution.CleverPositiveSum(arrCase3);
            Console.WriteLine(Case3_CleverResult);

            // Case 4
            int Case4_CleverResult = CodeWars.EightKyu.Sumofpositive.Solution.CleverPositiveSum(arrCase4);
            Console.WriteLine(Case4_CleverResult);

            // Case 5
            int Case5_CleverResult = CodeWars.EightKyu.Sumofpositive.Solution.CleverPositiveSum(arrCase5);
            Console.WriteLine(Case5_CleverResult);

            // Case 6
            int Case6_CleverResult = CodeWars.EightKyu.Sumofpositive.Solution.CleverPositiveSum(arrCase6);
            Console.WriteLine(Case6_CleverResult);
        }


        private static void StringRepeatFunc()
        {
            Program.Space();
            Program.Title("String Repeat");
            System.Random random = new System.Random();

            // Case 1
            int numberCase1 = 6;
            string stringCase1 = "I";
            string Case1_Result = CodeWars.EightKyu.Stringrepeat.Solution.RepeatStr(numberCase1, stringCase1);
            string Case1_ResultConcat = CodeWars.EightKyu.Stringrepeat.Solution.ConcatRepeatStr(numberCase1, stringCase1);
            string Case1_ResultStringBuilder = CodeWars.EightKyu.Stringrepeat.Solution.StringBuilderRepeatStr(numberCase1, stringCase1);
            StringRepeatPrint(Case1_Result, Case1_ResultConcat, Case1_ResultStringBuilder);

            // Case 2
            int numberCase2 = 5;
            string stringCase2 = "Hello";
            string Case2_Result = CodeWars.EightKyu.Stringrepeat.Solution.RepeatStr(numberCase2, stringCase2);
            string Case2_ResultConcat = CodeWars.EightKyu.Stringrepeat.Solution.ConcatRepeatStr(numberCase2, stringCase2);
            string Case2_ResultStringBuilder = CodeWars.EightKyu.Stringrepeat.Solution.StringBuilderRepeatStr(numberCase2, stringCase2);
            StringRepeatPrint(Case2_Result, Case2_ResultConcat, Case2_ResultStringBuilder);

            // Case 3
            int numberCase3 = 3;
            string stringCase3 = "*";
            string Case3_Result = CodeWars.EightKyu.Stringrepeat.Solution.RepeatStr(numberCase3, stringCase3);
            string Case3_ResultConcat = CodeWars.EightKyu.Stringrepeat.Solution.ConcatRepeatStr(numberCase3, stringCase3);
            string Case3_ResultStringBuilder = CodeWars.EightKyu.Stringrepeat.Solution.StringBuilderRepeatStr(numberCase3, stringCase3);
            StringRepeatPrint(Case3_Result, Case3_ResultConcat, Case3_ResultStringBuilder);

            // Case 4
            int numberCase4 = 5;
            string stringCase4 = "#";
            string Case4_Result = CodeWars.EightKyu.Stringrepeat.Solution.RepeatStr(numberCase4, stringCase4);
            string Case4_ResultConcat = CodeWars.EightKyu.Stringrepeat.Solution.ConcatRepeatStr(numberCase4, stringCase4);
            string Case4_ResultStringBuilder = CodeWars.EightKyu.Stringrepeat.Solution.StringBuilderRepeatStr(numberCase4, stringCase4);
            StringRepeatPrint(Case4_Result, Case4_ResultConcat, Case4_ResultStringBuilder);

            // Case 5
            int numberCase5 = 2;
            string stringCase5 = "ha ";
            string Case5_Result = CodeWars.EightKyu.Stringrepeat.Solution.RepeatStr(numberCase5, stringCase5);
            string Case5_ResultConcat = CodeWars.EightKyu.Stringrepeat.Solution.ConcatRepeatStr(numberCase5, stringCase5);
            string Case5_ResultStringBuilder = CodeWars.EightKyu.Stringrepeat.Solution.StringBuilderRepeatStr(numberCase5, stringCase5);
            StringRepeatPrint(Case5_Result, Case5_ResultConcat, Case5_ResultStringBuilder);

            // Case 6
            int numberCase6 = random.Next(1, 10);
            string stringCase6 = "random ";
            string Case6_Result = CodeWars.EightKyu.Stringrepeat.Solution.RepeatStr(numberCase6, stringCase6);
            string Case6_ResultConcat = CodeWars.EightKyu.Stringrepeat.Solution.ConcatRepeatStr(numberCase6, stringCase6);
            string Case6_ResultStringBuilder = CodeWars.EightKyu.Stringrepeat.Solution.StringBuilderRepeatStr(numberCase6, stringCase6);
            StringRepeatPrint(Case6_Result, Case6_ResultConcat, Case6_ResultStringBuilder);

            // Case 7
            int numberCase7 = 0;
            string stringCase7 = "nothing";
            string Case7_Result = CodeWars.EightKyu.Stringrepeat.Solution.RepeatStr(numberCase7, stringCase7);
            string Case7_ResultConcat = CodeWars.EightKyu.Stringrepeat.Solution.ConcatRepeatStr(numberCase7, stringCase7);
            string Case7_ResultStringBuilder = CodeWars.EightKyu.Stringrepeat.Solution.StringBuilderRepeatStr(numberCase7, stringCase7);
            StringRepeatPrint(Case7_Result, Case7_ResultConcat, Case7_ResultStringBuilder);
        }

        private static void StringRepeatPrint(string Case_Result, string Case_ResultConcat, string Case_ResultStringBuilder)
        {
            Console.WriteLine("For Loop : '{0}' \nConcat : '{1}' \nStringBuilder : '{2}'", Case_Result, Case_ResultConcat, Case_ResultStringBuilder);
            Program.Space();
        }


        private static void FindMinAndMaxOfListFunc()
        {
            Program.Space();
            Program.Title("Find Min And Max Of List");
            System.Random random = new System.Random();

            // Case 1
            int[] Case1 = { 1, -4, 7, 12};
            int minCase1 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case1);
            int maxCase1 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case1);
            FindMinAndMaxOfListPrint(Case1, minCase1, maxCase1);

            // Case 2
            int[] Case2 = { 26, 7, 7, 8, 7, 30};
            int minCase2 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case2);
            int maxCase2 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case2);
            FindMinAndMaxOfListPrint(Case2, minCase2, maxCase2);

            // Case 3
            int[] Case3 = { -2, -6, -17, -3, -8, -9, -10};
            int minCase3 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case3);
            int maxCase3 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case3);
            FindMinAndMaxOfListPrint(Case3, minCase3, maxCase3);

            // Case 4
            int value1 = random.Next();
            int value2 = random.Next();
            int value3 = random.Next();
            int value4 = random.Next();
            int value5 = random.Next();
            int[] Case4 = { value1, value2, value3, value4, value5 };
            int minCase4 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case4);
            int maxCase4 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case4);
            FindMinAndMaxOfListPrint(Case4, minCase4, maxCase4);

            // Case 5
            int value6 = random.Next(-100, -1);
            int value7 = random.Next(-100, -1);
            int value8 = random.Next(-100, -1);
            int value9 = random.Next(-100, -1);
            int value10 = random.Next(-100, -1);
            int[] Case5 = { value6, value7, value8, value9, value10 };
            int minCase5 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case5);
            int maxCase5 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case5);
            FindMinAndMaxOfListPrint(Case5, minCase5, maxCase5);

            // Case 6
            int[] Case6 = { 1, 2, 3, 4, 5 };
            int minCase6 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case6);
            int maxCase6 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case6);
            FindMinAndMaxOfListPrint(Case6, minCase6, maxCase6);

            // Case 7
            int[] Case7 = { 6, 7, 8, 9, 0 };
            int minCase7 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case7);
            int maxCase7 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case7);
            FindMinAndMaxOfListPrint(Case7, minCase7, maxCase7);
            
            // Case 8
            int[] Case8 = Case1.Union(Case2).Union(Case3).Union(Case4).Union(Case5).Union(Case6).Union(Case7).ToArray();
            int minCase8 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Min(Case8);
            int maxCase8 = CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Solution.Max(Case8);
            FindMinAndMaxOfListPrint(Case8, minCase8, maxCase8);
        }

        private static void FindMinAndMaxOfListPrint(int[] list, int min, int max)
        {
            Console.WriteLine("The List : {0}", string.Join(", ", list));
            Console.WriteLine("The Min : {0}", min);
            Console.WriteLine("The Max : {0}", max);
            Program.Space();
        }


        private static void RemoveExclamationMarksFunc()
        {
            Program.Space();
            Program.Title("Remove Exclamation Marks");

            // Case 1
            string case1ToRemove = "Test!";
            string case1ToRemove_Result = CodeWars.EightKyu.RemoveExclamationMarks.Solution.RemoveExclamationMarks(case1ToRemove);
            Program.PrintBeforeAfterStringToString(case1ToRemove, case1ToRemove_Result);

            // Case 2
            string case2ToRemove = "! Test!!";
            string case2ToRemove_Result = CodeWars.EightKyu.RemoveExclamationMarks.Solution.RemoveExclamationMarks(case2ToRemove);
            Program.PrintBeforeAfterStringToString(case2ToRemove, case2ToRemove_Result);
        }


        private static void MakeNegativeFunc()
        {
            Program.Space();
            Program.Title("Make Negative");
            System.Random random = new System.Random();

            // Case 1
            int valueCase1 = random.Next();
            int resultCase1 = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegative(valueCase1);
            Program.PrintBeforeAfterIntToInt(valueCase1, resultCase1);

            // Case 2
            int valueCase2 = 1;
            int resultCase2 = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegative(valueCase2);
            Program.PrintBeforeAfterIntToInt(valueCase2, resultCase2);

            // Case 3
            int valueCase3 = -5;
            int resultCase3 = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegative(valueCase3);
            Program.PrintBeforeAfterIntToInt(valueCase3, resultCase3);

            // Case 4
            int valueCase4 = 0;
            int resultCase4 = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegative(valueCase4);
            Program.PrintBeforeAfterIntToInt(valueCase4, resultCase4);

            // Using Math
            Program.SubTitle("Math");
            // Case 1
            int resultCase1Math = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeMath(valueCase1);
            Program.PrintBeforeAfterIntToInt(valueCase1, resultCase1Math);

            // Case 2
            int resultCase2Math = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeMath(valueCase2);
            Program.PrintBeforeAfterIntToInt(valueCase2, resultCase2Math);

            // Case 3
            int resultCase3Math = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeMath(valueCase3);
            Program.PrintBeforeAfterIntToInt(valueCase3, resultCase3Math);

            // Case 4
            int resultCase4Math = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeMath(valueCase4);
            Program.PrintBeforeAfterIntToInt(valueCase4, resultCase4Math);

            // One Line
            Program.SubTitle("One Line");
            // Case 1
            int resultCase1OneLine = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeOneLine(valueCase1);
            Program.PrintBeforeAfterIntToInt(valueCase1, resultCase1OneLine);

            // Case 2
            int resultCase2OneLine = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeOneLine(valueCase2);
            Program.PrintBeforeAfterIntToInt(valueCase2, resultCase2OneLine);

            // Case 3
            int resultCase3OneLine = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeOneLine(valueCase3);
            Program.PrintBeforeAfterIntToInt(valueCase3, resultCase3OneLine);

            // Case 4
            int resultCase4OneLine = CodeWars.EightKyu.ReturnNegative.Solution.MakeNegativeOneLine(valueCase4);
            Program.PrintBeforeAfterIntToInt(valueCase4, resultCase4OneLine);
        }


        private static void SearchInsertPositionFunc()
        {
            Program.Space();
            Program.Title("Search Insert Position");
            System.Random random = new System.Random();

            // Case 1
            int[] Case1_35 = { 1, 3, 5, 6 };
            int targetCase1_35 = 5;
            int resultCase1_35 = LeetCode.SearchInsertPosition.Solution.SearchInsert(Case1_35, targetCase1_35);
            Console.WriteLine(resultCase1_35);

            // Case 2
            int[] Case2_35 = { 1, 3, 5, 6 };
            int targetCase2_35 = 2;
            int resultCase2_35 = LeetCode.SearchInsertPosition.Solution.SearchInsert(Case2_35, targetCase2_35);
            Console.WriteLine(resultCase2_35);

            // Case 3
            int[] Case3_35 = { 1, 3, 5, 6 };
            int targetCase3_35 = 7;
            int resultCase3_35 = LeetCode.SearchInsertPosition.Solution.SearchInsert(Case3_35, targetCase3_35);
            Console.WriteLine(resultCase3_35);

            // Case 4
            int[] Case4_35 = { 1, 3, 5, 6 };
            int targetCase4_35 = random.Next(1, 10);
            int resultCase4_35 = LeetCode.SearchInsertPosition.Solution.SearchInsert(Case4_35, targetCase4_35);
            Console.WriteLine(resultCase4_35);
        }


        private static void SingleElementinaSortedArrayFunc()
        {
            Program.Space();
            Program.Title("Single Element in a Sorted Array");

            // Case 1
            int[] Case1_540 = { 1, 1, 2, 3, 3, 4, 4, 8, 8 };
            int resultCase1_540 = LeetCode.SingleElementinaSortedArray.Solution.SingleNonDuplicate(Case1_540);
            Console.WriteLine(resultCase1_540);

            // Case 2
            int[] Case2_540 = { 3, 3, 7, 7, 10, 11, 11 };
            int resultCase2_540 = LeetCode.SingleElementinaSortedArray.Solution.SingleNonDuplicate(Case2_540);
            Console.WriteLine(resultCase2_540);
        }


        private static void CapacityToShipPackagesWithinDDaysFunc()
        {
            Program.Space();
            Program.Title("Capacity To Ship Packages Within D Days");
            System.Random random = new System.Random();

            // Case 1
            int[] weightsCase1_1011 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int daysCase1_1011 = 5;
            int resultCase1_1011 = LeetCode.CapacityToShipPackagesWithinDDays.Solution.ShipWithinDays(weightsCase1_1011, daysCase1_1011);
            Console.WriteLine(resultCase1_1011);

            // Case 2
            int[] weightsCase2_1011 = { 3, 2, 2, 4, 1, 4 };
            int daysCase2_1011 = 3;
            int resultCase2_1011 = LeetCode.CapacityToShipPackagesWithinDDays.Solution.ShipWithinDays(weightsCase2_1011, daysCase2_1011);
            Console.WriteLine(resultCase2_1011);

            // Case 3
            int[] weightsCase3_1011 = { 1, 2, 3, 1, 1 };
            int daysCase3_1011 = 4;
            int resultCase3_1011 = LeetCode.CapacityToShipPackagesWithinDDays.Solution.ShipWithinDays(weightsCase3_1011, daysCase3_1011);
            Console.WriteLine(resultCase3_1011);

            // Case 4
            int value1_1011 = random.Next(1, 10);
            int value2_1011 = random.Next(1, 10);
            int value3_1011 = random.Next(1, 10);
            int value4_1011 = random.Next(1, 10);
            int value5_1011 = random.Next(1, 10);
            int[] weightsCase4_1011 = { value1_1011, value2_1011, value3_1011, value4_1011, value5_1011 };
            int daysCase4_1011 = random.Next(1, 10);
            int resultCase4_1011 = LeetCode.CapacityToShipPackagesWithinDDays.Solution.ShipWithinDays(weightsCase4_1011, daysCase4_1011);
            Console.WriteLine(resultCase4_1011);

            // Case 5
            int value6_1011 = random.Next(1, 10);
            int value7_1011 = random.Next(1, 10);
            int value8_1011 = random.Next(1, 10);
            int value9_1011 = random.Next(1, 10);
            int value10_1011 = random.Next(1, 10);
            int[] weightsCase5_1011 = { value6_1011, value7_1011, value8_1011, value9_1011, value10_1011 };
            int daysCase5_1011 = random.Next(1, 10);
            int resultCase5_1011 = LeetCode.CapacityToShipPackagesWithinDDays.Solution.ShipWithinDays(weightsCase5_1011, daysCase5_1011);
            Console.WriteLine(resultCase5_1011);
        }


        private static void IPOFunc()
        {
            Program.Space();
            Program.Title("IPO");

            // Case 1
            int k_502 = 2;
            int w_502 = 0;
            int[] profits_502 = {1, 2, 3};
            int[] capital_502 = {0, 1, 1};
            int result_502 = LeetCode.IPO.Solution.FindMaximizedCapital(k_502, w_502, profits_502, capital_502);
            Console.WriteLine(result_502);

            // Case 2
            int k2_502 = 3;
            int w2_502 = 0;
            int[] profits2_502 = {1, 2, 3};
            int[] capital2_502 = {0, 1, 2};
            int result2_502 = LeetCode.IPO.Solution.FindMaximizedCapital(k2_502, w2_502, profits2_502, capital2_502);
            Console.WriteLine(result2_502);
        }


        private static void EditDistanceFunc()
        {
            Program.Space();
            Program.Title("Edit Distance");

            // Case 1
            string word1 = "horse", word2 = "ros";
            int result1_72 = LeetCode.EditDistance.Solution.MinDistance(word1, word2);
            Console.WriteLine(result1_72);

            // Case 2
            string word3 = "intention", word4 = "execution";
            int result2_72 = LeetCode.EditDistance.Solution.MinDistance(word3, word4);
            Console.WriteLine(result2_72);
        }


        private static void SortanArrayFunc()
        {
            Program.Space();
            Program.Title("Sort an Array");
            System.Random random = new System.Random();

            // Case 1
            int[] case1_912 = { 5, 2, 3, 1 };
            int[] result1_912 = LeetCode.SortanArray.Solution.SortArray(case1_912);
            Program.PrintBeforeAfterIntArray(case1_912, result1_912);

            // Case 2
            int[] case2_912 = { 1, 2, 3, 5 };
            int[] result2_912 = LeetCode.SortanArray.Solution.SortArray(case2_912);
            Program.PrintBeforeAfterIntArray(case2_912, result2_912);

            // Case 3
            int[] case3_912 = { 5, 1, 1, 2, 0, 0 };
            int[] result3_912 = LeetCode.SortanArray.Solution.SortArray(case3_912);
            Program.PrintBeforeAfterIntArray(case3_912, result3_912);

            // Case 4
            int[] case4_912 = { 0, 0, 1, 1, 2, 5 };
            int[] result4_912 = LeetCode.SortanArray.Solution.SortArray(case4_912);
            Program.PrintBeforeAfterIntArray(case4_912, result4_912);

            // Case 5
            int[] case5_912 = { 7, 1, 2, 3 };
            int[] result5_912 = LeetCode.SortanArray.Solution.SortArray(case5_912);
            Program.PrintBeforeAfterIntArray(case5_912, result5_912);

            // Case 6
            int[] case6_912 = { 9, 7, 6, 2, 1, 1, 2, 3, 3, 4, 4, 8, 8 };
            int[] result6_912 = LeetCode.SortanArray.Solution.SortArray(case6_912);
            Program.PrintBeforeAfterIntArray(case6_912, result6_912);

            // Case 7
            int[] case7_912 = { 82, 4, 3, 1, 3, 3, 7, 7, 10, 11, 11 };
            int[] result7_912 = LeetCode.SortanArray.Solution.SortArray(case7_912);
            Program.PrintBeforeAfterIntArray(case7_912, result7_912);

            // Case 8
            int[] case8_912 = { 7, -1, 1, 2, 3 };
            int[] result8_912 = LeetCode.SortanArray.Solution.SortArray(case8_912);
            Program.PrintBeforeAfterIntArray(case8_912, result8_912);

            // Case 9
            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);
            int d = random.Next(1, 10);
            int e = random.Next(1, 10);
            int[] case9_912 = { a, b, c, d, e };
            int[] result9_912 = LeetCode.SortanArray.Solution.SortArray(case9_912);
            Program.PrintBeforeAfterIntArray(case9_912, result9_912);

            // Case 10
            int[] case10_912 = { 3, 2, 8, 2, 6 };
            int[] result10_912 = LeetCode.SortanArray.Solution.SortArray(case10_912);
            Program.PrintBeforeAfterIntArray(case10_912, result10_912);

            // Case 11
            int[] case11_912 = { a+b, b+c, c+d, d+e, e+a };
            int[] result11_912 = LeetCode.SortanArray.Solution.SortArray(case11_912);
            Program.PrintBeforeAfterIntArray(case11_912, result11_912);

            // Case 12
            int[] case12_912 = { 14, 10, 3, 2, 7 };
            int[] result12_912 = LeetCode.SortanArray.Solution.SortArray(case12_912);
            Program.PrintBeforeAfterIntArray(case12_912, result12_912);

            // Case 13
            int[] case13_912 = { 6, 8, 2, 1, 1 };
            int[] result13_912 = LeetCode.SortanArray.Solution.SortArray(case13_912);
            Program.PrintBeforeAfterIntArray(case13_912, result13_912);

            // Case 14
            int[] case14_912 = { a+b+c, b+c+d, c+d+e, d+e+a, e+a+b };
            int[] result14_912 = LeetCode.SortanArray.Solution.SortArray(case14_912);
            Program.PrintBeforeAfterIntArray(case14_912, result14_912);

            // Case 15
            int[] case15_912 = { 24, 24, 22, 21, 23 };
            int[] result15_912 = LeetCode.SortanArray.Solution.SortArray(case15_912);
            Program.PrintBeforeAfterIntArray(case15_912, result15_912);

            // Case 16
            int[] case16_912 = { a+b+c+d, b+c+d+e, c+d+e+a, d+e+a+b, e+a+b+c };
            int[] result16_912 = LeetCode.SortanArray.Solution.SortArray(case16_912);
            Program.PrintBeforeAfterIntArray(case16_912, result16_912);

            // Case 17
            int f = random.Next(-10, 0);
            int g = random.Next(-10, 0);
            int h = random.Next(-10, 0);
            int i = random.Next(-10, 0);
            int j = random.Next(-10, 0);
            int[] case17_912 = { f, g, h, i, j };
            int[] result17_912 = LeetCode.SortanArray.Solution.SortArray(case17_912);
            Program.PrintBeforeAfterIntArray(case17_912, result17_912);

            // Case 18
            int[] case18_912 = { -9, -6, -6, -6, -1 };
            int[] result18_912 = LeetCode.SortanArray.Solution.SortArray(case18_912);
            Program.PrintBeforeAfterIntArray(case18_912, result18_912);

            // Case 19
            int[] case19_912 = { a+f, b+g, c+h, d+i, e+j };
            int[] result19_912 = LeetCode.SortanArray.Solution.SortArray(case19_912);
            Program.PrintBeforeAfterIntArray(case19_912, result19_912);

            // Case 20
            int[] case20_912 = case1_912.Concat(case2_912).Concat(case3_912).Concat(case4_912)
                                        .Concat(case5_912).Concat(case6_912).Concat(case7_912)
                                        .Concat(case8_912).Concat(case9_912).Concat(case10_912)
                                        .Concat(case11_912).Concat(case12_912).Concat(case13_912)
                                        .Concat(case14_912).Concat(case15_912).Concat(case16_912)
                                        .Concat(case17_912).Concat(case18_912).Concat(case19_912).ToArray();
            int[] result20_912 = LeetCode.SortanArray.Solution.SortArray(case20_912);
            Program.PrintBeforeAfterIntArray(case20_912, result20_912);
        }


        private static void StringCompressionFunc()
        {
            Program.Space();
            Program.Title("String Compression");

            // Case 1
            char[] case1_443 = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            int result1_443 = LeetCode.StringCompression.Solution.Compress(case1_443);
            Console.WriteLine(result1_443);

            // Case 2
            char[] case2_443 = { 'a' };
            int result2_443 = LeetCode.StringCompression.Solution.Compress(case2_443);
            Console.WriteLine(result2_443);

            // Case 3
            char[] case3_443 = { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            int result3_443 = LeetCode.StringCompression.Solution.Compress(case3_443);
            Console.WriteLine(result3_443);

            // Case 4
            char[] case4_443 = { '1', '1', '2' };
            int result4_443 = LeetCode.StringCompression.Solution.Compress(case4_443);
            Console.WriteLine(result4_443);
        }

        private static void FindtheIndexoftheFirstOccurrenceinaStringFunc()
        {
            Program.Space();
            Program.Title("Find the Index of the First Occurrence in a String");

            // Case 1
            string haystackCase1_28 = "sadbutsad";
            string needleCase1_28 = "sad";
            int result_Case1_28 = LeetCode.FindtheIndexoftheFirstOccurrenceinaString.Solution.StrStr(haystackCase1_28, needleCase1_28);
            Console.WriteLine(result_Case1_28);

            // Case 2
            string haystackCase2_28 = "leetcode";
            string needleCase2_28 = "leeto";
            int result_Case2_28 = LeetCode.FindtheIndexoftheFirstOccurrenceinaString.Solution.StrStr(haystackCase2_28, needleCase2_28);
            Console.WriteLine(result_Case2_28);

            // Case 3
            string haystackCase3_28 = "mississippi";
            string needleCase3_28 = "issip";
            int result_Case3_28 = LeetCode.FindtheIndexoftheFirstOccurrenceinaString.Solution.StrStr(haystackCase3_28, needleCase3_28);
            Console.WriteLine(result_Case3_28);

            // Case 4
            string haystackCase4_28 = "a";
            string needleCase4_28 = "a";
            int result_Case4_28 = LeetCode.FindtheIndexoftheFirstOccurrenceinaString.Solution.StrStr(haystackCase4_28, needleCase4_28);
            Console.WriteLine(result_Case4_28);

            // Case 5
            string haystackCase5_28 = "hello";
            string needleCase5_28 = "ll";
            int result_Case5_28 = LeetCode.FindtheIndexoftheFirstOccurrenceinaString.Solution.StrStr(haystackCase5_28, needleCase5_28);
            Console.WriteLine(result_Case5_28);
        }


        private static void CountSubarraysWithFixedBoundsFunc()
        {
            Program.Space();
            Program.Title("Count Subarrays With Fixed Bounds");

            // Case 1
            int[] numsCase1_2444 = {1, 3, 5, 2, 7, 5};
            int minKCase1_2444 = 1;
            int maxKCase1_2444 = 5;
            long resultCase1_2444 = LeetCode.CountSubarraysWithFixedBounds.Solution.CountSubarrays(numsCase1_2444, minKCase1_2444, maxKCase1_2444);
            Console.WriteLine(resultCase1_2444);

            // Case 2
            int[] numsCase2_2444 = {1, 1, 1, 1};
            int minKCase2_2444 = 1;
            int maxKCase2_2444 = 1;
            long resultCase2_2444 = LeetCode.CountSubarraysWithFixedBounds.Solution.CountSubarrays(numsCase2_2444, minKCase2_2444, maxKCase2_2444);
            Console.WriteLine(resultCase2_2444);
        }


        private static void JumpGameIVFunc()
        {
            Program.Space();
            Program.Title("Jump Game IV");

            // Case 1
            int[] arrCase1_1345 = { 100, -23, -23, 404, 100, 23, 23, 23, 3, 404 };
            Console.WriteLine("Array Case 1 :");
            Program.PrintArray(arrCase1_1345);
            int resultCase1_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase1_1345);
            Console.WriteLine(resultCase1_1345);

            // Case 2
            int[] arrCase2_1345 = { 7 };
            Console.WriteLine("Array Case 2 :");
            Program.PrintArray(arrCase2_1345);
            int resultCase2_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase2_1345);
            Console.WriteLine(resultCase2_1345);

            // Case 3
            int[] arrCase3_1345 = { 7, 6, 9, 6, 9, 6, 9, 7 };
            Console.WriteLine("Array Case 3 :");
            Program.PrintArray(arrCase3_1345);
            int resultCase3_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase3_1345);
            Console.WriteLine(resultCase3_1345);

            // Case 4
            int[] arrCase4_1345 = { -1, 100, 100, 100, 100, 100, 100, -1, };
            Console.WriteLine("Array Case 4 :");
            Program.PrintArray(arrCase4_1345);
            int resultCase4_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase4_1345);
            Console.WriteLine(resultCase4_1345);

            // Case 5
            int[] arrCase5_1345 = Program.GenerateRandomNumber(100, 5);
            Console.WriteLine("Array Case 5 :");
            Program.PrintArray(arrCase5_1345);
            int resultCase5_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase5_1345);
            Console.WriteLine(resultCase5_1345);

            // Case 6
            int[] arrCase6_1345 = Program.GenerateRandomNumber(1000, 5);
            Console.WriteLine("Array Case 6 :");
            Program.PrintArray(arrCase6_1345);
            int resultCase6_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase6_1345);
            Console.WriteLine(resultCase6_1345);

            // Case 7
            int[] arrCase7_1345 = Program.GenerateRandomNumber(100, 10);
            Console.WriteLine("Array Case 7 :");
            Program.PrintArray(arrCase7_1345);
            int resultCase7_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase7_1345);
            Console.WriteLine(resultCase7_1345);

            // Case 8
            int[] arrCase8_1345 = Program.GenerateRandomNumber(1000, 10);
            Console.WriteLine("Array Case 8 :");
            Program.PrintArray(arrCase8_1345);
            int resultCase8_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase8_1345);
            Console.WriteLine(resultCase8_1345);

            // Case 9
            int[] arrCase9_1345 = Program.GenerateRandomNumber(10, 100);
            Console.WriteLine("Array Case 9 :");
            Program.PrintArray(arrCase9_1345);
            int resultCase9_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase9_1345);
            Console.WriteLine(resultCase9_1345);

            // Case 10
            int[] arrCase10_1345 = Program.GenerateRandomNegativeNumber(5);
            Console.WriteLine("Array Case 10 :");
            Program.PrintArray(arrCase10_1345);
            int resultCase10_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase10_1345);
            Console.WriteLine(resultCase10_1345);

            // Case 11
            int[] arrCase11_1345 = Program.GenerateRandomNegativeNumber(10);
            Console.WriteLine("Array Case 11 :");
            Program.PrintArray(arrCase11_1345);
            int resultCase11_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase11_1345);
            Console.WriteLine(resultCase11_1345);

            // Case 12
            int[] arrCase12_1345 = Program.GenerateRandomNegativePositiveNumber(5);
            Console.WriteLine("Array Case 12 :");
            Program.PrintArray(arrCase12_1345);
            int resultCase12_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase12_1345);
            Console.WriteLine(resultCase12_1345);

            // Case 13
            int[] arrCase13_1345 = Program.GenerateRandomNegativePositiveNumber(10);
            Console.WriteLine("Array Case 13 :");
            Program.PrintArray(arrCase13_1345);
            int resultCase13_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase13_1345);
            Console.WriteLine(resultCase13_1345);

            // Case 14
            int[] arrCase14_1345 = arrCase1_1345.Concat(arrCase2_1345).Concat(arrCase3_1345).Concat(arrCase4_1345)
                                                .Concat(arrCase5_1345).Concat(arrCase6_1345).Concat(arrCase7_1345)
                                                .Concat(arrCase8_1345).Concat(arrCase9_1345).Concat(arrCase10_1345)
                                                .Concat(arrCase11_1345).Concat(arrCase12_1345)
                                                .Concat(arrCase13_1345).ToArray();
            Console.WriteLine("Array Case 14 :");
            Program.PrintArray(arrCase14_1345);
            int resultCase14_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase14_1345);
            Console.WriteLine(resultCase14_1345);

            // Case 15
            int[] arrCase15_1345 = arrCase14_1345;
            Program.ShuffleArray(arrCase15_1345);
            Console.WriteLine("Array Case 15 :");
            Program.PrintArray(arrCase15_1345);
            int resultCase15_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase15_1345);
            Console.WriteLine(resultCase15_1345);
        }


        private static void KthMissingPositiveNumberFunc()
        {
            Program.Space();
            Program.Title("Kth Missing Positive Number");

            // Case 1
            int[] arrCase1_1539 = { 2, 3, 4, 7, 11 };
            int kCase1_1539 = 5;
            Console.WriteLine("Array Case 1 :");
            Program.PrintArray(arrCase1_1539);
            Console.WriteLine("Case 1 Kth Missing Number :");
            Console.WriteLine(kCase1_1539);
            int resultCase1_1345 = LeetCode.KthMissingPositiveNumber.Solution.FindKthPositive(arrCase1_1539, kCase1_1539);
            Console.WriteLine(resultCase1_1345);

            // Case 2
            int[] arrCase2_1539 = { 1, 2, 3, 4 };
            int kCase2_1539 = 2;
            Console.WriteLine("Array Case 2 :");
            Program.PrintArray(arrCase2_1539);
            Console.WriteLine("Case 2 Kth Missing Number :");
            Console.WriteLine(kCase2_1539);
            int resultCase2_1345 = LeetCode.KthMissingPositiveNumber.Solution.FindKthPositive(arrCase2_1539, kCase2_1539);
            Console.WriteLine(resultCase2_1345);

            // Case 3
            int[] arrCase3_1539 = { 1, 2, 3, 4, 9, 10, 12, 17 };
            int kCase3_1539 = 6;
            Console.WriteLine("Array Case 3 :");
            Program.PrintArray(arrCase3_1539);
            Console.WriteLine("Case 3 Kth Missing Number :");
            Console.WriteLine(kCase3_1539);
            int resultCase3_1345 = LeetCode.KthMissingPositiveNumber.Solution.FindKthPositive(arrCase3_1539, kCase3_1539);
            Console.WriteLine(resultCase3_1345);
        }


        private static void MinimumTimetoCompleteTripsFunc()
        {
            Program.Space();
            Program.Title("Minimum Time to Complete Trips");

            // Case 1
            int[] time1_1287 = {1, 2, 3};
            int totalTrips1_1287 = 5;
            long result1_1287 = LeetCode.MinimumTimetoCompleteTrips.Solution.MinimumTime(time1_1287, totalTrips1_1287);
            Console.WriteLine(result1_1287);

            // Case 2
            int[] time2_1287 = { 2 };
            int totalTrips2_1287 = 1;
            long result2_1287 = LeetCode.MinimumTimetoCompleteTrips.Solution.MinimumTime(time2_1287, totalTrips2_1287);
            Console.WriteLine(result2_1287);
        }


        private static void KokoEatingBananasFunc()
        {
            Program.Space();
            Program.Title("Koko Eating Bananas");
            System.Random random = new System.Random();

            // Case 1
            int[] piles1_875 = { 3, 6, 7, 11 };
            int h1_875 = 8;
            Console.WriteLine("Case 1 Piles :");
            Program.PrintArray(piles1_875);
            Console.WriteLine("Case 1 Hours :");
            Console.WriteLine(h1_875);
            int result1_875 = LeetCode.KokoEatingBananas.Solution.MinEatingSpeed(piles1_875, h1_875);
            Console.WriteLine("Number of Bananas Koko needs to eat per hour :");
            Console.WriteLine(result1_875);

            // Case 2
            int[] piles2_875 = { 30, 11, 23, 4, 20 };
            int h2_875 = 5;
            Console.WriteLine("Case 2 Piles :");
            Program.PrintArray(piles2_875);
            Console.WriteLine("Case 2 Hours :");
            Console.WriteLine(h2_875);
            int result2_875 = LeetCode.KokoEatingBananas.Solution.MinEatingSpeed(piles2_875, h2_875);
            Console.WriteLine("Number of Bananas Koko needs to eat per hour :");
            Console.WriteLine(result2_875);

            // Case 3
            int[] piles3_875 = { 30, 11, 23, 4, 20 };
            int h3_875 = 6;
            Console.WriteLine("Case 3 Piles :");
            Program.PrintArray(piles3_875);
            Console.WriteLine("Case 3 Hours :");
            Console.WriteLine(h3_875);
            int result3_875 = LeetCode.KokoEatingBananas.Solution.MinEatingSpeed(piles3_875, h3_875);
            Console.WriteLine("Number of Bananas Koko needs to eat per hour :");
            Console.WriteLine(result3_875);

            // Case 4
            int[] piles4_875 = Program.GenerateRandomNumber(25, 10);
            int h4_875 = random.Next(1, 10);
            Console.WriteLine("Case 4 Piles :");
            Program.PrintArray(piles4_875);
            Console.WriteLine("Case 4 Hours :");
            Console.WriteLine(h4_875);
            int result4_875 = LeetCode.KokoEatingBananas.Solution.MinEatingSpeed(piles4_875, h4_875);
            Console.WriteLine("Number of Bananas Koko needs to eat per hour :");
            Console.WriteLine(result4_875);

            // Case 5
            int[] piles5_875 = Program.GenerateRandomNumber(25, 10);
            int h5_875 = random.Next(1, 10);
            Console.WriteLine("Case 5 Piles :");
            Program.PrintArray(piles5_875);
            Console.WriteLine("Case 5 Hours :");
            Console.WriteLine(h5_875);
            int result5_875 = LeetCode.KokoEatingBananas.Solution.MinEatingSpeed(piles5_875, h5_875);
            Console.WriteLine("Number of Bananas Koko needs to eat per hour :");
            Console.WriteLine(result5_875);
        }

        private static void ConvertSortedArraytoBinarySearchTree()
        {
            Program.Space();
            Program.Title("Convert Sorted Array to Binary Search Tree");

            // Case 1
            Program.SubTitle("Case 1");
            int[] numsCase1_108 = { -10, -3, 0, 5, 9 };
            TreeNode resultCase1_108 = LeetCode.ConvertSortedArraytoBinarySearchTree.Solution.SortedArrayToBST(numsCase1_108);
            
            // Case 2
            Program.SubTitle("Case 2");
            int[] numsCase2_108 = { 1, 3 };
            TreeNode resultCase2_108 = LeetCode.ConvertSortedArraytoBinarySearchTree.Solution.SortedArrayToBST(numsCase2_108);
        }



        // CURRENT TESTS
        private static void CurrentTests()
        {
            ConvertSortedArraytoBinarySearchTree();
        }
    }
}