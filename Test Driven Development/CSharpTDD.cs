using System;
using System.Collections.Generic;
using CompetitiveProgramming.CodeChef;
using CompetitiveProgramming.CoderByte;
using CompetitiveProgramming.LeetCode;
using CompetitiveProgramming.CodeWars;
using CompetitiveProgramming.ProjectEuler;
using CompetitiveProgramming.Helpers.Outputs;

namespace CompetitiveProgramming.TestDrivenDevelopment
{
    public class CSharpTDD
    {
        private static Delegate[] codeWarsEightList = new Delegate[]
        {
            GrasshopperSummationFunc, SumArrayFunc, RemoveFirstandLastCharacterFunc, ReturnNegativeFunc, RemoveExclamationMarksFunc, BeginnerLostWithoutaMapFunc, AreYouPlayingBanjoFunc,
            FindMinAndMaxOfListFunc, StringRepeatFunc, SumOfPositiveFunc, ConvertbooleanvaluestostringsYesorNoFunc, ConvertaNumbertoaStringFunc, ANeedleintheHaystackFunc, InvertValuesFunc,
            EvenOrOddFunc, SquareNSumFunc, FindthesmallestintegerinthearrayFunc, RemoveStringSpacesFunc, CountingsheepFunc, ConvertaStringtoaNumberFunc, MakeUpperCaseFunc, CalculateaverageFunc,
            BeginnerSeries2ClockFunc, OppositesAttractFunc, SquaringAnArgumentFunc, ReturningStringsFunc, ReturnToSanityFunc, ReturnHelloWorldFunc, BeginnerSeries1SchoolPaperworkFunc,
            YouCantCodeUnderPressure1Func, CenturyFromYearFunc, BasicMathematicalOperationsFunc, ConvertNumberToReversedArrayOfDigitsFunc, AbbreviateaTwoWordNameFunc, SimplemultiplicationFunc,
            IshegonnasurviveFunc, FakeBinaryFunc,
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
            StringOperationsFunc, IndexingFunc, AccessingcharactersofaStringFunc, StringOperationsSTRS7Func, EnormousInputTestFunc, GoodTurnFunc, AddTwoNumbersCCFunc, UserInputUsrs1Func, USRS2IntegerInputFunc, HelloUserFunc, MultipleoutputsusingasinglelineFunc,
            CalculatorFunc, MiletoKilometerConvertorFunc, CSB001IntroductionFunc, CSB002IntroductionFunc, CSB003IntroductionFunc, CSB004ArithmeticOperationsFunc, CSB007MultipleOutputsFunc, CSB008OutputsInSeperateLinesFunc, CSB009AreaPerimeterofRectangleFunc,
            InsertingspacebetweenoutputsFunc, InsertingtextBetweenOutputsFunc, MultiplicationFunc, DivisionFunc, SyntaxFunc, StoringBoxesFunc, DeclaringavariableFunc, AdditionofVariablesFunc, AreaofRectangleFunc, DoubledatatypeFunc, StringDatatypeFunc,
        };

        private static Delegate[] codeChefBeginner = new Delegate[]
        {
            AgeLimitFunc, NumberMirrorFunc, RichieRichFunc, VaccineDatesFunc, HoopJumpFunc, TheTwoDishesFunc, MotivationFunc,
        };

        private static Delegate[] leetCodeEasyList = new Delegate[]
        {
            ClimbingStairsFunc, AddTwoIntegersFunc, NumberOfStepsFunc, ContainsDuplicateFunc, BestTimetoBuyandSellStockFunc, RangeSumQueryImmutableFunc, DesignHashSetFunc, SearchintoaBinarySearchTreeFunc, SameTreeFunc, AddStringsFunc,
            FirstUniqueCharacterinaStringFunc, SingleNumberFunc, FindJudgeFunc, ShuffleTheArrayFunc, CountOddNumbersInAnIntervalRangeFunc, RunningSumof1dArrayFunc, TwoSumIVInputisaBSTFunc, WordPatternFunc, SymmetricTreeFunc, FindtheKorofanArrayFunc,
            AddBinaryFunc, DefanginganIPAddressFunc, FindLuckyIntegerinanArrayFunc, SearchInsertPositionFunc, FindtheIndexoftheFirstOccurrenceinaStringFunc, MinimumDistanceBetweenBSTNodesFunc, PascalsTriangleIIFunc, DiameterofBinaryTreeFunc,
            KthMissingPositiveNumberFunc, ConvertSortedArraytoBinarySearchTreeFunc, CanPlaceFlowersFunc, KItemsWiththeMaximumSumFunc, BinarySearchFunc, MiddleoftheLinkedListFunc, ReshapetheMatrixFunc, MergeSortedArrayFunc, FindChampionIFunc,
            CheckIfNandItsDoubleExistFunc, ConcatenationofArrayFunc, KidsWiththeGreatestNumberofCandiesFunc, MergeStringsAlternatelyFunc, RomantoIntegerFunc, DesignHashMapFunc, AlternatingDigitSumFunc, TwoSumFunc, BalancedBinaryTreeFunc,
            BestPokerHandFunc, LastStoneWeightFunc, AddDigitsFunc, BulbSwitcherFunc, FindtheDifferenceFunc, RepeatedSubstringPatternFunc, VerifyinganAlienDictionaryFunc, MinimumAbsoluteDifferenceinBSTFunc, BackspaceStringCompareFunc,
            MoveZeroesFunc, PlusOneFunc, AverageSalaryExcludingtheMinimumandMaximumSalaryFunc, FindifPathExistsinGraphFunc, RichestCustomerWealthFunc, NumberofRecentCallsFunc, LongestPalindromeFunc, BuddyStringsFunc, NumberofGoodPairsFunc,
            SignoftheProductofanArrayFunc, CanMakeArithmeticProgressionFunc, MonotonicArrayFunc, LengthofLastWordFunc, ToLowerCaseFunc, ConvertBinaryNumberinaLinkedListtoIntegerFunc, FirstBadVersionFunc, SubtreeofAnotherTreeFunc,
            FindSmallestLetterGreaterThanTargetFunc, CountNegativeNumbersinaSortedMatrixFunc, ValidPerfectSquareFunc, ArrangingCoinsFunc, BaseballGameFunc, KeysandRoomsFunc, SumofLeftLeavesFunc, BinaryTreeInorderTraversalFunc, SortthePeopleFunc,
            RobotReturntoOriginFunc, FindWinneronaTicTacToeGameFunc, LemonadeChangeFunc, LargestPerimeterTriangleFunc, CheckIfItIsaStraightLineFunc, DeleteColumnstoMakeSortedFunc, GuessNumberHigherorLowerFunc, ExcelSheetColumnTitleFunc,
            ReverseVowelsofaStringFunc, CountingBitsFunc, IsSubsequenceFunc, MinCostClimbingStairsFunc, MaximumAverageSubarrayIFunc, DesignParkingSystemFunc, LeafSimilarTreesFunc, IntersectionofTwoArraysIIFunc, RemoveElementFunc,
            FindtheHighestAltitudeFunc, FindPivotIndexFunc, UniqueNumberofOccurrencesFunc, MajorityElementFunc, GoalParserInterpretationFunc, AddtoArrayFormofIntegerFunc, DetectCapitalFunc, ValidAnagramFunc, ImplementStackusingQueuesFunc,
            FloodFillFunc, HappyNumberFunc, DecryptStringfromAlphabettoIntegerMappingFunc, TheKWeakestRowsinaMatrixFunc, CheckifOneStringSwapCanMakeStringsEqualFunc, MergeTwoBinaryTreesFunc, BinaryTreePreorderTraversalFunc, FindWordsContainingCharacterFunc,
            SubtracttheProductandSumofDigitsofanIntegerFunc, SpecialArrayWithXElementsGreaterThanorEqualXFunc, SqrtxFunc, FindtheDistanceValueBetweenTwoArraysFunc, SortColorsFunc, ReverseStringFunc, IntersectionofTwoLinkedListsFunc,
            SumofAllOddLengthSubarraysFunc, NextGreaterElementIFunc, SquaresofaSortedArrayFunc, FibonacciNumberFunc, FindNearestPointThatHastheSameXorYCoordinateFunc, NaryTreePreorderTraversalFunc, MaximumAscendingSubarraySumFunc, DestinationCityFunc,
            Numberof1BitsFunc, SortIntegersbyTheNumberof1BitsFunc, SearchinRotatedSortedArrayFunc, PowerofTwoFunc, ReverseWordsinaStringIIIFunc, GreatestCommonDivisorofStringsFunc, RansomNoteFunc, ValidParenthesesFunc, MakeThreeStringsEqualFunc,
            ReverseBitsFunc, MaximumValueofaStringinanArrayFunc, SummaryRangesFunc, FindtheDifferenceofTwoArraysFunc, IntegerBreakFunc, NthTribonacciNumberFunc, KthLargestElementinaStreamFunc, MergeTwoSortedListsFunc, UniqueLength3PalindromicSubsequencesFunc,
            InvertBinaryTreeFunc, IsomorphicStringsFunc, RemoveLinkedListElementsFunc, LinkedListCycleFunc, PascalsTriangleFunc, PathSumFuncFunc, MaximumDepthofBinaryTreeFunc, RemoveDuplicatesfromSortedListFunc, PowerofFourFunc, MinimumOperationstoCollectElementsFunc,
            DetermineWhetherMatrixCanBeObtainedByRotationFunc, MinimumDepthofBinaryTreeFunc, EquilibriumPointFunc, RemoveDuplicatesfromSortedArrayFunc, SortArrayByParityFunc, FindModeinBinarySearchTreeFunc, LastVisitedIntegersFunc, SpecialPositionsinaBinaryMatrixFunc,
            SubarraysDistinctElementSumofSquaresIFunc, MinimumSumofMountainTripletsIFunc, FindIndicesWithIndexandValueDifferenceIFunc, DistributeCandiesAmongChildrenIFunc, MaximumStrongPairXORIFunc, DivisibleandNondivisibleSumsDifferenceFunc,
            CountNumberofPairsWithAbsoluteDifferenceKFunc, NumberofValidClockTimesFunc, DistributeCandiesFunc, AccountBalanceAfterRoundedPurchaseFunc, PalindromeNumberFunc, ValidPalindromeFunc, MatrixSimilarityAfterCyclicShiftsFunc, MaximumProductofTwoElementsinanArrayFunc,
            CheckIfTwoStringArraysareEquivalentFunc, FindWordsThatCanBeFormedbyCharactersFunc, MinimumTimeVisitingAllPointsFunc, FindthePeaksFunc, LargestSameDigitNumberinStringFunc, CountofMatchesinTournamentFunc, CalculateMoneyinLeetcodeBankFunc,
            LargestOddNumberinStringFunc, ConstructStringfromBinaryTreeFunc, MaximumValueofanOrderedTripletIFunc, FindCommonElementsBetweenTwoArraysFunc, TransposeMatrixFunc, CountTestedDevicesAfterTestOperationsFunc, ElementAppearingMoreThanInSortedArrayFunc,
        };

        private static Delegate[] leetCodeMediumList = new Delegate[]
        {
            RestoreIpAddressesFunc, SnakesAndLaddersFunc, FindClosestNodetoGivenTwoNodesFunc, FruitIntoBasketsFunc, JumpGameIIFunc, AllPathsFromSourcetoTargetFunc, MagneticForceBetweenTwoBallsFunc, PredicttheWinnerFunc, SubarraySumsDivisiblebyKFunc, ImplementQueueusingStacksFunc, SwapNodesinPairsFunc, ExtraCharactersinaStringFunc,
            AsFarfromLandasPossibleFunc, ShortestPathWithAlternatingColorsFunc, MinimumFuelCosttoReporttotheCapitalFunc, SingleElementinaSortedArrayFunc, CapacityToShipPackagesWithinDDaysFunc, DesignUndergroundSystemFunc, CheckCompletenessofaBinaryTreeFunc, BinaryTreeRightSideViewFunc, GenerateParenthesesFunc, ReorganizeStringFunc,
            SortanArrayFunc, StringCompressionFunc, MinimumTimetoCompleteTripsFunc, KokoEatingBananasFunc, ImplementTriePrefixTreeFunc, CountSubIslandsFunc, KRadiusSubarrayAveragesFunc, SeatReservationManagerFunc, MaximumLevelSumofaBinaryTreeFunc, LowestCommonAncestorofaBinaryTreeFunc, RemoveNthNodeFromEndofListFunc, SoupServingsFunc,
            NumberofZeroFilledSubarraysFunc, MinimumScoreofaPathBetweenTwoCitiesFunc, NumberofOperationstoMakeNetworkConnectedFunc, ReorderRoutestoMakeAllPathsLeadtotheCityZeroFunc, CountUnreachablePairsofNodesinanUndirectedGraphFunc, NondecreasingSubsequencesFunc, HouseRobberFunc, ValidSudokuFunc, AddTwoNumbersFunc,
            MinimumPathSumFunc, PrimeSubtractionOperationFunc, MinimumCostForTicketsFunc, SuccessfulPairsofSpellsandPotionsFunc, BoatstoSavePeopleFunc, HIndexIIFunc, FindaPeakElementIIFunc, WaterandJugProblemFunc, ShortestPathinBinaryMatrixFunc, OddEvenLinkedListFunc, GasStationFunc, PermutationsFunc, RotateImageFunc,
            OptimalPartitionofStringFunc, MinimizeMaximumofArrayFunc, NumberofEnclavesFunc, RemoveStarsFunc, NumberofClosedIslandsFunc, RangeSumofSortedSubarraySumsFunc, SellDiminishingValuedColoredBallsFunc, PermutationsIIFunc, CheapestFlightsWithinKStopsFunc, LowestCommonAncestorofaBinarySearchTreeFunc, CombinationSumIVFunc,
            SimplifyPathFunc, ValidateStackSequencesFunc, LongestPalindromicSubsequenceFunc, NonoverlappingIntervalsFunc, RobotBoundedInCircleFunc, MinimumSizeSubarraySumFunc, OpentheLockFunc, DesignBrowserHistoryFunc, RottingOrangesFunc, ConstructQuadTreeFunc, BinaryTreePostorderTraversalFunc, BullsandCowsFunc, ReverseLinkedListIIFunc,
            MatrixDiagonalSumFunc, MultiplyStringsFunc, PowxnFunc, ReverseWordsinaStringFunc, ProductofArrayExceptSelfFunc, WaystoSplitArrayIntoThreeSubarraysFunc, FindKClosestElementsFunc, PopulatingNextRightPointersinEachNodeIIFunc, AddTwoNumbersIIFunc, PeekingIteratorFunc, SpiralMatrixFunc, ZigzagConversionFunc,
            Dota2SenateFunc, MinimumFlipstoMakeaORbEqualtocFunc, BestTimetoBuyandSellStockwithTransactionFeeFunc, IncreasingTripletSubsequenceFunc, MaximumNumberofVowelsinaSubstringofGivenLengthFunc, SearchSuggestionsSystemFunc, MaximumWidthofBinaryTreeFunc, ReverseLinkedListFunc, SpiralMatrixIIFunc, SingleNumberIIFunc,
            DominoandTrominoTilingFunc, ContainerWithMostWaterFunc, MaxNumberofKSumPairsFunc, UniquePathsFunc, NearestExitfromEntranceinMazeFunc, FrequencyoftheMostFrequentElementFunc, NumberofNodesintheSubTreeWiththeSameLabelFunc, DeleteNodeinaBSTFunc, HouseRobberIIIFunc, PopulatingNextRightPointersinEachNodeIFunc,
            LongestCommonSubsequenceFunc, MaxIceCreamFunc, TopKFrequentFunc, LexicographicallySmallestEquivalentStringFunc, FlipStringtoMonotoneIncreasingFunc, SearchA2DMatrixFunc, InsertIntervalFunc, MaxSubarraySumCircularFunc, SubarraySumFunc, SubarraysDivByKFunc, LinkedListCycleIIFunc, LetterCombinationsofaPhoneNumberFunc,
            LongestSubstringWithoutRepeatingCharactersFunc, UniquePathsIIFunc, MaximalSquareFunc, JumpGameFunc, PathSumIIFunc, MaximumValueataGivenIndexinaBoundedArrayFunc, BinarySearchTreeIteratorFunc, KthSmallestElementinaBSTFunc, ConstructBinaryTreefromPreorderandInorderTraversalFunc, SmallestNumberinInfiniteSetFunc,
            SnapshotArrayFunc, LongestIncreasingSubsequenceFunc, WiggleSubsequenceFunc, LongestPalindromicSubstringFunc, RangeSumQuery2DImmutableFunc, BestTimetoBuyandSellStockIIFunc, BestSightseeingPairFunc, MatrixBlockSumFunc, MaximumProductSubarrayFunc, MaximumLengthofSubarrayWithPositiveProductFunc, PartitionLabelsFunc,
            FindtheWinneroftheCircularGameFunc, RemoveDuplicatesfromSortedListIIFunc, DesignLinkedListFunc, MinStackFunc, CoinChangeFunc, CoinChangeIIFunc, MinimumRoundstoCompleteAllTasksFunc, SolvingQuestionsWithBrainpowerFunc, MaximumTwinSumofaLinkedListFunc, DeletetheMiddleNodeofaLinkedListFunc, GroupAnagramsFunc,
            MaxConsecutiveOnesIIIFunc, LongestSubarrayof1sAfterDeletingOneElementFunc, NumberofProvincesFunc, NumberofSubsequencesThatSatisfytheGivenSumConditionFunc, AsteroidCollisionFunc, IntervalListIntersectionsFunc, OnlineStockSpanFunc, EvaluateDivisionFunc, DesignAddandSearchWordsDataStructureFunc, PartitionListFunc,
            FindPeakElementFunc, WateringPlantsIIFunc, CarPoolingFunc, CountWaysToBuildGoodStringsFunc, TotalCosttoHireKWorkersFunc, PacificAtlanticWaterFlowFunc, FindtheStudentthatWillReplacetheChalkFunc, JumpGameIIIFunc, DailyTemperaturesFunc, DecodeStringFunc, EvaluateReversePolishNotationFunc, SubsetsFunc, WordSearchFunc,
            MaximumSubsequenceScoreFunc, KthLargestElementinanArrayFunc, EqualRowandColumnPairsFunc, DetermineifTwoStringsAreCloseFunc, IsGraphBipartiteFunc, MinimumLimitofBallsinaBagFunc, AllPossibleFullBinaryTreesFunc, LetterCasePermutationFunc, TopKFrequentElementsFunc, ConvertSortedListtoBinarySearchTreeFunc, TaskSchedulerFunc,
            NextPermutationFunc, ShortestBridgeFunc, FindtheDuplicateNumberFunc, New21GameFunc, FindMinimuminRotatedSortedArrayFunc, NumberofIslandsFunc, LongestArithmeticSubsequenceFunc, MaximalNetworkRankFunc, UncrossedLinesFunc, MinimumNumberofArrowstoBurstBalloonsFunc, BinaryTreeLevelOrderTraversalFunc, ShuffleanArrayFunc,
            StoneGameIIFunc, CourseScheduleFunc, ThreeSumFunc, PeakIndexinaMountainArrayFunc, DeleteandEarnFunc, SearchinRotatedSortedArrayIIFunc, ValidTriangleNumberFunc, RandomPickwithWeightFunc, CountGoodNodesinBinaryTreeFunc, DesignCircularQueueFunc, CombinationSumIIIFunc, ValidateBinarySearchTreeFunc, PerfectSquaresFunc,
            TwoSumIIInputArrayIsSortedFunc, FindFirstandLastPositionofElementinSortedArrayFunc, MergeIntervalsFunc, TimeNeededtoInformAllEmployeesFunc, SumofSquareNumbersFunc, AvoidFloodinTheCityFunc, KnightProbabilityinChessboardFunc, FindAllAnagramsinaStringFunc, PalindromePartitioningFunc, MaximumSubarrayFunc, ValidateBinaryTreeNodesFunc,
            DecodeWaysFunc, ArithmeticSlicesFunc, RotateArrayFunc, UglyNumberIIFunc, UniqueBinarySearchTreesFunc, FindRightIntervalFunc, ShortestSubarraytobeRemovedtoMakeArraySortedFunc, SwappingNodesinaLinkedListFunc, PossibleBipartitionFunc, LinkedListRandomNodeFunc, SumRoottoLeafNumbersFunc, UglyNumberIIIFunc, SortListFunc,
            MaximumDistanceBetweenaPairofValuesFunc, WordBreakFunc, ZeroOneMatrixFunc, MaxAreaofIslandFunc, TriangleFunc, MostProfitAssigningWorkFunc, CountCompleteTreeNodesFunc, LongestRepeatingCharacterReplacementFunc, InsertintoaBinarySearchTreeFunc, HouseRobberIIFunc, BinaryTreeZigzagLevelOrderTraversalFunc, Searcha2DMatrixIIFunc,
            NextGreaterElementIIIFunc, SubsetsIIFunc, MinimumNumberofVerticestoReachAllNodesFunc, BasicCalculatorIIFunc, TopKFrequentWordsFunc, NextGreaterElementIIFunc, LinkedListinBinaryTreeFunc, MaximumSideLengthofaSquarewithSumLessthanorEqualtoThresholdFunc, CloneGraphFunc, CombinationsFunc, SurroundedRegionsFunc,
            SmallestRangeIIFunc, BestTeamWithNoConflictsFunc, ThreeSumClosestFunc, CombinationSumFunc, CopyListwithRandomPointerFunc, MinimumGeneticMutationFunc, LongestZigZagPathinaBinaryTreeFunc, SubarrayProductLessThanKFunc, PermutationinStringFunc, BestTimetoBuyandSellStockwithCooldownFunc, SetMatrixZeroesFunc,
            LongestArithmeticSubsequenceofGivenDifferenceFunc, PartitionEqualSubsetSumFunc, RotateListFunc, ArithmeticSubarraysFunc, OnlineElectionFunc, MinimumTimetoCollectAllApplesinaTreeFunc, PathwithMaximumProbabilityFunc, FindDuplicateSubtreesFunc, PathSumIIIFunc, ConstructBinaryTreefromInorderandPostorderTraversalFunc,
            MinimumRemovetoMakeValidParenthesesFunc, FindEventualSafeStatesFunc, NaryTreeLevelOrderTraversalFunc, FlattenNestedListIteratorFunc, UniqueBinarySearchTreesIIFunc, FindLatestGroupofSizeMFunc, ReorderListFunc, ShortestPathVisitingAllNodesFunc, SortCharactersByFrequencyFunc, SumofMutatedArrayClosesttoTargetFunc,
            KClosestPointstoOriginFunc, CheckifThereisaValidPartitionForTheArrayFunc, MaximumLengthofPairChainFunc, MinimumPenaltyforaShopFunc, InterleavingStringFunc, MinimumSpeedtoArriveonTimeFunc, MinimumNumberofDaystoMakemBouquetsFunc, FairDistributionofCookiesFunc, RepeatedDNASequencesFunc, NumberofLongestIncreasingSubsequenceFunc,
            MinimizetheMaximumDifferenceofPairsFunc, TimeBasedKeyValueStoreFunc, DeleteOperationforTwoStringsFunc, BitwiseANDofNumbersRangeFunc, MaximumNumberofRemovableCharactersFunc, FindKPairswithSmallestSumsFunc, MinimumAbsoluteSumDifferenceFunc, FindtheSmallestDivisorGivenaThresholdFunc, SplitLinkedListinPartsFunc,
            DesignAuthenticationManagerFunc, InsertDeleteGetRandomFunc, MyCalendarIFunc, MaximizetheConfusionofanExamFunc, AllNodesDistanceKinBinaryTreeFunc, LongestPalindromebyConcatenatingTwoLetterWordsFunc, PathWithMinimumEffortFunc, WhereWilltheBallFallFunc, MinimumASCIIDeleteSumforTwoStringsFunc, CombinationSumIIFunc,
            GroupthePeopleGiventheGroupSizeTheyBelongToFunc, MinimumDeletionstoMakeCharacterFrequenciesUniqueFunc, MinCosttoConnectAllPointsFunc, MinimumOperationstoReduceXtoZeroFunc, ChampagneTowerFunc, RemoveDuplicateLettersFunc, DecodedStringatIndexFunc, OneThreeTwoPatternFunc, RemoveColoredPiecesifBothNeighborsaretheSameColorFunc,
            MajorityElementIIFunc, FindLargestValueinEachTreeRowFunc, KthSymbolinGrammarFunc, BinaryTreesWithFactorsFunc, FindTheOriginalArrayofPrefixXorFunc, CountNodesEqualtoAverageofSubtreeFunc, BuildanArrayWithStackOperationsFunc, LastMomentBeforeAllAntsFallOutofaPlankFunc, FindtheWinnerofanArrayGameFunc, EliminateMaximumNumberofMonstersFunc,
            DetermineifaCellIsReachableataGivenTimeFunc, CountNumberofHomogenousSubstringsFunc, RestoretheArrayFromAdjacentPairsFunc, SortVowelsinaStringFunc, MaximumElementAfterDecreasingandRearrangingFunc, FindUniqueBinaryStringFunc, MinimizeMaximumPairSuminArrayFunc, ReductionOperationstoMaketheArrayElementsEqualFunc,
            MinimumAmountofTimetoCollectGarbageFunc, CountNicePairsinanArrayFunc, DiagonalTraverseIIFunc, MaximumNumberofCoinsYouCanGetFunc, SumofAbsoluteDifferencesinaSortedArrayFunc, LargestSubmatrixWithRearrangementsFunc, KnightDialerFunc, DifferenceBetweenOnesandZerosinRowandColumnFunc,
        };

