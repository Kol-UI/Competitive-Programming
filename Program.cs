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
            CheckifPointIsReachableFunc();
            SnakesAndLaddersFunc();
            FindClosestNodetoGivenTwoNodesFunc();
            ShuffleTheArrayFunc();
            CountOddNumbersInAnIntervalRangeFunc();
            FruitIntoBasketsFunc();
            JumpGameIIFunc();
            EvenOrOddFunc();
            NamingaCompanyFunc();
            AsFarfromLandasPossibleFunc();
            ShortestPathWithAlternatingColorsFunc();
            MinimumFuelCosttoReporttotheCapitalFunc();
            AddBinaryFunc();
            OppositeNumberFunc();
            ConvertaNumbertoaStringFunc();
            DefanginganIPAddressFunc();
            FindLuckyIntegerinanArrayFunc();
            ConvertbooleanvaluestostringsYesorNoFunc();
            SumOfPositiveFunc();
            StringRepeatFunc();
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


        public static void PrintArray(int[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
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


        private static void CheckifPointIsReachableFunc()
        {
            Space();
            Title("Check if Point Is Reachable");

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
            Space();
            Title("Snakes And Ladders");

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
            Space();
            Title("Find Closest Node to Given Two Nodes");

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
            Space();
            Title("Shuffle The Array");

            // Case 1
            int[] arrayCase1_1470 = { 2, 5, 1, 3, 4, 7 };
            int nCase1_1470 = 3;
            int[] Case1_1470_Result = LeetCode.ShuffletheArray.Solution.Shuffle(arrayCase1_1470, nCase1_1470);
            PrintArray(Case1_1470_Result);

            // Case 2
            int[] arrayCase2_1470 = { 1, 2, 3, 4, 4, 3, 2, 1 };
            int nCase2_1470 = 4;
            int[] Case2_1470_Result = LeetCode.ShuffletheArray.Solution.Shuffle(arrayCase2_1470, nCase2_1470);
            PrintArray(Case2_1470_Result);
            
            // Case 3
            int[] arrayCase3_1470 = { 1, 1, 2, 2 };
            int nCase3_1470 = 2;
            int[] Case3_1470_Result = LeetCode.ShuffletheArray.Solution.Shuffle(arrayCase3_1470, nCase3_1470);
            PrintArray(Case3_1470_Result);
        }


        private static void CountOddNumbersInAnIntervalRangeFunc()
        {
            Space();
            Title("Count Odd Numbers in an Interval Range");

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
            Space();
            Title("Fruit Into Baskets");

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
            Space();
            Title("Jump Game II");

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
            Space();
            Title("Even or Odd");

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
        }

        private static void NamingaCompanyFunc()
        {
            Space();
            Title("Naming a Company");

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
            Space();
            Title("As Far from Land as Possible");

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
            Space();
            Title("Shortest Path With Alternating Colors");

            // Case 1
            int nCase1_1129 = 3;
            int[][] redEdgesCase1_1129 = new int[][]
            {
                new int[] {0, 1},
                new int[] {1, 2}
            };
            int[][] blueEdgesCase1_1129 = new int[][] { };
            int[] Case1_1129_Result = LeetCode.ShortestPathwithAlternatingColors.Solution.ShortestAlternatingPaths(nCase1_1129, redEdgesCase1_1129, blueEdgesCase1_1129);
            PrintArray(Case1_1129_Result);

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
            PrintArray(Case2_1129_Result);

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
            PrintArray(Case3_1129_Result);
        }


        private static void MinimumFuelCosttoReporttotheCapitalFunc()
        {
            Space();
            Title("Minimum Fuel Cost to Report to the Capital");

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
            Space();
            Title("Add Binary");

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


        private static void OppositeNumberFunc()
        {
            Space();
            Title("Opposite number");
            System.Random random = new System.Random();

            // Case 1
            int case1IntOppositeNumber = 1;
            int Case1_OppositeNumber_Result = CodeWars.EightKyu.Oppositenumber.Solution.Opposite(case1IntOppositeNumber);
            Console.WriteLine(Case1_OppositeNumber_Result);

            // Case 2
            int case2IntOppositeNumber = -1;
            int Case2_OppositeNumber_Result = CodeWars.EightKyu.Oppositenumber.Solution.Opposite(case2IntOppositeNumber);
            Console.WriteLine(Case2_OppositeNumber_Result);            

            // Case 3
            int case3IntOppositeNumber = 14;
            int Case3_OppositeNumber_Result = CodeWars.EightKyu.Oppositenumber.Solution.Opposite(case3IntOppositeNumber);
            Console.WriteLine(Case3_OppositeNumber_Result);

            // Case 4
            int case4IntOppositeNumber = -14;
            int Case4_OppositeNumber_Result = CodeWars.EightKyu.Oppositenumber.Solution.Opposite(case4IntOppositeNumber);
            Console.WriteLine(Case4_OppositeNumber_Result);

            // Case 5
            int case5IntOppositeNumber = 34;
            int Case5_OppositeNumber_Result = CodeWars.EightKyu.Oppositenumber.Solution.Opposite(case5IntOppositeNumber);
            Console.WriteLine(Case5_OppositeNumber_Result);

            // Case 6
            int case6IntOppositeNumber = -34;
            int Case6_OppositeNumber_Result = CodeWars.EightKyu.Oppositenumber.Solution.Opposite(case6IntOppositeNumber);
            Console.WriteLine(Case6_OppositeNumber_Result);

            // Case 7
            int case7IntOppositeNumber = 0;
            int Case7_OppositeNumber_Result = CodeWars.EightKyu.Oppositenumber.Solution.Opposite(case7IntOppositeNumber);
            Console.WriteLine(Case7_OppositeNumber_Result);

            // Case 8
            int case8IntOppositeNumber = random.Next();
            int Case8_OppositeNumber_Result = CodeWars.EightKyu.Oppositenumber.Solution.Opposite(case8IntOppositeNumber);
            Console.WriteLine(Case8_OppositeNumber_Result);
            
            // Case 9
            int case9IntOppositeNumber = random.Next();
            int Case9_OppositeNumber_Result = CodeWars.EightKyu.Oppositenumber.Solution.Opposite(case9IntOppositeNumber);
            Console.WriteLine(Case9_OppositeNumber_Result);

            // Case 10
            int case10IntOppositeNumber = random.Next();
            int Case10_OppositeNumber_Result = CodeWars.EightKyu.Oppositenumber.Solution.Opposite(case10IntOppositeNumber);
            Console.WriteLine(Case10_OppositeNumber_Result);
        }


        private static void ConvertaNumbertoaStringFunc()
        {
            Space();
            Title("Convert a Number to a String");
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
            Space();
            Title("Defanging an IP Address");

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
            Space();
            Title("Find Lucky Integer in an Array");
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
            Space();
            Title("Convert boolean values to strings Yes or No");

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
            Space();
            Title("Sum Of Positive");
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
            Space();
            Title("String Repeat");
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
            Space();
        }

    }
}