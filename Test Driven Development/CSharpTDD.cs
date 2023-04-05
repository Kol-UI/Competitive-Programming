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

            // All GeeksForGeeks Solutions
            GeeksForGeeksTests();

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


        private static void GeeksForGeeksTests()
        {
            // School 
            SchoolGeeksForGeeksTests();

            // Basic
            BasicGeeksForGeeksTests();

            // Easy
            EasyGeeksForGeeksTests();

            // Medium
            MediumGeeksForGeeksTests();

            // Hard
            HardGeeksForGeeksTests();
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
            SquareNSumFunc();
            FindthesmallestintegerinthearrayFunc();
            RemoveStringSpacesFunc();
            CountingsheepFunc();
            ConvertaStringtoaNumberFunc();
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


        // SCHOOL GEEKSFORGEEKS
        private static void SchoolGeeksForGeeksTests()
        {
            SumofSeriesFunc();
            PrintSecondLargestFunc();
        }


        // BASIC GEEKSFORGEEKS
        private static void BasicGeeksForGeeksTests()
        {

        }


        // EASY GEEKSFORGEEKS
        private static void EasyGeeksForGeeksTests()
        {
            CounttheSubstringsFunc();
            MinimumIntegerFunc();
            Remainderondividingby11Func();
            MakeArrayElementsEqualFunc();
        }


        // MEDIUM GEEKSFORGEEKS
        private static void MediumGeeksForGeeksTests()
        {
            StringrporprFunc();
            EvenSwapFunc();
            MinimumStepsRequiredFunc();
        }


        // HARD GEEKSFORGEEKS
        private static void HardGeeksForGeeksTests()
        {

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
            CanPlaceFlowersFunc();
            KItemsWiththeMaximumSumFunc();
            BinarySearchFunc();
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
            ImplementTriePrefixTreeFunc();
            NumberofZeroFilledSubarraysFunc();
            MinimumScoreofaPathBetweenTwoCitiesFunc();
            NumberofOperationstoMakeNetworkConnectedFunc();
            ReorderRoutestoMakeAllPathsLeadtotheCityZeroFunc();
            CountUnreachablePairsofNodesinanUndirectedGraphFunc();
            MinimumPathSumFunc();
            PrimeSubtractionOperationFunc();
            MinimumCostForTicketsFunc();
            SuccessfulPairsofSpellsandPotionsFunc();
            BoatstoSavePeopleFunc();
            OptimalPartitionofStringFunc();
            MinimizeMaximumofArrayFunc();
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
            LongestCycleinaGraphFunc();
            NumberofWaysofCuttingaPizzaFunc();
            ReducingDishesFunc();
            ScrambleStringFunc();
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


        private static void ImplementTriePrefixTreeFunc()
        {
            Program.Space();
            Program.Title("Implement Trie Prefix Tree");

            LeetCode.ImplementTriePrefixTree.Trie obj_208 = new LeetCode.ImplementTriePrefixTree.Trie();
            string word1_208 = "Trie";
            Program.SubTitle(word1_208);
            obj_208.Insert(word1_208);
            bool searchResult1_208 = obj_208.Search(word1_208);
            bool startsWithResult1_208 = obj_208.StartsWith(word1_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult1_208, startsWithResult1_208);

            string word2_208 = "insert";
            Program.SubTitle(word2_208);
            obj_208.Insert(word2_208);
            bool searchResult2_208 = obj_208.Search(word2_208);
            bool startsWithResult2_208 = obj_208.StartsWith(word2_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult2_208, startsWithResult2_208);

            string word3_208 = "search";
            Program.SubTitle(word3_208);
            obj_208.Insert(word3_208);
            bool searchResult3_208 = obj_208.Search(word3_208);
            bool startsWithResult3_208 = obj_208.StartsWith(word3_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult3_208, startsWithResult3_208);
            
            Program.SubTitle(word3_208);
            obj_208.Insert(word3_208);
            bool searchResult3_2_208 = obj_208.Search(word3_208);
            bool startsWithResult3_2_208 = obj_208.StartsWith(word3_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult3_2_208, startsWithResult3_2_208);

            string word4_208 = "startsWith";
            Program.SubTitle(word4_208);
            obj_208.Insert(word4_208);
            bool searchResult4_208 = obj_208.Search(word4_208);
            bool startsWithResult4_208 = obj_208.StartsWith(word4_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult4_208, startsWithResult4_208);

            Program.SubTitle(word2_208);
            obj_208.Insert(word2_208);
            bool searchResult2_2_208 = obj_208.Search(word2_208);
            bool startsWithResult2_2_208 = obj_208.StartsWith(word2_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult2_2_208, startsWithResult2_2_208);

            Program.SubTitle(word3_208);
            obj_208.Insert(word3_208);
            bool searchResult3_3_208 = obj_208.Search(word3_208);
            bool startsWithResult3_3_208 = obj_208.StartsWith(word3_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult3_3_208, startsWithResult3_3_208);

            string word5_208 = "apple";
            Program.SubTitle(word5_208);
            obj_208.Insert(word5_208);
            bool searchResult5_208 = obj_208.Search(word5_208);
            bool startsWithResult5_208 = obj_208.StartsWith(word5_208);
            Console.WriteLine("Search: {0} - Starts With: {1}", searchResult5_208, startsWithResult5_208);

            LeetCode.ImplementTriePrefixTree.Trie trie = new LeetCode.ImplementTriePrefixTree.Trie();
            Program.SubTitle(word5_208);
            trie.Insert(word5_208);
            bool test1_2_208 = trie.StartsWith(word5_208);
            bool test1_208 = trie.Search(word5_208);
            Console.WriteLine(test1_2_208);
            Console.WriteLine(test1_208);

            string word6_208 = "app";
            Program.SubTitle(word6_208);
            bool test2_208 = trie.Search(word6_208);
            Console.WriteLine(test2_208);
        }


        private static void SquareNSumFunc()
        {
            Program.Space();
            Program.Title("Square(n) Sum");
            
            // Case 1
            int[] case1_SquareNSum = {};
            int case1_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(case1_SquareNSum);
            Console.WriteLine(case1_SquareNSumResult);

            // Case 2
            int[] case2_SquareNSum = { 1, 2, 2 };
            int case2_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(case2_SquareNSum);
            Console.WriteLine(case2_SquareNSumResult);

            // Case 3
            int[] case3_SquareNSum = { 1, 2 };
            int case3_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(case3_SquareNSum);
            Console.WriteLine(case3_SquareNSumResult);

            // Case 4
            int[] case4_SquareNSum = { 5, 3, 4 };
            int case4_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(case4_SquareNSum);
            Console.WriteLine(case4_SquareNSumResult);

            // Case 5
            int[] case5_SquareNSum = Program.GenerateRandomNumber(10, 100);
            int case5_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(case5_SquareNSum);
            Console.WriteLine(case5_SquareNSumResult);

            // Case 6
            int[] Case6_SquareNSum = Program.GenerateRandomNumber(10, 100);
            int Case6_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(Case6_SquareNSum);
            Console.WriteLine(Case6_SquareNSumResult);

            // Case 7
            int[] Case7_SquareNSum = Program.GenerateRandomNumber(10, 100);
            int Case7_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(Case7_SquareNSum);
            Console.WriteLine(Case7_SquareNSumResult);

            // Case 8
            int[] Case8_SquareNSum = Program.GenerateRandomNumber(10, 100);
            int Case8_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(Case8_SquareNSum);
            Console.WriteLine(Case8_SquareNSumResult);

            // Case 9
            int[] Case9_SquareNSum = Program.GenerateRandomNegativeNumber(100);
            int Case9_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(Case9_SquareNSum);
            Console.WriteLine(Case9_SquareNSumResult);

            // Case 10
            int[] Case10_SquareNSum = Program.GenerateRandomNegativeNumber(100);
            int Case10_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(Case10_SquareNSum);
            Console.WriteLine(Case10_SquareNSumResult);

            // Case 11
            int[] Case11_SquareNSum = Program.GenerateRandomNegativeNumber(100);
            int Case11_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(Case11_SquareNSum);
            Console.WriteLine(Case11_SquareNSumResult);

            // Case 12
            int[] Case12_SquareNSum = Program.GenerateRandomNegativeNumber(100);
            int Case12_SquareNSumResult = CodeWars.EightKyu.SquareNSum.Kata.SquareSum(Case12_SquareNSum);
            Console.WriteLine(Case12_SquareNSumResult);

            // Case 1 Clever
            int[] case1_SquareNSumClever = {};
            int case1_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(case1_SquareNSumClever);
            Console.WriteLine(case1_SquareNSumResultClever);

            // Case 2 Clever
            int[] case2_SquareNSumClever = { 1, 2, 2 };
            int case2_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(case2_SquareNSumClever);
            Console.WriteLine(case2_SquareNSumResultClever);

            // Case 3 Clever
            int[] case3_SquareNSumClever = { 1, 2 };
            int case3_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(case3_SquareNSumClever);
            Console.WriteLine(case3_SquareNSumResultClever);

            // Case 4 Clever
            int[] case4_SquareNSumClever = { 5, 3, 4 };
            int case4_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(case4_SquareNSumClever);
            Console.WriteLine(case4_SquareNSumResultClever);

            // Case 5 Clever
            int[] case5_SquareNSumClever = Program.GenerateRandomNumber(10, 100);
            int case5_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(case5_SquareNSumClever);
            Console.WriteLine(case5_SquareNSumResultClever);

            // Case 6 Clever
            int[] Case6_SquareNSumClever = Program.GenerateRandomNumber(10, 100);
            int Case6_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(Case6_SquareNSumClever);
            Console.WriteLine(Case6_SquareNSumResultClever);

            // Case 7 Clever
            int[] Case7_SquareNSumClever = Program.GenerateRandomNumber(10, 100);
            int Case7_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(Case7_SquareNSumClever);
            Console.WriteLine(Case7_SquareNSumResultClever);

            // Case 8 Clever
            int[] Case8_SquareNSumClever = Program.GenerateRandomNumber(10, 100);
            int Case8_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(Case8_SquareNSumClever);
            Console.WriteLine(Case8_SquareNSumResultClever);

            // Case 9 Clever
            int[] Case9_SquareNSumClever = Program.GenerateRandomNegativeNumber(100);
            int Case9_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(Case9_SquareNSumClever);
            Console.WriteLine(Case9_SquareNSumResultClever);

            // Case 10 Clever
            int[] Case10_SquareNSumClever = Program.GenerateRandomNegativeNumber(100);
            int Case10_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(Case10_SquareNSumClever);
            Console.WriteLine(Case10_SquareNSumResultClever);

            // Case 11 Clever
            int[] Case11_SquareNSumClever = Program.GenerateRandomNegativeNumber(100);
            int Case11_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(Case11_SquareNSumClever);
            Console.WriteLine(Case11_SquareNSumResultClever);

            // Case 12 Clever
            int[] Case12_SquareNSumClever = Program.GenerateRandomNegativeNumber(100);
            int Case12_SquareNSumResultClever = CodeWars.EightKyu.SquareNSum.Kata.SquareSumClever(Case12_SquareNSumClever);
            Console.WriteLine(Case12_SquareNSumResultClever);
        }


        private static void FindthesmallestintegerinthearrayFunc()
        {
            Program.Space();
            Program.Title("Find the smallest integer in the array");

            // Case 1
            int[] case1_Findthesmallestintegerinthearray = { -1, -2 };
            int case1_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case1_Findthesmallestintegerinthearray);
            Console.WriteLine(case1_FindthesmallestintegerinthearrayResult);

            // Case 2
            int[] case2_Findthesmallestintegerinthearray = { 1, 2, 2 };
            int case2_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case2_Findthesmallestintegerinthearray);
            Console.WriteLine(case2_FindthesmallestintegerinthearrayResult);

            // Case 3
            int[] case3_Findthesmallestintegerinthearray = { 1, 2 };
            int case3_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case3_Findthesmallestintegerinthearray);
            Console.WriteLine(case3_FindthesmallestintegerinthearrayResult);

            // Case 4
            int[] case4_Findthesmallestintegerinthearray = { 5, 3, 4 };
            int case4_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case4_Findthesmallestintegerinthearray);
            Console.WriteLine(case4_FindthesmallestintegerinthearrayResult);

            // Case 5
            int[] case5_Findthesmallestintegerinthearray = Program.GenerateRandomNumber(10, 100);
            int case5_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case5_Findthesmallestintegerinthearray);
            Console.WriteLine(case5_FindthesmallestintegerinthearrayResult);

            // Case 6
            int[] Case6_Findthesmallestintegerinthearray = Program.GenerateRandomNumber(10, 100);
            int Case6_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(Case6_Findthesmallestintegerinthearray);
            Console.WriteLine(Case6_FindthesmallestintegerinthearrayResult);

            // Case 7
            int[] Case7_Findthesmallestintegerinthearray = Program.GenerateRandomNumber(10, 100);
            int Case7_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(Case7_Findthesmallestintegerinthearray);
            Console.WriteLine(Case7_FindthesmallestintegerinthearrayResult);

            // Case 8
            int[] Case8_Findthesmallestintegerinthearray = Program.GenerateRandomNumber(10, 100);
            int Case8_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(Case8_Findthesmallestintegerinthearray);
            Console.WriteLine(Case8_FindthesmallestintegerinthearrayResult);

            // Case 9
            int[] Case9_Findthesmallestintegerinthearray = Program.GenerateRandomNegativeNumber(100);
            int Case9_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(Case9_Findthesmallestintegerinthearray);
            Console.WriteLine(Case9_FindthesmallestintegerinthearrayResult);

            // Case 10
            int[] Case10_Findthesmallestintegerinthearray = Program.GenerateRandomNegativeNumber(100);
            int Case10_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(Case10_Findthesmallestintegerinthearray);
            Console.WriteLine(Case10_FindthesmallestintegerinthearrayResult);

            // Case 11
            int[] Case11_Findthesmallestintegerinthearray = Program.GenerateRandomNegativeNumber(100);
            int Case11_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(Case11_Findthesmallestintegerinthearray);
            Console.WriteLine(Case11_FindthesmallestintegerinthearrayResult);

            // Case 12
            int[] Case12_Findthesmallestintegerinthearray = Program.GenerateRandomNegativeNumber(100);
            int Case12_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(Case12_Findthesmallestintegerinthearray);
            Console.WriteLine(Case12_FindthesmallestintegerinthearrayResult);

            // Case 13
            int[] case13_Findthesmallestintegerinthearray = { 78, 56, 232, 12, 11, 43 };
            int case13_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case13_Findthesmallestintegerinthearray);
            Console.WriteLine(case13_FindthesmallestintegerinthearrayResult);

            // Case 14
            int[] case14_Findthesmallestintegerinthearray = { 78, 56, -2, 12, 8, -33 };
            int case14_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case14_Findthesmallestintegerinthearray);
            Console.WriteLine(case14_FindthesmallestintegerinthearrayResult);

            // Case 15
            int[] case15_Findthesmallestintegerinthearray = { 34, 15, 88, 2 };
            int case15_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case15_Findthesmallestintegerinthearray);
            Console.WriteLine(case15_FindthesmallestintegerinthearrayResult);

            // Case 16
            int[] case16_Findthesmallestintegerinthearray = { 34, -345, -1, 100 };
            int case16_FindthesmallestintegerinthearrayResult = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestInt(case16_Findthesmallestintegerinthearray);
            Console.WriteLine(case16_FindthesmallestintegerinthearrayResult);

            
            // Case 1 Clever Linq
            int case1_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case1_Findthesmallestintegerinthearray);
            Console.WriteLine(case1_FindthesmallestintegerinthearrayResultCleverLinq);

            // Case 2 Clever Linq
            int case2_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case2_Findthesmallestintegerinthearray);
            Console.WriteLine(case2_FindthesmallestintegerinthearrayResultCleverLinq);

            // Case 3 Clever Linq
            int case3_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case3_Findthesmallestintegerinthearray);
            Console.WriteLine(case3_FindthesmallestintegerinthearrayResultCleverLinq);

            // Case 4 Clever Linq
            int case4_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case4_Findthesmallestintegerinthearray);
            Console.WriteLine(case4_FindthesmallestintegerinthearrayResultCleverLinq);

            // Case 5 Clever Linq
            int case5_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case5_Findthesmallestintegerinthearray);
            Console.WriteLine(case5_FindthesmallestintegerinthearrayResultCleverLinq);

            // Case 6 Clever Linq
            int Case6_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(Case6_Findthesmallestintegerinthearray);
            Console.WriteLine(Case6_FindthesmallestintegerinthearrayResultCleverLinq);

            // Case 7 Clever Linq
            int Case7_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(Case7_Findthesmallestintegerinthearray);
            Console.WriteLine(Case7_FindthesmallestintegerinthearrayResultCleverLinq);

            // Case 8 Clever Linq
            int Case8_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(Case8_Findthesmallestintegerinthearray);
            Console.WriteLine(Case8_FindthesmallestintegerinthearrayResultCleverLinq);

            // Case 9 Clever Linq
            int Case9_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(Case9_Findthesmallestintegerinthearray);
            Console.WriteLine(Case9_FindthesmallestintegerinthearrayResultCleverLinq);

            // Case 10 Clever Linq
            int Case10_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(Case10_Findthesmallestintegerinthearray);
            Console.WriteLine(Case10_FindthesmallestintegerinthearrayResultCleverLinq);

            // Case 11 Clever Linq
            int Case11_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(Case11_Findthesmallestintegerinthearray);
            Console.WriteLine(Case11_FindthesmallestintegerinthearrayResultCleverLinq);

            // Case 12 Clever Linq
            int Case12_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(Case12_Findthesmallestintegerinthearray);
            Console.WriteLine(Case12_FindthesmallestintegerinthearrayResultCleverLinq);

            // Case 13 Clever Linq
            int case13_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case13_Findthesmallestintegerinthearray);
            Console.WriteLine(case13_FindthesmallestintegerinthearrayResultCleverLinq);

            // Case 14 Clever Linq
            int case14_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case14_Findthesmallestintegerinthearray);
            Console.WriteLine(case14_FindthesmallestintegerinthearrayResultCleverLinq);

            // Case 15 Clever Linq
            int case15_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case15_Findthesmallestintegerinthearray);
            Console.WriteLine(case15_FindthesmallestintegerinthearrayResultCleverLinq);

            // Case 16 Clever Linq
            int case16_FindthesmallestintegerinthearrayResultCleverLinq = CodeWars.EightKyu.Findthesmallestintegerinthearray.Kata.FindSmallestIntCleverLinq(case16_Findthesmallestintegerinthearray);
            Console.WriteLine(case16_FindthesmallestintegerinthearrayResultCleverLinq);
        }


        private static void SumofSeriesFunc()
        {
            Program.Space();
            Program.Title("Sum of Series");

            // Case 1
            int NCase1 = 1;
            Console.WriteLine("Input: {0}", NCase1);
            long Output1 = GeeksForGeeks.School.SumofSeries.Solution.SeriesSum(NCase1);
            Console.WriteLine("Output: {0}", Output1);

            // Case 2
            int NCase2 = 5;
            Console.WriteLine("Input: {0}", NCase2);
            long Output2 = GeeksForGeeks.School.SumofSeries.Solution.SeriesSum(NCase2);
            Console.WriteLine("Output: {0}", Output2);
        }


        private static void PrintSecondLargestFunc()
        {
            Program.Space();
            Program.Title("Print Second Largest");

            // Case 1
            int[] case1_PrintSecondLargest = { 12, 35, 1, 10, 34, 1 };
            int NCase1_PrintSecondLargest = 6;
            int case1_PrintSecondLargestResult = GeeksForGeeks.School.SecondLargest.Solution.PrintSecondLargest(case1_PrintSecondLargest, NCase1_PrintSecondLargest);
            Console.WriteLine("Input: {0}", case1_PrintSecondLargestResult);
            Program.PrintArray(case1_PrintSecondLargest);
            Console.WriteLine("Output: {0}", case1_PrintSecondLargestResult);
            Program.Space();

            // Case 2
            int[] case2_PrintSecondLargest = { 10, 5, 10 };
            int NCase2_PrintSecondLargest = 3;
            int case2_PrintSecondLargestResult = GeeksForGeeks.School.SecondLargest.Solution.PrintSecondLargest(case2_PrintSecondLargest, NCase2_PrintSecondLargest);
            Console.WriteLine("Input: {0}", case2_PrintSecondLargestResult);
            Program.PrintArray(case2_PrintSecondLargest);
            Console.WriteLine("Output: {0}", case2_PrintSecondLargestResult);
            Program.Space();
        }


        private static void StringrporprFunc()
        {
            Program.Space();
            Program.Title("String rp or pr");

            // Case 1
            int X_Case1 = 5;
            int Y_Case1 = 4;
	        string S_Case1 = "abppprrr";
            long case1_Result = GeeksForGeeks.Medium.Stringrporpr.Solution.Solve(X_Case1, Y_Case1, S_Case1);
            Console.WriteLine("Input X Y S: {0} - {1} - {2}", X_Case1, Y_Case1, S_Case1);
            Console.WriteLine("Output: {0}", case1_Result);
            Program.Space();

            // Case 1
            int X_Case2 = 7;
            int Y_Case2 = 7;
	        string S_Case2 = "prpptppr";
            long Case2_Result = GeeksForGeeks.Medium.Stringrporpr.Solution.Solve(X_Case2, Y_Case2, S_Case2);
            Console.WriteLine("Input X Y S: {0} - {1} - {2}", X_Case2, Y_Case2, S_Case2);
            Console.WriteLine("Output: {0}", Case2_Result);
            Program.Space();
        }


        private static void CanPlaceFlowersFunc()
        {
            Program.Space();
            Program.Title("Can Place Flowers");

            // Case 1
            int[] arrayCase1_605 = { 1, 0, 0, 0, 1 };
            int intCase1_605 = 1;
            Console.WriteLine("Input: {0}", intCase1_605);
            Program.PrintArray(arrayCase1_605);
            bool case1_605Result = LeetCode.CanPlaceFlowers.Solution.CanPlaceFlowers(arrayCase1_605, intCase1_605);
            Console.WriteLine("Output: {0}", case1_605Result);
            Program.PrintArray(arrayCase1_605);
            Program.Space();

            // Case 2
            int[] arrayCase2_605 = { 1, 0, 0, 0, 1 };
            int intCase2_605 = 2;
            Console.WriteLine("Input: {0}", intCase2_605);
            Program.PrintArray(arrayCase2_605);
            bool case2_605Result = LeetCode.CanPlaceFlowers.Solution.CanPlaceFlowers(arrayCase2_605, intCase2_605);
            Console.WriteLine("Output: {0}", case2_605Result);
            Program.PrintArray(arrayCase2_605);
            Program.Space();

            // Case 3
            int[] arrayCase3_605 = { 1, 0, 0, 0, 0, 0, 1 };
            int intCase3_605 = 2;
            Console.WriteLine("Input: {0}", intCase3_605);
            Program.PrintArray(arrayCase3_605);
            bool case3_605Result = LeetCode.CanPlaceFlowers.Solution.CanPlaceFlowers(arrayCase3_605, intCase3_605);
            Console.WriteLine("Output: {0}", case3_605Result);
            Program.PrintArray(arrayCase3_605);
            Program.Space();
        }


        private static void NumberofZeroFilledSubarraysFunc()
        {
            Program.Space();
            Program.Title("Number of Zero-Filled Subarrays");

            // Case 1
            int[] arrayCase1_2348 = { 1, 3, 0, 0, 2, 0, 0, 4 };
            Console.WriteLine("Input:");
            Program.PrintArray(arrayCase1_2348);
            long case1_2348Result = LeetCode.NumberofZeroFilledSubarrays.Solution.ZeroFilledSubarray(arrayCase1_2348);
            Console.WriteLine("Output: {0}", case1_2348Result);
            Program.Space();

            // Case 2
            int[] arrayCase2_2348 = { 0, 0, 0, 2, 0, 0 };
            Console.WriteLine("Input:");
            Program.PrintArray(arrayCase2_2348);
            long case2_2348Result = LeetCode.NumberofZeroFilledSubarrays.Solution.ZeroFilledSubarray(arrayCase2_2348);
            Console.WriteLine("Output: {0}", case2_2348Result);
            Program.Space();
        }


        private static void MinimumScoreofaPathBetweenTwoCitiesFunc()
        {
            Program.Space();
            Program.Title("Minimum Score of a Path Between Two Cities");

            // Case 1
            int[][] roads2492Case1 = new int[][]
            {
                new int[] { 1, 2, 9 },
                new int[] { 2, 3, 6 },
                new int[] { 1, 4, 7 }
            };
            int n2492Case1 = 4;
            int result2492Case1 = LeetCode.MinimumScoreofaPathBetweenTwoCities.Solution.MinScore(n2492Case1, roads2492Case1);
            Console.WriteLine("Output: {0}", result2492Case1);

            // Case 2
            int[][] roads2492Case2 = new int[][]
            {
                new int[] { 1, 2, 2 },
                new int[] { 1, 3, 4 },
                new int[] { 3, 4, 7 }
            };
            int n2492Case2 = 4;
            int result2492Case2 = LeetCode.MinimumScoreofaPathBetweenTwoCities.Solution.MinScore(n2492Case2, roads2492Case2);
            Console.WriteLine("Output: {0}", result2492Case2);
        }


        private static void NumberofOperationstoMakeNetworkConnectedFunc()
        {
            Program.Space();
            Program.Title("Number of Operations to Make Network Connected");

            // Case 1
            int[][] connections1319Case1 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 1, 2 }
            };
            int n1319Case1 = 4;
            int result1319Case1 = LeetCode.NumberofOperationstoMakeNetworkConnected.Solution.MakeConnected(n1319Case1, connections1319Case1);
            Console.WriteLine("Output: {0}", result1319Case1);

            // Case 2
            int[][] connections1319Case2 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 0, 3 },
                new int[] { 1, 2 },
                new int[] { 1, 3 }
            };
            int n1319Case2 = 6;
            int result1319Case2 = LeetCode.NumberofOperationstoMakeNetworkConnected.Solution.MakeConnected(n1319Case2, connections1319Case2);
            Console.WriteLine("Output: {0}", result1319Case2);

            // Case 3
            int[][] connections1319Case3 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 0, 3 },
                new int[] { 1, 2 }
            };
            int n1319Case3 = 6;
            int result1319Case3 = LeetCode.NumberofOperationstoMakeNetworkConnected.Solution.MakeConnected(n1319Case3, connections1319Case3);
            Console.WriteLine("Output: {0}", result1319Case3);
        }


        private static void RemoveStringSpacesFunc()
        {
            Program.Space();
            Program.Title("Remove String Spaces");

            // Case 1
            string Case1 = "8 j 8   mBliB8g  imjB8B8  jl  B";
            Console.WriteLine("Input: {0}", Case1);
            string Case1_Result = CodeWars.EightKyu.RemoveStringSpaces.Solution.NoSpace(Case1);
            Console.WriteLine("Output: {0}", Case1_Result);
            Program.Space();

            // Case 2
            string Case2 = "8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd";
            Console.WriteLine("Input: {0}", Case2);
            string Case2_Result = CodeWars.EightKyu.RemoveStringSpaces.Solution.NoSpace(Case2);
            Console.WriteLine("Output: {0}", Case2_Result);
            Program.Space();

            // Case 3
            string Case3 = "8aaaaa dddd r     ";
            Console.WriteLine("Input: {0}", Case3);
            string Case3_Result = CodeWars.EightKyu.RemoveStringSpaces.Solution.NoSpace(Case3);
            Console.WriteLine("Output: {0}", Case3_Result);
            Program.Space();
        }

        
        private static void CountingsheepFunc()
        {
            Program.Space();
            Program.Title("Counting Sheep");

            // Case 1
            bool[] sheepsCase1 =
            {
                true,  true,  true,  false,
                true,  true,  true,  true ,
                true,  false, true,  false,
                true,  false, false, true ,
                true,  true,  true,  true ,
                false, false, true,  true
            };
            Console.WriteLine("Input:");
            Program.PrintBoolArray(sheepsCase1);
            int Case1_Sheeps = CodeWars.EightKyu.Countingsheep.Kata.CountSheeps(sheepsCase1);
            Console.WriteLine("Output: {0}", Case1_Sheeps);
            Program.Space();

            // Case 2
            bool[] sheepsCase2 = { true,  false,  true };
            Console.WriteLine("Input:");
            Program.PrintBoolArray(sheepsCase2);
            int Case2_Sheeps = CodeWars.EightKyu.Countingsheep.Kata.CountSheeps(sheepsCase2);
            Console.WriteLine("Output: {0}", Case2_Sheeps);
            Program.Space();
        }


        private static void ConvertaStringtoaNumberFunc()
        {
            Program.Space();
            Program.Title("Convert a String to a Number");

            string case1ConvertaStringtoaNumber = "1234";
            Console.WriteLine("Input: {0}", case1ConvertaStringtoaNumber);
            int resultcase1ConvertaStringtoaNumber = CodeWars.EightKyu.ConvertaStringtoaNumber.Solution.StringToNumber(case1ConvertaStringtoaNumber);
            int resultcase1ConvertaStringtoaNumberClever = CodeWars.EightKyu.ConvertaStringtoaNumber.Solution.StringToNumberClever(case1ConvertaStringtoaNumber);
            string case2ConvertaStringtoaNumber = "605";
            Console.WriteLine("Input: {0}", case2ConvertaStringtoaNumber);
            int resultcase2ConvertaStringtoaNumber = CodeWars.EightKyu.ConvertaStringtoaNumber.Solution.StringToNumber(case2ConvertaStringtoaNumber);
            int resultcase2ConvertaStringtoaNumberClever = CodeWars.EightKyu.ConvertaStringtoaNumber.Solution.StringToNumberClever(case2ConvertaStringtoaNumber);
            string case3ConvertaStringtoaNumber = "1405";
            Console.WriteLine("Input: {0}", case3ConvertaStringtoaNumber);
            int resultcase3ConvertaStringtoaNumber = CodeWars.EightKyu.ConvertaStringtoaNumber.Solution.StringToNumber(case3ConvertaStringtoaNumber);
            int resultcase3ConvertaStringtoaNumberClever = CodeWars.EightKyu.ConvertaStringtoaNumber.Solution.StringToNumberClever(case3ConvertaStringtoaNumber);
            string case4ConvertaStringtoaNumber = "-7";
            Console.WriteLine("Input: {0}", case4ConvertaStringtoaNumber);
            int resultcase4ConvertaStringtoaNumber = CodeWars.EightKyu.ConvertaStringtoaNumber.Solution.StringToNumber(case4ConvertaStringtoaNumber);
            int resultcase4ConvertaStringtoaNumberClever = CodeWars.EightKyu.ConvertaStringtoaNumber.Solution.StringToNumberClever(case4ConvertaStringtoaNumber);
        }


        private static void ReorderRoutestoMakeAllPathsLeadtotheCityZeroFunc()
        {
            Program.Space();
            Program.Title("Reorder Routes to Make All Paths Lead to the City Zero");
            
            // Case 1
            int[][] connections1466Case1 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 3 },
                new int[] { 2, 3 },
                new int[] { 4, 0 },
                new int[] { 4, 5 }
            };
            int n1466Case1 = 6;
            int result1466Case1 = LeetCode.ReorderRoutestoMakeAllPathsLeadtotheCityZero.Solution.MinReorder(n1466Case1, connections1466Case1);
            Console.WriteLine("Output: {0}", result1466Case1);

            // Case 2
            int[][] connections1466Case2 = new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 1, 2 },
                new int[] { 3, 2 },
                new int[] { 3, 4 }
            };
            int n1466Case2 = 5;
            int result1466Case2 = LeetCode.ReorderRoutestoMakeAllPathsLeadtotheCityZero.Solution.MinReorder(n1466Case2, connections1466Case2);
            Console.WriteLine("Output: {0}", result1466Case2);

            // Case 3
            int[][] connections1466Case3 = new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 2, 0 }
            };
            int n1466Case3 = 3;
            int result1466Case3 = LeetCode.ReorderRoutestoMakeAllPathsLeadtotheCityZero.Solution.MinReorder(n1466Case3, connections1466Case3);
            Console.WriteLine("Output: {0}", result1466Case3);
        }


        private static void CountUnreachablePairsofNodesinanUndirectedGraphFunc()
        {
            Program.Space();
            Program.Title("Count Unreachable Pairs of Nodes in an Undirected Graph");
            
            // Case 1
            int[][] edges2316Case1 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 1, 2 }
            };
            int n2316Case1 = 3;
            long Result2316Case1 = LeetCode.CountUnreachablePairsofNodesinanUndirectedGraph.Solution.CountPairs(n2316Case1, edges2316Case1);
            Console.WriteLine("Result Case 1: {0}", Result2316Case1);

            // Case 2
            int[][] edges2316Case2 = new int[][]
            {
                new int[] { 0, 2 },
                new int[] { 0, 5 },
                new int[] { 2, 4 },
                new int[] { 1, 6 },
                new int[] { 5, 4 }
            };
            int n2316Case2 = 7;
            long Result2316Case2 = LeetCode.CountUnreachablePairsofNodesinanUndirectedGraph.Solution.CountPairs(n2316Case2, edges2316Case2);
            Console.WriteLine("Result Case 2: {0}", Result2316Case2);
        }


        private static void LongestCycleinaGraphFunc()
        {
            Program.Space();
            Program.Title("Longest Cycle in a Graph");

            // Case 1
            int[] edges2360Case1 = { 3, 3, 4, 2, 3 };
            int result2360Case1 = LeetCode.LongestCycleinaGraph.Solution.LongestCycle(edges2360Case1);
            Console.WriteLine("Result Case 1: {0}", result2360Case1);

            // Case 2
            int[] edges2360Case2 = { 2, -1, 3, 1 };
            int result2360Case2 = LeetCode.LongestCycleinaGraph.Solution.LongestCycle(edges2360Case2);
            Console.WriteLine("Result Case 2: {0}", result2360Case2);
        }


        private static void MinimumPathSumFunc()
        {
            Program.Space();
            Program.Title("Minimum Path Sum");
            
            // Case 1
            int[][] grid64Case1 = new int[][]
            {
                new int[] { 1, 3, 1 },
                new int[] { 1, 5, 1 },
                new int[] { 4, 2, 1 }
            };
            int result64Case1 = LeetCode.MinimumPathSum.Solution.MinPathSum(grid64Case1);
            Console.WriteLine("Result Case 1: {0}", result64Case1);

            // Case 2
            int[][] grid64Case2 = new int[][]
            {
                new int[] { 1, 3, 1 },
                new int[] { 1, 5, 1 },
                new int[] { 4, 2, 1 }
            };
            int result64Case2 = LeetCode.MinimumPathSum.Solution.MinPathSum(grid64Case2);
            Console.WriteLine("Result Case 2: {0}", result64Case2);
        }


        private static void PrimeSubtractionOperationFunc()
        {
            Program.Space();
            Program.Title("Prime Subtraction Operation");

            // Case 1
            Program.Space();
            int[] nums2601Case1 = { 4, 9, 6, 10 };
            Console.WriteLine("Array Case 1: ");
            Program.PrintArray(nums2601Case1);
            bool result2601Case1 = LeetCode.PrimeSubtractionOperation.Solution.PrimeSubOperation(nums2601Case1);
            Console.WriteLine("Result Case 1: {0}", result2601Case1);

            // Case 2
            Program.Space();
            int[] nums2601Case2 = { 6, 8, 11, 12 };
            Console.WriteLine("Array Case 2: ");
            Program.PrintArray(nums2601Case2);
            bool result2601Case2 = LeetCode.PrimeSubtractionOperation.Solution.PrimeSubOperation(nums2601Case2);
            Console.WriteLine("Result Case 2: {0}", result2601Case2);

            // Case 3
            Program.Space();
            int[] nums2601Case3 = { 5, 8, 3 };
            Console.WriteLine("Array Case 3: ");
            Program.PrintArray(nums2601Case3);
            bool result2601Case3 = LeetCode.PrimeSubtractionOperation.Solution.PrimeSubOperation(nums2601Case3);
            Console.WriteLine("Result Case 3: {0}", result2601Case3);
        }


        private static void MinimumCostForTicketsFunc()
        {
            Program.Space();
            Program.Title("PMinimum Cost For Tickets");

            // Case 1
            int[] days983Case1 = { 1, 4, 6, 7, 8, 20 };
            int[] costs983Case1 = { 2, 7, 15 };
            Console.WriteLine("Days:");
            Program.PrintArray(days983Case1);
            Console.WriteLine("Costs:");
            Program.PrintArray(costs983Case1);
            int result983Case1 = LeetCode.MinimumCostForTickets.Solution.MincostTickets(days983Case1, costs983Case1);
            Console.WriteLine("Result: {0}", result983Case1);
            Program.Space();

            // Case 2
            int[] days983Case2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31 };
            int[] costs983Case2 = { 2, 7, 15 };
            Console.WriteLine("Days:");
            Program.PrintArray(days983Case2);
            Console.WriteLine("Costs:");
            Program.PrintArray(costs983Case2);
            int result983Case2 = LeetCode.MinimumCostForTickets.Solution.MincostTickets(days983Case2, costs983Case2);
            Console.WriteLine("Result: {0}", result983Case2);
        }


        private static void KItemsWiththeMaximumSumFunc()
        {
            Program.Space();
            Program.Title("K Items With the Maximum Sums");

            // Case 1
            int numOnes2600Case1 = 3;
            int numZeros2600Case1 = 2;
            int numNegOnes2600Case1 = 0;
            int k2600Case1 = 2;
            int result2600Case1 = LeetCode.KItemsWiththeMaximumSum.Solution.KItemsWithMaximumSum(numOnes2600Case1, numZeros2600Case1, numNegOnes2600Case1, k2600Case1);
            Console.WriteLine("numOnes = {0}, numZeros = {1}, numNegOnes = {2}, k = {3}, Result = {4}", numOnes2600Case1, numZeros2600Case1, numNegOnes2600Case1, k2600Case1, result2600Case1);

            // Case 2
            int numOnes2600Case2 = 3;
            int numZeros2600Case2 = 2;
            int numNegOnes2600Case2 = 0;
            int k2600Case2 = 4;
            int result2600Case2 = LeetCode.KItemsWiththeMaximumSum.Solution.KItemsWithMaximumSum(numOnes2600Case2, numZeros2600Case2, numNegOnes2600Case2, k2600Case2);
            Console.WriteLine("numOnes = {0}, numZeros = {1}, numNegOnes = {2}, k = {3}, Result = {4}", numOnes2600Case2, numZeros2600Case2, numNegOnes2600Case2, k2600Case2, result2600Case2);
        }


        private static void CounttheSubstringsFunc()
        {
            Program.Space();
            Program.Title("Count the Substrings");

            // Case 1
            string Case1S = "gEEk";
            Console.WriteLine("Case 1 {0}", Case1S);
            int resultCase1 = GeeksForGeeks.Easy.CounttheSubstrings.Solution.CountSubstring(Case1S);
            Console.WriteLine("Result {0}", resultCase1);

            // Case 2
            string Case2S = "WomensDAY";
            Console.WriteLine("Case 2 {0}", Case2S);
            int resultCase2 = GeeksForGeeks.Easy.CounttheSubstrings.Solution.CountSubstring(Case2S);
            Console.WriteLine("Result {0}", resultCase2);
        }


        private static void MinimumIntegerFunc()
        {
            Program.Space();
            Program.Title("Minimum Integer");

            // Case 1
            int N = 3;
            int[] A = { 1, 3, 2 };
            int resultCase1 = GeeksForGeeks.Easy.MinimumInteger.Solution.MinimumInteger(N, A);
            Console.WriteLine("Result {0}", resultCase1);
            
            // Case 2
            int N2 = 1;
            int[] A2 = { 3 };
            int resultCase2 = GeeksForGeeks.Easy.MinimumInteger.Solution.MinimumInteger(N2, A2);
            Console.WriteLine("Result {0}", resultCase2);
        }


        private static void EvenSwapFunc()
        {
            Program.Space();
            Program.Title("Even Swap");

            // Case 1
            int N1 = 3;
            int[] a1 = { 1, 3, 5 };
            int[] result1 = GeeksForGeeks.Medium.EvenSwap.Solution.LexicographicallyLargest(a1, N1);
            Program.PrintArray(result1);
            Program.Space();
        }


        private static void NumberofWaysofCuttingaPizzaFunc()
        {
            Program.Space();
            Program.Title("Number of Ways of Cutting a Pizza");
            
            // Case 1
            string[] pizza1444_1 = { "A..","AAA","..." };
            int k1444_1 = 3;
            Console.WriteLine("Case 1 : {0}", k1444_1);
            Program.PrintStringArray(pizza1444_1);
            int result1444_1 = LeetCode.NumberofWaysofCuttingaPizza.Solution.Ways(pizza1444_1, k1444_1);
            Console.WriteLine("Result : {0}", result1444_1);

            // Case 2
            string[] pizza1444_2 = { "A..","AA.","..." };
            int k1444_2 = 3;
            Console.WriteLine("Case 2 : {0}", k1444_2);
            Program.PrintStringArray(pizza1444_2);
            int result1444_2 = LeetCode.NumberofWaysofCuttingaPizza.Solution.Ways(pizza1444_2, k1444_2);
            Console.WriteLine("Result : {0}", result1444_2);

            // Case 3
            string[] pizza1444_3 = { "A..","A..","..." };
            int k1444_3 = 1;
            Console.WriteLine("Case 3 : {0}", k1444_3);
            Program.PrintStringArray(pizza1444_3);
            int result1444_3 = LeetCode.NumberofWaysofCuttingaPizza.Solution.Ways(pizza1444_3, k1444_3);
            Console.WriteLine("Result : {0}", result1444_3);
        }


        private static void ReducingDishesFunc()
        {
            Program.Space();
            Program.Title("Reducing Dishes");

            // Case 1
            Program.Space();
            int[] satisfaction1402_1 = { -1 , -8 , 0 , 5 , -9 };
            Program.PrintArray(satisfaction1402_1);
            int result1402_1 = LeetCode.ReducingDishes.Solution.MaxSatisfaction(satisfaction1402_1);
            Console.WriteLine("Result : {0}", result1402_1);

            // Case 2
            Program.Space();
            int[] satisfaction1402_2 = { 4, 3, 2 };
            Program.PrintArray(satisfaction1402_2);
            int result1402_2 = LeetCode.ReducingDishes.Solution.MaxSatisfaction(satisfaction1402_2);
            Console.WriteLine("Result : {0}", result1402_2);

            // Case 3
            Program.Space();
            int[] satisfaction1402_3 = { -1, -4 , -5 };
            Program.PrintArray(satisfaction1402_3);
            int result1402_3 = LeetCode.ReducingDishes.Solution.MaxSatisfaction(satisfaction1402_3);
            Console.WriteLine("Result : {0}", result1402_3);
        }


        private static void ScrambleStringFunc()
        {
            Program.Space();
            Program.Title("Scramble String");

            // Case 1
            string s1_87_1 = "great";
            string s2_87_1 = "rgeat";
            bool result87_1 = LeetCode.ScrambleString.Solution.IsScramble(s1_87_1, s2_87_1);
            Console.WriteLine("Result : {0}", result87_1);

            // Case 2
            string s1_87_2 = "great";
            string s2_87_2 = "rgeat";
            bool result87_2 = LeetCode.ScrambleString.Solution.IsScramble(s1_87_2, s2_87_2);
            Console.WriteLine("Result : {0}", result87_2);

            // Case 3
            string s1_87_3 = "great";
            string s2_87_3 = "rgeat";
            bool result87_3 = LeetCode.ScrambleString.Solution.IsScramble(s1_87_3, s2_87_3);
            Console.WriteLine("Result : {0}", result87_3);
        }


        private static void BinarySearchFunc()
        {
            Program.Space();
            Program.Title("Binary Search");

            // Case 1
            int[] nums704_1 = {-1,0,3,5,9,12};
            int target704_1 = 9;
            int result704_1 = LeetCode.BinarySearch.Solution.Search(nums704_1, target704_1);
            Console.WriteLine("Case 1");
            Program.PrintArray(nums704_1);
            Console.WriteLine(target704_1);
            Console.WriteLine("Result : {0}", result704_1);

            // Case 2
            Program.Space();
            int[] nums704_2 = {-1,0,3,5,9,12};
            int target704_2 = 2;
            int result704_2 = LeetCode.BinarySearch.Solution.Search(nums704_2, target704_2);
            Console.WriteLine("Case 2");
            Program.PrintArray(nums704_2);
            Console.WriteLine(target704_2);
            Console.WriteLine("Result : {0}", result704_2);
        }


        private static void SuccessfulPairsofSpellsandPotionsFunc()
        {
            Program.Space();
            Program.Title("Successful Pairs of Spells and Potions");

            // Case 1
            int[] spells2300_1 = {5,1,3};
            int[] potions2300_1 = {1,2,3,4,5};
            long success2300_1 = 7;
            int[] result2300_1 = LeetCode.SuccessfulPairsofSpellsandPotions.Solution.SuccessfulPairs(spells2300_1, potions2300_1, success2300_1);
            Console.WriteLine("Case 1 :");
            Program.PrintArray(result2300_1);

            // Case 2
            Program.Space();
            int[] spells2300_2 = {3,1,2};
            int[] potions2300_2 = {8,5,8};
            long success2300_2 = 16;
            int[] result2300_2 = LeetCode.SuccessfulPairsofSpellsandPotions.Solution.SuccessfulPairs(spells2300_2, potions2300_2, success2300_2);
            Console.WriteLine("Case 2 :");
            Program.PrintArray(result2300_2);
        }


        private static void BoatstoSavePeopleFunc()
        {
            Program.Space();
            Program.Title("Boats to Save People");

            Program.SubTitle("Solution 1");
            // Case 1
            int[] people881_1 = {1,2};
            int limit881_1 = 3;
            int result881_1 = LeetCode.BoatstoSavePeople.Solution.NumRescueBoats(people881_1, limit881_1);
            Console.WriteLine("Result : {0}", result881_1);

            // Case 2
            int[] people881_2 = {3,2,2,1};
            int limit881_2 = 3;
            int result881_2 = LeetCode.BoatstoSavePeople.Solution.NumRescueBoats(people881_2, limit881_2);
            Console.WriteLine("Result : {0}", result881_2);

            // Case 3
            int[] people881_3 = {3,5,3,4};
            int limit881_3 = 5;
            int result881_3 = LeetCode.BoatstoSavePeople.Solution.NumRescueBoats(people881_3, limit881_3);
            Console.WriteLine("Result : {0}", result881_3);

            Program.SubTitle("Solution 2");
            // Case 1
            int result881_1_2 = LeetCode.BoatstoSavePeople.Solution.NumRescueBoats2(people881_1, limit881_1);
            Console.WriteLine("Result : {0}", result881_1_2);

            // Case 2
            int result881_2_2 = LeetCode.BoatstoSavePeople.Solution.NumRescueBoats2(people881_2, limit881_2);
            Console.WriteLine("Result : {0}", result881_2_2);

            // Case 3
            int result881_3_2 = LeetCode.BoatstoSavePeople.Solution.NumRescueBoats(people881_3, limit881_3);
            Console.WriteLine("Result : {0}", result881_3_2);
        }


        private static void Remainderondividingby11Func()
        {
            Program.Space();
            Program.Title("Remainder on dividing by 11");

            // Case 1
            string RemainderCase1 = "1345";
            int RemainderCase1_Result = GeeksForGeeks.Easy.Remainderondividingby11.Solution.xmod11(RemainderCase1);
            Console.WriteLine("Result : {0}", RemainderCase1_Result);
            
            // Case 2
            string RemainderCase2 = "231456786543567898765";
            int RemainderCase2_Result = GeeksForGeeks.Easy.Remainderondividingby11.Solution.xmod11(RemainderCase2);
            Console.WriteLine("Result : {0}", RemainderCase2_Result);
        }


        private static void MakeArrayElementsEqualFunc()
        {
            Program.Space();
            Program.Title("Make Array Elements Equal");

            // Case 1
            long MakeArrayElementsEqual1 = GeeksForGeeks.Easy.MakeArrayElementsEqual.Solution.MinOperations(12);
            Console.WriteLine(MakeArrayElementsEqual1);

            // Case 2
            long MakeArrayElementsEqual2 = GeeksForGeeks.Easy.MakeArrayElementsEqual.Solution.MinOperations(3);
            Console.WriteLine(MakeArrayElementsEqual2);

            // Case 3
            long MakeArrayElementsEqual3 = GeeksForGeeks.Easy.MakeArrayElementsEqual.Solution.MinOperations(2);
            Console.WriteLine(MakeArrayElementsEqual3);
        }


        private static void OptimalPartitionofStringFunc()
        {
            Program.Space();
            Program.Title("Optimal Partition of String");

            // Case 1
            int Case1Result2405 = LeetCode.OptimalPartitionofString.Solution.PartitionString("abacaba");
            Console.WriteLine("Result 1 : {0}", Case1Result2405);

            // Case 2
            int Case2Result2405 = LeetCode.OptimalPartitionofString.Solution.PartitionString("ssssss");
            Console.WriteLine("Result 2 : {0}", Case2Result2405);
        }


        private static void MinimumStepsRequiredFunc()
        {
            Program.Space();
            Program.Title("Minimum Steps Required");

            // Case 1
            int case1_MinimumSteps = GeeksForGeeks.Medium.MinimumStepsRequired.Solution.minSteps("bbaaabb");
            Console.WriteLine("Result 1 : {0}", case1_MinimumSteps);

            // Case 2
            int case2_MinimumSteps = GeeksForGeeks.Medium.MinimumStepsRequired.Solution.minSteps("aababaa");
            Console.WriteLine("Result 2 : {0}", case2_MinimumSteps);
        }


        private static void MinimizeMaximumofArrayFunc()
        {
            Program.Space();
            Program.Title("Minimize Maximum of Array");

            // Case 1
            int[] nums2439_1 = {3,7,1,6};
            int result2439_1 = LeetCode.MinimizeMaximumofArray.Solution.MinimizeArrayValue(nums2439_1);
            Console.WriteLine("Result 1 : {0}", result2439_1);

            // Case 2
            int[] nums2439_2 = {10,1};
            int result2439_2 = LeetCode.MinimizeMaximumofArray.Solution.MinimizeArrayValue(nums2439_2);
            Console.WriteLine("Result 2 : {0}", result2439_2);
        }
        


        // CURRENT TESTS
        private static void CurrentTests()
        {
            MinimizeMaximumofArrayFunc(); // Medium LC
        }
    }
}