        private static Delegate[] leetCodeHardList = new Delegate[]
        {
            CountDigitOneFunc, LongestPathWithDifferentAdjacentCharactersFunc, CheckifPointIsReachableFunc, NamingaCompanyFunc, IPOFunc, EditDistanceFunc, CountSubarraysWithFixedBoundsFunc, JumpGameIVFunc, LongestCycleinaGraphFunc, NumberofWaysofCuttingaPizzaFunc, FindMinimuminRotatedSortedArrayIIFunc, NumberofMusicPlaylistsFunc, WordLadderFunc, CandyFunc,
            ReducingDishesFunc, ScrambleStringFunc, MinimumReverseOperationsFunc, LargestColorValueinaDirectedGraphFunc, MaximumValueofKCoinsFromPilesFunc, NumberofWaystoFormaTargetStringGivenaDictionaryFunc, ProfitableSchemesFunc, MinimumInsertionStepstoMakeaStringPalindromeFunc, RestoreTheArrayFunc, FindtheLongestValidObstacleCourseatEachPositionFunc,
            MaximizeScoreAfterNOperationsFunc, StoneGameIIIFunc, MinimumCosttoCutaStickFunc, TrappingRainWaterFunc, NumberofGoodPathsFunc, SerializeandDeserializeBinaryTreeFunc, ReverseNodesinkGroupFunc, MakeArrayStrictlyIncreasingFunc, NumberofIncreasingPathsinaGridFunc, FrogJumpFunc, TextJustificationFunc, SortItemsbyGroupsRespectingDependenciesFunc,
            NumberofWaystoReorderArraytoGetSameBSTFunc, TallestBillboardFunc, CheckingExistenceofEdgeLengthLimitedPathsFunc, MinimizeDeviationinArrayFunc, SubstringWithLargestVarianceFunc, MergekSortedListsFunc, PutMarblesinBagsFunc, CountAllValidPickupandDeliveryOptionsFunc, ReconstructItineraryFunc, NQueensFunc, PaintingtheWallsFunc, PoorPigsFunc,
            CountAllPossibleRoutesFunc, MinimumJumpstoReachHomeFunc, BusRoutesFunc, StrangePrinterFunc, SumofDistancesinTreeFunc, DataStreamasDisjointIntervalsFunc, MinimumNumberofTapstoOpentoWateraGardenFunc, MaxDotProductofTwoSubsequencesFunc, NumberofFlowersinFullBloomFunc, FindinMountainArrayFunc, ConstrainedSubsequenceSumFunc, ParallelCoursesIIIFunc,
            MinimumCosttoMakeArrayEqualFunc, RemoveMaxNumberofEdgestoKeepGraphFullyTraversableFunc, FirstMissingPositiveFunc, LFUCacheFunc, BinaryTreeMaximumPathSumFunc, MinimumNumberofOperationstoMakeArrayContinuousFunc, NumberofWaystoStayintheSamePlaceAfterSomeStepsFunc, CountVowelsPermutationFunc, MinimumOneBitOperationstoMakeIntegersZeroFunc,
            MaximumNumberofEventsThatCanBeAttendedIIFunc, SmallestSufficientTeamFunc, MaximumNumberofAchievableTransferRequestsFunc, MaxPointsonaLineFunc, MaximumRunningTimeofNComputersFunc, DesignGraphWithShortestPathCalculatorFunc,
            CourseScheduleIIFunc, LastDayWhereYouCanStillCrossFunc, ShortestPathtoGetAllKeysFunc, SimilarStringGroupsFunc, ConcatenatedWordsFunc, SlidingWindowMaximumFunc, MaximumScoreofaGoodSubarrayFunc, NumberofWaystoDivideaLongCorridorFunc,
            FindCriticalandPseudoCriticalEdgesinMinimumSpanningTreeFunc, MinimumReplacementstoSorttheArrayFunc, MedianofTwoSortedArraysFunc, BuildArrayWhereYouCanFindTheMaximumExactlyKComparisonsFunc,
        };

        private static Delegate[] hackerRankEasyList = new Delegate[]
        {
            SimpleArraySumFunc, SolveMeFirstFunc, AVeryBigSumFunc, CompareTheTripletsFunc, DiagonalDifferenceFunc, PlusMinusFunc, StaircaseFunc, MiniMaxSumFunc, BirthdayCakeCandlesFunc, TimeConversionFunc, GradientStudentsFunc,
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
            SumofSeriesFunc, PrintSecondLargestFunc, Print1ToNWithoutLoopFunc,
        };

        private static Delegate[] geeksForGeeksBasicList = new Delegate[]
        {
            PrintfirstnFibonacciNumbersFunc, ReversearrayingroupsFunc,
        };

        private static Delegate[] geeksForGeeksEasyList = new Delegate[]
        {
            CounttheSubstringsFunc, MinimumIntegerFunc, Remainderondividingby11Func, MakeArrayElementsEqualFunc, EqualLeftandRightSubarraySumFunc, BFSofgraphFunc, MakeTheArrayBeautifulFunc, FrogsAndJumpFunc, DominantPairsFunc, DFSofGraphFunc,
            StringPermutationsFunc, FindfirstsetbitFunc, SumofupperandlowertrianglesFunc, DetermineifTwoTreesareIdenticalFunc,
        };

        private static Delegate[] geeksForGeeksMediumList = new Delegate[]
        {
            StringrporprFunc, EvenSwapFunc, MinimumStepsRequiredFunc, AddMinimumCharactersFunc, MaximumLengthFunc, RemoveandReverseFunc, ShyGeek, MaximumIntersectingLinesFunc, KnightInGeeklandFunc, CountSpecialNumbersFunc, BTSMaximumDifferenceFunc,
            ReverseaStackFunc, SticklerThiefFunc, BinaryTreetoCDLLFunc,
        };

        private static Delegate[] geeksForGeeksHardList = new Delegate[]
        {
            SpecialDigitsFunc, DivideInIncrementialGroupsFunc, SolvetheSudokuFunc,
        };

        private static Delegate[] sphereOnlineJudgeList = new Delegate[]
        {
            LifetheUniverseandEverythingFunc, PrimeGeneratorFunc, TransformtheExpressionFunc,
        };

        private static Delegate[] csacademyTutorialList = new Delegate[]
        {
            AdditionFunc, GreatestCommonDivisorFunc,
        };

        private static Delegate[] csacademyEasyList = new Delegate[]
        {
            MatrixExplorationFunc,
        };

        private static Delegate[] kattisEasyList = new Delegate[]
        {
            VelkominFunc, HelloWorldKattisFunc, LeggjasamanFunc, SevenWondersFunc, EchoEchoEchoFunc, SecretMessageFunc,
        };

        private static Delegate[] codeForces800List = new Delegate[]
        {
            TeamFunc, WayTooLongWordsFunc, WatermelonFunc, NextRoundFunc, DominoPilingFunc, BitPPFunc, BeautifulMatrixFunc, PetyaandStringsFunc, HelpfulMathsFunc, WordCapitalizationFunc, BoyorGirlFunc, StonesontheTableFunc, BearandBigBrotherFunc, SoldierandBananasFunc, ElephantFunc, WordFunc,
            WrongSubtractionFunc, NearlyLuckyNumberFunc, AntonandDanikFunc, ATranslationFunc, ATramFunc, VanyaandFenceFunc, QueueattheSchoolFunc, BeautifulYearFunc, InSearchofanEasyProblemFunc, GeorgeandAccommodationFunc, MagnetsFunc, PresentsFunc, CalculateFunctionFunc, DrinksFunc,
            UltraFastMathematicianFunc, IsyourhorseshoeontheotherhoofFunc, HulkFunc, DivisibilityProblemFunc, IWannaBetheGuyFunc, ArrivaloftheGeneralFunc, PangramFunc, InsomniacureFunc, AntonandLettersFunc, HittheLotteryFunc, GamesFunc, AntonandPolyhedronsFunc, CandiesandTwoSistersFunc,
            AmusingJokeFunc, FoxAndSnakeFunc,
        };

        private static Delegate[] coderByteEasyList = new Delegate[]
        {
            FirstFactorialFunc, FirstReverseFunc, CodelandUsernameValidationFunc, FindIntersectionFunc, QuestionsMarksFunc, LongestWordFunc,
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

        private static Delegate[] projectEulerList = new Delegate[]
        {
            Multiplesof3or5Func, EvenFibonacciNumbersFunc, LargestPrimeFactorFunc, LargestPalindromeProductFunc,
        };

        private static Delegate[] codinGameList = new Delegate[]
        {
            TheDescentFunc, OnboardingFunc,
        };

        public static void StartAllTDD()
        {
            // All CoderByte Solutions
            CoderByteTests();

            // All AtCoder Solutions
            AtCoderTests();

            // All CodeWars Solutions
            CodeWarsTests();

            // All CodinGame Solutions
            CodinGameTests();

            // All CodeChef Solutions
            CodeChefTests();

            // All GeeksForGeeks Solutions
            GeeksForGeeksTests();

            // All HackerRank Solutions
            HackerRankTests();

            // All Kattis Solutions
            KattisTests();

            // All Sphere Online Judge Solutions
            SphereOnlineJudgeTests();

            // All CS Academy Solutions
            CSAcademyTests();

            // All CodeForces Solutions
            CodeForcesTests();

            // All LeetCode Solutions
            LeetCodeTests();

            // All Project Euler Solutions
            ProjectEulerTests();

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


        private static void KattisTests()
        {
            // Easy
            InvokeDelegateIfNotNull(kattisEasyList);
        }


        private static void SphereOnlineJudgeTests()
        {
            // All
            InvokeDelegateIfNotNull(sphereOnlineJudgeList);
        }


        private static void ProjectEulerTests()
        {
            // All
            InvokeDelegateIfNotNull(projectEulerList);
        }


        private static void CSAcademyTests()
        {
            // Tutorial
            InvokeDelegateIfNotNull(csacademyTutorialList);

            // Easy
            InvokeDelegateIfNotNull(csacademyEasyList);
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
            // All
            InvokeDelegateIfNotNull(atCoderList);
        }


        // CODINGAME
        private static void CodinGameTests()
        {
            // All
            InvokeDelegateIfNotNull(codinGameList);
        }


        private static void ClimbingStairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Climbing Stairs");
            ResultTester.CheckSolution("LC", LeetCode.ClimbingStairs.Test.TestClimbingStairs());
        }


        private static void AddTwoIntegersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Two Integers");
            ResultTester.CheckSolution("LC", LeetCode.AddTwoIntegers.Test.TestCases());
        }


        private static void FirstFactorialFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("First Factorial");
            ResultTester.CheckSolution("CB", CoderByte.FirstFactorial.Test.TestFirstFactorial());
        }


