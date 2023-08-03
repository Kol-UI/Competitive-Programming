using System;
using System.Collections.Generic;
using CompetitiveProgramming.CodeChef;
using CompetitiveProgramming.CoderByte;
using CompetitiveProgramming.LeetCode;
using CompetitiveProgramming.CodeWars;

namespace CompetitiveProgramming.TestDrivenDevelopment
{
    public class CSharpTDD
    {
        private static Delegate[] codeWarsEightList = new Delegate[]
        {
            GrasshopperSummationFunc, SumArrayFunc, RemoveFirstandLastCharacterFunc, ReturnNegativeFunc, RemoveExclamationMarksFunc, BeginnerLostWithoutaMapFunc,
            FindMinAndMaxOfListFunc, StringRepeatFunc, SumOfPositiveFunc, ConvertbooleanvaluestostringsYesorNoFunc, ConvertaNumbertoaStringFunc,
            EvenOrOddFunc, SquareNSumFunc, FindthesmallestintegerinthearrayFunc, RemoveStringSpacesFunc, CountingsheepFunc, ConvertaStringtoaNumberFunc,
            BeginnerSeries2ClockFunc, OppositesAttractFunc, SquaringAnArgumentFunc, ReturningStringsFunc, ReturnToSanityFunc, ReturnHelloWorldFunc,
            YouCantCodeUnderPressure1Func, CenturyFromYearFunc, BasicMathematicalOperationsFunc, ConvertNumberToReversedArrayOfDigitsFunc, AbbreviateaTwoWordNameFunc
        };

        private static Delegate[] codeWarsSevenKyuList = new Delegate[]
        {
            ItIsIsogramFunc,
        };

        private static Delegate[] codeWarsSixKyuList = new Delegate[]
        {
            ReplaceWithAlphabetPositionFunc,
        };

        private static Delegate[] codeChefLearn = new Delegate[]
        {
            StringOperationsFunc, IndexingFunc, AccessingcharactersofaStringFunc, StringOperationsSTRS7Func,
        };

        private static Delegate[] codeChefBeginner = new Delegate[]
        {
            AgeLimitFunc, NumberMirrorFunc,
        };

        private static Delegate[] leetCodeEasyList = new Delegate[]
        {
            ClimbingStairsFunc, AddTwoIntegersFunc, NumberOfStepsFunc, ContainsDuplicateFunc, BestTimetoBuyandSellStockFunc, RangeSumQueryImmutableFunc, DesignHashSetFunc, SearchintoaBinarySearchTreeFunc, SameTreeFunc,
            FirstUniqueCharacterinaStringFunc, SingleNumberFunc, FindJudgeFunc, ShuffleTheArrayFunc, CountOddNumbersInAnIntervalRangeFunc, RunningSumof1dArrayFunc, TwoSumIVInputisaBSTFunc, WordPatternFunc, SymmetricTreeFunc,
            AddBinaryFunc, DefanginganIPAddressFunc, FindLuckyIntegerinanArrayFunc, SearchInsertPositionFunc, FindtheIndexoftheFirstOccurrenceinaStringFunc, MinimumDistanceBetweenBSTNodesFunc, PascalsTriangleIIFunc,
            KthMissingPositiveNumberFunc, ConvertSortedArraytoBinarySearchTreeFunc, CanPlaceFlowersFunc, KItemsWiththeMaximumSumFunc, BinarySearchFunc, MiddleoftheLinkedListFunc, ReshapetheMatrixFunc, MergeSortedArrayFunc,
            CheckIfNandItsDoubleExistFunc, ConcatenationofArrayFunc, KidsWiththeGreatestNumberofCandiesFunc, MergeStringsAlternatelyFunc, RomantoIntegerFunc, DesignHashMapFunc, AlternatingDigitSumFunc, TwoSumFunc,
            BestPokerHandFunc, LastStoneWeightFunc, AddDigitsFunc, BulbSwitcherFunc, FindtheDifferenceFunc, RepeatedSubstringPatternFunc, VerifyinganAlienDictionaryFunc, MinimumAbsoluteDifferenceinBSTFunc,
            MoveZeroesFunc, PlusOneFunc, AverageSalaryExcludingtheMinimumandMaximumSalaryFunc, FindifPathExistsinGraphFunc, RichestCustomerWealthFunc, NumberofRecentCallsFunc, LongestPalindromeFunc,
            SignoftheProductofanArrayFunc, CanMakeArithmeticProgressionFunc, MonotonicArrayFunc, LengthofLastWordFunc, ToLowerCaseFunc, ConvertBinaryNumberinaLinkedListtoIntegerFunc, FirstBadVersionFunc,
            FindSmallestLetterGreaterThanTargetFunc, CountNegativeNumbersinaSortedMatrixFunc, ValidPerfectSquareFunc, ArrangingCoinsFunc, BaseballGameFunc, KeysandRoomsFunc, SumofLeftLeavesFunc, BinaryTreeInorderTraversalFunc,
            RobotReturntoOriginFunc, FindWinneronaTicTacToeGameFunc, LemonadeChangeFunc, LargestPerimeterTriangleFunc, CheckIfItIsaStraightLineFunc, DeleteColumnstoMakeSortedFunc, GuessNumberHigherorLowerFunc,
            ReverseVowelsofaStringFunc, CountingBitsFunc, IsSubsequenceFunc, MinCostClimbingStairsFunc, MaximumAverageSubarrayIFunc, DesignParkingSystemFunc, LeafSimilarTreesFunc, IntersectionofTwoArraysIIFunc,
            FindtheHighestAltitudeFunc, FindPivotIndexFunc, UniqueNumberofOccurrencesFunc, MajorityElementFunc, GoalParserInterpretationFunc, AddtoArrayFormofIntegerFunc, DetectCapitalFunc, ValidAnagramFunc,
            FloodFillFunc, HappyNumberFunc, DecryptStringfromAlphabettoIntegerMappingFunc, TheKWeakestRowsinaMatrixFunc, CheckifOneStringSwapCanMakeStringsEqualFunc, MergeTwoBinaryTreesFunc, BinaryTreePreorderTraversalFunc,
            SubtracttheProductandSumofDigitsofanIntegerFunc, SpecialArrayWithXElementsGreaterThanorEqualXFunc, SqrtxFunc, FindtheDistanceValueBetweenTwoArraysFunc, SortColorsFunc, ReverseStringFunc,
            SumofAllOddLengthSubarraysFunc, NextGreaterElementIFunc, SquaresofaSortedArrayFunc, FibonacciNumberFunc, FindNearestPointThatHastheSameXorYCoordinateFunc, NaryTreePreorderTraversalFunc,
            Numberof1BitsFunc, SortIntegersbyTheNumberof1BitsFunc, SearchinRotatedSortedArrayFunc, PowerofTwoFunc, ReverseWordsinaStringIIIFunc, GreatestCommonDivisorofStringsFunc, RansomNoteFunc, ValidParenthesesFunc,
            ReverseBitsFunc, MaximumValueofaStringinanArrayFunc, SummaryRangesFunc, FindtheDifferenceofTwoArraysFunc, IntegerBreakFunc, NthTribonacciNumberFunc, KthLargestElementinaStreamFunc, MergeTwoSortedListsFunc,
            InvertBinaryTreeFunc, IsomorphicStringsFunc, RemoveLinkedListElementsFunc, LinkedListCycleFunc, PascalsTriangleFunc, PathSumFuncFunc, MaximumDepthofBinaryTreeFunc, RemoveDuplicatesfromSortedListFunc,
        };

        private static Delegate[] leetCodeMediumList = new Delegate[]
        {
            RestoreIpAddressesFunc, SnakesAndLaddersFunc, FindClosestNodetoGivenTwoNodesFunc, FruitIntoBasketsFunc, JumpGameIIFunc, AllPathsFromSourcetoTargetFunc, MagneticForceBetweenTwoBallsFunc, PredicttheWinnerFunc, SubarraySumsDivisiblebyKFunc, ImplementQueueusingStacksFunc, SwapNodesinPairsFunc,
            AsFarfromLandasPossibleFunc, ShortestPathWithAlternatingColorsFunc, MinimumFuelCosttoReporttotheCapitalFunc, SingleElementinaSortedArrayFunc, CapacityToShipPackagesWithinDDaysFunc, DesignUndergroundSystemFunc, CheckCompletenessofaBinaryTreeFunc, BinaryTreeRightSideViewFunc, GenerateParenthesesFunc,
            SortanArrayFunc, StringCompressionFunc, MinimumTimetoCompleteTripsFunc, KokoEatingBananasFunc, ImplementTriePrefixTreeFunc, CountSubIslandsFunc, KRadiusSubarrayAveragesFunc, SeatReservationManagerFunc, MaximumLevelSumofaBinaryTreeFunc, LowestCommonAncestorofaBinaryTreeFunc, RemoveNthNodeFromEndofListFunc,
            NumberofZeroFilledSubarraysFunc, MinimumScoreofaPathBetweenTwoCitiesFunc, NumberofOperationstoMakeNetworkConnectedFunc, ReorderRoutestoMakeAllPathsLeadtotheCityZeroFunc, CountUnreachablePairsofNodesinanUndirectedGraphFunc, NondecreasingSubsequencesFunc, HouseRobberFunc, ValidSudokuFunc, AddTwoNumbersFunc,
            MinimumPathSumFunc, PrimeSubtractionOperationFunc, MinimumCostForTicketsFunc, SuccessfulPairsofSpellsandPotionsFunc, BoatstoSavePeopleFunc, HIndexIIFunc, FindaPeakElementIIFunc, WaterandJugProblemFunc, ShortestPathinBinaryMatrixFunc, OddEvenLinkedListFunc, GasStationFunc, PermutationsFunc,
            OptimalPartitionofStringFunc, MinimizeMaximumofArrayFunc, NumberofEnclavesFunc, RemoveStarsFunc, NumberofClosedIslandsFunc, RangeSumofSortedSubarraySumsFunc, SellDiminishingValuedColoredBallsFunc, PermutationsIIFunc, CheapestFlightsWithinKStopsFunc, LowestCommonAncestorofaBinarySearchTreeFunc,
            SimplifyPathFunc, ValidateStackSequencesFunc, LongestPalindromicSubsequenceFunc, NonoverlappingIntervalsFunc, RobotBoundedInCircleFunc, MinimumSizeSubarraySumFunc, OpentheLockFunc, DesignBrowserHistoryFunc, RottingOrangesFunc, ConstructQuadTreeFunc, BinaryTreePostorderTraversalFunc,
            MatrixDiagonalSumFunc, MultiplyStringsFunc, PowxnFunc, ReverseWordsinaStringFunc, ProductofArrayExceptSelfFunc, WaystoSplitArrayIntoThreeSubarraysFunc, FindKClosestElementsFunc, PopulatingNextRightPointersinEachNodeIIFunc, AddTwoNumbersIIFunc, PeekingIteratorFunc, SpiralMatrixFunc, ZigzagConversionFunc,
            Dota2SenateFunc, MinimumFlipstoMakeaORbEqualtocFunc, BestTimetoBuyandSellStockwithTransactionFeeFunc, IncreasingTripletSubsequenceFunc, MaximumNumberofVowelsinaSubstringofGivenLengthFunc, SearchSuggestionsSystemFunc, MaximumWidthofBinaryTreeFunc, ReverseLinkedListFunc, SpiralMatrixIIFunc,
            DominoandTrominoTilingFunc, ContainerWithMostWaterFunc, MaxNumberofKSumPairsFunc, UniquePathsFunc, NearestExitfromEntranceinMazeFunc, FrequencyoftheMostFrequentElementFunc, NumberofNodesintheSubTreeWiththeSameLabelFunc, DeleteNodeinaBSTFunc, HouseRobberIIIFunc, PopulatingNextRightPointersinEachNodeIFunc,
            LongestCommonSubsequenceFunc, MaxIceCreamFunc, TopKFrequentFunc, LexicographicallySmallestEquivalentStringFunc, FlipStringtoMonotoneIncreasingFunc, SearchA2DMatrixFunc, InsertIntervalFunc, MaxSubarraySumCircularFunc, SubarraySumFunc, SubarraysDivByKFunc, LinkedListCycleIIFunc, LetterCombinationsofaPhoneNumberFunc,
            LongestSubstringWithoutRepeatingCharactersFunc, UniquePathsIIFunc, MaximalSquareFunc, JumpGameFunc, PathSumIIFunc, MaximumValueataGivenIndexinaBoundedArrayFunc, BinarySearchTreeIteratorFunc, KthSmallestElementinaBSTFunc, ConstructBinaryTreefromPreorderandInorderTraversalFunc, SmallestNumberinInfiniteSetFunc,
            SnapshotArrayFunc, LongestIncreasingSubsequenceFunc, WiggleSubsequenceFunc, LongestPalindromicSubstringFunc, RangeSumQuery2DImmutableFunc, BestTimetoBuyandSellStockIIFunc, BestSightseeingPairFunc, MatrixBlockSumFunc, MaximumProductSubarrayFunc, MaximumLengthofSubarrayWithPositiveProductFunc,
            FindtheWinneroftheCircularGameFunc, RemoveDuplicatesfromSortedListIIFunc, DesignLinkedListFunc, MinStackFunc, CoinChangeFunc, CoinChangeIIFunc, MinimumRoundstoCompleteAllTasksFunc, SolvingQuestionsWithBrainpowerFunc, MaximumTwinSumofaLinkedListFunc, DeletetheMiddleNodeofaLinkedListFunc,
            MaxConsecutiveOnesIIIFunc, LongestSubarrayof1sAfterDeletingOneElementFunc, NumberofProvincesFunc, NumberofSubsequencesThatSatisfytheGivenSumConditionFunc, AsteroidCollisionFunc, IntervalListIntersectionsFunc, OnlineStockSpanFunc, EvaluateDivisionFunc, DesignAddandSearchWordsDataStructureFunc,
            FindPeakElementFunc, WateringPlantsIIFunc, CarPoolingFunc, CountWaysToBuildGoodStringsFunc, TotalCosttoHireKWorkersFunc, PacificAtlanticWaterFlowFunc, FindtheStudentthatWillReplacetheChalkFunc, JumpGameIIIFunc, DailyTemperaturesFunc, DecodeStringFunc, EvaluateReversePolishNotationFunc,
            MaximumSubsequenceScoreFunc, KthLargestElementinanArrayFunc, EqualRowandColumnPairsFunc, DetermineifTwoStringsAreCloseFunc, IsGraphBipartiteFunc, MinimumLimitofBallsinaBagFunc, AllPossibleFullBinaryTreesFunc, LetterCasePermutationFunc, TopKFrequentElementsFunc, ConvertSortedListtoBinarySearchTreeFunc,
            NextPermutationFunc, ShortestBridgeFunc, FindtheDuplicateNumberFunc, New21GameFunc, FindMinimuminRotatedSortedArrayFunc, NumberofIslandsFunc, LongestArithmeticSubsequenceFunc, MaximalNetworkRankFunc, UncrossedLinesFunc, MinimumNumberofArrowstoBurstBalloonsFunc, BinaryTreeLevelOrderTraversalFunc,
            StoneGameIIFunc, CourseScheduleFunc, ThreeSumFunc, PeakIndexinaMountainArrayFunc, DeleteandEarnFunc, SearchinRotatedSortedArrayIIFunc, ValidTriangleNumberFunc, RandomPickwithWeightFunc, CountGoodNodesinBinaryTreeFunc, DesignCircularQueueFunc, CombinationSumIIIFunc, ValidateBinarySearchTreeFunc,
            TwoSumIIInputArrayIsSortedFunc, FindFirstandLastPositionofElementinSortedArrayFunc, MergeIntervalsFunc, TimeNeededtoInformAllEmployeesFunc, SumofSquareNumbersFunc, AvoidFloodinTheCityFunc, KnightProbabilityinChessboardFunc, FindAllAnagramsinaStringFunc, PalindromePartitioningFunc, MaximumSubarrayFunc,
            DecodeWaysFunc, ArithmeticSlicesFunc, RotateArrayFunc, UglyNumberIIFunc, UniqueBinarySearchTreesFunc, FindRightIntervalFunc, ShortestSubarraytobeRemovedtoMakeArraySortedFunc, SwappingNodesinaLinkedListFunc, PossibleBipartitionFunc, LinkedListRandomNodeFunc, SumRoottoLeafNumbersFunc,
            MaximumDistanceBetweenaPairofValuesFunc, WordBreakFunc, ZeroOneMatrixFunc, MaxAreaofIslandFunc, TriangleFunc, MostProfitAssigningWorkFunc, CountCompleteTreeNodesFunc, LongestRepeatingCharacterReplacementFunc, InsertintoaBinarySearchTreeFunc, HouseRobberIIFunc, BinaryTreeZigzagLevelOrderTraversalFunc,
            NextGreaterElementIIIFunc, SubsetsIIFunc, MinimumNumberofVerticestoReachAllNodesFunc, BasicCalculatorIIFunc, TopKFrequentWordsFunc, NextGreaterElementIIFunc, LinkedListinBinaryTreeFunc, MaximumSideLengthofaSquarewithSumLessthanorEqualtoThresholdFunc, CloneGraphFunc, CombinationsFunc,
            SmallestRangeIIFunc, BestTeamWithNoConflictsFunc, ThreeSumClosestFunc, CombinationSumFunc, CopyListwithRandomPointerFunc, MinimumGeneticMutationFunc, LongestZigZagPathinaBinaryTreeFunc, SubarrayProductLessThanKFunc, PermutationinStringFunc, BestTimetoBuyandSellStockwithCooldownFunc, SetMatrixZeroesFunc,
            LongestArithmeticSubsequenceofGivenDifferenceFunc, PartitionEqualSubsetSumFunc, RotateListFunc, ArithmeticSubarraysFunc, OnlineElectionFunc, MinimumTimetoCollectAllApplesinaTreeFunc, PathwithMaximumProbabilityFunc, FindDuplicateSubtreesFunc, PathSumIIIFunc, ConstructBinaryTreefromInorderandPostorderTraversalFunc,
        };

        private static Delegate[] leetCodeHardList = new Delegate[]
        {
            CountDigitOneFunc, LongestPathWithDifferentAdjacentCharactersFunc, CheckifPointIsReachableFunc, NamingaCompanyFunc, IPOFunc, EditDistanceFunc, CountSubarraysWithFixedBoundsFunc, JumpGameIVFunc, LongestCycleinaGraphFunc, NumberofWaysofCuttingaPizzaFunc, FindMinimuminRotatedSortedArrayIIFunc,
            ReducingDishesFunc, ScrambleStringFunc, MinimumReverseOperationsFunc, LargestColorValueinaDirectedGraphFunc, MaximumValueofKCoinsFromPilesFunc, NumberofWaystoFormaTargetStringGivenaDictionaryFunc, ProfitableSchemesFunc, MinimumInsertionStepstoMakeaStringPalindromeFunc, RestoreTheArrayFunc, FindtheLongestValidObstacleCourseatEachPositionFunc,
            MaximizeScoreAfterNOperationsFunc, StoneGameIIIFunc, MinimumCosttoCutaStickFunc, TrappingRainWaterFunc, NumberofGoodPathsFunc, SerializeandDeserializeBinaryTreeFunc, ReverseNodesinkGroupFunc, MakeArrayStrictlyIncreasingFunc, NumberofIncreasingPathsinaGridFunc,
            NumberofWaystoReorderArraytoGetSameBSTFunc, TallestBillboardFunc, CheckingExistenceofEdgeLengthLimitedPathsFunc, MinimizeDeviationinArrayFunc, SubstringWithLargestVarianceFunc, MergekSortedListsFunc,
            CountAllPossibleRoutesFunc, MinimumJumpstoReachHomeFunc, BusRoutesFunc, StrangePrinterFunc, SumofDistancesinTreeFunc, DataStreamasDisjointIntervalsFunc,
            MinimumCosttoMakeArrayEqualFunc, RemoveMaxNumberofEdgestoKeepGraphFullyTraversableFunc, FirstMissingPositiveFunc, LFUCacheFunc, BinaryTreeMaximumPathSumFunc,
            MaximumNumberofEventsThatCanBeAttendedIIFunc, SmallestSufficientTeamFunc, MaximumNumberofAchievableTransferRequestsFunc, MaxPointsonaLineFunc,
            CourseScheduleIIFunc, LastDayWhereYouCanStillCrossFunc, ShortestPathtoGetAllKeysFunc, SimilarStringGroupsFunc, ConcatenatedWordsFunc,
        };

        private static Delegate[] hackerRankEasyList = new Delegate[]
        {
            SimpleArraySumFunc, SolveMeFirstFunc, AVeryBigSumFunc, CompareTheTripletsFunc, DiagonalDifferenceFunc, PlusMinusFunc,
        };

        private static Delegate[] hackerRankMediumList = new Delegate[]
        {
            
        };

        private static Delegate[] hackerRankHardList = new Delegate[]
        {
            
        };

        private static Delegate[] geeksForGeeksSchoolList = new Delegate[]
        {
            SumofSeriesFunc, PrintSecondLargestFunc,
        };

        private static Delegate[] geeksForGeeksBasicList = new Delegate[]
        {
            
        };

        private static Delegate[] geeksForGeeksEasyList = new Delegate[]
        {
            CounttheSubstringsFunc, MinimumIntegerFunc, Remainderondividingby11Func, MakeArrayElementsEqualFunc, EqualLeftandRightSubarraySumFunc, BFSofgraphFunc, MakeTheArrayBeautifulFunc, FrogsAndJumpFunc, DominantPairsFunc, DFSofGraphFunc,
        };

        private static Delegate[] geeksForGeeksMediumList = new Delegate[]
        {
            StringrporprFunc, EvenSwapFunc, MinimumStepsRequiredFunc, AddMinimumCharactersFunc, MaximumLengthFunc, RemoveandReverseFunc, ShyGeek, MaximumIntersectingLinesFunc, KnightInGeeklandFunc, CountSpecialNumbersFunc, BTSMaximumDifferenceFunc,
        };

        private static Delegate[] geeksForGeeksHardList = new Delegate[]
        {
            SpecialDigitsFunc, DivideInIncrementialGroupsFunc,
        };

        private static Delegate[] codeForces800List = new Delegate[]
        {
            TeamFunc, WayTooLongWordsFunc, WatermelonFunc,
        };

        private static Delegate[] coderByteList = new Delegate[]
        {
            FirstFactorialFunc, FirstReverseFunc
        };


        public static void StartAllTDD()
        {
            // All CoderByte Solutions
            CoderByteTests();

            // All CodeWars Solutions
            CodeWarsTests();

            // All CodeChef Solutions
            CodeChefTests();

            // All GeeksForGeeks Solutions
            GeeksForGeeksTests();

            // All HackerRank Solutions
            HackerRankTests();

            // All CodeForces Solutions
            CodeForcesTests();

            // All LeetCode Solutions
            LeetCodeTests();

            // Current Testing Solution
            CurrentTests();
        }


        private static void InvokeDelegateIfNotNull(Delegate[] delegatesToInvoke)
        {
            if (delegatesToInvoke != null && delegatesToInvoke.Length > 0)
            {
                foreach (Delegate del in delegatesToInvoke)
                {
                    del.DynamicInvoke();
                }
            }
        }

        
        private static void CodeWarsTests()
        {
            // 8 Kyu
            InvokeDelegateIfNotNull(codeWarsEightList);

            // 7 Kyu
            InvokeDelegateIfNotNull(codeWarsSevenKyuList);

            // 6 Kyu
            InvokeDelegateIfNotNull(codeWarsSixKyuList);
        }

        
        private static void CodeChefTests()
        {
            // Learn
            InvokeDelegateIfNotNull(codeChefLearn);

            // Beginner
            InvokeDelegateIfNotNull(codeChefBeginner);
        }


        private static void LeetCodeTests()
        {
            // Easy 
            InvokeDelegateIfNotNull(leetCodeEasyList);

            // Medium
            InvokeDelegateIfNotNull(leetCodeMediumList);

            // Hard
            InvokeDelegateIfNotNull(leetCodeHardList);
        }


        private static void HackerRankTests()
        {
            // Easy
            InvokeDelegateIfNotNull(hackerRankEasyList);

            // Medium
            InvokeDelegateIfNotNull(hackerRankMediumList);

            // Hard
            InvokeDelegateIfNotNull(hackerRankHardList);
        }


        private static void CodeForcesTests()
        {
            // 800
            InvokeDelegateIfNotNull(codeForces800List);
        }


        private static void GeeksForGeeksTests()
        {
            // School 
            InvokeDelegateIfNotNull(geeksForGeeksSchoolList);

            // Basic
            InvokeDelegateIfNotNull(geeksForGeeksBasicList);

            // Easy
            InvokeDelegateIfNotNull(geeksForGeeksEasyList);

            // Medium
            InvokeDelegateIfNotNull(geeksForGeeksMediumList);

            // Hard
            InvokeDelegateIfNotNull(geeksForGeeksHardList);
        }


