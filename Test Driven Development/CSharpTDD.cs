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
            FindMinAndMaxOfListFunc, StringRepeatFunc, SumOfPositiveFunc, ConvertbooleanvaluestostringsYesorNoFunc, ConvertaNumbertoaStringFunc, ANeedleintheHaystackFunc,
            EvenOrOddFunc, SquareNSumFunc, FindthesmallestintegerinthearrayFunc, RemoveStringSpacesFunc, CountingsheepFunc, ConvertaStringtoaNumberFunc, MakeUpperCaseFunc,
            BeginnerSeries2ClockFunc, OppositesAttractFunc, SquaringAnArgumentFunc, ReturningStringsFunc, ReturnToSanityFunc, ReturnHelloWorldFunc, BeginnerSeries1SchoolPaperworkFunc,
            YouCantCodeUnderPressure1Func, CenturyFromYearFunc, BasicMathematicalOperationsFunc, ConvertNumberToReversedArrayOfDigitsFunc, AbbreviateaTwoWordNameFunc, SimplemultiplicationFunc,
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
            StringOperationsFunc, IndexingFunc, AccessingcharactersofaStringFunc, StringOperationsSTRS7Func, EnormousInputTestFunc, GoodTurnFunc, AddTwoNumbersCCFunc, UserInputUsrs1Func, USRS2IntegerInputFunc, HelloUserFunc,
            CalculatorFunc, MiletoKilometerConvertorFunc,
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
            BestPokerHandFunc, LastStoneWeightFunc, AddDigitsFunc, BulbSwitcherFunc, FindtheDifferenceFunc, RepeatedSubstringPatternFunc, VerifyinganAlienDictionaryFunc, MinimumAbsoluteDifferenceinBSTFunc, BackspaceStringCompareFunc,
            MoveZeroesFunc, PlusOneFunc, AverageSalaryExcludingtheMinimumandMaximumSalaryFunc, FindifPathExistsinGraphFunc, RichestCustomerWealthFunc, NumberofRecentCallsFunc, LongestPalindromeFunc, BuddyStringsFunc,
            SignoftheProductofanArrayFunc, CanMakeArithmeticProgressionFunc, MonotonicArrayFunc, LengthofLastWordFunc, ToLowerCaseFunc, ConvertBinaryNumberinaLinkedListtoIntegerFunc, FirstBadVersionFunc, SubtreeofAnotherTreeFunc,
            FindSmallestLetterGreaterThanTargetFunc, CountNegativeNumbersinaSortedMatrixFunc, ValidPerfectSquareFunc, ArrangingCoinsFunc, BaseballGameFunc, KeysandRoomsFunc, SumofLeftLeavesFunc, BinaryTreeInorderTraversalFunc,
            RobotReturntoOriginFunc, FindWinneronaTicTacToeGameFunc, LemonadeChangeFunc, LargestPerimeterTriangleFunc, CheckIfItIsaStraightLineFunc, DeleteColumnstoMakeSortedFunc, GuessNumberHigherorLowerFunc,
            ReverseVowelsofaStringFunc, CountingBitsFunc, IsSubsequenceFunc, MinCostClimbingStairsFunc, MaximumAverageSubarrayIFunc, DesignParkingSystemFunc, LeafSimilarTreesFunc, IntersectionofTwoArraysIIFunc,
            FindtheHighestAltitudeFunc, FindPivotIndexFunc, UniqueNumberofOccurrencesFunc, MajorityElementFunc, GoalParserInterpretationFunc, AddtoArrayFormofIntegerFunc, DetectCapitalFunc, ValidAnagramFunc, ImplementStackusingQueuesFunc,
            FloodFillFunc, HappyNumberFunc, DecryptStringfromAlphabettoIntegerMappingFunc, TheKWeakestRowsinaMatrixFunc, CheckifOneStringSwapCanMakeStringsEqualFunc, MergeTwoBinaryTreesFunc, BinaryTreePreorderTraversalFunc,
            SubtracttheProductandSumofDigitsofanIntegerFunc, SpecialArrayWithXElementsGreaterThanorEqualXFunc, SqrtxFunc, FindtheDistanceValueBetweenTwoArraysFunc, SortColorsFunc, ReverseStringFunc, IntersectionofTwoLinkedListsFunc,
            SumofAllOddLengthSubarraysFunc, NextGreaterElementIFunc, SquaresofaSortedArrayFunc, FibonacciNumberFunc, FindNearestPointThatHastheSameXorYCoordinateFunc, NaryTreePreorderTraversalFunc, MaximumAscendingSubarraySumFunc,
            Numberof1BitsFunc, SortIntegersbyTheNumberof1BitsFunc, SearchinRotatedSortedArrayFunc, PowerofTwoFunc, ReverseWordsinaStringIIIFunc, GreatestCommonDivisorofStringsFunc, RansomNoteFunc, ValidParenthesesFunc,
            ReverseBitsFunc, MaximumValueofaStringinanArrayFunc, SummaryRangesFunc, FindtheDifferenceofTwoArraysFunc, IntegerBreakFunc, NthTribonacciNumberFunc, KthLargestElementinaStreamFunc, MergeTwoSortedListsFunc,
            InvertBinaryTreeFunc, IsomorphicStringsFunc, RemoveLinkedListElementsFunc, LinkedListCycleFunc, PascalsTriangleFunc, PathSumFuncFunc, MaximumDepthofBinaryTreeFunc, RemoveDuplicatesfromSortedListFunc,
        };

        private static Delegate[] leetCodeMediumList = new Delegate[]
        {
            RestoreIpAddressesFunc, SnakesAndLaddersFunc, FindClosestNodetoGivenTwoNodesFunc, FruitIntoBasketsFunc, JumpGameIIFunc, AllPathsFromSourcetoTargetFunc, MagneticForceBetweenTwoBallsFunc, PredicttheWinnerFunc, SubarraySumsDivisiblebyKFunc, ImplementQueueusingStacksFunc, SwapNodesinPairsFunc, ExtraCharactersinaStringFunc,
            AsFarfromLandasPossibleFunc, ShortestPathWithAlternatingColorsFunc, MinimumFuelCosttoReporttotheCapitalFunc, SingleElementinaSortedArrayFunc, CapacityToShipPackagesWithinDDaysFunc, DesignUndergroundSystemFunc, CheckCompletenessofaBinaryTreeFunc, BinaryTreeRightSideViewFunc, GenerateParenthesesFunc,
            SortanArrayFunc, StringCompressionFunc, MinimumTimetoCompleteTripsFunc, KokoEatingBananasFunc, ImplementTriePrefixTreeFunc, CountSubIslandsFunc, KRadiusSubarrayAveragesFunc, SeatReservationManagerFunc, MaximumLevelSumofaBinaryTreeFunc, LowestCommonAncestorofaBinaryTreeFunc, RemoveNthNodeFromEndofListFunc,
            NumberofZeroFilledSubarraysFunc, MinimumScoreofaPathBetweenTwoCitiesFunc, NumberofOperationstoMakeNetworkConnectedFunc, ReorderRoutestoMakeAllPathsLeadtotheCityZeroFunc, CountUnreachablePairsofNodesinanUndirectedGraphFunc, NondecreasingSubsequencesFunc, HouseRobberFunc, ValidSudokuFunc, AddTwoNumbersFunc,
            MinimumPathSumFunc, PrimeSubtractionOperationFunc, MinimumCostForTicketsFunc, SuccessfulPairsofSpellsandPotionsFunc, BoatstoSavePeopleFunc, HIndexIIFunc, FindaPeakElementIIFunc, WaterandJugProblemFunc, ShortestPathinBinaryMatrixFunc, OddEvenLinkedListFunc, GasStationFunc, PermutationsFunc, RotateImageFunc,
            OptimalPartitionofStringFunc, MinimizeMaximumofArrayFunc, NumberofEnclavesFunc, RemoveStarsFunc, NumberofClosedIslandsFunc, RangeSumofSortedSubarraySumsFunc, SellDiminishingValuedColoredBallsFunc, PermutationsIIFunc, CheapestFlightsWithinKStopsFunc, LowestCommonAncestorofaBinarySearchTreeFunc, CombinationSumIVFunc,
            SimplifyPathFunc, ValidateStackSequencesFunc, LongestPalindromicSubsequenceFunc, NonoverlappingIntervalsFunc, RobotBoundedInCircleFunc, MinimumSizeSubarraySumFunc, OpentheLockFunc, DesignBrowserHistoryFunc, RottingOrangesFunc, ConstructQuadTreeFunc, BinaryTreePostorderTraversalFunc, BullsandCowsFunc,
            MatrixDiagonalSumFunc, MultiplyStringsFunc, PowxnFunc, ReverseWordsinaStringFunc, ProductofArrayExceptSelfFunc, WaystoSplitArrayIntoThreeSubarraysFunc, FindKClosestElementsFunc, PopulatingNextRightPointersinEachNodeIIFunc, AddTwoNumbersIIFunc, PeekingIteratorFunc, SpiralMatrixFunc, ZigzagConversionFunc,
            Dota2SenateFunc, MinimumFlipstoMakeaORbEqualtocFunc, BestTimetoBuyandSellStockwithTransactionFeeFunc, IncreasingTripletSubsequenceFunc, MaximumNumberofVowelsinaSubstringofGivenLengthFunc, SearchSuggestionsSystemFunc, MaximumWidthofBinaryTreeFunc, ReverseLinkedListFunc, SpiralMatrixIIFunc, SingleNumberIIFunc,
            DominoandTrominoTilingFunc, ContainerWithMostWaterFunc, MaxNumberofKSumPairsFunc, UniquePathsFunc, NearestExitfromEntranceinMazeFunc, FrequencyoftheMostFrequentElementFunc, NumberofNodesintheSubTreeWiththeSameLabelFunc, DeleteNodeinaBSTFunc, HouseRobberIIIFunc, PopulatingNextRightPointersinEachNodeIFunc,
            LongestCommonSubsequenceFunc, MaxIceCreamFunc, TopKFrequentFunc, LexicographicallySmallestEquivalentStringFunc, FlipStringtoMonotoneIncreasingFunc, SearchA2DMatrixFunc, InsertIntervalFunc, MaxSubarraySumCircularFunc, SubarraySumFunc, SubarraysDivByKFunc, LinkedListCycleIIFunc, LetterCombinationsofaPhoneNumberFunc,
            LongestSubstringWithoutRepeatingCharactersFunc, UniquePathsIIFunc, MaximalSquareFunc, JumpGameFunc, PathSumIIFunc, MaximumValueataGivenIndexinaBoundedArrayFunc, BinarySearchTreeIteratorFunc, KthSmallestElementinaBSTFunc, ConstructBinaryTreefromPreorderandInorderTraversalFunc, SmallestNumberinInfiniteSetFunc,
            SnapshotArrayFunc, LongestIncreasingSubsequenceFunc, WiggleSubsequenceFunc, LongestPalindromicSubstringFunc, RangeSumQuery2DImmutableFunc, BestTimetoBuyandSellStockIIFunc, BestSightseeingPairFunc, MatrixBlockSumFunc, MaximumProductSubarrayFunc, MaximumLengthofSubarrayWithPositiveProductFunc, PartitionLabelsFunc,
            FindtheWinneroftheCircularGameFunc, RemoveDuplicatesfromSortedListIIFunc, DesignLinkedListFunc, MinStackFunc, CoinChangeFunc, CoinChangeIIFunc, MinimumRoundstoCompleteAllTasksFunc, SolvingQuestionsWithBrainpowerFunc, MaximumTwinSumofaLinkedListFunc, DeletetheMiddleNodeofaLinkedListFunc, GroupAnagramsFunc,
            MaxConsecutiveOnesIIIFunc, LongestSubarrayof1sAfterDeletingOneElementFunc, NumberofProvincesFunc, NumberofSubsequencesThatSatisfytheGivenSumConditionFunc, AsteroidCollisionFunc, IntervalListIntersectionsFunc, OnlineStockSpanFunc, EvaluateDivisionFunc, DesignAddandSearchWordsDataStructureFunc, PartitionListFunc,
            FindPeakElementFunc, WateringPlantsIIFunc, CarPoolingFunc, CountWaysToBuildGoodStringsFunc, TotalCosttoHireKWorkersFunc, PacificAtlanticWaterFlowFunc, FindtheStudentthatWillReplacetheChalkFunc, JumpGameIIIFunc, DailyTemperaturesFunc, DecodeStringFunc, EvaluateReversePolishNotationFunc, SubsetsFunc,
            MaximumSubsequenceScoreFunc, KthLargestElementinanArrayFunc, EqualRowandColumnPairsFunc, DetermineifTwoStringsAreCloseFunc, IsGraphBipartiteFunc, MinimumLimitofBallsinaBagFunc, AllPossibleFullBinaryTreesFunc, LetterCasePermutationFunc, TopKFrequentElementsFunc, ConvertSortedListtoBinarySearchTreeFunc,
            NextPermutationFunc, ShortestBridgeFunc, FindtheDuplicateNumberFunc, New21GameFunc, FindMinimuminRotatedSortedArrayFunc, NumberofIslandsFunc, LongestArithmeticSubsequenceFunc, MaximalNetworkRankFunc, UncrossedLinesFunc, MinimumNumberofArrowstoBurstBalloonsFunc, BinaryTreeLevelOrderTraversalFunc, ShuffleanArrayFunc,
            StoneGameIIFunc, CourseScheduleFunc, ThreeSumFunc, PeakIndexinaMountainArrayFunc, DeleteandEarnFunc, SearchinRotatedSortedArrayIIFunc, ValidTriangleNumberFunc, RandomPickwithWeightFunc, CountGoodNodesinBinaryTreeFunc, DesignCircularQueueFunc, CombinationSumIIIFunc, ValidateBinarySearchTreeFunc, PerfectSquaresFunc,
            TwoSumIIInputArrayIsSortedFunc, FindFirstandLastPositionofElementinSortedArrayFunc, MergeIntervalsFunc, TimeNeededtoInformAllEmployeesFunc, SumofSquareNumbersFunc, AvoidFloodinTheCityFunc, KnightProbabilityinChessboardFunc, FindAllAnagramsinaStringFunc, PalindromePartitioningFunc, MaximumSubarrayFunc,
            DecodeWaysFunc, ArithmeticSlicesFunc, RotateArrayFunc, UglyNumberIIFunc, UniqueBinarySearchTreesFunc, FindRightIntervalFunc, ShortestSubarraytobeRemovedtoMakeArraySortedFunc, SwappingNodesinaLinkedListFunc, PossibleBipartitionFunc, LinkedListRandomNodeFunc, SumRoottoLeafNumbersFunc, UglyNumberIIIFunc,
            MaximumDistanceBetweenaPairofValuesFunc, WordBreakFunc, ZeroOneMatrixFunc, MaxAreaofIslandFunc, TriangleFunc, MostProfitAssigningWorkFunc, CountCompleteTreeNodesFunc, LongestRepeatingCharacterReplacementFunc, InsertintoaBinarySearchTreeFunc, HouseRobberIIFunc, BinaryTreeZigzagLevelOrderTraversalFunc,
            NextGreaterElementIIIFunc, SubsetsIIFunc, MinimumNumberofVerticestoReachAllNodesFunc, BasicCalculatorIIFunc, TopKFrequentWordsFunc, NextGreaterElementIIFunc, LinkedListinBinaryTreeFunc, MaximumSideLengthofaSquarewithSumLessthanorEqualtoThresholdFunc, CloneGraphFunc, CombinationsFunc, SurroundedRegionsFunc,
            SmallestRangeIIFunc, BestTeamWithNoConflictsFunc, ThreeSumClosestFunc, CombinationSumFunc, CopyListwithRandomPointerFunc, MinimumGeneticMutationFunc, LongestZigZagPathinaBinaryTreeFunc, SubarrayProductLessThanKFunc, PermutationinStringFunc, BestTimetoBuyandSellStockwithCooldownFunc, SetMatrixZeroesFunc,
            LongestArithmeticSubsequenceofGivenDifferenceFunc, PartitionEqualSubsetSumFunc, RotateListFunc, ArithmeticSubarraysFunc, OnlineElectionFunc, MinimumTimetoCollectAllApplesinaTreeFunc, PathwithMaximumProbabilityFunc, FindDuplicateSubtreesFunc, PathSumIIIFunc, ConstructBinaryTreefromInorderandPostorderTraversalFunc,
            MinimumRemovetoMakeValidParenthesesFunc, FindEventualSafeStatesFunc, NaryTreeLevelOrderTraversalFunc, FlattenNestedListIteratorFunc, UniqueBinarySearchTreesIIFunc, FindLatestGroupofSizeMFunc, ReorderListFunc, ShortestPathVisitingAllNodesFunc, SortCharactersByFrequencyFunc, SumofMutatedArrayClosesttoTargetFunc,
            KClosestPointstoOriginFunc, CheckifThereisaValidPartitionForTheArrayFunc, MaximumLengthofPairChainFunc, MinimumPenaltyforaShopFunc, InterleavingStringFunc, MinimumSpeedtoArriveonTimeFunc, MinimumNumberofDaystoMakemBouquetsFunc, FairDistributionofCookiesFunc,
            MinimizetheMaximumDifferenceofPairsFunc, TimeBasedKeyValueStoreFunc, DeleteOperationforTwoStringsFunc, BitwiseANDofNumbersRangeFunc,
        };

        private static Delegate[] leetCodeHardList = new Delegate[]
        {
            CountDigitOneFunc, LongestPathWithDifferentAdjacentCharactersFunc, CheckifPointIsReachableFunc, NamingaCompanyFunc, IPOFunc, EditDistanceFunc, CountSubarraysWithFixedBoundsFunc, JumpGameIVFunc, LongestCycleinaGraphFunc, NumberofWaysofCuttingaPizzaFunc, FindMinimuminRotatedSortedArrayIIFunc, NumberofMusicPlaylistsFunc, WordLadderFunc,
            ReducingDishesFunc, ScrambleStringFunc, MinimumReverseOperationsFunc, LargestColorValueinaDirectedGraphFunc, MaximumValueofKCoinsFromPilesFunc, NumberofWaystoFormaTargetStringGivenaDictionaryFunc, ProfitableSchemesFunc, MinimumInsertionStepstoMakeaStringPalindromeFunc, RestoreTheArrayFunc, FindtheLongestValidObstacleCourseatEachPositionFunc,
            MaximizeScoreAfterNOperationsFunc, StoneGameIIIFunc, MinimumCosttoCutaStickFunc, TrappingRainWaterFunc, NumberofGoodPathsFunc, SerializeandDeserializeBinaryTreeFunc, ReverseNodesinkGroupFunc, MakeArrayStrictlyIncreasingFunc, NumberofIncreasingPathsinaGridFunc, FrogJumpFunc,
            NumberofWaystoReorderArraytoGetSameBSTFunc, TallestBillboardFunc, CheckingExistenceofEdgeLengthLimitedPathsFunc, MinimizeDeviationinArrayFunc, SubstringWithLargestVarianceFunc, MergekSortedListsFunc,
            CountAllPossibleRoutesFunc, MinimumJumpstoReachHomeFunc, BusRoutesFunc, StrangePrinterFunc, SumofDistancesinTreeFunc, DataStreamasDisjointIntervalsFunc, MinimumNumberofTapstoOpentoWateraGardenFunc,
            MinimumCosttoMakeArrayEqualFunc, RemoveMaxNumberofEdgestoKeepGraphFullyTraversableFunc, FirstMissingPositiveFunc, LFUCacheFunc, BinaryTreeMaximumPathSumFunc,
            MaximumNumberofEventsThatCanBeAttendedIIFunc, SmallestSufficientTeamFunc, MaximumNumberofAchievableTransferRequestsFunc, MaxPointsonaLineFunc,
            CourseScheduleIIFunc, LastDayWhereYouCanStillCrossFunc, ShortestPathtoGetAllKeysFunc, SimilarStringGroupsFunc, ConcatenatedWordsFunc, SlidingWindowMaximumFunc,
            FindCriticalandPseudoCriticalEdgesinMinimumSpanningTreeFunc, MinimumReplacementstoSorttheArrayFunc,
        };

        private static Delegate[] hackerRankEasyList = new Delegate[]
        {
            SimpleArraySumFunc, SolveMeFirstFunc, AVeryBigSumFunc, CompareTheTripletsFunc, DiagonalDifferenceFunc, PlusMinusFunc, StaircaseFunc,
        };

        private static Delegate[] hackerRankMediumList = new Delegate[]
        {
            
        };

        private static Delegate[] hackerRankHardList = new Delegate[]
        {
            FormingaMagicSquareFunc, AshtonandStringFunc,
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
            StringPermutationsFunc,
        };

        private static Delegate[] geeksForGeeksMediumList = new Delegate[]
        {
            StringrporprFunc, EvenSwapFunc, MinimumStepsRequiredFunc, AddMinimumCharactersFunc, MaximumLengthFunc, RemoveandReverseFunc, ShyGeek, MaximumIntersectingLinesFunc, KnightInGeeklandFunc, CountSpecialNumbersFunc, BTSMaximumDifferenceFunc,
            ReverseaStackFunc,
        };

        private static Delegate[] geeksForGeeksHardList = new Delegate[]
        {
            SpecialDigitsFunc, DivideInIncrementialGroupsFunc, SolvetheSudokuFunc,
        };

        private static Delegate[] codeForces800List = new Delegate[]
        {
            TeamFunc, WayTooLongWordsFunc, WatermelonFunc, NextRoundFunc, DominoPilingFunc, BitPPFunc, BeautifulMatrixFunc, PetyaandStringsFunc, HelpfulMathsFunc,
        };

        private static Delegate[] coderByteEasyList = new Delegate[]
        {
            FirstFactorialFunc, FirstReverseFunc,
        };

        private static Delegate[] coderByteMediumList = new Delegate[]
        {
            MinWindowSubstringFunc, TreeConstructorFunc, BracketMatcherFunc,
        };

        private static Delegate[] coderByteHardList = new Delegate[]
        {
            BracketCombinationsFunc,
        };

        private static Delegate[] atCoderList = new Delegate[]
        {
            ADisjointSetUnionFunc, BFenwickTreeFunc, CFloorSumFunc, DMaxflowFunc, EMinCostFlowFunc, FConvolutionFunc, GSCCFunc, TwoSATFunc, NumberofSubstringsFunc, SegmentTreeFunc, RangeAffineRangeSumFunc, LazySegmentTreeFunc,
        };


        public static void StartAllTDD()
        {
            // All CoderByte Solutions
            CoderByteTests();

            // All AtCoder Solutions
            AtCoderTests();

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
            // Easy
            InvokeDelegateIfNotNull(coderByteEasyList);

            // Medium
            InvokeDelegateIfNotNull(coderByteMediumList);

            // Hard
            InvokeDelegateIfNotNull(coderByteHardList);
        }


        // ATCODER
        private static void AtCoderTests()
        {
            InvokeDelegateIfNotNull(atCoderList);
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
            Program.Title("Add Two Integers");
            ResultTester.CheckSolution("LC", LeetCode.AddTwoIntegers.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.NumberofStepstoReduceaNumbertoZero.Test.TestNumberofStepstoReduceaNumbertoZero());
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
            ResultTester.CheckSolution("LC", LeetCode.MaximumIceCreamBars.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.LongestPathWithDifferentAdjacentCharacters.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.CheckifPointIsReachable.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.FindClosestNodetoGivenTwoNodes.Test.TestCases());
        }


        private static void ShuffleTheArrayFunc()
        {
            Program.Space();
            Program.Title("Shuffle The Array");
            ResultTester.CheckSolution("LC", LeetCode.ShuffletheArray.Test.TestCases());
        }


        private static void CountOddNumbersInAnIntervalRangeFunc()
        {
            Program.Space();
            Program.Title("Count Odd Numbers in an Interval Range");
            ResultTester.CheckSolution("LC", LeetCode.CountOddNumbersinanIntervalRange.Test.TestCases());
        }


        private static void NumberofNodesintheSubTreeWiththeSameLabelFunc()
        {
            Program.Space();
            Program.Title("Number of Nodes in the Sub-Tree With the Same Label");
            ResultTester.SpecialTestCase("LC");
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
            ResultTester.CheckSolution("LC", LeetCode.NamingaCompany.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.MinimumFuelCosttoReporttotheCapital.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.FindLuckyIntegerinanArray.Test.TestFindLuckyIntegerinanArray());
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


        private static void EnormousInputTestFunc()
        {
            Program.Space();
            Program.Title("Enormous Input Test");
            ResultTester.SpecialTestCase("CC");
        }


        private static void GoodTurnFunc()
        {
            Program.Space();
            Program.Title("Good Turn");
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
            ResultTester.CheckSolution("LC", LeetCode.CountSubarraysWithFixedBounds.Test.TestCases());
        }


        private static void JumpGameIVFunc()
        {
            Program.Space();
            Program.Title("Jump Game IV");
            ResultTester.CheckSolution("LC", LeetCode.JumpGameIV.Test.TestJumpGameIV());
        }


        private static void KthMissingPositiveNumberFunc()
        {
            Program.Space();
            Program.Title("Kth Missing Positive Number");
            ResultTester.CheckSolution("LC", LeetCode.KthMissingPositiveNumber.Test.TestCases());
        }


        private static void MinimumTimetoCompleteTripsFunc()
        {
            Program.Space();
            Program.Title("Minimum Time to Complete Trips");
            ResultTester.CheckSolution("LC", LeetCode.MinimumTimetoCompleteTrips.Test.TestCases());
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


        private static void ANeedleintheHaystackFunc()
        {
            Program.Space();
            Program.Title("A Needle in the Haystack");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.ANeedleintheHaystack.Test.TestCases());
        }


        private static void CanPlaceFlowersFunc()
        {
            Program.Space();
            Program.Title("Can Place Flowers");
            ResultTester.CheckSolution("LC", LeetCode.CanPlaceFlowers.Test.TestCanPlaceFlowers());
        }


        private static void ReverseaStackFunc()
        {
            Program.Space();
            Program.Title("Reverse a Stack");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void NumberofZeroFilledSubarraysFunc()
        {
            Program.Space();
            Program.Title("Number of Zero-Filled Subarrays");
            ResultTester.CheckSolution("LC", LeetCode.NumberofZeroFilledSubarrays.Test.TestCases());
        }


        private static void MinimumScoreofaPathBetweenTwoCitiesFunc()
        {
            Program.Space();
            Program.Title("Minimum Score of a Path Between Two Cities");
            ResultTester.CheckSolution("LC", LeetCode.MinimumScoreofaPathBetweenTwoCities.Test.TestCases());
        }


        private static void NumberofOperationstoMakeNetworkConnectedFunc()
        {
            Program.Space();
            Program.Title("Number of Operations to Make Network Connected");
            ResultTester.CheckSolution("LC", LeetCode.NumberofOperationstoMakeNetworkConnected.Test.TestNumberofOperationstoMakeNetworkConnected());
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
            ResultTester.CheckSolution("LC", LeetCode.ReorderRoutestoMakeAllPathsLeadtotheCityZero.Test.TestCases());
        }


        private static void CountUnreachablePairsofNodesinanUndirectedGraphFunc()
        {
            Program.Space();
            Program.Title("Count Unreachable Pairs of Nodes in an Undirected Graph");
            ResultTester.CheckSolution("LC", LeetCode.CountUnreachablePairsofNodesinanUndirectedGraph.Test.TestCases());
        }


        private static void LongestCycleinaGraphFunc()
        {
            Program.Space();
            Program.Title("Longest Cycle in a Graph");
            ResultTester.CheckSolution("LC", LeetCode.LongestCycleinaGraph.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.PrimeSubtractionOperation.Test.TestCase());
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
            ResultTester.CheckSolution("LC", LeetCode.KItemsWiththeMaximumSum.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.NumberofWaysofCuttingaPizza.Test.TestCases());
        }


        private static void ReducingDishesFunc()
        {
            Program.Space();
            Program.Title("Reducing Dishes");
            ResultTester.CheckSolution("LC", LeetCode.ReducingDishes.Test.TestReducingDishes());
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
            ResultTester.CheckSolution("LC", LeetCode.SuccessfulPairsofSpellsandPotions.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.OptimalPartitionofString.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.MinimizeMaximumofArray.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.RemovingStarsFromaString.Test.TestCases());
        }


        private static void NumberofClosedIslandsFunc()
        {
            Program.Space();
            Program.Title("Number of Closed Islands");
            ResultTester.CheckSolution("LC", LeetCode.NumberofClosedIslands.Test.TestNumberofClosedIslands());
        }


        private static void CheckIfNandItsDoubleExistFunc()
        {
            Program.Space();
            Program.Title("Check If N and Its Double Exist");
            ResultTester.CheckSolution("LC", LeetCode.CheckIfNandItsDoubleExist.Test.TestCheckIfNandItsDoubleExist());
        }


        private static void MinimumReverseOperationsFunc()
        {
            Program.Space();
            Program.Title("Minimum Reverse Operations");
            ResultTester.CheckSolution("LC", LeetCode.MinimumReverseOperations.Test.TestCase());
        }


        private static void LargestColorValueinaDirectedGraphFunc()
        {
            Program.Space();
            Program.Title("Largest Color Value in a Directed Graph");
            ResultTester.CheckSolution("LC", LeetCode.LargestColorValueinaDirectedGraph.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.MaximumValueofKCoinsFromPiles.Test.TestCases());
        }


        private static void ConcatenationofArrayFunc()
        {
            Program.Space();
            Program.Title("Concatenation of Array");
            ResultTester.CheckSolution("LC", LeetCode.ConcatenationofArray.Test.TestCases());
        }


        private static void NumberofWaystoFormaTargetStringGivenaDictionaryFunc()
        {
            Program.Space();
            Program.Title("Number of Ways to Form a Target String Given a Dictionary");
            ResultTester.CheckSolution("LC", LeetCode.NumberofWaystoFormaTargetStringGivenaDictionary.Test.TestCases());
        }


        private static void BestTeamWithNoConflictsFunc()
        {
            Program.Space();
            Program.Title("Best Team With No Conflicts");
            ResultTester.CheckSolution("LC", LeetCode.BestTeamWithNoConflicts.Test.TestCases());
        }


        private static void KidsWiththeGreatestNumberofCandiesFunc()
        {
            Program.Space();
            Program.Title("Kids With the Greatest Number of Candies");
            ResultTester.CheckSolution("LC", LeetCode.KidsWiththeGreatestNumberofCandies.Test.TestKidsWiththeGreatestNumberofCandies());
        }


        private static void MergeStringsAlternatelyFunc()
        {
            Program.Space();
            Program.Title("Merge Strings Alternately");
            ResultTester.CheckSolution("LC", LeetCode.MergeStringsAlternately.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.MinimumInsertionStepstoMakeaStringPalindrome.Test.TestDecryptStringfromAlphabettoIntegerMapping());
        }


        private static void BestPokerHandFunc()
        {
            Program.Space();
            Program.Title("Best Poker Hand");
            ResultTester.CheckSolution("LC", LeetCode.BestPokerHand.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.RestoreTheArray.Test.TestRestoreTheArray());
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
            ResultTester.CheckSolution("LC", LeetCode.AverageSalaryExcludingtheMinimumandMaximumSalary.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.SignoftheProductofanArray.Test.TestCases());
        }


        private static void CanMakeArithmeticProgressionFunc()
        {
            Program.Space();
            Program.Title("Can Make Arithmetic Progression From Sequence");
            ResultTester.CheckSolution("LC", LeetCode.CanMakeArithmeticProgressionFromSequence.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.CountNegativeNumbersinaSortedMatrix.Test.TestCountNegativeNumbersinaSortedMatrix());
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
            ResultTester.CheckSolution("LC", LeetCode.FindWinneronaTicTacToeGame.Test.TestFindWinneronaTicTacToeGame());
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
            ResultTester.CheckSolution("LC", LeetCode.MatrixDiagonalSum.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.CheckIfItIsaStraightLine.Test.TestCheckIfItIsaStraightLine());
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
            ResultTester.CheckSolution("LC", LeetCode.MinimumFlipstoMakeaORbEqualtoc.Test.TestMinimumFlipstoMakeaORbEqualtoc());
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
            ResultTester.CheckSolution("LC", LeetCode.MaximumNumberofVowelsinaSubstringofGivenLength.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.MaxNumberofKSumPairs.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.LongestSubarrayof1sAfterDeletingOneElement.Test.TestCases());
        }


        private static void FindtheHighestAltitudeFunc()
        {
            Program.Space();
            Program.Title("Find the Highest Altitude");
            ResultTester.CheckSolution("LC", LeetCode.FindtheHighestAltitude.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.NumberofSubsequencesThatSatisfytheGivenSumCondition.Test.TestCases());
        }


        private static void FindtheLongestValidObstacleCourseatEachPositionFunc()
        {
            Program.Space();
            Program.Title("Number of Subsequences That Satisfy the Given Sum Condition");
            ResultTester.CheckSolution("LC", LeetCode.FindtheLongestValidObstacleCourseatEachPosition.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.MaximizeScoreAfterNOperations.Test.TestCases());
        }


        private static void MaximumAscendingSubarraySumFunc()
        {
            Program.Space();
            Program.Title("Maximum Ascending Subarray Sum");
            ResultTester.CheckSolution("LC", LeetCode.MaximumAscendingSubarraySum.Test.TestCases());
        }


        private static void UserInputUsrs1Func()
        {
            Program.Space();
            Program.Title("User Input USRS 1");
            ResultTester.SpecialTestCase("CC");
        }


        private static void NextRoundFunc()
        {
            Program.Space();
            Program.Title("Next Round");
            ResultTester.CheckSolution("CF", CodeForces.NextRound.Test.TestCases());
        }


        private static void WateringPlantsIIFunc()
        {
            Program.Space();
            Program.Title("Watering Plants II");
            ResultTester.CheckSolution("LC", LeetCode.WateringPlantsII.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.CountWaysToBuildGoodStrings.Test.TestCases());
        }


        private static void TotalCosttoHireKWorkersFunc()
        {
            Program.Space();
            Program.Title("Total Cost to Hire K Workers");
            ResultTester.CheckSolution("LC", LeetCode.TotalCosttoHireKWorkers.Test.TestCases());
        }


        private static void MaximumSubsequenceScoreFunc()
        {
            Program.Space();
            Program.Title("Maximum Subsequence Score");
            ResultTester.CheckSolution("LC", LeetCode.MaximumSubsequenceScore.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.EqualRowandColumnPairs.Test.TestCases());
        }


        private static void UniqueNumberofOccurrencesFunc()
        {
            Program.Space();
            Program.Title("Unique Number of Occurrences");
            ResultTester.CheckSolution("LC", LeetCode.UniqueNumberofOccurrences.Test.TestUniqueNumberofOccurrences());
        }


        private static void DetermineifTwoStringsAreCloseFunc()
        {
            Program.Space();
            Program.Title("Determine if Two Strings Are Close");
            ResultTester.CheckSolution("LC", LeetCode.DetermineifTwoStringsAreClose.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.StoneGameIII.Test.TestStoneGameIII());
        }


        private static void MinimumCosttoCutaStickFunc()
        {
            Program.Space();
            Program.Title("Minimum Cost to Cut a Stick");
            ResultTester.CheckSolution("LC", LeetCode.MinimumCosttoCutaStick.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.GoalParserInterpretation.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.DecryptStringfromAlphabettoIntegerMapping.Test.TestDecryptStringfromAlphabettoIntegerMapping());
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
            ResultTester.CheckSolution("LC", LeetCode.TheKWeakestRowsinaMatrix.Test.TestTheKWeakestRowsinaMatrix());
        }


        private static void CheckifOneStringSwapCanMakeStringsEqualFunc()
        {
            Program.Space();
            Program.Title("Check if One String Swap Can Make Strings Equal");
            ResultTester.CheckSolution("LC", LeetCode.CheckifOneStringSwapCanMakeStringsEqual.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.SubtracttheProductandSumofDigitsofanInteger.Test.TestSubtracttheProductandSumofDigitsofanInteger());
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
            ResultTester.CheckSolution("LC", LeetCode.SpecialArrayWithXElementsGreaterThanorEqualX.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.FindtheDistanceValueBetweenTwoArrays.Test.TestFindtheDistanceValueBetweenTwoArrays());
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
            ResultTester.SpecialTestCase("LC");
        }


        private static void TimeNeededtoInformAllEmployeesFunc()
        {
            Program.Space();
            Program.Title("Time Needed to Inform All Employees");
            ResultTester.CheckSolution("LC", LeetCode.TimeNeededtoInformAllEmployees.Test.TestTimeNeededtoInformAllEmployees());
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
            ResultTester.CheckSolution("LC", LeetCode.SumofAllOddLengthSubarrays.Test.TestCases());
        }


        private static void RemoveMaxNumberofEdgestoKeepGraphFullyTraversableFunc()
        {
            Program.Space();
            Program.Title("Remove Max Number of Edges to Keep Graph Fully Traversable");
            ResultTester.SpecialTestCase("LC");
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
            ResultTester.CheckSolution("LC", LeetCode.FindNearestPointThatHastheSameXorYCoordinate.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.SortIntegersbyTheNumberof1Bits.Test.TestSortIntegersbyTheNumberof1Bits());
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
            ResultTester.CheckSolution("LC", LeetCode.MaximumDistanceBetweenaPairofValues.Test.TestCases());
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
            ResultTester.CheckSolution("HR", HackerRank.AVeryBigSum.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.MaximumValueataGivenIndexinaBoundedArray.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.MaximumValueofaStringinanArray.Test.TestCases());
        }


        private static void SnapshotArrayFunc()
        {
            Program.Space();
            Program.Title("Maximum Value of a String in an Array");
            ResultTester.SpecialTestCase("LC");
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
            ResultTester.CheckSolution("LC", LeetCode.MatrixBlockSum.Test.TestMatrixBlockSum());
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
            ResultTester.CheckSolution("LC", LeetCode.MaximumLengthofSubarrayWithPositiveProduct.Test.TestCases());
        }


        private static void MinimumNumberofVerticestoReachAllNodesFunc()
        {
            Program.Space();
            Program.Title("Minimum Number of Vertices to Reach All Nodes");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FindtheWinneroftheCircularGameFunc()
        {
            Program.Space();
            Program.Title("Find the Winner of the Circular Game");
            ResultTester.CheckSolution("LC", LeetCode.FindtheWinneroftheCircularGame.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.MinimumRoundstoCompleteAllTasks.Test.TestCases());
        }


        private static void FindtheDifferenceofTwoArraysFunc()
        {
            Program.Space();
            Program.Title("Find the Difference of Two Arrays");
            ResultTester.CheckSolution("LC", LeetCode.FindtheDifferenceofTwoArrays.Test.TestCases());
        }


        private static void SolvingQuestionsWithBrainpowerFunc()
        {
            Program.Space();
            Program.Title("Solving Questions With Brainpower");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaximumTwinSumofaLinkedListFunc()
        {
            Program.Space();
            Program.Title("Maximum Twin Sum of a Linked List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DeletetheMiddleNodeofaLinkedListFunc()
        {
            Program.Space();
            Program.Title("Delete the Middle Node of a Linked List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FindifPathExistsinGraphFunc()
        {
            Program.Space();
            Program.Title("Find if Path Exists in Graph");
            ResultTester.SpecialTestCase("LC");
        }


        private static void NearestExitfromEntranceinMazeFunc()
        {
            Program.Space();
            Program.Title("Nearest Exit from Entrance in Maze");
            ResultTester.CheckSolution("LC", LeetCode.NearestExitfromEntranceinMaze.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.MakeArrayStrictlyIncreasing.Test.TestMakeArrayStrictlyIncreasing());
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
            ResultTester.CheckSolution("LC", LeetCode.WaystoSplitArrayIntoThreeSubarrays.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.NumberofIncreasingPathsinaGrid.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.CountSubIslands.Test.TestCases());
        }


        private static void ShortestSubarraytobeRemovedtoMakeArraySortedFunc()
        {
            Program.Space();
            Program.Title("Shortest Subarray to be Removed to Make Array Sorted");
            ResultTester.CheckSolution("LC", LeetCode.ShortestSubarraytobeRemovedtoMakeArraySorted.Test.TestCases());
        }


        private static void RangeSumofSortedSubarraySumsFunc()
        {
            Program.Space();
            Program.Title("Range Sum of Sorted Subarray Sums");
            ResultTester.CheckSolution("LC", LeetCode.RangeSumofSortedSubarraySums.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.FrequencyoftheMostFrequentElement.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.KRadiusSubarrayAverages.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.NumberofWaystoReorderArraytoGetSameBST.Test.TestCases());
        }


        private static void LongestArithmeticSubsequenceFunc()
        {
            Program.Space();
            Program.Title("Number of Ways to Reorder Array to Get Same BST");
            ResultTester.CheckSolution("LC", LeetCode.LongestArithmeticSubsequence.Test.TestLongestArithmeticSubsequence());
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
            ResultTester.CheckSolution("LC", LeetCode.MinimumLimitofBallsinaBag.Test.TestCases());
        }


        private static void MagneticForceBetweenTwoBallsFunc()
        {
            Program.Space();
            Program.Title("Magnetic Force Between Two Balls");
            ResultTester.CheckSolution("LC", LeetCode.MagneticForceBetweenTwoBalls.Test.TestCases());
        }


        private static void FindaPeakElementIIFunc()
        {
            Program.Space();
            Program.Title("Find a Peak Element II");
            ResultTester.CheckSolution("LC", LeetCode.FindaPeakElementII.Test.TestCases());
        }


        private static void FindtheStudentthatWillReplacetheChalkFunc()
        {
            Program.Space();
            Program.Title("Find the Student that Will Replace the Chalk");
            ResultTester.CheckSolution("LC", LeetCode.FindtheStudentthatWillReplacetheChalk.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.SellDiminishingValuedColoredBalls.Test.TestCases());
        }


        private static void AvoidFloodinTheCityFunc()
        {
            Program.Space();
            Program.Title("Avoid Flood in The City");
            ResultTester.CheckSolution("LC", LeetCode.AvoidFloodinTheCity.Test.TestCases());
        }


        private static void RunningSumof1dArrayFunc()
        {
            Program.Space();
            Program.Title("Running Sum of 1d Array");
            ResultTester.CheckSolution("LC", LeetCode.RunningSumof1dArray.Test.TestCases());
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
            ResultTester.SpecialTestCase("LC");
        }


        private static void CheckingExistenceofEdgeLengthLimitedPathsFunc()
        {
            Program.Space();
            Program.Title("Checking Existence of Edge Length Limited Paths");
            ResultTester.CheckSolution("LC", LeetCode.CheckingExistenceofEdgeLengthLimitedPaths.Test.TestCases());
        }


        private static void MinimizeDeviationinArrayFunc()
        {
            Program.Space();
            Program.Title("Minimize Deviation in Array");
            ResultTester.SpecialTestCase("LC");
        }


        private static void RichestCustomerWealthFunc()
        {
            Program.Space();
            Program.Title("Richest Customer Wealth");
            ResultTester.CheckSolution("LC", LeetCode.RichestCustomerWealth.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.SubstringWithLargestVariance.Test.TestCases());
        }


        private static void MaximalNetworkRankFunc()
        {
            Program.Space();
            Program.Title("Maximal Network Rank");
            ResultTester.CheckSolution("LC", LeetCode.MaximalNetworkRank.Test.TestCases());
        }


        private static void CountAllPossibleRoutesFunc()
        {
            Program.Space();
            Program.Title("Count All Possible Routes");
            ResultTester.CheckSolution("LC", LeetCode.CountAllPossibleRoutes.Test.TestCases());
        }


        private static void MinimumJumpstoReachHomeFunc()
        {
            Program.Space();
            Program.Title("Minimum Jumps to Reach Home");
            ResultTester.CheckSolution("LC", LeetCode.MinimumJumpstoReachHome.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.LongestArithmeticSubsequenceofGivenDifference.Test.TestLongestArithmeticSubsequenceofGivenDifference());
        }


        private static void MinimumCosttoMakeArrayEqualFunc()
        {
            Program.Space();
            Program.Title("Minimum Cost to Make Array Equal");
            ResultTester.CheckSolution("LC", LeetCode.MinimumCosttoMakeArrayEqual.Test.TestCases());
        }


        private static void SubsetsIIFunc()
        {
            Program.Space();
            Program.Title("Subsets II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaximumNumberofEventsThatCanBeAttendedIIFunc()
        {
            Program.Space();
            Program.Title("Maximum Number of Events That Can Be Attended II");
            ResultTester.CheckSolution("LC", LeetCode.MaximumNumberofEventsThatCanBeAttendedII.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.SmallestSufficientTeam.Test.TestSmallestSufficientTeam());
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
            ResultTester.CheckSolution("LC", LeetCode.CombinationSum.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.ArithmeticSubarrays.Test.TestCases());
        }


        private static void SeatReservationManagerFunc()
        {
            Program.Space();
            Program.Title("Seat Reservation Manager");
            ResultTester.SpecialTestCase("LC");
        }


        private static void LastDayWhereYouCanStillCrossFunc()
        {
            Program.Space();
            Program.Title("Last Day Where You Can Still Cross");
            ResultTester.CheckSolution("LC", LeetCode.LastDayWhereYouCanStillCross.Test.TestLastDayWhereYouCanStillCroww());
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
            ResultTester.SpecialTestCase("LC");
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
            ResultTester.SpecialTestCase("LC");
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
            ResultTester.CheckSolution("LC", LeetCode.ShortestPathtoGetAllKeys.Test.TestShortestPathtoGetAllKeys());
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
            ResultTester.CheckSolution("LC", LeetCode.MaximumNumberofAchievableTransferRequests.Test.TestMaximumNumberofAchievableTransferRequests());
        }


        private static void DesignBrowserHistoryFunc()
        {
            Program.Space();
            Program.Title("Design Browser History");
            ResultTester.SpecialTestCase("LC");
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
            ResultTester.CheckSolution("LC", LeetCode.SearchSuggestionsSystem.Test.TestSearchSuggestionsSystem());
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


        private static void DominoPilingFunc()
        {
            Program.Space();
            Program.Title("Subarray Product Less Than K");
            ResultTester.CheckSolution("CF", CodeForces.DominoPiling.Test.TestCases());
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
            ResultTester.CheckSolution("LC", LeetCode.AlternatingDigitSum.Test.TestCase());
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


        private static void AddTwoNumbersCCFunc()
        {
            Program.Space();
            Program.Title("Add Two Numbers (CodeChef)");
            ResultTester.SpecialTestCase("CC");
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


        private static void BitPPFunc()
        {
            Program.Space();
            Program.Title("Bit++");
            ResultTester.CheckSolution("CF", CodeForces.BitPP.Test.TestCases());
        }


        private static void BuddyStringsFunc()
        {
            Program.Space();
            Program.Title("Buddy Strings");
            ResultTester.CheckSolution("LC", LeetCode.BuddyStrings.Test.TestCase());
        }


        private static void SurroundedRegionsFunc()
        {
            Program.Space();
            Program.Title("Surrounded Regions");
            ResultTester.CheckSolution("LC", LeetCode.SurroundedRegions.Test.TestCases());
        }


        private static void BullsandCowsFunc()
        {
            Program.Space();
            Program.Title("Bulls and Cows");
            ResultTester.CheckSolution("LC", LeetCode.BullsandCows.Test.TestCases());
        }


        private static void MinimumRemovetoMakeValidParenthesesFunc()
        {
            Program.Space();
            Program.Title("Minimum Remove to Make Valid Parentheses");
            ResultTester.CheckSolution("LC", LeetCode.MinimumRemovetoMakeValidParentheses.Test.TestCases());
        }


        private static void FindEventualSafeStatesFunc()
        {
            Program.Space();
            Program.Title("Find Eventual Safe States");
            ResultTester.CheckSolution("LC", LeetCode.FindEventualSafeStates.Test.TestCases());
        }


        private static void NaryTreeLevelOrderTraversalFunc()
        {
            Program.Space();
            Program.Title("N-ary Tree Level Order Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FlattenNestedListIteratorFunc()
        {
            Program.Space();
            Program.Title("Flatten Nested List Iterator");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SingleNumberIIFunc()
        {
            Program.Space();
            Program.Title("Single Number II");
            ResultTester.CheckSolution("LC", LeetCode.SingleNumberII.Test.TestCases());
        }


        private static void UniqueBinarySearchTreesIIFunc()
        {
            Program.Space();
            Program.Title("Unique Binary Search Trees II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void NumberofMusicPlaylistsFunc()
        {
            Program.Space();
            Program.Title("Number of Music Playlists");
            ResultTester.CheckSolution("LC", LeetCode.NumberofMusicPlaylists.Test.TestCases());
        }


        private static void BeginnerSeries1SchoolPaperworkFunc()
        {
            Program.Space();
            Program.Title("Beginner Series #1 School Paperwork");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.BeginnerSeries1SchoolPaperwork.Test.TestCases());
        }


        private static void USRS2IntegerInputFunc()
        {
            Program.Space();
            Program.Title("USRS2 Integer Input");
            ResultTester.CheckSolution("CC", CodeChef.USRS2IntegerInput.Test.TestCases());
        }


        private static void StringPermutationsFunc()
        {
            Program.Space();
            Program.Title("String Permutations");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.StringPermutations.Test.TestCases());
        }


        private static void BeautifulMatrixFunc()
        {
            Program.Space();
            Program.Title("Beautiful Matrix");
            ResultTester.CheckSolution("CF", CodeForces.BeautifulMatrix.Test.TestCases());
        }


        private static void StaircaseFunc()
        {
            Program.Space();
            Program.Title("Staircase");
            ResultTester.CheckSolution("HR", HackerRank.Staircase.Test.TestCases());
        }


        private static void FormingaMagicSquareFunc()
        {
            Program.Space();
            Program.Title("Forming a Magic Square");
            ResultTester.CheckSolution("HR", HackerRank.FormingaMagicSquare.Test.TestCases());
        }


        private static void AshtonandStringFunc()
        {
            Program.Space();
            Program.Title("Ashton and String");
            ResultTester.CheckSolution("HR", HackerRank.AshtonandString.Test.TestCases());
        }


        private static void FindLatestGroupofSizeMFunc()
        {
            Program.Space();
            Program.Title("Find Latest Group of Size M");
            ResultTester.CheckSolution("LC", LeetCode.FindLatestGroupofSizeM.Test.TestCases());
        }


        private static void HelloUserFunc()
        {
            Program.Space();
            Program.Title("Hello User");
            ResultTester.SpecialTestCase("CC");
        }


        private static void PetyaandStringsFunc()
        {
            Program.Space();
            Program.Title("Petya and Strings");
            ResultTester.CheckSolution("CF", CodeForces.PetyaandStrings.Test.TestCases());
        }


        private static void SolvetheSudokuFunc()
        {
            Program.Space();
            Program.Title("Solve the Sudoku");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void ReorderListFunc()
        {
            Program.Space();
            Program.Title("Reorder List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ShortestPathVisitingAllNodesFunc()
        {
            Program.Space();
            Program.Title("Shortest Path Visiting All Nodes");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SortCharactersByFrequencyFunc()
        {
            Program.Space();
            Program.Title("Sort Characters By Frequency");
            ResultTester.CheckSolution("LC", LeetCode.SortCharactersByFrequency.Test.TestCases());
        }


        private static void UglyNumberIIIFunc()
        {
            Program.Space();
            Program.Title("Ugly Number III");
            ResultTester.CheckSolution("LC", LeetCode.UglyNumberIII.Test.TestCases());
        }


        private static void SumofMutatedArrayClosesttoTargetFunc()
        {
            Program.Space();
            Program.Title("Sum of Mutated Array Closest to Target");
            ResultTester.CheckSolution("LC", LeetCode.SumofMutatedArrayClosesttoTarget.Test.TestCases());
        }


        private static void IntersectionofTwoLinkedListsFunc()
        {
            Program.Space();
            Program.Title("Intersection of Two Linked Lists");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SubsetsFunc()
        {
            Program.Space();
            Program.Title("Subsets");
            ResultTester.CheckSolution("LC", LeetCode.Subsets.Test.TestCases());
        }


        private static void GroupAnagramsFunc()
        {
            Program.Space();
            Program.Title("Group Anagrams");
            ResultTester.CheckSolution("LC", LeetCode.GroupAnagrams.Test.TestCases());
        }


        private static void PartitionLabelsFunc()
        {
            Program.Space();
            Program.Title("Partition Labels");
            ResultTester.CheckSolution("LC", LeetCode.PartitionLabels.Test.TestCases());
        }


        private static void SubtreeofAnotherTreeFunc()
        {
            Program.Space();
            Program.Title("Subtree of Another Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CalculatorFunc()
        {
            Program.Space();
            Program.Title("Calculator");
            ResultTester.SpecialTestCase("CC");
        }


        private static void RotateImageFunc()
        {
            Program.Space();
            Program.Title("Rotate Image");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MinimizetheMaximumDifferenceofPairsFunc()
        {
            Program.Space();
            Program.Title("Minimize the Maximum Difference of Pairs");
            ResultTester.CheckSolution("LC", LeetCode.MinimizetheMaximumDifferenceofPairs.Test.TestCase());
        }


        private static void WordLadderFunc()
        {
            Program.Space();
            Program.Title("Word Ladder");
            ResultTester.CheckSolution("LC", LeetCode.WordLadder.Test.TestCase());
        }


        private static void HelpfulMathsFunc()
        {
            Program.Space();
            Program.Title("Helpful Maths");
            ResultTester.CheckSolution("CF", CodeForces.HelpfulMaths.Test.TestCases());
        }


        private static void MakeUpperCaseFunc()
        {
            Program.Space();
            Program.Title("MakeUpperCase");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.MakeUpperCase.Test.TestCases());
        }


        private static void ADisjointSetUnionFunc()
        {
            Program.Space();
            Program.Title("Disjoint Set Union");
            ResultTester.CheckSolution("AC", AtCoder.ADisjointSetUnion.Test.TestCases());
        }


        private static void BFenwickTreeFunc()
        {
            Program.Space();
            Program.Title("Fenwick Tree");
            ResultTester.CheckSolution("AC", AtCoder.BFenwickTree.Test.TestCases());
        }

        
        private static void CFloorSumFunc()
        {
            Program.Space();
            Program.Title("Floor Sum");
            ResultTester.SpecialTestCase("AC");
        }


        private static void DMaxflowFunc()
        {
            Program.Space();
            Program.Title("Max flow");
            ResultTester.SpecialTestCase("AC");
        }


        private static void EMinCostFlowFunc()
        {
            Program.Space();
            Program.Title("Min Cost Flow");
            ResultTester.SpecialTestCase("AC");
        }


        private static void FConvolutionFunc()
        {
            Program.Space();
            Program.Title("Convolution");
            ResultTester.SpecialTestCase("AC");
        }


        private static void SimplemultiplicationFunc()
        {
            Program.Space();
            Program.Title("Simple multiplication");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.Simplemultiplication.Test.TestCases());
        }


        private static void GSCCFunc()
        {
            Program.Space();
            Program.Title("SCC");
            ResultTester.SpecialTestCase("AC");
        }


        private static void KClosestPointstoOriginFunc()
        {
            Program.Space();
            Program.Title("K Closest Points to Origin");
            ResultTester.CheckSolution("LC", LeetCode.KClosestPointstoOrigin.Test.TestCases());
        }


        private static void MiletoKilometerConvertorFunc()
        {
            Program.Space();
            Program.Title("Mile to Kilometer Convertor");
            ResultTester.SpecialTestCase("CC");
        }


        private static void BracketCombinationsFunc()
        {
            Program.Space();
            Program.Title("Bracket Combinations");
            ResultTester.CheckSolution("CB", CoderByte.BracketCombinations.Test.TestCases());
        }


        private static void MinWindowSubstringFunc()
        {
            Program.Space();
            Program.Title("Min Window Substring");
            ResultTester.CheckSolution("CB", CoderByte.MinWindowSubstring.Test.TestCases());
        }


        private static void SlidingWindowMaximumFunc()
        {
            Program.Space();
            Program.Title("Sliding Window Maximum");
            ResultTester.CheckSolution("LC", LeetCode.SlidingWindowMaximum.Test.TestCases());
        }


        private static void PartitionListFunc()
        {
            Program.Space();
            Program.Title("Partition List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CheckifThereisaValidPartitionForTheArrayFunc()
        {
            Program.Space();
            Program.Title("Check if There is a Valid Partition For The Array");
            ResultTester.CheckSolution("LC", LeetCode.CheckifThereisaValidPartitionForTheArray.Test.TestCases());
        }


        private static void PerfectSquaresFunc()
        {
            Program.Space();
            Program.Title("Perfect Squares");
            ResultTester.CheckSolution("LC", LeetCode.PerfectSquares.Test.TestCases());
        }


        private static void CombinationSumIVFunc()
        {
            Program.Space();
            Program.Title("Combination Sum IV");
            ResultTester.CheckSolution("LC", LeetCode.CombinationSumIV.Test.TestCases());
        }


        private static void FindCriticalandPseudoCriticalEdgesinMinimumSpanningTreeFunc()
        {
            Program.Space();
            Program.Title("Find Critical and Pseudo-Critical Edges in Minimum Spanning Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void TwoSATFunc()
        {
            Program.Space();
            Program.Title("Two SAT");
            ResultTester.SpecialTestCase("AC");
        }


        private static void NumberofSubstringsFunc()
        {
            Program.Space();
            Program.Title("Number of Substrings");
            ResultTester.SpecialTestCase("AC");
        }


        private static void TimeBasedKeyValueStoreFunc()
        {
            Program.Space();
            Program.Title("Time Based Key-Value Store");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SegmentTreeFunc()
        {
            Program.Space();
            Program.Title("Segment Tree");
            ResultTester.SpecialTestCase("AC");
        }


        private static void MaximumLengthofPairChainFunc()
        {
            Program.Space();
            Program.Title("Maximum Length of Pair Chain");
            ResultTester.CheckSolution("LC", LeetCode.MaximumLengthofPairChain.Test.TestCases());
        }


        private static void LazySegmentTreeFunc()
        {
            Program.Space();
            Program.Title("Lazy Segment Tree");
            ResultTester.SpecialTestCase("AC");
        }


        private static void RangeAffineRangeSumFunc()
        {
            Program.Space();
            Program.Title("Range Affine Range Sum");
            ResultTester.SpecialTestCase("AC");
        }


        private static void TreeConstructorFunc()
        {
            Program.Space();
            Program.Title("Tree Constructor");
            ResultTester.CheckSolution("CB", CoderByte.TreeConstructor.Test.TestCases());
        }


        private static void MinimumReplacementstoSorttheArrayFunc()
        {
            Program.Space();
            Program.Title("Minimum Replacements to Sort the Array");
            ResultTester.CheckSolution("LC", LeetCode.MinimumReplacementstoSorttheArray.Test.TestCases());
        }


        private static void MinimumPenaltyforaShopFunc()
        {
            Program.Space();
            Program.Title("Minimum Penalty for a Shop");
            ResultTester.CheckSolution("LC", LeetCode.MinimumPenaltyforaShop.Test.TestCases());
        }


        private static void ImplementStackusingQueuesFunc()
        {
            Program.Space();
            Program.Title("Implement Stack using Queues");
            ResultTester.SpecialTestCase("LC");
        }


        private static void BracketMatcherFunc()
        {
            Program.Space();
            Program.Title("Bracket Matcher");
            ResultTester.CheckSolution("CB", CoderByte.BracketMatcher.Test.TestCases());
        }


        private static void ExtraCharactersinaStringFunc()
        {
            Program.Space();
            Program.Title("Extra Characters in a String");
            ResultTester.CheckSolution("LC", LeetCode.ExtraCharactersinaString.Test.TestCases());
        }


        private static void MinimumNumberofTapstoOpentoWateraGardenFunc()
        {
            Program.Space();
            Program.Title("Minimum Number of Taps to Open to Water a Garden");
            ResultTester.CheckSolution("LC", LeetCode.MinimumNumberofTapstoOpentoWateraGarden.Test.TestCases());
        }


        private static void InterleavingStringFunc()
        {
            Program.Space();
            Program.Title("Interleaving String");
            ResultTester.CheckSolution("LC", LeetCode.InterleavingString.Test.TestCases());
        }


        private static void ShuffleanArrayFunc()
        {
            Program.Space();
            Program.Title("Shuffle an Array");
            ResultTester.SpecialTestCase("LC");
        }


        private static void BackspaceStringCompareFunc()
        {
            Program.Space();
            Program.Title("Backspace String Compare");
            ResultTester.CheckSolution("LC", LeetCode.BackspaceStringCompare.Test.TestCases());
        }


        private static void DeleteOperationforTwoStringsFunc()
        {
            Program.Space();
            Program.Title("Delete Operation for Two Strings");
            ResultTester.CheckSolution("LC", LeetCode.DeleteOperationforTwoStrings.Test.TestCases());
        }


        private static void BitwiseANDofNumbersRangeFunc()
        {
            Program.Space();
            Program.Title("Bitwise AND of Numbers Range");
            ResultTester.CheckSolution("LC", LeetCode.BitwiseANDofNumbersRange.Test.TestCases());
        }


        private static void MinimumSpeedtoArriveonTimeFunc()
        {
            Program.Space();
            Program.Title("Minimum Speed to Arrive on Time");
            ResultTester.CheckSolution("LC", LeetCode.MinimumSpeedtoArriveonTime.Test.TestCases());
        }


        private static void FrogJumpFunc()
        {
            Program.Space();
            Program.Title("Frog Jump");
            ResultTester.CheckSolution("LC", LeetCode.FrogJump.Test.TestCases());
        }


        private static void FairDistributionofCookiesFunc()
        {
            Program.Space();
            Program.Title("Fair Distribution of Cookies");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MinimumNumberofDaystoMakemBouquetsFunc()
        {
            Program.Space();
            Program.Title("Minimum Number of Days to Make m Bouquets");
            ResultTester.CheckSolution("LC", LeetCode.MinimumNumberofDaystoMakemBouquets.Test.TestCases());
        }

 
        // CURRENT TESTS
        private static void CurrentTests()
        {
        }
    }
}