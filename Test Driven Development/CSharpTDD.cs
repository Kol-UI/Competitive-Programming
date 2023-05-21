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
            EqualLeftandRightSubarraySumFunc();
        }


        // MEDIUM GEEKSFORGEEKS
        private static void MediumGeeksForGeeksTests()
        {
            StringrporprFunc();
            EvenSwapFunc();
            MinimumStepsRequiredFunc();
            AddMinimumCharactersFunc();
            MaximumLengthFunc();
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
            CheckIfNandItsDoubleExistFunc();
            ConcatenationofArrayFunc();
            KidsWiththeGreatestNumberofCandiesFunc();
            MergeStringsAlternatelyFunc();
            RomantoIntegerFunc();
            BestPokerHandFunc();
            LastStoneWeightFunc();
            AddDigitsFunc();
            BulbSwitcherFunc();
            FindtheDifferenceFunc();
            RepeatedSubstringPatternFunc();
            MoveZeroesFunc();
            PlusOneFunc();
            AverageSalaryExcludingtheMinimumandMaximumSalaryFunc();
            SignoftheProductofanArrayFunc();
            CanMakeArithmeticProgressionFunc();
            MonotonicArrayFunc();
            LengthofLastWordFunc();
            ToLowerCaseFunc();
            FindSmallestLetterGreaterThanTargetFunc();
            CountNegativeNumbersinaSortedMatrixFunc();
            ValidPerfectSquareFunc();
            ArrangingCoinsFunc();
            BaseballGameFunc();
            RobotReturntoOriginFunc();
            FindWinneronaTicTacToeGameFunc();
            LemonadeChangeFunc();
            LargestPerimeterTriangleFunc();
            CheckIfItIsaStraightLineFunc();
            ReverseVowelsofaStringFunc();
            CountingBitsFunc();
            IsSubsequenceFunc();
            MinCostClimbingStairsFunc();
            MaximumAverageSubarrayIFunc();
            FindtheHighestAltitudeFunc();
            FindPivotIndexFunc();
            UniqueNumberofOccurrencesFunc();
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
            NumberofEnclavesFunc();
            RemoveStarsFunc();
            NumberofClosedIslandsFunc();
            SimplifyPathFunc();
            ValidateStackSequencesFunc();
            LongestPalindromicSubsequenceFunc();
            NonoverlappingIntervalsFunc();
            RobotBoundedInCircleFunc();
            MatrixDiagonalSumFunc();
            MultiplyStringsFunc();
            PowxnFunc();
            ReverseWordsinaStringFunc();
            ProductofArrayExceptSelfFunc();
            Dota2SenateFunc();
            MinimumFlipstoMakeaORbEqualtocFunc();
            BestTimetoBuyandSellStockwithTransactionFeeFunc();
            IncreasingTripletSubsequenceFunc();
            MaximumNumberofVowelsinaSubstringofGivenLengthFunc();
            DominoandTrominoTilingFunc();
            ContainerWithMostWaterFunc();
            MaxNumberofKSumPairsFunc();
            UniquePathsFunc();
            MaxConsecutiveOnesIIIFunc();
            LongestSubarrayof1sAfterDeletingOneElementFunc();
            NumberofProvincesFunc();
            NumberofSubsequencesThatSatisfytheGivenSumConditionFunc();
            AsteroidCollisionFunc();
            FindPeakElementFunc();
            WateringPlantsIIFunc();
            CarPoolingFunc();
            CountWaysToBuildGoodStringsFunc();
            TotalCosttoHireKWorkersFunc();
            MaximumSubsequenceScoreFunc();
            KthLargestElementinanArrayFunc();
            EqualRowandColumnPairsFunc();
            DetermineifTwoStringsAreCloseFunc();
            IsGraphBipartiteFunc();
            NextPermutationFunc();
            ShortestBridgeFunc();
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
            MinimumReverseOperationsFunc();
            LargestColorValueinaDirectedGraphFunc();
            MaximumValueofKCoinsFromPilesFunc();
            NumberofWaystoFormaTargetStringGivenaDictionaryFunc();
            ProfitableSchemesFunc();
            MinimumInsertionStepstoMakeaStringPalindromeFunc();
            RestoreTheArrayFunc();
            FindtheLongestValidObstacleCourseatEachPositionFunc();
            MaximizeScoreAfterNOperationsFunc();
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


        private static void EqualLeftandRightSubarraySumFunc()
        {
            Program.Space();
            Program.Title("Equal Left and Right Subarray Sum");

            // Case 1
            int[] ACase1 = {1,3,5,2,2};
            int n1 = 5;
            int Output1 = GeeksForGeeks.Easy.EqualLeftandRightSubarraySum.Solution.EqualSum(ACase1 , n1);
            Console.WriteLine("Result 1 : {0}", Output1);

            // Case2
            int[] ACase2 = {1};
            int n2 = 1;
            int Output2 = GeeksForGeeks.Easy.EqualLeftandRightSubarraySum.Solution.EqualSum(ACase1 , n2);
            Console.WriteLine("Result 2 : {0}", Output2);
        }


        private static void AddMinimumCharactersFunc()
        {
            Program.Space();
            Program.Title("Add Minimum Characters");

            // Case 1
            int Output1 = GeeksForGeeks.Medium.AddMinimumCharacters.Solution.AddMinChar("ABCD");
            Console.WriteLine("Result 1 : {0}", Output1);

            // Case 2
            int Output2 = GeeksForGeeks.Medium.AddMinimumCharacters.Solution.AddMinChar("ABA");
            Console.WriteLine("Result 2 : {0}", Output2);
        }


        private static void NumberofEnclavesFunc()
        {
            Program.Space();
            Program.Title("Number of Enclaves");

            // Case 1
            int[][] Grid1020_1 = new int[][]
            {
                new int[]{0,0,0,0},
                new int[]{1,0,1,0},
                new int[]{0,1,1,0},
                new int[]{0,0,0,0}
            };
            int Result1020_1 = LeetCode.NumberofEnclaves.Solution.NumEnclaves(Grid1020_1);
            Console.WriteLine("Result 1 : {0}", Result1020_1);

            // Case 2
            int[][] Grid1020_2 = new int[][]
            {
                new int[]{0,1,1,0},
                new int[]{0,0,1,0},
                new int[]{0,0,1,0},
                new int[]{0,0,0,0}
            };
            int Result1020_2 = LeetCode.NumberofEnclaves.Solution.NumEnclaves(Grid1020_2);
            Console.WriteLine("Result 2 : {0}", Result1020_2);
        }


        private static void RemoveStarsFunc()
        {
            Program.Space();
            Program.Title("Removing Stars From a String");

            // Case 1
            string output2390_1 = LeetCode.RemovingStarsFromaString.Solution.RemoveStars("leet**cod*e");
            Console.WriteLine("Result 1 : {0}", output2390_1);

            // Case 2
            string output2390_2 = LeetCode.RemovingStarsFromaString.Solution.RemoveStars("erase*****");
            Console.WriteLine("Result 2 : {0}", output2390_2);
        }


        private static void NumberofClosedIslandsFunc()
        {
            Program.Space();
            Program.Title("Number of Closed Islands");

            // Case 1
            int[][] Grid1254_1 = new int[][]
            {
                new int[]{1,1,1,1,1,1,1,0},
                new int[]{1,0,0,0,0,1,1,0},
                new int[]{1,0,1,0,1,1,1,0},
                new int[]{1,0,0,0,0,1,0,1},
                new int[]{1,1,1,1,1,1,1,0}
            };
            int result1254_1 = LeetCode.NumberofClosedIslands.Solution.ClosedIsland(Grid1254_1);
            Console.WriteLine("Result 1 : {0}", result1254_1);

            // Case 2
            int[][] Grid1254_2 = new int[][]
            {
                new int[]{1,1,1,1,1,1,1},
                new int[]{1,0,0,0,0,0,1},
                new int[]{1,0,1,1,1,0,1},
                new int[]{1,0,1,0,1,0,1},
                new int[]{1,0,1,1,1,0,1},
                new int[]{1,0,0,0,0,0,1},
                new int[]{1,1,1,1,1,1,1}
            };
            int result1254_2 = LeetCode.NumberofClosedIslands.Solution.ClosedIsland(Grid1254_2);
            Console.WriteLine("Result 2 : {0}", result1254_2);

            // Case 3
            int[][] Grid1254_3 = new int[][]
            {
                new int[]{0,0,1,0,0},
                new int[]{0,1,0,1,0},
                new int[]{0,1,1,1,0}
            };
            int result1254_3 = LeetCode.NumberofClosedIslands.Solution.ClosedIsland(Grid1254_3);
            Console.WriteLine("Result 3 : {0}", result1254_3);
        }


        private static void CheckIfNandItsDoubleExistFunc()
        {
            Program.Space();
            Program.Title("Check If N and Its Double Exist");

            // Case 1
            int[] arr2346_1 = {10,2,5,3};
            bool result2346_1 = LeetCode.CheckIfNandItsDoubleExist.Solution.CheckIfExist(arr2346_1);
            Console.WriteLine("Result 1 : {0}", result2346_1);
            
            // Case 2
            int[] arr2346_2 = {3,1,7,11};
            bool result2346_2 = LeetCode.CheckIfNandItsDoubleExist.Solution.CheckIfExist(arr2346_2);
            Console.WriteLine("Result 2 : {0}", result2346_2);
        }


        private static void MinimumReverseOperationsFunc()
        {
            Program.Space();
            Program.Title("Minimum Reverse Operations");

            // Case 1
            int n_2612_1 = 4;
            int p_2612_1 = 0;
            int[] banned_2612_1 = {1,2};
            int k_2612_1 = 4;
            int[] result2612_1 = LeetCode.MinimumReverseOperations.Solution.MinReverseOperations(n_2612_1, p_2612_1, banned_2612_1, k_2612_1);
            Console.WriteLine("Result 1 :");
            Program.PrintArray(result2612_1);

            // Case 2
            int n_2612_2 = 5;
            int p_2612_2 = 0;
            int[] banned_2612_2 = {2,4};
            int k_2612_2 = 3;
            int[] result2612_2 = LeetCode.MinimumReverseOperations.Solution.MinReverseOperations(n_2612_2, p_2612_2, banned_2612_2, k_2612_2);
            Console.WriteLine("Result 2 :");
            Program.PrintArray(result2612_2);

            // Case 3
            int n_2612_3 = 4;
            int p_2612_3 = 2;
            int[] banned_2612_3 = {0,1,3};
            int k_2612_3 = 1;
            int[] result2612_3 = LeetCode.MinimumReverseOperations.Solution.MinReverseOperations(n_2612_3, p_2612_3, banned_2612_3, k_2612_3);
            Console.WriteLine("Result 3 :");
            Program.PrintArray(result2612_3);
        }


        private static void LargestColorValueinaDirectedGraphFunc()
        {
            Program.Space();
            Program.Title("Largest Color Value in a Directed Graph");

            // Case 1
            string colors1857_1 = "abaca";
            int[][] edges1857_1 = new int[][]
            {
                new int[]{0,1},
                new int[]{0,2},
                new int[]{2,3},
                new int[]{3,4}
            };
            int result1857_1 = LeetCode.LargestColorValueinaDirectedGraph.Solution.LargestPathValue(colors1857_1, edges1857_1);
            Console.WriteLine("Result 1 : {0}", result1857_1);

            // Case 2
            string colors1857_2 = "a";
            int[][] edges1857_2 = new int[][]
            {
                new int[]{0,0}
            };
            int result1857_2 = LeetCode.LargestColorValueinaDirectedGraph.Solution.LargestPathValue(colors1857_2, edges1857_2);
            Console.WriteLine("Result 2 : {0}", result1857_2);
        }


        private static void SimplifyPathFunc()
        {
            Program.Space();
            Program.Title("Simplify Path");

            // Case 1
            string result71_1 = LeetCode.SimplifyPath.Solution.SimplifyPath("/home/");
            Console.WriteLine("Result 1 : {0}", result71_1);

            // Case 2
            string result71_2 = LeetCode.SimplifyPath.Solution.SimplifyPath("/../");
            Console.WriteLine("Result 2 : {0}", result71_2);

            // Case 3
            string result71_3 = LeetCode.SimplifyPath.Solution.SimplifyPath("/home//foo/");
            Console.WriteLine("Result 3 : {0}", result71_3);
        }


        private static void MaximumLengthFunc()
        {
            Program.Space();
            Program.Title("Maximum Length");

            // Case 1
            int result_testML_1 = GeeksForGeeks.Medium.MaximumLength.Solution.Solve(3, 3, 3);
            Console.WriteLine("Result 1 : {0}", result_testML_1);

            // Case 2
            int result_testML_2 = GeeksForGeeks.Medium.MaximumLength.Solution.Solve(11, 2, 2);
            Console.WriteLine("Result 2 : {0}", result_testML_2);
        }


        private static void ValidateStackSequencesFunc()
        {
            Program.Space();
            Program.Title("Validate Stack Sequences");

            // Case 1
            int[] pushed1 = {1,2,3,4,5};
            int[] popped1 = {4,5,3,2,1};
            bool case1_946 = LeetCode.ValidateStackSequences.Solution.ValidateStackSequences(pushed1, popped1);
            Console.WriteLine("Pushed 1 :");
            Program.PrintArray(pushed1);
            Console.WriteLine("Popped 1 :");
            Program.PrintArray(popped1);
            Console.WriteLine("Result 1 : {0}", case1_946);
            Program.Space();

            // Case 2
            int[] pushed2 = {1,2,3,4,5};
            int[] popped2 = {4,3,5,1,2};
            bool case2_946 = LeetCode.ValidateStackSequences.Solution.ValidateStackSequences(pushed2, popped2);
            Console.WriteLine("Pushed 2 :");
            Program.PrintArray(pushed2);
            Console.WriteLine("Popped 2 :");
            Program.PrintArray(popped2);
            Console.WriteLine("Result 2 : {0}", case2_946);
            Program.Space();
        }


        private static void LongestPalindromicSubsequenceFunc()
        {
            Program.Space();
            Program.Title("Longest Palindromic Subsequence");

            // Case 1
            string s516_1 = "bbbab";
            int output516_1 = LeetCode.LongestPalindromicSubsequence.Solution.LongestPalindromeSubseq(s516_1);
            Console.WriteLine("Case 1 : {0}", s516_1);
            Console.WriteLine("Result 1 : {0}", output516_1);
            Program.Space();

            // Case 2
            string s516_2 = "cbbd";
            int output516_2 = LeetCode.LongestPalindromicSubsequence.Solution.LongestPalindromeSubseq(s516_2);
            Console.WriteLine("Case 2 : {0}", s516_2);
            Console.WriteLine("Result 2 : {0}", output516_2);
            Program.Space();

            // Case 3
            string s516_3 = "noon";
            int output516_3 = LeetCode.LongestPalindromicSubsequence.Solution.LongestPalindromeSubseq(s516_3);
            Console.WriteLine("Case 3 : {0}", s516_3);
            Console.WriteLine("Result 3 : {0}", output516_3);
            Program.Space();

            // Case 4
            string s516_4 = "civic";
            int output516_4 = LeetCode.LongestPalindromicSubsequence.Solution.LongestPalindromeSubseq(s516_4);
            Console.WriteLine("Case 4 : {0}", s516_4);
            Console.WriteLine("Result 4 : {0}", output516_4);
            Program.Space();

            // Case 5
            string s516_5 = "racecar";
            int output516_5 = LeetCode.LongestPalindromicSubsequence.Solution.LongestPalindromeSubseq(s516_5);
            Console.WriteLine("Case 5 : {0}", s516_5);
            Console.WriteLine("Result 5 : {0}", output516_5);
            Program.Space();

            // Case 6
            string s516_6 = "level";
            int output516_6 = LeetCode.LongestPalindromicSubsequence.Solution.LongestPalindromeSubseq(s516_6);
            Console.WriteLine("Case 6 : {0}", s516_6);
            Console.WriteLine("Result 6 : {0}", output516_6);
            Program.Space();

            // Case 7
            string s516_7 = "mom";
            int output516_7 = LeetCode.LongestPalindromicSubsequence.Solution.LongestPalindromeSubseq(s516_7);
            Console.WriteLine("Case 7 : {0}", s516_7);
            Console.WriteLine("Result 7 : {0}", output516_7);
            Program.Space();
        }


        private static void MaximumValueofKCoinsFromPilesFunc()
        {
            Program.Space();
            Program.Title("Maximum Value of K Coins From Piles");

            // Case 1
            int[][] piles1_2218 = new int[][]
            {
                new int[]{1,100,3},
                new int[]{7,8,9}
            };
            int k1_2218 = 2;
            int output1_2218 = LeetCode.MaximumValueofKCoinsFromPiles.Solution.MaxValueOfCoins(piles1_2218, k1_2218);
            Console.WriteLine("Result 1 : {0}", output1_2218);
            Program.Space();

            // Case 2
            int[][] piles2_2218 = new int[][]
            {
                new int[]{100},
                new int[]{100},
                new int[]{100},
                new int[]{100},
                new int[]{100},
                new int[]{100},
                new int[]{1,1,1,1,1,1,700}
            };
            int k2_2218 = 7;
            int output2_2218 = LeetCode.MaximumValueofKCoinsFromPiles.Solution.MaxValueOfCoins(piles2_2218, k2_2218);
            Console.WriteLine("Result 2 : {0}", output2_2218);
            Program.Space();
        }


        private static void ConcatenationofArrayFunc()
        {
            Program.Space();
            Program.Title("Concatenation of Array");

            // Case 1
            int[] nums1_1929 = {1,2,1};
            int[] output1_1929 = LeetCode.ConcatenationofArray.Solution.GetConcatenation(nums1_1929);
            Console.WriteLine("Result 1 :");
            Program.PrintArray(output1_1929);
            Program.Space();

            // Case 2
            int[] nums2_1929 = {1,3,2,1};
            int[] output2_1929 = LeetCode.ConcatenationofArray.Solution.GetConcatenation(nums2_1929);
            Console.WriteLine("Result 2 :");
            Program.PrintArray(output2_1929);
            Program.Space();
        }


        private static void NumberofWaystoFormaTargetStringGivenaDictionaryFunc()
        {
            Program.Space();
            Program.Title("Number of Ways to Form a Target String Given a Dictionary");

            // Case 1
            string[] words1_1639 = {"acca","bbbb","caca"};
            string target1_1639 = "aba";
            int result1_1639 = LeetCode.NumberofWaystoFormaTargetStringGivenaDictionary.Solution.NumWays(words1_1639, target1_1639);
            Console.WriteLine("Result 1 : {0}", result1_1639);
            Program.Space();

            // Case 2
            string[] words2_1639 = {"abba","baab"};
            string target2_1639 = "bab";
            int result2_1639 = LeetCode.NumberofWaystoFormaTargetStringGivenaDictionary.Solution.NumWays(words2_1639, target2_1639);
            Console.WriteLine("Result 2 : {0}", result2_1639);
            Program.Space();
        }


        private static void KidsWiththeGreatestNumberofCandiesFunc()
        {
            Program.Space();
            Program.Title("Kids With the Greatest Number of Candies");

            // Case 1
            int[] candies1 = {2,3,5,1,3};
            int extraCandies1 = 3;
            IList<bool> result1 = LeetCode.KidsWiththeGreatestNumberofCandies.Solution.KidsWithCandies(candies1, extraCandies1);
            Console.WriteLine("[{0}]", string.Join(", ", result1));

            // Case 1
            int[] candies2 = {4,2,1,1,2};
            int extraCandies2 = 1;
            IList<bool> result2 = LeetCode.KidsWiththeGreatestNumberofCandies.Solution.KidsWithCandies(candies2, extraCandies2);
            Console.WriteLine("[{0}]", string.Join(", ", result2));
        }


        private static void MergeStringsAlternatelyFunc()
        {
            Program.Space();
            Program.Title("Merge Strings Alternately");

            // Case 1
            string Case1_1768 = LeetCode.MergeStringsAlternately.Solution.MergeAlternately("abc", "pqr");
            Console.WriteLine("Result 1 : {0}", Case1_1768);

            // Case 2
            string Case2_1768 = LeetCode.MergeStringsAlternately.Solution.MergeAlternately("ab", "pqrs");
            Console.WriteLine("Result 2 : {0}", Case2_1768);

            // Case 3
            string Case3_1768 = LeetCode.MergeStringsAlternately.Solution.MergeAlternately("abcd", "pq");
            Console.WriteLine("Result 3 : {0}", Case3_1768);
        }


        private static void RomantoIntegerFunc()
        {
            Program.Space();
            Program.Title("Roman to Integer");

            // Case 1
            int Case1_13 = LeetCode.RomantoInteger.Solution.RomanToInt("III");
            Console.WriteLine("Result 1 : {0}", Case1_13);

            // Case 2
            int Case2_13 = LeetCode.RomantoInteger.Solution.RomanToInt("LVIII");            
            Console.WriteLine("Result 2 : {0}", Case2_13);

            // Case 3
            int Case3_13 = LeetCode.RomantoInteger.Solution.RomanToInt("MCMXCIV");
            Console.WriteLine("Result 3 : {0}", Case3_13);
        }


        private static void ProfitableSchemesFunc()
        {
            Program.Space();
            Program.Title("Profitable Schemes");

            // Case 1
            int n1 = 5;
            int minProfit1 = 3;
            int[] group1 = {2,2};
            int[] profit1 = {2,3};
            int Case1_879 = LeetCode.ProfitableSchemes.Solution.ProfitableSchemes(n1, minProfit1, group1, profit1);
            Console.WriteLine("Result 1 : {0}", Case1_879);

            // Case 2
            int n2 = 10;
            int minProfit2 = 5;
            int[] group2 = {2,3,5};
            int[] profit2 = {6,7,8};
            int Case2_879 = LeetCode.ProfitableSchemes.Solution.ProfitableSchemes(n2, minProfit2, group2, profit2);
            Console.WriteLine("Result 2 : {0}", Case2_879);
        }


        private static void MinimumInsertionStepstoMakeaStringPalindromeFunc()
        {
            Program.Space();
            Program.Title("Minimum Insertion Steps to Make a String Palindrome");

            // Case 1
            int Case1_1312 = LeetCode.MinimumInsertionStepstoMakeaStringPalindrome.Solution.MinInsertions("zzazz");
            Console.WriteLine("Result 1 : {0}", Case1_1312);

            // Case 2
            int Case2_1312 = LeetCode.MinimumInsertionStepstoMakeaStringPalindrome.Solution.MinInsertions("mbadm");
            Console.WriteLine("Result 2 : {0}", Case2_1312);

            // Case 3
            int Case3_1312 = LeetCode.MinimumInsertionStepstoMakeaStringPalindrome.Solution.MinInsertions("leetcode");
            Console.WriteLine("Result 3 : {0}", Case3_1312);
        }


        private static void BestPokerHandFunc()
        {
            Program.Space();
            Program.Title("Best Poker Hand");

            // Case 1
            int[] ranks1 = {13,2,3,1,9};
            char[] suits1 = {'a','a','a','a','a'};
            string Case1_2347 = LeetCode.BestPokerHand.Solution.BestHand(ranks1, suits1);
            Console.WriteLine("Result 1 : {0}", Case1_2347);

            // Case 2
            int[] ranks2 = {4,4,2,4,4};
            char[] suits2 = {'d','a','a','b','c'};
            string Case2_2347 = LeetCode.BestPokerHand.Solution.BestHand(ranks2, suits2);
            Console.WriteLine("Result 2 : {0}", Case2_2347);

            // Case 3
            int[] ranks3 = {10,10,2,12,9};
            char[] suits3 = {'a','b','c','a','d'};
            string Case3_2347 = LeetCode.BestPokerHand.Solution.BestHand(ranks3, suits3);
            Console.WriteLine("Result 3 : {0}", Case3_2347);
        }


        private static void RestoreTheArrayFunc()
        {
            Program.Space();
            Program.Title("Restore The Array");

            // Case 1
            int Case1_1416 = LeetCode.RestoreTheArray.Solution.NumberOfArrays("1000", 10000);
            Console.WriteLine("Result 1 : {0}", Case1_1416);

            // Case 2
            int Case2_1416 = LeetCode.RestoreTheArray.Solution.NumberOfArrays("1000", 10);
            Console.WriteLine("Result 2 : {0}", Case2_1416);

            // Case 3
            int Case3_1416 = LeetCode.RestoreTheArray.Solution.NumberOfArrays("1317", 200);
            Console.WriteLine("Result 3 : {0}", Case3_1416);
        }


        private static void LastStoneWeightFunc()
        {
            Program.Space();
            Program.Title("Last Stone Weight");

            // Case 1
            int[] stones1 = {2,7,4,1,8,1};
            int result1_1046 = LeetCode.LastStoneWeight.Solution.LastStoneWeight(stones1);
            Console.WriteLine("Result 1 : {0}", result1_1046);

            // Case 2
            int[] stones2 = {1};
            int result2_1046 = LeetCode.LastStoneWeight.Solution.LastStoneWeight(stones2);
            Console.WriteLine("Result 2 : {0}", result2_1046);
        }


        private static void AddDigitsFunc()
        {
            Program.Space();
            Program.Title("Add Digits");

            // Case 1
            int Case1_258 = LeetCode.AddDigits.Solution.AddDigits(38);
            Console.WriteLine("Result 1 : {0}", Case1_258);

            // Case 2
            int Case2_258 = LeetCode.AddDigits.Solution.AddDigits(0);
            Console.WriteLine("Result 2 : {0}", Case2_258);
        }


        private static void BulbSwitcherFunc()
        {
            Program.Space();
            Program.Title("Bulb Switcher");

            // Case 1
            int Case1_319 = LeetCode.BulbSwitcher.Solution.BulbSwitch(3);
            Console.WriteLine("Result 1 : {0}", Case1_319);

            // Case 2
            int Case2_319 = LeetCode.BulbSwitcher.Solution.BulbSwitch(0);
            Console.WriteLine("Result 2 : {0}", Case2_319);

            // Case 3
            int Case3_319 = LeetCode.BulbSwitcher.Solution.BulbSwitch(1);
            Console.WriteLine("Result 3 : {0}", Case3_319);
        }


        private static void FindtheDifferenceFunc()
        {
            Program.Space();
            Program.Title("Find the Difference");

            // Case 1
            char Case1_389 = LeetCode.FindtheDifference.Solution.FindTheDifference("abcd", "abcde");
            Console.WriteLine("Result 1 : {0}", Case1_389);

            // Case 2
            char Case2_389 = LeetCode.FindtheDifference.Solution.FindTheDifference("", "y");
            Console.WriteLine("Result 2 : {0}", Case2_389);
        }


        private static void RepeatedSubstringPatternFunc()
        {
            Program.Space();
            Program.Title("Repeated Substring Pattern");

            // Case 1
            bool Case1_459 = LeetCode.RepeatedSubstringPattern.Solution.RepeatedSubstringPattern("abab");
            Console.WriteLine("Result 1 : {0}", Case1_459);

            // Case 2
            bool Case2_459 = LeetCode.RepeatedSubstringPattern.Solution.RepeatedSubstringPattern("aba");
            Console.WriteLine("Result 2 : {0}", Case2_459);

            // Case 3
            bool Case3_459 = LeetCode.RepeatedSubstringPattern.Solution.RepeatedSubstringPattern("abcabcabcabc");
            Console.WriteLine("Result 3 : {0}", Case3_459);
        }


        private static void MoveZeroesFunc()
        {
            Program.Space();
            Program.Title("Move Zeroes");

            // Case 1
            int[] Case1_283 = {0,1,0,3,12};
            Console.WriteLine("Case 1 Before :");
            Program.PrintArray(Case1_283);
            LeetCode.MoveZeroes.Solution.MoveZeroes(Case1_283);
            Console.WriteLine("Case 1 After :");
            Program.PrintArray(Case1_283);
            Program.Space();

            // Case 2
            int[] Case2_283 = {0};
            Console.WriteLine("Case 2 Before :");
            Program.PrintArray(Case2_283);
            LeetCode.MoveZeroes.Solution.MoveZeroes(Case2_283);
            Console.WriteLine("Case 2 After :");
            Program.PrintArray(Case2_283);
            Program.Space();
        }


        private static void PlusOneFunc()
        {
            Program.Space();
            Program.Title("Plus One");

            // Case 1
            int[] digits1_66 = {1,2,3};
            int[] result1_66 = LeetCode.PlusOne.Solution.PlusOne(digits1_66);
            Console.WriteLine("Case 1 :");
            Program.PrintBeforeAfterIntArray(digits1_66, result1_66); 

            // Case 2
            int[] digits2_66 = {4,3,2,1};
            int[] result2_66 = LeetCode.PlusOne.Solution.PlusOne(digits2_66);
            Console.WriteLine("Case 2 :");
            Program.PrintBeforeAfterIntArray(digits2_66, result2_66);

            // Case 3
            int[] digits3_66 = {9};
            int[] result3_66 = LeetCode.PlusOne.Solution.PlusOne(digits3_66);
            Console.WriteLine("Case 3 :");
            Program.PrintBeforeAfterIntArray(digits3_66, result3_66);
        }


        private static void AverageSalaryExcludingtheMinimumandMaximumSalaryFunc()
        {
            Program.Space();
            Program.Title("Average Salary Excluding the Minimum and Maximum Salary");

            // Case 1
            int[] salary1_1491 = {4000,3000,1000,2000};
            double result1_1491 = LeetCode.AverageSalaryExcludingtheMinimumandMaximumSalary.Solution.Average(salary1_1491);
            Console.WriteLine("Result 1 : {0}", result1_1491);

            // Case 2
            int[] salary2_1491 = {1000,2000,3000};
            double result2_1491 = LeetCode.AverageSalaryExcludingtheMinimumandMaximumSalary.Solution.Average(salary2_1491);
            Console.WriteLine("Result 2 : {0}", result2_1491);
        }


        private static void NonoverlappingIntervalsFunc()
        {
            Program.Space();
            Program.Title("Non-overlapping Intervals");

            // Case 1
            int[][] intervals1_435 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 1, 3 }
            };
            int result1_435 = LeetCode.NonoverlappingIntervals.Solution.EraseOverlapIntervals(intervals1_435);
            Console.WriteLine("Result 1 : {0}", result1_435);

            // Case 2
            int[][] intervals2_435 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 1, 2 },
                new int[] { 1, 2 }
            };
            int result2_435 = LeetCode.NonoverlappingIntervals.Solution.EraseOverlapIntervals(intervals2_435);
            Console.WriteLine("Result 2 : {0}", result2_435);

            // Case 3
            int[][] intervals3_435 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 }
            };
            int result3_435 = LeetCode.NonoverlappingIntervals.Solution.EraseOverlapIntervals(intervals3_435);
            Console.WriteLine("Result 3 : {0}", result3_435);
        }


        private static void SignoftheProductofanArrayFunc()
        {
            Program.Space();
            Program.Title("Sign of the Product of an Array");

            // Case 1
            int[] Case1_1822 = {-1,-2,-3,-4,3,2,1};
            int Result1_1822 = LeetCode.SignoftheProductofanArray.Solution.ArraySign(Case1_1822);
            Console.WriteLine("Result 1 : {0}", Result1_1822);

            // Case 2
            int[] Case2_1822 = {1,5,0,2,-3};
            int Result2_1822 = LeetCode.SignoftheProductofanArray.Solution.ArraySign(Case2_1822);
            Console.WriteLine("Result 2 : {0}", Result2_1822);

            // Case 3
            int[] Case3_1822 = {-1,1,-1,1,-1};
            int Result3_1822 = LeetCode.SignoftheProductofanArray.Solution.ArraySign(Case3_1822);
            Console.WriteLine("Result 3 : {0}", Result3_1822);
        }


        private static void CanMakeArithmeticProgressionFunc()
        {
            Program.Space();
            Program.Title("Can Make Arithmetic Progression From Sequence");

            int[] Case1_1502 = {-1,-2,-3,-4,3,2,1};
            int[] Case2_1502 = {1,5,0,2,-3};
            int[] Case3_1502 = {-1,1,-1,1,-1};
            int[] Case4_1502 = {1000,2000,3000};
            int[] Case5_1502 = {4000,3000,1000,2000};
            int[] Case6_1502 = {3,5,1};
            int[] Case7_1502 = {1,2,4};

            bool Result1_1502 = LeetCode.CanMakeArithmeticProgressionFromSequence.Solution.CanMakeArithmeticProgression(Case1_1502);
            bool Result2_1502 = LeetCode.CanMakeArithmeticProgressionFromSequence.Solution.CanMakeArithmeticProgression(Case2_1502);
            bool Result3_1502 = LeetCode.CanMakeArithmeticProgressionFromSequence.Solution.CanMakeArithmeticProgression(Case3_1502);
            bool Result4_1502 = LeetCode.CanMakeArithmeticProgressionFromSequence.Solution.CanMakeArithmeticProgression(Case4_1502);
            bool Result5_1502 = LeetCode.CanMakeArithmeticProgressionFromSequence.Solution.CanMakeArithmeticProgression(Case5_1502);
            bool Result6_1502 = LeetCode.CanMakeArithmeticProgressionFromSequence.Solution.CanMakeArithmeticProgression(Case6_1502);
            bool Result7_1502 = LeetCode.CanMakeArithmeticProgressionFromSequence.Solution.CanMakeArithmeticProgression(Case7_1502);

            Console.WriteLine("Result 1 : {0}", Result1_1502);
            Console.WriteLine("Result 2 : {0}", Result2_1502);
            Console.WriteLine("Result 3 : {0}", Result3_1502);
            Console.WriteLine("Result 4 : {0}", Result4_1502);
            Console.WriteLine("Result 5 : {0}", Result5_1502);
            Console.WriteLine("Result 6 : {0}", Result6_1502);
            Console.WriteLine("Result 7 : {0}", Result7_1502);
        }


        private static void MonotonicArrayFunc()
        {
            Program.Space();
            Program.Title("Monotonic Array");

            int[] Case1 = {-1,-2,-3,-4,3,2,1};
            int[] Case2 = {1,5,0,2,-3};
            int[] Case3 = {-1,1,-1,1,-1};
            int[] Case4 = {1000,2000,3000};
            int[] Case5 = {4000,3000,1000,2000};
            int[] Case6 = {3,5,1};
            int[] Case7 = {1,2,4};
            int[] Case8 = {1,2,2,3};
            int[] Case9 = {6,5,4,4};
            int[] Case10 = {1,3,2};
            int[] Case11 = { 30, 11, 23, 4, 20 };
            int[] Case12 = { 3, 6, 7, 11 };
            int[] Case13 = { -30, -11, 23, 4, 20 };
            int[] Case14 = { -10, -3, 0, 5, 9 };
            int[] Case15 = { 1, 3 };
            int[] Case16 = { 1, 2, 2 };
            int[] Case17 = { 1, 2 };
            int[] Case18 = { 5, 3, 4 };
            int[] Case19 = Program.GenerateRandomNumber(10, 100);
            int[] Case20 = Program.GenerateRandomNumber(10, 100);
            int[] Case21 = Program.GenerateRandomNumber(10, 100);
            int[] Case22 = Program.GenerateRandomNumber(10, 100);
            int[] Case23 = Program.GenerateRandomNegativeNumber(100);
            int[] Case24 = Program.GenerateRandomNegativeNumber(100);
            int[] Case25 = Program.GenerateRandomNegativeNumber(100);
            int[] Case26 = Program.GenerateRandomNegativeNumber(100);
            int[] Case27 = { -1, -2 };
            int[] Case28 = { 78, 56, 232, 12, 11, 43 };
            int[] Case29 = { 78, 56, -2, 12, 8, -33 };
            int[] Case30 = { 34, 15, 88, 2 };
            int[] Case31 = { 34, -345, -1, 100 };
            int[] Case32 = { 12, 35, 1, 10, 34, 1 };
            int[] Case33 = { 10, 5, 10 };
            int[] Case34 = { 1, 0, 0, 0, 1 };
            int[] Case35 = { 1, 0, 0, 0, 0, 0, 1 };
            int[] Case36 = { 1, 3, 0, 0, 2, 0, 0, 4 };
            int[] Case37 = { 0, 0, 0, 2, 0, 0 };

            bool result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case1);
            Console.WriteLine("Result 1 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case2);
            Console.WriteLine("Result 2 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case3);
            Console.WriteLine("Result 3 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case4);
            Console.WriteLine("Result 4 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case5);
            Console.WriteLine("Result 5 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case6);
            Console.WriteLine("Result 6 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case7);
            Console.WriteLine("Result 7 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case8);
            Console.WriteLine("Result 8 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case9);
            Console.WriteLine("Result 9 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case10);
            Console.WriteLine("Result 10 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case11);
            Console.WriteLine("Result 11 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case12);
            Console.WriteLine("Result 12 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case13);
            Console.WriteLine("Result 13 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case14);
            Console.WriteLine("Result 14 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case15);
            Console.WriteLine("Result 15 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case16);
            Console.WriteLine("Result 16 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case17);
            Console.WriteLine("Result 17 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case18);
            Console.WriteLine("Result 18 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case19);
            Console.WriteLine("Result 19 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case20);
            Console.WriteLine("Result 20 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case21);
            Console.WriteLine("Result 21 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case22);
            Console.WriteLine("Result 22 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case23);
            Console.WriteLine("Result 23 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case24);
            Console.WriteLine("Result 24 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case25);
            Console.WriteLine("Result 25 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case26);
            Console.WriteLine("Result 26 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case27);
            Console.WriteLine("Result 27 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case28);
            Console.WriteLine("Result 28 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case29);
            Console.WriteLine("Result 29 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case30);
            Console.WriteLine("Result 30 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case31);
            Console.WriteLine("Result 31 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case32);
            Console.WriteLine("Result 32 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case33);
            Console.WriteLine("Result 33 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case34);
            Console.WriteLine("Result 34 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case35);
            Console.WriteLine("Result 35 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case36);
            Console.WriteLine("Result 36 : {0}", result);
            result = LeetCode.MonotonicArray.Solution.IsMonotonic(Case37);
            Console.WriteLine("Result 37 : {0}", result);
        }


        private static void LengthofLastWordFunc()
        {
            Program.Space();
            Program.Title("Length of Last Word");

            // Case 1
            string s1 = "Hello World";
            int result1 = LeetCode.LengthofLastWord.Solution.LengthOfLastWord(s1);
            Console.WriteLine("Result 1 : {0}", result1);

            // Case 2
            string s2 = "   fly me   to   the moon  ";
            int result2 = LeetCode.LengthofLastWord.Solution.LengthOfLastWord(s2);
            Console.WriteLine("Result 2 : {0}", result2);

            // Case 3
            string s3 = "luffy is still joyboy";
            int result3 = LeetCode.LengthofLastWord.Solution.LengthOfLastWord(s3);
            Console.WriteLine("Result 3 : {0}", result3);
        }


        private static void ToLowerCaseFunc()
        {
            Program.Space();
            Program.Title("To Lower Case");

            string s1 = "Hello";
            string s2 = "here";
            string s3 = "LOVELY";

            s1 = LeetCode.ToLowerCase.Solution.ToLowerCase(s1);
            s2 = LeetCode.ToLowerCase.Solution.ToLowerCase(s2);
            s3 = LeetCode.ToLowerCase.Solution.ToLowerCase(s3);

            Console.WriteLine("Result 1 : {0}", s1);
            Console.WriteLine("Result 2 : {0}", s2);
            Console.WriteLine("Result 3 : {0}", s3);
        }


        private static void FindSmallestLetterGreaterThanTargetFunc()
        {
            Program.Space();
            Program.Title("Find Smallest Letter Greater Than Target");

            // Case 1
            char[] letters = {'c','f','j'};
            char target = 'a';
            char result = LeetCode.FindSmallestLetterGreaterThanTarget.Solution.NextGreatestLetter(letters, target);
            Console.WriteLine("Result 1 : {0}", result);

            // Case 2
            target = 'c';
            result = LeetCode.FindSmallestLetterGreaterThanTarget.Solution.NextGreatestLetter(letters, target);
            Console.WriteLine("Result 2 : {0}", result);

            // Case 3
            char[] letters3 = {'x','x','y','y'};
            target = 'a';
            result = LeetCode.FindSmallestLetterGreaterThanTarget.Solution.NextGreatestLetter(letters3, target);
            Console.WriteLine("Result 3 : {0}", result);
        }


        private static void CountNegativeNumbersinaSortedMatrixFunc()
        {
            Program.Space();
            Program.Title("Count Negative Numbers in a Sorted Matrix");

            // Case 1
            int[][] grid1_1351 = new int[][]
            {
                new int[] { 4,3,2,-1 },
                new int[] { 3,2,1,-1 },
                new int[] { 1,1,-1,-2 },
                new int[] { -1,-1,-2,-3 }
            };
            int result1_1351 = LeetCode.CountNegativeNumbersinaSortedMatrix.Solution.CountNegatives(grid1_1351);
            Console.WriteLine("Result 1 : {0}", result1_1351);

            // Case 2
            int[][] grid2_1351 = new int[][]
            {
                new int[] { 3,2 },
                new int[] { 1,0 }
            };
            int result2_1351 = LeetCode.CountNegativeNumbersinaSortedMatrix.Solution.CountNegatives(grid2_1351);
            Console.WriteLine("Result 2 : {0}", result2_1351);
        }


        private static void ValidPerfectSquareFunc()
        {
            Program.Space();
            Program.Title("Valid Perfect Square");

            int case1_367 = 16;
            int case2_367 = 14;

            bool result1_367 = LeetCode.ValidPerfectSquare.Solution.IsPerfectSquare(case1_367);
            bool result2_367 = LeetCode.ValidPerfectSquare.Solution.IsPerfectSquare(case2_367);

            Console.WriteLine("Result 1 : {0}", result1_367);
            Console.WriteLine("Result 2 : {0}", result2_367);
        }


        private static void ArrangingCoinsFunc()
        {
            Program.Space();
            Program.Title("Arranging Coins");
            int case1_441 = 5;
            int case2_441 = 8;
            int result1_441 = LeetCode.ArrangingCoins.Solution.ArrangeCoins(case1_441);
            int result2_441 = LeetCode.ArrangingCoins.Solution.ArrangeCoins(case2_441);
            Console.WriteLine("Result 1 : {0}", result1_441);
            Console.WriteLine("Result 2 : {0}", result2_441);
        }


        private static void BaseballGameFunc()
        {
            Program.Space();
            Program.Title("Baseball Game");
            string[] ops1 = {"5","-2","4","C","D","9","+","+"};
            string[] ops2 = {"1","C"};
            int result1_682 = LeetCode.BaseballGame.Solution.CalPoints(ops1);
            int result2_682 = LeetCode.BaseballGame.Solution.CalPoints(ops2);
            Console.WriteLine("Result 1 : {0}", result1_682);
            Console.WriteLine("Result 2 : {0}", result2_682);
        }


        private static void RobotReturntoOriginFunc()
        {
            Program.Space();
            Program.Title("Robot Return to Origin");
            string moves1 = "UD";
            string moves2 = "LL";
            bool result1 = LeetCode.RobotReturntoOrigin.Solution.JudgeCircle(moves1);
            bool result2 = LeetCode.RobotReturntoOrigin.Solution.JudgeCircle(moves2);
            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void FindWinneronaTicTacToeGameFunc()
        {
            Program.Space();
            Program.Title("Find Winner on a Tic Tac Toe Game");
            
            // Case 1
            int[][] grid1_1275 = new int[][]
            {
                new int[] { 0,0 },
                new int[] { 2,0 },
                new int[] { 1,1 },
                new int[] { 2,1 },
                new int[] { 2,2 }
            };
            string result1_1275 = LeetCode.FindWinneronaTicTacToeGame.Solution.Tictactoe(grid1_1275);
            Console.WriteLine("Result 1 : {0}", result1_1275);

            // Case 2
            int[][] grid2_1275 = new int[][]
            {
                new int[] { 0,0 },
                new int[] { 1,1 },
                new int[] { 0,1 },
                new int[] { 0,2 },
                new int[] { 1,0 },
                new int[] { 2,0 }
            };
            string result2_1275 = LeetCode.FindWinneronaTicTacToeGame.Solution.Tictactoe(grid2_1275);
            Console.WriteLine("Result 2 : {0}", result2_1275);

            // Case 3
            int[][] grid3_1275 = new int[][]
            {
                new int[] { 0,0 },
                new int[] { 1,1 },
                new int[] { 2,0 },
                new int[] { 1,0 },
                new int[] { 1,2 },
                new int[] { 2,1 },
                new int[] { 0,1 },
                new int[] { 0,2 },
                new int[] { 2,2 }
            };
            string result3_1275 = LeetCode.FindWinneronaTicTacToeGame.Solution.Tictactoe(grid3_1275);
            Console.WriteLine("Result 3 : {0}", result3_1275);
        }


        private static void RobotBoundedInCircleFunc()
        {
            Program.Space();
            Program.Title("Robot Bounded In Circle");

            string instructions1 = "GGLLGG";
            string instructions2 = "GG";
            string instructions3 = "GL";
            bool result1 = LeetCode.RobotBoundedInCircle.Solution.IsRobotBounded(instructions1);
            bool result2 = LeetCode.RobotBoundedInCircle.Solution.IsRobotBounded(instructions2);
            bool result3 = LeetCode.RobotBoundedInCircle.Solution.IsRobotBounded(instructions3);
            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
            Console.WriteLine("Result 3 : {0}", result3);
        }


        private static void MatrixDiagonalSumFunc()
        {
            Program.Space();
            Program.Title("Matrix Diagonal Sum");

            // Case 1
            int[][] grid1_1572 = new int[][]
            {
                new int[] { 1,2,3 },
                new int[] { 4,5,6 },
                new int[] { 7,8,9 }
            };
            int result1 = LeetCode.MatrixDiagonalSum.Solution.DiagonalSum(grid1_1572);
            Console.WriteLine("Result 1 : {0}", result1);

            // Case 2
            int[][] grid2_1572 = new int[][]
            {
                new int[] { 1,1,1,1 },
                new int[] { 1,1,1,1 },
                new int[] { 1,1,1,1 },
                new int[] { 1,1,1,1 }
            };
            int result2 = LeetCode.MatrixDiagonalSum.Solution.DiagonalSum(grid2_1572);
            Console.WriteLine("Result 2 : {0}", result2);

            // Case 3
            int[][] grid3_1572 = new int[][]
            {
                new int[] { 5 }
            };
            int result3 = LeetCode.MatrixDiagonalSum.Solution.DiagonalSum(grid3_1572);
            Console.WriteLine("Result 3 : {0}", result3);
        }


        private static void LemonadeChangeFunc()
        {
            Program.Space();
            Program.Title("Lemonade Change");

            int[] bills = {5,5,5,10,20};
            bool output1_860 = LeetCode.LemonadeChange.Solution.LemonadeChange(bills);
            Console.WriteLine("Result 1 : {0}", output1_860);
            bool output2_860 = LeetCode.LemonadeChange.Solution.LemonadeChange(bills);
            Console.WriteLine("Result 2 : {0}", output2_860);
        }


        private static void LargestPerimeterTriangleFunc()
        {
            Program.Space();
            Program.Title("Largest Perimeter Triangle");
            int[] case1_976 = {2,1,2};
            int[] case2_976 = {1,2,1,10};
            int result1_976 = LeetCode.LargestPerimeterTriangle.Solution.LargestPerimeter(case1_976);
            Console.WriteLine("Result 1 : {0}", result1_976);
            int result2_976 = LeetCode.LargestPerimeterTriangle.Solution.LargestPerimeter(case2_976);
            Console.WriteLine("Result 2 : {0}", result2_976);
        }


        private static void CheckIfItIsaStraightLineFunc()
        {
            Program.Space();
            Program.Title("Check If It Is a Straight Line");
            int[][] coordinates1_1232 = new int[][]
            {
                new int[] { 1,2 },
                new int[] { 2,3 },
                new int[] { 3,4 },
                new int[] { 4,5 },
                new int[] { 5,6 },
                new int[] { 6,7 }
            };
            int[][] coordinates2_1232 = new int[][]
            {
                new int[] { 1,1 },
                new int[] { 2,2 },
                new int[] { 3,4 },
                new int[] { 4,5 },
                new int[] { 5,6 },
                new int[] { 7,7 }
            };

            bool result1 = LeetCode.CheckIfItIsaStraightLine.Solution.CheckStraightLine(coordinates1_1232);
            bool result2 = LeetCode.CheckIfItIsaStraightLine.Solution.CheckStraightLine(coordinates2_1232);
            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void MultiplyStringsFunc()
        {
            Program.Space();
            Program.Title("Multiply Strings");

            string num1 = "2";
            string num2 = "3";
            string num3 = "123";
            string num4 = "456";
            string result1 = LeetCode.MultiplyStrings.Solution.Multiply(num1, num2);
            string result2 = LeetCode.MultiplyStrings.Solution.Multiply(num3, num4);
            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void PowxnFunc()
        {
            Program.Space();
            Program.Title("Pow(x, n)");

            // Case 1
            double x1 = 2.00000;
            int n1 = 10;
            double result1 = LeetCode.Powxn.Solution.MyPow(x1,n1);
            Console.WriteLine("Result 1 : {0}", result1);

            // Case 2
            double x2 = 2.10000;
            int n2 = 3;
            double result2 = LeetCode.Powxn.Solution.MyPow(x2,n2);
            Console.WriteLine("Result 2 : {0}", result2);

            // Case 3
            double x3 = 2.00000;
            int n3 = -2;
            double result3 = LeetCode.Powxn.Solution.MyPow(x3,n3);
            Console.WriteLine("Result 3 : {0}", result3);
        }


        private static void ReverseVowelsofaStringFunc()
        {
            Program.Space();
            Program.Title("Reverse Vowels of a String");

            string Case1_345 = LeetCode.ReverseVowelsofaString.Solution.ReverseVowels("hello");
            string Case2_345 = LeetCode.ReverseVowelsofaString.Solution.ReverseVowels("leetcode");
            Console.WriteLine("Result 1 : {0}", Case1_345);
            Console.WriteLine("Result 2 : {0}", Case2_345);
        }



        private static void ReverseWordsinaStringFunc()
        {
            Program.Space();
            Program.Title("Reverse Words in a String");
            string s1 = "the sky is blue";
            string s2 = "  hello world  ";
            string s3 = "a good   example";
            string solution1Case1 = LeetCode.ReverseWordsinaString.Solution.ReverseWords(s1);
            string solution2Case1 = LeetCode.ReverseWordsinaString.Solution.ReverseWordsSecond(s1);
            Console.WriteLine("Solution 1 Result 1 : {0}", solution1Case1);
            Console.WriteLine("Solution 2 Result 1 : {0}", solution2Case1);
            string solution1Case2 = LeetCode.ReverseWordsinaString.Solution.ReverseWords(s2);
            string solution2Case2 = LeetCode.ReverseWordsinaString.Solution.ReverseWordsSecond(s2);
            Console.WriteLine("Solution 1 Result 2 : {0}", solution1Case2);
            Console.WriteLine("Solution 2 Result 2 : {0}", solution2Case2);
            string solution1Case3 = LeetCode.ReverseWordsinaString.Solution.ReverseWords(s3);
            string solution2Case3 = LeetCode.ReverseWordsinaString.Solution.ReverseWordsSecond(s3);
            Console.WriteLine("Solution 1 Result 3 : {0}", solution1Case3);
            Console.WriteLine("Solution 2 Result 3 : {0}", solution2Case3);
        }


        private static void ProductofArrayExceptSelfFunc()
        {
            Program.Space();
            Program.Title("Product of Array Except Self");

            int[] Case1 = {-1,-2,-3,-4,3,2,1};
            int[] Case2 = {1,5,0,2,-3};
            int[] Case3 = {-1,1,-1,1,-1};
            int[] Case4 = {1000,2000,3000};
            int[] Case5 = {4000,3000,1000,2000};
            int[] Case6 = {3,5,1};
            int[] Case7 = {1,2,4};
            int[] Case8 = {1,2,2,3};
            int[] Case9 = {6,5,4,4};
            int[] Case10 = {1,3,2};
            int[] Case11 = { 30, 11, 23, 4, 20 };
            int[] Case12 = { 3, 6, 7, 11 };
            int[] Case13 = { -30, -11, 23, 4, 20 };
            int[] Case14 = { -10, -3, 0, 5, 9 };
            int[] Case15 = { 1, 3 };
            int[] Case16 = { 1, 2, 2 };
            int[] Case17 = { 1, 2 };
            int[] Case18 = { 5, 3, 4 };
            int[] Case19 = Program.GenerateRandomNumber(10, 100);
            int[] Case20 = Program.GenerateRandomNumber(10, 100);
            int[] Case21 = Program.GenerateRandomNumber(10, 100);
            int[] Case22 = Program.GenerateRandomNumber(10, 100);
            int[] Case23 = Program.GenerateRandomNegativeNumber(100);
            int[] Case24 = Program.GenerateRandomNegativeNumber(100);
            int[] Case25 = Program.GenerateRandomNegativeNumber(100);
            int[] Case26 = Program.GenerateRandomNegativeNumber(100);
            int[] Case27 = { -1, -2 };
            int[] Case28 = { 78, 56, 232, 12, 11, 43 };
            int[] Case29 = { 78, 56, -2, 12, 8, -33 };
            int[] Case30 = { 34, 15, 88, 2 };
            int[] Case31 = { 34, -345, -1, 100 };
            int[] Case32 = { 12, 35, 1, 10, 34, 1 };
            int[] Case33 = { 10, 5, 10 };
            int[] Case34 = { 1, 0, 0, 0, 1 };
            int[] Case35 = { 1, 0, 0, 0, 0, 0, 1 };
            int[] Case36 = { 1, 3, 0, 0, 2, 0, 0, 4 };
            int[] Case37 = { 0, 0, 0, 2, 0, 0 };
            int[] Case38 = { 1, 2, 3, 4 };
            int[] Case39 = { -1, 1, 0, -3, 3 };

            int[] result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case1);
            Console.WriteLine("Result 1 :");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case2);
            Console.WriteLine("Result 2 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case3);
            Console.WriteLine("Result 3 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case4);
            Console.WriteLine("Result 4 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case5);
            Console.WriteLine("Result 5 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case6);
            Console.WriteLine("Result 6 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case7);
            Console.WriteLine("Result 7 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case8);
            Console.WriteLine("Result 8 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case9);
            Console.WriteLine("Result 9 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case10);
            Console.WriteLine("Result 10 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case11);
            Console.WriteLine("Result 11 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case12);
            Console.WriteLine("Result 12 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case13);
            Console.WriteLine("Result 13 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case14);
            Console.WriteLine("Result 14 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case15);
            Console.WriteLine("Result 15 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case16);
            Console.WriteLine("Result 16 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case17);
            Console.WriteLine("Result 17 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case18);
            Console.WriteLine("Result 18 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case19);
            Console.WriteLine("Result 19 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case20);
            Console.WriteLine("Result 20 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case21);
            Console.WriteLine("Result 21 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case22);
            Console.WriteLine("Result 22 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case23);
            Console.WriteLine("Result 23 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case24);
            Console.WriteLine("Result 24 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case25);
            Console.WriteLine("Result 25 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case26);
            Console.WriteLine("Result 26 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case27);
            Console.WriteLine("Result 27 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case28);
            Console.WriteLine("Result 28 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case29);
            Console.WriteLine("Result 29 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case30);
            Console.WriteLine("Result 30 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case31);
            Console.WriteLine("Result 31 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case32);
            Console.WriteLine("Result 32 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case33);
            Console.WriteLine("Result 33 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case34);
            Console.WriteLine("Result 34 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case35);
            Console.WriteLine("Result 35 : ");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case36);
            Console.WriteLine("Result 36 :");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case37);
            Console.WriteLine("Result 37 :");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case38);
            Console.WriteLine("Result 38 :");
            Program.PrintArray(result);
            result = LeetCode.ProductofArrayExceptSelf.Solution.ProductExceptSelf(Case39);
            Console.WriteLine("Result 39 :");
            Program.PrintArray(result);
        }


        private static void Dota2SenateFunc()
        {
            Program.Space();
            Program.Title("Dota2 Senate");

            string senate1 = "RD";
            string senate2 = "RDD";

            string result1 = LeetCode.Dota2Senate.Solution.PredictPartyVictory(senate1);
            string result2 = LeetCode.Dota2Senate.Solution.PredictPartyVictory(senate2);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void MinimumFlipstoMakeaORbEqualtocFunc()
        {
            Program.Space();
            Program.Title("Minimum Flips to Make a OR b Equal to c");

            int result1 = LeetCode.MinimumFlipstoMakeaORbEqualtoc.Solution.MinFlips(2,6,5);
            int result2 = LeetCode.MinimumFlipstoMakeaORbEqualtoc.Solution.MinFlips(4,2,7);
            int result3 = LeetCode.MinimumFlipstoMakeaORbEqualtoc.Solution.MinFlips(1,2,3);
            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
            Console.WriteLine("Result 3 : {0}", result3);
        }


        private static void CountingBitsFunc()
        {
            Program.Space();
            Program.Title("Counting Bits");

            int[] result1 = LeetCode.CountingBits.Solution.CountBits(2);
            int[] result2 = LeetCode.CountingBits.Solution.CountBits(5);
            Program.PrintArray(result1);
            Program.PrintArray(result2);
        }


        private static void BestTimetoBuyandSellStockwithTransactionFeeFunc()
        {
            Program.Space();
            Program.Title("Best Time to Buy and Sell Stock with Transaction Fee");

            int[] prices1 = {1,3,2,8,4,9};
            int fee1 = 2;
            int[] prices2 = {1,3,7,5,10,3};
            int fee2 = 3;

            int result1 = LeetCode.BestTimetoBuyandSellStockwithTransactionFee.Solution.MaxProfit(prices1, fee1);
            int result2 = LeetCode.BestTimetoBuyandSellStockwithTransactionFee.Solution.MaxProfit(prices2, fee2);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void IncreasingTripletSubsequenceFunc()
        {
            Program.Space();
            Program.Title("Increasing Triplet Subsequence");

            int[] Case1 = { -1, -2, -3, -4, 3, 2, 1};
            int[] Case2 = { 1, 5, 0, 2,-3 };
            int[] Case3 = { -1, 1, -1, 1, -1 };
            int[] Case4 = { 1000, 2000, 3000 };
            int[] Case5 = { 4000, 3000, 1000, 2000 };
            int[] Case6 = { 3, 5, 1 };
            int[] Case7 = { 1, 2, 4 };
            int[] Case8 = { 1, 2, 2, 3 };
            int[] Case9 = { 6, 5, 4, 4 };
            int[] Case10 = { 1, 3, 2 };
            int[] Case11 = { 30, 11, 23, 4, 20 };
            int[] Case12 = { 3, 6, 7, 11 };
            int[] Case13 = { -30, -11, 23, 4, 20 };
            int[] Case14 = { -10, -3, 0, 5, 9 };
            int[] Case15 = { 1, 3 };
            int[] Case16 = { 1, 2, 2 };
            int[] Case17 = { 1, 2 };
            int[] Case18 = { 5, 3, 4 };
            int[] Case19 = Program.GenerateRandomNumber(10, 100);
            int[] Case20 = Program.GenerateRandomNumber(10, 100);
            int[] Case21 = Program.GenerateRandomNumber(10, 100);
            int[] Case22 = Program.GenerateRandomNumber(10, 100);
            int[] Case23 = Program.GenerateRandomNegativeNumber(100);
            int[] Case24 = Program.GenerateRandomNegativeNumber(100);
            int[] Case25 = Program.GenerateRandomNegativeNumber(100);
            int[] Case26 = Program.GenerateRandomNegativeNumber(100);
            int[] Case27 = { -1, -2 };
            int[] Case28 = { 78, 56, 232, 12, 11, 43 };
            int[] Case29 = { 78, 56, -2, 12, 8, -33 };
            int[] Case30 = { 34, 15, 88, 2 };
            int[] Case31 = { 34, -345, -1, 100 };
            int[] Case32 = { 12, 35, 1, 10, 34, 1 };
            int[] Case33 = { 10, 5, 10 };
            int[] Case34 = { 1, 0, 0, 0, 1 };
            int[] Case35 = { 1, 0, 0, 0, 0, 0, 1 };
            int[] Case36 = { 1, 3, 0, 0, 2, 0, 0, 4 };
            int[] Case37 = { 0, 0, 0, 2, 0, 0 };
            int[] Case38 = { 1, 2, 3, 4 };
            int[] Case39 = { -1, 1, 0, -3, 3 };
            int[] Case40 = { 1, 2, 3, 4, 5 };
            int[] Case41 = { 5, 4, 3, 2, 1 };
            int[] Case42 = { 2, 1, 5, 0, 4, 6 };

            bool result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case1);
            Console.WriteLine("Result 1 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case2);
            Console.WriteLine("Result 2 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case3);
            Console.WriteLine("Result 3 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case4);
            Console.WriteLine("Result 4 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case5);
            Console.WriteLine("Result 5 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case6);
            Console.WriteLine("Result 6 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case7);
            Console.WriteLine("Result 7 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case8);
            Console.WriteLine("Result 8 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case9);
            Console.WriteLine("Result 9 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case10);
            Console.WriteLine("Result 10 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case11);
            Console.WriteLine("Result 11 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case12);
            Console.WriteLine("Result 12 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case13);
            Console.WriteLine("Result 13 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case14);
            Console.WriteLine("Result 14 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case15);
            Console.WriteLine("Result 15 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case16);
            Console.WriteLine("Result 16 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case17);
            Console.WriteLine("Result 17 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case18);
            Console.WriteLine("Result 18 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case19);
            Console.WriteLine("Result 19 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case20);
            Console.WriteLine("Result 20 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case21);
            Console.WriteLine("Result 21 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case22);
            Console.WriteLine("Result 22 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case23);
            Console.WriteLine("Result 23 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case24);
            Console.WriteLine("Result 24 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case25);
            Console.WriteLine("Result 25 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case26);
            Console.WriteLine("Result 26 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case27);
            Console.WriteLine("Result 27 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case28);
            Console.WriteLine("Result 28 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case29);
            Console.WriteLine("Result 29 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case30);
            Console.WriteLine("Result 30 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case31);
            Console.WriteLine("Result 31 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case32);
            Console.WriteLine("Result 32 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case33);
            Console.WriteLine("Result 33 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case34);
            Console.WriteLine("Result 34 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case35);
            Console.WriteLine("Result 35 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case36);
            Console.WriteLine("Result 36 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case37);
            Console.WriteLine("Result 37 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case38);
            Console.WriteLine("Result 38 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case39);
            Console.WriteLine("Result 39 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case40);
            Console.WriteLine("Result 40 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case41);
            Console.WriteLine("Result 41 : {0}", result);
            result = LeetCode.IncreasingTripletSubsequence.Solution.IncreasingTriplet(Case42);
            Console.WriteLine("Result 42 : {0}", result);
        }


        private static void IsSubsequenceFunc()
        {
            Program.Space();
            Program.Title("Is Subsequence");

            string s1 = "abc";
            string t1 = "ahbgdc";
            string s2 = "axc";
            string t2 = "ahbgdc";

            bool result1 = LeetCode.IsSubsequence.Solution.IsSubsequence(s1,t1);
            bool result2 = LeetCode.IsSubsequence.Solution.IsSubsequence(s2,t2);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void MaximumNumberofVowelsinaSubstringofGivenLengthFunc()
        {
            Program.Space();
            Program.Title("Maximum Number of Vowels in a Substring of Given Length");

            int result1 = LeetCode.MaximumNumberofVowelsinaSubstringofGivenLength.Solution.MaxVowels("abciiidef", 3);
            int result2 = LeetCode.MaximumNumberofVowelsinaSubstringofGivenLength.Solution.MaxVowels("aeiou", 2);
            int result3 = LeetCode.MaximumNumberofVowelsinaSubstringofGivenLength.Solution.MaxVowels("leetcode", 3);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
            Console.WriteLine("Result 3 : {0}", result3);
        }


        private static void DominoandTrominoTilingFunc()
        {
            Program.Space();
            Program.Title("Domino and Tromino Tiling");

            int result1 = LeetCode.DominoandTrominoTiling.Solution.NumTilings(3);
            int result2 = LeetCode.DominoandTrominoTiling.Solution.NumTilings(1);
            
            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void MinCostClimbingStairsFunc()
        {
            Program.Space();
            Program.Title("Min Cost Climbing Stairs");

            // Case 1
            int[] cost1 = {10,15,20};
            int result1 = LeetCode.MinCostClimbingStairs.Solution.MinCostClimbingStairs(cost1);
            Console.WriteLine("Result 1 : {0}", result1);

            // Case 2
            int[] cost2 = {1,100,1,1,1,100,1,1,100,1};
            int result2 = LeetCode.MinCostClimbingStairs.Solution.MinCostClimbingStairs(cost2);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void ContainerWithMostWaterFunc()
        {
            Program.Space();
            Program.Title("Container With Most Water");

            int[] height1 = {1,8,6,2,5,4,8,3,7};
            int[] height2 = {1,1};

            int result1 = LeetCode.ContainerWithMostWater.Solution.MaxArea(height1);
            int result2 = LeetCode.ContainerWithMostWater.Solution.MaxArea(height2);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void MaxNumberofKSumPairsFunc()
        {
            Program.Space();
            Program.Title("Max Number of K-Sum Pairs");

            // Case 1
            int[] nums1 = {1,2,3,4};
            int k1 = 5;
            int result1 = LeetCode.MaxNumberofKSumPairs.Solution.MaxOperations(nums1, k1);
            Console.WriteLine("Result 1 : {0}", result1);

            // Case 2
            int[] nums2 = {3,1,3,4,3};
            int k2 = 6;
            int result2 = LeetCode.MaxNumberofKSumPairs.Solution.MaxOperations(nums2, k2);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void MaximumAverageSubarrayIFunc()
        {
            Program.Space();
            Program.Title("Maximum Average Subarray I");

            // Case 1
            int[] nums1 = {1,12,-5,-6,50,3};
            int k1 = 4;
            double result1 = LeetCode.MaximumAverageSubarrayI.Solution.FindMaxAverage(nums1, k1);
            Console.WriteLine("Result 1 : {0}", result1);

            // Case 2
            int[] nums2 = {5};
            int k2 = 1;
            double result2 = LeetCode.MaximumAverageSubarrayI.Solution.FindMaxAverage(nums2, k2);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void UniquePathsFunc()
        {
            Program.Space();
            Program.Title("Unique Paths");

            int result1 = LeetCode.UniquePaths.Solution.UniquePaths(3, 7);
            int result2 = LeetCode.UniquePaths.Solution.UniquePaths(3, 2);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void MaxConsecutiveOnesIIIFunc()
        {
            Program.Space();
            Program.Title("Max Consecutive Ones III");
            int[] nums1 = {1,1,1,0,0,0,1,1,1,1,0};
            int k1 = 2;
            int[] nums2 = {0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1};
            int k2 = 3;
            int result1 = LeetCode.MaxConsecutiveOnesIII.Solution.LongestOnes(nums1, k1);
            int result2 = LeetCode.MaxConsecutiveOnesIII.Solution.LongestOnes(nums2, k2);
            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void LongestSubarrayof1sAfterDeletingOneElementFunc()
        {
            Program.Space();
            Program.Title("Longest Subarray of 1's After Deleting One Element");
            
            int[] nums1 = {1,1,0,1};
            int[] nums2 = {0,1,1,1,0,1,1,0,1};
            int[] nums3 = {1,1,1};

            int result1 = LeetCode.LongestSubarrayof1sAfterDeletingOneElement.Solution.LongestSubarray(nums1);
            int result2 = LeetCode.LongestSubarrayof1sAfterDeletingOneElement.Solution.LongestSubarray(nums2);
            int result3 = LeetCode.LongestSubarrayof1sAfterDeletingOneElement.Solution.LongestSubarray(nums3);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
            Console.WriteLine("Result 3 : {0}", result3);
        }


        private static void FindtheHighestAltitudeFunc()
        {
            Program.Space();
            Program.Title("Find the Highest Altitude");

            int[] gain1 = {-5,1,5,0,-7};
            int[] gain2 = {-4,-3,-2,-1,4,3,2};

            int result1 = LeetCode.FindtheHighestAltitude.Solution.LargestAltitude(gain1);
            int result2 = LeetCode.FindtheHighestAltitude.Solution.LargestAltitude(gain2);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void FindPivotIndexFunc()
        {
            Program.Space();
            Program.Title("Find Pivot Index");

            int[] nums1 = {1,7,3,6,5,6};
            int[] nums2 = {1,2,3};
            int[] nums3 = {2,1,-1};

            int result1 = LeetCode.FindPivotIndex.Solution.PivotIndex(nums1);
            int result2 = LeetCode.FindPivotIndex.Solution.PivotIndex(nums2);
            int result3 = LeetCode.FindPivotIndex.Solution.PivotIndex(nums3);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
            Console.WriteLine("Result 3 : {0}", result3);
        }


        private static void NumberofProvincesFunc()
        {
            Program.Space();
            Program.Title("Number of Provinces");

            // Case 1
            int[][] case1_547 = new int[][]
            {
                new int[] { 1,1,0 },
                new int[] { 1,1,0 },
                new int[] { 0,0,1 }
            };
            int result1 = LeetCode.NumberofProvinces.Solution.FindCircleNum(case1_547);
            Console.WriteLine("Result 1 : {0}", result1);
            
            // Case 2
            int[][] case2_547 = new int[][]
            {
                new int[] { 1,0,0 },
                new int[] { 0,1,0 },
                new int[] { 0,0,1 }
            };
            int result2 = LeetCode.NumberofProvinces.Solution.FindCircleNum(case2_547);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void NumberofSubsequencesThatSatisfytheGivenSumConditionFunc()
        {
            Program.Space();
            Program.Title("Number of Subsequences That Satisfy the Given Sum Condition");

            int[] nums1 = {3,5,6,7};
            int target1 = 9;
            int[] nums2 = {3,3,6,8};
            int target2 = 10;
            int[] nums3 = {2,3,3,4,6,7};
            int target3 = 12;

            int result1 = LeetCode.NumberofSubsequencesThatSatisfytheGivenSumCondition.Solution.NumSubseq(nums1, target1);
            int result2 = LeetCode.NumberofSubsequencesThatSatisfytheGivenSumCondition.Solution.NumSubseq(nums2, target2);
            int result3 = LeetCode.NumberofSubsequencesThatSatisfytheGivenSumCondition.Solution.NumSubseq(nums3, target3);
            
            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
            Console.WriteLine("Result 3 : {0}", result3);
        }


        private static void FindtheLongestValidObstacleCourseatEachPositionFunc()
        {
            Program.Space();
            Program.Title("Number of Subsequences That Satisfy the Given Sum Condition");

            int[] obstacles1 = {1,2,3,2};
            int[] obstacles2 = {2,2,1};
            int[] obstacles3 = {3,1,5,6,4,2};
            int[] result1 = LeetCode.FindtheLongestValidObstacleCourseatEachPosition.Solution.LongestObstacleCourseAtEachPosition(obstacles1);
            int[] result2 = LeetCode.FindtheLongestValidObstacleCourseatEachPosition.Solution.LongestObstacleCourseAtEachPosition(obstacles2);
            int[] result3 = LeetCode.FindtheLongestValidObstacleCourseatEachPosition.Solution.LongestObstacleCourseAtEachPosition(obstacles3);
            Program.PrintArray(result1);
            Program.PrintArray(result2);
            Program.PrintArray(result3);
        }


        private static void AsteroidCollisionFunc()
        {
            Program.Space();
            Program.Title("Asteroid Collision");

            int[] asteroids1 = {5,10,-5};
            int[] asteroids2 = {8,-8};
            int[] asteroids3 = {10,2,-5};

            int[] result1 = LeetCode.AsteroidCollision.Solution.AsteroidCollision(asteroids1);
            int[] result2 = LeetCode.AsteroidCollision.Solution.AsteroidCollision(asteroids2);
            int[] result3 = LeetCode.AsteroidCollision.Solution.AsteroidCollision(asteroids3);

            Program.PrintArray(result1);
            Program.PrintArray(result2);
            Program.PrintArray(result3);
        }


        private static void FindPeakElementFunc()
        {
            Program.Space();
            Program.Title("Find Peak Element");

            int[] nums1 = {1,2,3,1};
            int[] nums2 = {1,2,1,3,5,6,4};

            int result1 = LeetCode.FindPeakElement.Solution.FindPeakElement(nums1);
            int result2 = LeetCode.FindPeakElement.Solution.FindPeakElement(nums2);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void MaximizeScoreAfterNOperationsFunc()
        {
            Program.Space();
            Program.Title("Maximize Score After N Operations");

            int[] case1_1799 = {1,2};
            int[] case2_1799 = {3,4,6,8};
            int[] case3_1799 = {1,2,3,4,5,6};

            int result1 = LeetCode.MaximizeScoreAfterNOperations.Solution.MaxScore(case1_1799);
            int result2 = LeetCode.MaximizeScoreAfterNOperations.Solution.MaxScore(case2_1799);
            int result3 = LeetCode.MaximizeScoreAfterNOperations.Solution.MaxScore(case3_1799);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
            Console.WriteLine("Result 3 : {0}", result3);
        }


        private static void WateringPlantsIIFunc()
        {
            Program.Space();
            Program.Title("Watering Plants II");

            int[] plants1 = {2,2,3,3};
            int capacityA1 = 5;
            int capacityB1 = 5;

            int[] plants2 = {2,2,3,3};
            int capacityA2 = 3;
            int capacityB2 = 4;

            int[] plants3 = {5};
            int capacityA3 = 10;
            int capacityB3 = 8;

            int result1 = LeetCode.WateringPlantsII.Solution.MinimumRefill(plants1, capacityA1, capacityB1);
            int result2 = LeetCode.WateringPlantsII.Solution.MinimumRefill(plants2, capacityA2, capacityB2);
            int result3 = LeetCode.WateringPlantsII.Solution.MinimumRefill(plants3, capacityA3, capacityB3);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
            Console.WriteLine("Result 3 : {0}", result3);
        }


        private static void CarPoolingFunc()
        {
            Program.Space();
            Program.Title("Car Pooling");

            int[][] trips = new int[][]
            {
                new int[] { 2, 1, 5 },
                new int[] { 3, 3, 7 }
            };
            int capacity1 = 4;
            int capacity2 = 5;

            bool result1 = LeetCode.CarPooling.Solution.CarPooling(trips, capacity1);
            bool result2 = LeetCode.CarPooling.Solution.CarPooling(trips, capacity2);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void CountWaysToBuildGoodStringsFunc()
        {
            Program.Space();
            Program.Title("Count Ways To Build Good Strings");

            int low1 = 3;
            int high1 = 3;
            int zero1 = 1;
            int one1 = 1;

            int result1 = LeetCode.CountWaysToBuildGoodStrings.Solution.CountGoodStrings(low1, high1, zero1, one1);
            Console.WriteLine("Result 1 : {0}", result1);

            int low2 = 2;
            int high2 = 3;
            int zero2 = 1;
            int one2 = 2;

            int result2 = LeetCode.CountWaysToBuildGoodStrings.Solution.CountGoodStrings(low2, high2, zero2, one2);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void TotalCosttoHireKWorkersFunc()
        {
            Program.Space();
            Program.Title("Total Cost to Hire K Workers");

            int[] costs1 = {17,12,10,2,7,2,11,20,8};
            int k1 = 3;
            int candidates1 = 4;

            int[] costs2 = {1,2,4,1};
            int k2 = 3;
            int candidates2 = 3;

            long result1 = LeetCode.TotalCosttoHireKWorkers.Solution.TotalCost(costs1, k1, candidates1);
            long result2 = LeetCode.TotalCosttoHireKWorkers.Solution.TotalCost(costs2, k2, candidates2);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void MaximumSubsequenceScoreFunc()
        {
            Program.Space();
            Program.Title("Maximum Subsequence Score");

            int[] nums1_1 = {1,3,3,2};
            int[] nums2_1 = {2,1,3,4};
            int k1 = 3;

            int[] nums1_2 = {4,2,3,1,1};
            int[] nums2_2 = {7,5,10,9,6};
            int k2 = 1;

            long result1 = LeetCode.MaximumSubsequenceScore.Solution.MaxScore(nums1_1, nums2_1, k1);
            long result2 = LeetCode.MaximumSubsequenceScore.Solution.MaxScore(nums1_2, nums2_2, k2);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void KthLargestElementinanArrayFunc()
        {
            Program.Space();
            Program.Title("Kth Largest Element in an Array");

            int[] nums1 = {3,2,1,5,6,4};
            int k1 = 2;

            int[] nums2 = {3,2,3,1,2,4,5,5,6};
            int k2 = 4;

            int result1 = LeetCode.KthLargestElementinanArray.Solution.FindKthLargest(nums1, k1);
            int result2 = LeetCode.KthLargestElementinanArray.Solution.FindKthLargest(nums2, k2);
            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }

        
        private static void EqualRowandColumnPairsFunc()
        {
            Program.Space();
            Program.Title("Equal Row and Column Pairs");

            int[][] case1 = new int[][]
            {
                new int[] { 3, 2, 1 },
                new int[] { 1, 7, 6 },
                new int[] { 2, 7, 7 }
            };

            int[][] case2 = new int[][]
            {
                new int[] { 3,1,2,2 },
                new int[] { 1,4,4,5 },
                new int[] { 2,4,2,2 },
                new int[] { 2,4,2,2 }
            };

            int result1 = LeetCode.EqualRowandColumnPairs.Solution.EqualPairs(case1);
            int result2 = LeetCode.EqualRowandColumnPairs.Solution.EqualPairs(case2);
            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void UniqueNumberofOccurrencesFunc()
        {
            Program.Space();
            Program.Title("Unique Number of Occurrences");

            int[] Case1 = { -1, -2, -3, -4, 3, 2, 1};
            int[] Case2 = { 1, 5, 0, 2,-3 };
            int[] Case3 = { -1, 1, -1, 1, -1 };
            int[] Case4 = { 1000, 2000, 3000 };
            int[] Case5 = { 4000, 3000, 1000, 2000 };
            int[] Case6 = { 3, 5, 1 };
            int[] Case7 = { 1, 2, 4 };
            int[] Case8 = { 1, 2, 2, 3 };
            int[] Case9 = { 6, 5, 4, 4 };
            int[] Case10 = { 1, 3, 2 };
            int[] Case11 = { 30, 11, 23, 4, 20 };
            int[] Case12 = { 3, 6, 7, 11 };
            int[] Case13 = { -30, -11, 23, 4, 20 };
            int[] Case14 = { -10, -3, 0, 5, 9 };
            int[] Case15 = { 1, 3 };
            int[] Case16 = { 1, 2, 2 };
            int[] Case17 = { 1, 2 };
            int[] Case18 = { 5, 3, 4 };
            int[] Case19 = Program.GenerateRandomNumber(10, 100);
            int[] Case20 = Program.GenerateRandomNumber(10, 100);
            int[] Case21 = Program.GenerateRandomNumber(10, 100);
            int[] Case22 = Program.GenerateRandomNumber(10, 100);
            int[] Case23 = Program.GenerateRandomNegativeNumber(100);
            int[] Case24 = Program.GenerateRandomNegativeNumber(100);
            int[] Case25 = Program.GenerateRandomNegativeNumber(100);
            int[] Case26 = Program.GenerateRandomNegativeNumber(100);
            int[] Case27 = { -1, -2 };
            int[] Case28 = { 78, 56, 232, 12, 11, 43 };
            int[] Case29 = { 78, 56, -2, 12, 8, -33 };
            int[] Case30 = { 34, 15, 88, 2 };
            int[] Case31 = { 34, -345, -1, 100 };
            int[] Case32 = { 12, 35, 1, 10, 34, 1 };
            int[] Case33 = { 10, 5, 10 };
            int[] Case34 = { 1, 0, 0, 0, 1 };
            int[] Case35 = { 1, 0, 0, 0, 0, 0, 1 };
            int[] Case36 = { 1, 3, 0, 0, 2, 0, 0, 4 };
            int[] Case37 = { 0, 0, 0, 2, 0, 0 };
            int[] Case38 = { 1, 2, 3, 4 };
            int[] Case39 = { -1, 1, 0, -3, 3 };
            int[] Case40 = { 1, 2, 3, 4, 5 };
            int[] Case41 = { 5, 4, 3, 2, 1 };
            int[] Case42 = { 2, 1, 5, 0, 4, 6 };
            int[] Case43 = { 3, 2, 1, 5, 6, 4 };
            int[] Case44 = { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            int[] Case45 = { 1, 3, 3, 2 };
            int[] Case46 = { 2, 1, 3, 4 };
            int[] Case47 = { 4, 2, 3, 1, 1 };
            int[] Case48 = { 7, 5, 10, 9, 6 };

            bool result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case1);
            Console.WriteLine("Result 1 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case2);
            Console.WriteLine("Result 2 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case3);
            Console.WriteLine("Result 3 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case4);
            Console.WriteLine("Result 4 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case5);
            Console.WriteLine("Result 5 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case6);
            Console.WriteLine("Result 6 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case7);
            Console.WriteLine("Result 7 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case8);
            Console.WriteLine("Result 8 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case9);
            Console.WriteLine("Result 9 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case10);
            Console.WriteLine("Result 10 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case11);
            Console.WriteLine("Result 11 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case12);
            Console.WriteLine("Result 12 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case13);
            Console.WriteLine("Result 13 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case14);
            Console.WriteLine("Result 14 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case15);
            Console.WriteLine("Result 15 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case16);
            Console.WriteLine("Result 16 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case17);
            Console.WriteLine("Result 17 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case18);
            Console.WriteLine("Result 18 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case19);
            Console.WriteLine("Result 19 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case20);
            Console.WriteLine("Result 20 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case21);
            Console.WriteLine("Result 21 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case22);
            Console.WriteLine("Result 22 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case23);
            Console.WriteLine("Result 23 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case24);
            Console.WriteLine("Result 24 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case25);
            Console.WriteLine("Result 25 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case26);
            Console.WriteLine("Result 26 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case27);
            Console.WriteLine("Result 27 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case28);
            Console.WriteLine("Result 28 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case29);
            Console.WriteLine("Result 29 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case30);
            Console.WriteLine("Result 30 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case31);
            Console.WriteLine("Result 31 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case32);
            Console.WriteLine("Result 32 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case33);
            Console.WriteLine("Result 33 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case34);
            Console.WriteLine("Result 34 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case35);
            Console.WriteLine("Result 35 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case36);
            Console.WriteLine("Result 36 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case37);
            Console.WriteLine("Result 37 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case38);
            Console.WriteLine("Result 38 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case39);
            Console.WriteLine("Result 39 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case40);
            Console.WriteLine("Result 40 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case41);
            Console.WriteLine("Result 41 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case42);
            Console.WriteLine("Result 42 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case43);
            Console.WriteLine("Result 43 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case44);
            Console.WriteLine("Result 44 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case45);
            Console.WriteLine("Result 45 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case46);
            Console.WriteLine("Result 46 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case47);
            Console.WriteLine("Result 47 : {0}", result);
            result = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case48);
            Console.WriteLine("Result 48 : {0}", result);
        }


        private static void DetermineifTwoStringsAreCloseFunc()
        {
            Program.Space();
            Program.Title("Determine if Two Strings Are Close");

            string word1_1 = "abc";
            string word2_1 = "bca";
            string word1_2 = "a";
            string word2_2 = "aa";
            string word1_3 = "cabbba";
            string word2_3 = "abbccc";

            bool result1 = LeetCode.DetermineifTwoStringsAreClose.Solution.CloseStrings(word1_1, word2_1);
            bool result2 = LeetCode.DetermineifTwoStringsAreClose.Solution.CloseStrings(word1_2, word2_2);
            bool result3 = LeetCode.DetermineifTwoStringsAreClose.Solution.CloseStrings(word1_3, word2_3);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
            Console.WriteLine("Result 3 : {0}", result3);
        }


        private static void IsGraphBipartiteFunc()
        {
            Program.Space();
            Program.Title("Is Graph Bipartite");

            int[][] case1 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 0, 2 },
                new int[] { 0, 1, 3 },
                new int[] { 0, 2 }
            };

            int[][] case2 = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 0, 2 },
                new int[] { 1, 3 },
                new int[] { 0, 2 }
            };

            bool result1 = LeetCode.IsGraphBipartite.Solution.IsBipartite(case1);
            bool result2 = LeetCode.IsGraphBipartite.Solution.IsBipartite(case2);
            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
        }


        private static void NextPermutationFunc()
        {
            Program.Space();
            Program.Title("Next Permutation");

            int[] case1 = { 1, 2, 3 };
            int[] case2 = { 3, 2, 1 };
            int[] case3 = { 1, 1, 5 };

            LeetCode.NextPermutation.Solution.NextPermutation(case1);
            LeetCode.NextPermutation.Solution.NextPermutation(case2);
            LeetCode.NextPermutation.Solution.NextPermutation(case3);
        }


        private static void ShortestBridgeFunc()
        {
            Program.Space();
            Program.Title("Shortest Bridge");

            int[][] case1 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 0 }
            };

            int[][] case2 = new int[][]
            {
                new int[] { 0,1,0 },
                new int[] { 0,0,0 },
                new int[] { 0,0,1 }
            };

            int[][] case3 = new int[][]
            {
                new int[] { 1,1,1,1,1 },
                new int[] { 1,0,0,0,1 },
                new int[] { 1,0,1,0,1 },
                new int[] { 1,0,0,0,1 },
                new int[] { 1,1,1,1,1 }
            };

            int result1 = LeetCode.ShortestBridge.Solution.ShortestBridge(case1);
            int result2 = LeetCode.ShortestBridge.Solution.ShortestBridge(case2);
            int result3 = LeetCode.ShortestBridge.Solution.ShortestBridge(case3);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
            Console.WriteLine("Result 3 : {0}", result3);
        }


        // CURRENT TESTS
        private static void CurrentTests()
        {
            ShortestBridgeFunc(); // Medium LC
        }
    }
}