        // CODERBYTE
        private static void CoderByteTests()
        {
            InvokeDelegateIfNotNull(coderByteList);
        }


        private static void ClimbingStairsFunc()
        {
            Program.Space();
            Program.Title("Climbing Stairs");
            ResultTester.CheckSolution("LC", LeetCode.ClimbingStairs.Test.TestClimbingStairs());
        }


        private static void AddTwoIntegersFunc()
        {
            Program.Space();
            Program.Title("2235. Add Two Integers");
            string source = "LC";
            // Add Two Intergers

            // Case 1
            int Case1_2235 = LeetCode.AddTwoIntegers.Solution.Sum(12, 5);

            // Case 2
            int Case2_2235 = LeetCode.AddTwoIntegers.Solution.Sum(-10, 4);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_2235, 17),
                ResultTester.CheckResult<int>(Case2_2235, -6)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void FirstFactorialFunc()
        {
            Program.Space();
            Program.Title("First Factorial");
            ResultTester.CheckSolution("CB", CoderByte.FirstFactorial.Test.TestFirstFactorial());
        }


        private static void FirstReverseFunc()
        {
            Program.Space();
            Program.Title("First Reverse");
            ResultTester.CheckSolution("CB", CoderByte.FirstReverse.Test.TestFirstReverse());
        }


        private static void ReplaceWithAlphabetPositionFunc()
        {
            Program.Space();
            Program.Title("Replace With Alphabet Position");
            ResultTester.CheckSolution("CW", CodeWars.SixKyu.ReplaceWithAlphabetPosition.Test.TestReplaceWithAlphabetPosition());
        }


        private static void GrasshopperSummationFunc()
        {
            Program.Space();
            Program.Title("Grasshopper Summation");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.GrasshopperSummation.Test.TestGrasshopperSummation());
        }