        private static void FirstReverseFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("First Reverse");
            ResultTester.CheckSolution("CB", CoderByte.FirstReverse.Test.TestFirstReverse());
        }


        private static void ReplaceWithAlphabetPositionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Replace With Alphabet Position");
            ResultTester.CheckSolution("CW", CodeWars.SixKyu.ReplaceWithAlphabetPosition.Test.TestReplaceWithAlphabetPosition());
        }


        private static void FakeBinaryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fake Binary");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.FakeBinary.Test.TestCases());
        }


        private static void GrasshopperSummationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Grasshopper Summation");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.GrasshopperSummation.Test.TestGrasshopperSummation());
        }


        private static void NumberOfStepsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Steps to Reduce a Number to Zero");
            ResultTester.CheckSolution("LC", LeetCode.NumberofStepstoReduceaNumbertoZero.Test.TestNumberofStepstoReduceaNumbertoZero());
        }


        private static void SumArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum Array");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.SumArray.Test.TestSumArray());
        }


        private static void LongestCommonSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Common Subsequence");
            ResultTester.CheckSolution("LC", LeetCode.LongestCommonSubsequence.Solution.TestLongestCommonSubsequence());
        }


        private static void RemoveFirstandLastCharacterFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove First and Last Character");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.RemoveFirstandLastCharacter.Test.TestRemoveFirstandLastCharacter());
        }


        private static void ItIsIsogramFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("It is an Isogram");
            ResultTester.CheckSolution("CW", CodeWars.SevenKyu.Isograms.Test.TestIsograms());
        }


        private static void CountDigitOneFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Digit One");
            ResultTester.CheckSolution("LC", LeetCode.NumberofDigitOne.Test.TestNumberofDigitOne());
        }


        private static void ContainsDuplicateFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Contains Duplicate");
            ResultTester.CheckSolution("LC", LeetCode.ContainsDuplicate.Test.TestContainsDuplicate());            
        }


        private static void MaxIceCreamFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Ice Cream");
            ResultTester.CheckSolution("LC", LeetCode.MaximumIceCreamBars.Test.TestCases());
        }


        private static void LongestPathWithDifferentAdjacentCharactersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Path With Different Adjacent Characters");
            ResultTester.CheckSolution("LC", LeetCode.LongestPathWithDifferentAdjacentCharacters.Test.TestCases());
        }


        private static void LexicographicallySmallestEquivalentStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Lexicographically Smallest Equivalent String");
            ResultTester.CheckSolution("LC", LeetCode.LexicographicallySmallestEquivalentString.Test.TestLexicographicallySmallestEquivalentString());
        }


        private static void FlipStringtoMonotoneIncreasingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Flip String to Monotone Increasing");
            ResultTester.CheckSolution("LC", LeetCode.FlipStringtoMonotoneIncreasing.Test.TestFlipStringtoMonotoneIncreasing());
        }


        private static void SearchA2DMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search a Matrix");
            ResultTester.CheckSolution("LC", LeetCode.Searcha2DMatrix.Test.TestSearcha2DMatrix());
        }


        private static void SetMatrixZeroesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Set Matrix Zeroes");
            ResultTester.CheckSolution("LC", LeetCode.SetMatrixZeroes.Test.TestSetMatrixZeroes());
        }


        private static void InsertIntervalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Insert Interval");
            ResultTester.CheckSolution("LC", LeetCode.InsertInterval.Test.TestInsertInterval());
        }


        private static void BestTimetoBuyandSellStockFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Time to Buy and Sell Stock");
            ResultTester.CheckSolution("LC", LeetCode.BestTimetoBuyandSellStock.Test.TestBestTimetoBuyandSellStock());
        }


        private static void FirstUniqueCharacterinaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("First Unique Character in a String");
            ResultTester.CheckSolution("LC", LeetCode.FirstUniqueCharacterinaString.Test.TestFirstUniqueCharacterinaString());
        }


        private static void RansomNoteFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ransom Note");
            ResultTester.CheckSolution("LC", LeetCode.RansomNote.Test.TestRansomNote());
        }


        private static void LinkedListRandomNodeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Linked List Random Node");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CandiesandTwoSistersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Candies and Two Sisters");
            ResultTester.SpecialTestCase("CF");
        }


        private static void AmusingJokeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Amusing Joke");
            ResultTester.SpecialTestCase("CF");
        }


        private static void FoxAndSnakeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fox And Snake");
            ResultTester.SpecialTestCase("CF");
        }


        private static void SoupServingsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Soup Servings");
            ResultTester.SpecialTestCase("LC");
        }


        private static void BinaryTreePreorderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Preorder Traversal");
            ResultTester.SpecialTestCase("LC");
        }
        

        private static void CombinationSumIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Combination Sum III");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ValidSudokuFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Sudoku");
            ResultTester.SpecialTestCase("LC");
        }


        private static void LinkedListCycleIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Linked List Cycle II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void LinkedListCycleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Linked List Cycle");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CloneGraphFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Clone Graph");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PalindromePartitioningFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Palindrome Partitioning");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SumRoottoLeafNumbersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum Root to Leaf Numbers");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SingleNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Single Number");
            ResultTester.CheckSolution("LC", LeetCode.SingleNumber.Test.TestSingleNumber());
        }


        private static void BinaryTreeMaximumPathSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Maximum Path Sum");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaxSubarraySumCircularFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Subarray Sum Circular");
            ResultTester.CheckSolution("LC", LeetCode.MaximumSumCircularSubarray.Test.TestMaximumSumCircularSubarray());
        }


        private static void FindCommonElementsBetweenTwoArraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Common Elements Between Two Arrays");
            ResultTester.CheckSolution("LC", LeetCode.FindCommonElementsBetweenTwoArrays.Test.TestCases());
        }


        private static void GasStationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Gas Station");
            ResultTester.CheckSolution("LC", LeetCode.GasStation.Test.TestGasStation());
        }


        private static void TransposeMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Transpose Matrix");
            ResultTester.CheckSolution("LC", LeetCode.TransposeMatrix.Test.TestCases());
        }

        private static void SubarraySumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subarray Sum");
            ResultTester.CheckSolution("LC", LeetCode.SubarraySumEqualsK.Test.TestSubarraySumEqualsK());
        }


        private static void CountTestedDevicesAfterTestOperationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Tested Devices After Test Operations");
            ResultTester.CheckSolution("LC", LeetCode.CountTestedDevicesAfterTestOperations.Test.TestCases());
        }


        private static void FindJudgeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Judge");
            ResultTester.CheckSolution("LC", LeetCode.FindtheTownJudge.Test.TestFindtheTownJudge());
        }


        private static void RottingOrangesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Rotting Oranges");
            ResultTester.CheckSolution("LC", LeetCode.RottingOranges.Test.TestRottingOranges());
        }


        private static void AddtoArrayFormofIntegerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add to Array Form of Integer");
            ResultTester.CheckSolution("LC", LeetCode.AddtoArrayFormofInteger.Test.TestAddtoArrayFormofInteger());
        }


        private static void RestoreIpAddressesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Restore Ip Addresses");
            ResultTester.CheckSolution("LC", LeetCode.RestoreIPAddresses.Test.TestRestoreIPAddresses());
        }


        private static void CheckifPointIsReachableFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check if Point Is Reachable");
            ResultTester.CheckSolution("LC", LeetCode.CheckifPointIsReachable.Test.TestCases());
        }


        private static void SnakesAndLaddersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Snakes And Ladders");
            ResultTester.CheckSolution("LC", LeetCode.SnakesandLadders.Test.TestSnakesandLadders());
        }


        private static void FindClosestNodetoGivenTwoNodesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Closest Node to Given Two Nodes");
            ResultTester.CheckSolution("LC", LeetCode.FindClosestNodetoGivenTwoNodes.Test.TestCases());
        }


        private static void ShuffleTheArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shuffle The Array");
            ResultTester.CheckSolution("LC", LeetCode.ShuffletheArray.Test.TestCases());
        }


        private static void CountOddNumbersInAnIntervalRangeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Odd Numbers in an Interval Range");
            ResultTester.CheckSolution("LC", LeetCode.CountOddNumbersinanIntervalRange.Test.TestCases());
        }


        private static void NumberofNodesintheSubTreeWiththeSameLabelFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Nodes in the Sub-Tree With the Same Label");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FruitIntoBasketsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fruit Into Baskets");
            ResultTester.CheckSolution("LC", LeetCode.FruitIntoBaskets.Test.TestFruitIntoBaskets());
        }


        private static void OnlineStockSpanFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Online Stock Span");
            ResultTester.SpecialTestCase("LC");
        }


        private static void JumpGameIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Jump Game II");
            ResultTester.CheckSolution("LC", LeetCode.JumpGameII.Test.TestJumpGameII());
        }


        private static void EvenOrOddFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Even or Odd");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.EvenorOdd.Test.TestEvenorOdd());
        }


        private static void NamingaCompanyFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Naming a Company");
            ResultTester.CheckSolution("LC", LeetCode.NamingaCompany.Test.TestCases());
        }


        private static void AsFarfromLandasPossibleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("As Far from Land as Possible");
            ResultTester.CheckSolution("LC", LeetCode.AsFarfromLandasPossible.Solution.TestAsFarfromLandasPossible());
        }


        private static void MaximumLevelSumofaBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Level Sum of a Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ShortestPathWithAlternatingColorsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Path With Alternating Colors");
            ResultTester.CheckSolution("LC", LeetCode.ShortestPathwithAlternatingColors.Test.TestShortestPathwithAlternatingColors());
        }


        private static void MinimumFuelCosttoReporttotheCapitalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Fuel Cost to Report to the Capital");
            ResultTester.CheckSolution("LC", LeetCode.MinimumFuelCosttoReporttotheCapital.Test.TestCases());
        }


        private static void AddBinaryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Binary");
            ResultTester.CheckSolution("LC", LeetCode.AddBinary.Test.TestAddBinary());
        }


        private static void ConvertaNumbertoaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert a Number to a String");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.ConvertaNumbertoaString.Test.TestConvertaNumbertoaString());
        }


        private static void DefanginganIPAddressFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Defanging an IP Address");
            ResultTester.CheckSolution("LC", LeetCode.DefanginganIPAddress.Test.TestDefanginganIPAddress());
        }


        private static void FindLuckyIntegerinanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Lucky Integer in an Array");
            ResultTester.CheckSolution("LC", LeetCode.FindLuckyIntegerinanArray.Test.TestFindLuckyIntegerinanArray());
        }


        private static void ConvertbooleanvaluestostringsYesorNoFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert boolean values to strings Yes or No");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.ConvertbooleanvaluestostringsYesorNo.Test.TestConvertbooleanvaluestostringsYesorNo());  
        }


        private static void SumOfPositiveFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum Of Positive");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.Sumofpositive.Test.TestYouCantCodeUnderPressure1());
        }


        private static void StringRepeatFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("String Repeat");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.Stringrepeat.Test.TestStringrepeat());
        }


        private static void FindMinAndMaxOfListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Min And Max Of List");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.FindMaximumandMinimumValuesofaList.Test.TestFindMaximumandMinimumValuesofaList());
        }


        private static void RemoveExclamationMarksFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Exclamation Marks");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.RemoveExclamationMarks.Test.TestRemoveExclamationMarks());
        }


        private static void ReturnNegativeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Return Negative");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.ReturnNegative.Test.TestReturnNegative());
        }


        private static void SearchInsertPositionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search Insert Position");
            ResultTester.CheckSolution("LC", LeetCode.SearchInsertPosition.Test.TestSearchInsertPosition());
        }


        private static void StringOperationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("String Operations");
            ResultTester.CheckSolution("CC", CodeChef.StringOperations.Test.TestStringOperations());
        }


        private static void StringOperationsSTRS7Func()
        {
            StyleHelper.Space();
            StyleHelper.Title("String Operations 7");
            ResultTester.CheckSolution("CC", CodeChef.StringOperationsStrs7.Test.TestStringOperationsStrs7());
        }


        private static void AgeLimitFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Age Limit");
            ResultTester.SpecialTestCase("CC");
        }


        private static void NumberMirrorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number Mirror");
            ResultTester.SpecialTestCase("CC");
        }


        private static void EnormousInputTestFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Enormous Input Test");
            ResultTester.SpecialTestCase("CC");
        }


        private static void GoodTurnFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Good Turn");
            ResultTester.SpecialTestCase("CC");
        }


        private static void MinimumAbsoluteDifferenceinBSTFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Absolute Difference in BST");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SingleElementinaSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Single Element in a Sorted Array");
            ResultTester.CheckSolution("LC", LeetCode.SingleElementinaSortedArray.Test.TestSingleElementinaSortedArray());
        }


        private static void CapacityToShipPackagesWithinDDaysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Capacity To Ship Packages Within D Days");
            ResultTester.CheckSolution("LC", LeetCode.CapacityToShipPackagesWithinDDays.Test.TestCapacityToShipPackagesWithinDDays());
        }


        private static void IPOFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("IPO");
            ResultTester.CheckSolution("LC", LeetCode.IPO.Test.TestIPO());
        }


        private static void EditDistanceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Edit Distance");
            ResultTester.CheckSolution("LC", LeetCode.EditDistance.Test.TestEditDistance());
        }


        private static void SortanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort an Array");
            ResultTester.CheckSolution("LC", LeetCode.SortanArray.Test.TestSortanArray());
        }


        private static void StringCompressionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("String Compression");
            ResultTester.CheckSolution("LC", LeetCode.StringCompression.Test.TestStringCompression());
        }


        private static void DFSofGraphFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("DFS of Graph");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.DFSofGraph.Test.TestDFSofGraph());
        }


        private static void DetermineifTwoTreesareIdenticalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Determine if Two Trees are Identical");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void PrintfirstnFibonacciNumbersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Print first n Fibonacci Numbers");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Basic.PrintfirstnFibonacciNumbers.Test.TestCases());
        }


        private static void ReversearrayingroupsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse array in groups");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void OppositesAttractFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("OppositesAttract");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.OppositesAttract.Test.TestOppositesAttract());
        }


        private static void FindtheIndexoftheFirstOccurrenceinaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Index of the First Occurrence in a String");
            ResultTester.CheckSolution("LC", LeetCode.FindtheIndexoftheFirstOccurrenceinaString.Test.TestFindtheIndexoftheFirstOccurrenceinaString());
        }


        private static void CountSubarraysWithFixedBoundsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Subarrays With Fixed Bounds");
            ResultTester.CheckSolution("LC", LeetCode.CountSubarraysWithFixedBounds.Test.TestCases());
        }


        private static void JumpGameIVFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Jump Game IV");
            ResultTester.CheckSolution("LC", LeetCode.JumpGameIV.Test.TestJumpGameIV());
        }


        private static void KthMissingPositiveNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Kth Missing Positive Number");
            ResultTester.CheckSolution("LC", LeetCode.KthMissingPositiveNumber.Test.TestCases());
        }


        private static void MinimumTimetoCompleteTripsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Time to Complete Trips");
            ResultTester.CheckSolution("LC", LeetCode.MinimumTimetoCompleteTrips.Test.TestCases());
        }


        private static void KokoEatingBananasFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Koko Eating Bananas");
            ResultTester.CheckSolution("LC", LeetCode.KokoEatingBananas.Test.TestKokoEatingBananas());
        }


        private static void LeafSimilarTreesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Leaf-Similar Trees");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DiameterofBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Diameter of Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ConvertSortedArraytoBinarySearchTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert Sorted Array to Binary Search Tree");
            ResultTester.CheckSolution("LC", LeetCode.ConvertSortedArraytoBinarySearchTree.Test.TestConvertSortedArraytoBinarySearchTree());
        }


        private static void MaximumRunningTimeofNComputersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Running Time of N Computers");
            ResultTester.CheckSolution("LC", LeetCode.MaximumRunningTimeofNComputers.Test.TestCases());
        }


        private static void ImplementTriePrefixTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Implement Trie Prefix Tree");
            ResultTester.CheckSolution("LC", LeetCode.ImplementTriePrefixTree.Test.TestImplementTriePrefixTree());
        }


        private static void MinimumASCIIDeleteSumforTwoStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum ASCII Delete Sum for Two Strings");
            ResultTester.CheckSolution("LC", LeetCode.MinimumASCIIDeleteSumforTwoStrings.Test.TestCases());
        }


        private static void CombinationSumIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Combination Sum II");
            ResultTester.CheckSolution("LC", LeetCode.CombinationSumII.Test.TestCases());
        }


        private static void SquareNSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Square(n) Sum");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.SquareNSum.Test.TestStringrepeat());
        }


        private static void FindthesmallestintegerinthearrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the smallest integer in the array");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.Findthesmallestintegerinthearray.Test.TestFindthesmallestintegerinthearray());
        }


        private static void IshegonnasurviveFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Is he gonna survive");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.Ishegonnasurvive.Test.TestCases());
        }


        private static void SumofSeriesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Series");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.School.SumofSeries.Test.TestSumofSeries());
        }


        private static void PrintSecondLargestFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Print Second Largest");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.School.SecondLargest.Test.TestSecondLargest());
        }


        private static void StringrporprFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("String rp or pr");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Medium.Stringrporpr.Test.TestStringrporpr());
        }


        private static void ANeedleintheHaystackFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("A Needle in the Haystack");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.ANeedleintheHaystack.Test.TestCases());
        }


        private static void CanPlaceFlowersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Can Place Flowers");
            ResultTester.CheckSolution("LC", LeetCode.CanPlaceFlowers.Test.TestCanPlaceFlowers());
        }


        private static void ReverseaStackFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse a Stack");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void NumberofZeroFilledSubarraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Zero-Filled Subarrays");
            ResultTester.CheckSolution("LC", LeetCode.NumberofZeroFilledSubarrays.Test.TestCases());
        }


        private static void MinimumScoreofaPathBetweenTwoCitiesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Score of a Path Between Two Cities");
            ResultTester.CheckSolution("LC", LeetCode.MinimumScoreofaPathBetweenTwoCities.Test.TestCases());
        }


        private static void NumberofOperationstoMakeNetworkConnectedFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Operations to Make Network Connected");
            ResultTester.CheckSolution("LC", LeetCode.NumberofOperationstoMakeNetworkConnected.Test.TestNumberofOperationstoMakeNetworkConnected());
        }


        private static void RemoveStringSpacesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove String Spaces");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.RemoveStringSpaces.Test.TestRemoveStringSpaces());       
        }

        
        private static void CountingsheepFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Counting Sheep");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.Countingsheep.Test.TestCountingsheep());       
        }


        private static void ConvertaStringtoaNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert a String to a Number");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.ConvertaStringtoaNumber.Test.TestConvertaStringtoaNumber());       
        }


        private static void ReorderRoutestoMakeAllPathsLeadtotheCityZeroFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reorder Routes to Make All Paths Lead to the City Zero");
            ResultTester.CheckSolution("LC", LeetCode.ReorderRoutestoMakeAllPathsLeadtotheCityZero.Test.TestCases());
        }


        private static void CountUnreachablePairsofNodesinanUndirectedGraphFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Unreachable Pairs of Nodes in an Undirected Graph");
            ResultTester.CheckSolution("LC", LeetCode.CountUnreachablePairsofNodesinanUndirectedGraph.Test.TestCases());
        }


        private static void LongestCycleinaGraphFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Cycle in a Graph");
            ResultTester.CheckSolution("LC", LeetCode.LongestCycleinaGraph.Test.TestCases());
        }


        private static void MinimumPathSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Path Sum");
            ResultTester.CheckSolution("LC", LeetCode.MinimumPathSum.Test.TestMinimumPathSum());
        }


        private static void PrimeSubtractionOperationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Prime Subtraction Operation");
            ResultTester.CheckSolution("LC", LeetCode.PrimeSubtractionOperation.Test.TestCase());
        }


        private static void MinimumCostForTicketsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Cost For Tickets");
            ResultTester.CheckSolution("LC", LeetCode.MinimumCostForTickets.Test.TestMinimumCostForTickets());
        }


        private static void KItemsWiththeMaximumSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("K Items With the Maximum Sums");
            ResultTester.CheckSolution("LC", LeetCode.KItemsWiththeMaximumSum.Test.TestCases());
        }


        private static void CounttheSubstringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count the Substrings");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.CounttheSubstrings.Test.TestCounttheSubstrings());
        }


        private static void MinimumIntegerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Integer");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.MinimumInteger.Test.TestMinimumInteger());
        }


        private static void EvenSwapFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Even Swap");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Medium.EvenSwap.Test.TestEvenSwap());
        }


        private static void NumberofWaysofCuttingaPizzaFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Ways of Cutting a Pizza");
            ResultTester.CheckSolution("LC", LeetCode.NumberofWaysofCuttingaPizza.Test.TestCases());
        }


        private static void ReducingDishesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reducing Dishes");
            ResultTester.CheckSolution("LC", LeetCode.ReducingDishes.Test.TestReducingDishes());
        }


        private static void DesignUndergroundSystemFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Underground System");
            ResultTester.SpecialTestCase("LC");
        }


        private static void RemoveandReverseFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove and Reverse");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void ShyGeek()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shy Geek");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void NaryTreePreorderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("N-ary Tree Preorder Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PermutationinStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Permutation in String");
            ResultTester.CheckSolution ("LC", LeetCode.PermutationinString.Test.TestValidTriangleNumber());
        }


        private static void ReshapetheMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reshape the Matrix");
            ResultTester.CheckSolution("LC", LeetCode.ReshapetheMatrix.Test.TestReshapetheMatrix());
        }


        private static void ScrambleStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Scramble String");
            ResultTester.CheckSolution("LC", LeetCode.ScrambleString.Test.TestScrambleString());
        }


        private static void BinarySearchFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Search");
            ResultTester.CheckSolution("LC", LeetCode.BinarySearch.Test.TestBinarySearch());
        }


        private static void InsertintoaBinarySearchTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Insert into a Binary Search Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SearchintoaBinarySearchTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search in a Binary Search Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void KthLargestElementinaStreamFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Kth Largest Element in a Stream");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SuccessfulPairsofSpellsandPotionsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Successful Pairs of Spells and Potions");
            ResultTester.CheckSolution("LC", LeetCode.SuccessfulPairsofSpellsandPotions.Test.TestCases());
        }


        private static void BoatstoSavePeopleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Boats to Save People");
            ResultTester.CheckSolution("LC", LeetCode.BoatstoSavePeople.Test.TestBoatstoSavePeople());
        }


        private static void Remainderondividingby11Func()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remainder on dividing by 11");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.Remainderondividingby11.Test.TestRemainderondividingby11());
        }


        private static void MakeArrayElementsEqualFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Make Array Elements Equal");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.MakeArrayElementsEqual.Test.TestMakeArrayElementsEqual());
        }


        private static void OptimalPartitionofStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Optimal Partition of String");
            ResultTester.CheckSolution("LC", LeetCode.OptimalPartitionofString.Test.TestCases());
        }


        private static void MinimumStepsRequiredFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Steps Required");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Medium.MinimumStepsRequired.Test.TestMinimumStepsRequired());
        }


        private static void MinimizeMaximumofArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimize Maximum of Array");
            ResultTester.CheckSolution("LC", LeetCode.MinimizeMaximumofArray.Test.TestCases());
        }


        private static void EqualLeftandRightSubarraySumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Equal Left and Right Subarray Sum");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.EqualLeftandRightSubarraySum.Test.TestEqualLeftandRightSubarraySum());
        }


        private static void AddMinimumCharactersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Minimum Characters");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Medium.AddMinimumCharacters.Test.TestAddMinimumCharacters());
        }


        private static void NumberofGoodPathsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Good Paths");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DominantPairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Dominant Pairs");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void SpecialDigitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Special Digits");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void DivideInIncrementialGroupsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Divide In Incremential Groups");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void NumberofEnclavesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Enclaves");
            ResultTester.CheckSolution("LC", LeetCode.NumberofEnclaves.Test.TestNumberofEnclaves());
        }


        private static void RemoveStarsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Removing Stars From a String");
            ResultTester.CheckSolution("LC", LeetCode.RemovingStarsFromaString.Test.TestCases());
        }


        private static void NumberofClosedIslandsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Closed Islands");
            ResultTester.CheckSolution("LC", LeetCode.NumberofClosedIslands.Test.TestNumberofClosedIslands());
        }


        private static void CheckIfNandItsDoubleExistFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check If N and Its Double Exist");
            ResultTester.CheckSolution("LC", LeetCode.CheckIfNandItsDoubleExist.Test.TestCheckIfNandItsDoubleExist());
        }


        private static void MinimumReverseOperationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Reverse Operations");
            ResultTester.CheckSolution("LC", LeetCode.MinimumReverseOperations.Test.TestCase());
        }


        private static void LargestColorValueinaDirectedGraphFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Color Value in a Directed Graph");
            ResultTester.CheckSolution("LC", LeetCode.LargestColorValueinaDirectedGraph.Test.TestCases());
        }


        private static void SimplifyPathFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Simplify Path");
            ResultTester.CheckSolution("LC", LeetCode.SimplifyPath.Test.TestSimplifyPath());
        }


        private static void MaximumLengthFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Length");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Medium.MaximumLength.Test.TestMaximumLength());
        }


        private static void ValidateStackSequencesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Validate Stack Sequences");
            ResultTester.CheckSolution("LC", LeetCode.ValidateStackSequences.Test.TestValidateStackSequences());
        }


        private static void DeleteColumnstoMakeSortedFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("DeleteColumnstoMakeSorted");
            ResultTester.CheckSolution("LC", LeetCode.DeleteColumnstoMakeSorted.Test.TestDeleteColumnstoMakeSorted());
        }


        private static void LongestPalindromicSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Palindromic Subsequence");
            ResultTester.CheckSolution("LC", LeetCode.LongestPalindromicSubsequence.Test.TestLongestPalindromicSubsequence());
        }


        private static void MaximumValueofKCoinsFromPilesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Value of K Coins From Piles");
            ResultTester.CheckSolution("LC", LeetCode.MaximumValueofKCoinsFromPiles.Test.TestCases());
        }


        private static void ConcatenationofArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Concatenation of Array");
            ResultTester.CheckSolution("LC", LeetCode.ConcatenationofArray.Test.TestCases());
        }


        private static void NumberofWaystoFormaTargetStringGivenaDictionaryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Ways to Form a Target String Given a Dictionary");
            ResultTester.CheckSolution("LC", LeetCode.NumberofWaystoFormaTargetStringGivenaDictionary.Test.TestCases());
        }


        private static void BestTeamWithNoConflictsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Team With No Conflicts");
            ResultTester.CheckSolution("LC", LeetCode.BestTeamWithNoConflicts.Test.TestCases());
        }


        private static void KidsWiththeGreatestNumberofCandiesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Kids With the Greatest Number of Candies");
            ResultTester.CheckSolution("LC", LeetCode.KidsWiththeGreatestNumberofCandies.Test.TestKidsWiththeGreatestNumberofCandies());
        }


        private static void MergeStringsAlternatelyFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Merge Strings Alternately");
            ResultTester.CheckSolution("LC", LeetCode.MergeStringsAlternately.Test.TestCases());
        }


        private static void RomantoIntegerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Roman to Integer");
            ResultTester.CheckSolution("LC", LeetCode.RomantoInteger.Test.TestRomantoInteger());
        }


        private static void ProfitableSchemesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Profitable Schemes");
            ResultTester.CheckSolution("LC", LeetCode.ProfitableSchemes.Test.TestProfitableSchemes());
        }


        private static void MinimumInsertionStepstoMakeaStringPalindromeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Insertion Steps to Make a String Palindrome");
            ResultTester.CheckSolution("LC", LeetCode.MinimumInsertionStepstoMakeaStringPalindrome.Test.TestDecryptStringfromAlphabettoIntegerMapping());
        }


        private static void BestPokerHandFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Poker Hand");
            ResultTester.CheckSolution("LC", LeetCode.BestPokerHand.Test.TestCases());
        }


        private static void SmallestNumberinInfiniteSetFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Smallest Number in Infinite Set");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DeleteNodeinaBSTFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Delete Node in a BST");
            ResultTester.SpecialTestCase("LC");
        }


        private static void AddTwoNumbersIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Two Numbers II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void RestoreTheArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Restore The Array");
            ResultTester.CheckSolution("LC", LeetCode.RestoreTheArray.Test.TestRestoreTheArray());
        }


        private static void LastStoneWeightFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Last Stone Weight");
            ResultTester.CheckSolution("LC", LeetCode.LastStoneWeight.Test.TestLastStoneWeight());
        }


        private static void AddDigitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Digits");
            ResultTester.CheckSolution("LC", LeetCode.AddDigits.Test.TestAddDigits());
        }


        private static void ValidAnagramFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Anagram");
            ResultTester.CheckSolution("LC", LeetCode.ValidAnagram.Test.TestValidAnagram());
        }


        private static void BulbSwitcherFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bulb Switcher");
            ResultTester.CheckSolution("LC", LeetCode.BulbSwitcher.Test.TestBulbSwitcher());
        }


        private static void FindtheDifferenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Difference");
            ResultTester.CheckSolution("LC", LeetCode.FindtheDifference.Test.TestFindtheDifference());
        }


        private static void RepeatedSubstringPatternFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Repeated Substring Pattern");
            ResultTester.CheckSolution("LC", LeetCode.RepeatedSubstringPattern.Test.TestRepeatedSubstringPattern());
        }


        private static void MinimumNumberofArrowstoBurstBalloonsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Arrows to Burst Balloons");
            ResultTester.CheckSolution("LC", LeetCode.MinimumNumberofArrowstoBurstBalloons.Test.TestMinimumNumberofArrowstoBurstBalloons());
        }


        private static void MoveZeroesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Move Zeroes");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FirstBadVersionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("First Bad Version");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PlusOneFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Plus One");
            ResultTester.CheckSolution("LC", LeetCode.PlusOne.Test.TestPlusOne());
        }


        private static void AverageSalaryExcludingtheMinimumandMaximumSalaryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Average Salary Excluding the Minimum and Maximum Salary");
            ResultTester.CheckSolution("LC", LeetCode.AverageSalaryExcludingtheMinimumandMaximumSalary.Test.TestCases());
        }


        private static void NonoverlappingIntervalsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Non-overlapping Intervals");
            ResultTester.CheckSolution("LC", LeetCode.NonoverlappingIntervals.Test.TestNonoverlappingIntervals());
        }


        private static void SignoftheProductofanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sign of the Product of an Array");
            ResultTester.CheckSolution("LC", LeetCode.SignoftheProductofanArray.Test.TestCases());
        }


        private static void CanMakeArithmeticProgressionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Can Make Arithmetic Progression From Sequence");
            ResultTester.CheckSolution("LC", LeetCode.CanMakeArithmeticProgressionFromSequence.Test.TestCases());
        }


        private static void MonotonicArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Monotonic Array");
            ResultTester.CheckSolution("LC", LeetCode.MonotonicArray.Test.TestMonotonicArray());
        }


        private static void LengthofLastWordFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Length of Last Word");
            ResultTester.CheckSolution("LC", LeetCode.LengthofLastWord.Test.TestLengthofLastWord());
        }


        private static void ToLowerCaseFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("To Lower Case");
            ResultTester.CheckSolution("LC", LeetCode.ToLowerCase.Test.TestToLowerCase());
        }


        private static void FindSmallestLetterGreaterThanTargetFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Smallest Letter Greater Than Target");
            ResultTester.CheckSolution("LC", LeetCode.FindSmallestLetterGreaterThanTarget.Test.TestFindSmallestLetterGreaterThanTarget());
        }


        private static void CountNegativeNumbersinaSortedMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Negative Numbers in a Sorted Matrix");
            ResultTester.CheckSolution("LC", LeetCode.CountNegativeNumbersinaSortedMatrix.Test.TestCountNegativeNumbersinaSortedMatrix());
        }


        private static void ValidPerfectSquareFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Perfect Square");
            ResultTester.CheckSolution("LC", LeetCode.ValidPerfectSquare.Test.TestValidPerfectSquare());
        }


        private static void ArrangingCoinsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Arranging Coins");
            ResultTester.CheckSolution("LC", LeetCode.ArrangingCoins.Test.TestArrangingCoins());
        }


        private static void BaseballGameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Baseball Game");
            ResultTester.CheckSolution("LC", LeetCode.BaseballGame.Test.TestBaseballGame());
        }


        private static void FindAllAnagramsinaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find All Anagrams in a String");
            ResultTester.CheckSolution("LC", LeetCode.FindAllAnagramsinaString.Test.TestFindAllAnagramsinaString());
        }


        private static void PathSumIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Path Sum III");
            ResultTester.SpecialTestCase("LC");
        }


        private static void RobotReturntoOriginFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Robot Return to Origin");
            ResultTester.CheckSolution("LC", LeetCode.RobotReturntoOrigin.Test.TestRobotReturntoOrigin());
        }


        private static void TwoSumIVInputisaBSTFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Two Sum IV - Input is a BST");
            ResultTester.SpecialTestCase("LC");
        }


        private static void TwoSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Two Sum");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FindDuplicateSubtreesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Duplicate Subtrees");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FindWinneronaTicTacToeGameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Winner on a Tic Tac Toe Game");
            ResultTester.CheckSolution("LC", LeetCode.FindWinneronaTicTacToeGame.Test.TestFindWinneronaTicTacToeGame());
        }


        private static void RobotBoundedInCircleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Robot Bounded In Circle");
            ResultTester.CheckSolution("LC", LeetCode.RobotBoundedInCircle.Test.TestRobotBoundedInCircle());
        }


        private static void UncrossedLinesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Uncrossed Lines");
            ResultTester.CheckSolution("LC", LeetCode.UncrossedLines.Test.TestUncrossedLines());
        }


        private static void MatrixDiagonalSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Matrix Diagonal Sum");
            ResultTester.CheckSolution("LC", LeetCode.MatrixDiagonalSum.Test.TestCases());
        }


        private static void LemonadeChangeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Lemonade Change");
            ResultTester.CheckSolution("LC", LeetCode.LemonadeChange.Test.TestLemonadeChange());
        }


        private static void LargestPerimeterTriangleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Perimeter Triangle");
            ResultTester.CheckSolution("LC", LeetCode.LargestPerimeterTriangle.Test.TestLargestPerimeterTriangle());
        }


        private static void SubarraySumsDivisiblebyKFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subarray Sums Divisible by K");
            ResultTester.CheckSolution("LC", LeetCode.SubarraySumsDivisiblebyK.Test.TestSubarraySumsDivisiblebyK());
        }


        private static void CheckCompletenessofaBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check Completeness of a Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CheckIfItIsaStraightLineFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check If It Is a Straight Line");
            ResultTester.CheckSolution("LC", LeetCode.CheckIfItIsaStraightLine.Test.TestCheckIfItIsaStraightLine());
        }


        private static void MultiplyStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Multiply Strings");
            ResultTester.CheckSolution("LC", LeetCode.MultiplyStrings.Test.TestMultiplyStrings());
        }


        private static void PowxnFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Pow(x, n)");
            ResultTester.CheckSolution("LC", LeetCode.Powxn.Test.TestPowxn());
        }


        private static void ReverseVowelsofaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Vowels of a String");
            ResultTester.CheckSolution("LC", LeetCode.ReverseVowelsofaString.Test.TestReverseVowelsofaString());
        }


        private static void ReverseStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse String");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ReverseWordsinaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Words in a String");
            ResultTester.CheckSolution("LC", LeetCode.ReverseWordsinaString.Test.TestReverseWordsinaString());
        }


        private static void EvaluateReversePolishNotationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Evaluate Reverse Polish Notation");
            ResultTester.CheckSolution("LC", LeetCode.EvaluateReversePolishNotation.Test.TestEvaluateReversePolishNotation());
        }


        private static void ProductofArrayExceptSelfFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Product of Array Except Self");
            ResultTester.CheckSolution("LC", LeetCode.ProductofArrayExceptSelf.Test.TestProductofArrayExceptSelf());
        }


        private static void Dota2SenateFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Dota2 Senate");
            ResultTester.CheckSolution("LC", LeetCode.Dota2Senate.Test.TestDota2Senate());
        }


        private static void MinimumFlipstoMakeaORbEqualtocFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Flips to Make a OR b Equal to c");
            ResultTester.CheckSolution("LC", LeetCode.MinimumFlipstoMakeaORbEqualtoc.Test.TestMinimumFlipstoMakeaORbEqualtoc());
        }


        private static void CountingBitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Counting Bits");
            ResultTester.CheckSolution("LC", LeetCode.CountingBits.Test.TestCountingBits());
        }


        private static void BestTimetoBuyandSellStockwithTransactionFeeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Time to Buy and Sell Stock with Transaction Fee");
            ResultTester.CheckSolution("LC", LeetCode.BestTimetoBuyandSellStockwithTransactionFee.Test.TestBestTimetoBuyandSellStockwithTransactionFee());
        }


        private static void IncreasingTripletSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Increasing Triplet Subsequence");
            ResultTester.CheckSolution("LC", LeetCode.IncreasingTripletSubsequence.Test.TestIncreasingTripletSubsequence());
        }


        private static void IsSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Is Subsequence");
            ResultTester.CheckSolution("LC", LeetCode.IsSubsequence.Test.TestIsSubsequence());
        }


        private static void MaximumNumberofVowelsinaSubstringofGivenLengthFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Vowels in a Substring of Given Length");
            ResultTester.CheckSolution("LC", LeetCode.MaximumNumberofVowelsinaSubstringofGivenLength.Test.TestCases());
        }


        private static void DominoandTrominoTilingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Domino and Tromino Tiling");
            ResultTester.CheckSolution("LC", LeetCode.DominoandTrominoTiling.Test.TestDominoandTrominoTiling());
        }


        private static void MinCostClimbingStairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Min Cost Climbing Stairs");
            ResultTester.CheckSolution("LC", LeetCode.MinCostClimbingStairs.Test.TestMinCostClimbingStairs());    
        }


        private static void ContainerWithMostWaterFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Container With Most Water");
            ResultTester.CheckSolution("LC", LeetCode.ContainerWithMostWater.Test.TestContainerWithMostWater());    
        }


        private static void MaxNumberofKSumPairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Number of K-Sum Pairs");
            ResultTester.CheckSolution("LC", LeetCode.MaxNumberofKSumPairs.Test.TestCases());
        }


        private static void MaximumAverageSubarrayIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Average Subarray I");
            ResultTester.CheckSolution("LC", LeetCode.MaximumAverageSubarrayI.Test.TestMaximumAverageSubarrayI());
        }


        private static void UniquePathsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Unique Paths");
            ResultTester.CheckSolution("LC", LeetCode.UniquePaths.Test.TestUniquePaths());
        }


        private static void MaxConsecutiveOnesIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Consecutive Ones III");
            ResultTester.CheckSolution("LC", LeetCode.MaxConsecutiveOnesIII.Test.TestMaxConsecutiveOnesIII());
        }


        private static void LongestSubarrayof1sAfterDeletingOneElementFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Subarray of 1's After Deleting One Element");
            ResultTester.CheckSolution("LC", LeetCode.LongestSubarrayof1sAfterDeletingOneElement.Test.TestCases());
        }


        private static void FindtheHighestAltitudeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Highest Altitude");
            ResultTester.CheckSolution("LC", LeetCode.FindtheHighestAltitude.Test.TestCases());
        }


        private static void FindPivotIndexFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Pivot Index");
            ResultTester.CheckSolution("LC", LeetCode.FindPivotIndex.Test.TestFindPivotIndex());
        }


        private static void NumberofProvincesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Provinces");
            ResultTester.CheckSolution("LC", LeetCode.NumberofProvinces.Test.TestNumberofProvinces());
        }


        private static void NumberofSubsequencesThatSatisfytheGivenSumConditionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Subsequences That Satisfy the Given Sum Condition");
            ResultTester.CheckSolution("LC", LeetCode.NumberofSubsequencesThatSatisfytheGivenSumCondition.Test.TestCases());
        }


        private static void FindtheLongestValidObstacleCourseatEachPositionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Subsequences That Satisfy the Given Sum Condition");
            ResultTester.CheckSolution("LC", LeetCode.FindtheLongestValidObstacleCourseatEachPosition.Test.TestCases());
        }


        private static void AsteroidCollisionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Asteroid Collision");
            ResultTester.CheckSolution("LC", LeetCode.AsteroidCollision.Test.TestAsteroidCollision());
        }


        private static void FindPeakElementFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Peak Element");
            ResultTester.CheckSolution("LC", LeetCode.FindPeakElement.Test.TestFindPeakElement());
        }


        private static void AccessingcharactersofaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Accessing characters of a String");
            ResultTester.CheckSolution("CC", CodeChef.AccessingcharactersofaString.Test.TestAccessingcharactersofaString());
        }


        private static void MaximizeScoreAfterNOperationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximize Score After N Operations");
            ResultTester.CheckSolution("LC", LeetCode.MaximizeScoreAfterNOperations.Test.TestCases());
        }


        private static void MaximumAscendingSubarraySumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Ascending Subarray Sum");
            ResultTester.CheckSolution("LC", LeetCode.MaximumAscendingSubarraySum.Test.TestCases());
        }


        private static void UserInputUsrs1Func()
        {
            StyleHelper.Space();
            StyleHelper.Title("User Input USRS 1");
            ResultTester.SpecialTestCase("CC");
        }


        private static void NextRoundFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Next Round");
            ResultTester.CheckSolution("CF", CodeForces.NextRound.Test.TestCases());
        }


        private static void HulkFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Hulk");
            ResultTester.SpecialTestCase("CF");
        }


        private static void IWannaBetheGuyFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("I Wanna Be the Guy");
            ResultTester.SpecialTestCase("CF");
        }


        private static void DivisibilityProblemFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Divisibility Problem");
            ResultTester.SpecialTestCase("CF");
        }


        private static void ArrivaloftheGeneralFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Arrival of the General");
            ResultTester.SpecialTestCase("CF");
        }


        private static void WateringPlantsIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Watering Plants II");
            ResultTester.CheckSolution("LC", LeetCode.WateringPlantsII.Test.TestCases());
        }


        private static void MaximumNumberofCoinsYouCanGetFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Coins You Can Get");
            ResultTester.CheckSolution("LC", LeetCode.MaximumNumberofCoinsYouCanGet.Test.TestCases());
        }


        private static void DiagonalTraverseIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Diagonal Traverse II");
            ResultTester.CheckSolution("LC", LeetCode.DiagonalTraverseII.Test.TestCases());
        }


        private static void CountNicePairsinanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Nice Pairs in an Array");
            ResultTester.CheckSolution("LC", LeetCode.CountNicePairsinanArray.Test.TestCases());
        }


        private static void CarPoolingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Car Pooling");
            ResultTester.CheckSolution("LC", LeetCode.CarPooling.Test.TestCarPooling());
        }


        private static void GreatestCommonDivisorofStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Greatest Common Divisor of Strings");
            ResultTester.CheckSolution("LC", LeetCode.GreatestCommonDivisorofStrings.Test.TestGreatestCommonDivisorofStrings());
        }


        private static void ShortestPathinBinaryMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Path in Binary Matrix");
            ResultTester.CheckSolution("LC", LeetCode.ShortestPathinBinaryMatrix.Test.TestShortestPathinBinaryMatrix());
        }


        private static void CountWaysToBuildGoodStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Ways To Build Good Strings");
            ResultTester.CheckSolution("LC", LeetCode.CountWaysToBuildGoodStrings.Test.TestCases());
        }


        private static void TotalCosttoHireKWorkersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Total Cost to Hire K Workers");
            ResultTester.CheckSolution("LC", LeetCode.TotalCosttoHireKWorkers.Test.TestCases());
        }


        private static void MaximumSubsequenceScoreFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Subsequence Score");
            ResultTester.CheckSolution("LC", LeetCode.MaximumSubsequenceScore.Test.TestCases());
        }


        private static void KthLargestElementinanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Kth Largest Element in an Array");
            ResultTester.CheckSolution("LC", LeetCode.KthLargestElementinanArray.Test.TestKthLargestElementinanArray());
        }

        
        private static void EqualRowandColumnPairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Equal Row and Column Pairs");
            ResultTester.CheckSolution("LC", LeetCode.EqualRowandColumnPairs.Test.TestCases());
        }


        private static void UniqueNumberofOccurrencesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Unique Number of Occurrences");
            ResultTester.CheckSolution("LC", LeetCode.UniqueNumberofOccurrences.Test.TestUniqueNumberofOccurrences());
        }


        private static void DetermineifTwoStringsAreCloseFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Determine if Two Strings Are Close");
            ResultTester.CheckSolution("LC", LeetCode.DetermineifTwoStringsAreClose.Test.TestCases());
        }


        private static void IsGraphBipartiteFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Is Graph Bipartite");
            ResultTester.CheckSolution("LC", LeetCode.IsGraphBipartite.Test.TestIsGraphBipartite());
        }


        private static void LetterCasePermutationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Letter Case Permutation");
            ResultTester.CheckSolution("LC", LeetCode.LetterCasePermutation.Test.TestLetterCasePermutation());
        }

        
        private static void MinimumDistanceBetweenBSTNodesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Distance Between BST Nodes");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaxPointsonaLineFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Points on a Line");
            ResultTester.SpecialTestCase("LC");
        }


        private static void BinaryTreePostorderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Level Order Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void LowestCommonAncestorofaBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Lowest Common Ancestor of a Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void OddEvenLinkedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Odd Even Linked List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void LowestCommonAncestorofaBinarySearchTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Lowest Common Ancestor of a Binary Search Tree");
            ResultTester.SpecialTestCase("LC");
        }

        
        private static void HouseRobberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("House Robber");
            ResultTester.SpecialTestCase("LC");
        }


        private static void HouseRobberIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("House Robber III");
            ResultTester.SpecialTestCase("LC");
        }


        private static void HouseRobberIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("House Robber II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DesignAddandSearchWordsDataStructureFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Add and Search Words Data Structure");
            ResultTester.SpecialTestCase("LC");
        }


        private static void NextPermutationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Next Permutation");
            ResultTester.CheckSolution("LC", LeetCode.NextPermutation.Test.TestNextPermutation());
        }


        private static void ShortestBridgeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Bridge");
            ResultTester.CheckSolution("LC", LeetCode.ShortestBridge.Test.TestShortestBridge());
        }


        private static void NumberofRecentCallsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Recent Calls");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PeekingIteratorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Peeking Iterator");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FindtheDuplicateNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Duplicate Number");
            ResultTester.CheckSolution("LC", LeetCode.FindtheDuplicateNumber.Test.TestFindtheDuplicateNumber());
        }


        private static void New21GameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("New 21 Game");
            ResultTester.CheckSolution("LC", LeetCode.New21Game.Test.TestNew21Game());
        }


        private static void FindMinimuminRotatedSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Minimum in Rotated Sorted Array");
            ResultTester.CheckSolution("LC", LeetCode.FindMinimuminRotatedSortedArray.Test.TestFindMinimuminRotatedSortedArray());
        }


        private static void StoneGameIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Stone Game II");
            ResultTester.CheckSolution("LC", LeetCode.StoneGameII.Solution.TestStoneGameII());
        }


        private static void PermutationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Permutations");
            ResultTester.CheckSolution("LC", LeetCode.Permutations.Test.TestPermutations());
        }


        private static void PermutationsIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Permutations II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ReverseLinkedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Linked List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void IsomorphicStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Isomorphic Strings");
            ResultTester.SpecialTestCase("LC");
        }


        private static void RemoveLinkedListElementsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Linked List Elements");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CourseScheduleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Course Schedule");
            ResultTester.CheckSolution("LC", LeetCode.CourseSchedule.Test.TestCourseSchedule());
        }


        private static void StoneGameIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Stone Game III");
            ResultTester.CheckSolution("LC", LeetCode.StoneGameIII.Test.TestStoneGameIII());
        }


        private static void MinimumCosttoCutaStickFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Cost to Cut a Stick");
            ResultTester.CheckSolution("LC", LeetCode.MinimumCosttoCutaStick.Test.TestCases());
        }


        private static void MajorityElementFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Majority Element");
            ResultTester.CheckSolution("LC", LeetCode.MajorityElement.Test.TestMajorityElement());
        }


        private static void GoalParserInterpretationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Goal Parser Interpretation");
            ResultTester.CheckSolution("LC", LeetCode.GoalParserInterpretation.Test.TestCases());
        }


        private static void FloodFillFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Flood Fill");
            ResultTester.CheckSolution("LC", LeetCode.FloodFill.Test.TestFloodFill());
        }


        private static void HappyNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Happy Number");
            ResultTester.CheckSolution("LC", LeetCode.HappyNumber.Test.TestHappyNumber());
        }


        private static void DecryptStringfromAlphabettoIntegerMappingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Decrypt String from Alphabet to Integer Mapping");
            ResultTester.CheckSolution("LC", LeetCode.DecryptStringfromAlphabettoIntegerMapping.Test.TestDecryptStringfromAlphabettoIntegerMapping());
        }


        private static void ConvertBinaryNumberinaLinkedListtoIntegerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert Binary Number in a Linked List to Integer");
            ResultTester.SpecialTestCase("LC");
        }


        private static void TheKWeakestRowsinaMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("The K Weakest Rows in a Matrix");
            ResultTester.CheckSolution("LC", LeetCode.TheKWeakestRowsinaMatrix.Test.TestTheKWeakestRowsinaMatrix());
        }


        private static void CheckifOneStringSwapCanMakeStringsEqualFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check if One String Swap Can Make Strings Equal");
            ResultTester.CheckSolution("LC", LeetCode.CheckifOneStringSwapCanMakeStringsEqual.Test.TestCases());
        }


        private static void ThreeSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("3Sum");
            ResultTester.CheckSolution("LC", LeetCode.ThreeSum.Test.TestThreeSum());
        }


        private static void PeakIndexinaMountainArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Peak Index in a Mountain Array");
            ResultTester.CheckSolution("LC", LeetCode.PeakIndexinaMountainArray.Test.TestPeakIndexinaMountainArray());
        }


        private static void KeysandRoomsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Keys and Rooms");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SimilarStringGroupsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Similar String Groups");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SubtracttheProductandSumofDigitsofanIntegerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subtract the Product and Sum of Digits of an Integer");
            ResultTester.CheckSolution("LC", LeetCode.SubtracttheProductandSumofDigitsofanInteger.Test.TestSubtracttheProductandSumofDigitsofanInteger());
        }


        private static void DeleteandEarnFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Delete and Earn");
            ResultTester.CheckSolution("LC", LeetCode.DeleteandEarn.Test.TestDeleteandEarn());
        }


        private static void DailyTemperaturesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Daily Temperatures");
            ResultTester.CheckSolution("LC", LeetCode.DailyTemperatures.Test.TestDailyTemperatures());
        }


        private static void SpecialArrayWithXElementsGreaterThanorEqualXFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Special Array With X Elements Greater Than or Equal X");
            ResultTester.CheckSolution("LC", LeetCode.SpecialArrayWithXElementsGreaterThanorEqualX.Test.TestCases());
        }


        private static void TwoSumIIInputArrayIsSortedFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Two Sum II - Input Array Is Sorted");
            ResultTester.CheckSolution("LC", LeetCode.TwoSumIIInputArrayIsSorted.Test.TestTwoSumIIInputArrayIsSorted());
        }


        private static void FindFirstandLastPositionofElementinSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find First and Last Position of Element in Sorted Array");
            ResultTester.CheckSolution("LC", LeetCode.FindFirstandLastPositionofElementinSortedArray.Test.TestFindFirstandLastPositionofElementinSortedArray());
        }


        private static void SqrtxFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sqrt(x)");
            ResultTester.CheckSolution("LC", LeetCode.Sqrtx.Test.TestSqrtx());
        }


        private static void FindtheDistanceValueBetweenTwoArraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Distance Value Between Two Arrays");
            ResultTester.CheckSolution("LC", LeetCode.FindtheDistanceValueBetweenTwoArrays.Test.TestFindtheDistanceValueBetweenTwoArrays());
        }


        private static void MergeIntervalsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Merge Intervals");
            ResultTester.CheckSolution("LC", LeetCode.MergeIntervals.Test.TestInsertInterval());
        }


        private static void SortColorsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort Colors");
            ResultTester.SpecialTestCase("LC");
        }


        private static void TimeNeededtoInformAllEmployeesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Time Needed to Inform All Employees");
            ResultTester.CheckSolution("LC", LeetCode.TimeNeededtoInformAllEmployees.Test.TestTimeNeededtoInformAllEmployees());
        }


        private static void LongestZigZagPathinaBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest ZigZag Path in a Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DesignCircularQueueFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Circular Queue");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MergeTwoBinaryTreesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Merge Two Binary Trees");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SumofSquareNumbersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Square Numbers");
            ResultTester.CheckSolution("LC", LeetCode.SumofSquareNumbers.Test.TestSumofSquareNumbers());
        }


        private static void DecodeWaysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Decode Ways");
            ResultTester.CheckSolution("LC", LeetCode.DecodeWays.Test.TestDecodeWays());
        }


        private static void ArithmeticSlicesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Arithmetic Slices");
            ResultTester.CheckSolution("LC", LeetCode.ArithmeticSlices.Test.TestArithmeticSlices());
        }


        private static void SumofAllOddLengthSubarraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of All Odd Length Subarrays");
            ResultTester.CheckSolution("LC", LeetCode.SumofAllOddLengthSubarrays.Test.TestCases());
        }


        private static void RemoveMaxNumberofEdgestoKeepGraphFullyTraversableFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Max Number of Edges to Keep Graph Fully Traversable");
            ResultTester.SpecialTestCase("LC");
        }


        private static void NextGreaterElementIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Next Greater Element I");
            ResultTester.CheckSolution("LC", LeetCode.NextGreaterElementI.Test.TestNextGreaterElementI());
        }


        private static void SquaresofaSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Squares of a Sorted Array");
            ResultTester.CheckSolution("LC", LeetCode.SquaresofaSortedArray.Test.TestSquaresofaSortedArray());
        }


        private static void RotateArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Rotate Array");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FibonacciNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fibonacci Number");
            ResultTester.CheckSolution("LC", LeetCode.FibonacciNumber.Test.TestFibonacciNumber());
        }


        private static void FindNearestPointThatHastheSameXorYCoordinateFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Nearest Point That Has the Same X or Y Coordinate");
            ResultTester.CheckSolution("LC", LeetCode.FindNearestPointThatHastheSameXorYCoordinate.Test.TestCases());
        }


        private static void Numberof1BitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of 1 Bits");
            ResultTester.CheckSolution("LC", LeetCode.Numberof1Bits.Test.TestNumberof1Bits());
        }


        private static void SimpleArraySumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Simple Array Sum");
            ResultTester.CheckSolution("HR", HackerRank.SimpleArraySum.Test.TestSimpleArraySum());
        }


        private static void SolveMeFirstFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Solve Me First");
            ResultTester.CheckSolution("HR", HackerRank.SolveMeFirst.Test.TestSolveMeFirst());
        }


        private static void UglyNumberIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ugly Number II");
            ResultTester.CheckSolution("LC", LeetCode.UglyNumberII.Test.TestUglyNumberII());
        }


        private static void UniqueBinarySearchTreesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Unique Binary Search Trees");
            ResultTester.CheckSolution("LC", LeetCode.UniqueBinarySearchTrees.Test.TestUniqueBinarySearchTrees());
        }


        private static void SortIntegersbyTheNumberof1BitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort Integers by The Number of 1 Bits");
            ResultTester.CheckSolution("LC", LeetCode.SortIntegersbyTheNumberof1Bits.Test.TestSortIntegersbyTheNumberof1Bits());
        }


        private static void SearchinRotatedSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search in Rotated Sorted Array");
            ResultTester.CheckSolution("LC", LeetCode.SearchinRotatedSortedArray.Test.TestSearchinRotatedSortedArray());
        }


        private static void MaximumDistanceBetweenaPairofValuesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Distance Between a Pair of Values");
            ResultTester.CheckSolution("LC", LeetCode.MaximumDistanceBetweenaPairofValues.Test.TestCases());
        }


        private static void TrappingRainWaterFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Trapping Rain Water");
            ResultTester.CheckSolution("LC", LeetCode.TrappingRainWater.Test.TestTrappingRainWater());
        }


        private static void WordBreakFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word Break");
            ResultTester.CheckSolution("LC", LeetCode.WordBreak.Test.TestWordBreak());
        }


        private static void ZeroOneMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("01 Matrix");
            ResultTester.CheckSolution("LC", LeetCode.ZeroOneMatrix.Test.TestZeroOneMatrix());
        }


        private static void MaxAreaofIslandFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Area of Island");
            ResultTester.CheckSolution("LC", LeetCode.MaxAreaofIsland.Test.TestMaxAreaofIsland());
        }


        private static void PowerofTwoFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Power of Two");
            ResultTester.CheckSolution("LC", LeetCode.PowerofTwo.Test.TestPowerofTwo());
        }


        private static void ReverseWordsinaStringIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Power of Two");
            ResultTester.CheckSolution("LC", LeetCode.ReverseWordsinaStringIII.Test.TestReverseWordsinaStringIII());
        }


        private static void TriangleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Tringle");
            ResultTester.CheckSolution("LC", LeetCode.Triangle.Test.TestTriangle());
        }


        private static void PascalsTriangleIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Pascals Triangle II");
            ResultTester.CheckSolution("LC", LeetCode.PascalsTriangleII.Test.TestPascalsTriangleII());
        }


        private static void LongestSubstringWithoutRepeatingCharactersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Substring Without Repeating Characters");
            ResultTester.CheckSolution("LC", LeetCode.LongestSubstringWithoutRepeatingCharacters.Test.TestLongestSubstringWithoutRepeatingCharacters());
        }


        private static void AVeryBigSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("A Very Big Sum");
            ResultTester.CheckSolution("HR", HackerRank.AVeryBigSum.Test.TestCases());
        }


        private static void ReverseBitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Bits");
            ResultTester.CheckSolution("LC", LeetCode.ReverseBits.Test.TestReverseBits());
        }


        private static void UniquePathsIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Unique Paths II");
            ResultTester.CheckSolution("LC", LeetCode.UniquePathsII.Test.TestUniquePathsII());
        }


        private static void MaximalSquareFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximal Square");
            ResultTester.CheckSolution("LC", LeetCode.MaximalSquare.Test.TestMaximalSquare());
        }


        private static void JumpGameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Jump Game");
            ResultTester.CheckSolution("LC", LeetCode.JumpGame.Test.TestJumpGame());
        }


        private static void PathSumIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Path Sum II");
            ResultTester.SpecialTestCase("LC");
        }

        
        private static void BinaryTreeInorderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Inorder Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaximumValueataGivenIndexinaBoundedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Value at a Given Index in a Bounded Array");
            ResultTester.CheckSolution("LC", LeetCode.MaximumValueataGivenIndexinaBoundedArray.Test.TestCases());
        }


        private static void BinarySearchTreeIteratorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Search Tree Iterator");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PathSumFuncFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Path Sum Func");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ConvertSortedListtoBinarySearchTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("ConvertSorted List to Binary Search Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void KthSmallestElementinaBSTFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Kth Smallest Element in a BST");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ConstructBinaryTreefromPreorderandInorderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Construct Binary Tree from Preorder and Inorder Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaximumDepthofBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Depth of Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }
        

        private static void BinaryTreeZigzagLevelOrderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Zigzag Level Order Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void BinaryTreeLevelOrderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Level Order Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SymmetricTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Symmetric Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SameTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Same Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ValidateBinarySearchTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Validate Binary Search Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaximumValueofaStringinanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Value of a String in an Array");
            ResultTester.CheckSolution("LC", LeetCode.MaximumValueofaStringinanArray.Test.TestCases());
        }


        private static void SnapshotArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Value of a String in an Array");
            ResultTester.SpecialTestCase("LC");
        }


        private static void LongestIncreasingSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Increasing Subsequence");
            ResultTester.CheckSolution("LC", LeetCode.LongestIncreasingSubsequence.Test.TestLongestIncreasingSubsequence());
        }


        private static void WiggleSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Wiggle Subsequence");
            ResultTester.CheckSolution("LC", LeetCode.WiggleSubsequence.Test.TestWiggleSubsequence());
        }


        private static void LongestPalindromicSubstringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Palindromic Substring");
            ResultTester.CheckSolution("LC", LeetCode.LongestPalindromicSubstring.Test.TestLongestPalindromicSubstring());
        }


        private static void LongestPalindromeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Palindrome");
            ResultTester.CheckSolution("LC", LeetCode.LongestPalindrome.Test.TestLongestPalindrome());
        }


        private static void RangeSumQuery2DImmutableFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Range Sum Query 2D - Immutable");
            ResultTester.SpecialTestCase("LC");
        }


        private static void BestTimetoBuyandSellStockwithCooldownFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Time to Buy and Sell Stock with Cooldown");
            ResultTester.CheckSolution("LC", LeetCode.BestTimetoBuyandSellStockwithCooldown.Test.TestBestTimetoBuyandSellStockwithCooldown());
        }
        

        private static void GuessNumberHigherorLowerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Guess Number Higher or Lower");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SumofLeftLeavesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Left Leaves");
            ResultTester.SpecialTestCase("LC");
        }


        private static void EvaluateDivisionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Evaluate Division");
            ResultTester.CheckSolution("LC", LeetCode.EvaluateDivision.Test.TestEvaluateDivision());
        }


        private static void DecodeStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Decode String");
            ResultTester.CheckSolution("LC", LeetCode.DecodeString.Test.TestDecodeString());
        }


        private static void BestTimetoBuyandSellStockIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Time to Buy and Sell Stock II");
            ResultTester.CheckSolution("LC", LeetCode.BestTimetoBuyandSellStockII.Test.TestBestTimetoBuyandSellStockII());
        }


        private static void BestSightseeingPairFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Sightseeing Pair");
            ResultTester.CheckSolution("LC", LeetCode.BestSightseeingPair.Test.TestBestSightseeingPair());
        }


        private static void WordPatternFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word Pattern");
            ResultTester.CheckSolution("LC", LeetCode.WordPattern.Test.TestWordPattern());
        }


        private static void SerializeandDeserializeBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Serialize and Deserialize Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MatrixBlockSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Matrix Block Sum");
            ResultTester.CheckSolution("LC", LeetCode.MatrixBlockSum.Test.TestMatrixBlockSum());
        }


        private static void SummaryRangesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Summary Ranges");
            ResultTester.CheckSolution("LC", LeetCode.SummaryRanges.Test.TestSummaryRanges());
        }


        private static void MaximumProductSubarrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Product Subarray");
            ResultTester.CheckSolution("LC", LeetCode.MaximumProductSubarray.Test.TestMaximumProductSubarray());
        }


        private static void MaximumLengthofSubarrayWithPositiveProductFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Length of Subarray With Positive Product");
            ResultTester.CheckSolution("LC", LeetCode.MaximumLengthofSubarrayWithPositiveProduct.Test.TestCases());
        }


        private static void MinimumNumberofVerticestoReachAllNodesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Vertices to Reach All Nodes");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FindtheWinneroftheCircularGameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Winner of the Circular Game");
            ResultTester.CheckSolution("LC", LeetCode.FindtheWinneroftheCircularGame.Test.TestCases());
        }


        private static void RemoveDuplicatesfromSortedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Duplicates from Sorted List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void RemoveDuplicatesfromSortedListIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Duplicates from Sorted List II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DesignLinkedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Linked List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DesignHashMapFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Hash Map");
            ResultTester.SpecialTestCase("LC");
        }
        

        private static void DesignHashSetFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Hash Set");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ReverseNodesinkGroupFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Nodes in k-Group");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SwapNodesinPairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Swap Nodes in Pairs");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MergekSortedListsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Merge k Sorted Lists");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MinStackFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Min Stack");
            ResultTester.SpecialTestCase("LC");
        } 


        private static void GenerateParenthesesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Generate Parentheses");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MergeTwoSortedListsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Merge Two Sorted Lists");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CoinChangeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Coin Change");
            ResultTester.CheckSolution("LC", LeetCode.CoinChange.Test.TestCoinChange());
        }


        private static void ValidParenthesesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Parentheses");
            ResultTester.CheckSolution("LC", LeetCode.ValidParentheses.Test.TestValidParentheses());
        }


        private static void CoinChangeIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Coin Change");
            ResultTester.CheckSolution("LC", LeetCode.CoinChangeII.Test.TestCoinChangeII());
        }


        private static void MinimumRoundstoCompleteAllTasksFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Rounds to Complete All Tasks");
            ResultTester.CheckSolution("LC", LeetCode.MinimumRoundstoCompleteAllTasks.Test.TestCases());
        }


        private static void FindtheDifferenceofTwoArraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Difference of Two Arrays");
            ResultTester.CheckSolution("LC", LeetCode.FindtheDifferenceofTwoArrays.Test.TestCases());
        }


        private static void SolvingQuestionsWithBrainpowerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Solving Questions With Brainpower");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaximumTwinSumofaLinkedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Twin Sum of a Linked List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DeletetheMiddleNodeofaLinkedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Delete the Middle Node of a Linked List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FindifPathExistsinGraphFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find if Path Exists in Graph");
            ResultTester.SpecialTestCase("LC");
        }


        private static void NearestExitfromEntranceinMazeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Nearest Exit from Entrance in Maze");
            ResultTester.CheckSolution("LC", LeetCode.NearestExitfromEntranceinMaze.Test.TestCases());
        }


        private static void YouCantCodeUnderPressure1Func()
        {
            StyleHelper.Space();
            StyleHelper.Title("You Can't Code Under Pressure #1");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.YouCantCodeUnderPressure1.Test.TestYouCantCodeUnderPressure1());
        }


        private static void CompareTheTripletsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Compare The Triplets");
            ResultTester.CheckSolution("HR", HackerRank.CompareTheTriplets.Test.TestCompareTriplets());
        }


        private static void RangeSumQueryImmutableFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Range Sum Query - Immutable");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MakeArrayStrictlyIncreasingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Make Array Strictly Increasing");
            ResultTester.CheckSolution("LC", LeetCode.MakeArrayStrictlyIncreasing.Test.TestMakeArrayStrictlyIncreasing());
        }

        
        private static void SearchinRotatedSortedArrayIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search in Rotated Sorted Array II");
            ResultTester.CheckSolution("LC", LeetCode.SearchinRotatedSortedArrayII.Test.TestSearchinRotatedSortedArrayII());
        }


        private static void FindRightIntervalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Right Interval");
            ResultTester.CheckSolution("LC", LeetCode.FindRightInterval.Test.TestFindRightInterval());
        }


        private static void MostProfitAssigningWorkFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Most Profit Assigning Work");
            ResultTester.CheckSolution("LC", LeetCode.MostProfitAssigningWork.Test.TestMostProfitAssigningWork());
        }


        private static void WaystoSplitArrayIntoThreeSubarraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ways to Split Array Into Three Subarrays");
            ResultTester.CheckSolution("LC", LeetCode.WaystoSplitArrayIntoThreeSubarrays.Test.TestCases());
        }


        private static void NumberofIslandsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Islands");
            ResultTester.CheckSolution("LC", LeetCode.NumberofIslands.Test.TestHappyNumber());
        }


        private static void AllPathsFromSourcetoTargetFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("All Paths From Source to Target");
            ResultTester.CheckSolution("LC", LeetCode.AllPathsFromSourcetoTarget.Test.TestAllPathsFromSourcetoTarget());
        }


        private static void NumberofIncreasingPathsinaGridFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Increasing Paths in a Grid");
            ResultTester.CheckSolution("LC", LeetCode.NumberofIncreasingPathsinaGrid.Test.TestCases());
        }


        private static void PacificAtlanticWaterFlowFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Pacific Atlantic Water Flow");
            ResultTester.CheckSolution("LC", LeetCode.PacificAtlanticWaterFlow.Test.TestPacificAtlanticWaterFlow());
        }


        private static void CenturyFromYearFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Century From Year");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.CenturyFromYear.Test.TestCenturyFromYear());
        }


        private static void BasicMathematicalOperationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Basic Mathematical Operations");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.BasicMathematicalOperations.Test.TestBasicMathematicalOperations());
        }


        private static void DiagonalDifferenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Diagonal Difference");
            ResultTester.SpecialTestCase("HR");
        }


        private static void BinaryTreeRightSideViewFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Right Side View");
            ResultTester.SpecialTestCase("LC");
        }

        
        private static void CountSubIslandsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Diagonal Difference");
            ResultTester.CheckSolution("LC", LeetCode.CountSubIslands.Test.TestCases());
        }


        private static void ShortestSubarraytobeRemovedtoMakeArraySortedFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Subarray to be Removed to Make Array Sorted");
            ResultTester.CheckSolution("LC", LeetCode.ShortestSubarraytobeRemovedtoMakeArraySorted.Test.TestCases());
        }


        private static void RangeSumofSortedSubarraySumsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Range Sum of Sorted Subarray Sums");
            ResultTester.CheckSolution("LC", LeetCode.RangeSumofSortedSubarraySums.Test.TestCases());
        }


        private static void MinimumSizeSubarraySumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Size Subarray Sum");
            ResultTester.CheckSolution("LC", LeetCode.MinimumSizeSubarraySum.Test.TestMinimumSizeSubarraySum());
        }


        private static void ValidTriangleNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Triangle Number");
            ResultTester.CheckSolution("LC", LeetCode.ValidTriangleNumber.Test.TestValidTriangleNumber());
        }


        private static void CountCompleteTreeNodesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Complete Tree Nodes");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FrequencyoftheMostFrequentElementFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Frequency of the Most Frequent Element");
            ResultTester.CheckSolution("LC", LeetCode.FrequencyoftheMostFrequentElement.Test.TestCases());
        }


        private static void HIndexIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("H-Index II");
            ResultTester.CheckSolution("LC", LeetCode.HIndexII.Test.TestHIndexII());
        }


        private static void KRadiusSubarrayAveragesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("K Radius Subarray Averages");
            ResultTester.CheckSolution("LC", LeetCode.KRadiusSubarrayAverages.Test.TestCases());
        }


        private static void FindMinimuminRotatedSortedArrayIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Minimum in Rotated Sorted Array II");
            ResultTester.CheckSolution("LC", LeetCode.FindMinimuminRotatedSortedArrayII.Test.TestFindMinimuminRotatedSortedArrayII());
        }


        private static void NumberofWaystoReorderArraytoGetSameBSTFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Ways to Reorder Array to Get Same BST");
            ResultTester.CheckSolution("LC", LeetCode.NumberofWaystoReorderArraytoGetSameBST.Test.TestCases());
        }


        private static void LongestArithmeticSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Ways to Reorder Array to Get Same BST");
            ResultTester.CheckSolution("LC", LeetCode.LongestArithmeticSubsequence.Test.TestLongestArithmeticSubsequence());
        }


        private static void TallestBillboardFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Tallest Billboard");
            ResultTester.CheckSolution("LC", LeetCode.TallestBillboard.Test.TestTallestBillboard());
        }


        private static void VerifyinganAlienDictionaryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Verifying an Alien Dictionary");
            ResultTester.CheckSolution("LC", LeetCode.VerifyinganAlienDictionary.Test.TestVerifyinganAlienDictionary());
        }


        private static void MinimumLimitofBallsinaBagFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Limit of Balls in a Bag");
            ResultTester.CheckSolution("LC", LeetCode.MinimumLimitofBallsinaBag.Test.TestCases());
        }


        private static void MagneticForceBetweenTwoBallsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Magnetic Force Between Two Balls");
            ResultTester.CheckSolution("LC", LeetCode.MagneticForceBetweenTwoBalls.Test.TestCases());
        }


        private static void FindaPeakElementIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find a Peak Element II");
            ResultTester.CheckSolution("LC", LeetCode.FindaPeakElementII.Test.TestCases());
        }


        private static void FindtheStudentthatWillReplacetheChalkFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Student that Will Replace the Chalk");
            ResultTester.CheckSolution("LC", LeetCode.FindtheStudentthatWillReplacetheChalk.Test.TestCases());
        }


        private static void FindKClosestElementsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find K Closest Elements");
            ResultTester.CheckSolution("LC", LeetCode.FindKClosestElements.Test.TestFindKClosestElements());
        }


        private static void DetectCapitalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Detect Capital");
            ResultTester.CheckSolution("LC", LeetCode.DetectCapital.Test.TestDetectCapital());
        }


        private static void RandomPickwithWeightFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Random Pick with Weight");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SellDiminishingValuedColoredBallsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sell Diminishing-Valued Colored Balls");
            ResultTester.CheckSolution("LC", LeetCode.SellDiminishingValuedColoredBalls.Test.TestCases());
        }


        private static void AvoidFloodinTheCityFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Avoid Flood in The City");
            ResultTester.CheckSolution("LC", LeetCode.AvoidFloodinTheCity.Test.TestCases());
        }


        private static void RunningSumof1dArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Running Sum of 1d Array");
            ResultTester.CheckSolution("LC", LeetCode.RunningSumof1dArray.Test.TestCases());
        }


        private static void OpentheLockFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Open the Lock");
            ResultTester.CheckSolution("LC", LeetCode.OpentheLock.Test.TestOpentheLock());
        }


        private static void LongestRepeatingCharacterReplacementFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Repeating Character Replacement");
            ResultTester.CheckSolution("LC", LeetCode.LongestRepeatingCharacterReplacement.Test.TestLongestRepeatingCharacterReplacement());
        }


        private static void SwappingNodesinaLinkedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Swapping Nodes in a Linked List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CheckingExistenceofEdgeLengthLimitedPathsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Checking Existence of Edge Length Limited Paths");
            ResultTester.CheckSolution("LC", LeetCode.CheckingExistenceofEdgeLengthLimitedPaths.Test.TestCases());
        }


        private static void MinimizeDeviationinArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimize Deviation in Array");
            ResultTester.SpecialTestCase("LC");
        }


        private static void RichestCustomerWealthFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Richest Customer Wealth");
            ResultTester.CheckSolution("LC", LeetCode.RichestCustomerWealth.Test.TestCases());
        }


        private static void IntegerBreakFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Integer Break");
            ResultTester.CheckSolution("LC", LeetCode.IntegerBreak.Test.TestIntegerBreak());
        }


        private static void JumpGameIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Jump Game III");
            ResultTester.CheckSolution("LC", LeetCode.JumpGameIII.Test.TestJumpGameIII());
        }


        private static void SubstringWithLargestVarianceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Substring With Largest Variance");
            ResultTester.CheckSolution("LC", LeetCode.SubstringWithLargestVariance.Test.TestCases());
        }


        private static void MaximalNetworkRankFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximal Network Rank");
            ResultTester.CheckSolution("LC", LeetCode.MaximalNetworkRank.Test.TestCases());
        }


        private static void CountAllPossibleRoutesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count All Possible Routes");
            ResultTester.CheckSolution("LC", LeetCode.CountAllPossibleRoutes.Test.TestCases());
        }


        private static void MinimumJumpstoReachHomeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Jumps to Reach Home");
            ResultTester.CheckSolution("LC", LeetCode.MinimumJumpstoReachHome.Test.TestCases());
        }


        private static void NextGreaterElementIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Next Greater Element III");
            ResultTester.CheckSolution("LC", LeetCode.NextGreaterElementIII.Test.TestNextGreaterElementIII());
        }


        private static void SmallestRangeIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Smallest Range II");            
            ResultTester.CheckSolution("LC", LeetCode.SmallestRangeII.Test.TestSmallestRangeII());
        }


        private static void LongestArithmeticSubsequenceofGivenDifferenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Arithmetic Subsequence of Given Difference");
            ResultTester.CheckSolution("LC", LeetCode.LongestArithmeticSubsequenceofGivenDifference.Test.TestLongestArithmeticSubsequenceofGivenDifference());
        }


        private static void MinimumCosttoMakeArrayEqualFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Cost to Make Array Equal");
            ResultTester.CheckSolution("LC", LeetCode.MinimumCosttoMakeArrayEqual.Test.TestCases());
        }


        private static void SubsetsIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subsets II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaximumNumberofEventsThatCanBeAttendedIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Events That Can Be Attended II");
            ResultTester.CheckSolution("LC", LeetCode.MaximumNumberofEventsThatCanBeAttendedII.Test.TestCases());
        }


        private static void DesignParkingSystemFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Parking System");
            ResultTester.SpecialTestCase("LC");
        }

        
        private static void MergeSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Merge Sorted Array");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CombinationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Combinations");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SmallestSufficientTeamFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Smallest Sufficient Team");
            ResultTester.CheckSolution("LC", LeetCode.SmallestSufficientTeam.Test.TestSmallestSufficientTeam());
        }


        private static void ThreeSumClosestFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("3Sum Closest");
            ResultTester.CheckSolution("LC", LeetCode.ThreeSumClosest.Test.TestThreeSumClosest());
        }


        private static void PartitionEqualSubsetSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Partition Equal Subset Sum");
            ResultTester.CheckSolution("LC", LeetCode.PartitionEqualSubsetSum.Test.TestPartitionEqualSubsetSum());
        }


        private static void BusRoutesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bus Routes");
            ResultTester.CheckSolution("LC", LeetCode.BusRoutes.Test.TestBusRoutes());
        }


        private static void CourseScheduleIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Course Schedule II");
            ResultTester.CheckSolution("LC", LeetCode.CourseScheduleII.Test.TestCourseScheduleII());
        }


        private static void BasicCalculatorIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Basic Calculator II");
            ResultTester.CheckSolution("LC", LeetCode.BasicCalculatorII.Test.TestBasicCalculatorII());
        }


        private static void CombinationSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Combination Sum");
            ResultTester.CheckSolution("LC", LeetCode.CombinationSum.Test.TestCases());
        }


        private static void RotateListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Rotate List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SpiralMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Spiral Matrix");
            ResultTester.CheckSolution("LC", LeetCode.SpiralMatrix.Test.TestSpiralMatrix());
        }


        private static void SpiralMatrixIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Spiral Matrix II");
            ResultTester.CheckSolution("LC", LeetCode.SpiralMatrixII.Test.TestSpiralMatrixII());
        }


        private static void CopyListwithRandomPointerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Copy List with Random Pointer");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ArithmeticSubarraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Arithmetic Subarrays");
            ResultTester.CheckSolution("LC", LeetCode.ArithmeticSubarrays.Test.TestCases());
        }


        private static void SeatReservationManagerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Seat Reservation Manager");
            ResultTester.SpecialTestCase("LC");
        }


        private static void LastDayWhereYouCanStillCrossFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Last Day Where You Can Still Cross");
            ResultTester.CheckSolution("LC", LeetCode.LastDayWhereYouCanStillCross.Test.TestLastDayWhereYouCanStillCroww());
        }


        private static void TopKFrequentWordsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Top K Frequent Words");
            ResultTester.CheckSolution("LC", LeetCode.TopKFrequentWords.Test.TestTopKFrequentWords());
        }


        private static void NextGreaterElementIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Next Greater Element II");
            ResultTester.CheckSolution("LC", LeetCode.NextGreaterElementII.Test.TestNextGreaterElementII());
        }


        private static void OnlineElectionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Online Election");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ConstructQuadTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Construct Quad Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MinimumGeneticMutationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Genetic Mutation");
            ResultTester.CheckSolution("LC", LeetCode.MinimumGeneticMutation.Test.TestMinimumGeneticMutation());
        }


        private static void IntervalListIntersectionsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Interval List Intersections");
            ResultTester.CheckSolution("LC", LeetCode.IntervalListIntersections.Test.TestIntervalListIntersections());
        }


        private static void LinkedListinBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Linked List in Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void KnightProbabilityinChessboardFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Knight Probability in Chessboard");
            ResultTester.CheckSolution("LC", LeetCode.KnightProbabilityinChessboard.Test.TestKnightProbabilityinChessboard());
        }


        private static void PossibleBipartitionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Possible Bipartition");
            ResultTester.SpecialTestCase("LC");
        }


        private static void AllPossibleFullBinaryTreesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("All Possible Full Binary Trees");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PopulatingNextRightPointersinEachNodeIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Populating Next Right Pointers in Each Node I");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PopulatingNextRightPointersinEachNodeIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Populating Next Right Pointers in Each Node II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ShortestPathtoGetAllKeysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Path to Get All Keys");
            ResultTester.CheckSolution("LC", LeetCode.ShortestPathtoGetAllKeys.Test.TestShortestPathtoGetAllKeys());
        }


        private static void WaterandJugProblemFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Water and Jug Problem");
            ResultTester.CheckSolution("LC", LeetCode.WaterandJugProblem.Test.TestWaterandJugProblem());
        }


        private static void MaximumNumberofAchievableTransferRequestsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Achievable Transfer Requests");
            ResultTester.CheckSolution("LC", LeetCode.MaximumNumberofAchievableTransferRequests.Test.TestMaximumNumberofAchievableTransferRequests());
        }


        private static void DesignBrowserHistoryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Browser History");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CountGoodNodesinBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Good Nodes in Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DataStreamasDisjointIntervalsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Data Stream as Disjoint Intervals");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MinimumTimetoCollectAllApplesinaTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Time to Collect All Apples in a Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void IntersectionofTwoArraysIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Intersection of Two Arrays II");
            ResultTester.CheckSolution("LC", LeetCode.IntersectionofTwoArraysII.Test.TestIntersectionofTwoArraysII());
        }


        private static void StrangePrinterFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Strange Printer");
            ResultTester.CheckSolution("LC", LeetCode.StrangePrinter.Test.TestStrangePrinter());
        }


        private static void TopKFrequentElementsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Top K Frequent Elements");
            ResultTester.CheckSolution("LC", LeetCode.TopKFrequentElements.Test.TestTopKFrequentElements());
        }


        private static void MaximumWidthofBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Width of Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ConvertNumberToReversedArrayOfDigitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert number to reversed array of digits");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.ConvertNumberToReversedArrayOfDigits.Test.TestConvertNumberToReversedArrayOfDigits());
        }


        private static void BeginnerLostWithoutaMapFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Beginner - Lost Without a Map");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.BeginnerLostWithoutaMap.Test.TestBeginnerLostWithoutaMap());
        }


        private static void SearchSuggestionsSystemFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search Suggestions System");
            ResultTester.CheckSolution("LC", LeetCode.SearchSuggestionsSystem.Test.TestSearchSuggestionsSystem());
        }


        private static void FirstMissingPositiveFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("First Missing Positive");
            ResultTester.CheckSolution("LC", LeetCode.FirstMissingPositive.Test.TestFirstMissingPositive());
        }


        private static void CheapestFlightsWithinKStopsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Cheapest Flights Within K Stops");
            ResultTester.CheckSolution("LC", LeetCode.CheapestFlightsWithinKStops.Test.TestCheapestFlightsWithinKStops());
        }


        private static void PredicttheWinnerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Predict the Winner");
            ResultTester.CheckSolution("LC", LeetCode.PredicttheWinner.Test.TestPredicttheWinner());
        }


        private static void ConcatenatedWordsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Concatenated Words");
            ResultTester.CheckSolution("LC", LeetCode.ConcatenatedWords.Test.TestConcatenatedWords());
        }


        private static void AbbreviateaTwoWordNameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Abbreviate a Two Word Name");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.AbbreviateaTwoWordName.Solution.TestAbbreviateaTwoWordName());
        }


        private static void BeginnerSeries2ClockFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Beginner Series #2 Clock");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.BeginnerSeries2Clock.Solution.TestBeginnerSeries2Clock());
        }

        
        private static void PathwithMaximumProbabilityFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Pathwith Maximum Probability");
            ResultTester.CheckSolution("LC", LeetCode.PathwithMaximumProbability.Test.TestPathwithMaximumProbability());
        }


        private static void SubarrayProductLessThanKFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subarray Product Less Than K");
            ResultTester.CheckSolution("LC", LeetCode.SubarrayProductLessThanK.Test.TestSubarrayProductLessThanK());
        }


        private static void DominoPilingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subarray Product Less Than K");
            ResultTester.CheckSolution("CF", CodeForces.DominoPiling.Test.TestCases());
        }


        private static void MaximumSideLengthofaSquarewithSumLessthanorEqualtoThresholdFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Side Length of a Square with Sum Less than or Equal to Threshold");
            ResultTester.CheckSolution("LC", LeetCode.MaximumSideLengthofaSquarewithSumLessthanorEqualtoThreshold.Test.TestMaximumSideLengthofaSquarewithSumLessthanorEqualtoThreshold());
        }

        
        private static void NthTribonacciNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Nth Tribonacci Number");
            ResultTester.CheckSolution("LC", LeetCode.NthTribonacciNumber.Test.TestNthTribonacciNumber());
        }


        private static void NondecreasingSubsequencesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Non-decreasing Subsequences");
            ResultTester.CheckSolution("LC", LeetCode.NondecreasingSubsequences.Test.TestNondecreasingSubsequences());
        }


        private static void BFSofgraphFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("BFS of graph");
            ResultTester.SpecialTestCase("GFG");
        }

        private static void LFUCacheFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("LFU Cache");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PlusMinusFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Plus Minus");
            ResultTester.CheckSolution("HR", HackerRank.PlusMinus.Test.TestPlusMinus());
        }


        private static void MiddleoftheLinkedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Middle of the Linked List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SumofDistancesinTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Distances in Tree");
            ResultTester.CheckSolution("LC", LeetCode.SumofDistancesinTree.Test.TestSumofDistancesinTree());
        }


        private static void IndexingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Indexing");
            ResultTester.CheckSolution("CC", CodeChef.Indexing.Test.TestIndexing());
        }


        private static void AlternatingDigitSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Alternating Digit Sum");
            ResultTester.CheckSolution("LC", LeetCode.AlternatingDigitSum.Test.TestCase());
        }


        private static void ImplementQueueusingStacksFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Implement Queue using Stacks");
            ResultTester.SpecialTestCase("LC");
        }


        private static void PangramFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Pangram");
            ResultTester.SpecialTestCase("CF");
        }


        private static void InsomniacureFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Insomnia cure");
            ResultTester.SpecialTestCase("CF");
        }


        private static void AntonandLettersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Anton and Letters");
            ResultTester.SpecialTestCase("CF");
        }


        private static void InvertBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Invert Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void TeamFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Team");
            ResultTester.CheckSolution("CF", CodeForces.Team.Test.TestTeam());
        }


        private static void WayTooLongWordsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Way Too Long Words");
            ResultTester.SpecialTestCase("CF");
        }


        private static void PascalsTriangleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Pascals Triangle");
            ResultTester.SpecialTestCase("LC");
        }


        private static void WatermelonFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Watermelon");
            ResultTester.SpecialTestCase("CF");
        }


        private static void ConstructBinaryTreefromInorderandPostorderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Construct Binary Tree from In order and Post order Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaximumSubarrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Subarray");
            ResultTester.CheckSolution("LC", LeetCode.MaximumSubarray.Test.TestMaximumSubarray());
        }


        private static void RemoveNthNodeFromEndofListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Nth Node From End of List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void LetterCombinationsofaPhoneNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Letter Combinations of a Phone Number");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ZigzagConversionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Zigzag Conversion");
            ResultTester.CheckSolution("LC", LeetCode.ZigzagConversion.Test.TestZigzagConversion());
        }


        private static void AddTwoNumbersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Two Numbers");
            ResultTester.SpecialTestCase("LC");
        }


        private static void AddTwoNumbersCCFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Two Numbers (CodeChef)");
            ResultTester.SpecialTestCase("CC");
        }


        private static void MaximumIntersectingLinesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Intersecting Lines");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void CountSpecialNumbersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Special Numbers");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void KnightInGeeklandFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Knight In Geekland");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void BTSMaximumDifferenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("BTS Maximum Difference");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void MakeTheArrayBeautifulFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Make The Array Beautiful");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void FrogsAndJumpFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Frogs And Jump");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void SquaringAnArgumentFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Squaring An Argument");
            ResultTester.SpecialTestCase("CW");
        }


        private static void ReturningStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Returning Strings");
            ResultTester.SpecialTestCase("CW");
        }


        private static void ReturnToSanityFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Return To Sanity");
            ResultTester.SpecialTestCase("CW");
        }


        private static void ReturnHelloWorldFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Return Hello World");
            ResultTester.SpecialTestCase("CW");
        }


        private static void BitPPFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bit++");
            ResultTester.CheckSolution("CF", CodeForces.BitPP.Test.TestCases());
        }


        private static void BuddyStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Buddy Strings");
            ResultTester.CheckSolution("LC", LeetCode.BuddyStrings.Test.TestCase());
        }


        private static void SurroundedRegionsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Surrounded Regions");
            ResultTester.CheckSolution("LC", LeetCode.SurroundedRegions.Test.TestCases());
        }


        private static void BullsandCowsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bulls and Cows");
            ResultTester.CheckSolution("LC", LeetCode.BullsandCows.Test.TestCases());
        }


        private static void MinimumRemovetoMakeValidParenthesesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Remove to Make Valid Parentheses");
            ResultTester.CheckSolution("LC", LeetCode.MinimumRemovetoMakeValidParentheses.Test.TestCases());
        }


        private static void FindEventualSafeStatesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Eventual Safe States");
            ResultTester.CheckSolution("LC", LeetCode.FindEventualSafeStates.Test.TestCases());
        }


        private static void NaryTreeLevelOrderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("N-ary Tree Level Order Traversal");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FlattenNestedListIteratorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Flatten Nested List Iterator");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SingleNumberIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Single Number II");
            ResultTester.CheckSolution("LC", LeetCode.SingleNumberII.Test.TestCases());
        }


        private static void UniqueBinarySearchTreesIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Unique Binary Search Trees II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void NumberofMusicPlaylistsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Music Playlists");
            ResultTester.CheckSolution("LC", LeetCode.NumberofMusicPlaylists.Test.TestCases());
        }


        private static void BeginnerSeries1SchoolPaperworkFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Beginner Series #1 School Paperwork");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.BeginnerSeries1SchoolPaperwork.Test.TestCases());
        }


        private static void USRS2IntegerInputFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("USRS2 Integer Input");
            ResultTester.CheckSolution("CC", CodeChef.USRS2IntegerInput.Test.TestCases());
        }


        private static void StringPermutationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("String Permutations");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.StringPermutations.Test.TestCases());
        }


        private static void BeautifulMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Beautiful Matrix");
            ResultTester.CheckSolution("CF", CodeForces.BeautifulMatrix.Test.TestCases());
        }


        private static void StaircaseFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Staircase");
            ResultTester.CheckSolution("HR", HackerRank.Staircase.Test.TestCases());
        }


        private static void FormingaMagicSquareFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Forming a Magic Square");
            ResultTester.CheckSolution("HR", HackerRank.FormingaMagicSquare.Test.TestCases());
        }


        private static void AshtonandStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ashton and String");
            ResultTester.CheckSolution("HR", HackerRank.AshtonandString.Test.TestCases());
        }


        private static void FindLatestGroupofSizeMFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Latest Group of Size M");
            ResultTester.CheckSolution("LC", LeetCode.FindLatestGroupofSizeM.Test.TestCases());
        }


        private static void HelloUserFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Hello User");
            ResultTester.SpecialTestCase("CC");
        }


        private static void MultipleoutputsusingasinglelineFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Multiple outputs using a single line");
            ResultTester.SpecialTestCase("CC");
        }


        private static void InsertingspacebetweenoutputsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Inserting space between outputs");
            ResultTester.SpecialTestCase("CC");
        }


        private static void InsertingtextBetweenOutputsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Inserting text Between Outputs");
            ResultTester.SpecialTestCase("CC");
        }


        private static void MultiplicationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Multiplication");
            ResultTester.SpecialTestCase("CC");
        }


        private static void DivisionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Division");
            ResultTester.SpecialTestCase("CC");
        }


        private static void SyntaxFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Syntax");
            ResultTester.SpecialTestCase("CC");
        }


        private static void StoringBoxesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Storing Boxes");
            ResultTester.SpecialTestCase("CC");
        }


        private static void DeclaringavariableFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Declaring a variable");
            ResultTester.SpecialTestCase("CC");
        }


        private static void AdditionofVariablesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Addition of Variables");
            ResultTester.SpecialTestCase("CC");
        }


        private static void AreaofRectangleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Area of Rectangle");
            ResultTester.SpecialTestCase("CC");
        }


        private static void DoubledatatypeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Double data type");
            ResultTester.SpecialTestCase("CC");
        }


        private static void StringDatatypeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("String Data type");
            ResultTester.SpecialTestCase("CC");
        }


        private static void PetyaandStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Petya and Strings");
            ResultTester.CheckSolution("CF", CodeForces.PetyaandStrings.Test.TestCases());
        }


        private static void SolvetheSudokuFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Solve the Sudoku");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void ReorderListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reorder List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ShortestPathVisitingAllNodesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Path Visiting All Nodes");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SortCharactersByFrequencyFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort Characters By Frequency");
            ResultTester.CheckSolution("LC", LeetCode.SortCharactersByFrequency.Test.TestCases());
        }


        private static void UglyNumberIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ugly Number III");
            ResultTester.CheckSolution("LC", LeetCode.UglyNumberIII.Test.TestCases());
        }


        private static void SumofMutatedArrayClosesttoTargetFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Mutated Array Closest to Target");
            ResultTester.CheckSolution("LC", LeetCode.SumofMutatedArrayClosesttoTarget.Test.TestCases());
        }


        private static void IntersectionofTwoLinkedListsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Intersection of Two Linked Lists");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SubsetsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subsets");
            ResultTester.CheckSolution("LC", LeetCode.Subsets.Test.TestCases());
        }


        private static void GroupAnagramsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Group Anagrams");
            ResultTester.CheckSolution("LC", LeetCode.GroupAnagrams.Test.TestCases());
        }


        private static void PartitionLabelsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Partition Labels");
            ResultTester.CheckSolution("LC", LeetCode.PartitionLabels.Test.TestCases());
        }


        private static void SubtreeofAnotherTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subtree of Another Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CalculatorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Calculator");
            ResultTester.SpecialTestCase("CC");
        }


        private static void RotateImageFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Rotate Image");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MinimizetheMaximumDifferenceofPairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimize the Maximum Difference of Pairs");
            ResultTester.CheckSolution("LC", LeetCode.MinimizetheMaximumDifferenceofPairs.Test.TestCase());
        }


        private static void WordLadderFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word Ladder");
            ResultTester.CheckSolution("LC", LeetCode.WordLadder.Test.TestCase());
        }


        private static void HelpfulMathsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Helpful Maths");
            ResultTester.CheckSolution("CF", CodeForces.HelpfulMaths.Test.TestCases());
        }


        private static void MakeUpperCaseFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Make Upper Case");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.MakeUpperCase.Test.TestCases());
        }


        private static void ADisjointSetUnionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Disjoint Set Union");
            ResultTester.CheckSolution("AC", AtCoder.ADisjointSetUnion.Test.TestCases());
        }


        private static void BFenwickTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fenwick Tree");
            ResultTester.CheckSolution("AC", AtCoder.BFenwickTree.Test.TestCases());
        }

        
        private static void CFloorSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Floor Sum");
            ResultTester.SpecialTestCase("AC");
        }


        private static void DMaxflowFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max flow");
            ResultTester.SpecialTestCase("AC");
        }


        private static void EMinCostFlowFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Min Cost Flow");
            ResultTester.SpecialTestCase("AC");
        }


        private static void FConvolutionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convolution");
            ResultTester.SpecialTestCase("AC");
        }


        private static void SimplemultiplicationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Simple multiplication");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.Simplemultiplication.Test.TestCases());
        }


        private static void GSCCFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("SCC");
            ResultTester.SpecialTestCase("AC");
        }


        private static void KClosestPointstoOriginFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("K Closest Points to Origin");
            ResultTester.CheckSolution("LC", LeetCode.KClosestPointstoOrigin.Test.TestCases());
        }


        private static void MiletoKilometerConvertorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Mile to Kilometer Convertor");
            ResultTester.SpecialTestCase("CC");
        }


        private static void BracketCombinationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bracket Combinations");
            ResultTester.CheckSolution("CB", CoderByte.BracketCombinations.Test.TestCases());
        }


        private static void MinWindowSubstringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Min Window Substring");
            ResultTester.CheckSolution("CB", CoderByte.MinWindowSubstring.Test.TestCases());
        }


        private static void SlidingWindowMaximumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sliding Window Maximum");
            ResultTester.CheckSolution("LC", LeetCode.SlidingWindowMaximum.Test.TestCases());
        }


        private static void PartitionListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Partition List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void CheckifThereisaValidPartitionForTheArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check if There is a Valid Partition For The Array");
            ResultTester.CheckSolution("LC", LeetCode.CheckifThereisaValidPartitionForTheArray.Test.TestCases());
        }


        private static void PerfectSquaresFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Perfect Squares");
            ResultTester.CheckSolution("LC", LeetCode.PerfectSquares.Test.TestCases());
        }


        private static void CombinationSumIVFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Combination Sum IV");
            ResultTester.CheckSolution("LC", LeetCode.CombinationSumIV.Test.TestCases());
        }


        private static void FindCriticalandPseudoCriticalEdgesinMinimumSpanningTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Critical and Pseudo-Critical Edges in Minimum Spanning Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void TwoSATFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Two SAT");
            ResultTester.SpecialTestCase("AC");
        }


        private static void NumberofSubstringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Substrings");
            ResultTester.SpecialTestCase("AC");
        }


        private static void TimeBasedKeyValueStoreFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Time Based Key-Value Store");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SegmentTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Segment Tree");
            ResultTester.SpecialTestCase("AC");
        }


        private static void MaximumLengthofPairChainFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Length of Pair Chain");
            ResultTester.CheckSolution("LC", LeetCode.MaximumLengthofPairChain.Test.TestCases());
        }


        private static void LazySegmentTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Lazy Segment Tree");
            ResultTester.SpecialTestCase("AC");
        }


        private static void RangeAffineRangeSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Range Affine Range Sum");
            ResultTester.SpecialTestCase("AC");
        }


        private static void TreeConstructorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Tree Constructor");
            ResultTester.CheckSolution("CB", CoderByte.TreeConstructor.Test.TestCases());
        }


        private static void MinimumReplacementstoSorttheArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Replacements to Sort the Array");
            ResultTester.CheckSolution("LC", LeetCode.MinimumReplacementstoSorttheArray.Test.TestCases());
        }


        private static void MinimumPenaltyforaShopFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Penalty for a Shop");
            ResultTester.CheckSolution("LC", LeetCode.MinimumPenaltyforaShop.Test.TestCases());
        }


        private static void ImplementStackusingQueuesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Implement Stack using Queues");
            ResultTester.SpecialTestCase("LC");
        }


        private static void BracketMatcherFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bracket Matcher");
            ResultTester.CheckSolution("CB", CoderByte.BracketMatcher.Test.TestCases());
        }


        private static void ExtraCharactersinaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Extra Characters in a String");
            ResultTester.CheckSolution("LC", LeetCode.ExtraCharactersinaString.Test.TestCases());
        }


        private static void MinimumNumberofTapstoOpentoWateraGardenFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Taps to Open to Water a Garden");
            ResultTester.CheckSolution("LC", LeetCode.MinimumNumberofTapstoOpentoWateraGarden.Test.TestCases());
        }


        private static void InterleavingStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Interleaving String");
            ResultTester.CheckSolution("LC", LeetCode.InterleavingString.Test.TestCases());
        }


        private static void ShuffleanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shuffle an Array");
            ResultTester.SpecialTestCase("LC");
        }


        private static void BackspaceStringCompareFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Backspace String Compare");
            ResultTester.CheckSolution("LC", LeetCode.BackspaceStringCompare.Test.TestCases());
        }


        private static void DeleteOperationforTwoStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Delete Operation for Two Strings");
            ResultTester.CheckSolution("LC", LeetCode.DeleteOperationforTwoStrings.Test.TestCases());
        }


        private static void BitwiseANDofNumbersRangeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bitwise AND of Numbers Range");
            ResultTester.CheckSolution("LC", LeetCode.BitwiseANDofNumbersRange.Test.TestCases());
        }


        private static void MinimumSpeedtoArriveonTimeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Speed to Arrive on Time");
            ResultTester.CheckSolution("LC", LeetCode.MinimumSpeedtoArriveonTime.Test.TestCases());
        }


        private static void FrogJumpFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Frog Jump");
            ResultTester.CheckSolution("LC", LeetCode.FrogJump.Test.TestCases());
        }


        private static void FairDistributionofCookiesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fair Distribution of Cookies");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MinimumNumberofDaystoMakemBouquetsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Days to Make m Bouquets");
            ResultTester.CheckSolution("LC", LeetCode.MinimumNumberofDaystoMakemBouquets.Test.TestCases());
        }


        private static void TextJustificationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Text Justification");
            ResultTester.CheckSolution("LC", LeetCode.TextJustification.Test.TestCases());
        }


        private static void ReorganizeStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reorganize String");
            ResultTester.CheckSolution("LC", LeetCode.ReorganizeString.Test.TestCases());
        }


        private static void RepeatedDNASequencesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Repeated DNA Sequences");
            ResultTester.CheckSolution("LC", LeetCode.RepeatedDNASequences.Test.TestCases());
        }


        private static void ExcelSheetColumnTitleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Excel Sheet Column Title");
            ResultTester.CheckSolution("LC", LeetCode.ExcelSheetColumnTitle.Test.TestCases());
        }


        private static void SortItemsbyGroupsRespectingDependenciesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort Items by Groups Respecting Dependencies");
            ResultTester.CheckSolution("LC", LeetCode.SortItemsbyGroupsRespectingDependencies.Test.TestCases());
        }


        private static void NumberofLongestIncreasingSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Longest Increasing Subsequence");
            ResultTester.CheckSolution("LC", LeetCode.NumberofLongestIncreasingSubsequence.Test.TestCases());
        }


        private static void MaximumNumberofRemovableCharactersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Removable Characters");
            ResultTester.CheckSolution("LC", LeetCode.MaximumNumberofRemovableCharacters.Test.TestCases());
        }


        private static void BalancedBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Balanced Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FindKPairswithSmallestSumsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Removable Characters");
            ResultTester.CheckSolution("LC", LeetCode.FindKPairswithSmallestSums.Test.TestCases());
        }


        private static void MinimumAbsoluteSumDifferenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Absolute Sum Difference");
            ResultTester.CheckSolution("LC", LeetCode.MinimumAbsoluteSumDifference.Test.TestCases());
        }


        private static void DetermineWhetherMatrixCanBeObtainedByRotationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Determine Whether Matrix Can Be Obtained By Rotation");
            ResultTester.CheckSolution("LC", LeetCode.DetermineWhetherMatrixCanBeObtainedByRotation.Test.TestCases());
        }


        private static void FindtheSmallestDivisorGivenaThresholdFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Smallest Divisor Given a Threshold");
            ResultTester.CheckSolution("LC", LeetCode.FindtheSmallestDivisorGivenaThreshold.Test.TestCases());
        }


        private static void SplitLinkedListinPartsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Split Linked List in Parts");
            ResultTester.SpecialTestCase("LC");
        }


        private static void AddStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Strings");
            ResultTester.CheckSolution("LC", LeetCode.AddStrings.Test.TestCases());
        }


        private static void WordSearchFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word Search");
            ResultTester.CheckSolution("LC", LeetCode.WordSearch.Test.TestCases());
        }


        private static void Searcha2DMatrixIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search a 2D Matrix II");
            ResultTester.CheckSolution("LC", LeetCode.Searcha2DMatrixII.Test.TestCases());
        }


        private static void InsertDeleteGetRandomFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Insert Delete GetRandom O(1)");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ReverseLinkedListIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Linked List II");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MyCalendarIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("My Calendar I");
            ResultTester.SpecialTestCase("LC");
        }


        private static void DesignAuthenticationManagerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Authentication Manager");
            ResultTester.SpecialTestCase("LC");
        }


        private static void SortListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort List");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MinimumDepthofBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Depth of Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void AllNodesDistanceKinBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("All Nodes Distance K in Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaximizetheConfusionofanExamFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximize the Confusion of an Exam");
            ResultTester.CheckSolution("LC", LeetCode.MaximizetheConfusionofanExam.Test.TestCases());
        }


        private static void LongestPalindromebyConcatenatingTwoLetterWordsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Palindrome by Concatenating Two Letter Words");
            ResultTester.CheckSolution("LC", LeetCode.LongestPalindromebyConcatenatingTwoLetterWords.Test.TestCases());
        }


        private static void PutMarblesinBagsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Put Marbles in Bags");
            ResultTester.CheckSolution("LC", LeetCode.PutMarblesinBags.Test.TestCases());
        }


        private static void TaskSchedulerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Task Scheduler");
            ResultTester.CheckSolution("LC", LeetCode.TaskScheduler.Test.TestCases());
        }


        private static void PathWithMinimumEffortFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Path With Minimum Effort");
            ResultTester.CheckSolution("LC", LeetCode.PathWithMinimumEffort.Test.TestCases());
        }


        private static void WhereWilltheBallFallFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Where Will the Ball Fall");
            ResultTester.CheckSolution("LC", LeetCode.WhereWilltheBallFall.Test.TestCases());
        }


        private static void WordCapitalizationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word Capitalization");
            ResultTester.CheckSolution("CF", CodeForces.WordCapitalization.Solution.TestCases());
        }


        private static void BoyorGirlFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Boy or Girl");
            ResultTester.CheckSolution("CF", CodeForces.BoyorGirl.Solution.TestCases());
        }


        private static void CSB001IntroductionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB001 Introduction");
            ResultTester.SpecialTestCase("CC");
        }


        private static void CSB002IntroductionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB002 Introduction");
            ResultTester.SpecialTestCase("CC");
        }


        private static void CSB003IntroductionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB003 Introduction");
            ResultTester.SpecialTestCase("CC");
        }


        private static void CountAllValidPickupandDeliveryOptionsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count All Valid Pickup and Delivery Options");
            ResultTester.CheckSolution("LC", LeetCode.CountAllValidPickupandDeliveryOptions.Test.TestCases());
        }


        private static void GroupthePeopleGiventheGroupSizeTheyBelongToFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Group the People Given the Group Size They Belong To");
            ResultTester.CheckSolution("LC", LeetCode.GroupthePeopleGiventheGroupSizeTheyBelongTo.Test.TestCases());
        }


        private static void MinimumDeletionstoMakeCharacterFrequenciesUniqueFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Deletions to Make Character Frequencies Unique");
            ResultTester.CheckSolution("LC", LeetCode.MinimumDeletionstoMakeCharacterFrequenciesUnique.Test.TestCases());
        }


        private static void CandyFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Candy");
            ResultTester.CheckSolution("LC", LeetCode.Candy.Test.TestCases());
        }


        private static void MinCosttoConnectAllPointsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Min Cost to Connect All Points");
            ResultTester.CheckSolution("LC", LeetCode.MinCosttoConnectAllPoints.Test.TestCases());
        }


        private static void ReconstructItineraryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reconstruct Itinerary");
            ResultTester.SpecialTestCase("LC");
        }


        private static void StonesontheTableFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Stones on the Table");
            ResultTester.SpecialTestCase("CF");
        }


        private static void BearandBigBrotherFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bear and Big Brother");
            ResultTester.SpecialTestCase("CF");
        }


        private static void CodelandUsernameValidationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Codeland Username Validation");
            ResultTester.CheckSolution("CB", CoderByte.CodelandUsernameValidation.Test.TestCases());
        }


        private static void FindfirstsetbitFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find first set bit");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.Findfirstsetbit.Test.TestCases());
        }


        private static void FindIntersectionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Intersection");
            ResultTester.CheckSolution("CB", CoderByte.FindIntersection.Test.TestCases());
        }


        private static void AreYouPlayingBanjoFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Are You Playing Banjo");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.AreYouPlayingBanjo.Test.TestCases());
        }


        private static void CSB004ArithmeticOperationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB004 Arithmetic Operations");
            ResultTester.SpecialTestCase("CC");
        }


        private static void CSB007MultipleOutputsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB007 Multiple Outputs");
            ResultTester.SpecialTestCase("CC");
        }
        

        private static void CSB008OutputsInSeperateLinesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB008 Outputs In Seperate Lines");
            ResultTester.SpecialTestCase("CC");
        }


        private static void CSB009AreaPerimeterofRectangleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB009 Area & Perimeter of Rectangle");
            ResultTester.SpecialTestCase("CC");
        }


        private static void MiniMaxSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Mini-Max Sum");
            ResultTester.SpecialTestCase("HR");
        }


        private static void NQueensFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("N-Queens");
            ResultTester.CheckSolution("LC", LeetCode.NQueens.Test.TestCases());
        }


        private static void MinimumOperationstoReduceXtoZeroFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Operations to Reduce X to Zero");
            ResultTester.CheckSolution("LC", LeetCode.MinimumOperationstoReduceXtoZero.Test.TestCases());
        }


        private static void QuestionsMarksFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Questions Marks");
            ResultTester.CheckSolution("CB", CoderByte.QuestionsMarks.Test.TestCases());
        }


        private static void SticklerThiefFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Stickler Thief");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Medium.SticklerThief.Test.TestCases());
        }


        private static void MedianofTwoSortedArraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Median of Two Sorted Arrays");
            ResultTester.CheckSolution("LC", LeetCode.MedianofTwoSortedArrays.Test.TestCases());
        }


        private static void EquilibriumPointFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Equilibrium Point");
            ResultTester.CheckSolution("GFG", GeeksForGeeks.Easy.EquilibriumPoint.Test.TestCases());
        }


        private static void SoldierandBananasFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Soldier and Bananas");
            ResultTester.SpecialTestCase("CF");
        }


        private static void ElephantFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Elephant");
            ResultTester.SpecialTestCase("CF");
        }


        private static void WordFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word");
            ResultTester.CheckSolution("CF", CodeForces.Word.Test.TestCases());
        }


        private static void LongestWordFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Word");
            ResultTester.CheckSolution("CB", CoderByte.LongestWord.Test.TestCases());
        }


        private static void BirthdayCakeCandlesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Birthday Cake Candles");
            ResultTester.SpecialTestCase("HR");
        }


        private static void TimeConversionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Time Conversion");
            ResultTester.SpecialTestCase("HR");
        }


        private static void GradientStudentsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Gradient Students");
            ResultTester.CheckSolution("HR", HackerRank.GradientStudents.Test.TestCases());
        }
        

        private static void MaximumProductofTwoElementsinanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Product of Two Elements in an Array");
            ResultTester.CheckSolution("LC", LeetCode.MaximumProductofTwoElementsinanArray.Test.TestCases());
        }


        private static void ChampagneTowerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Champagne Tower");
            ResultTester.CheckSolution("LC", LeetCode.ChampagneTower.Test.TestCases());
        }


        private static void SpecialPositionsinaBinaryMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Special Positions in a Binary Matrix");
            ResultTester.CheckSolution("LC", LeetCode.SpecialPositionsinaBinaryMatrix.Test.TestCases());
        }
        

        private static void RemoveElementFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Element");
            ResultTester.CheckSolution("LC", LeetCode.RemoveElement.Test.TestCases());
        }


        private static void DifferenceBetweenOnesandZerosinRowandColumnFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Difference Between Ones and Zeros in Row and Column");
            ResultTester.CheckSolution("LC", LeetCode.DifferenceBetweenOnesandZerosinRowandColumn.Test.TestCases());
        }


        private static void RemoveDuplicatesfromSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Duplicates from Sorted Array");
            ResultTester.CheckSolution("LC", LeetCode.RemoveDuplicatesfromSortedArray.Test.TestCases());
        }

        
        private static void TheDescentFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("The Descent");
            ResultTester.SpecialTestCase("CG");
        }


        private static void OnboardingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Onboarding");
            ResultTester.SpecialTestCase("CG");
        }


        private static void RemoveDuplicateLettersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Duplicate Letters");
            ResultTester.CheckSolution("LC", LeetCode.RemoveDuplicateLetters.Test.TestCases());
        }


        private static void DecodedStringatIndexFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Decoded Stringat Index");
            ResultTester.CheckSolution("LC", LeetCode.DecodedStringatIndex.Test.TestCases());
        }


        private static void SortArrayByParityFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort Array By Parity");
            ResultTester.CheckSolution("LC", LeetCode.SortArrayByParity.Test.TestCases());
        }


        private static void WrongSubtractionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Wrong Subtraction");
            ResultTester.SpecialTestCase("CF");
        }


        private static void NearlyLuckyNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Nearly Lucky Number");
            ResultTester.SpecialTestCase("CF");
        }


        private static void OneThreeTwoPatternFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("132 Pattern");
            ResultTester.CheckSolution("LC", LeetCode.OneThreeTwoPattern.Test.TestCases());
        }


        private static void AntonandDanikFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Anton and Danik");
            ResultTester.CheckSolution("CF", CodeForces.AntonandDanik.Test.TestCases());
        }


        private static void ATranslationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("41A Translation");
            ResultTester.CheckSolution("CF", CodeForces.Translation.Test.TestCases());
        }


        private static void ATramFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("116A Tram");
            ResultTester.CheckSolution("CF", CodeForces.Tram.Test.TestCases());
        }


        private static void InvertValuesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Invert Values");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.InvertValues.Test.TestCases());
        }


        private static void RemoveColoredPiecesifBothNeighborsaretheSameColorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Colored Pieces if Both Neighbors are the Same Color");
            ResultTester.CheckSolution("LC", LeetCode.RemoveColoredPiecesifBothNeighborsaretheSameColor.Test.TestCases());
        }


        private static void NumberofGoodPairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Good Pairs");
            ResultTester.CheckSolution("LC", LeetCode.NumberofGoodPairs.Test.TestCases());
        }


        private static void MajorityElementIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Majority Element II");
            ResultTester.CheckSolution("LC", LeetCode.MajorityElementII.Test.TestCases());
        }


        private static void BuildArrayWhereYouCanFindTheMaximumExactlyKComparisonsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Build Array Where You Can Find The Maximum Exactly K Comparisons");
            ResultTester.CheckSolution("LC", LeetCode.BuildArrayWhereYouCanFindTheMaximumExactlyKComparisons.Test.TestCases());
        }


        private static void MaxDotProductofTwoSubsequencesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Dot Product of Two Subsequences");
            ResultTester.CheckSolution("LC", LeetCode.MaxDotProductofTwoSubsequences.Test.TestCases());
        }


        private static void MinimumNumberofOperationstoMakeArrayContinuousFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Operations to Make Array Continuous");
            ResultTester.CheckSolution("LC", LeetCode.MinimumNumberofOperationstoMakeArrayContinuous.Test.TestCases());
        }


        private static void NumberofFlowersinFullBloomFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Flowers in Full Bloom");
            ResultTester.CheckSolution("LC", LeetCode.NumberofFlowersinFullBloom.Test.TestCases());
        }


        private static void FindinMountainArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find in Mountain Array");
            ResultTester.SpecialTestCase("LC");
        }


        private static void VanyaandFenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Vanya and Fence");
            ResultTester.CheckSolution("CF", CodeForces.VanyaandFence.Test.TestCases());
        }


        private static void QueueattheSchoolFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Queue at the School");
            ResultTester.CheckSolution("CF", CodeForces.QueueattheSchool.Test.TestCases());
        }


        private static void MaximumScoreofaGoodSubarrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Score of a Good Subarray");
            ResultTester.CheckSolution("LC", LeetCode.MaximumScoreofaGoodSubarray.Test.TestCases());
        }


        private static void PaintingtheWallsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Painting the Walls");
            ResultTester.SpecialTestCase("LC");
        }


        private static void NumberofWaystoStayintheSamePlaceAfterSomeStepsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Ways to Stay in the Same Place After Some Steps");
            ResultTester.CheckSolution("LC", LeetCode.NumberofWaystoStayintheSamePlaceAfterSomeSteps.Test.TestCases());
        }


        private static void ValidateBinaryTreeNodesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Validate Binary Tree Nodes");
            ResultTester.SpecialTestCase("LC");
        }


        private static void ConstrainedSubsequenceSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Constrained Subsequence Sum");
            ResultTester.CheckSolution("LC", LeetCode.ConstrainedSubsequenceSum.Test.TestCases());
        }


        private static void ParallelCoursesIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Parallel Courses III");
            ResultTester.CheckSolution("LC", LeetCode.ParallelCoursesIII.Test.TestCases());
        }


        private static void CountVowelsPermutationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Vowels Permutation");
            ResultTester.CheckSolution("LC", LeetCode.CountVowelsPermutation.Test.TestCases());
        }


        private static void PowerofFourFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Power of Four");
            ResultTester.CheckSolution("LC", LeetCode.PowerofFour.Test.TestCases());
        }


        private static void FindLargestValueinEachTreeRowFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Largest Value in Each Tree Row");
            ResultTester.SpecialTestCase("LC");
        }


        private static void KthSymbolinGrammarFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("K-th Symbol in Grammar");
            ResultTester.CheckSolution("LC", LeetCode.KthSymbolinGrammar.Test.TestCases());
        }


        private static void BeautifulYearFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Beautiful Year");
            ResultTester.CheckSolution("CF", CodeForces.BeautifulYear.Test.TestCases());
        }
        
        
        private static void BinaryTreesWithFactorsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Trees With Factors");
            ResultTester.CheckSolution("LC", LeetCode.BinaryTreesWithFactors.Test.TestCases());
        }


        private static void PoorPigsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Poor Pigs");
            ResultTester.CheckSolution("LC", LeetCode.PoorPigs.Test.TestCases());
        }


        private static void InSearchofanEasyProblemFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("In Search of an Easy Problem");
            ResultTester.CheckSolution("CF", CodeForces.InSearchofanEasyProblem.Test.TestCases());
        }
        
        
        private static void FindTheOriginalArrayofPrefixXorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find The Original Array of Prefix Xor");
            ResultTester.CheckSolution("LC", LeetCode.FindTheOriginalArrayofPrefixXor.Test.TestCases());
        }


        private static void FindModeinBinarySearchTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Mode in Binary Search Tree");
            ResultTester.SpecialTestCase("LC");
        }
        

        private static void CountNodesEqualtoAverageofSubtreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Nodes Equal to Average of Subtree");
            ResultTester.SpecialTestCase("LC");
        }
        

        private static void BuildanArrayWithStackOperationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Build an Array With Stack Operations");
            ResultTester.CheckSolution("LC", LeetCode.BuildanArrayWithStackOperations.Test.TestCases());
        }


        private static void LastMomentBeforeAllAntsFallOutofaPlankFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Last Moment Before All Ants Fall Out of a Plank");
            ResultTester.CheckSolution("LC", LeetCode.LastMomentBeforeAllAntsFallOutofaPlank.Test.TestCases());
        }


        private static void FindtheKorofanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the K-or of an Array");
            ResultTester.CheckSolution("LC", LeetCode.FindtheKorofanArray.Test.TestCases());
        }


        private static void SubarraysDistinctElementSumofSquaresIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subarrays Distinct Element Sum of Squares I");
            ResultTester.CheckSolution("LC", LeetCode.SubarraysDistinctElementSumofSquaresI.Test.TestCases());
        }


        private static void FindtheWinnerofanArrayGameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Winner of an Array Game");
            ResultTester.CheckSolution("LC", LeetCode.FindtheWinnerofanArrayGame.Test.TestCases());
        }
        
        
        private static void FindChampionIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Champion I");
            ResultTester.CheckSolution("LC", LeetCode.FindChampionI.Test.TestCases());
        }


        private static void MinimumSumofMountainTripletsIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Sum of Mountain Triplets I");
            ResultTester.CheckSolution("LC", LeetCode.MinimumSumofMountainTripletsI.Test.TestCases());
        }


        private static void GeorgeandAccommodationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("George and Accommodation");
            ResultTester.CheckSolution("CF", CodeForces.GeorgeandAccommodation.Test.TestCases());
        }

        
        private static void Print1ToNWithoutLoopFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Print 1 To N Without Loop");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void RichieRichFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Richie Rich");
            ResultTester.CheckSolution("CC", CodeChef.RichieRich.Test.TestCases());
        }


        private static void VaccineDatesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Vaccine Dates");
            ResultTester.SpecialTestCase("CC");
        }


        private static void HoopJumpFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Hoop Jump");
            ResultTester.SpecialTestCase("CC");
        }


        private static void TheTwoDishesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("The Two Dishes");
            ResultTester.SpecialTestCase("CC");
        }


        private static void CalculateaverageFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Calculate average");
            ResultTester.CheckSolution("CW", CodeWars.EightKyu.Calculateaverage.Test.TestCases());
        }


        private static void MotivationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Motivation");
            ResultTester.SpecialTestCase("CC");
        }


        private static void PresentsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Presents");
            ResultTester.SpecialTestCase("CF");
        }

        
        private static void CalculateFunctionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Calculate Function");
            ResultTester.SpecialTestCase("CF");
        }
        
        
        private static void MagnetsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Magnets");
            ResultTester.CheckSolution("CF", CodeForces.Magnets.Test.TestCases());
        }


        private static void SumofupperandlowertrianglesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of upper and lower triangles");
            ResultTester.CheckSolution("CF", GeeksForGeeks.Easy.Sumofupperandlowertriangles.Test.TestCases());
        }


        private static void EliminateMaximumNumberofMonstersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Eliminate Maximum Number of Monsters");
            ResultTester.CheckSolution("LC", LeetCode.EliminateMaximumNumberofMonsters.Test.TestCases());
        }


        private static void DetermineifaCellIsReachableataGivenTimeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Determine if a Cell Is Reachable at a Given Time");
            ResultTester.CheckSolution("LC", LeetCode.DetermineifaCellIsReachableataGivenTime.Test.TestCases());
        }


        private static void CountNumberofHomogenousSubstringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Number of Homogenous Substrings");
            ResultTester.CheckSolution("LC", LeetCode.CountNumberofHomogenousSubstrings.Test.TestCases());
        }


        private static void RestoretheArrayFromAdjacentPairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Restore the Array From Adjacent Pairs");
            ResultTester.CheckSolution("LC", LeetCode.RestoretheArrayFromAdjacentPairs.Test.TestCases());
        }


        private static void DesignGraphWithShortestPathCalculatorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Graph With Shortest Path Calculator");
            ResultTester.SpecialTestCase("LC");
        }


        private static void FindIndicesWithIndexandValueDifferenceIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Indices With Index and Value Difference I");
            ResultTester.CheckSolution("LC", LeetCode.FindIndicesWithIndexandValueDifferenceI.Test.TestCases());
        }


        private static void DistributeCandiesAmongChildrenIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Distribute Candies Among Children I");
            ResultTester.CheckSolution("LC", LeetCode.DistributeCandiesAmongChildrenI.Test.TestCases());
        }


        private static void LifetheUniverseandEverythingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Life the Universe and Everything");
            ResultTester.SpecialTestCase("SPOJ");
        }


        private static void TransformtheExpressionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Transform the Expression");
            ResultTester.SpecialTestCase("SPOJ");
        }


        private static void PrimeGeneratorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Prime Generator");
            ResultTester.SpecialTestCase("SPOJ");
        }
        
        
        private static void AdditionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Addition");
            ResultTester.SpecialTestCase("CSA");
        }


        private static void GreatestCommonDivisorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Greatest Common Divisor");
            ResultTester.SpecialTestCase("CSA");
        }

        private static void MatrixExplorationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Matrix Exploration");
            ResultTester.SpecialTestCase("CSA");
        }

        private static void Multiplesof3or5Func()
        {
            StyleHelper.Space();
            StyleHelper.Title("Multiple of 3 or 5");
            ResultTester.CheckSolution("PE", ProjectEuler.Multiplesof3or5.Test.TestCases());
        }


        private static void LargestPalindromeProductFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Palindrome Product");
            ResultTester.CheckSolution("PE", ProjectEuler.LargestPalindromeProduct.Test.TestCases());
        }


        private static void EvenFibonacciNumbersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Even Fibonacci Numbers");
            ResultTester.CheckSolution("PE", ProjectEuler.EvenFibonacciNumbers.Test.TestCases());
        }

        private static void VelkominFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Velkomin");
            ResultTester.SpecialTestCase("KAT");
        }
        

        private static void EchoEchoEchoFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Echo Echo Echo");
            ResultTester.SpecialTestCase("KAT");
        }


        private static void LeggjasamanFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Leggja saman");
            ResultTester.SpecialTestCase("KAT");
        }


        private static void SecretMessageFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Secret Message");
            ResultTester.SpecialTestCase("KAT");
        }


        private static void SevenWondersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Seven Wonders");
            ResultTester.SpecialTestCase("KAT");
        }

        
        private static void HelloWorldKattisFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Hello World");
            ResultTester.SpecialTestCase("KAT");
        }


        private static void MaximumStrongPairXORIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Strong Pair XOR I");
            ResultTester.CheckSolution("LC", LeetCode.MaximumStrongPairXORI.Test.TestCases());
        }


        private static void LastVisitedIntegersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Last Visited Integers");
            ResultTester.CheckSolution("LC", LeetCode.LastVisitedIntegers.Test.TestCases());
        }


        private static void DrinksFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Drinks");
            ResultTester.CheckSolution("CF", CodeForces.Drinks.Test.TestCases());
        }


        private static void UltraFastMathematicianFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ultra Fast Mathematician");
            ResultTester.SpecialTestCase("CF");
        }


        private static void HittheLotteryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Hit the Lottery");
            ResultTester.SpecialTestCase("CF");
        }


        private static void GamesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Games");
            ResultTester.SpecialTestCase("CF");
        }


        private static void IsyourhorseshoeontheotherhoofFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Is your horseshoe on the other hoof");
            ResultTester.SpecialTestCase("CF");
        }


        private static void AntonandPolyhedronsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Anton and Polyhedrons");
            ResultTester.SpecialTestCase("CF");
        }


        private static void SortVowelsinaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort Vowels in a String");
            ResultTester.CheckSolution("LC", LeetCode.SortVowelsinaString.Test.TestCases());
        }


        private static void MinimumTimeVisitingAllPointsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Time Visiting All Points");
            ResultTester.CheckSolution("LC", LeetCode.MinimumTimeVisitingAllPoints.Test.TestCases());
        }


        private static void DivisibleandNondivisibleSumsDifferenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Divisible and Non divisible Sums Difference");
            ResultTester.CheckSolution("LC", LeetCode.DivisibleandNondivisibleSumsDifference.Test.TestCases());
        }


        private static void FindthePeaksFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Peaks");
            ResultTester.CheckSolution("LC", LeetCode.FindthePeaks.Test.TestCases());
        }


        private static void UniqueLength3PalindromicSubsequencesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Unique Length-3 Palindromic Subsequences");
            ResultTester.CheckSolution("LC", LeetCode.UniqueLength3PalindromicSubsequences.Test.TestCases());
        }


        private static void LargestSameDigitNumberinStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest 3-Same-Digit Number in String");
            ResultTester.CheckSolution("LC", LeetCode.LargestSameDigitNumberinString.Test.TestCases());
        }


        private static void CountofMatchesinTournamentFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count of Matches in Tournament");
            ResultTester.CheckSolution("LC", LeetCode.CountofMatchesinTournament.Test.TestCases());
        }


        private static void CalculateMoneyinLeetcodeBankFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Calculate Money in Leetcode Bank");
            ResultTester.CheckSolution("LC", LeetCode.CalculateMoneyinLeetcodeBank.Test.TestCases());
        }


        private static void LargestOddNumberinStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Odd Number in String");
            ResultTester.CheckSolution("LC", LeetCode.LargestOddNumberinString.Test.TestCases());
        }


        private static void ConstructStringfromBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Construct String from Binary Tree");
            ResultTester.SpecialTestCase("LC");
        }


        private static void MaximumValueofanOrderedTripletIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Value of an Ordered Triplet I");
            ResultTester.CheckSolution("LC", LeetCode.MaximumValueofanOrderedTripletI.Test.TestCases());
        }


        private static void CountNumberofPairsWithAbsoluteDifferenceKFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Number of Pairs With Absolute Difference K");
            ResultTester.CheckSolution("LC", LeetCode.CountNumberofPairsWithAbsoluteDifferenceK.Test.TestCases());
        }


        private static void MaximumElementAfterDecreasingandRearrangingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Element After Decreasing and Rearranging");
            ResultTester.CheckSolution("LC", LeetCode.MaximumElementAfterDecreasingandRearranging.Test.TestCases());
        }


        private static void NumberofValidClockTimesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Valid Clock Times");
            ResultTester.CheckSolution("LC", LeetCode.NumberofValidClockTimes.Test.TestCases());
        }


        private static void FindUniqueBinaryStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Unique Binary String");
            ResultTester.CheckSolution("LC", LeetCode.FindUniqueBinaryString.Test.TestCases());
        }


        private static void BinaryTreetoCDLLFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree to CDLL");
            ResultTester.SpecialTestCase("GFG");
        }


        private static void LargestPrimeFactorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Prime Factor");
            ResultTester.CheckSolution("PE", ProjectEuler.LargestPrimeFactor.Test.TestCases());
        }


        private static void MinimizeMaximumPairSuminArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimize Maximum Pair Sum in Array");
            ResultTester.CheckSolution("LC", LeetCode.MinimizeMaximumPairSuminArray.Test.TestCases());
        }


        private static void DistributeCandiesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Distribute Candies");
            ResultTester.CheckSolution("LC", LeetCode.DistributeCandies.Test.TestCases());
        }


        private static void AccountBalanceAfterRoundedPurchaseFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Account Balance After Rounded Purchase");
            ResultTester.CheckSolution("LC", LeetCode.AccountBalanceAfterRoundedPurchase.Test.TestCases());
        }


        private static void ReductionOperationstoMaketheArrayElementsEqualFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reduction Operations to Make the Array Elements Equal");
            ResultTester.CheckSolution("LC", LeetCode.ReductionOperationstoMaketheArrayElementsEqual.Test.TestCases());
        }


        private static void PalindromeNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Palindrome Number");
            ResultTester.CheckSolution("LC", LeetCode.PalindromeNumber.Test.TestCases());
        }


        private static void MinimumAmountofTimetoCollectGarbageFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Amount of Time to Collect Garbage");
            ResultTester.CheckSolution("LC", LeetCode.MinimumAmountofTimetoCollectGarbage.Test.TestCases());
        }


        private static void ValidPalindromeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Palindrome");
            ResultTester.CheckSolution("LC", LeetCode.ValidPalindrome.Test.TestCases());
        }


        private static void SumofAbsoluteDifferencesinaSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Absolute Differences in a Sorted Array");
            ResultTester.CheckSolution("LC", LeetCode.SumofAbsoluteDifferencesinaSortedArray.Test.TestCases());
        }


        private static void LargestSubmatrixWithRearrangementsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Submatrix With Rearrangements");
            ResultTester.CheckSolution("LC", LeetCode.LargestSubmatrixWithRearrangements.Test.TestCases());
        }
        

        private static void KnightDialerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Knight Dialer");
            ResultTester.CheckSolution("LC", LeetCode.KnightDialer.Test.TestCases());
        }


        private static void NumberofWaystoDivideaLongCorridorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Ways to Divide a Long Corridor");
            ResultTester.CheckSolution("LC", LeetCode.NumberofWaystoDivideaLongCorridor.Test.TestCases());
        }
        

        private static void MakeThreeStringsEqualFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Make Three Strings Equal");
            ResultTester.CheckSolution("LC", LeetCode.MakeThreeStringsEqual.Test.TestCases());
        }


        private static void MatrixSimilarityAfterCyclicShiftsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Matrix Similarity After Cyclic Shifts");
            ResultTester.CheckSolution("LC", LeetCode.MatrixSimilarityAfterCyclicShifts.Test.TestCases());
        }


        private static void MinimumOneBitOperationstoMakeIntegersZeroFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum One Bit Operations to Make Integers Zero");
            ResultTester.CheckSolution("LC", LeetCode.MinimumOneBitOperationstoMakeIntegersZero.Test.TestCases());
        }


        private static void FindWordsContainingCharacterFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Words Containing Character");
            ResultTester.CheckSolution("LC", LeetCode.FindWordsContainingCharacter.Test.TestCases());
        }


        private static void CheckIfTwoStringArraysareEquivalentFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check If Two String Arrays are Equivalent");
            ResultTester.CheckSolution("LC", LeetCode.CheckIfTwoStringArraysareEquivalent.Test.TestCases());
        }


        private static void FindWordsThatCanBeFormedbyCharactersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Words That Can Be Formed by Characters");
            ResultTester.CheckSolution("LC", LeetCode.FindWordsThatCanBeFormedbyCharacters.Test.TestCases());
        }


        private static void ElementAppearingMoreThanInSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Element Appearing More Than 25% In Sorted Array");
            ResultTester.CheckSolution("LC", LeetCode.ElementAppearingMoreThanInSortedArray.Test.TestCases());
        }


        private static void MinimumOperationstoCollectElementsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Operations to Collect Elements");
            ResultTester.CheckSolution("LC", LeetCode.MinimumOperationstoCollectElements.Test.TestCases());
        }


        private static void DestinationCityFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Destination City");
            ResultTester.CheckSolution("LC", LeetCode.DestinationCity.Test.TestCases());
        }


        private static void SortthePeopleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort the People");
            ResultTester.CheckSolution("LC", LeetCode.SortthePeople.Test.TestCases());
        }


        private static void SubarraysDivByKFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subarrays Div By K");

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

        private static void TopKFrequentFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Top K Frequent");

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

        // CURRENT TESTS
        private static void CurrentTests()
        {
            SortthePeopleFunc();
        }
    }
}