        private static void NumberOfStepsFunc()
        {
            Program.Space();
            Program.Title("Number of Steps to Reduce a Number to Zero");

            // Case 1
            int Case1_NumberOfSteps = LeetCode.NumberofStepstoReduceaNumbertoZero.Solution.NumberOfSteps(14);

            // Case 2
            int Case2_NumberOfSteps = LeetCode.NumberofStepstoReduceaNumbertoZero.Solution.NumberOfSteps(8);

            // Case 3
            int Case3_NumberOfSteps = LeetCode.NumberofStepstoReduceaNumbertoZero.Solution.NumberOfSteps(123);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_NumberOfSteps, 6),
                ResultTester.CheckResult<int>(Case2_NumberOfSteps, Case2_NumberOfSteps),
                ResultTester.CheckResult<int>(Case3_NumberOfSteps, Case3_NumberOfSteps)
            };
            ResultTester.CheckSolution("LC", results);
        }


        private static void SumArrayFunc()
        {
            Program.Space();
            Program.Title("Sum Array");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.SumArray.Test.TestSumArray());
        }


        private static void LongestCommonSubsequenceFunc()
        {
            Program.Space();
            Program.Title("Longest Common Subsequence");
            ResultTester.CheckSolution("LC", LeetCode.LongestCommonSubsequence.Solution.TestLongestCommonSubsequence());
        }


        private static void RemoveFirstandLastCharacterFunc()
        {
            Program.Space();
            Program.Title("Remove First and Last Character");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.RemoveFirstandLastCharacter.Test.TestRemoveFirstandLastCharacter());
        }


        private static void ItIsIsogramFunc()
        {
            Program.Space();
            Program.Title("It is an Isogram");
            ResultTester.CheckSolution("CW", CodeWars.SevenKyu.Isograms.Test.TestIsograms());
        }


        private static void CountDigitOneFunc()
        {
            Program.Space();
            Program.Title("Count Digit One");
            ResultTester.CheckSolution("LC", LeetCode.NumberofDigitOne.Test.TestNumberofDigitOne());
        }


        private static void ContainsDuplicateFunc()
        {
            Program.Space();
            Program.Title("Contains Duplicate");
            ResultTester.CheckSolution("LC", LeetCode.ContainsDuplicate.Test.TestContainsDuplicate());            
        }


        private static void MaxIceCreamFunc()
        {
            Program.Space();
            Program.Title("Max Ice Cream");
            string source = "LC";

            // Case 1
            int[] Case1_1833 = { 1, 2, 3, 1 };
            int CoinsCase1 = 7;
            int Case1_1833_Result = LeetCode.MaximumIceCreamBars.Solution.MaxIceCream(Case1_1833, CoinsCase1);

            // Case 2
            int[] Case2_1833 = { 10, 6, 8, 7, 7, 8 };
            int CoinsCase2 = 5;
            int Case2_1833_Result = LeetCode.MaximumIceCreamBars.Solution.MaxIceCream(Case2_1833, CoinsCase2);

            // Case 3
            int[] Case3_1833 = { 1, 6, 3, 1, 2, 5 };
            int CoinsCase3 = 20;
            int Case3_1833_Result = LeetCode.MaximumIceCreamBars.Solution.MaxIceCream(Case3_1833, CoinsCase3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_1833_Result, 4),
                ResultTester.CheckResult<int>(Case2_1833_Result, 0),
                ResultTester.CheckResult<int>(Case3_1833_Result, 6)
            };
            ResultTester.CheckSolution(source, results);
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
            string source = "LC";

            // Case 1
            int[] Case1_2246 = { -1, 0, 0, 0 };
            string s1 = "abacbe";
            int Case1_2246_Result = LeetCode.LongestPathWithDifferentAdjacentCharacters.Solution.LongestPath(Case1_2246, s1);

            // Case 2
            int[] Case2_2246 = { 1, 1, 1, 2, 2, 3 };
            string s2 = "aabc";
            int Case2_2246_Result = LeetCode.LongestPathWithDifferentAdjacentCharacters.Solution.LongestPath(Case2_2246, s2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_2246_Result, 3),
                ResultTester.CheckResult<int>(Case2_2246_Result, 1)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void LexicographicallySmallestEquivalentStringFunc()
        {
            Program.Space();
            Program.Title("Lexicographically Smallest Equivalent String");
            ResultTester.CheckSolution("LC", LeetCode.LexicographicallySmallestEquivalentString.Test.TestLexicographicallySmallestEquivalentString());
        }


        private static void FlipStringtoMonotoneIncreasingFunc()
        {
            Program.Space();
            Program.Title("Flip String to Monotone Increasing");
            ResultTester.CheckSolution("LC", LeetCode.FlipStringtoMonotoneIncreasing.Test.TestFlipStringtoMonotoneIncreasing());
        }


        private static void SearchA2DMatrixFunc()
        {
            Program.Space();
            Program.Title("Search a Matrix");
            ResultTester.CheckSolution("LC", LeetCode.Searcha2DMatrix.Test.TestSearcha2DMatrix());
        }


        private static void SetMatrixZeroesFunc()
        {
            Program.Space();
            Program.Title("Set Matrix Zeroes");
            ResultTester.CheckSolution("LC", LeetCode.SetMatrixZeroes.Test.TestSetMatrixZeroes());
        }


        private static void InsertIntervalFunc()
        {
            Program.Space();
            Program.Title("Insert Interval");
            ResultTester.CheckSolution("LC", LeetCode.InsertInterval.Test.TestInsertInterval());
        }


        private static void BestTimetoBuyandSellStockFunc()
        {
            Program.Space();
            Program.Title("Best Time to Buy and Sell Stock");
            ResultTester.CheckSolution("LC", LeetCode.BestTimetoBuyandSellStock.Test.TestBestTimetoBuyandSellStock());
        }


        private static void FirstUniqueCharacterinaStringFunc()
        {
            Program.Space();
            Program.Title("First Unique Character in a String");
            ResultTester.CheckSolution("LC", LeetCode.FirstUniqueCharacterinaString.Test.TestFirstUniqueCharacterinaString());
        }


        private static void RansomNoteFunc()
        {
            Program.Space();
            Program.Title("Ransom Note");
            ResultTester.CheckSolution("LC", LeetCode.RansomNote.Test.TestRansomNote());
        }


        private static void LinkedListRandomNodeFunc()
        {
            Program.Space();
            Program.Title("Linked List Random Node");
            ResultTester.SpecialTestCase("LC");
        }


        private static void BinaryTreePreorderTraversalFunc()
        {
            Program.Space();
            Program.Title("Binary Tree Preorder Traversal");
            ResultTester.SpecialTestCase("LC");
        }
        

        private static void CombinationSumIIIFunc()
        {
            Program.Space();
            Program.Title("Combination Sum III");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ValidSudokuFunc()
        {
            Program.Space();
            Program.Title("Valid Sudoku");
            ResultTester.SpecialTestCase("LC");
        }


        private static void LinkedListCycleIIFunc()
        {
            Program.Space();
            Program.Title("Linked List Cycle II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void LinkedListCycleFunc()
        {
            Program.Space();
            Program.Title("Linked List Cycle");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CloneGraphFunc()
        {
            Program.Space();
            Program.Title("Clone Graph");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PalindromePartitioningFunc()
        {
            Program.Space();
            Program.Title("Palindrome Partitioning");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SumRoottoLeafNumbersFunc()
        {
            Program.Space();
            Program.Title("Sum Root to Leaf Numbers");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SingleNumberFunc()
        {
            Program.Space();
            Program.Title("Single Number");
            ResultTester.CheckSolution("LC", LeetCode.SingleNumber.Test.TestSingleNumber());
        }


        private static void BinaryTreeMaximumPathSumFunc()
        {
            Program.Space();
            Program.Title("Binary Tree Maximum Path Sum");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaxSubarraySumCircularFunc()
        {
            Program.Space();
            Program.Title("Max Subarray Sum Circular");
            ResultTester.CheckSolution("LC", LeetCode.MaximumSumCircularSubarray.Test.TestMaximumSumCircularSubarray());
        }


        private static void GasStationFunc()
        {
            Program.Space();
            Program.Title("Gas Station");
            ResultTester.CheckSolution("LC", LeetCode.GasStation.Test.TestGasStation());
        }


        private static void SubarraySumFunc()
        {
            Program.Space();
            Program.Title("Subarray Sum");
            ResultTester.CheckSolution("LC", LeetCode.SubarraySumEqualsK.Test.TestSubarraySumEqualsK());
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
            ResultTester.CheckSolution("LC", LeetCode.FindtheTownJudge.Test.TestFindtheTownJudge());
        }


        private static void RottingOrangesFunc()
        {
            Program.Space();
            Program.Title("Rotting Oranges");
            ResultTester.CheckSolution("LC", LeetCode.RottingOranges.Test.TestRottingOranges());
        }


        private static void AddtoArrayFormofIntegerFunc()
        {
            Program.Space();
            Program.Title("Add to Array Form of Integer");
            ResultTester.CheckSolution("LC", LeetCode.AddtoArrayFormofInteger.Test.TestAddtoArrayFormofInteger());
        }


        private static void RestoreIpAddressesFunc()
        {
            Program.Space();
            Program.Title("Restore Ip Addresses");
            ResultTester.CheckSolution("LC", LeetCode.RestoreIPAddresses.Test.TestRestoreIPAddresses());
        }


        private static void CheckifPointIsReachableFunc()
        {
            Program.Space();
            Program.Title("Check if Point Is Reachable");
            string source = "LC";

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

            bool output1 = false;
            bool output2 = true;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Case1_2543_Result, output1),
                ResultTester.CheckResult<bool>(Case2_2543_Result, output2),
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void SnakesAndLaddersFunc()
        {
            Program.Space();
            Program.Title("Snakes And Ladders");
            ResultTester.CheckSolution("LC", LeetCode.SnakesandLadders.Test.TestSnakesandLadders());
        }


        private static void FindClosestNodetoGivenTwoNodesFunc()
        {
            Program.Space();
            Program.Title("Find Closest Node to Given Two Nodes");
            string source = "LC";

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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_2359_Result, 2),
                ResultTester.CheckResult<int>(Case2_2359_Result, 2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void ShuffleTheArrayFunc()
        {
            Program.Space();
            Program.Title("Shuffle The Array");
            string source = "LC";

            // Case 1
            int[] arrayCase1_1470 = { 2, 5, 1, 3, 4, 7 };
            int nCase1_1470 = 3;
            int[] Case1_1470_Result = LeetCode.ShuffletheArray.Solution.Shuffle(arrayCase1_1470, nCase1_1470);

            // Case 2
            int[] arrayCase2_1470 = { 1, 2, 3, 4, 4, 3, 2, 1 };
            int nCase2_1470 = 4;
            int[] Case2_1470_Result = LeetCode.ShuffletheArray.Solution.Shuffle(arrayCase2_1470, nCase2_1470);
            
            // Case 3
            int[] arrayCase3_1470 = { 1, 1, 2, 2 };
            int nCase3_1470 = 2;
            int[] Case3_1470_Result = LeetCode.ShuffletheArray.Solution.Shuffle(arrayCase3_1470, nCase3_1470);

            int[] expected1 = {2,3,5,4,1,7};
            int[] expected2 = {1,4,2,3,3,2,4,1};
            int[] expected3 = {1,2,1,2};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Case1_1470_Result, expected1),
                ResultTester.CheckResult<int[]>(Case2_1470_Result, expected2),
                ResultTester.CheckResult<int[]>(Case3_1470_Result, expected3)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void CountOddNumbersInAnIntervalRangeFunc()
        {
            Program.Space();
            Program.Title("Count Odd Numbers in an Interval Range");
            string source = "LC";

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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_1523_Result, 3),
                ResultTester.CheckResult<int>(Case2_1523_Result, 1),
                ResultTester.CheckResult<int>(Case3_1523_Result, Case3_1523_Result)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void NumberofNodesintheSubTreeWiththeSameLabelFunc()
        {
            Program.Space();
            Program.Title("Number of Nodes in the Sub-Tree With the Same Label");
            string source = "LC";
            ResultTester.SpecialTestCase(source);
        }


        private static void FruitIntoBasketsFunc()
        {
            Program.Space();
            Program.Title("Fruit Into Baskets");
            ResultTester.CheckSolution("LC", LeetCode.FruitIntoBaskets.Test.TestFruitIntoBaskets());
        }


        private static void OnlineStockSpanFunc()
        {
            Program.Space();
            Program.Title("Online Stock Span");
            ResultTester.SpecialTestCase("LC");
        }


        private static void JumpGameIIFunc()
        {
            Program.Space();
            Program.Title("Jump Game II");
            ResultTester.CheckSolution("LC", LeetCode.JumpGameII.Test.TestJumpGameII());
        }


        private static void EvenOrOddFunc()
        {
            Program.Space();
            Program.Title("Even or Odd");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.EvenorOdd.Test.TestEvenorOdd());
        }


        private static void NamingaCompanyFunc()
        {
            Program.Space();
            Program.Title("Naming a Company");
            string source = "LC";

            // Case 1
            string[] arrayCase1_2306 = { "coffee", "donuts", "time", "toffee"};
            long Case1_2306_Result = LeetCode.NamingaCompany.Solution.DistinctNames(arrayCase1_2306);

            // Case 2
            string[] arrayCase2_2306 = { "lack", "back"};
            long Case2_2306_Result = LeetCode.NamingaCompany.Solution.DistinctNames(arrayCase2_2306);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Case1_2306_Result, 6),
                ResultTester.CheckResult<long>(Case2_2306_Result, 0)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void AsFarfromLandasPossibleFunc()
        {
            Program.Space();
            Program.Title("As Far from Land as Possible");
            ResultTester.CheckSolution("LC", LeetCode.AsFarfromLandasPossible.Solution.TestAsFarfromLandasPossible());
        }


        private static void MaximumLevelSumofaBinaryTreeFunc()
        {
            Program.Space();
            Program.Title("Maximum Level Sum of a Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ShortestPathWithAlternatingColorsFunc()
        {
            Program.Space();
            Program.Title("Shortest Path With Alternating Colors");
            ResultTester.CheckSolution("LC", LeetCode.ShortestPathwithAlternatingColors.Test.TestShortestPathwithAlternatingColors());
        }


        private static void MinimumFuelCosttoReporttotheCapitalFunc()
        {
            Program.Space();
            Program.Title("Minimum Fuel Cost to Report to the Capital");
            string source = "LC";

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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Case1_2477_Result, 3),
                ResultTester.CheckResult<long>(Case2_2477_Result, 7),
                ResultTester.CheckResult<long>(Case3_2477_Result, 0)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void AddBinaryFunc()
        {
            Program.Space();
            Program.Title("Add Binary");
            ResultTester.CheckSolution("LC", LeetCode.AddBinary.Test.TestAddBinary());
        }


        private static void ConvertaNumbertoaStringFunc()
        {
            Program.Space();
            Program.Title("Convert a Number to a String");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.ConvertaNumbertoaString.Test.TestConvertaNumbertoaString());
        }


        private static void DefanginganIPAddressFunc()
        {
            Program.Space();
            Program.Title("Defanging an IP Address");
            ResultTester.CheckSolution("LC", LeetCode.DefanginganIPAddress.Test.TestDefanginganIPAddress());
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

            string source = "LC";
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_1394_Result, 2),
                ResultTester.CheckResult<int>(Case2_1394_Result, 3),
                ResultTester.CheckResult<int>(Case3_1394_Result, -1),
                ResultTester.CheckResult<int>(Case4_1394_Result, Case4_1394_Result)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void ConvertbooleanvaluestostringsYesorNoFunc()
        {
            Program.Space();
            Program.Title("Convert boolean values to strings Yes or No");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.ConvertbooleanvaluestostringsYesorNo.Test.TestConvertbooleanvaluestostringsYesorNo());  
        }


        private static void SumOfPositiveFunc()
        {
            Program.Space();
            Program.Title("Sum Of Positive");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.Sumofpositive.Test.TestYouCantCodeUnderPressure1());
        }


        private static void StringRepeatFunc()
        {
            Program.Space();
            Program.Title("String Repeat");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.Stringrepeat.Test.TestStringrepeat());
        }


        private static void FindMinAndMaxOfListFunc()
        {
            Program.Space();
            Program.Title("Find Min And Max Of List");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Test.TestFindMaximumandMinimumValuesofaList());
        }


        private static void RemoveExclamationMarksFunc()
        {
            Program.Space();
            Program.Title("Remove Exclamation Marks");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.RemoveExclamationMarks.Test.TestRemoveExclamationMarks());
        }


        private static void ReturnNegativeFunc()
        {
            Program.Space();
            Program.Title("Return Negative");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.ReturnNegative.Test.TestReturnNegative());
        }


        private static void SearchInsertPositionFunc()
        {
            Program.Space();
            Program.Title("Search Insert Position");
            ResultTester.CheckSolution("LC", LeetCode.SearchInsertPosition.Test.TestSearchInsertPosition());
        }


        private static void StringOperationsFunc()
        {
            Program.Space();
            Program.Title("String Operations");
            ResultTester.CheckSolution("CC", CodeChef.StringOperations.Test.TestStringOperations());
        }


        private static void StringOperationsSTRS7Func()
        {
            Program.Space();
            Program.Title("String Operations 7");
            ResultTester.CheckSolution("CC", CodeChef.StringOperationsStrs7.Test.TestStringOperationsStrs7());
        }


        private static void AgeLimitFunc()
        {
            Program.Space();
            Program.Title("Age Limit");
            ResultTester.SpecialTestCase("CC");
        }


        private static void NumberMirrorFunc()
        {
            Program.Space();
            Program.Title("Number Mirror");
            ResultTester.SpecialTestCase("CC");
        }


        private static void MinimumAbsoluteDifferenceinBSTFunc()
        {
            Program.Space();
            Program.Title("Minimum Absolute Difference in BST");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SingleElementinaSortedArrayFunc()
        {
            Program.Space();
            Program.Title("Single Element in a Sorted Array");
            ResultTester.CheckSolution("LC", LeetCode.SingleElementinaSortedArray.Test.TestSingleElementinaSortedArray());
        }


        private static void CapacityToShipPackagesWithinDDaysFunc()
        {
            Program.Space();
            Program.Title("Capacity To Ship Packages Within D Days");
            ResultTester.CheckSolution("LC", LeetCode.CapacityToShipPackagesWithinDDays.Test.TestCapacityToShipPackagesWithinDDays());
        }


        private static void IPOFunc()
        {
            Program.Space();
            Program.Title("IPO");
            ResultTester.CheckSolution("LC", LeetCode.IPO.Test.TestIPO());
        }


        private static void EditDistanceFunc()
        {
            Program.Space();
            Program.Title("Edit Distance");
            ResultTester.CheckSolution("LC", LeetCode.EditDistance.Test.TestEditDistance());
        }


        private static void SortanArrayFunc()
        {
            Program.Space();
            Program.Title("Sort an Array");
            ResultTester.CheckSolution("LC", LeetCode.SortanArray.Test.TestSortanArray());
        }


        private static void StringCompressionFunc()
        {
            Program.Space();
            Program.Title("String Compression");
            ResultTester.CheckSolution("LC", LeetCode.StringCompression.Test.TestStringCompression());
        }


        private static void DFSofGraphFunc()
        {
            Program.Space();
            Program.Title("DFS of Graph");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.DFSofGraph.Test.TestDFSofGraph());
        }


        private static void OppositesAttractFunc()
        {
            Program.Space();
            Program.Title("OppositesAttract");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.OppositesAttract.Test.TestOppositesAttract());
        }


        private static void FindtheIndexoftheFirstOccurrenceinaStringFunc()
        {
            Program.Space();
            Program.Title("Find the Index of the First Occurrence in a String");
            ResultTester.CheckSolution("LC", LeetCode.FindtheIndexoftheFirstOccurrenceinaString.Test.TestFindtheIndexoftheFirstOccurrenceinaString());
        }


        private static void CountSubarraysWithFixedBoundsFunc()
        {
            Program.Space();
            Program.Title("Count Subarrays With Fixed Bounds");
            string source = "LC";

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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(resultCase1_2444, 2),
                ResultTester.CheckResult<long>(resultCase2_2444, 10),
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void JumpGameIVFunc()
        {
            Program.Space();
            Program.Title("Jump Game IV");
            string source = "LC";

            // Case 1
            int[] arrCase1_1345 = { 100, -23, -23, 404, 100, 23, 23, 23, 3, 404 };
            int resultCase1_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase1_1345);

            // Case 2
            int[] arrCase2_1345 = { 7 };
            int resultCase2_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase2_1345);

            // Case 3
            int[] arrCase3_1345 = { 7, 6, 9, 6, 9, 6, 9, 7 };
            int resultCase3_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase3_1345);

            // Case 4
            int[] arrCase4_1345 = { -1, 100, 100, 100, 100, 100, 100, -1, };
            int resultCase4_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase4_1345);

            // Case 5
            int[] arrCase5_1345 = Program.GenerateRandomNumber(100, 5);
            int resultCase5_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase5_1345);

            // Case 6
            int[] arrCase6_1345 = Program.GenerateRandomNumber(1000, 5);
            int resultCase6_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase6_1345);

            // Case 7
            int[] arrCase7_1345 = Program.GenerateRandomNumber(100, 10);
            int resultCase7_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase7_1345);

            // Case 8
            int[] arrCase8_1345 = Program.GenerateRandomNumber(1000, 10);
            int resultCase8_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase8_1345);

            // Case 9
            int[] arrCase9_1345 = Program.GenerateRandomNumber(10, 100);
            int resultCase9_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase9_1345);

            // Case 10
            int[] arrCase10_1345 = Program.GenerateRandomNegativeNumber(5);
            int resultCase10_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase10_1345);

            // Case 11
            int[] arrCase11_1345 = Program.GenerateRandomNegativeNumber(10);
            int resultCase11_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase11_1345);

            // Case 12
            int[] arrCase12_1345 = Program.GenerateRandomNegativePositiveNumber(5);
            int resultCase12_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase12_1345);

            // Case 13
            int[] arrCase13_1345 = Program.GenerateRandomNegativePositiveNumber(10);
            int resultCase13_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase13_1345);

            // Case 14
            int[] arrCase14_1345 = arrCase1_1345.Concat(arrCase2_1345).Concat(arrCase3_1345).Concat(arrCase4_1345)
                                                .Concat(arrCase5_1345).Concat(arrCase6_1345).Concat(arrCase7_1345)
                                                .Concat(arrCase8_1345).Concat(arrCase9_1345).Concat(arrCase10_1345)
                                                .Concat(arrCase11_1345).Concat(arrCase12_1345)
                                                .Concat(arrCase13_1345).ToArray();

            int resultCase14_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase14_1345);

            // Case 15
            int[] arrCase15_1345 = arrCase14_1345;
            Program.ShuffleArray(arrCase15_1345);
            int resultCase15_1345 = LeetCode.JumpGameIV.Solution.MinJumps(arrCase15_1345);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(resultCase1_1345, 3),
                ResultTester.CheckResult<int>(resultCase2_1345, 0),
                ResultTester.CheckResult<int>(resultCase3_1345, 1),
                ResultTester.CheckResult<int>(resultCase4_1345, resultCase4_1345),
                ResultTester.CheckResult<int>(resultCase5_1345, resultCase5_1345),
                ResultTester.CheckResult<int>(resultCase6_1345, resultCase6_1345),
                ResultTester.CheckResult<int>(resultCase7_1345, resultCase7_1345),
                ResultTester.CheckResult<int>(resultCase8_1345, resultCase8_1345),
                ResultTester.CheckResult<int>(resultCase9_1345, resultCase9_1345),
                ResultTester.CheckResult<int>(resultCase10_1345, resultCase10_1345),
                ResultTester.CheckResult<int>(resultCase11_1345, resultCase11_1345),
                ResultTester.CheckResult<int>(resultCase12_1345, resultCase12_1345),
                ResultTester.CheckResult<int>(resultCase13_1345, resultCase13_1345),
                ResultTester.CheckResult<int>(resultCase14_1345, resultCase14_1345),
                ResultTester.CheckResult<int>(resultCase15_1345, resultCase15_1345),
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void KthMissingPositiveNumberFunc()
        {
            Program.Space();
            Program.Title("Kth Missing Positive Number");
            string source = "LC";

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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(resultCase1_1345, 9),
                ResultTester.CheckResult<int>(resultCase2_1345, 6),
                ResultTester.CheckResult<int>(resultCase3_1345, resultCase3_1345)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MinimumTimetoCompleteTripsFunc()
        {
            Program.Space();
            Program.Title("Minimum Time to Complete Trips");
            string source = "LC";

            // Case 1
            int[] time1_1287 = {1, 2, 3};
            int totalTrips1_1287 = 5;
            long result1_1287 = LeetCode.MinimumTimetoCompleteTrips.Solution.MinimumTime(time1_1287, totalTrips1_1287);

            // Case 2
            int[] time2_1287 = { 2 };
            int totalTrips2_1287 = 1;
            long result2_1287 = LeetCode.MinimumTimetoCompleteTrips.Solution.MinimumTime(time2_1287, totalTrips2_1287);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(result1_1287, 3),
                ResultTester.CheckResult<long>(result2_1287, 2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void KokoEatingBananasFunc()
        {
            Program.Space();
            Program.Title("Koko Eating Bananas");
            ResultTester.CheckSolution("LC", LeetCode.KokoEatingBananas.Test.TestKokoEatingBananas());
        }


        private static void LeafSimilarTreesFunc()
        {
            Program.Space();
            Program.Title("Leaf-Similar Trees");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ConvertSortedArraytoBinarySearchTreeFunc()
        {
            Program.Space();
            Program.Title("Convert Sorted Array to Binary Search Tree");
            ResultTester.CheckSolution("LC", LeetCode.ConvertSortedArraytoBinarySearchTree.Test.TestConvertSortedArraytoBinarySearchTree());
        }


        private static void ImplementTriePrefixTreeFunc()
        {
            Program.Space();
            Program.Title("Implement Trie Prefix Tree");
            ResultTester.CheckSolution("LC", LeetCode.ImplementTriePrefixTree.Test.TestImplementTriePrefixTree());
        }


        private static void SquareNSumFunc()
        {
            Program.Space();
            Program.Title("Square(n) Sum");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.SquareNSum.Test.TestStringrepeat());
        }


        private static void FindthesmallestintegerinthearrayFunc()
        {
            Program.Space();
            Program.Title("Find the smallest integer in the array");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.Findthesmallestintegerinthearray.Test.TestFindthesmallestintegerinthearray());
        }


        private static void SumofSeriesFunc()
        {
            Program.Space();
            Program.Title("Sum of Series");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.School.SumofSeries.Test.TestSumofSeries());
        }


        private static void PrintSecondLargestFunc()
        {
            Program.Space();
            Program.Title("Print Second Largest");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.School.SecondLargest.Test.TestSecondLargest());
        }


        private static void StringrporprFunc()
        {
            Program.Space();
            Program.Title("String rp or pr");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Medium.Stringrporpr.Test.TestStringrporpr());
        }


        private static void CanPlaceFlowersFunc()
        {
            Program.Space();
            Program.Title("Can Place Flowers");
            ResultTester.CheckSolution("LC", LeetCode.CanPlaceFlowers.Test.TestCanPlaceFlowers());
        }


        private static void NumberofZeroFilledSubarraysFunc()
        {
            Program.Space();
            Program.Title("Number of Zero-Filled Subarrays");
            string source = "LC";

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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(case1_2348Result, 6),
                ResultTester.CheckResult<long>(case2_2348Result, 9)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MinimumScoreofaPathBetweenTwoCitiesFunc()
        {
            Program.Space();
            Program.Title("Minimum Score of a Path Between Two Cities");
            string source = "LC";

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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result2492Case1, 6),
                ResultTester.CheckResult<int>(result2492Case2, 2)
            };
            ResultTester.CheckSolution(source, results);
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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1319Case1, 1),
                ResultTester.CheckResult<int>(result1319Case2, 2),
                ResultTester.CheckResult<int>(result1319Case3, -1)
            };
            ResultTester.CheckSolution("LC", results);
        }


        private static void RemoveStringSpacesFunc()
        {
            Program.Space();
            Program.Title("Remove String Spaces");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.RemoveStringSpaces.Test.TestRemoveStringSpaces());       
        }

        
        private static void CountingsheepFunc()
        {
            Program.Space();
            Program.Title("Counting Sheep");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.Countingsheep.Test.TestCountingsheep());       
        }


        private static void ConvertaStringtoaNumberFunc()
        {
            Program.Space();
            Program.Title("Convert a String to a Number");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.ConvertaStringtoaNumber.Test.TestConvertaStringtoaNumber());       
        }


        private static void ReorderRoutestoMakeAllPathsLeadtotheCityZeroFunc()
        {
            Program.Space();
            Program.Title("Reorder Routes to Make All Paths Lead to the City Zero");
            string source = "LC";
            
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

            // Case 3
            int[][] connections1466Case3 = new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 2, 0 }
            };
            int n1466Case3 = 3;
            int result1466Case3 = LeetCode.ReorderRoutestoMakeAllPathsLeadtotheCityZero.Solution.MinReorder(n1466Case3, connections1466Case3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1466Case1, 3),
                ResultTester.CheckResult<int>(result1466Case2, 3),
                ResultTester.CheckResult<int>(result1466Case3, 3)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void CountUnreachablePairsofNodesinanUndirectedGraphFunc()
        {
            Program.Space();
            Program.Title("Count Unreachable Pairs of Nodes in an Undirected Graph");
            string source = "LC";
            
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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Result2316Case1, 0),
                ResultTester.CheckResult<long>(Result2316Case2, 14),
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void LongestCycleinaGraphFunc()
        {
            Program.Space();
            Program.Title("Longest Cycle in a Graph");
            string source = "LC";

            // Case 1
            int[] edges2360Case1 = { 3, 3, 4, 2, 3 };
            int result2360Case1 = LeetCode.LongestCycleinaGraph.Solution.LongestCycle(edges2360Case1);
            Console.WriteLine("Result Case 1: {0}", result2360Case1);

            // Case 2
            int[] edges2360Case2 = { 2, -1, 3, 1 };
            int result2360Case2 = LeetCode.LongestCycleinaGraph.Solution.LongestCycle(edges2360Case2);
            Console.WriteLine("Result Case 2: {0}", result2360Case2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result2360Case1, 3),
                ResultTester.CheckResult<int>(result2360Case2, -1),
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MinimumPathSumFunc()
        {
            Program.Space();
            Program.Title("Minimum Path Sum");
            ResultTester.CheckSolution("LC", LeetCode.MinimumPathSum.Test.TestMinimumPathSum());
        }


        private static void PrimeSubtractionOperationFunc()
        {
            Program.Space();
            Program.Title("Prime Subtraction Operation");
            string source = "LC";

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

            bool output1_2601 = true;
            bool output2_2601 = true;
            bool output3_2601 = false;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result2601Case1, output1_2601),
                ResultTester.CheckResult<bool>(result2601Case2, output2_2601),
                ResultTester.CheckResult<bool>(result2601Case3, output3_2601)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MinimumCostForTicketsFunc()
        {
            Program.Space();
            Program.Title("Minimum Cost For Tickets");
            ResultTester.CheckSolution("LC", LeetCode.MinimumCostForTickets.Test.TestMinimumCostForTickets());
        }


        private static void KItemsWiththeMaximumSumFunc()
        {
            Program.Space();
            Program.Title("K Items With the Maximum Sums");
            string source = "LC";

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

            int output1 = 2;
            int output2 = 3;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result2600Case1, output1),
                ResultTester.CheckResult<int>(result2600Case2, output2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void CounttheSubstringsFunc()
        {
            Program.Space();
            Program.Title("Count the Substrings");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.CounttheSubstrings.Test.TestCounttheSubstrings());
        }


        private static void MinimumIntegerFunc()
        {
            Program.Space();
            Program.Title("Minimum Integer");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.MinimumInteger.Test.TestMinimumInteger());
        }


        private static void EvenSwapFunc()
        {
            Program.Space();
            Program.Title("Even Swap");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Medium.EvenSwap.Test.TestEvenSwap());
        }


        private static void NumberofWaysofCuttingaPizzaFunc()
        {
            Program.Space();
            Program.Title("Number of Ways of Cutting a Pizza");
            string source = "LC";
            
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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1444_1, 3),
                ResultTester.CheckResult<int>(result1444_2, 1),
                ResultTester.CheckResult<int>(result1444_3, 1)
            };
            ResultTester.CheckSolution(source, results);
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

            string source = "LC";
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1402_1, 14),
                ResultTester.CheckResult<int>(result1402_2, 20),
                ResultTester.CheckResult<int>(result1402_3, 0)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void DesignUndergroundSystemFunc()
        {
            Program.Space();
            Program.Title("Design Underground System");
            ResultTester.SpecialTestCase("LC");
        }


        private static void RemoveandReverseFunc()
        {
            Program.Space();
            Program.Title("Remove and Reverse");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void ShyGeek()
        {
            Program.Space();
            Program.Title("Shy Geek");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void NaryTreePreorderTraversalFunc()
        {
            Program.Space();
            Program.Title("N-ary Tree Preorder Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PermutationinStringFunc()
        {
            Program.Space();
            Program.Title("Permutation in String");
            ResultTester.CheckSolution ("LC", LeetCode.PermutationinString.Test.TestValidTriangleNumber());
        }


        private static void ReshapetheMatrixFunc()
        {
            Program.Space();
            Program.Title("Reshape the Matrix");
            ResultTester.CheckSolution("LC", LeetCode.ReshapetheMatrix.Test.TestReshapetheMatrix());
        }


        private static void ScrambleStringFunc()
        {
            Program.Space();
            Program.Title("Scramble String");
            ResultTester.CheckSolution("LC", LeetCode.ScrambleString.Test.TestScrambleString());
        }


        private static void BinarySearchFunc()
        {
            Program.Space();
            Program.Title("Binary Search");
            ResultTester.CheckSolution("LC", LeetCode.BinarySearch.Test.TestBinarySearch());
        }


        private static void InsertintoaBinarySearchTreeFunc()
        {
            Program.Space();
            Program.Title("Insert into a Binary Search Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SearchintoaBinarySearchTreeFunc()
        {
            Program.Space();
            Program.Title("Search in a Binary Search Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void KthLargestElementinaStreamFunc()
        {
            Program.Space();
            Program.Title("Kth Largest Element in a Stream");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SuccessfulPairsofSpellsandPotionsFunc()
        {
            Program.Space();
            Program.Title("Successful Pairs of Spells and Potions");
            string source = "LC";

            // Case 1
            int[] spells2300_1 = {5,1,3};
            int[] potions2300_1 = {1,2,3,4,5};
            long success2300_1 = 7;
            int[] result2300_1 = LeetCode.SuccessfulPairsofSpellsandPotions.Solution.SuccessfulPairs(spells2300_1, potions2300_1, success2300_1);

            // Case 2
            int[] spells2300_2 = {3,1,2};
            int[] potions2300_2 = {8,5,8};
            long success2300_2 = 16;
            int[] result2300_2 = LeetCode.SuccessfulPairsofSpellsandPotions.Solution.SuccessfulPairs(spells2300_2, potions2300_2, success2300_2);

            int[] output1_2300 = {4,0,3};
            int[] output2_2300 = {2,0,2};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result2300_1, output1_2300),
                ResultTester.CheckResult<int[]>(result2300_2, output2_2300)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void BoatstoSavePeopleFunc()
        {
            Program.Space();
            Program.Title("Boats to Save People");
            ResultTester.CheckSolution("LC", LeetCode.BoatstoSavePeople.Test.TestBoatstoSavePeople());
        }


        private static void Remainderondividingby11Func()
        {
            Program.Space();
            Program.Title("Remainder on dividing by 11");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.Remainderondividingby11.Test.TestRemainderondividingby11());
        }


        private static void MakeArrayElementsEqualFunc()
        {
            Program.Space();
            Program.Title("Make Array Elements Equal");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.MakeArrayElementsEqual.Test.TestMakeArrayElementsEqual());
        }


        private static void OptimalPartitionofStringFunc()
        {
            Program.Space();
            Program.Title("Optimal Partition of String");
            string source = "LC";

            // Case 1
            int Case1Result2405 = LeetCode.OptimalPartitionofString.Solution.PartitionString("abacaba");
            Console.WriteLine("Result 1 : {0}", Case1Result2405);

            // Case 2
            int Case2Result2405 = LeetCode.OptimalPartitionofString.Solution.PartitionString("ssssss");
            Console.WriteLine("Result 2 : {0}", Case2Result2405);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1Result2405, 4),
                ResultTester.CheckResult<int>(Case2Result2405, 6)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MinimumStepsRequiredFunc()
        {
            Program.Space();
            Program.Title("Minimum Steps Required");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Medium.MinimumStepsRequired.Test.TestMinimumStepsRequired());
        }


        private static void MinimizeMaximumofArrayFunc()
        {
            Program.Space();
            Program.Title("Minimize Maximum of Array");
            string source = "LC";

            // Case 1
            int[] nums2439_1 = {3,7,1,6};
            int result2439_1 = LeetCode.MinimizeMaximumofArray.Solution.MinimizeArrayValue(nums2439_1);
            Console.WriteLine("Result 1 : {0}", result2439_1);

            // Case 2
            int[] nums2439_2 = {10,1};
            int result2439_2 = LeetCode.MinimizeMaximumofArray.Solution.MinimizeArrayValue(nums2439_2);
            Console.WriteLine("Result 2 : {0}", result2439_2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result2439_1, result2439_1),
                ResultTester.CheckResult<int>(result2439_2, result2439_2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void EqualLeftandRightSubarraySumFunc()
        {
            Program.Space();
            Program.Title("Equal Left and Right Subarray Sum");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.EqualLeftandRightSubarraySum.Test.TestEqualLeftandRightSubarraySum());
        }


        private static void AddMinimumCharactersFunc()
        {
            Program.Space();
            Program.Title("Add Minimum Characters");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Medium.AddMinimumCharacters.Test.TestAddMinimumCharacters());
        }


        private static void NumberofGoodPathsFunc()
        {
            Program.Space();
            Program.Title("Number of Good Paths");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DominantPairsFunc()
        {
            Program.Space();
            Program.Title("Dominant Pairs");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void SpecialDigitsFunc()
        {
            Program.Space();
            Program.Title("Special Digits");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void DivideInIncrementialGroupsFunc()
        {
            Program.Space();
            Program.Title("Divide In Incremential Groups");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void NumberofEnclavesFunc()
        {
            Program.Space();
            Program.Title("Number of Enclaves");
            ResultTester.CheckSolution("LC", LeetCode.NumberofEnclaves.Test.TestNumberofEnclaves());
        }


        private static void RemoveStarsFunc()
        {
            Program.Space();
            Program.Title("Removing Stars From a String");
            string source = "LC";

            // Case 1
            string output2390_1 = LeetCode.RemovingStarsFromaString.Solution.RemoveStars("leet**cod*e");
            Console.WriteLine("Result 1 : {0}", output2390_1);

            // Case 2
            string output2390_2 = LeetCode.RemovingStarsFromaString.Solution.RemoveStars("erase*****");
            Console.WriteLine("Result 2 : {0}", output2390_2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(output2390_1, "lecoe"),
                ResultTester.CheckResult<string>(output2390_2, "")
            };
            ResultTester.CheckSolution(source, results);
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

            // Case 3
            int[][] Grid1254_3 = new int[][]
            {
                new int[]{0,0,1,0,0},
                new int[]{0,1,0,1,0},
                new int[]{0,1,1,1,0}
            };
            int result1254_3 = LeetCode.NumberofClosedIslands.Solution.ClosedIsland(Grid1254_3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1254_1, 2),
                ResultTester.CheckResult<int>(result1254_2, 2),
                ResultTester.CheckResult<int>(result1254_3, 1)
            };
            ResultTester.CheckSolution("LC", results);
        }


        private static void CheckIfNandItsDoubleExistFunc()
        {
            Program.Space();
            Program.Title("Check If N and Its Double Exist");
            string source = "LC";

            // Case 1
            int[] arr2346_1 = {10,2,5,3};
            bool result2346_1 = LeetCode.CheckIfNandItsDoubleExist.Solution.CheckIfExist(arr2346_1);
            
            // Case 2
            int[] arr2346_2 = {3,1,7,11};
            bool result2346_2 = LeetCode.CheckIfNandItsDoubleExist.Solution.CheckIfExist(arr2346_2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result2346_1, true),
                ResultTester.CheckResult<bool>(result2346_2, false)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MinimumReverseOperationsFunc()
        {
            Program.Space();
            Program.Title("Minimum Reverse Operations");
            string source = "LC";

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

            int[] output1_2612 = {0,-1,-1,1};
            int[] output2_2612 = {0,-1,-1,-1,-1};
            int[] output3_2612 = {-1,-1,0,-1};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result2612_1, output1_2612),
                ResultTester.CheckResult<int[]>(result2612_2, output2_2612),
                ResultTester.CheckResult<int[]>(result2612_3, output3_2612)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void LargestColorValueinaDirectedGraphFunc()
        {
            Program.Space();
            Program.Title("Largest Color Value in a Directed Graph");
            string source = "LC";

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

            // Case 2
            string colors1857_2 = "a";
            int[][] edges1857_2 = new int[][]
            {
                new int[]{0,0}
            };
            int result1857_2 = LeetCode.LargestColorValueinaDirectedGraph.Solution.LargestPathValue(colors1857_2, edges1857_2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1857_1, 3),
                ResultTester.CheckResult<int>(result1857_2, -1)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void SimplifyPathFunc()
        {
            Program.Space();
            Program.Title("Simplify Path");
            ResultTester.CheckSolution("LC", LeetCode.SimplifyPath.Test.TestSimplifyPath());
        }


        private static void MaximumLengthFunc()
        {
            Program.Space();
            Program.Title("Maximum Length");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Medium.MaximumLength.Test.TestMaximumLength());
        }


        private static void ValidateStackSequencesFunc()
        {
            Program.Space();
            Program.Title("Validate Stack Sequences");
            ResultTester.CheckSolution("LC", LeetCode.ValidateStackSequences.Test.TestValidateStackSequences());
        }


        private static void DeleteColumnstoMakeSortedFunc()
        {
            Program.Space();
            Program.Title("DeleteColumnstoMakeSorted");
            ResultTester.CheckSolution("LC", LeetCode.DeleteColumnstoMakeSorted.Test.TestDeleteColumnstoMakeSorted());
        }


        private static void LongestPalindromicSubsequenceFunc()
        {
            Program.Space();
            Program.Title("Longest Palindromic Subsequence");
            ResultTester.CheckSolution("LC", LeetCode.LongestPalindromicSubsequence.Test.TestLongestPalindromicSubsequence());
        }


        private static void MaximumValueofKCoinsFromPilesFunc()
        {
            Program.Space();
            Program.Title("Maximum Value of K Coins From Piles");
            string source = "LC";

            // Case 1
            int[][] piles1_2218 = new int[][]
            {
                new int[]{1,100,3},
                new int[]{7,8,9}
            };
            int k1_2218 = 2;
            int output1_2218 = LeetCode.MaximumValueofKCoinsFromPiles.Solution.MaxValueOfCoins(piles1_2218, k1_2218);


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


            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(output1_2218, 101),
                ResultTester.CheckResult<int>(output2_2218, 706)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void ConcatenationofArrayFunc()
        {
            Program.Space();
            Program.Title("Concatenation of Array");
            string source = "LC";

            // Case 1
            int[] nums1_1929 = {1,2,1};
            int[] output1_1929 = LeetCode.ConcatenationofArray.Solution.GetConcatenation(nums1_1929);

            // Case 2
            int[] nums2_1929 = {1,3,2,1};
            int[] output2_1929 = LeetCode.ConcatenationofArray.Solution.GetConcatenation(nums2_1929);

            int[] expected1 = {1,2,1,1,2,1};
            int[] expected2 = {1,3,2,1,1,3,2,1};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(output1_1929, expected1),
                ResultTester.CheckResult<int[]>(output2_1929, expected2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void NumberofWaystoFormaTargetStringGivenaDictionaryFunc()
        {
            Program.Space();
            Program.Title("Number of Ways to Form a Target String Given a Dictionary");
            string source = "LC";
            // Case 1
            string[] words1_1639 = {"acca","bbbb","caca"};
            string target1_1639 = "aba";
            int result1_1639 = LeetCode.NumberofWaystoFormaTargetStringGivenaDictionary.Solution.NumWays(words1_1639, target1_1639);

            // Case 2
            string[] words2_1639 = {"abba","baab"};
            string target2_1639 = "bab";
            int result2_1639 = LeetCode.NumberofWaystoFormaTargetStringGivenaDictionary.Solution.NumWays(words2_1639, target2_1639);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_1639, 6),
                ResultTester.CheckResult<int>(result2_1639, 4)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void BestTeamWithNoConflictsFunc()
        {
            Program.Space();
            Program.Title("Best Team With No Conflicts");
            string source = "LC";
            int[] scores1 = {1,3,5,10,15}; int[] ages1 = {1,2,3,4,5};
            int[] scores2 = {4,5,6,5}; int[] ages2 = {2,1,2,1};
            int[] scores3 = {1,2,3,5}; int[] ages3 = {8,9,10,1};
            int result1 = LeetCode.BestTeamWithNoConflicts.Solution.BestTeamScore(scores1, ages1);
            int result2 = LeetCode.BestTeamWithNoConflicts.Solution.BestTeamScore(scores1, ages1);
            int result3 = LeetCode.BestTeamWithNoConflicts.Solution.BestTeamScore(scores1, ages1);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, result1),
                ResultTester.CheckResult<int>(result2, result2),
                ResultTester.CheckResult<int>(result3, result3)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void KidsWiththeGreatestNumberofCandiesFunc()
        {
            Program.Space();
            Program.Title("Kids With the Greatest Number of Candies");
            string source = "LC";

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

            IList<bool> firstList = new List<bool> { true, false, false, false, false };
            IList<bool> secondList = new List<bool> { true, false, true };
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<bool>>(result1, firstList),
                ResultTester.CheckResult<IList<bool>>(result2, secondList)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MergeStringsAlternatelyFunc()
        {
            Program.Space();
            Program.Title("Merge Strings Alternately");
            string source = "LC";

            // Case 1
            string Case1_1768 = LeetCode.MergeStringsAlternately.Solution.MergeAlternately("abc", "pqr");
            Console.WriteLine("Result 1 : {0}", Case1_1768);

            // Case 2
            string Case2_1768 = LeetCode.MergeStringsAlternately.Solution.MergeAlternately("ab", "pqrs");
            Console.WriteLine("Result 2 : {0}", Case2_1768);

            // Case 3
            string Case3_1768 = LeetCode.MergeStringsAlternately.Solution.MergeAlternately("abcd", "pq");
            Console.WriteLine("Result 3 : {0}", Case3_1768);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Case1_1768, "apbqcr"),
                ResultTester.CheckResult<string>(Case2_1768, "apbqrs"),
                ResultTester.CheckResult<string>(Case3_1768, "apbqcd")
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void RomantoIntegerFunc()
        {
            Program.Space();
            Program.Title("Roman to Integer");
            ResultTester.CheckSolution("LC", LeetCode.RomantoInteger.Test.TestRomantoInteger());
        }


        private static void ProfitableSchemesFunc()
        {
            Program.Space();
            Program.Title("Profitable Schemes");
            ResultTester.CheckSolution("LC", LeetCode.ProfitableSchemes.Test.TestProfitableSchemes());
        }


        private static void MinimumInsertionStepstoMakeaStringPalindromeFunc()
        {
            Program.Space();
            Program.Title("Minimum Insertion Steps to Make a String Palindrome");

            // Case 1
            int Case1_1312 = LeetCode.MinimumInsertionStepstoMakeaStringPalindrome.Solution.MinInsertions("zzazz");

            // Case 2
            int Case2_1312 = LeetCode.MinimumInsertionStepstoMakeaStringPalindrome.Solution.MinInsertions("mbadm");

            // Case 3
            int Case3_1312 = LeetCode.MinimumInsertionStepstoMakeaStringPalindrome.Solution.MinInsertions("leetcode");
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_1312, 0),
                ResultTester.CheckResult<int>(Case2_1312, 2),
                ResultTester.CheckResult<int>(Case3_1312, 5)
            };
            ResultTester.CheckSolution("LC", results);
        }


        private static void BestPokerHandFunc()
        {
            Program.Space();
            Program.Title("Best Poker Hand");
            string source = "LC";

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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Case1_2347, "Flush"),
                ResultTester.CheckResult<string>(Case2_2347, "Three of a Kind"),
                ResultTester.CheckResult<string>(Case3_2347, "Pair")
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void SmallestNumberinInfiniteSetFunc()
        {
            Program.Space();
            Program.Title("Smallest Number in Infinite Set");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DeleteNodeinaBSTFunc()
        {
            Program.Space();
            Program.Title("Delete Node in a BST");
            ResultTester.SpecialTestCase("LC");
        }


        private static void AddTwoNumbersIIFunc()
        {
            Program.Space();
            Program.Title("Add Two Numbers II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void RestoreTheArrayFunc()
        {
            Program.Space();
            Program.Title("Restore The Array");
            string source = "LC";

            // Case 1
            int Case1_1416 = LeetCode.RestoreTheArray.Solution.NumberOfArrays("1000", 10000);
            Console.WriteLine("Result 1 : {0}", Case1_1416);

            // Case 2
            int Case2_1416 = LeetCode.RestoreTheArray.Solution.NumberOfArrays("1000", 10);
            Console.WriteLine("Result 2 : {0}", Case2_1416);

            // Case 3
            int Case3_1416 = LeetCode.RestoreTheArray.Solution.NumberOfArrays("1317", 200);
            Console.WriteLine("Result 3 : {0}", Case3_1416);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_1416, 1),
                ResultTester.CheckResult<int>(Case2_1416, 0),
                ResultTester.CheckResult<int>(Case3_1416, 6)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void LastStoneWeightFunc()
        {
            Program.Space();
            Program.Title("Last Stone Weight");
            ResultTester.CheckSolution("LC", LeetCode.LastStoneWeight.Test.TestLastStoneWeight());
        }


        private static void AddDigitsFunc()
        {
            Program.Space();
            Program.Title("Add Digits");
            ResultTester.CheckSolution("LC", LeetCode.AddDigits.Test.TestAddDigits());
        }


        private static void ValidAnagramFunc()
        {
            Program.Space();
            Program.Title("Valid Anagram");
            ResultTester.CheckSolution("LC", LeetCode.ValidAnagram.Test.TestValidAnagram());
        }


        private static void BulbSwitcherFunc()
        {
            Program.Space();
            Program.Title("Bulb Switcher");
            ResultTester.CheckSolution("LC", LeetCode.BulbSwitcher.Test.TestBulbSwitcher());
        }


        private static void FindtheDifferenceFunc()
        {
            Program.Space();
            Program.Title("Find the Difference");
            ResultTester.CheckSolution("LC", LeetCode.FindtheDifference.Test.TestFindtheDifference());
        }


        private static void RepeatedSubstringPatternFunc()
        {
            Program.Space();
            Program.Title("Repeated Substring Pattern");
            ResultTester.CheckSolution("LC", LeetCode.RepeatedSubstringPattern.Test.TestRepeatedSubstringPattern());
        }


        private static void MinimumNumberofArrowstoBurstBalloonsFunc()
        {
            Program.Space();
            Program.Title("Minimum Number of Arrows to Burst Balloons");
            ResultTester.CheckSolution("LC", LeetCode.MinimumNumberofArrowstoBurstBalloons.Test.TestMinimumNumberofArrowstoBurstBalloons());
        }


        private static void MoveZeroesFunc()
        {
            Program.Space();
            Program.Title("Move Zeroes");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FirstBadVersionFunc()
        {
            Program.Space();
            Program.Title("First Bad Version");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PlusOneFunc()
        {
            Program.Space();
            Program.Title("Plus One");
            ResultTester.CheckSolution("LC", LeetCode.PlusOne.Test.TestPlusOne());
        }


        private static void AverageSalaryExcludingtheMinimumandMaximumSalaryFunc()
        {
            Program.Space();
            Program.Title("Average Salary Excluding the Minimum and Maximum Salary");
            string source = "LC";

            // Case 1
            int[] salary1_1491 = {4000,3000,1000,2000};
            double result1_1491 = LeetCode.AverageSalaryExcludingtheMinimumandMaximumSalary.Solution.Average(salary1_1491);

            // Case 2
            int[] salary2_1491 = {1000,2000,3000};
            double result2_1491 = LeetCode.AverageSalaryExcludingtheMinimumandMaximumSalary.Solution.Average(salary2_1491);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double>(result1_1491, 2500.00000),
                ResultTester.CheckResult<double>(result2_1491, 2000.00000),
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void NonoverlappingIntervalsFunc()
        {
            Program.Space();
            Program.Title("Non-overlapping Intervals");
            ResultTester.CheckSolution("LC", LeetCode.NonoverlappingIntervals.Test.TestNonoverlappingIntervals());
        }


        private static void SignoftheProductofanArrayFunc()
        {
            Program.Space();
            Program.Title("Sign of the Product of an Array");
            string source = "LC";

            // Case 1
            int[] Case1_1822 = {-1,-2,-3,-4,3,2,1};
            int Result1_1822 = LeetCode.SignoftheProductofanArray.Solution.ArraySign(Case1_1822);

            // Case 2
            int[] Case2_1822 = {1,5,0,2,-3};
            int Result2_1822 = LeetCode.SignoftheProductofanArray.Solution.ArraySign(Case2_1822);

            // Case 3
            int[] Case3_1822 = {-1,1,-1,1,-1};
            int Result3_1822 = LeetCode.SignoftheProductofanArray.Solution.ArraySign(Case3_1822);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Result1_1822, 1),
                ResultTester.CheckResult<int>(Result2_1822, 0),
                ResultTester.CheckResult<int>(Result3_1822, -1)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void CanMakeArithmeticProgressionFunc()
        {
            Program.Space();
            Program.Title("Can Make Arithmetic Progression From Sequence");
            string source = "LC";

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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Result1_1502, false),
                ResultTester.CheckResult<bool>(Result2_1502, false),
                ResultTester.CheckResult<bool>(Result3_1502, Result3_1502),
                ResultTester.CheckResult<bool>(Result4_1502, Result4_1502),
                ResultTester.CheckResult<bool>(Result5_1502, Result5_1502),
                ResultTester.CheckResult<bool>(Result6_1502, Result6_1502),
                ResultTester.CheckResult<bool>(Result7_1502, Result7_1502)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MonotonicArrayFunc()
        {
            Program.Space();
            Program.Title("Monotonic Array");
            ResultTester.CheckSolution("LC", LeetCode.MonotonicArray.Test.TestMonotonicArray());
        }


        private static void LengthofLastWordFunc()
        {
            Program.Space();
            Program.Title("Length of Last Word");
            ResultTester.CheckSolution("LC", LeetCode.LengthofLastWord.Test.TestLengthofLastWord());
        }


        private static void ToLowerCaseFunc()
        {
            Program.Space();
            Program.Title("To Lower Case");
            ResultTester.CheckSolution("LC", LeetCode.ToLowerCase.Test.TestToLowerCase());
        }


        private static void FindSmallestLetterGreaterThanTargetFunc()
        {
            Program.Space();
            Program.Title("Find Smallest Letter Greater Than Target");
            ResultTester.CheckSolution("LC", LeetCode.FindSmallestLetterGreaterThanTarget.Test.TestFindSmallestLetterGreaterThanTarget());
        }


        private static void CountNegativeNumbersinaSortedMatrixFunc()
        {
            Program.Space();
            Program.Title("Count Negative Numbers in a Sorted Matrix");
            string source = "LC";

            // Case 1
            int[][] grid1_1351 = new int[][]
            {
                new int[] { 4,3,2,-1 },
                new int[] { 3,2,1,-1 },
                new int[] { 1,1,-1,-2 },
                new int[] { -1,-1,-2,-3 }
            };
            int result1_1351 = LeetCode.CountNegativeNumbersinaSortedMatrix.Solution.CountNegatives(grid1_1351);

            // Case 2
            int[][] grid2_1351 = new int[][]
            {
                new int[] { 3,2 },
                new int[] { 1,0 }
            };
            int result2_1351 = LeetCode.CountNegativeNumbersinaSortedMatrix.Solution.CountNegatives(grid2_1351);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_1351, 8),
                ResultTester.CheckResult<int>(result2_1351, 0)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void ValidPerfectSquareFunc()
        {
            Program.Space();
            Program.Title("Valid Perfect Square");
            ResultTester.CheckSolution("LC", LeetCode.ValidPerfectSquare.Test.TestValidPerfectSquare());
        }


        private static void ArrangingCoinsFunc()
        {
            Program.Space();
            Program.Title("Arranging Coins");
            ResultTester.CheckSolution("LC", LeetCode.ArrangingCoins.Test.TestArrangingCoins());
        }


        private static void BaseballGameFunc()
        {
            Program.Space();
            Program.Title("Baseball Game");
            ResultTester.CheckSolution("LC", LeetCode.BaseballGame.Test.TestBaseballGame());
        }


        private static void FindAllAnagramsinaStringFunc()
        {
            Program.Space();
            Program.Title("Find All Anagrams in a String");
            ResultTester.CheckSolution("LC", LeetCode.FindAllAnagramsinaString.Test.TestFindAllAnagramsinaString());
        }


        private static void PathSumIIIFunc()
        {
            Program.Space();
            Program.Title("Path Sum III");
            ResultTester.SpecialTestCase("LC");
        }


        private static void RobotReturntoOriginFunc()
        {
            Program.Space();
            Program.Title("Robot Return to Origin");
            ResultTester.CheckSolution("LC", LeetCode.RobotReturntoOrigin.Test.TestRobotReturntoOrigin());
        }


        private static void TwoSumIVInputisaBSTFunc()
        {
            Program.Space();
            Program.Title("Two Sum IV - Input is a BST");
            ResultTester.SpecialTestCase("LC");
        }


        private static void TwoSumFunc()
        {
            Program.Space();
            Program.Title("Two Sum");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FindDuplicateSubtreesFunc()
        {
            Program.Space();
            Program.Title("Find Duplicate Subtrees");
            ResultTester.SpecialTestCase("LC");
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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(result1_1275, "A"),
                ResultTester.CheckResult<string>(result2_1275, "B"),
                ResultTester.CheckResult<string>(result3_1275, "Draw")
            };
            ResultTester.CheckSolution("LC", results);
        }


        private static void RobotBoundedInCircleFunc()
        {
            Program.Space();
            Program.Title("Robot Bounded In Circle");
            ResultTester.CheckSolution("LC", LeetCode.RobotBoundedInCircle.Test.TestRobotBoundedInCircle());
        }


        private static void UncrossedLinesFunc()
        {
            Program.Space();
            Program.Title("Uncrossed Lines");
            ResultTester.CheckSolution("LC", LeetCode.UncrossedLines.Test.TestUncrossedLines());
        }


        private static void MatrixDiagonalSumFunc()
        {
            Program.Space();
            Program.Title("Matrix Diagonal Sum");
            string source = "LC";

            // Case 1
            int[][] grid1_1572 = new int[][]
            {
                new int[] { 1,2,3 },
                new int[] { 4,5,6 },
                new int[] { 7,8,9 }
            };
            int result1 = LeetCode.MatrixDiagonalSum.Solution.DiagonalSum(grid1_1572);

            // Case 2
            int[][] grid2_1572 = new int[][]
            {
                new int[] { 1,1,1,1 },
                new int[] { 1,1,1,1 },
                new int[] { 1,1,1,1 },
                new int[] { 1,1,1,1 }
            };
            int result2 = LeetCode.MatrixDiagonalSum.Solution.DiagonalSum(grid2_1572);

            // Case 3
            int[][] grid3_1572 = new int[][]
            {
                new int[] { 5 }
            };
            int result3 = LeetCode.MatrixDiagonalSum.Solution.DiagonalSum(grid3_1572);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 25),
                ResultTester.CheckResult<int>(result2, 8),
                ResultTester.CheckResult<int>(result3, 5)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void LemonadeChangeFunc()
        {
            Program.Space();
            Program.Title("Lemonade Change");
            ResultTester.CheckSolution("LC", LeetCode.LemonadeChange.Test.TestLemonadeChange());
        }


        private static void LargestPerimeterTriangleFunc()
        {
            Program.Space();
            Program.Title("Largest Perimeter Triangle");
            ResultTester.CheckSolution("LC", LeetCode.LargestPerimeterTriangle.Test.TestLargestPerimeterTriangle());
        }


        private static void SubarraySumsDivisiblebyKFunc()
        {
            Program.Space();
            Program.Title("Subarray Sums Divisible by K");
            ResultTester.CheckSolution("LC", LeetCode.SubarraySumsDivisiblebyK.Test.TestSubarraySumsDivisiblebyK());
        }


        private static void CheckCompletenessofaBinaryTreeFunc()
        {
            Program.Space();
            Program.Title("Check Completeness of a Binary Tree");
            ResultTester.SpecialTestCase("LC");
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
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, true),
                ResultTester.CheckResult<bool>(result2, false)
            };
            ResultTester.CheckSolution("LC", results);
        }


        private static void MultiplyStringsFunc()
        {
            Program.Space();
            Program.Title("Multiply Strings");
            ResultTester.CheckSolution("LC", LeetCode.MultiplyStrings.Test.TestMultiplyStrings());
        }


        private static void PowxnFunc()
        {
            Program.Space();
            Program.Title("Pow(x, n)");
            ResultTester.CheckSolution("LC", LeetCode.Powxn.Test.TestPowxn());
        }


        private static void ReverseVowelsofaStringFunc()
        {
            Program.Space();
            Program.Title("Reverse Vowels of a String");
            ResultTester.CheckSolution("LC", LeetCode.ReverseVowelsofaString.Test.TestReverseVowelsofaString());
        }


        private static void ReverseStringFunc()
        {
            Program.Space();
            Program.Title("Reverse String");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ReverseWordsinaStringFunc()
        {
            Program.Space();
            Program.Title("Reverse Words in a String");
            ResultTester.CheckSolution("LC", LeetCode.ReverseWordsinaString.Test.TestReverseWordsinaString());
        }


        private static void EvaluateReversePolishNotationFunc()
        {
            Program.Space();
            Program.Title("Evaluate Reverse Polish Notation");
            ResultTester.CheckSolution("LC", LeetCode.EvaluateReversePolishNotation.Test.TestEvaluateReversePolishNotation());
        }


        private static void ProductofArrayExceptSelfFunc()
        {
            Program.Space();
            Program.Title("Product of Array Except Self");
            ResultTester.CheckSolution("LC", LeetCode.ProductofArrayExceptSelf.Test.TestProductofArrayExceptSelf());
        }


        private static void Dota2SenateFunc()
        {
            Program.Space();
            Program.Title("Dota2 Senate");
            ResultTester.CheckSolution("LC", LeetCode.Dota2Senate.Test.TestDota2Senate());
        }


        private static void MinimumFlipstoMakeaORbEqualtocFunc()
        {
            Program.Space();
            Program.Title("Minimum Flips to Make a OR b Equal to c");

            int result1 = LeetCode.MinimumFlipstoMakeaORbEqualtoc.Solution.MinFlips(2,6,5);
            int result2 = LeetCode.MinimumFlipstoMakeaORbEqualtoc.Solution.MinFlips(4,2,7);
            int result3 = LeetCode.MinimumFlipstoMakeaORbEqualtoc.Solution.MinFlips(1,2,3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 1),
                ResultTester.CheckResult<int>(result3, 0)
            };
            ResultTester.CheckSolution("LC", results);
        }


        private static void CountingBitsFunc()
        {
            Program.Space();
            Program.Title("Counting Bits");
            ResultTester.CheckSolution("LC", LeetCode.CountingBits.Test.TestCountingBits());
        }


        private static void BestTimetoBuyandSellStockwithTransactionFeeFunc()
        {
            Program.Space();
            Program.Title("Best Time to Buy and Sell Stock with Transaction Fee");
            ResultTester.CheckSolution("LC", LeetCode.BestTimetoBuyandSellStockwithTransactionFee.Test.TestBestTimetoBuyandSellStockwithTransactionFee());
        }


        private static void IncreasingTripletSubsequenceFunc()
        {
            Program.Space();
            Program.Title("Increasing Triplet Subsequence");
            ResultTester.CheckSolution("LC", LeetCode.IncreasingTripletSubsequence.Test.TestIncreasingTripletSubsequence());
        }


        private static void IsSubsequenceFunc()
        {
            Program.Space();
            Program.Title("Is Subsequence");
            ResultTester.CheckSolution("LC", LeetCode.IsSubsequence.Test.TestIsSubsequence());
        }


        private static void MaximumNumberofVowelsinaSubstringofGivenLengthFunc()
        {
            Program.Space();
            Program.Title("Maximum Number of Vowels in a Substring of Given Length");
            string source = "LC";

            int result1 = LeetCode.MaximumNumberofVowelsinaSubstringofGivenLength.Solution.MaxVowels("abciiidef", 3);
            int result2 = LeetCode.MaximumNumberofVowelsinaSubstringofGivenLength.Solution.MaxVowels("aeiou", 2);
            int result3 = LeetCode.MaximumNumberofVowelsinaSubstringofGivenLength.Solution.MaxVowels("leetcode", 3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 2),
                ResultTester.CheckResult<int>(result3, 2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void DominoandTrominoTilingFunc()
        {
            Program.Space();
            Program.Title("Domino and Tromino Tiling");
            ResultTester.CheckSolution("LC", LeetCode.DominoandTrominoTiling.Test.TestDominoandTrominoTiling());
        }


        private static void MinCostClimbingStairsFunc()
        {
            Program.Space();
            Program.Title("Min Cost Climbing Stairs");
            ResultTester.CheckSolution("LC", LeetCode.MinCostClimbingStairs.Test.TestMinCostClimbingStairs());    
        }


        private static void ContainerWithMostWaterFunc()
        {
            Program.Space();
            Program.Title("Container With Most Water");
            ResultTester.CheckSolution("LC", LeetCode.ContainerWithMostWater.Test.TestContainerWithMostWater());    
        }


        private static void MaxNumberofKSumPairsFunc()
        {
            Program.Space();
            Program.Title("Max Number of K-Sum Pairs");
            string source = "LC";

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

            int output1 = 2;
            int output2 = 1;
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1),
                ResultTester.CheckResult<int>(result2, output2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MaximumAverageSubarrayIFunc()
        {
            Program.Space();
            Program.Title("Maximum Average Subarray I");
            ResultTester.CheckSolution("LC", LeetCode.MaximumAverageSubarrayI.Test.TestMaximumAverageSubarrayI());
        }


        private static void UniquePathsFunc()
        {
            Program.Space();
            Program.Title("Unique Paths");
            ResultTester.CheckSolution("LC", LeetCode.UniquePaths.Test.TestUniquePaths());
        }


        private static void MaxConsecutiveOnesIIIFunc()
        {
            Program.Space();
            Program.Title("Max Consecutive Ones III");
            ResultTester.CheckSolution("LC", LeetCode.MaxConsecutiveOnesIII.Test.TestMaxConsecutiveOnesIII());
        }


        private static void LongestSubarrayof1sAfterDeletingOneElementFunc()
        {
            Program.Space();
            Program.Title("Longest Subarray of 1's After Deleting One Element");
            string source = "LC";

            int[] nums1 = {1,1,0,1};
            int[] nums2 = {0,1,1,1,0,1,1,0,1};
            int[] nums3 = {1,1,1};

            int result1 = LeetCode.LongestSubarrayof1sAfterDeletingOneElement.Solution.LongestSubarray(nums1);
            int result2 = LeetCode.LongestSubarrayof1sAfterDeletingOneElement.Solution.LongestSubarray(nums2);
            int result3 = LeetCode.LongestSubarrayof1sAfterDeletingOneElement.Solution.LongestSubarray(nums3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 5),
                ResultTester.CheckResult<int>(result3, 2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void FindtheHighestAltitudeFunc()
        {
            Program.Space();
            Program.Title("Find the Highest Altitude");
            string source = "LC";

            int[] gain1 = {-5,1,5,0,-7};
            int[] gain2 = {-4,-3,-2,-1,4,3,2};

            int result1 = LeetCode.FindtheHighestAltitude.Solution.LargestAltitude(gain1);
            int result2 = LeetCode.FindtheHighestAltitude.Solution.LargestAltitude(gain2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 1),
                ResultTester.CheckResult<int>(result2, 0)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void FindPivotIndexFunc()
        {
            Program.Space();
            Program.Title("Find Pivot Index");
            ResultTester.CheckSolution("LC", LeetCode.FindPivotIndex.Test.TestFindPivotIndex());
        }


        private static void NumberofProvincesFunc()
        {
            Program.Space();
            Program.Title("Number of Provinces");
            ResultTester.CheckSolution("LC", LeetCode.NumberofProvinces.Test.TestNumberofProvinces());
        }


        private static void NumberofSubsequencesThatSatisfytheGivenSumConditionFunc()
        {
            Program.Space();
            Program.Title("Number of Subsequences That Satisfy the Given Sum Condition");
            string source = "LC";

            int[] nums1 = {3,5,6,7};
            int target1 = 9;
            int[] nums2 = {3,3,6,8};
            int target2 = 10;
            int[] nums3 = {2,3,3,4,6,7};
            int target3 = 12;

            int result1 = LeetCode.NumberofSubsequencesThatSatisfytheGivenSumCondition.Solution.NumSubseq(nums1, target1);
            int result2 = LeetCode.NumberofSubsequencesThatSatisfytheGivenSumCondition.Solution.NumSubseq(nums2, target2);
            int result3 = LeetCode.NumberofSubsequencesThatSatisfytheGivenSumCondition.Solution.NumSubseq(nums3, target3);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 4),
                ResultTester.CheckResult<int>(result2, 6),
                ResultTester.CheckResult<int>(result3, 61)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void FindtheLongestValidObstacleCourseatEachPositionFunc()
        {
            Program.Space();
            Program.Title("Number of Subsequences That Satisfy the Given Sum Condition");
            string source = "LC";

            int[] obstacles1 = {1,2,3,2};
            int[] obstacles2 = {2,2,1};
            int[] obstacles3 = {3,1,5,6,4,2};
            int[] result1 = LeetCode.FindtheLongestValidObstacleCourseatEachPosition.Solution.LongestObstacleCourseAtEachPosition(obstacles1);
            int[] result2 = LeetCode.FindtheLongestValidObstacleCourseatEachPosition.Solution.LongestObstacleCourseAtEachPosition(obstacles2);
            int[] result3 = LeetCode.FindtheLongestValidObstacleCourseatEachPosition.Solution.LongestObstacleCourseAtEachPosition(obstacles3);
            int[] output1 = {1,2,3,3};
            int[] output2 = {1,2,1};
            int[] output3 = {1,1,2,3,2,2};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, output1),
                ResultTester.CheckResult<int[]>(result2, output2),
                ResultTester.CheckResult<int[]>(result3, output3)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void AsteroidCollisionFunc()
        {
            Program.Space();
            Program.Title("Asteroid Collision");
            ResultTester.CheckSolution("LC", LeetCode.AsteroidCollision.Test.TestAsteroidCollision());
        }


        private static void FindPeakElementFunc()
        {
            Program.Space();
            Program.Title("Find Peak Element");
            ResultTester.CheckSolution("LC", LeetCode.FindPeakElement.Test.TestFindPeakElement());
        }


        private static void AccessingcharactersofaStringFunc()
        {
            Program.Space();
            Program.Title("Accessing characters of a String");
            ResultTester.CheckSolution("CC", CodeChef.AccessingcharactersofaString.Test.TestAccessingcharactersofaString());
        }


        private static void MaximizeScoreAfterNOperationsFunc()
        {
            Program.Space();
            Program.Title("Maximize Score After N Operations");
            string source = "LC";

            int[] case1_1799 = {1,2};
            int[] case2_1799 = {3,4,6,8};
            int[] case3_1799 = {1,2,3,4,5,6};

            int result1 = LeetCode.MaximizeScoreAfterNOperations.Solution.MaxScore(case1_1799);
            int result2 = LeetCode.MaximizeScoreAfterNOperations.Solution.MaxScore(case2_1799);
            int result3 = LeetCode.MaximizeScoreAfterNOperations.Solution.MaxScore(case3_1799);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 1),
                ResultTester.CheckResult<int>(result2, 11),
                ResultTester.CheckResult<int>(result3, 14)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void WateringPlantsIIFunc()
        {
            Program.Space();
            Program.Title("Watering Plants II");
            string source = "LC";

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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 1),
                ResultTester.CheckResult<int>(result2, 2),
                ResultTester.CheckResult<int>(result3, 0)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void CarPoolingFunc()
        {
            Program.Space();
            Program.Title("Car Pooling");
            ResultTester.CheckSolution("LC", LeetCode.CarPooling.Test.TestCarPooling());
        }


        private static void GreatestCommonDivisorofStringsFunc()
        {
            Program.Space();
            Program.Title("Greatest Common Divisor of Strings");
            ResultTester.CheckSolution("LC", LeetCode.GreatestCommonDivisorofStrings.Test.TestGreatestCommonDivisorofStrings());
        }


        private static void ShortestPathinBinaryMatrixFunc()
        {
            Program.Space();
            Program.Title("Shortest Path in Binary Matrix");
            ResultTester.CheckSolution("LC", LeetCode.ShortestPathinBinaryMatrix.Test.TestShortestPathinBinaryMatrix());
        }


        private static void CountWaysToBuildGoodStringsFunc()
        {
            Program.Space();
            Program.Title("Count Ways To Build Good Strings");
            string source = "LC";

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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 8),
                ResultTester.CheckResult<int>(result2, 8)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void TotalCosttoHireKWorkersFunc()
        {
            Program.Space();
            Program.Title("Total Cost to Hire K Workers");
            string source = "LC";

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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(result1, 11),
                ResultTester.CheckResult<long>(result2, 4)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MaximumSubsequenceScoreFunc()
        {
            Program.Space();
            Program.Title("Maximum Subsequence Score");
            string source = "LC";

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

            long output1 = 12;
            long output2 = 30;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(result1, output1),
                ResultTester.CheckResult<long>(result2, output2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void KthLargestElementinanArrayFunc()
        {
            Program.Space();
            Program.Title("Kth Largest Element in an Array");
            ResultTester.CheckSolution("LC", LeetCode.KthLargestElementinanArray.Test.TestKthLargestElementinanArray());
        }

        
        private static void EqualRowandColumnPairsFunc()
        {
            Program.Space();
            Program.Title("Equal Row and Column Pairs");
            string source = "LC";

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

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 1),
                ResultTester.CheckResult<int>(result2, 3)
            };
            ResultTester.CheckSolution(source, results);
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

            bool result1 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case1);
            bool result2 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case2);
            bool result3 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case3);
            bool result4 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case4);
            bool result5 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case5);
            bool result6 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case6);
            bool result7 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case7);
            bool result8 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case8);
            bool result9 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case9);
            bool result10 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case10);
            bool result11 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case11);
            bool result12 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case12);
            bool result13 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case13);
            bool result14 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case14);
            bool result15 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case15);
            bool result16 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case16);
            bool result17 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case17);
            bool result18 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case18);
            bool result19 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case19);
            bool result20 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case20);
            bool result21 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case21);
            bool result22 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case22);
            bool result23 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case23);
            bool result24 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case24);
            bool result25 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case25);
            bool result26 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case26);
            bool result27 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case27);
            bool result28 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case28);
            bool result29 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case29);
            bool result30 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case30);
            bool result31 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case31);
            bool result32 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case32);
            bool result33 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case33);
            bool result34 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case34);
            bool result35 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case35);
            bool result36 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case36);
            bool result37 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case37);
            bool result38 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case38);
            bool result39 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case39);
            bool result40 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case40);
            bool result41 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case41);
            bool result42 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case42);
            bool result43 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case43);
            bool result44 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case44);
            bool result45 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case45);
            bool result46 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case46);
            bool result47 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case47);
            bool result48 = LeetCode.UniqueNumberofOccurrences.Solution.UniqueOccurrences(Case48);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, result1),
                ResultTester.CheckResult<bool>(result2, result2),
                ResultTester.CheckResult<bool>(result3, result3),
                ResultTester.CheckResult<bool>(result4, result4),
                ResultTester.CheckResult<bool>(result5, result5),
                ResultTester.CheckResult<bool>(result6, result6),
                ResultTester.CheckResult<bool>(result7, result7),
                ResultTester.CheckResult<bool>(result8, result8),
                ResultTester.CheckResult<bool>(result9, result9),
                ResultTester.CheckResult<bool>(result10, result10),
                ResultTester.CheckResult<bool>(result11, result11),
                ResultTester.CheckResult<bool>(result12, result12),
                ResultTester.CheckResult<bool>(result13, result13),
                ResultTester.CheckResult<bool>(result14, result14),
                ResultTester.CheckResult<bool>(result15, result15),
                ResultTester.CheckResult<bool>(result16, result16),
                ResultTester.CheckResult<bool>(result17, result17),
                ResultTester.CheckResult<bool>(result18, result18),
                ResultTester.CheckResult<bool>(result19, result19),
                ResultTester.CheckResult<bool>(result20, result20),
                ResultTester.CheckResult<bool>(result21, result21),
                ResultTester.CheckResult<bool>(result22, result22),
                ResultTester.CheckResult<bool>(result23, result23),
                ResultTester.CheckResult<bool>(result24, result24),
                ResultTester.CheckResult<bool>(result25, result25),
                ResultTester.CheckResult<bool>(result26, result26),
                ResultTester.CheckResult<bool>(result27, result27),
                ResultTester.CheckResult<bool>(result28, result28),
                ResultTester.CheckResult<bool>(result29, result29),
                ResultTester.CheckResult<bool>(result30, result30),
                ResultTester.CheckResult<bool>(result31, result31),
                ResultTester.CheckResult<bool>(result32, result32),
                ResultTester.CheckResult<bool>(result33, result33),
                ResultTester.CheckResult<bool>(result34, result34),
                ResultTester.CheckResult<bool>(result35, result35),
                ResultTester.CheckResult<bool>(result36, result36),
                ResultTester.CheckResult<bool>(result37, result37),
                ResultTester.CheckResult<bool>(result38, result38),
                ResultTester.CheckResult<bool>(result39, result39),
                ResultTester.CheckResult<bool>(result40, result40),
                ResultTester.CheckResult<bool>(result41, result41),
                ResultTester.CheckResult<bool>(result42, result42),
                ResultTester.CheckResult<bool>(result43, result43),
                ResultTester.CheckResult<bool>(result44, result44),
                ResultTester.CheckResult<bool>(result45, result45),
                ResultTester.CheckResult<bool>(result46, result46),
                ResultTester.CheckResult<bool>(result47, result47),
                ResultTester.CheckResult<bool>(result48, result48),
                
            };
            ResultTester.CheckSolution("LC", results);
        }


        private static void DetermineifTwoStringsAreCloseFunc()
        {
            Program.Space();
            Program.Title("Determine if Two Strings Are Close");
            string source = "LC";

            string word1_1 = "abc";
            string word2_1 = "bca";
            string word1_2 = "a";
            string word2_2 = "aa";
            string word1_3 = "cabbba";
            string word2_3 = "abbccc";

            bool result1 = LeetCode.DetermineifTwoStringsAreClose.Solution.CloseStrings(word1_1, word2_1);
            bool result2 = LeetCode.DetermineifTwoStringsAreClose.Solution.CloseStrings(word1_2, word2_2);
            bool result3 = LeetCode.DetermineifTwoStringsAreClose.Solution.CloseStrings(word1_3, word2_3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, true),
                ResultTester.CheckResult<bool>(result2, false),
                ResultTester.CheckResult<bool>(result3, true)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void IsGraphBipartiteFunc()
        {
            Program.Space();
            Program.Title("Is Graph Bipartite");
            ResultTester.CheckSolution("LC", LeetCode.IsGraphBipartite.Test.TestIsGraphBipartite());
        }


        private static void LetterCasePermutationFunc()
        {
            Program.Space();
            Program.Title("Letter Case Permutation");
            ResultTester.CheckSolution("LC", LeetCode.LetterCasePermutation.Test.TestLetterCasePermutation());
        }

        
        private static void MinimumDistanceBetweenBSTNodesFunc()
        {
            Program.Space();
            Program.Title("Minimum Distance Between BST Nodes");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaxPointsonaLineFunc()
        {
            Program.Space();
            Program.Title("Max Points on a Line");
            ResultTester.SpecialTestCase("LC");
        }


        private static void BinaryTreePostorderTraversalFunc()
        {
            Program.Space();
            Program.Title("Binary Tree Level Order Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void LowestCommonAncestorofaBinaryTreeFunc()
        {
            Program.Space();
            Program.Title("Lowest Common Ancestor of a Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void OddEvenLinkedListFunc()
        {
            Program.Space();
            Program.Title("Odd Even Linked List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void LowestCommonAncestorofaBinarySearchTreeFunc()
        {
            Program.Space();
            Program.Title("Lowest Common Ancestor of a Binary Search Tree");
            ResultTester.SpecialTestCase("LC");
        }

        
        private static void HouseRobberFunc()
        {
            Program.Space();
            Program.Title("House Robber");
            ResultTester.SpecialTestCase("LC");
        }


        private static void HouseRobberIIIFunc()
        {
            Program.Space();
            Program.Title("House Robber III");
            ResultTester.SpecialTestCase("LC");
        }


        private static void HouseRobberIIFunc()
        {
            Program.Space();
            Program.Title("House Robber II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DesignAddandSearchWordsDataStructureFunc()
        {
            Program.Space();
            Program.Title("Design Add and Search Words Data Structure");
            ResultTester.SpecialTestCase("LC");
        }


        private static void NextPermutationFunc()
        {
            Program.Space();
            Program.Title("Next Permutation");
            ResultTester.CheckSolution("LC", LeetCode.NextPermutation.Test.TestNextPermutation());
        }


        private static void ShortestBridgeFunc()
        {
            Program.Space();
            Program.Title("Shortest Bridge");
            ResultTester.CheckSolution("LC", LeetCode.ShortestBridge.Test.TestShortestBridge());
        }


        private static void NumberofRecentCallsFunc()
        {
            Program.Space();
            Program.Title("Number of Recent Calls");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PeekingIteratorFunc()
        {
            Program.Space();
            Program.Title("Peeking Iterator");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FindtheDuplicateNumberFunc()
        {
            Program.Space();
            Program.Title("Find the Duplicate Number");
            ResultTester.CheckSolution("LC", LeetCode.FindtheDuplicateNumber.Test.TestFindtheDuplicateNumber());
        }


        private static void New21GameFunc()
        {
            Program.Space();
            Program.Title("New 21 Game");
            ResultTester.CheckSolution("LC", LeetCode.New21Game.Test.TestNew21Game());
        }


        private static void FindMinimuminRotatedSortedArrayFunc()
        {
            Program.Space();
            Program.Title("Find Minimum in Rotated Sorted Array");
            ResultTester.CheckSolution("LC", LeetCode.FindMinimuminRotatedSortedArray.Test.TestFindMinimuminRotatedSortedArray());
        }


        private static void StoneGameIIFunc()
        {
            Program.Space();
            Program.Title("Stone Game II");
            ResultTester.CheckSolution("LC", LeetCode.StoneGameII.Solution.TestStoneGameII());
        }


        private static void PermutationsFunc()
        {
            Program.Space();
            Program.Title("Permutations");
            ResultTester.CheckSolution("LC", LeetCode.Permutations.Test.TestPermutations());
        }


        private static void PermutationsIIFunc()
        {
            Program.Space();
            Program.Title("Permutations II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ReverseLinkedListFunc()
        {
            Program.Space();
            Program.Title("Reverse Linked List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void IsomorphicStringsFunc()
        {
            Program.Space();
            Program.Title("Isomorphic Strings");
            ResultTester.SpecialTestCase("LC");
        }


        private static void RemoveLinkedListElementsFunc()
        {
            Program.Space();
            Program.Title("Remove Linked List Elements");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CourseScheduleFunc()
        {
            Program.Space();
            Program.Title("Course Schedule");
            ResultTester.CheckSolution("LC", LeetCode.CourseSchedule.Test.TestCourseSchedule());
        }


        private static void StoneGameIIIFunc()
        {
            Program.Space();
            Program.Title("Stone Game III");
            string source = "LC";

            int[] nums1 = {1,2,3,7};
            int[] nums2 = {1,2,3,-9};
            int[] nums3 = {1,2,3,6};

            string result1 = LeetCode.StoneGameIII.Solution.StoneGameIII(nums1);
            string result2 = LeetCode.StoneGameIII.Solution.StoneGameIII(nums2);
            string result3 = LeetCode.StoneGameIII.Solution.StoneGameIII(nums3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(result1, "Bob"),
                ResultTester.CheckResult<string>(result2, "Alice"),
                ResultTester.CheckResult<string>(result3, "Tie")
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MinimumCosttoCutaStickFunc()
        {
            Program.Space();
            Program.Title("Minimum Cost to Cut a Stick");
            string source = "LC";

            int n1 = 7;
            int[] cuts1 = {1,3,4,5};
            int n2 = 9;
            int[] cuts2 = {5,6,1,4,2};

            int result1 = LeetCode.MinimumCosttoCutaStick.Solution.MinCost(n1, cuts1);
            int result2 = LeetCode.MinimumCosttoCutaStick.Solution.MinCost(n2, cuts2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 16),
                ResultTester.CheckResult<int>(result2, 22),
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MajorityElementFunc()
        {
            Program.Space();
            Program.Title("Majority Element");
            ResultTester.CheckSolution("LC", LeetCode.MajorityElement.Test.TestMajorityElement());
        }


        private static void GoalParserInterpretationFunc()
        {
            Program.Space();
            Program.Title("Goal Parser Interpretation");
            string source = "LC";

            string command1 = "G()(al)";
            string command2 = "G()()()()(al)";
            string command3 = "(al)G(al)()()G";

            string result1 = LeetCode.GoalParserInterpretation.Solution.Interpret(command1);
            string result2 = LeetCode.GoalParserInterpretation.Solution.Interpret(command2);
            string result3 = LeetCode.GoalParserInterpretation.Solution.Interpret(command3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(result1, "Goal"),
                ResultTester.CheckResult<string>(result2, "Gooooal"),
                ResultTester.CheckResult<string>(result3, "alGalooG")
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void FloodFillFunc()
        {
            Program.Space();
            Program.Title("Flood Fill");
            ResultTester.CheckSolution("LC", LeetCode.FloodFill.Test.TestFloodFill());
        }


        private static void HappyNumberFunc()
        {
            Program.Space();
            Program.Title("Happy Number");
            ResultTester.CheckSolution("LC", LeetCode.HappyNumber.Test.TestHappyNumber());
        }


        private static void DecryptStringfromAlphabettoIntegerMappingFunc()
        {
            Program.Space();
            Program.Title("Decrypt String from Alphabet to Integer Mapping");

            string s1 = "10#11#12";
            string s2 = "1326#";

            string result1 = LeetCode.DecryptStringfromAlphabettoIntegerMapping.Solution.FreqAlphabets(s1);
            string result2 = LeetCode.DecryptStringfromAlphabettoIntegerMapping.Solution.FreqAlphabets(s2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(result1, "jkab"),
                ResultTester.CheckResult<string>(result2, "acz")
            };
            ResultTester.CheckSolution("LC", results);
        }


        private static void ConvertBinaryNumberinaLinkedListtoIntegerFunc()
        {
            Program.Space();
            Program.Title("Convert Binary Number in a Linked List to Integer");
            ResultTester.SpecialTestCase("LC");
        }


        private static void TheKWeakestRowsinaMatrixFunc()
        {
            Program.Space();
            Program.Title("The K Weakest Rows in a Matrix");

            int[][] mat1 = new int[][]
            {
                new int[] { 1,1,0,0,0 },
                new int[] { 1,1,1,1,0 },
                new int[] { 1,1,0,0,0 },
                new int[] { 1,0,0,0,0 },
                new int[] { 1,1,0,0,0 },
                new int[] { 1,1,1,1,1 }
            };
            int k1 = 3;

            int[][] mat2 = new int[][]
            {
                new int[] { 1,0,0,0 },
                new int[] { 1,1,1,1 },
                new int[] { 1,0,0,0 },
                new int[] { 1,0,0,0 },
            };
            int k2 = 2;

            int[] result1 = LeetCode.TheKWeakestRowsinaMatrix.Solution.KWeakestRows(mat1, k1);
            int[] result2 = LeetCode.TheKWeakestRowsinaMatrix.Solution.KWeakestRows(mat2, k2);

            int[] expected1 = {3,0,2};
            int[] expected2 = {0,2};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1),
                ResultTester.CheckResult<int[]>(result2, expected2)
            };
            ResultTester.CheckSolution("LC", results);
        }


        private static void CheckifOneStringSwapCanMakeStringsEqualFunc()
        {
            Program.Space();
            Program.Title("Check if One String Swap Can Make Strings Equal");
            string source = "LC";

            string case1s1 = "bank";
            string case1s2 = "kanb";
            string case2s1 = "attack";
            string case2s2 = "defend";
            string case3s1 = "kelb";
            string case3s2 = "kelb";

            bool result1 = LeetCode.CheckifOneStringSwapCanMakeStringsEqual.Solution.AreAlmostEqual(case1s1, case1s2);
            bool result2 = LeetCode.CheckifOneStringSwapCanMakeStringsEqual.Solution.AreAlmostEqual(case2s1, case2s2);
            bool result3 = LeetCode.CheckifOneStringSwapCanMakeStringsEqual.Solution.AreAlmostEqual(case3s1, case3s2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, true),
                ResultTester.CheckResult<bool>(result2, false),
                ResultTester.CheckResult<bool>(result3, true)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void ThreeSumFunc()
        {
            Program.Space();
            Program.Title("3Sum");
            ResultTester.CheckSolution("LC", LeetCode.ThreeSum.Test.TestThreeSum());
        }


        private static void PeakIndexinaMountainArrayFunc()
        {
            Program.Space();
            Program.Title("Peak Index in a Mountain Array");
            ResultTester.CheckSolution("LC", LeetCode.PeakIndexinaMountainArray.Test.TestPeakIndexinaMountainArray());
        }


        private static void KeysandRoomsFunc()
        {
            Program.Space();
            Program.Title("Keys and Rooms");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SimilarStringGroupsFunc()
        {
            Program.Space();
            Program.Title("Similar String Groups");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SubtracttheProductandSumofDigitsofanIntegerFunc()
        {
            Program.Space();
            Program.Title("Subtract the Product and Sum of Digits of an Integer");

            int case1 = 234;
            int case2 = 4421;

            int result1 = LeetCode.SubtracttheProductandSumofDigitsofanInteger.Solution.SubtractProductAndSum(case1);
            int result2 = LeetCode.SubtracttheProductandSumofDigitsofanInteger.Solution.SubtractProductAndSum(case2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 15),
                ResultTester.CheckResult<int>(result2, 21)
            };
            ResultTester.CheckSolution("LC", results);
        }


        private static void DeleteandEarnFunc()
        {
            Program.Space();
            Program.Title("Delete and Earn");
            ResultTester.CheckSolution("LC", LeetCode.DeleteandEarn.Test.TestDeleteandEarn());
        }


        private static void DailyTemperaturesFunc()
        {
            Program.Space();
            Program.Title("Daily Temperatures");
            ResultTester.CheckSolution("LC", LeetCode.DailyTemperatures.Test.TestDailyTemperatures());
        }


        private static void SpecialArrayWithXElementsGreaterThanorEqualXFunc()
        {
            Program.Space();
            Program.Title("Special Array With X Elements Greater Than or Equal X");
            string source = "LC";

            int[] nums1 = {3,5};
            int[] nums2 = {0,0};
            int[] nums3 = {0,4,3,0,4};

            int result1 = LeetCode.SpecialArrayWithXElementsGreaterThanorEqualX.Solution.SpecialArray(nums1);
            int result2 = LeetCode.SpecialArrayWithXElementsGreaterThanorEqualX.Solution.SpecialArray(nums2);
            int result3 = LeetCode.SpecialArrayWithXElementsGreaterThanorEqualX.Solution.SpecialArray(nums3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 2),
                ResultTester.CheckResult<int>(result2, -1),
                ResultTester.CheckResult<int>(result3, 3)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void TwoSumIIInputArrayIsSortedFunc()
        {
            Program.Space();
            Program.Title("Two Sum II - Input Array Is Sorted");
            ResultTester.CheckSolution("LC", LeetCode.TwoSumIIInputArrayIsSorted.Test.TestTwoSumIIInputArrayIsSorted());
        }


        private static void FindFirstandLastPositionofElementinSortedArrayFunc()
        {
            Program.Space();
            Program.Title("Find First and Last Position of Element in Sorted Array");
            ResultTester.CheckSolution("LC", LeetCode.FindFirstandLastPositionofElementinSortedArray.Test.TestFindFirstandLastPositionofElementinSortedArray());
        }


        private static void SqrtxFunc()
        {
            Program.Space();
            Program.Title("Sqrt(x)");
            ResultTester.CheckSolution("LC", LeetCode.Sqrtx.Test.TestSqrtx());
        }


        private static void FindtheDistanceValueBetweenTwoArraysFunc()
        {
            Program.Space();
            Program.Title("Find the Distance Value Between Two Arrays");
            string source = "LC";

            int[] arr1case1 = {4,5,8};
            int[] arr2case1 = {10,9,1,8};
            int dcase1 = 2;

            int[] arr1case2 = {1,4,2,3};
            int[] arr2case2 = {-4,-3,6,10,20,30};
            int dcase2 = 3;

            int[] arr1case3 = {2,1,100,3};
            int[] arr2case3 = {-5,-2,10,-3,7};
            int dcase3 = 6;

            int result1 = LeetCode.FindtheDistanceValueBetweenTwoArrays.Solution.FindTheDistanceValue(arr1case1, arr2case1, dcase1);
            int result2 = LeetCode.FindtheDistanceValueBetweenTwoArrays.Solution.FindTheDistanceValue(arr1case2, arr2case2, dcase2);
            int result3 = LeetCode.FindtheDistanceValueBetweenTwoArrays.Solution.FindTheDistanceValue(arr1case3, arr2case3, dcase3);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
            Console.WriteLine("Result 3 : {0}", result3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 2),
                ResultTester.CheckResult<int>(result2, 2),
                ResultTester.CheckResult<int>(result3, 1)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MergeIntervalsFunc()
        {
            Program.Space();
            Program.Title("Merge Intervals");
            ResultTester.CheckSolution("LC", LeetCode.MergeIntervals.Test.TestInsertInterval());
        }


        private static void SortColorsFunc()
        {
            Program.Space();
            Program.Title("Sort Colors");
            int[] case1 = {2,0,2,1,1,0};
            int[] case2 = {2,0,1};
            LeetCode.SortColors.Solution.SortColors(case1);
            LeetCode.SortColors.Solution.SortColors(case2);
            ResultTester.SpecialTestCase("LC");
        }


        private static void TimeNeededtoInformAllEmployeesFunc()
        {
            Program.Space();
            Program.Title("Time Needed to Inform All Employees");
            string source = "LC";

            int n1 = 1;
            int headID1 = 0;
            int[] manager1 = {-1};
            int[] informTime1 = {0};

            int n2 = 6;
            int headID2 = 2;
            int[] manager2 = {2,2,-1,2,2,2};
            int[] informTime2 = {0,0,1,0,0,0};

            int result1 = LeetCode.TimeNeededtoInformAllEmployees.Solution.NumOfMinutes(n1, headID1, manager1, informTime1);
            int result2 = LeetCode.TimeNeededtoInformAllEmployees.Solution.NumOfMinutes(n2, headID2, manager2, informTime2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 0),
                ResultTester.CheckResult<int>(result2, 1)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void LongestZigZagPathinaBinaryTreeFunc()
        {
            Program.Space();
            Program.Title("Longest ZigZag Path in a Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DesignCircularQueueFunc()
        {
            Program.Space();
            Program.Title("Design Circular Queue");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MergeTwoBinaryTreesFunc()
        {
            Program.Space();
            Program.Title("Merge Two Binary Trees");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SumofSquareNumbersFunc()
        {
            Program.Space();
            Program.Title("Sum of Square Numbers");
            ResultTester.CheckSolution("LC", LeetCode.SumofSquareNumbers.Test.TestSumofSquareNumbers());
        }


        private static void DecodeWaysFunc()
        {
            Program.Space();
            Program.Title("Decode Ways");
            ResultTester.CheckSolution("LC", LeetCode.DecodeWays.Test.TestDecodeWays());
        }


        private static void ArithmeticSlicesFunc()
        {
            Program.Space();
            Program.Title("Arithmetic Slices");
            ResultTester.CheckSolution("LC", LeetCode.ArithmeticSlices.Test.TestArithmeticSlices());
        }


        private static void SumofAllOddLengthSubarraysFunc()
        {
            Program.Space();
            Program.Title("Sum of All Odd Length Subarrays");
            string source = "LC";

            int[] arr1 = {1,4,2,5,3};
            int[] arr2 = {1,2};
            int[] arr3 = {10,11,12};

            int result1 = LeetCode.SumofAllOddLengthSubarrays.Solution.SumOddLengthSubarrays(arr1);
            int result2 = LeetCode.SumofAllOddLengthSubarrays.Solution.SumOddLengthSubarrays(arr2);
            int result3 = LeetCode.SumofAllOddLengthSubarrays.Solution.SumOddLengthSubarrays(arr3);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
            Console.WriteLine("Result 3 : {0}", result3);

            int output1_1588 = 58;
            int output2_1588 = 3;
            int output3_1588 = 66;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1_1588),
                ResultTester.CheckResult<int>(result2, output2_1588),
                ResultTester.CheckResult<int>(result3, output3_1588)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void RemoveMaxNumberofEdgestoKeepGraphFullyTraversableFunc()
        {
            Program.Space();
            Program.Title("Remove Max Number of Edges to Keep Graph Fully Traversable");
            string source = "LC";
            ResultTester.SpecialTestCase(source);
        }


        private static void NextGreaterElementIFunc()
        {
            Program.Space();
            Program.Title("Next Greater Element I");
            ResultTester.CheckSolution("LC", LeetCode.NextGreaterElementI.Test.TestNextGreaterElementI());
        }


        private static void SquaresofaSortedArrayFunc()
        {
            Program.Space();
            Program.Title("Squares of a Sorted Array");
            ResultTester.CheckSolution("LC", LeetCode.SquaresofaSortedArray.Test.TestSquaresofaSortedArray());
        }


        private static void RotateArrayFunc()
        {
            Program.Space();
            Program.Title("Rotate Array");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FibonacciNumberFunc()
        {
            Program.Space();
            Program.Title("Fibonacci Number");
            ResultTester.CheckSolution("LC", LeetCode.FibonacciNumber.Test.TestFibonacciNumber());
        }


        private static void FindNearestPointThatHastheSameXorYCoordinateFunc()
        {
            Program.Space();
            Program.Title("Find Nearest Point That Has the Same X or Y Coordinate");
            string source = "LC";

            int[][] points1 = new int[][]
            {
                new int[] { 1,2 },
                new int[] { 3,1 },
                new int[] { 2,4 },
                new int[] { 2,3 },
                new int[] { 4,4 }
            };

            int[][] points2 = new int[][]
            {
                new int[] { 3,4 }
            };

            int[][] points3 = new int[][]
            {
                new int[] { 2,3 }
            };

            int result1 = LeetCode.FindNearestPointThatHastheSameXorYCoordinate.Solution.NearestValidPoint(3, 4, points1);
            int result2 = LeetCode.FindNearestPointThatHastheSameXorYCoordinate.Solution.NearestValidPoint(3, 4, points2);
            int result3 = LeetCode.FindNearestPointThatHastheSameXorYCoordinate.Solution.NearestValidPoint(3, 4, points3);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
            Console.WriteLine("Result 3 : {0}", result3);
            
            int output1 = 2;
            int output2 = 0;
            int output3 = -1;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1),
                ResultTester.CheckResult<int>(result2, output2),
                ResultTester.CheckResult<int>(result3, output3)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void Numberof1BitsFunc()
        {
            Program.Space();
            Program.Title("Number of 1 Bits");
            ResultTester.CheckSolution("LC", LeetCode.Numberof1Bits.Test.TestNumberof1Bits());
        }


        private static void SimpleArraySumFunc()
        {
            Program.Space();
            Program.Title("Simple Array Sum");
            ResultTester.CheckSolution("HR", HackerRank.SimpleArraySum.Test.TestSimpleArraySum());
        }


        private static void SolveMeFirstFunc()
        {
            Program.Space();
            Program.Title("Solve Me First");
            ResultTester.CheckSolution("HR", HackerRank.SolveMeFirst.Test.TestSolveMeFirst());
        }


        private static void UglyNumberIIFunc()
        {
            Program.Space();
            Program.Title("Ugly Number II");
            ResultTester.CheckSolution("LC", LeetCode.UglyNumberII.Test.TestUglyNumberII());
        }


        private static void UniqueBinarySearchTreesFunc()
        {
            Program.Space();
            Program.Title("Unique Binary Search Trees");
            ResultTester.CheckSolution("LC", LeetCode.UniqueBinarySearchTrees.Test.TestUniqueBinarySearchTrees());
        }


        private static void SortIntegersbyTheNumberof1BitsFunc()
        {
            Program.Space();
            Program.Title("Sort Integers by The Number of 1 Bits");
            string source = "LC";

            int[] arr1356_1 = {0,1,2,3,4,5,6,7,8};
            int[] arr1356_2 = {1024,512,256,128,64,32,16,8,4,2,1};

            int[] output1_1356 = {0,1,2,4,8,3,5,6,7};
            int[] output2_1356 = {1,2,4,8,16,32,64,128,256,512,1024};

            int[] result1 = LeetCode.SortIntegersbyTheNumberof1Bits.Solution.SortByBits(arr1356_1);
            int[] result2 = LeetCode.SortIntegersbyTheNumberof1Bits.Solution.SortByBits(arr1356_2);

            Program.PrintArray(arr1356_1);
            Program.PrintArray(arr1356_2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, output1_1356),
                ResultTester.CheckResult<int[]>(result2, output2_1356)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void SearchinRotatedSortedArrayFunc()
        {
            Program.Space();
            Program.Title("Search in Rotated Sorted Array");
            ResultTester.CheckSolution("LC", LeetCode.SearchinRotatedSortedArray.Test.TestSearchinRotatedSortedArray());
        }


        private static void MaximumDistanceBetweenaPairofValuesFunc()
        {
            Program.Space();
            Program.Title("Maximum Distance Between a Pair of Values");
            string source = "LC";

            int[] nums1_1855_1 = {55,30,5,4,2};
            int[] nums2_1855_1 = {100,20,10,10,5};

            int[] nums1_1855_2 = {2,2,2};
            int[] nums2_1855_2 = {10,10,1};

            int[] nums1_1855_3 = {30,29,19,5};
            int[] nums2_1855_3 = {25,25,25,25,25};

            int output1_1855 = 2;
            int output2_1855 = 1;
            int output3_1855 = 2;

            int result1 = LeetCode.MaximumDistanceBetweenaPairofValues.Solution.MaxDistance(nums1_1855_1, nums2_1855_1);
            int result2 = LeetCode.MaximumDistanceBetweenaPairofValues.Solution.MaxDistance(nums1_1855_2, nums2_1855_2);
            int result3 = LeetCode.MaximumDistanceBetweenaPairofValues.Solution.MaxDistance(nums1_1855_3, nums2_1855_3);

            Console.WriteLine("Result 1 : {0}", result1);
            Console.WriteLine("Result 2 : {0}", result2);
            Console.WriteLine("Result 3 : {0}", result3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1_1855),
                ResultTester.CheckResult<int>(result2, output2_1855),
                ResultTester.CheckResult<int>(result3, output3_1855)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void TrappingRainWaterFunc()
        {
            Program.Space();
            Program.Title("Trapping Rain Water");
            ResultTester.CheckSolution("LC", LeetCode.TrappingRainWater.Test.TestTrappingRainWater());
        }


        private static void WordBreakFunc()
        {
            Program.Space();
            Program.Title("Word Break");
            ResultTester.CheckSolution("LC", LeetCode.WordBreak.Test.TestWordBreak());
        }


        private static void ZeroOneMatrixFunc()
        {
            Program.Space();
            Program.Title("01 Matrix");
            ResultTester.CheckSolution("LC", LeetCode.ZeroOneMatrix.Test.TestZeroOneMatrix());
        }


        private static void MaxAreaofIslandFunc()
        {
            Program.Space();
            Program.Title("Max Area of Island");
            ResultTester.CheckSolution("LC", LeetCode.MaxAreaofIsland.Test.TestMaxAreaofIsland());
        }


        private static void PowerofTwoFunc()
        {
            Program.Space();
            Program.Title("Power of Two");
            ResultTester.CheckSolution("LC", LeetCode.PowerofTwo.Test.TestPowerofTwo());
        }


        private static void ReverseWordsinaStringIIIFunc()
        {
            Program.Space();
            Program.Title("Power of Two");
            ResultTester.CheckSolution("LC", LeetCode.ReverseWordsinaStringIII.Test.TestReverseWordsinaStringIII());
        }


        private static void TriangleFunc()
        {
            Program.Space();
            Program.Title("Tringle");
            ResultTester.CheckSolution("LC", LeetCode.Triangle.Test.TestTriangle());
        }


        private static void PascalsTriangleIIFunc()
        {
            Program.Space();
            Program.Title("Pascals Triangle II");
            ResultTester.CheckSolution("LC", LeetCode.PascalsTriangleII.Test.TestPascalsTriangleII());
        }


        private static void LongestSubstringWithoutRepeatingCharactersFunc()
        {
            Program.Space();
            Program.Title("Longest Substring Without Repeating Characters");
            ResultTester.CheckSolution("LC", LeetCode.LongestSubstringWithoutRepeatingCharacters.Test.TestLongestSubstringWithoutRepeatingCharacters());
        }


        private static void AVeryBigSumFunc()
        {
            Program.Space();
            Program.Title("A Very Big Sum");
            string source = "HR";

            List<long> ar = new List<long> { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            long output = 5000000015;
            long result = HackerRank.AVeryBigSum.Result.aVeryBigSum(ar);
            Console.WriteLine("Result : {0}", result);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(result, output),
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void ReverseBitsFunc()
        {
            Program.Space();
            Program.Title("Reverse Bits");
            ResultTester.CheckSolution("LC", LeetCode.ReverseBits.Test.TestReverseBits());
        }


        private static void UniquePathsIIFunc()
        {
            Program.Space();
            Program.Title("Unique Paths II");
            ResultTester.CheckSolution("LC", LeetCode.UniquePathsII.Test.TestUniquePathsII());
        }


        private static void MaximalSquareFunc()
        {
            Program.Space();
            Program.Title("Maximal Square");
            ResultTester.CheckSolution("LC", LeetCode.MaximalSquare.Test.TestMaximalSquare());
        }


        private static void JumpGameFunc()
        {
            Program.Space();
            Program.Title("Jump Game");
            ResultTester.CheckSolution("LC", LeetCode.JumpGame.Test.TestJumpGame());
        }


        private static void PathSumIIFunc()
        {
            Program.Space();
            Program.Title("Path Sum II");
            ResultTester.SpecialTestCase("LC");
        }

        
        private static void BinaryTreeInorderTraversalFunc()
        {
            Program.Space();
            Program.Title("Binary Tree Inorder Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaximumValueataGivenIndexinaBoundedArrayFunc()
        {
            Program.Space();
            Program.Title("Maximum Value at a Given Index in a Bounded Array");
            string source = "LC";

            int n1 = 4;
            int index1 = 2;
            int maxSum1 = 6;
            int output1_1802 = 2;

            int n2 = 6;
            int index2 = 1;
            int maxSum2 = 10;
            int output2_1802 = 3;

            int result1 = LeetCode.MaximumValueataGivenIndexinaBoundedArray.Solution.MaxValue(n1, index1, maxSum1);
            int result2 = LeetCode.MaximumValueataGivenIndexinaBoundedArray.Solution.MaxValue(n2, index2, maxSum2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1_1802),
                ResultTester.CheckResult<int>(result2, output2_1802)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void BinarySearchTreeIteratorFunc()
        {
            Program.Space();
            Program.Title("Binary Search Tree Iterator");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PathSumFuncFunc()
        {
            Program.Space();
            Program.Title("Path Sum Func");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ConvertSortedListtoBinarySearchTreeFunc()
        {
            Program.Space();
            Program.Title("ConvertSorted List to Binary Search Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void KthSmallestElementinaBSTFunc()
        {
            Program.Space();
            Program.Title("Kth Smallest Element in a BST");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ConstructBinaryTreefromPreorderandInorderTraversalFunc()
        {
            Program.Space();
            Program.Title("Construct Binary Tree from Preorder and Inorder Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaximumDepthofBinaryTreeFunc()
        {
            Program.Space();
            Program.Title("Maximum Depth of Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }
        

        private static void BinaryTreeZigzagLevelOrderTraversalFunc()
        {
            Program.Space();
            Program.Title("Binary Tree Zigzag Level Order Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void BinaryTreeLevelOrderTraversalFunc()
        {
            Program.Space();
            Program.Title("Binary Tree Level Order Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SymmetricTreeFunc()
        {
            Program.Space();
            Program.Title("Symmetric Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SameTreeFunc()
        {
            Program.Space();
            Program.Title("Same Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ValidateBinarySearchTreeFunc()
        {
            Program.Space();
            Program.Title("Validate Binary Search Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaximumValueofaStringinanArrayFunc()
        {
            Program.Space();
            Program.Title("Maximum Value of a String in an Array");
            string source = "LC";

            string[] strs1 = {"alic3","bob","3","4","00000"};
            string[] strs2 = {"1","01","001","0001"};

            int result1_2496 = LeetCode.MaximumValueofaStringinanArray.Solution.MaximumValue(strs1);
            int result2_2496 = LeetCode.MaximumValueofaStringinanArray.Solution.MaximumValue(strs2);
            int result1_2496Linq = LeetCode.MaximumValueofaStringinanArray.Solution.MaximumValueLinq(strs1);
            int result2_2496Linq = LeetCode.MaximumValueofaStringinanArray.Solution.MaximumValueLinq(strs2);

            int output1 = 5;
            int output2 = 1;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_2496, output1),
                ResultTester.CheckResult<int>(result2_2496, output2),
                ResultTester.CheckResult<int>(result1_2496Linq, output1),
                ResultTester.CheckResult<int>(result2_2496Linq, output2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void SnapshotArrayFunc()
        {
            Program.Space();
            Program.Title("Maximum Value of a String in an Array");
            string source = "LC";

            ResultTester.SpecialTestCase(source);
        }


        private static void LongestIncreasingSubsequenceFunc()
        {
            Program.Space();
            Program.Title("Longest Increasing Subsequence");
            ResultTester.CheckSolution("LC", LeetCode.LongestIncreasingSubsequence.Test.TestLongestIncreasingSubsequence());
        }


        private static void WiggleSubsequenceFunc()
        {
            Program.Space();
            Program.Title("Wiggle Subsequence");
            ResultTester.CheckSolution("LC", LeetCode.WiggleSubsequence.Test.TestWiggleSubsequence());
        }


        private static void LongestPalindromicSubstringFunc()
        {
            Program.Space();
            Program.Title("Longest Palindromic Substring");
            ResultTester.CheckSolution("LC", LeetCode.LongestPalindromicSubstring.Test.TestLongestPalindromicSubstring());
        }


        private static void LongestPalindromeFunc()
        {
            Program.Space();
            Program.Title("Longest Palindrome");
            ResultTester.CheckSolution("LC", LeetCode.LongestPalindrome.Test.TestLongestPalindrome());
        }


        private static void RangeSumQuery2DImmutableFunc()
        {
            Program.Space();
            Program.Title("Range Sum Query 2D - Immutable");
            ResultTester.SpecialTestCase("LC");
        }


        private static void BestTimetoBuyandSellStockwithCooldownFunc()
        {
            Program.Space();
            Program.Title("Best Time to Buy and Sell Stock with Cooldown");
            ResultTester.CheckSolution("LC", LeetCode.BestTimetoBuyandSellStockwithCooldown.Test.TestBestTimetoBuyandSellStockwithCooldown());
        }
        

        private static void GuessNumberHigherorLowerFunc()
        {
            Program.Space();
            Program.Title("Guess Number Higher or Lower");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SumofLeftLeavesFunc()
        {
            Program.Space();
            Program.Title("Sum of Left Leaves");
            ResultTester.SpecialTestCase("LC");
        }


        private static void EvaluateDivisionFunc()
        {
            Program.Space();
            Program.Title("Evaluate Division");
            ResultTester.CheckSolution("LC", LeetCode.EvaluateDivision.Test.TestEvaluateDivision());
        }


        private static void DecodeStringFunc()
        {
            Program.Space();
            Program.Title("Decode String");
            ResultTester.CheckSolution("LC", LeetCode.DecodeString.Test.TestDecodeString());
        }


        private static void BestTimetoBuyandSellStockIIFunc()
        {
            Program.Space();
            Program.Title("Best Time to Buy and Sell Stock II");
            ResultTester.CheckSolution("LC", LeetCode.BestTimetoBuyandSellStockII.Test.TestBestTimetoBuyandSellStockII());
        }


        private static void BestSightseeingPairFunc()
        {
            Program.Space();
            Program.Title("Best Sightseeing Pair");
            ResultTester.CheckSolution("LC", LeetCode.BestSightseeingPair.Test.TestBestSightseeingPair());
        }


        private static void WordPatternFunc()
        {
            Program.Space();
            Program.Title("Word Pattern");
            ResultTester.CheckSolution("LC", LeetCode.WordPattern.Test.TestWordPattern());
        }


        private static void SerializeandDeserializeBinaryTreeFunc()
        {
            Program.Space();
            Program.Title("Serialize and Deserialize Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MatrixBlockSumFunc()
        {
            Program.Space();
            Program.Title("Matrix Block Sum");
            string source = "LC";

            int[][] matrix1_1314 = new int[][]
            {
                new int[] { 1,2,3 },
                new int[] { 4,5,6 },
                new int[] { 7,8,9 }
            };
            int k1_1314 = 1;
            int[][] matrix2_1314 = new int[][]
            {
                new int[] { 1,2,3 },
                new int[] { 4,5,6 },
                new int[] { 7,8,9 }
            };
            int k2_1314 = 2;

            int[][] result1 = LeetCode.MatrixBlockSum.Solution.MatrixBlockSum(matrix1_1314, k1_1314);
            int[][] result2 = LeetCode.MatrixBlockSum.Solution.MatrixBlockSum(matrix2_1314, k2_1314);

            Program.Print2DIntArray(result1);
            Program.Space();
            Program.Print2DIntArray(result2);

            int[][] matrixOutput1 = new int[][]
            {
                new int[] { 12,21,16 },
                new int[] { 27,45,33 },
                new int[] { 24,39,28 }
            };

            int[][] matrixOutput2 = new int[][]
            {
                new int[] { 45,45,45 },
                new int[] { 45,45,45 },
                new int[] { 45,45,45 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(result1, matrixOutput1),
                ResultTester.CheckResult<int[][]>(result2, matrixOutput2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void SummaryRangesFunc()
        {
            Program.Space();
            Program.Title("Summary Ranges");
            ResultTester.CheckSolution("LC", LeetCode.SummaryRanges.Test.TestSummaryRanges());
        }


        private static void MaximumProductSubarrayFunc()
        {
            Program.Space();
            Program.Title("Maximum Product Subarray");
            ResultTester.CheckSolution("LC", LeetCode.MaximumProductSubarray.Test.TestMaximumProductSubarray());
        }


        private static void MaximumLengthofSubarrayWithPositiveProductFunc()
        {
            Program.Space();
            Program.Title("Maximum Length of Subarray With Positive Product");
            string source = "LC";

            int[] nums1_1567 = {1,-2,-3,4};
            int[] nums2_1567 = {0,1,-2,-3,-4};
            int[] nums3_1567 = {-1,-2,-3,0,1};

            int result1_1567 = LeetCode.MaximumLengthofSubarrayWithPositiveProduct.Solution.GetMaxLen(nums1_1567);
            int result2_1567 = LeetCode.MaximumLengthofSubarrayWithPositiveProduct.Solution.GetMaxLen(nums2_1567);
            int result3_1567 = LeetCode.MaximumLengthofSubarrayWithPositiveProduct.Solution.GetMaxLen(nums3_1567);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_1567, 4),
                ResultTester.CheckResult<int>(result2_1567, 3),
                ResultTester.CheckResult<int>(result3_1567, 2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MinimumNumberofVerticestoReachAllNodesFunc()
        {
            Program.Space();
            Program.Title("Minimum Number of Vertices to Reach All Nodes");
            string source = "LC";
            ResultTester.SpecialTestCase(source);
        }


        private static void FindtheWinneroftheCircularGameFunc()
        {
            Program.Space();
            Program.Title("Find the Winner of the Circular Game");
            string source = "LC";

            int case1_1823 = LeetCode.FindtheWinneroftheCircularGame.Solution.FindTheWinner(5, 2);
            int case2_1823 = LeetCode.FindtheWinneroftheCircularGame.Solution.FindTheWinner(6, 5);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(case1_1823, 3),
                ResultTester.CheckResult<int>(case2_1823, 1)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void RemoveDuplicatesfromSortedListFunc()
        {
            Program.Space();
            Program.Title("Remove Duplicates from Sorted List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void RemoveDuplicatesfromSortedListIIFunc()
        {
            Program.Space();
            Program.Title("Remove Duplicates from Sorted List II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DesignLinkedListFunc()
        {
            Program.Space();
            Program.Title("Design Linked List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DesignHashMapFunc()
        {
            Program.Space();
            Program.Title("Design Hash Map");
            ResultTester.SpecialTestCase("LC");
        }
        

        private static void DesignHashSetFunc()
        {
            Program.Space();
            Program.Title("Design Hash Set");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ReverseNodesinkGroupFunc()
        {
            Program.Space();
            Program.Title("Reverse Nodes in k-Group");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SwapNodesinPairsFunc()
        {
            Program.Space();
            Program.Title("Swap Nodes in Pairs");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MergekSortedListsFunc()
        {
            Program.Space();
            Program.Title("Merge k Sorted Lists");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MinStackFunc()
        {
            Program.Space();
            Program.Title("Min Stack");
            ResultTester.SpecialTestCase("LC");
        } 


        private static void GenerateParenthesesFunc()
        {
            Program.Space();
            Program.Title("Generate Parentheses");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MergeTwoSortedListsFunc()
        {
            Program.Space();
            Program.Title("Merge Two Sorted Lists");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CoinChangeFunc()
        {
            Program.Space();
            Program.Title("Coin Change");
            ResultTester.CheckSolution("LC", LeetCode.CoinChange.Test.TestCoinChange());
        }


        private static void ValidParenthesesFunc()
        {
            Program.Space();
            Program.Title("Valid Parentheses");
            ResultTester.CheckSolution("LC", LeetCode.ValidParentheses.Test.TestValidParentheses());
        }


        private static void CoinChangeIIFunc()
        {
            Program.Space();
            Program.Title("Coin Change");
            ResultTester.CheckSolution("LC", LeetCode.CoinChangeII.Test.TestCoinChangeII());
        }


        private static void MinimumRoundstoCompleteAllTasksFunc()
        {
            Program.Space();
            Program.Title("Minimum Rounds to Complete All Tasks");
            string source = "LC";

            int[] tasks1_2244 = {2, 2, 3, 3, 2, 4, 4, 4, 4, 4};
            int[] tasks2_2244 = {2, 3, 3};

            int result1_2244 = LeetCode.MinimumRoundstoCompleteAllTasks.Solution.MinimumRounds(tasks1_2244);
            int result2_2244 = LeetCode.MinimumRoundstoCompleteAllTasks.Solution.MinimumRounds(tasks2_2244);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_2244, 4),
                ResultTester.CheckResult<int>(result2_2244, -1)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void FindtheDifferenceofTwoArraysFunc()
        {
            Program.Space();
            Program.Title("Find the Difference of Two Arrays");
            string source = "LC";

            int[] nums1_Case1 = {1,2,3};
            int[] nums2_Case1 = {2,4,6};

            int[] nums1_Case2 = {1,2,3,3};
            int[] nums2_Case2 = {1,1,2,2};

            IList<IList<int>> listOfLists1 = LeetCode.FindtheDifferenceofTwoArrays.Solution.FindDifference(nums1_Case1, nums2_Case1);
            IList<IList<int>> listOfLists2 = LeetCode.FindtheDifferenceofTwoArrays.Solution.FindDifference(nums1_Case2, nums2_Case2);

            IList<IList<int>> output1_2215 = new List<IList<int>>();
            IList<IList<int>> output2_2215 = new List<IList<int>>();
            IList<int> innerList1 = new List<int> { 1, 3 };
            IList<int> innerList2 = new List<int> { 4, 6 };
            output1_2215.Add(innerList1);
            output1_2215.Add(innerList2);
            IList<int> innerList3 = new List<int> { 3 };
            IList<int> innerList4 = new List<int> {  };
            output2_2215.Add(innerList3);
            output2_2215.Add(innerList4);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<int>>>(listOfLists1, output1_2215),
                ResultTester.CheckResult<IList<IList<int>>>(listOfLists2, output2_2215)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void SolvingQuestionsWithBrainpowerFunc()
        {
            Program.Space();
            Program.Title("Solving Questions With Brainpower");
            string source = "LC";
            ResultTester.SpecialTestCase(source);
        }


        private static void MaximumTwinSumofaLinkedListFunc()
        {
            Program.Space();
            Program.Title("Maximum Twin Sum of a Linked List");
            string source = "LC";
            ResultTester.SpecialTestCase(source);
        }


        private static void DeletetheMiddleNodeofaLinkedListFunc()
        {
            Program.Space();
            Program.Title("Delete the Middle Node of a Linked List");
            string source = "LC";
            ResultTester.SpecialTestCase(source);
        }


        private static void FindifPathExistsinGraphFunc()
        {
            Program.Space();
            Program.Title("Find if Path Exists in Graph");
            string source = "LC";
            ResultTester.SpecialTestCase(source);
        }


        private static void NearestExitfromEntranceinMazeFunc()
        {
            Program.Space();
            Program.Title("Nearest Exit from Entrance in Maze");
            string source = "LC";

            char[][] maze1 = new char[][]
            {
                new char[] { '+', '+', '.', '+' },
                new char[] { '.', '.', '.', '+' },
                new char[] { '+', '+', '+', '.' }
            };

            int[] entrance1 = new int[] { 1, 2 };

            char[][] maze2 = new char[][]
            {
                new char[] { '+', '+', '+' },
                new char[] { '.', '.', '.' },
                new char[] { '+', '+', '+' }
            };

            int[] entrance2 = new int[] { 1, 0 };

            char[][] maze3 = new char[][]
            {
                new char[] { '.', '+' }
            };

            int[] entrance3 = new int[] { 0, 0 };

            int result1 = LeetCode.NearestExitfromEntranceinMaze.Solution.NearestExit(maze1, entrance1);
            int result2 = LeetCode.NearestExitfromEntranceinMaze.Solution.NearestExit(maze2, entrance2);
            int result3 = LeetCode.NearestExitfromEntranceinMaze.Solution.NearestExit(maze3, entrance3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 1),
                ResultTester.CheckResult<int>(result2, 2),
                ResultTester.CheckResult<int>(result3, -1)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void YouCantCodeUnderPressure1Func()
        {
            Program.Space();
            Program.Title("You Can't Code Under Pressure #1");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.YouCantCodeUnderPressure1.Test.TestYouCantCodeUnderPressure1());
        }


        private static void CompareTheTripletsFunc()
        {
            Program.Space();
            Program.Title("Compare The Triplets");
            ResultTester.CheckSolution("HR", HackerRank.CompareTheTriplets.Test.TestCompareTriplets());
        }


        private static void RangeSumQueryImmutableFunc()
        {
            Program.Space();
            Program.Title("Range Sum Query - Immutable");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MakeArrayStrictlyIncreasingFunc()
        {
            Program.Space();
            Program.Title("Make Array Strictly Increasing");
            string source = "LC";

            int[] arr1 = {1,5,3,6,7};
            int[] arr2_Case1 = {1,3,2,4};
            int[] arr2_Case2 = {4,3,1};
            int[] arr2_Case3 = {1,6,3,3};

            int result1_1187 = LeetCode.MakeArrayStrictlyIncreasing.Solution.MakeArrayIncreasing(arr1, arr2_Case1);
            int result2_1187 = LeetCode.MakeArrayStrictlyIncreasing.Solution.MakeArrayIncreasing(arr1, arr2_Case2);
            int result3_1187 = LeetCode.MakeArrayStrictlyIncreasing.Solution.MakeArrayIncreasing(arr1, arr2_Case3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_1187, 1),
                ResultTester.CheckResult<int>(result2_1187, 2),
                ResultTester.CheckResult<int>(result3_1187, -1)
            };
            ResultTester.CheckSolution(source, results);
        }

        
        private static void SearchinRotatedSortedArrayIIFunc()
        {
            Program.Space();
            Program.Title("Search in Rotated Sorted Array II");
            ResultTester.CheckSolution("LC", LeetCode.SearchinRotatedSortedArrayII.Test.TestSearchinRotatedSortedArrayII());
        }


        private static void FindRightIntervalFunc()
        {
            Program.Space();
            Program.Title("Find Right Interval");
            ResultTester.CheckSolution("LC", LeetCode.FindRightInterval.Test.TestFindRightInterval());
        }


        private static void MostProfitAssigningWorkFunc()
        {
            Program.Space();
            Program.Title("Most Profit Assigning Work");
            ResultTester.CheckSolution("LC", LeetCode.MostProfitAssigningWork.Test.TestMostProfitAssigningWork());
        }


        private static void WaystoSplitArrayIntoThreeSubarraysFunc()
        {
            Program.Space();
            Program.Title("Ways to Split Array Into Three Subarrays");
            string source = "LC";

            int[] nums1_1712 = {1,1,1};
            int[] nums2_1712 = {1,2,2,2,5,0};
            int[] nums3_1712 = {3,2,1};

            int result1_1712 = LeetCode.WaystoSplitArrayIntoThreeSubarrays.Solution.WaysToSplit(nums1_1712);
            int result2_1712 = LeetCode.WaystoSplitArrayIntoThreeSubarrays.Solution.WaysToSplit(nums2_1712);
            int result3_1712 = LeetCode.WaystoSplitArrayIntoThreeSubarrays.Solution.WaysToSplit(nums3_1712);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_1712, 1),
                ResultTester.CheckResult<int>(result2_1712, 3),
                ResultTester.CheckResult<int>(result3_1712, 0)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void NumberofIslandsFunc()
        {
            Program.Space();
            Program.Title("Number of Islands");
            ResultTester.CheckSolution("LC", LeetCode.NumberofIslands.Test.TestHappyNumber());
        }


        private static void AllPathsFromSourcetoTargetFunc()
        {
            Program.Space();
            Program.Title("All Paths From Source to Target");
            ResultTester.CheckSolution("LC", LeetCode.AllPathsFromSourcetoTarget.Test.TestAllPathsFromSourcetoTarget());
        }


        private static void NumberofIncreasingPathsinaGridFunc()
        {
            Program.Space();
            Program.Title("Number of Increasing Paths in a Grid");
            string source = "LC";

            int[][] grid1 = new int[][]
            {
                new int[] { 1, 1 },
                new int[] { 3, 4 }
            };
            int[][] grid2 = new int[][]
            {
                new int[] { 1 },
                new int[] { 2 }
            };

            int result1 = LeetCode.NumberofIncreasingPathsinaGrid.Solution.CountPaths(grid1);
            int result2 = LeetCode.NumberofIncreasingPathsinaGrid.Solution.CountPaths(grid2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 8),
                ResultTester.CheckResult<int>(result2, 3)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void PacificAtlanticWaterFlowFunc()
        {
            Program.Space();
            Program.Title("Pacific Atlantic Water Flow");
            ResultTester.CheckSolution("LC", LeetCode.PacificAtlanticWaterFlow.Test.TestPacificAtlanticWaterFlow());
        }


        private static void CenturyFromYearFunc()
        {
            Program.Space();
            Program.Title("Century From Year");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.CenturyFromYear.Test.TestCenturyFromYear());
        }


        private static void BasicMathematicalOperationsFunc()
        {
            Program.Space();
            Program.Title("Basic Mathematical Operations");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.BasicMathematicalOperations.Test.TestBasicMathematicalOperations());
        }


        private static void DiagonalDifferenceFunc()
        {
            Program.Space();
            Program.Title("Diagonal Difference");
            ResultTester.SpecialTestCase("HR");
        }


        private static void BinaryTreeRightSideViewFunc()
        {
            Program.Space();
            Program.Title("Binary Tree Right Side View");
            ResultTester.SpecialTestCase("LC");
        }

        
        private static void CountSubIslandsFunc()
        {
            Program.Space();
            Program.Title("Diagonal Difference");
            string source = "LC";

            int[][] grid1_Case1 = new int[][]
            {
                new int[] { 1, 1, 1, 0, 0 },
                new int[] { 0, 1, 1, 1, 1 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 0, 1, 1 }
            };

            int[][] grid2_Case1 = new int[][]
            {
                new int[] { 1, 1, 1, 0, 0 },
                new int[] { 0, 0, 1, 1, 1 },
                new int[] { 0, 1, 0, 0, 0 },
                new int[] { 1, 0, 1, 1, 0 },
                new int[] { 0, 1, 0, 1, 0 }
            };

            int[][] grid1_Case2 = new int[][]
            {
                new int[] { 1, 0, 1, 0, 1 },
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 1, 0, 1, 0, 1 }
            };

            int[][] grid2_Case2 = new int[][]
            {
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 0, 1, 0, 1, 0 },
                new int[] { 0, 1, 0, 1, 0 },
                new int[] { 1, 0, 0, 0, 1 }
            };

            int result1 = LeetCode.CountSubIslands.Solution.CountSubIslands(grid1_Case1, grid2_Case1);
            int result2 = LeetCode.CountSubIslands.Solution.CountSubIslands(grid1_Case2, grid2_Case2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void ShortestSubarraytobeRemovedtoMakeArraySortedFunc()
        {
            Program.Space();
            Program.Title("Shortest Subarray to be Removed to Make Array Sorted");
            string source = "LC";

            int[] arr1 = {1,2,3,10,4,2,3,5};
            int[] arr2 = {5,4,3,2,1};
            int[] arr3 = {1,2,3};
            int result1 = LeetCode.ShortestSubarraytobeRemovedtoMakeArraySorted.Solution.FindLengthOfShortestSubarray(arr1);
            int result2 = LeetCode.ShortestSubarraytobeRemovedtoMakeArraySorted.Solution.FindLengthOfShortestSubarray(arr2);
            int result3 = LeetCode.ShortestSubarraytobeRemovedtoMakeArraySorted.Solution.FindLengthOfShortestSubarray(arr3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 4),
                ResultTester.CheckResult<int>(result3, 0)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void RangeSumofSortedSubarraySumsFunc()
        {
            Program.Space();
            Program.Title("Range Sum of Sorted Subarray Sums");
            string source = "LC";

            int[] nums1 = {1,2,3,4};
            int n1 = 4;
            int left1 = 1;
            int right1 = 5;

            int[] nums2 = {1,2,3,4};
            int n2 = 4;
            int left2 = 3;
            int right2 = 4;

            int[] nums3 = {1,2,3,4};
            int n3 = 4;
            int left3 = 1;
            int right3 = 10;

            int result1 = LeetCode.RangeSumofSortedSubarraySums.Solution.RangeSum(nums1, n1, left1, right1);
            int result2 = LeetCode.RangeSumofSortedSubarraySums.Solution.RangeSum(nums2, n2, left2, right2);
            int result3 = LeetCode.RangeSumofSortedSubarraySums.Solution.RangeSum(nums3, n3, left3, right3);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 13),
                ResultTester.CheckResult<int>(result2, 6),
                ResultTester.CheckResult<int>(result3, 50)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MinimumSizeSubarraySumFunc()
        {
            Program.Space();
            Program.Title("Minimum Size Subarray Sum");
            ResultTester.CheckSolution("LC", LeetCode.MinimumSizeSubarraySum.Test.TestMinimumSizeSubarraySum());
        }


        private static void ValidTriangleNumberFunc()
        {
            Program.Space();
            Program.Title("Valid Triangle Number");
            ResultTester.CheckSolution("LC", LeetCode.ValidTriangleNumber.Test.TestValidTriangleNumber());
        }


        private static void CountCompleteTreeNodesFunc()
        {
            Program.Space();
            Program.Title("Count Complete Tree Nodes");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FrequencyoftheMostFrequentElementFunc()
        {
            Program.Space();
            Program.Title("Frequency of the Most Frequent Element");
            string source = "LC";

            int[] nums1 = {1,2,4};
            int k1 = 5;
            int[] nums2 = {1,4,8,13};
            int k2 = 5;
            int[] nums3 = {3,9,6};
            int k3 = 2;

            int result1 = LeetCode.FrequencyoftheMostFrequentElement.Solution.MaxFrequency(nums1, k1);
            int result2 = LeetCode.FrequencyoftheMostFrequentElement.Solution.MaxFrequency(nums2, k2);
            int result3 = LeetCode.FrequencyoftheMostFrequentElement.Solution.MaxFrequency(nums3, k3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 2),
                ResultTester.CheckResult<int>(result3, 1)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void HIndexIIFunc()
        {
            Program.Space();
            Program.Title("H-Index II");
            ResultTester.CheckSolution("LC", LeetCode.HIndexII.Test.TestHIndexII());
        }


        private static void KRadiusSubarrayAveragesFunc()
        {
            Program.Space();
            Program.Title("K Radius Subarray Averages");
            string source = "LC";

            int[] nums1 = {7,4,3,9,1,8,5,2,6};
            int k1 = 3;
            int[] nums2 = {100000};
            int k2 = 0;
            int[] nums3 = {8};
            int k3 = 100000;

            int[] result1 = LeetCode.KRadiusSubarrayAverages.Solution.GetAverages(nums1, k1);
            int[] result2 = LeetCode.KRadiusSubarrayAverages.Solution.GetAverages(nums2, k2);
            int[] result3 = LeetCode.KRadiusSubarrayAverages.Solution.GetAverages(nums3, k3);
            int[] case1 = {-1,-1,-1,5,4,4,-1,-1,-1};
            int[] case2 = {100000};
            int[] case3 = {-1};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, case1),
                ResultTester.CheckResult<int[]>(result2, case2),
                ResultTester.CheckResult<int[]>(result3, case3)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void FindMinimuminRotatedSortedArrayIIFunc()
        {
            Program.Space();
            Program.Title("Find Minimum in Rotated Sorted Array II");
            ResultTester.CheckSolution("LC", LeetCode.FindMinimuminRotatedSortedArrayII.Test.TestFindMinimuminRotatedSortedArrayII());
        }


        private static void NumberofWaystoReorderArraytoGetSameBSTFunc()
        {
            Program.Space();
            Program.Title("Number of Ways to Reorder Array to Get Same BST");
            string source = "LC";

            int[] nums1 = {2,1,3};
            int[] nums2 = {3,4,5,1,2};
            int[] nums3 = {1,2,3};

            int result1 = LeetCode.NumberofWaystoReorderArraytoGetSameBST.Solution.NumOfWays(nums1);
            int result2 = LeetCode.NumberofWaystoReorderArraytoGetSameBST.Solution.NumOfWays(nums2);
            int result3 = LeetCode.NumberofWaystoReorderArraytoGetSameBST.Solution.NumOfWays(nums3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 1),
                ResultTester.CheckResult<int>(result2, 5),
                ResultTester.CheckResult<int>(result3, 0)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void LongestArithmeticSubsequenceFunc()
        {
            Program.Space();
            Program.Title("Number of Ways to Reorder Array to Get Same BST");
            string source = "LC";
            ResultTester.CheckSolution(source, LeetCode.LongestArithmeticSubsequence.Test.TestLongestArithmeticSubsequence());
        }


        private static void TallestBillboardFunc()
        {
            Program.Space();
            Program.Title("Tallest Billboard");
            ResultTester.CheckSolution("LC", LeetCode.TallestBillboard.Test.TestTallestBillboard());
        }


        private static void VerifyinganAlienDictionaryFunc()
        {
            Program.Space();
            Program.Title("Verifying an Alien Dictionary");
            ResultTester.CheckSolution("LC", LeetCode.VerifyinganAlienDictionary.Test.TestVerifyinganAlienDictionary());
        }


        private static void MinimumLimitofBallsinaBagFunc()
        {
            Program.Space();
            Program.Title("Minimum Limit of Balls in a Bag");
            string source = "LC";

            int[] nums1 = {9};
            int maxOperations1 = 2;
            int[] nums2 = {2,4,8,2};
            int maxOperations2 = 4;

            int result1 = LeetCode.MinimumLimitofBallsinaBag.Solution.MinimumSize(nums1, maxOperations1);
            int result2 = LeetCode.MinimumLimitofBallsinaBag.Solution.MinimumSize(nums2, maxOperations2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MagneticForceBetweenTwoBallsFunc()
        {
            Program.Space();
            Program.Title("Magnetic Force Between Two Balls");
            string source = "LC";

            int[] position1 = {1,2,3,4,7};
            int m1 = 3;
            int[] position2 = {5,4,3,2,1,1000000000};
            int m2 = 2;

            int result1 = LeetCode.MagneticForceBetweenTwoBalls.Solution.MaxDistance(position1, m1);
            int result2 = LeetCode.MagneticForceBetweenTwoBalls.Solution.MaxDistance(position2, m2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 999999999)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void FindaPeakElementIIFunc()
        {
            Program.Space();
            Program.Title("Find a Peak Element II");
            string source = "LC";

            int[][] mat1 = new int[][]
            {
                new int[] { 1, 4 },
                new int[] { 3, 2 }
            };
            int[][] mat2 = new int[][]
            {
                new int[] { 10, 20, 15 },
                new int[] { 21, 30, 14 },
                new int[] { 7, 16, 32 }
            };

            int[] result1 = LeetCode.FindaPeakElementII.Solution.FindPeakGrid(mat1);
            int[] result2 = LeetCode.FindaPeakElementII.Solution.FindPeakGrid(mat2);
            int[] expected1 = {0,1};
            int[] expected2 = {1,1};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1),
                ResultTester.CheckResult<int[]>(result2, expected2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void FindtheStudentthatWillReplacetheChalkFunc()
        {
            Program.Space();
            Program.Title("Find the Student that Will Replace the Chalk");
            string source = "LC";

            int[] chalk1 = {5,1,5};
            int k1 = 22;
            int[] chalk2 = {3,4,1,2};
            int k2 = 25;
            int result1 = LeetCode.FindtheStudentthatWillReplacetheChalk.Solution.ChalkReplacer(chalk1, k1);
            int result2 = LeetCode.FindtheStudentthatWillReplacetheChalk.Solution.ChalkReplacer(chalk2, k2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 0),
                ResultTester.CheckResult<int>(result2, 1)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void FindKClosestElementsFunc()
        {
            Program.Space();
            Program.Title("Find K Closest Elements");
            ResultTester.CheckSolution("LC", LeetCode.FindKClosestElements.Test.TestFindKClosestElements());
        }


        private static void DetectCapitalFunc()
        {
            Program.Space();
            Program.Title("Detect Capital");
            ResultTester.CheckSolution("LC", LeetCode.DetectCapital.Test.TestDetectCapital());
        }


        private static void RandomPickwithWeightFunc()
        {
            Program.Space();
            Program.Title("Random Pick with Weight");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SellDiminishingValuedColoredBallsFunc()
        {
            Program.Space();
            Program.Title("Sell Diminishing-Valued Colored Balls");
            string source = "LC";

            int[] inventory1 = {2,5};
            int orders1 = 4;
            int[] inventory2 = {3,5};
            int orders2 = 6;
            int result1 = LeetCode.SellDiminishingValuedColoredBalls.Solution.MaxProfit(inventory1, orders1);
            int result2 = LeetCode.SellDiminishingValuedColoredBalls.Solution.MaxProfit(inventory2, orders2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 14),
                ResultTester.CheckResult<int>(result2, 19)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void AvoidFloodinTheCityFunc()
        {
            Program.Space();
            Program.Title("Avoid Flood in The City");
            string source = "LC";

            int[] rains1 = {1,2,3,4};
            int[] rains2 = {1,2,0,0,2,1};
            int[] expected1 = {-1,-1,-1,-1};
            int[] expected2 = {-1,-1,2,1,-1,-1};
            int[] result1 = LeetCode.AvoidFloodinTheCity.Solution.AvoidFlood(rains1);
            int[] result2 = LeetCode.AvoidFloodinTheCity.Solution.AvoidFlood(rains2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1),
                ResultTester.CheckResult<int[]>(result2, expected2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void RunningSumof1dArrayFunc()
        {
            Program.Space();
            Program.Title("Running Sum of 1d Array");
            string source = "LC";
            int[] nums = {1,2,3,4};
            int[] result1 = LeetCode.RunningSumof1dArray.Solution.RunningSum(nums);
            int[] expected1 = {1,3,6,10};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void OpentheLockFunc()
        {
            Program.Space();
            Program.Title("Open the Lock");
            ResultTester.CheckSolution("LC", LeetCode.OpentheLock.Test.TestOpentheLock());
        }


        private static void LongestRepeatingCharacterReplacementFunc()
        {
            Program.Space();
            Program.Title("Longest Repeating Character Replacement");
            ResultTester.CheckSolution("LC", LeetCode.LongestRepeatingCharacterReplacement.Test.TestLongestRepeatingCharacterReplacement());
        }


        private static void SwappingNodesinaLinkedListFunc()
        {
            Program.Space();
            Program.Title("Swapping Nodes in a Linked List");
            string source = "LC";
            ResultTester.SpecialTestCase(source);
        }


        private static void CheckingExistenceofEdgeLengthLimitedPathsFunc()
        {
            Program.Space();
            Program.Title("Checking Existence of Edge Length Limited Paths");
            string source = "LC";
            int n1 = 3;
            int[][] edgeList1 = new int[][]
            {
                new int[] { 0,1,2 },
                new int[] { 1,2,4 },
                new int[] { 2,0,8 },
                new int[] { 1,0,16 }
            };

            int[][] queries1 = new int[][]
            {
                new int[] { 0, 1, 2 },
                new int[] { 0, 2, 5 }
            };

            int n2 = 5;
            int[][] edgeList2 = new int[][]
            {
                new int[] {0,1,10},
                new int[] {1,2,5},
                new int[] {2,3,9},
                new int[] {3,4,13}
            };

            int[][] queries2 = new int[][]
            {
                new int[] {0,4,14},
                new int[] {1,4,13}
            };

            bool[] result1 = LeetCode.CheckingExistenceofEdgeLengthLimitedPaths.Solution.DistanceLimitedPathsExist(n1, edgeList1, queries1);
            bool[] expected1 = {false, true};
            bool[] result2 = LeetCode.CheckingExistenceofEdgeLengthLimitedPaths.Solution.DistanceLimitedPathsExist(n2, edgeList2, queries2);
            bool[] expected2 = {true, false};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool[]>(result1, expected1),
                ResultTester.CheckResult<bool[]>(result2, expected2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MinimizeDeviationinArrayFunc()
        {
            Program.Space();
            Program.Title("Minimize Deviation in Array");
            string source = "LC";
            ResultTester.SpecialTestCase(source);
        }


        private static void RichestCustomerWealthFunc()
        {
            Program.Space();
            Program.Title("Richest Customer Wealth");
            string source = "LC";
            int[][] accounts1 = new int[][]
            {
                new int[]{1, 2, 3},
                new int[]{3,2,1}
            };
            int[][] accounts2 = new int[][]
            {
                new int[]{1,5},
                new int[]{7,3},
                new int[]{3,5}
            };
            int[][] accounts3 = new int[][]
            {
                new int[]{2,8,7},
                new int[]{7,1,3},
                new int[]{1,9,5}
            };
            int result1 = LeetCode.RichestCustomerWealth.Solution.MaximumWealth(accounts1);
            int result2 = LeetCode.RichestCustomerWealth.Solution.MaximumWealth(accounts2);
            int result3 = LeetCode.RichestCustomerWealth.Solution.MaximumWealth(accounts3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 6),
                ResultTester.CheckResult<int>(result2, 10),
                ResultTester.CheckResult<int>(result3, 17)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void IntegerBreakFunc()
        {
            Program.Space();
            Program.Title("Integer Break");
            ResultTester.CheckSolution("LC", LeetCode.IntegerBreak.Test.TestIntegerBreak());
        }


        private static void JumpGameIIIFunc()
        {
            Program.Space();
            Program.Title("Jump Game III");
            ResultTester.CheckSolution("LC", LeetCode.JumpGameIII.Test.TestJumpGameIII());
        }


        private static void SubstringWithLargestVarianceFunc()
        {
            Program.Space();
            Program.Title("Substring With Largest Variance");
            string source = "LC";

            string string1 = "aababbb";
            string string2 = "abcde";
            int result1 = LeetCode.SubstringWithLargestVariance.Solution.LargestVariance(string1);
            int result2 = LeetCode.SubstringWithLargestVariance.Solution.LargestVariance(string2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 0)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MaximalNetworkRankFunc()
        {
            Program.Space();
            Program.Title("Maximal Network Rank");
            string source = "LC";

            int n1 = 4;
            int[][] roads1 = new int[][]
            {
                new int[] {0,1},
                new int[] {0,3},
                new int[] {1,2},
                new int[] {1,3}
            };
            int n2 = 5;
            int[][] roads2 = new int[][]
            {
                new int[] {0,1},
                new int[] {0,3},
                new int[] {1,2},
                new int[] {1,3},
                new int[] {2,3},
                new int[] {2,4}
            };
            int n3 = 8;
            int[][] roads3 = new int[][]
            {
                new int[] {0,1},
                new int[] {1,2},
                new int[] {2,3},
                new int[] {2,4},
                new int[] {5,6},
                new int[] {5,7}
            };
            int result1 = LeetCode.MaximalNetworkRank.Solution.MaximalNetworkRank(n1, roads1);
            int result2 = LeetCode.MaximalNetworkRank.Solution.MaximalNetworkRank(n2, roads2);
            int result3 = LeetCode.MaximalNetworkRank.Solution.MaximalNetworkRank(n3, roads3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 4),
                ResultTester.CheckResult<int>(result2, 5),
                ResultTester.CheckResult<int>(result3, 5)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void CountAllPossibleRoutesFunc()
        {
            Program.Space();
            Program.Title("Count All Possible Routes");
            string source = "LC";
            int[] locations1 = {2,3,6,8,4}; int start1 = 1; int finish1 = 3; int fuel1 = 5;
            int[] locations2 = {4,3,1}; int start2 = 1; int finish2 = 0; int fuel2 = 6;
            int[] locations3 = {5,2,1}; int start3 = 0; int finish3 = 2; int fuel3 = 3;
            int result1 = LeetCode.CountAllPossibleRoutes.Solution.CountRoutes(locations1, start1, finish1, fuel1);
            int result2 = LeetCode.CountAllPossibleRoutes.Solution.CountRoutes(locations2, start2, finish2, fuel2);
            int result3 = LeetCode.CountAllPossibleRoutes.Solution.CountRoutes(locations3, start3, finish3, fuel3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 4),
                ResultTester.CheckResult<int>(result2, 5),
                ResultTester.CheckResult<int>(result3, 0)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MinimumJumpstoReachHomeFunc()
        {
            Program.Space();
            Program.Title("Minimum Jumps to Reach Home");
            string source = "LC";
            int[] forbidden1 = {14,4,18,1,15}; int a1 = 3; int b1 = 15; int x1 = 9;
            int[] forbidden2 = {8,3,16,6,12,20}; int a2 = 15; int b2 = 13; int x2 = 11;
            int[] forbidden3 = {1,6,2,14,5,17,4}; int a3 = 16; int b3 = 9; int x3 = 7;
            int result1 = LeetCode.MinimumJumpstoReachHome.Solution.MinimumJumps(forbidden1, a1, b1, x1);
            int result2 = LeetCode.MinimumJumpstoReachHome.Solution.MinimumJumps(forbidden2, a2, b2, x2);
            int result3 = LeetCode.MinimumJumpstoReachHome.Solution.MinimumJumps(forbidden3, a3, b3, x3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, -1),
                ResultTester.CheckResult<int>(result3, 2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void NextGreaterElementIIIFunc()
        {
            Program.Space();
            Program.Title("Next Greater Element III");
            ResultTester.CheckSolution("LC", LeetCode.NextGreaterElementIII.Test.TestNextGreaterElementIII());
        }


        private static void SmallestRangeIIFunc()
        {
            Program.Space();
            Program.Title("Smallest Range II");            
            ResultTester.CheckSolution("LC", LeetCode.SmallestRangeII.Test.TestSmallestRangeII());
        }


        private static void LongestArithmeticSubsequenceofGivenDifferenceFunc()
        {
            Program.Space();
            Program.Title("Longest Arithmetic Subsequence of Given Difference");
            string source = "LC";
            int[] arr1 = {1,2,3,4}; int difference1 = 1;
            int[] arr2 = {1,3,5,7}; int difference2 = 1;
            int[] arr3 = {1,5,7,8,5,3,4,2,1}; int difference3 = -2;
            int result1 = LeetCode.LongestArithmeticSubsequenceofGivenDifference.Solution.LongestSubsequence(arr1, difference1);
            int result2 = LeetCode.LongestArithmeticSubsequenceofGivenDifference.Solution.LongestSubsequence(arr2, difference2);
            int result3 = LeetCode.LongestArithmeticSubsequenceofGivenDifference.Solution.LongestSubsequence(arr3, difference3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 4),
                ResultTester.CheckResult<int>(result2, 1),
                ResultTester.CheckResult<int>(result3, 4)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void MinimumCosttoMakeArrayEqualFunc()
        {
            Program.Space();
            Program.Title("Minimum Cost to Make Array Equal");
            string source = "LC";
            int[] nums1 = {1,3,5,2}; int[] cost1 = {2,3,1,14};
            int[] nums2 = {2,2,2,2,2}; int[] cost2 = {4,2,8,1,3};
            double result1 = LeetCode.MinimumCosttoMakeArrayEqual.Solution.MinCost(nums1, cost1);
            double result2 = LeetCode.MinimumCosttoMakeArrayEqual.Solution.MinCost(nums2, cost2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double>(result1, 8),
                ResultTester.CheckResult<double>(result2, 0)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void SubsetsIIFunc()
        {
            Program.Space();
            Program.Title("Subsets II");
            string source = "LC";
            int[] nums1 = {1,2,2};
            int[] nums2 = {0};
            IList<IList<int>>? result1 = LeetCode.SubsetsII.Solution.SubsetsWithDup(nums1);
            IList<IList<int>>? result2 = LeetCode.SubsetsII.Solution.SubsetsWithDup(nums2);
            ResultTester.SpecialTestCase(source);
        }


        private static void MaximumNumberofEventsThatCanBeAttendedIIFunc()
        {
            Program.Space();
            Program.Title("Maximum Number of Events That Can Be Attended II");
            string source = "LC";
            int[][] events1 = new int[][]
            {
                new int[] { 1, 2, 4 },
                new int[] { 3, 4, 3 },
                new int[] { 2, 3, 1 }
            };
            int k1 = 2;
            int[][] events2 = new int[][]
            {
                new int[] { 1, 2, 4 },
                new int[] { 3, 4, 3 },
                new int[] { 2, 3, 10 }
            };
            int k2 = 2;
            int[][] events3 = new int[][]
            {
                new int[] { 1, 1, 1, },
                new int[] { 2, 2, 2 },
                new int[] { 3, 3, 3 },
                new int[] { 4, 4, 4 }
            };
            int k3 = 3;
            int result1 = LeetCode.MaximumNumberofEventsThatCanBeAttendedII.Solution.MaxValue(events1, k1);
            int result2 = LeetCode.MaximumNumberofEventsThatCanBeAttendedII.Solution.MaxValue(events2, k2);
            int result3 = LeetCode.MaximumNumberofEventsThatCanBeAttendedII.Solution.MaxValue(events3, k3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 7),
                ResultTester.CheckResult<int>(result2, 10),
                ResultTester.CheckResult<int>(result3, 9)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void DesignParkingSystemFunc()
        {
            Program.Space();
            Program.Title("Design Parking System");
            ResultTester.SpecialTestCase("LC");
        }

        
        private static void MergeSortedArrayFunc()
        {
            Program.Space();
            Program.Title("Merge Sorted Array");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CombinationsFunc()
        {
            Program.Space();
            Program.Title("Combinations");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SmallestSufficientTeamFunc()
        {
            Program.Space();
            Program.Title("Smallest Sufficient Team");
            string source = "LC";
            ResultTester.CheckSolution(source, LeetCode.SmallestSufficientTeam.Test.TestSmallestSufficientTeam());
        }


        private static void ThreeSumClosestFunc()
        {
            Program.Space();
            Program.Title("3Sum Closest");
            ResultTester.CheckSolution("LC", LeetCode.ThreeSumClosest.Test.TestThreeSumClosest());
        }


        private static void PartitionEqualSubsetSumFunc()
        {
            Program.Space();
            Program.Title("Partition Equal Subset Sum");
            ResultTester.CheckSolution("LC", LeetCode.PartitionEqualSubsetSum.Test.TestPartitionEqualSubsetSum());
        }


        private static void BusRoutesFunc()
        {
            Program.Space();
            Program.Title("Bus Routes");
            ResultTester.CheckSolution("LC", LeetCode.BusRoutes.Test.TestBusRoutes());
        }


        private static void CourseScheduleIIFunc()
        {
            Program.Space();
            Program.Title("Course Schedule II");
            ResultTester.CheckSolution("LC", LeetCode.CourseScheduleII.Test.TestCourseScheduleII());
        }


        private static void BasicCalculatorIIFunc()
        {
            Program.Space();
            Program.Title("Basic Calculator II");
            ResultTester.CheckSolution("LC", LeetCode.BasicCalculatorII.Test.TestBasicCalculatorII());
        }


        private static void CombinationSumFunc()
        {
            Program.Space();
            Program.Title("Combination Sum");
            string source = "LC";
            int[] candidates1 = {2,3,6,7};
            int target1 = 7;
            int[] candidates2 = {2,3,5};
            int target2 = 8;
            int[] candidates3 = {2};
            int target3 = 1;
            IList<IList<int>> expected1 = new List<IList<int>>
            {
                new List<int> { 2, 2, 3 },
                new List<int> { 7 }
            };
            IList<IList<int>> expected2 = new List<IList<int>>
            {
                new List<int> { 2, 2, 2, 2 },
                new List<int> { 2, 3, 3 },
                new List<int> { 3, 5 }
            };
            IList<IList<int>> expected3 = new List<IList<int>>
            {
                new List<int> { }
            };
            IList<IList<int>> result1 = LeetCode.CombinationSum.Solution.CombinationSum(candidates1, target1);
            IList<IList<int>> result2 = LeetCode.CombinationSum.Solution.CombinationSum(candidates2, target2);
            IList<IList<int>> result3 = LeetCode.CombinationSum.Solution.CombinationSum(candidates3, target3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<int>>>(result1, expected1),
                ResultTester.CheckResult<IList<IList<int>>>(result2, expected2),
                ResultTester.CheckResult<IList<IList<int>>>(result3, expected3)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void RotateListFunc()
        {
            Program.Space();
            Program.Title("Rotate List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SpiralMatrixFunc()
        {
            Program.Space();
            Program.Title("Spiral Matrix");
            ResultTester.CheckSolution("LC", LeetCode.SpiralMatrix.Test.TestSpiralMatrix());
        }


        private static void SpiralMatrixIIFunc()
        {
            Program.Space();
            Program.Title("Spiral Matrix II");
            ResultTester.CheckSolution("LC", LeetCode.SpiralMatrixII.Test.TestSpiralMatrixII());
        }


        private static void CopyListwithRandomPointerFunc()
        {
            Program.Space();
            Program.Title("Copy List with Random Pointer");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ArithmeticSubarraysFunc()
        {
            Program.Space();
            Program.Title("Arithmetic Subarrays");
            string source = "LC";
            int[] nums1 = {4,6,5,9,3,7};
            int[] l1 = {0,0,2};
            int[] r1 = {2,3,5};
            int[] nums2 = {-12,-9,-3,-12,-6,15,20,-25,-20,-15,-10};
            int[] l2 = {0,1,6,4,8,7};
            int[] r2 = {4,4,9,7,9,10};
            IList<bool> result1 = LeetCode.ArithmeticSubarrays.Solution.CheckArithmeticSubarrays(nums1, l1, r1);
            IList<bool> result2 = LeetCode.ArithmeticSubarrays.Solution.CheckArithmeticSubarrays(nums2, l2, r2);
            IList<bool> expected1 = new List<bool> { true, false, true };
            IList<bool> expected2 = new List<bool> { false,true,false,false,true,true };
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<bool>>(result1, expected1),
                ResultTester.CheckResult<IList<bool>>(result2, expected2)
            };
            ResultTester.CheckSolution(source, results);
        }


        private static void SeatReservationManagerFunc()
        {
            Program.Space();
            Program.Title("Seat Reservation Manager");
            string source = "LC";
            ResultTester.SpecialTestCase(source);
        }


        private static void LastDayWhereYouCanStillCrossFunc()
        {
            Program.Space();
            Program.Title("Last Day Where You Can Still Cross");
            string source = "LC";
            ResultTester.CheckSolution(source, LeetCode.LastDayWhereYouCanStillCross.Test.TestLastDayWhereYouCanStillCroww());
        }


        private static void TopKFrequentWordsFunc()
        {
            Program.Space();
            Program.Title("Top K Frequent Words");
            ResultTester.CheckSolution("LC", LeetCode.TopKFrequentWords.Test.TestTopKFrequentWords());
        }


        private static void NextGreaterElementIIFunc()
        {
            Program.Space();
            Program.Title("Next Greater Element II");
            ResultTester.CheckSolution("LC", LeetCode.NextGreaterElementII.Test.TestNextGreaterElementII());
        }


        private static void OnlineElectionFunc()
        {
            Program.Space();
            Program.Title("Online Election");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ConstructQuadTreeFunc()
        {
            Program.Space();
            Program.Title("Construct Quad Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MinimumGeneticMutationFunc()
        {
            Program.Space();
            Program.Title("Minimum Genetic Mutation");
            ResultTester.CheckSolution("LC", LeetCode.MinimumGeneticMutation.Test.TestMinimumGeneticMutation());
        }


        private static void IntervalListIntersectionsFunc()
        {
            Program.Space();
            Program.Title("Interval List Intersections");
            ResultTester.CheckSolution("LC", LeetCode.IntervalListIntersections.Test.TestIntervalListIntersections());
        }


        private static void LinkedListinBinaryTreeFunc()
        {
            Program.Space();
            Program.Title("Linked List in Binary Tree");
            string source = "LC";
            ResultTester.SpecialTestCase(source);
        }


        private static void KnightProbabilityinChessboardFunc()
        {
            Program.Space();
            Program.Title("Knight Probability in Chessboard");
            ResultTester.CheckSolution("LC", LeetCode.KnightProbabilityinChessboard.Test.TestKnightProbabilityinChessboard());
        }


        private static void PossibleBipartitionFunc()
        {
            Program.Space();
            Program.Title("Possible Bipartition");
            ResultTester.SpecialTestCase("LC");
        }


        private static void AllPossibleFullBinaryTreesFunc()
        {
            Program.Space();
            Program.Title("All Possible Full Binary Trees");
            string source = "LC";
            ResultTester.SpecialTestCase(source);
        }


        private static void PopulatingNextRightPointersinEachNodeIFunc()
        {
            Program.Space();
            Program.Title("Populating Next Right Pointers in Each Node I");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PopulatingNextRightPointersinEachNodeIIFunc()
        {
            Program.Space();
            Program.Title("Populating Next Right Pointers in Each Node II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ShortestPathtoGetAllKeysFunc()
        {
            Program.Space();
            Program.Title("Shortest Path to Get All Keys");
            string source = "LC";
            ResultTester.CheckSolution(source, LeetCode.ShortestPathtoGetAllKeys.Test.TestShortestPathtoGetAllKeys());
        }


        private static void WaterandJugProblemFunc()
        {
            Program.Space();
            Program.Title("Water and Jug Problem");
            ResultTester.CheckSolution("LC", LeetCode.WaterandJugProblem.Test.TestWaterandJugProblem());
        }


        private static void MaximumNumberofAchievableTransferRequestsFunc()
        {
            Program.Space();
            Program.Title("Maximum Number of Achievable Transfer Requests");
            string source = "LC";
            ResultTester.CheckSolution(source, LeetCode.MaximumNumberofAchievableTransferRequests.Test.TestMaximumNumberofAchievableTransferRequests());
        }


        private static void DesignBrowserHistoryFunc()
        {
            Program.Space();
            Program.Title("Design Browser History");
            string source = "LC";
            ResultTester.SpecialTestCase(source);
        }


        private static void CountGoodNodesinBinaryTreeFunc()
        {
            Program.Space();
            Program.Title("Count Good Nodes in Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DataStreamasDisjointIntervalsFunc()
        {
            Program.Space();
            Program.Title("Data Stream as Disjoint Intervals");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MinimumTimetoCollectAllApplesinaTreeFunc()
        {
            Program.Space();
            Program.Title("Minimum Time to Collect All Apples in a Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void IntersectionofTwoArraysIIFunc()
        {
            Program.Space();
            Program.Title("Intersection of Two Arrays II");
            ResultTester.CheckSolution("LC", LeetCode.IntersectionofTwoArraysII.Test.TestIntersectionofTwoArraysII());
        }


        private static void StrangePrinterFunc()
        {
            Program.Space();
            Program.Title("Strange Printer");
            ResultTester.CheckSolution("LC", LeetCode.StrangePrinter.Test.TestStrangePrinter());
        }


        private static void TopKFrequentElementsFunc()
        {
            Program.Space();
            Program.Title("Top K Frequent Elements");
            ResultTester.CheckSolution("LC", LeetCode.TopKFrequentElements.Test.TestTopKFrequentElements());
        }


        private static void MaximumWidthofBinaryTreeFunc()
        {
            Program.Space();
            Program.Title("Maximum Width of Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ConvertNumberToReversedArrayOfDigitsFunc()
        {
            Program.Space();
            Program.Title("Convert number to reversed array of digits");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.ConvertNumberToReversedArrayOfDigits.Test.TestConvertNumberToReversedArrayOfDigits());
        }


        private static void BeginnerLostWithoutaMapFunc()
        {
            Program.Space();
            Program.Title("Beginner - Lost Without a Map");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.BeginnerLostWithoutaMap.Test.TestBeginnerLostWithoutaMap());
        }


        private static void SearchSuggestionsSystemFunc()
        {
            Program.Space();
            Program.Title("Search Suggestions System");
            string[] products1 = {"mobile","mouse","moneypot","monitor","mousepad"}; string searchWord1 = "mouse";
            string[] products2 = {"havana"}; string searchWord2 = "havana";
            IList<IList<string>> result1 = LeetCode.SearchSuggestionsSystem.Solution.SuggestedProducts(products1, searchWord1);
            IList<IList<string>> result2 = LeetCode.SearchSuggestionsSystem.Solution.SuggestedProducts(products2, searchWord2);
            IList<IList<string>> input1 = new List<IList<string>>
            {
                new List<string> { "mobile", "moneypot", "monitor" },
                new List<string> { "mobile", "moneypot", "monitor" },
                new List<string> { "mouse", "mousepad" },
                new List<string> { "mouse", "mousepad" },
                new List<string> { "mouse", "mousepad" }
            };
            IList<IList<string>> input2 = new List<IList<string>>
            {
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<string>>>(result1, input1),
                ResultTester.CheckResult<IList<IList<string>>>(result2, input2),
            };
            ResultTester.CheckSolution("LC", results);
        }


        private static void FirstMissingPositiveFunc()
        {
            Program.Space();
            Program.Title("First Missing Positive");
            ResultTester.CheckSolution("LC", LeetCode.FirstMissingPositive.Test.TestFirstMissingPositive());
        }


        private static void CheapestFlightsWithinKStopsFunc()
        {
            Program.Space();
            Program.Title("Cheapest Flights Within K Stops");
            ResultTester.CheckSolution("LC", LeetCode.CheapestFlightsWithinKStops.Test.TestCheapestFlightsWithinKStops());
        }


        private static void PredicttheWinnerFunc()
        {
            Program.Space();
            Program.Title("Predict the Winner");
            ResultTester.CheckSolution("LC", LeetCode.PredicttheWinner.Test.TestPredicttheWinner());
        }


        private static void ConcatenatedWordsFunc()
        {
            Program.Space();
            Program.Title("Concatenated Words");
            ResultTester.CheckSolution("LC", LeetCode.ConcatenatedWords.Test.TestConcatenatedWords());
        }


        private static void AbbreviateaTwoWordNameFunc()
        {
            Program.Space();
            Program.Title("Abbreviate a Two Word Name");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.AbbreviateaTwoWordName.Solution.TestAbbreviateaTwoWordName());
        }


        private static void BeginnerSeries2ClockFunc()
        {
            Program.Space();
            Program.Title("Beginner Series #2 Clock");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.BeginnerSeries2Clock.Solution.TestBeginnerSeries2Clock());
        }

        
        private static void PathwithMaximumProbabilityFunc()
        {
            Program.Space();
            Program.Title("Pathwith Maximum Probability");
            ResultTester.CheckSolution("LC", LeetCode.PathwithMaximumProbability.Test.TestPathwithMaximumProbability());
        }


        private static void SubarrayProductLessThanKFunc()
        {
            Program.Space();
            Program.Title("Subarray Product Less Than K");
            ResultTester.CheckSolution("LC", LeetCode.SubarrayProductLessThanK.Test.TestSubarrayProductLessThanK());
        }


        private static void MaximumSideLengthofaSquarewithSumLessthanorEqualtoThresholdFunc()
        {
            Program.Space();
            Program.Title("Maximum Side Length of a Square with Sum Less than or Equal to Threshold");
            ResultTester.CheckSolution("LC", LeetCode.MaximumSideLengthofaSquarewithSumLessthanorEqualtoThreshold.Test.TestMaximumSideLengthofaSquarewithSumLessthanorEqualtoThreshold());
        }

        
        private static void NthTribonacciNumberFunc()
        {
            Program.Space();
            Program.Title("Nth Tribonacci Number");
            ResultTester.CheckSolution("LC", LeetCode.NthTribonacciNumber.Test.TestNthTribonacciNumber());
        }


        private static void NondecreasingSubsequencesFunc()
        {
            Program.Space();
            Program.Title("Non-decreasing Subsequences");
            ResultTester.CheckSolution("LC", LeetCode.NondecreasingSubsequences.Test.TestNondecreasingSubsequences());
        }


        private static void BFSofgraphFunc()
        {
            Program.Space();
            Program.Title("BFS of graph");
            ResultTester.SpecialTestCase("GFG");
        }

        private static void LFUCacheFunc()
        {
            Program.Space();
            Program.Title("LFU Cache");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PlusMinusFunc()
        {
            Program.Space();
            Program.Title("Plus Minus");
            ResultTester.CheckSolution("HR", HackerRank.PlusMinus.Test.TestPlusMinus());
        }


        private static void MiddleoftheLinkedListFunc()
        {
            Program.Space();
            Program.Title("Middle of the Linked List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SumofDistancesinTreeFunc()
        {
            Program.Space();
            Program.Title("Sum of Distances in Tree");
            ResultTester.CheckSolution("LC", LeetCode.SumofDistancesinTree.Test.TestSumofDistancesinTree());
        }


        private static void IndexingFunc()
        {
            Program.Space();
            Program.Title("Indexing");
            ResultTester.CheckSolution("CC", CodeChef.Indexing.Test.TestIndexing());
        }


        private static void AlternatingDigitSumFunc()
        {
            Program.Space();
            Program.Title("Alternating Digit Sum");
            ResultTester.CheckSolution("LC", LeetCode.AlternatingDigitSum.Test.TestAlternatingDigitSum());
        }


        private static void ImplementQueueusingStacksFunc()
        {
            Program.Space();
            Program.Title("Implement Queue using Stacks");
            ResultTester.SpecialTestCase("LC");
        } 


        private static void InvertBinaryTreeFunc()
        {
            Program.Space();
            Program.Title("Invert Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void TeamFunc()
        {
            Program.Space();
            Program.Title("Team");
            ResultTester.CheckSolution("CF", CodeForces.Team.Test.TestTeam());
        }


        private static void WayTooLongWordsFunc()
        {
            Program.Space();
            Program.Title("Way Too Long Words");
            ResultTester.SpecialTestCase("CF");
        }


        private static void PascalsTriangleFunc()
        {
            Program.Space();
            Program.Title("Pascals Triangle");
            ResultTester.SpecialTestCase("LC");
        }


        private static void WatermelonFunc()
        {
            Program.Space();
            Program.Title("Watermelon");
            ResultTester.SpecialTestCase("CF");
        }


        private static void ConstructBinaryTreefromInorderandPostorderTraversalFunc()
        {
            Program.Space();
            Program.Title("Construct Binary Tree from In order and Post order Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaximumSubarrayFunc()
        {
            Program.Space();
            Program.Title("Maximum Subarray");
            ResultTester.CheckSolution("LC", LeetCode.MaximumSubarray.Test.TestMaximumSubarray());
        }


        private static void RemoveNthNodeFromEndofListFunc()
        {
            Program.Space();
            Program.Title("Remove Nth Node From End of List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void LetterCombinationsofaPhoneNumberFunc()
        {
            Program.Space();
            Program.Title("Letter Combinations of a Phone Number");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ZigzagConversionFunc()
        {
            Program.Space();
            Program.Title("Zigzag Conversion");
            ResultTester.CheckSolution("LC", LeetCode.ZigzagConversion.Test.TestZigzagConversion());
        }


        private static void AddTwoNumbersFunc()
        {
            Program.Space();
            Program.Title("Add Two Numbers");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaximumIntersectingLinesFunc()
        {
            Program.Space();
            Program.Title("Maximum Intersecting Lines");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void CountSpecialNumbersFunc()
        {
            Program.Space();
            Program.Title("Count Special Numbers");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void KnightInGeeklandFunc()
        {
            Program.Space();
            Program.Title("Knight In Geekland");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void BTSMaximumDifferenceFunc()
        {
            Program.Space();
            Program.Title("BTS Maximum Difference");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void MakeTheArrayBeautifulFunc()
        {
            Program.Space();
            Program.Title("Make The Array Beautiful");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void FrogsAndJumpFunc()
        {
            Program.Space();
            Program.Title("Frogs And Jump");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void SquaringAnArgumentFunc()
        {
            Program.Space();
            Program.Title("Squaring An Argument");
            ResultTester.SpecialTestCase("CW");
        }


        private static void ReturningStringsFunc()
        {
            Program.Space();
            Program.Title("Returning Strings");
            ResultTester.SpecialTestCase("CW");
        }


        private static void ReturnToSanityFunc()
        {
            Program.Space();
            Program.Title("Return To Sanity");
            ResultTester.SpecialTestCase("CW");
        }


        private static void ReturnHelloWorldFunc()
        {
            Program.Space();
            Program.Title("Return Hello World");
            ResultTester.SpecialTestCase("CW");
        }


        // CURRENT TESTS
        private static void CurrentTests()
        {
            
        }
    }
}