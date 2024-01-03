using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Services.Interfaces;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.Services.Providers
{
    public class LeetCodeServices : ILeetCodeServices
    {
        public int GetLeetCodeEasyProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(leetCodeEasyList);
        }

        public int GetLeetCodeMediumProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(leetCodeMediumList);
        }

        public int GetLeetCodeHardProblems()
        {
            return InvokeDelegateHelper.InvokeDelegateIfNotNull(leetCodeHardList);
        }

        // Delegates
        private static readonly Delegate[] leetCodeEasyList = new Delegate[]
        {
            ClimbingStairsFunc, AddTwoIntegersFunc, NumberOfStepsFunc, ContainsDuplicateFunc, BestTimetoBuyandSellStockFunc, RangeSumQueryImmutableFunc, DesignHashSetFunc, SearchintoaBinarySearchTreeFunc, SameTreeFunc, AddStringsFunc,
            FirstUniqueCharacterinaStringFunc, SingleNumberFunc, FindJudgeFunc, ShuffleTheArrayFunc, CountOddNumbersInAnIntervalRangeFunc, RunningSumof1dArrayFunc, TwoSumIVInputisaBSTFunc, WordPatternFunc, SymmetricTreeFunc, FindtheKorofanArrayFunc,
            AddBinaryFunc, DefanginganIPAddressFunc, FindLuckyIntegerinanArrayFunc, SearchInsertPositionFunc, FindtheIndexoftheFirstOccurrenceinaStringFunc, MinimumDistanceBetweenBSTNodesFunc, PascalsTriangleIIFunc, DiameterofBinaryTreeFunc,
            KthMissingPositiveNumberFunc, ConvertSortedArraytoBinarySearchTreeFunc, CanPlaceFlowersFunc, KItemsWiththeMaximumSumFunc, BinarySearchFunc, MiddleoftheLinkedListFunc, ReshapetheMatrixFunc, MergeSortedArrayFunc, FindChampionIFunc,
            CheckIfNandItsDoubleExistFunc, ConcatenationofArrayFunc, KidsWiththeGreatestNumberofCandiesFunc, MergeStringsAlternatelyFunc, RomantoIntegerFunc, DesignHashMapFunc, AlternatingDigitSumFunc, TwoSumFunc, BalancedBinaryTreeFunc, FurthestPointFromOriginFunc,
            BestPokerHandFunc, LastStoneWeightFunc, AddDigitsFunc, BulbSwitcherFunc, FindtheDifferenceFunc, RepeatedSubstringPatternFunc, VerifyinganAlienDictionaryFunc, MinimumAbsoluteDifferenceinBSTFunc, BackspaceStringCompareFunc, CheckifStringsCanbeMadeEqualWithOperationsIFunc,
            MoveZeroesFunc, PlusOneFunc, AverageSalaryExcludingtheMinimumandMaximumSalaryFunc, FindifPathExistsinGraphFunc, RichestCustomerWealthFunc, NumberofRecentCallsFunc, LongestPalindromeFunc, BuddyStringsFunc, NumberofGoodPairsFunc, RedistributeCharacterstoMakeAllStringsEqualFunc,
            SignoftheProductofanArrayFunc, CanMakeArithmeticProgressionFunc, MonotonicArrayFunc, LengthofLastWordFunc, ToLowerCaseFunc, ConvertBinaryNumberinaLinkedListtoIntegerFunc, FirstBadVersionFunc, SubtreeofAnotherTreeFunc, MaximumProductDifferenceBetweenTwoPairsFunc,
            FindSmallestLetterGreaterThanTargetFunc, CountNegativeNumbersinaSortedMatrixFunc, ValidPerfectSquareFunc, ArrangingCoinsFunc, BaseballGameFunc, KeysandRoomsFunc, SumofLeftLeavesFunc, BinaryTreeInorderTraversalFunc, SortthePeopleFunc, AssignCookiesFunc,
            RobotReturntoOriginFunc, FindWinneronaTicTacToeGameFunc, LemonadeChangeFunc, LargestPerimeterTriangleFunc, CheckIfItIsaStraightLineFunc, DeleteColumnstoMakeSortedFunc, GuessNumberHigherorLowerFunc, ExcelSheetColumnTitleFunc, ImageSmootherFunc,
            ReverseVowelsofaStringFunc, CountingBitsFunc, IsSubsequenceFunc, MinCostClimbingStairsFunc, MaximumAverageSubarrayIFunc, DesignParkingSystemFunc, LeafSimilarTreesFunc, IntersectionofTwoArraysIIFunc, RemoveElementFunc, FindMissingandRepeatedValuesFunc,
            FindtheHighestAltitudeFunc, FindPivotIndexFunc, UniqueNumberofOccurrencesFunc, MajorityElementFunc, GoalParserInterpretationFunc, AddtoArrayFormofIntegerFunc, DetectCapitalFunc, ValidAnagramFunc, ImplementStackusingQueuesFunc, MaxPairSuminanArrayFunc,
            FloodFillFunc, HappyNumberFunc, DecryptStringfromAlphabettoIntegerMappingFunc, TheKWeakestRowsinaMatrixFunc, CheckifOneStringSwapCanMakeStringsEqualFunc, MergeTwoBinaryTreesFunc, BinaryTreePreorderTraversalFunc, FindWordsContainingCharacterFunc,
            SubtracttheProductandSumofDigitsofanIntegerFunc, SpecialArrayWithXElementsGreaterThanorEqualXFunc, SqrtxFunc, FindtheDistanceValueBetweenTwoArraysFunc, SortColorsFunc, ReverseStringFunc, IntersectionofTwoLinkedListsFunc, ExcelSheetColumnNumberFunc,
            SumofAllOddLengthSubarraysFunc, NextGreaterElementIFunc, SquaresofaSortedArrayFunc, FibonacciNumberFunc, FindNearestPointThatHastheSameXorYCoordinateFunc, NaryTreePreorderTraversalFunc, MaximumAscendingSubarraySumFunc, DestinationCityFunc,
            Numberof1BitsFunc, SortIntegersbyTheNumberof1BitsFunc, SearchinRotatedSortedArrayFunc, PowerofTwoFunc, ReverseWordsinaStringIIIFunc, GreatestCommonDivisorofStringsFunc, RansomNoteFunc, ValidParenthesesFunc, MakeThreeStringsEqualFunc, FaultyKeyboardFunc,
            ReverseBitsFunc, MaximumValueofaStringinanArrayFunc, SummaryRangesFunc, FindtheDifferenceofTwoArraysFunc, IntegerBreakFunc, NthTribonacciNumberFunc, KthLargestElementinaStreamFunc, MergeTwoSortedListsFunc, UniqueLength3PalindromicSubsequencesFunc,
            InvertBinaryTreeFunc, IsomorphicStringsFunc, RemoveLinkedListElementsFunc, LinkedListCycleFunc, PascalsTriangleFunc, PathSumFuncFunc, MaximumDepthofBinaryTreeFunc, RemoveDuplicatesfromSortedListFunc, PowerofFourFunc, MinimumOperationstoCollectElementsFunc,
            DetermineWhetherMatrixCanBeObtainedByRotationFunc, MinimumDepthofBinaryTreeFunc, RemoveDuplicatesfromSortedArrayFunc, SortArrayByParityFunc, FindModeinBinarySearchTreeFunc, LastVisitedIntegersFunc, SpecialPositionsinaBinaryMatrixFunc,
            SubarraysDistinctElementSumofSquaresIFunc, MinimumSumofMountainTripletsIFunc, FindIndicesWithIndexandValueDifferenceIFunc, DistributeCandiesAmongChildrenIFunc, MaximumStrongPairXORIFunc, DivisibleandNondivisibleSumsDifferenceFunc, BuyTwoChocolatesFunc,
            CountNumberofPairsWithAbsoluteDifferenceKFunc, NumberofValidClockTimesFunc, DistributeCandiesFunc, AccountBalanceAfterRoundedPurchaseFunc, PalindromeNumberFunc, ValidPalindromeFunc, MatrixSimilarityAfterCyclicShiftsFunc, MaximumProductofTwoElementsinanArrayFunc,
            CheckIfTwoStringArraysareEquivalentFunc, FindWordsThatCanBeFormedbyCharactersFunc, MinimumTimeVisitingAllPointsFunc, FindthePeaksFunc, LargestSameDigitNumberinStringFunc, CountofMatchesinTournamentFunc, CalculateMoneyinLeetcodeBankFunc, MaximumOddBinaryNumberFunc,
            LargestOddNumberinStringFunc, ConstructStringfromBinaryTreeFunc, MaximumValueofanOrderedTripletIFunc, FindCommonElementsBetweenTwoArraysFunc, TransposeMatrixFunc, CountTestedDevicesAfterTestOperationsFunc, ElementAppearingMoreThanInSortedArrayFunc,
            SumofValuesatIndicesWithKSetBitsFunc, MaximumScoreAfterSplittingaStringFunc, MinimumRightShiftstoSorttheArrayFunc, PointsThatIntersectWithCarsFunc, CountSymmetricIntegersFunc, PathCrossingFunc, MinimumChangesToMakeAlternatingBinaryStringFunc,
            MinimumNumberGameFunc, CounttheNumberofIncremovableSubarraysIFunc, CheckifaStringIsanAcronymofWordsFunc, CountPairsWhoseSumisLessthanTargetFunc, LargestSubstringBetweenTwoEqualCharactersFunc, CheckifBitwiseORHasTrailingZerosFunc,
            RemoveTrailingZerosFromaStringFunc,
        };

        private static readonly Delegate[] leetCodeMediumList = new Delegate[]
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
            MinimumAmountofTimetoCollectGarbageFunc, CountNicePairsinanArrayFunc, DiagonalTraverseIIFunc, MaximumNumberofCoinsYouCanGetFunc, SumofAbsoluteDifferencesinaSortedArrayFunc, LargestSubmatrixWithRearrangementsFunc, KnightDialerFunc, DifferenceBetweenOnesandZerosinRowandColumnFunc, DesignaFoodRatingSystemFunc,
            WidestVerticalAreaBetweenTwoPointsContainingNoPointsFunc, NumberofDiceRollsWithTargetSumFunc, MinimumTimetoMakeRopeColorfulFunc, ConvertanArrayIntoaTwoDArrayWithConditionsFunc, NumberofLaserBeamsinaBankFunc,
        };

        private static readonly Delegate[] leetCodeHardList = new Delegate[]
        {
            CountDigitOneFunc, LongestPathWithDifferentAdjacentCharactersFunc, CheckifPointIsReachableFunc, NamingaCompanyFunc, IPOFunc, EditDistanceFunc, CountSubarraysWithFixedBoundsFunc, JumpGameIVFunc, LongestCycleinaGraphFunc, NumberofWaysofCuttingaPizzaFunc, FindMinimuminRotatedSortedArrayIIFunc, NumberofMusicPlaylistsFunc, WordLadderFunc, CandyFunc,
            ReducingDishesFunc, ScrambleStringFunc, MinimumReverseOperationsFunc, LargestColorValueinaDirectedGraphFunc, MaximumValueofKCoinsFromPilesFunc, NumberofWaystoFormaTargetStringGivenaDictionaryFunc, ProfitableSchemesFunc, MinimumInsertionStepstoMakeaStringPalindromeFunc, RestoreTheArrayFunc, FindtheLongestValidObstacleCourseatEachPositionFunc,
            MaximizeScoreAfterNOperationsFunc, StoneGameIIIFunc, MinimumCosttoCutaStickFunc, TrappingRainWaterFunc, NumberofGoodPathsFunc, SerializeandDeserializeBinaryTreeFunc, ReverseNodesinkGroupFunc, MakeArrayStrictlyIncreasingFunc, NumberofIncreasingPathsinaGridFunc, FrogJumpFunc, TextJustificationFunc, SortItemsbyGroupsRespectingDependenciesFunc,
            NumberofWaystoReorderArraytoGetSameBSTFunc, TallestBillboardFunc, CheckingExistenceofEdgeLengthLimitedPathsFunc, MinimizeDeviationinArrayFunc, SubstringWithLargestVarianceFunc, MergekSortedListsFunc, PutMarblesinBagsFunc, CountAllValidPickupandDeliveryOptionsFunc, ReconstructItineraryFunc, NQueensFunc, PaintingtheWallsFunc, PoorPigsFunc,
            CountAllPossibleRoutesFunc, MinimumJumpstoReachHomeFunc, BusRoutesFunc, StrangePrinterFunc, SumofDistancesinTreeFunc, DataStreamasDisjointIntervalsFunc, MinimumNumberofTapstoOpentoWateraGardenFunc, MaxDotProductofTwoSubsequencesFunc, NumberofFlowersinFullBloomFunc, FindinMountainArrayFunc, ConstrainedSubsequenceSumFunc, ParallelCoursesIIIFunc,
            MinimumCosttoMakeArrayEqualFunc, RemoveMaxNumberofEdgestoKeepGraphFullyTraversableFunc, FirstMissingPositiveFunc, LFUCacheFunc, BinaryTreeMaximumPathSumFunc, MinimumNumberofOperationstoMakeArrayContinuousFunc, NumberofWaystoStayintheSamePlaceAfterSomeStepsFunc, CountVowelsPermutationFunc, MinimumOneBitOperationstoMakeIntegersZeroFunc,
            MaximumNumberofEventsThatCanBeAttendedIIFunc, SmallestSufficientTeamFunc, MaximumNumberofAchievableTransferRequestsFunc, MaxPointsonaLineFunc, MaximumRunningTimeofNComputersFunc, DesignGraphWithShortestPathCalculatorFunc, MinimumDifficultyofaJobScheduleFunc,
            CourseScheduleIIFunc, LastDayWhereYouCanStillCrossFunc, ShortestPathtoGetAllKeysFunc, SimilarStringGroupsFunc, ConcatenatedWordsFunc, SlidingWindowMaximumFunc, MaximumScoreofaGoodSubarrayFunc, NumberofWaystoDivideaLongCorridorFunc,
            FindCriticalandPseudoCriticalEdgesinMinimumSpanningTreeFunc, MinimumReplacementstoSorttheArrayFunc, MedianofTwoSortedArraysFunc, BuildArrayWhereYouCanFindTheMaximumExactlyKComparisonsFunc, StringCompressionIIFunc,
        };

        // Functions 

        private static void NumberofLaserBeamsinaBankFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Laser Beams in a Bank");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofLaserBeamsinaBank.Test.TestCases());
        }

        private static void ConvertanArrayIntoaTwoDArrayWithConditionsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert an Array Into a 2D Array With Conditions");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ConvertanArrayIntoaTwoDArrayWithConditions.Test.TestCases());
        }

        private static void RemoveTrailingZerosFromaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Trailing Zeros From a String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RemoveTrailingZerosFromaString.Test.TestCases());
        }

        private static void CheckifBitwiseORHasTrailingZerosFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check if Bitwise OR Has Trailing Zeros");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CheckifBitwiseORHasTrailingZeros.Test.TestCases());
        }

        private static void AssignCookiesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Assign Cookies");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.AssignCookies.Test.TestCases());
        }

        private static void LargestSubstringBetweenTwoEqualCharactersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Substring Between Two Equal Characters");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LargestSubstringBetweenTwoEqualCharacters.Test.TestCases());
        }

        private static void FaultyKeyboardFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Faulty Keyboard");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FaultyKeyboard.Test.TestCases());
        }

        private static void RedistributeCharacterstoMakeAllStringsEqualFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Redistribute Characters to Make All Strings Equal");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RedistributeCharacterstoMakeAllStringsEqual.Test.TestCases());
        }

        private static void MaxPairSuminanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Pair Sum in an Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaxPairSuminanArray.Test.TestCases());
        }

        private static void CountPairsWhoseSumisLessthanTargetFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Pairs Whose Sum is Less than Target");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountPairsWhoseSumisLessthanTarget.Test.TestCases());
        }

        private static void MinimumDifficultyofaJobScheduleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Difficulty of a Job Schedule");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumDifficultyofaJobSchedule.Test.TestCases());
        }

        private static void CheckifaStringIsanAcronymofWordsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check if a String Is an Acronym of Words");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CheckifaStringIsanAcronymofWords.Test.TestCases());
        }

        private static void FurthestPointFromOriginFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Furthest Point From Origin");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FurthestPointFromOrigin.Test.TestCases());
        }

        private static void StringCompressionIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("String Compression II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.StringCompressionII.Test.TestCases());
        }

        private static void CheckifStringsCanbeMadeEqualWithOperationsIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check if Strings Can be Made Equal With Operations I");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CheckifStringsCanbeMadeEqualWithOperationsI.Test.TestCases());
        }

        private static void MinimumTimetoMakeRopeColorfulFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Time to Make Rope Colorful");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumTimetoMakeRopeColorful.Test.TestCases());
        }

        private static void CounttheNumberofIncremovableSubarraysIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count the Number of Incremovable Subarrays I");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CounttheNumberofIncremovableSubarraysI.Test.TestCases());
        }

        private static void NumberofDiceRollsWithTargetSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Dice Rolls With Target Sum");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofDiceRollsWithTargetSum.Test.TestCases());
        }

        private static void MinimumNumberGameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number Game");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumNumberGame.Test.TestCases());
        }

        private static void MinimumChangesToMakeAlternatingBinaryStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Changes To Make Alternating Binary String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumChangesToMakeAlternatingBinaryString.Test.TestCases());
        }

        private static void PathCrossingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Path Crossing");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PathCrossing.Test.TestCases());
        }

        private static void CountSymmetricIntegersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Symmetric Integers");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountSymmetricIntegers.Test.TestCases());
        }

        private static void PointsThatIntersectWithCarsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Points That Intersect With Cars");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PointsThatIntersectWithCars.Test.TestCases());
        }

        private static void MinimumRightShiftstoSorttheArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Right Shifts to Sort the Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumRightShiftstoSorttheArray.Test.TestCases());
        }

        private static void MaximumScoreAfterSplittingaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Score After Splitting a String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumScoreAfterSplittingaString.Test.TestCases());
        }

        private static void SubarraysDivByKFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subarrays Div By K");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SubarraySumsDivisiblebyK.Test.TestSubarraySumsDivisiblebyK());
        }
        
        private static void CountAllValidPickupandDeliveryOptionsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count All Valid Pickup and Delivery Options");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountAllValidPickupandDeliveryOptions.Test.TestCases());
        }

        private static void GroupthePeopleGiventheGroupSizeTheyBelongToFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Group the People Given the Group Size They Belong To");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.GroupthePeopleGiventheGroupSizeTheyBelongTo.Test.TestCases());
        }

        private static void MinimumDeletionstoMakeCharacterFrequenciesUniqueFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Deletions to Make Character Frequencies Unique");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumDeletionstoMakeCharacterFrequenciesUnique.Test.TestCases());
        }

        private static void CandyFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Candy");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.Candy.Test.TestCases());
        }

        private static void MinCosttoConnectAllPointsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Min Cost to Connect All Points");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinCosttoConnectAllPoints.Test.TestCases());
        }

        private static void ReconstructItineraryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reconstruct Itinerary");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void NQueensFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("N-Queens");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NQueens.Test.TestCases());
        }

        private static void MinimumOperationstoReduceXtoZeroFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Operations to Reduce X to Zero");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumOperationstoReduceXtoZero.Test.TestCases());
        }

        private static void MedianofTwoSortedArraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Median of Two Sorted Arrays");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MedianofTwoSortedArrays.Test.TestCases());
        }

        private static void MaximumProductofTwoElementsinanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Product of Two Elements in an Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumProductofTwoElementsinanArray.Test.TestCases());
        }

        private static void ChampagneTowerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Champagne Tower");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ChampagneTower.Test.TestCases());
        }

        private static void SpecialPositionsinaBinaryMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Special Positions in a Binary Matrix");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SpecialPositionsinaBinaryMatrix.Test.TestCases());
        }

        private static void RemoveElementFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Element");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RemoveElement.Test.TestCases());
        }

        private static void DifferenceBetweenOnesandZerosinRowandColumnFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Difference Between Ones and Zeros in Row and Column");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DifferenceBetweenOnesandZerosinRowandColumn.Test.TestCases());
        }

        private static void RemoveDuplicatesfromSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Duplicates from Sorted Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RemoveDuplicatesfromSortedArray.Test.TestCases());
        }

        private static void RemoveDuplicateLettersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Duplicate Letters");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RemoveDuplicateLetters.Test.TestCases());
        }

        private static void DecodedStringatIndexFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Decoded Stringat Index");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DecodedStringatIndex.Test.TestCases());
        }

        private static void SortArrayByParityFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort Array By Parity");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SortArrayByParity.Test.TestCases());
        }

        private static void OneThreeTwoPatternFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("132 Pattern");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.OneThreeTwoPattern.Test.TestCases());
        }

        private static void RemoveColoredPiecesifBothNeighborsaretheSameColorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Colored Pieces if Both Neighbors are the Same Color");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RemoveColoredPiecesifBothNeighborsaretheSameColor.Test.TestCases());
        }

        private static void NumberofGoodPairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Good Pairs");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofGoodPairs.Test.TestCases());
        }

        private static void TopKFrequentFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Top K Frequent");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MajorityElementIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Majority Element II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MajorityElementII.Test.TestCases());
        }

        private static void BuildArrayWhereYouCanFindTheMaximumExactlyKComparisonsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Build Array Where You Can Find The Maximum Exactly K Comparisons");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BuildArrayWhereYouCanFindTheMaximumExactlyKComparisons.Test.TestCases());
        }

        private static void MaxDotProductofTwoSubsequencesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Dot Product of Two Subsequences");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaxDotProductofTwoSubsequences.Test.TestCases());
        }

        private static void MinimumNumberofOperationstoMakeArrayContinuousFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Operations to Make Array Continuous");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumNumberofOperationstoMakeArrayContinuous.Test.TestCases());
        }

        private static void NumberofFlowersinFullBloomFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Flowers in Full Bloom");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofFlowersinFullBloom.Test.TestCases());
        }

        private static void FindinMountainArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find in Mountain Array");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MaximumScoreofaGoodSubarrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Score of a Good Subarray");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumScoreofaGoodSubarray.Test.TestCases());
        }

        private static void PaintingtheWallsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Painting the Walls");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void NumberofWaystoStayintheSamePlaceAfterSomeStepsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Ways to Stay in the Same Place After Some Steps");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofWaystoStayintheSamePlaceAfterSomeSteps.Test.TestCases());
        }

        private static void ValidateBinaryTreeNodesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Validate Binary Tree Nodes");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ConstrainedSubsequenceSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Constrained Subsequence Sum");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ConstrainedSubsequenceSum.Test.TestCases());
        }

        private static void ParallelCoursesIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Parallel Courses III");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ParallelCoursesIII.Test.TestCases());
        }

        private static void CountVowelsPermutationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Vowels Permutation");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountVowelsPermutation.Test.TestCases());
        }

        private static void PowerofFourFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Power of Four");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PowerofFour.Test.TestCases());
        }

        private static void FindLargestValueinEachTreeRowFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Largest Value in Each Tree Row");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void KthSymbolinGrammarFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("K-th Symbol in Grammar");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.KthSymbolinGrammar.Test.TestCases());
        }
        
        private static void BinaryTreesWithFactorsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Trees With Factors");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BinaryTreesWithFactors.Test.TestCases());
        }

        private static void PoorPigsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Poor Pigs");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PoorPigs.Test.TestCases());
        }

        private static void FindTheOriginalArrayofPrefixXorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find The Original Array of Prefix Xor");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindTheOriginalArrayofPrefixXor.Test.TestCases());
        }

        private static void FindModeinBinarySearchTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Mode in Binary Search Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }
        
        private static void CountNodesEqualtoAverageofSubtreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Nodes Equal to Average of Subtree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }
        
        private static void BuildanArrayWithStackOperationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Build an Array With Stack Operations");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BuildanArrayWithStackOperations.Test.TestCases());
        }

        private static void LastMomentBeforeAllAntsFallOutofaPlankFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Last Moment Before All Ants Fall Out of a Plank");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LastMomentBeforeAllAntsFallOutofaPlank.Test.TestCases());
        }

        private static void FindtheKorofanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the K-or of an Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindtheKorofanArray.Test.TestCases());
        }

        private static void SubarraysDistinctElementSumofSquaresIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subarrays Distinct Element Sum of Squares I");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SubarraysDistinctElementSumofSquaresI.Test.TestCases());
        }

        private static void FindtheWinnerofanArrayGameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Winner of an Array Game");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindtheWinnerofanArrayGame.Test.TestCases());
        }
        
        private static void FindChampionIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Champion I");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindChampionI.Test.TestCases());
        }

        private static void MinimumSumofMountainTripletsIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Sum of Mountain Triplets I");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumSumofMountainTripletsI.Test.TestCases());
        }

        private static void EliminateMaximumNumberofMonstersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Eliminate Maximum Number of Monsters");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.EliminateMaximumNumberofMonsters.Test.TestCases());
        }

        private static void DetermineifaCellIsReachableataGivenTimeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Determine if a Cell Is Reachable at a Given Time");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DetermineifaCellIsReachableataGivenTime.Test.TestCases());
        }

        private static void CountNumberofHomogenousSubstringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Number of Homogenous Substrings");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountNumberofHomogenousSubstrings.Test.TestCases());
        }

        private static void RestoretheArrayFromAdjacentPairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Restore the Array From Adjacent Pairs");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RestoretheArrayFromAdjacentPairs.Test.TestCases());
        }

        private static void DesignGraphWithShortestPathCalculatorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Graph With Shortest Path Calculator");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void FindIndicesWithIndexandValueDifferenceIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Indices With Index and Value Difference I");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindIndicesWithIndexandValueDifferenceI.Test.TestCases());
        }

        private static void DistributeCandiesAmongChildrenIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Distribute Candies Among Children I");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DistributeCandiesAmongChildrenI.Test.TestCases());
        }

        private static void MaximumStrongPairXORIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Strong Pair XOR I");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumStrongPairXORI.Test.TestCases());
        }

        private static void LastVisitedIntegersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Last Visited Integers");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LastVisitedIntegers.Test.TestCases());
        }

        private static void SortVowelsinaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort Vowels in a String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SortVowelsinaString.Test.TestCases());
        }

        private static void MinimumTimeVisitingAllPointsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Time Visiting All Points");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumTimeVisitingAllPoints.Test.TestCases());
        }

        private static void DivisibleandNondivisibleSumsDifferenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Divisible and Non divisible Sums Difference");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DivisibleandNondivisibleSumsDifference.Test.TestCases());
        }

        private static void FindthePeaksFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Peaks");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindthePeaks.Test.TestCases());
        }

        private static void UniqueLength3PalindromicSubsequencesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Unique Length-3 Palindromic Subsequences");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.UniqueLength3PalindromicSubsequences.Test.TestCases());
        }

        private static void LargestSameDigitNumberinStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest 3-Same-Digit Number in String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LargestSameDigitNumberinString.Test.TestCases());
        }

        private static void CountofMatchesinTournamentFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count of Matches in Tournament");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountofMatchesinTournament.Test.TestCases());
        }

        private static void CalculateMoneyinLeetcodeBankFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Calculate Money in Leetcode Bank");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CalculateMoneyinLeetcodeBank.Test.TestCases());
        }

        private static void LargestOddNumberinStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Odd Number in String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LargestOddNumberinString.Test.TestCases());
        }

        private static void ConstructStringfromBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Construct String from Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MaximumValueofanOrderedTripletIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Value of an Ordered Triplet I");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumValueofanOrderedTripletI.Test.TestCases());
        }

        private static void CountNumberofPairsWithAbsoluteDifferenceKFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Number of Pairs With Absolute Difference K");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountNumberofPairsWithAbsoluteDifferenceK.Test.TestCases());
        }

        private static void MaximumElementAfterDecreasingandRearrangingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Element After Decreasing and Rearranging");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumElementAfterDecreasingandRearranging.Test.TestCases());
        }

        private static void NumberofValidClockTimesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Valid Clock Times");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofValidClockTimes.Test.TestCases());
        }

        private static void FindUniqueBinaryStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Unique Binary String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindUniqueBinaryString.Test.TestCases());
        }

        private static void MinimizeMaximumPairSuminArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimize Maximum Pair Sum in Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimizeMaximumPairSuminArray.Test.TestCases());
        }

        private static void DistributeCandiesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Distribute Candies");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DistributeCandies.Test.TestCases());
        }

        private static void AccountBalanceAfterRoundedPurchaseFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Account Balance After Rounded Purchase");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.AccountBalanceAfterRoundedPurchase.Test.TestCases());
        }

        private static void ReductionOperationstoMaketheArrayElementsEqualFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reduction Operations to Make the Array Elements Equal");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ReductionOperationstoMaketheArrayElementsEqual.Test.TestCases());
        }

        private static void PalindromeNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Palindrome Number");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PalindromeNumber.Test.TestCases());
        }

        private static void MinimumAmountofTimetoCollectGarbageFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Amount of Time to Collect Garbage");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumAmountofTimetoCollectGarbage.Test.TestCases());
        }

        private static void ValidPalindromeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Palindrome");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ValidPalindrome.Test.TestCases());
        }

        private static void SumofAbsoluteDifferencesinaSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Absolute Differences in a Sorted Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SumofAbsoluteDifferencesinaSortedArray.Test.TestCases());
        }

        private static void LargestSubmatrixWithRearrangementsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Submatrix With Rearrangements");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LargestSubmatrixWithRearrangements.Test.TestCases());
        }
        
        private static void KnightDialerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Knight Dialer");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.KnightDialer.Test.TestCases());
        }

        private static void NumberofWaystoDivideaLongCorridorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Ways to Divide a Long Corridor");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofWaystoDivideaLongCorridor.Test.TestCases());
        }

        private static void MakeThreeStringsEqualFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Make Three Strings Equal");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MakeThreeStringsEqual.Test.TestCases());
        }

        private static void MatrixSimilarityAfterCyclicShiftsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Matrix Similarity After Cyclic Shifts");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MatrixSimilarityAfterCyclicShifts.Test.TestCases());
        }

        private static void MinimumOneBitOperationstoMakeIntegersZeroFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum One Bit Operations to Make Integers Zero");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumOneBitOperationstoMakeIntegersZero.Test.TestCases());
        }

        private static void FindWordsContainingCharacterFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Words Containing Character");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindWordsContainingCharacter.Test.TestCases());
        }

        private static void CheckIfTwoStringArraysareEquivalentFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check If Two String Arrays are Equivalent");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CheckIfTwoStringArraysareEquivalent.Test.TestCases());
        }

        private static void FindWordsThatCanBeFormedbyCharactersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Words That Can Be Formed by Characters");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindWordsThatCanBeFormedbyCharacters.Test.TestCases());
        }

        private static void ElementAppearingMoreThanInSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Element Appearing More Than 25% In Sorted Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ElementAppearingMoreThanInSortedArray.Test.TestCases());
        }

        private static void MinimumOperationstoCollectElementsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Operations to Collect Elements");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumOperationstoCollectElements.Test.TestCases());
        }

        private static void DestinationCityFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Destination City");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DestinationCity.Test.TestCases());
        }

        private static void SortthePeopleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort the People");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SortthePeople.Test.TestCases());
        }

        private static void ExcelSheetColumnNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Excel Sheet Column Number");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ExcelSheetColumnNumber.Test.TestCases());
        }

        private static void WidestVerticalAreaBetweenTwoPointsContainingNoPointsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Widest Vertical Area Between Two Points Containing No Points");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.WidestVerticalAreaBetweenTwoPointsContainingNoPoints.Test.TestCases());
        }

        private static void MaximumOddBinaryNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Odd Binary Number");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumOddBinaryNumber.Test.TestCases());
        }

        private static void SumofValuesatIndicesWithKSetBitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Values at Indices With K Set Bits");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SumofValuesatIndicesWithKSetBits.Test.TestCases());
        }

        private static void MinimizetheMaximumDifferenceofPairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimize the Maximum Difference of Pairs");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimizetheMaximumDifferenceofPairs.Test.TestCase());
        }

        private static void WordLadderFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word Ladder");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.WordLadder.Test.TestCase());
        }

        private static void KClosestPointstoOriginFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("K Closest Points to Origin");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.KClosestPointstoOrigin.Test.TestCases());
        }

        private static void SlidingWindowMaximumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sliding Window Maximum");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SlidingWindowMaximum.Test.TestCases());
        }

        private static void PartitionListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Partition List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void CheckifThereisaValidPartitionForTheArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check if There is a Valid Partition For The Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CheckifThereisaValidPartitionForTheArray.Test.TestCases());
        }

        private static void PerfectSquaresFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Perfect Squares");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PerfectSquares.Test.TestCases());
        }

        private static void CombinationSumIVFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Combination Sum IV");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CombinationSumIV.Test.TestCases());
        }

        private static void FindCriticalandPseudoCriticalEdgesinMinimumSpanningTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Critical and Pseudo-Critical Edges in Minimum Spanning Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void TimeBasedKeyValueStoreFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Time Based Key-Value Store");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MaximumLengthofPairChainFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Length of Pair Chain");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumLengthofPairChain.Test.TestCases());
        }

        private static void MinimumReplacementstoSorttheArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Replacements to Sort the Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumReplacementstoSorttheArray.Test.TestCases());
        }

        private static void MinimumPenaltyforaShopFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Penalty for a Shop");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumPenaltyforaShop.Test.TestCases());
        }

        private static void ImplementStackusingQueuesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Implement Stack using Queues");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ExtraCharactersinaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Extra Characters in a String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ExtraCharactersinaString.Test.TestCases());
        }

        private static void MinimumNumberofTapstoOpentoWateraGardenFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Taps to Open to Water a Garden");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumNumberofTapstoOpentoWateraGarden.Test.TestCases());
        }

        private static void InterleavingStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Interleaving String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.InterleavingString.Test.TestCases());
        }

        private static void ShuffleanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shuffle an Array");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void BackspaceStringCompareFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Backspace String Compare");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BackspaceStringCompare.Test.TestCases());
        }

        private static void DeleteOperationforTwoStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Delete Operation for Two Strings");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DeleteOperationforTwoStrings.Test.TestCases());
        }

        private static void BitwiseANDofNumbersRangeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bitwise AND of Numbers Range");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BitwiseANDofNumbersRange.Test.TestCases());
        }

        private static void MinimumSpeedtoArriveonTimeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Speed to Arrive on Time");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumSpeedtoArriveonTime.Test.TestCases());
        }

        private static void FrogJumpFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Frog Jump");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FrogJump.Test.TestCases());
        }

        private static void FairDistributionofCookiesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fair Distribution of Cookies");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MinimumNumberofDaystoMakemBouquetsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Days to Make m Bouquets");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumNumberofDaystoMakemBouquets.Test.TestCases());
        }

        private static void TextJustificationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Text Justification");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.TextJustification.Test.TestCases());
        }

        private static void ReorganizeStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reorganize String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ReorganizeString.Test.TestCases());
        }

        private static void RepeatedDNASequencesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Repeated DNA Sequences");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RepeatedDNASequences.Test.TestCases());
        }

        private static void ExcelSheetColumnTitleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Excel Sheet Column Title");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ExcelSheetColumnTitle.Test.TestCases());
        }

        private static void SortItemsbyGroupsRespectingDependenciesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort Items by Groups Respecting Dependencies");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SortItemsbyGroupsRespectingDependencies.Test.TestCases());
        }

        private static void NumberofLongestIncreasingSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Longest Increasing Subsequence");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofLongestIncreasingSubsequence.Test.TestCases());
        }

        private static void MaximumNumberofRemovableCharactersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Removable Characters");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumNumberofRemovableCharacters.Test.TestCases());
        }

        private static void BalancedBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Balanced Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void FindKPairswithSmallestSumsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Removable Characters");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindKPairswithSmallestSums.Test.TestCases());
        }

        private static void MinimumAbsoluteSumDifferenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Absolute Sum Difference");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumAbsoluteSumDifference.Test.TestCases());
        }

        private static void DetermineWhetherMatrixCanBeObtainedByRotationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Determine Whether Matrix Can Be Obtained By Rotation");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DetermineWhetherMatrixCanBeObtainedByRotation.Test.TestCases());
        }

        private static void FindtheSmallestDivisorGivenaThresholdFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Smallest Divisor Given a Threshold");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindtheSmallestDivisorGivenaThreshold.Test.TestCases());
        }

        private static void SplitLinkedListinPartsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Split Linked List in Parts");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void AddStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Strings");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.AddStrings.Test.TestCases());
        }

        private static void WordSearchFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word Search");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.WordSearch.Test.TestCases());
        }

        private static void Searcha2DMatrixIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search a 2D Matrix II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.Searcha2DMatrixII.Test.TestCases());
        }

        private static void InsertDeleteGetRandomFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Insert Delete GetRandom O(1)");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ReverseLinkedListIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Linked List II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MyCalendarIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("My Calendar I");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void DesignAuthenticationManagerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Authentication Manager");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SortListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MinimumDepthofBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Depth of Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void AllNodesDistanceKinBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("All Nodes Distance K in Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MaximizetheConfusionofanExamFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximize the Confusion of an Exam");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximizetheConfusionofanExam.Test.TestCases());
        }

        private static void LongestPalindromebyConcatenatingTwoLetterWordsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Palindrome by Concatenating Two Letter Words");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LongestPalindromebyConcatenatingTwoLetterWords.Test.TestCases());
        }

        private static void PutMarblesinBagsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Put Marbles in Bags");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PutMarblesinBags.Test.TestCases());
        }

        private static void TaskSchedulerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Task Scheduler");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.TaskScheduler.Test.TestCases());
        }

        private static void PathWithMinimumEffortFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Path With Minimum Effort");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PathWithMinimumEffort.Test.TestCases());
        }

        private static void WhereWilltheBallFallFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Where Will the Ball Fall");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.WhereWilltheBallFall.Test.TestCases());
        }

        private static void ClimbingStairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Climbing Stairs");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ClimbingStairs.Test.TestClimbingStairs());
        }

        private static void AddTwoIntegersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Two Integers");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.AddTwoIntegers.Test.TestCases());
        }

        private static void NumberOfStepsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Steps to Reduce a Number to Zero");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofStepstoReduceaNumbertoZero.Test.TestNumberofStepstoReduceaNumbertoZero());
        }

        private static void LongestCommonSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Common Subsequence");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LongestCommonSubsequence.Solution.TestLongestCommonSubsequence());
        }

        private static void CountDigitOneFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Digit One");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofDigitOne.Test.TestNumberofDigitOne());
        }

        private static void ContainsDuplicateFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Contains Duplicate");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ContainsDuplicate.Test.TestContainsDuplicate());            
        }

        private static void MaxIceCreamFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Ice Cream");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumIceCreamBars.Test.TestCases());
        }

        private static void LongestPathWithDifferentAdjacentCharactersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Path With Different Adjacent Characters");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LongestPathWithDifferentAdjacentCharacters.Test.TestCases());
        }

        private static void LexicographicallySmallestEquivalentStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Lexicographically Smallest Equivalent String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LexicographicallySmallestEquivalentString.Test.TestLexicographicallySmallestEquivalentString());
        }

        private static void FlipStringtoMonotoneIncreasingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Flip String to Monotone Increasing");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FlipStringtoMonotoneIncreasing.Test.TestFlipStringtoMonotoneIncreasing());
        }

        private static void SearchA2DMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search a Matrix");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.Searcha2DMatrix.Test.TestSearcha2DMatrix());
        }

        private static void SetMatrixZeroesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Set Matrix Zeroes");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SetMatrixZeroes.Test.TestSetMatrixZeroes());
        }

        private static void InsertIntervalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Insert Interval");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.InsertInterval.Test.TestInsertInterval());
        }

        private static void BestTimetoBuyandSellStockFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Time to Buy and Sell Stock");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BestTimetoBuyandSellStock.Test.TestBestTimetoBuyandSellStock());
        }

        private static void FirstUniqueCharacterinaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("First Unique Character in a String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FirstUniqueCharacterinaString.Test.TestFirstUniqueCharacterinaString());
        }

        private static void RansomNoteFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ransom Note");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RansomNote.Test.TestRansomNote());
        }

        private static void LinkedListRandomNodeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Linked List Random Node");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SoupServingsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Soup Servings");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void BinaryTreePreorderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Preorder Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }
        
        private static void CombinationSumIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Combination Sum III");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ValidSudokuFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Sudoku");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void LinkedListCycleIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Linked List Cycle II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void LinkedListCycleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Linked List Cycle");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void CloneGraphFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Clone Graph");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void PalindromePartitioningFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Palindrome Partitioning");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SumRoottoLeafNumbersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum Root to Leaf Numbers");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SingleNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Single Number");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SingleNumber.Test.TestSingleNumber());
        }

        private static void BinaryTreeMaximumPathSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Maximum Path Sum");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void DesignaFoodRatingSystemFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design a Food Rating System");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MaxSubarraySumCircularFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Subarray Sum Circular");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumSumCircularSubarray.Test.TestMaximumSumCircularSubarray());
        }

        private static void FindMissingandRepeatedValuesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Missing and Repeated Values");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindMissingandRepeatedValues.Test.TestCases());
        }

        private static void FindCommonElementsBetweenTwoArraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Common Elements Between Two Arrays");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindCommonElementsBetweenTwoArrays.Test.TestCases());
        }

        private static void GasStationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Gas Station");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.GasStation.Test.TestGasStation());
        }

        private static void TransposeMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Transpose Matrix");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.TransposeMatrix.Test.TestCases());
        }

        private static void SubarraySumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subarray Sum");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SubarraySumEqualsK.Test.TestSubarraySumEqualsK());
        }

        private static void CountTestedDevicesAfterTestOperationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Tested Devices After Test Operations");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountTestedDevicesAfterTestOperations.Test.TestCases());
        }

        private static void FindJudgeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Judge");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindtheTownJudge.Test.TestFindtheTownJudge());
        }

        private static void RottingOrangesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Rotting Oranges");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RottingOranges.Test.TestRottingOranges());
        }

        private static void AddtoArrayFormofIntegerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add to Array Form of Integer");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.AddtoArrayFormofInteger.Test.TestAddtoArrayFormofInteger());
        }

        private static void RestoreIpAddressesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Restore Ip Addresses");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RestoreIPAddresses.Test.TestRestoreIPAddresses());
        }

        private static void CheckifPointIsReachableFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check if Point Is Reachable");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CheckifPointIsReachable.Test.TestCases());
        }

        private static void SnakesAndLaddersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Snakes And Ladders");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SnakesandLadders.Test.TestSnakesandLadders());
        }

        private static void FindClosestNodetoGivenTwoNodesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Closest Node to Given Two Nodes");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindClosestNodetoGivenTwoNodes.Test.TestCases());
        }

        private static void ShuffleTheArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shuffle The Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ShuffletheArray.Test.TestCases());
        }

        private static void CountOddNumbersInAnIntervalRangeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Odd Numbers in an Interval Range");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountOddNumbersinanIntervalRange.Test.TestCases());
        }

        private static void NumberofNodesintheSubTreeWiththeSameLabelFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Nodes in the Sub-Tree With the Same Label");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void FruitIntoBasketsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fruit Into Baskets");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FruitIntoBaskets.Test.TestFruitIntoBaskets());
        }

        private static void OnlineStockSpanFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Online Stock Span");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void JumpGameIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Jump Game II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.JumpGameII.Test.TestJumpGameII());
        }

        private static void NamingaCompanyFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Naming a Company");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NamingaCompany.Test.TestCases());
        }

        private static void AsFarfromLandasPossibleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("As Far from Land as Possible");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.AsFarfromLandasPossible.Solution.TestAsFarfromLandasPossible());
        }

        private static void MaximumLevelSumofaBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Level Sum of a Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ShortestPathWithAlternatingColorsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Path With Alternating Colors");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ShortestPathwithAlternatingColors.Test.TestShortestPathwithAlternatingColors());
        }

        private static void MinimumFuelCosttoReporttotheCapitalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Fuel Cost to Report to the Capital");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumFuelCosttoReporttotheCapital.Test.TestCases());
        }

        private static void AddBinaryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Binary");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.AddBinary.Test.TestAddBinary());
        }

        private static void DefanginganIPAddressFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Defanging an IP Address");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DefanginganIPAddress.Test.TestDefanginganIPAddress());
        }

        private static void FindLuckyIntegerinanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Lucky Integer in an Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindLuckyIntegerinanArray.Test.TestFindLuckyIntegerinanArray());
        }

        private static void SearchInsertPositionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search Insert Position");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SearchInsertPosition.Test.TestSearchInsertPosition());
        }

        private static void MinimumAbsoluteDifferenceinBSTFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Absolute Difference in BST");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SingleElementinaSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Single Element in a Sorted Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SingleElementinaSortedArray.Test.TestSingleElementinaSortedArray());
        }

        private static void CapacityToShipPackagesWithinDDaysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Capacity To Ship Packages Within D Days");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CapacityToShipPackagesWithinDDays.Test.TestCapacityToShipPackagesWithinDDays());
        }

        private static void IPOFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("IPO");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.IPO.Test.TestIPO());
        }

        private static void EditDistanceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Edit Distance");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.EditDistance.Test.TestEditDistance());
        }

        private static void SortanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort an Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SortanArray.Test.TestSortanArray());
        }

        private static void StringCompressionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("String Compression");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.StringCompression.Test.TestStringCompression());
        }

        private static void FindtheIndexoftheFirstOccurrenceinaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Index of the First Occurrence in a String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindtheIndexoftheFirstOccurrenceinaString.Test.TestFindtheIndexoftheFirstOccurrenceinaString());
        }

        private static void CountSubarraysWithFixedBoundsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Subarrays With Fixed Bounds");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountSubarraysWithFixedBounds.Test.TestCases());
        }

        private static void JumpGameIVFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Jump Game IV");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.JumpGameIV.Test.TestJumpGameIV());
        }

        private static void KthMissingPositiveNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Kth Missing Positive Number");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.KthMissingPositiveNumber.Test.TestCases());
        }

        private static void MinimumTimetoCompleteTripsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Time to Complete Trips");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumTimetoCompleteTrips.Test.TestCases());
        }

        private static void KokoEatingBananasFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Koko Eating Bananas");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.KokoEatingBananas.Test.TestKokoEatingBananas());
        }

        private static void LeafSimilarTreesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Leaf-Similar Trees");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void DiameterofBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Diameter of Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ConvertSortedArraytoBinarySearchTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert Sorted Array to Binary Search Tree");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ConvertSortedArraytoBinarySearchTree.Test.TestConvertSortedArraytoBinarySearchTree());
        }

        private static void MaximumRunningTimeofNComputersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Running Time of N Computers");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumRunningTimeofNComputers.Test.TestCases());
        }

        private static void ImplementTriePrefixTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Implement Trie Prefix Tree");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ImplementTriePrefixTree.Test.TestImplementTriePrefixTree());
        }

        private static void MinimumASCIIDeleteSumforTwoStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum ASCII Delete Sum for Two Strings");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumASCIIDeleteSumforTwoStrings.Test.TestCases());
        }

        private static void CombinationSumIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Combination Sum II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CombinationSumII.Test.TestCases());
        }

        private static void CanPlaceFlowersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Can Place Flowers");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CanPlaceFlowers.Test.TestCanPlaceFlowers());
        }

        private static void NumberofZeroFilledSubarraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Zero-Filled Subarrays");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofZeroFilledSubarrays.Test.TestCases());
        }

        private static void MinimumScoreofaPathBetweenTwoCitiesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Score of a Path Between Two Cities");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumScoreofaPathBetweenTwoCities.Test.TestCases());
        }

        private static void NumberofOperationstoMakeNetworkConnectedFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Operations to Make Network Connected");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofOperationstoMakeNetworkConnected.Test.TestNumberofOperationstoMakeNetworkConnected());
        }

        private static void ReorderRoutestoMakeAllPathsLeadtotheCityZeroFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reorder Routes to Make All Paths Lead to the City Zero");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ReorderRoutestoMakeAllPathsLeadtotheCityZero.Test.TestCases());
        }

        private static void CountUnreachablePairsofNodesinanUndirectedGraphFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Unreachable Pairs of Nodes in an Undirected Graph");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountUnreachablePairsofNodesinanUndirectedGraph.Test.TestCases());
        }

        private static void LongestCycleinaGraphFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Cycle in a Graph");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LongestCycleinaGraph.Test.TestCases());
        }

        private static void MinimumPathSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Path Sum");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumPathSum.Test.TestMinimumPathSum());
        }

        private static void PrimeSubtractionOperationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Prime Subtraction Operation");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PrimeSubtractionOperation.Test.TestCase());
        }

        private static void MinimumCostForTicketsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Cost For Tickets");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumCostForTickets.Test.TestMinimumCostForTickets());
        }

        private static void KItemsWiththeMaximumSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("K Items With the Maximum Sums");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.KItemsWiththeMaximumSum.Test.TestCases());
        }

        private static void NumberofWaysofCuttingaPizzaFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Ways of Cutting a Pizza");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofWaysofCuttingaPizza.Test.TestCases());
        }

        private static void ReducingDishesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reducing Dishes");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ReducingDishes.Test.TestReducingDishes());
        }

        private static void DesignUndergroundSystemFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Underground System");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void NaryTreePreorderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("N-ary Tree Preorder Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void PermutationinStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Permutation in String");
            ResultTester.CheckSolution (ProblemOrigin.LeetCode, LeetCode.PermutationinString.Test.TestValidTriangleNumber());
        }

        private static void ReshapetheMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reshape the Matrix");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ReshapetheMatrix.Test.TestReshapetheMatrix());
        }

        private static void ScrambleStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Scramble String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ScrambleString.Test.TestScrambleString());
        }

        private static void BinarySearchFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Search");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BinarySearch.Test.TestBinarySearch());
        }

        private static void InsertintoaBinarySearchTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Insert into a Binary Search Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SearchintoaBinarySearchTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search in a Binary Search Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void KthLargestElementinaStreamFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Kth Largest Element in a Stream");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SuccessfulPairsofSpellsandPotionsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Successful Pairs of Spells and Potions");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SuccessfulPairsofSpellsandPotions.Test.TestCases());
        }

        private static void BoatstoSavePeopleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Boats to Save People");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BoatstoSavePeople.Test.TestBoatstoSavePeople());
        }

        private static void OptimalPartitionofStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Optimal Partition of String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.OptimalPartitionofString.Test.TestCases());
        }

        private static void MinimizeMaximumofArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimize Maximum of Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimizeMaximumofArray.Test.TestCases());
        }

        private static void NumberofGoodPathsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Good Paths");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void NumberofEnclavesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Enclaves");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofEnclaves.Test.TestNumberofEnclaves());
        }

        private static void RemoveStarsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Removing Stars From a String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RemovingStarsFromaString.Test.TestCases());
        }

        private static void NumberofClosedIslandsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Closed Islands");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofClosedIslands.Test.TestNumberofClosedIslands());
        }

        private static void CheckIfNandItsDoubleExistFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check If N and Its Double Exist");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CheckIfNandItsDoubleExist.Test.TestCheckIfNandItsDoubleExist());
        }

        private static void MinimumReverseOperationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Reverse Operations");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumReverseOperations.Test.TestCase());
        }

        private static void LargestColorValueinaDirectedGraphFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Color Value in a Directed Graph");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LargestColorValueinaDirectedGraph.Test.TestCases());
        }

        private static void SimplifyPathFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Simplify Path");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SimplifyPath.Test.TestSimplifyPath());
        }

        private static void ValidateStackSequencesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Validate Stack Sequences");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ValidateStackSequences.Test.TestValidateStackSequences());
        }

        private static void DeleteColumnstoMakeSortedFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("DeleteColumnstoMakeSorted");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DeleteColumnstoMakeSorted.Test.TestDeleteColumnstoMakeSorted());
        }

        private static void LongestPalindromicSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Palindromic Subsequence");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LongestPalindromicSubsequence.Test.TestLongestPalindromicSubsequence());
        }

        private static void MaximumValueofKCoinsFromPilesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Value of K Coins From Piles");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumValueofKCoinsFromPiles.Test.TestCases());
        }

        private static void ConcatenationofArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Concatenation of Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ConcatenationofArray.Test.TestCases());
        }

        private static void NumberofWaystoFormaTargetStringGivenaDictionaryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Ways to Form a Target String Given a Dictionary");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofWaystoFormaTargetStringGivenaDictionary.Test.TestCases());
        }

        private static void BestTeamWithNoConflictsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Team With No Conflicts");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BestTeamWithNoConflicts.Test.TestCases());
        }

        private static void KidsWiththeGreatestNumberofCandiesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Kids With the Greatest Number of Candies");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.KidsWiththeGreatestNumberofCandies.Test.TestKidsWiththeGreatestNumberofCandies());
        }

        private static void MergeStringsAlternatelyFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Merge Strings Alternately");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MergeStringsAlternately.Test.TestCases());
        }

        private static void RomantoIntegerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Roman to Integer");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RomantoInteger.Test.TestRomantoInteger());
        }

        private static void ProfitableSchemesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Profitable Schemes");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ProfitableSchemes.Test.TestProfitableSchemes());
        }

        private static void MinimumInsertionStepstoMakeaStringPalindromeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Insertion Steps to Make a String Palindrome");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumInsertionStepstoMakeaStringPalindrome.Test.TestDecryptStringfromAlphabettoIntegerMapping());
        }

        private static void BestPokerHandFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Poker Hand");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BestPokerHand.Test.TestCases());
        }

        private static void SmallestNumberinInfiniteSetFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Smallest Number in Infinite Set");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void DeleteNodeinaBSTFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Delete Node in a BST");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void AddTwoNumbersIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Two Numbers II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void RestoreTheArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Restore The Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RestoreTheArray.Test.TestRestoreTheArray());
        }

        private static void LastStoneWeightFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Last Stone Weight");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LastStoneWeight.Test.TestLastStoneWeight());
        }

        private static void AddDigitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Digits");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.AddDigits.Test.TestAddDigits());
        }

        private static void ValidAnagramFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Anagram");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ValidAnagram.Test.TestValidAnagram());
        }

        private static void BulbSwitcherFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bulb Switcher");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BulbSwitcher.Test.TestBulbSwitcher());
        }

        private static void FindtheDifferenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Difference");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindtheDifference.Test.TestFindtheDifference());
        }

        private static void RepeatedSubstringPatternFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Repeated Substring Pattern");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RepeatedSubstringPattern.Test.TestRepeatedSubstringPattern());
        }

        private static void MinimumNumberofArrowstoBurstBalloonsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Arrows to Burst Balloons");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumNumberofArrowstoBurstBalloons.Test.TestMinimumNumberofArrowstoBurstBalloons());
        }

        private static void MoveZeroesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Move Zeroes");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void FirstBadVersionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("First Bad Version");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void PlusOneFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Plus One");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PlusOne.Test.TestPlusOne());
        }

        private static void AverageSalaryExcludingtheMinimumandMaximumSalaryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Average Salary Excluding the Minimum and Maximum Salary");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.AverageSalaryExcludingtheMinimumandMaximumSalary.Test.TestCases());
        }

        private static void NonoverlappingIntervalsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Non-overlapping Intervals");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NonoverlappingIntervals.Test.TestNonoverlappingIntervals());
        }

        private static void SignoftheProductofanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sign of the Product of an Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SignoftheProductofanArray.Test.TestCases());
        }

        private static void CanMakeArithmeticProgressionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Can Make Arithmetic Progression From Sequence");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CanMakeArithmeticProgressionFromSequence.Test.TestCases());
        }

        private static void MonotonicArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Monotonic Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MonotonicArray.Test.TestMonotonicArray());
        }

        private static void LengthofLastWordFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Length of Last Word");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LengthofLastWord.Test.TestLengthofLastWord());
        }

        private static void ToLowerCaseFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("To Lower Case");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ToLowerCase.Test.TestToLowerCase());
        }

        private static void FindSmallestLetterGreaterThanTargetFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Smallest Letter Greater Than Target");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindSmallestLetterGreaterThanTarget.Test.TestFindSmallestLetterGreaterThanTarget());
        }

        private static void CountNegativeNumbersinaSortedMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Negative Numbers in a Sorted Matrix");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountNegativeNumbersinaSortedMatrix.Test.TestCountNegativeNumbersinaSortedMatrix());
        }

        private static void ValidPerfectSquareFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Perfect Square");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ValidPerfectSquare.Test.TestValidPerfectSquare());
        }

        private static void ArrangingCoinsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Arranging Coins");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ArrangingCoins.Test.TestArrangingCoins());
        }

        private static void BaseballGameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Baseball Game");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BaseballGame.Test.TestBaseballGame());
        }

        private static void FindAllAnagramsinaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find All Anagrams in a String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindAllAnagramsinaString.Test.TestFindAllAnagramsinaString());
        }

        private static void PathSumIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Path Sum III");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void RobotReturntoOriginFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Robot Return to Origin");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RobotReturntoOrigin.Test.TestRobotReturntoOrigin());
        }

        private static void TwoSumIVInputisaBSTFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Two Sum IV - Input is a BST");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void TwoSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Two Sum");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void FindDuplicateSubtreesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Duplicate Subtrees");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void FindWinneronaTicTacToeGameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Winner on a Tic Tac Toe Game");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindWinneronaTicTacToeGame.Test.TestFindWinneronaTicTacToeGame());
        }

        private static void RobotBoundedInCircleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Robot Bounded In Circle");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RobotBoundedInCircle.Test.TestRobotBoundedInCircle());
        }

        private static void UncrossedLinesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Uncrossed Lines");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.UncrossedLines.Test.TestUncrossedLines());
        }

        private static void MatrixDiagonalSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Matrix Diagonal Sum");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MatrixDiagonalSum.Test.TestCases());
        }

        private static void LemonadeChangeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Lemonade Change");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LemonadeChange.Test.TestLemonadeChange());
        }

        private static void LargestPerimeterTriangleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Perimeter Triangle");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LargestPerimeterTriangle.Test.TestLargestPerimeterTriangle());
        }

        private static void SubarraySumsDivisiblebyKFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subarray Sums Divisible by K");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SubarraySumsDivisiblebyK.Test.TestSubarraySumsDivisiblebyK());
        }

        private static void CheckCompletenessofaBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check Completeness of a Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void CheckIfItIsaStraightLineFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check If It Is a Straight Line");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CheckIfItIsaStraightLine.Test.TestCheckIfItIsaStraightLine());
        }

        private static void MultiplyStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Multiply Strings");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MultiplyStrings.Test.TestMultiplyStrings());
        }

        private static void PowxnFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Pow(x, n)");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.Powxn.Test.TestPowxn());
        }

        private static void ReverseVowelsofaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Vowels of a String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ReverseVowelsofaString.Test.TestReverseVowelsofaString());
        }

        private static void ReverseStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse String");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ReverseWordsinaStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Words in a String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ReverseWordsinaString.Test.TestReverseWordsinaString());
        }

        private static void EvaluateReversePolishNotationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Evaluate Reverse Polish Notation");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.EvaluateReversePolishNotation.Test.TestEvaluateReversePolishNotation());
        }

        private static void ProductofArrayExceptSelfFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Product of Array Except Self");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ProductofArrayExceptSelf.Test.TestProductofArrayExceptSelf());
        }

        private static void Dota2SenateFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Dota2 Senate");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.Dota2Senate.Test.TestDota2Senate());
        }

        private static void MinimumFlipstoMakeaORbEqualtocFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Flips to Make a OR b Equal to c");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumFlipstoMakeaORbEqualtoc.Test.TestMinimumFlipstoMakeaORbEqualtoc());
        }

        private static void CountingBitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Counting Bits");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountingBits.Test.TestCountingBits());
        }

        private static void BestTimetoBuyandSellStockwithTransactionFeeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Time to Buy and Sell Stock with Transaction Fee");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BestTimetoBuyandSellStockwithTransactionFee.Test.TestBestTimetoBuyandSellStockwithTransactionFee());
        }

        private static void IncreasingTripletSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Increasing Triplet Subsequence");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.IncreasingTripletSubsequence.Test.TestIncreasingTripletSubsequence());
        }

        private static void IsSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Is Subsequence");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.IsSubsequence.Test.TestIsSubsequence());
        }

        private static void MaximumNumberofVowelsinaSubstringofGivenLengthFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Vowels in a Substring of Given Length");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumNumberofVowelsinaSubstringofGivenLength.Test.TestCases());
        }

        private static void DominoandTrominoTilingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Domino and Tromino Tiling");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DominoandTrominoTiling.Test.TestDominoandTrominoTiling());
        }

        private static void MinCostClimbingStairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Min Cost Climbing Stairs");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinCostClimbingStairs.Test.TestMinCostClimbingStairs());    
        }

        private static void ContainerWithMostWaterFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Container With Most Water");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ContainerWithMostWater.Test.TestContainerWithMostWater());    
        }

        private static void MaxNumberofKSumPairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Number of K-Sum Pairs");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaxNumberofKSumPairs.Test.TestCases());
        }

        private static void MaximumAverageSubarrayIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Average Subarray I");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumAverageSubarrayI.Test.TestMaximumAverageSubarrayI());
        }

        private static void UniquePathsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Unique Paths");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.UniquePaths.Test.TestUniquePaths());
        }

        private static void MaxConsecutiveOnesIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Consecutive Ones III");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaxConsecutiveOnesIII.Test.TestMaxConsecutiveOnesIII());
        }

        private static void LongestSubarrayof1sAfterDeletingOneElementFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Subarray of 1's After Deleting One Element");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LongestSubarrayof1sAfterDeletingOneElement.Test.TestCases());
        }

        private static void FindtheHighestAltitudeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Highest Altitude");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindtheHighestAltitude.Test.TestCases());
        }

        private static void FindPivotIndexFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Pivot Index");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindPivotIndex.Test.TestFindPivotIndex());
        }

        private static void NumberofProvincesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Provinces");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofProvinces.Test.TestNumberofProvinces());
        }

        private static void NumberofSubsequencesThatSatisfytheGivenSumConditionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Subsequences That Satisfy the Given Sum Condition");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofSubsequencesThatSatisfytheGivenSumCondition.Test.TestCases());
        }

        private static void FindtheLongestValidObstacleCourseatEachPositionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Subsequences That Satisfy the Given Sum Condition");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindtheLongestValidObstacleCourseatEachPosition.Test.TestCases());
        }

        private static void AsteroidCollisionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Asteroid Collision");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.AsteroidCollision.Test.TestAsteroidCollision());
        }

        private static void FindPeakElementFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Peak Element");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindPeakElement.Test.TestFindPeakElement());
        }

        private static void MaximizeScoreAfterNOperationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximize Score After N Operations");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximizeScoreAfterNOperations.Test.TestCases());
        }

        private static void MaximumAscendingSubarraySumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Ascending Subarray Sum");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumAscendingSubarraySum.Test.TestCases());
        }

        private static void WateringPlantsIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Watering Plants II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.WateringPlantsII.Test.TestCases());
        }

        private static void MaximumProductDifferenceBetweenTwoPairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Product Difference Between Two Pairs");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumProductDifferenceBetweenTwoPairs.Test.TestCases());
        }

        private static void ImageSmootherFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Image Smoother");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ImageSmoother.Test.TestCases());
        }

        private static void MaximumNumberofCoinsYouCanGetFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Coins You Can Get");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumNumberofCoinsYouCanGet.Test.TestCases());
        }

        private static void BuyTwoChocolatesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Buy Two Chocolates");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BuyTwoChocolates.Test.TestCases());
        }

        private static void DiagonalTraverseIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Diagonal Traverse II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DiagonalTraverseII.Test.TestCases());
        }

        private static void CountNicePairsinanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Nice Pairs in an Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountNicePairsinanArray.Test.TestCases());
        }

        private static void CarPoolingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Car Pooling");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CarPooling.Test.TestCarPooling());
        }

        private static void GreatestCommonDivisorofStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Greatest Common Divisor of Strings");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.GreatestCommonDivisorofStrings.Test.TestGreatestCommonDivisorofStrings());
        }

        private static void ShortestPathinBinaryMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Path in Binary Matrix");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ShortestPathinBinaryMatrix.Test.TestShortestPathinBinaryMatrix());
        }

        private static void CountWaysToBuildGoodStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Ways To Build Good Strings");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountWaysToBuildGoodStrings.Test.TestCases());
        }

        private static void TotalCosttoHireKWorkersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Total Cost to Hire K Workers");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.TotalCosttoHireKWorkers.Test.TestCases());
        }

        private static void MaximumSubsequenceScoreFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Subsequence Score");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumSubsequenceScore.Test.TestCases());
        }

        private static void KthLargestElementinanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Kth Largest Element in an Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.KthLargestElementinanArray.Test.TestKthLargestElementinanArray());
        }

        private static void EqualRowandColumnPairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Equal Row and Column Pairs");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.EqualRowandColumnPairs.Test.TestCases());
        }

        private static void UniqueNumberofOccurrencesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Unique Number of Occurrences");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.UniqueNumberofOccurrences.Test.TestUniqueNumberofOccurrences());
        }

        private static void DetermineifTwoStringsAreCloseFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Determine if Two Strings Are Close");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DetermineifTwoStringsAreClose.Test.TestCases());
        }

        private static void IsGraphBipartiteFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Is Graph Bipartite");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.IsGraphBipartite.Test.TestIsGraphBipartite());
        }

        private static void LetterCasePermutationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Letter Case Permutation");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LetterCasePermutation.Test.TestLetterCasePermutation());
        }
        
        private static void MinimumDistanceBetweenBSTNodesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Distance Between BST Nodes");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MaxPointsonaLineFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Points on a Line");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void BinaryTreePostorderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Level Order Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void LowestCommonAncestorofaBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Lowest Common Ancestor of a Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void OddEvenLinkedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Odd Even Linked List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void LowestCommonAncestorofaBinarySearchTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Lowest Common Ancestor of a Binary Search Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }
        
        private static void HouseRobberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("House Robber");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void HouseRobberIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("House Robber III");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void HouseRobberIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("House Robber II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void DesignAddandSearchWordsDataStructureFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Add and Search Words Data Structure");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void NextPermutationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Next Permutation");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NextPermutation.Test.TestNextPermutation());
        }

        private static void ShortestBridgeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Bridge");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ShortestBridge.Test.TestShortestBridge());
        }

        private static void NumberofRecentCallsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Recent Calls");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void PeekingIteratorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Peeking Iterator");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void FindtheDuplicateNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Duplicate Number");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindtheDuplicateNumber.Test.TestFindtheDuplicateNumber());
        }

        private static void New21GameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("New 21 Game");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.New21Game.Test.TestNew21Game());
        }

        private static void FindMinimuminRotatedSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Minimum in Rotated Sorted Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindMinimuminRotatedSortedArray.Test.TestFindMinimuminRotatedSortedArray());
        }

        private static void StoneGameIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Stone Game II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.StoneGameII.Solution.TestStoneGameII());
        }

        private static void PermutationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Permutations");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.Permutations.Test.TestPermutations());
        }

        private static void PermutationsIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Permutations II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ReverseLinkedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Linked List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void IsomorphicStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Isomorphic Strings");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void RemoveLinkedListElementsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Linked List Elements");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void CourseScheduleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Course Schedule");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CourseSchedule.Test.TestCourseSchedule());
        }

        private static void StoneGameIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Stone Game III");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.StoneGameIII.Test.TestStoneGameIII());
        }

        private static void MinimumCosttoCutaStickFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Cost to Cut a Stick");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumCosttoCutaStick.Test.TestCases());
        }

        private static void MajorityElementFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Majority Element");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MajorityElement.Test.TestMajorityElement());
        }

        private static void GoalParserInterpretationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Goal Parser Interpretation");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.GoalParserInterpretation.Test.TestCases());
        }

        private static void FloodFillFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Flood Fill");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FloodFill.Test.TestFloodFill());
        }

        private static void HappyNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Happy Number");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.HappyNumber.Test.TestHappyNumber());
        }

        private static void DecryptStringfromAlphabettoIntegerMappingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Decrypt String from Alphabet to Integer Mapping");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DecryptStringfromAlphabettoIntegerMapping.Test.TestDecryptStringfromAlphabettoIntegerMapping());
        }

        private static void ConvertBinaryNumberinaLinkedListtoIntegerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert Binary Number in a Linked List to Integer");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void TheKWeakestRowsinaMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("The K Weakest Rows in a Matrix");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.TheKWeakestRowsinaMatrix.Test.TestTheKWeakestRowsinaMatrix());
        }

        private static void CheckifOneStringSwapCanMakeStringsEqualFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check if One String Swap Can Make Strings Equal");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CheckifOneStringSwapCanMakeStringsEqual.Test.TestCases());
        }

        private static void ThreeSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("3Sum");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ThreeSum.Test.TestThreeSum());
        }

        private static void PeakIndexinaMountainArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Peak Index in a Mountain Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PeakIndexinaMountainArray.Test.TestPeakIndexinaMountainArray());
        }

        private static void KeysandRoomsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Keys and Rooms");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SimilarStringGroupsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Similar String Groups");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SubtracttheProductandSumofDigitsofanIntegerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subtract the Product and Sum of Digits of an Integer");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SubtracttheProductandSumofDigitsofanInteger.Test.TestSubtracttheProductandSumofDigitsofanInteger());
        }

        private static void DeleteandEarnFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Delete and Earn");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DeleteandEarn.Test.TestDeleteandEarn());
        }

        private static void DailyTemperaturesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Daily Temperatures");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DailyTemperatures.Test.TestDailyTemperatures());
        }

        private static void SpecialArrayWithXElementsGreaterThanorEqualXFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Special Array With X Elements Greater Than or Equal X");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SpecialArrayWithXElementsGreaterThanorEqualX.Test.TestCases());
        }

        private static void TwoSumIIInputArrayIsSortedFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Two Sum II - Input Array Is Sorted");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.TwoSumIIInputArrayIsSorted.Test.TestTwoSumIIInputArrayIsSorted());
        }

        private static void FindFirstandLastPositionofElementinSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find First and Last Position of Element in Sorted Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindFirstandLastPositionofElementinSortedArray.Test.TestFindFirstandLastPositionofElementinSortedArray());
        }

        private static void SqrtxFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sqrt(x)");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.Sqrtx.Test.TestSqrtx());
        }

        private static void FindtheDistanceValueBetweenTwoArraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Distance Value Between Two Arrays");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindtheDistanceValueBetweenTwoArrays.Test.TestFindtheDistanceValueBetweenTwoArrays());
        }

        private static void MergeIntervalsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Merge Intervals");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MergeIntervals.Test.TestInsertInterval());
        }

        private static void SortColorsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort Colors");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void TimeNeededtoInformAllEmployeesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Time Needed to Inform All Employees");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.TimeNeededtoInformAllEmployees.Test.TestTimeNeededtoInformAllEmployees());
        }

        private static void LongestZigZagPathinaBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest ZigZag Path in a Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void DesignCircularQueueFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Circular Queue");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MergeTwoBinaryTreesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Merge Two Binary Trees");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SumofSquareNumbersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Square Numbers");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SumofSquareNumbers.Test.TestSumofSquareNumbers());
        }

        private static void DecodeWaysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Decode Ways");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DecodeWays.Test.TestDecodeWays());
        }

        private static void ArithmeticSlicesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Arithmetic Slices");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ArithmeticSlices.Test.TestArithmeticSlices());
        }

        private static void SumofAllOddLengthSubarraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of All Odd Length Subarrays");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SumofAllOddLengthSubarrays.Test.TestCases());
        }

        private static void RemoveMaxNumberofEdgestoKeepGraphFullyTraversableFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Max Number of Edges to Keep Graph Fully Traversable");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void NextGreaterElementIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Next Greater Element I");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NextGreaterElementI.Test.TestNextGreaterElementI());
        }

        private static void SquaresofaSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Squares of a Sorted Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SquaresofaSortedArray.Test.TestSquaresofaSortedArray());
        }

        private static void RotateArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Rotate Array");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void FibonacciNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fibonacci Number");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FibonacciNumber.Test.TestFibonacciNumber());
        }

        private static void FindNearestPointThatHastheSameXorYCoordinateFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Nearest Point That Has the Same X or Y Coordinate");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindNearestPointThatHastheSameXorYCoordinate.Test.TestCases());
        }

        private static void Numberof1BitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of 1 Bits");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.Numberof1Bits.Test.TestNumberof1Bits());
        }

        private static void UglyNumberIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ugly Number II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.UglyNumberII.Test.TestUglyNumberII());
        }

        private static void UniqueBinarySearchTreesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Unique Binary Search Trees");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.UniqueBinarySearchTrees.Test.TestUniqueBinarySearchTrees());
        }

        private static void SortIntegersbyTheNumberof1BitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort Integers by The Number of 1 Bits");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SortIntegersbyTheNumberof1Bits.Test.TestSortIntegersbyTheNumberof1Bits());
        }

        private static void SearchinRotatedSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search in Rotated Sorted Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SearchinRotatedSortedArray.Test.TestSearchinRotatedSortedArray());
        }

        private static void MaximumDistanceBetweenaPairofValuesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Distance Between a Pair of Values");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumDistanceBetweenaPairofValues.Test.TestCases());
        }

        private static void TrappingRainWaterFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Trapping Rain Water");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.TrappingRainWater.Test.TestTrappingRainWater());
        }

        private static void WordBreakFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word Break");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.WordBreak.Test.TestWordBreak());
        }

        private static void ZeroOneMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("01 Matrix");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ZeroOneMatrix.Test.TestZeroOneMatrix());
        }

        private static void MaxAreaofIslandFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Area of Island");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaxAreaofIsland.Test.TestMaxAreaofIsland());
        }

        private static void PowerofTwoFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Power of Two");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PowerofTwo.Test.TestPowerofTwo());
        }

        private static void ReverseWordsinaStringIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Power of Two");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ReverseWordsinaStringIII.Test.TestReverseWordsinaStringIII());
        }

        private static void TriangleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Tringle");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.Triangle.Test.TestTriangle());
        }

        private static void PascalsTriangleIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Pascals Triangle II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PascalsTriangleII.Test.TestPascalsTriangleII());
        }

        private static void LongestSubstringWithoutRepeatingCharactersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Substring Without Repeating Characters");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LongestSubstringWithoutRepeatingCharacters.Test.TestLongestSubstringWithoutRepeatingCharacters());
        }

        private static void ReverseBitsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Bits");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ReverseBits.Test.TestReverseBits());
        }

        private static void UniquePathsIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Unique Paths II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.UniquePathsII.Test.TestUniquePathsII());
        }

        private static void MaximalSquareFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximal Square");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximalSquare.Test.TestMaximalSquare());
        }

        private static void JumpGameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Jump Game");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.JumpGame.Test.TestJumpGame());
        }

        private static void PathSumIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Path Sum II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }
        
        private static void BinaryTreeInorderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Inorder Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MaximumValueataGivenIndexinaBoundedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Value at a Given Index in a Bounded Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumValueataGivenIndexinaBoundedArray.Test.TestCases());
        }

        private static void BinarySearchTreeIteratorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Search Tree Iterator");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void PathSumFuncFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Path Sum Func");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ConvertSortedListtoBinarySearchTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("ConvertSorted List to Binary Search Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void KthSmallestElementinaBSTFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Kth Smallest Element in a BST");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ConstructBinaryTreefromPreorderandInorderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Construct Binary Tree from Preorder and Inorder Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MaximumDepthofBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Depth of Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void BinaryTreeZigzagLevelOrderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Zigzag Level Order Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void BinaryTreeLevelOrderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Level Order Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SymmetricTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Symmetric Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SameTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Same Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ValidateBinarySearchTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Validate Binary Search Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MaximumValueofaStringinanArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Value of a String in an Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumValueofaStringinanArray.Test.TestCases());
        }

        private static void SnapshotArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Value of a String in an Array");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void LongestIncreasingSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Increasing Subsequence");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LongestIncreasingSubsequence.Test.TestLongestIncreasingSubsequence());
        }

        private static void WiggleSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Wiggle Subsequence");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.WiggleSubsequence.Test.TestWiggleSubsequence());
        }

        private static void LongestPalindromicSubstringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Palindromic Substring");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LongestPalindromicSubstring.Test.TestLongestPalindromicSubstring());
        }

        private static void LongestPalindromeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Palindrome");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LongestPalindrome.Test.TestLongestPalindrome());
        }

        private static void RangeSumQuery2DImmutableFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Range Sum Query 2D - Immutable");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void BestTimetoBuyandSellStockwithCooldownFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Time to Buy and Sell Stock with Cooldown");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BestTimetoBuyandSellStockwithCooldown.Test.TestBestTimetoBuyandSellStockwithCooldown());
        }

        private static void GuessNumberHigherorLowerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Guess Number Higher or Lower");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SumofLeftLeavesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Left Leaves");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void EvaluateDivisionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Evaluate Division");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.EvaluateDivision.Test.TestEvaluateDivision());
        }

        private static void DecodeStringFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Decode String");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DecodeString.Test.TestDecodeString());
        }

        private static void BestTimetoBuyandSellStockIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Time to Buy and Sell Stock II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BestTimetoBuyandSellStockII.Test.TestBestTimetoBuyandSellStockII());
        }

        private static void BestSightseeingPairFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Sightseeing Pair");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BestSightseeingPair.Test.TestBestSightseeingPair());
        }

        private static void WordPatternFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Word Pattern");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.WordPattern.Test.TestWordPattern());
        }

        private static void SerializeandDeserializeBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Serialize and Deserialize Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MatrixBlockSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Matrix Block Sum");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MatrixBlockSum.Test.TestMatrixBlockSum());
        }

        private static void SummaryRangesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Summary Ranges");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SummaryRanges.Test.TestSummaryRanges());
        }

        private static void MaximumProductSubarrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Product Subarray");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumProductSubarray.Test.TestMaximumProductSubarray());
        }

        private static void MaximumLengthofSubarrayWithPositiveProductFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Length of Subarray With Positive Product");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumLengthofSubarrayWithPositiveProduct.Test.TestCases());
        }

        private static void MinimumNumberofVerticestoReachAllNodesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Vertices to Reach All Nodes");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void FindtheWinneroftheCircularGameFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Winner of the Circular Game");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindtheWinneroftheCircularGame.Test.TestCases());
        }

        private static void RemoveDuplicatesfromSortedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Duplicates from Sorted List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void RemoveDuplicatesfromSortedListIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Duplicates from Sorted List II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void DesignLinkedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Linked List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void DesignHashMapFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Hash Map");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void DesignHashSetFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Hash Set");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ReverseNodesinkGroupFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Nodes in k-Group");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SwapNodesinPairsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Swap Nodes in Pairs");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MergekSortedListsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Merge k Sorted Lists");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MinStackFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Min Stack");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void GenerateParenthesesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Generate Parentheses");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MergeTwoSortedListsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Merge Two Sorted Lists");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void CoinChangeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Coin Change");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CoinChange.Test.TestCoinChange());
        }

        private static void ValidParenthesesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Parentheses");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ValidParentheses.Test.TestValidParentheses());
        }

        private static void CoinChangeIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Coin Change");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CoinChangeII.Test.TestCoinChangeII());
        }

        private static void MinimumRoundstoCompleteAllTasksFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Rounds to Complete All Tasks");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumRoundstoCompleteAllTasks.Test.TestCases());
        }

        private static void FindtheDifferenceofTwoArraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Difference of Two Arrays");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindtheDifferenceofTwoArrays.Test.TestCases());
        }

        private static void SolvingQuestionsWithBrainpowerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Solving Questions With Brainpower");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MaximumTwinSumofaLinkedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Twin Sum of a Linked List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void DeletetheMiddleNodeofaLinkedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Delete the Middle Node of a Linked List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void FindifPathExistsinGraphFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find if Path Exists in Graph");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void NearestExitfromEntranceinMazeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Nearest Exit from Entrance in Maze");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NearestExitfromEntranceinMaze.Test.TestCases());
        }

        private static void RangeSumQueryImmutableFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Range Sum Query - Immutable");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MakeArrayStrictlyIncreasingFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Make Array Strictly Increasing");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MakeArrayStrictlyIncreasing.Test.TestMakeArrayStrictlyIncreasing());
        }

        private static void SearchinRotatedSortedArrayIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search in Rotated Sorted Array II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SearchinRotatedSortedArrayII.Test.TestSearchinRotatedSortedArrayII());
        }

        private static void FindRightIntervalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Right Interval");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindRightInterval.Test.TestFindRightInterval());
        }

        private static void MostProfitAssigningWorkFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Most Profit Assigning Work");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MostProfitAssigningWork.Test.TestMostProfitAssigningWork());
        }

        private static void WaystoSplitArrayIntoThreeSubarraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ways to Split Array Into Three Subarrays");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.WaystoSplitArrayIntoThreeSubarrays.Test.TestCases());
        }

        private static void NumberofIslandsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Islands");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofIslands.Test.TestHappyNumber());
        }

        private static void AllPathsFromSourcetoTargetFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("All Paths From Source to Target");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.AllPathsFromSourcetoTarget.Test.TestAllPathsFromSourcetoTarget());
        }

        private static void NumberofIncreasingPathsinaGridFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Increasing Paths in a Grid");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofIncreasingPathsinaGrid.Test.TestCases());
        }

        private static void PacificAtlanticWaterFlowFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Pacific Atlantic Water Flow");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PacificAtlanticWaterFlow.Test.TestPacificAtlanticWaterFlow());
        }

        private static void BinaryTreeRightSideViewFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Binary Tree Right Side View");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }
        
        private static void CountSubIslandsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Diagonal Difference");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountSubIslands.Test.TestCases());
        }

        private static void ShortestSubarraytobeRemovedtoMakeArraySortedFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Subarray to be Removed to Make Array Sorted");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ShortestSubarraytobeRemovedtoMakeArraySorted.Test.TestCases());
        }

        private static void RangeSumofSortedSubarraySumsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Range Sum of Sorted Subarray Sums");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RangeSumofSortedSubarraySums.Test.TestCases());
        }

        private static void MinimumSizeSubarraySumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Size Subarray Sum");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumSizeSubarraySum.Test.TestMinimumSizeSubarraySum());
        }

        private static void ValidTriangleNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Triangle Number");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ValidTriangleNumber.Test.TestValidTriangleNumber());
        }

        private static void CountCompleteTreeNodesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Complete Tree Nodes");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void FrequencyoftheMostFrequentElementFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Frequency of the Most Frequent Element");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FrequencyoftheMostFrequentElement.Test.TestCases());
        }

        private static void HIndexIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("H-Index II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.HIndexII.Test.TestHIndexII());
        }

        private static void KRadiusSubarrayAveragesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("K Radius Subarray Averages");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.KRadiusSubarrayAverages.Test.TestCases());
        }

        private static void FindMinimuminRotatedSortedArrayIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Minimum in Rotated Sorted Array II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindMinimuminRotatedSortedArrayII.Test.TestFindMinimuminRotatedSortedArrayII());
        }

        private static void NumberofWaystoReorderArraytoGetSameBSTFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Ways to Reorder Array to Get Same BST");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofWaystoReorderArraytoGetSameBST.Test.TestCases());
        }

        private static void LongestArithmeticSubsequenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Ways to Reorder Array to Get Same BST");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LongestArithmeticSubsequence.Test.TestLongestArithmeticSubsequence());
        }

        private static void TallestBillboardFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Tallest Billboard");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.TallestBillboard.Test.TestTallestBillboard());
        }

        private static void VerifyinganAlienDictionaryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Verifying an Alien Dictionary");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.VerifyinganAlienDictionary.Test.TestVerifyinganAlienDictionary());
        }

        private static void MinimumLimitofBallsinaBagFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Limit of Balls in a Bag");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumLimitofBallsinaBag.Test.TestCases());
        }

        private static void MagneticForceBetweenTwoBallsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Magnetic Force Between Two Balls");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MagneticForceBetweenTwoBalls.Test.TestCases());
        }

        private static void FindaPeakElementIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find a Peak Element II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindaPeakElementII.Test.TestCases());
        }

        private static void FindtheStudentthatWillReplacetheChalkFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Student that Will Replace the Chalk");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindtheStudentthatWillReplacetheChalk.Test.TestCases());
        }

        private static void FindKClosestElementsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find K Closest Elements");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindKClosestElements.Test.TestFindKClosestElements());
        }

        private static void DetectCapitalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Detect Capital");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.DetectCapital.Test.TestDetectCapital());
        }

        private static void RandomPickwithWeightFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Random Pick with Weight");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SellDiminishingValuedColoredBallsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sell Diminishing-Valued Colored Balls");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SellDiminishingValuedColoredBalls.Test.TestCases());
        }

        private static void AvoidFloodinTheCityFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Avoid Flood in The City");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.AvoidFloodinTheCity.Test.TestCases());
        }

        private static void RunningSumof1dArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Running Sum of 1d Array");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RunningSumof1dArray.Test.TestCases());
        }

        private static void OpentheLockFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Open the Lock");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.OpentheLock.Test.TestOpentheLock());
        }

        private static void LongestRepeatingCharacterReplacementFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Repeating Character Replacement");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LongestRepeatingCharacterReplacement.Test.TestLongestRepeatingCharacterReplacement());
        }

        private static void SwappingNodesinaLinkedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Swapping Nodes in a Linked List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void CheckingExistenceofEdgeLengthLimitedPathsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Checking Existence of Edge Length Limited Paths");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CheckingExistenceofEdgeLengthLimitedPaths.Test.TestCases());
        }

        private static void MinimizeDeviationinArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimize Deviation in Array");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void RichestCustomerWealthFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Richest Customer Wealth");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.RichestCustomerWealth.Test.TestCases());
        }

        private static void IntegerBreakFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Integer Break");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.IntegerBreak.Test.TestIntegerBreak());
        }

        private static void JumpGameIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Jump Game III");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.JumpGameIII.Test.TestJumpGameIII());
        }

        private static void SubstringWithLargestVarianceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Substring With Largest Variance");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SubstringWithLargestVariance.Test.TestCases());
        }

        private static void MaximalNetworkRankFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximal Network Rank");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximalNetworkRank.Test.TestCases());
        }

        private static void CountAllPossibleRoutesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count All Possible Routes");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CountAllPossibleRoutes.Test.TestCases());
        }

        private static void MinimumJumpstoReachHomeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Jumps to Reach Home");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumJumpstoReachHome.Test.TestCases());
        }

        private static void NextGreaterElementIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Next Greater Element III");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NextGreaterElementIII.Test.TestNextGreaterElementIII());
        }

        private static void SmallestRangeIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Smallest Range II");            
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SmallestRangeII.Test.TestSmallestRangeII());
        }

        private static void LongestArithmeticSubsequenceofGivenDifferenceFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Arithmetic Subsequence of Given Difference");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LongestArithmeticSubsequenceofGivenDifference.Test.TestLongestArithmeticSubsequenceofGivenDifference());
        }

        private static void MinimumCosttoMakeArrayEqualFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Cost to Make Array Equal");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumCosttoMakeArrayEqual.Test.TestCases());
        }

        private static void SubsetsIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subsets II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MaximumNumberofEventsThatCanBeAttendedIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Events That Can Be Attended II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumNumberofEventsThatCanBeAttendedII.Test.TestCases());
        }

        private static void DesignParkingSystemFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Parking System");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }
        
        private static void MergeSortedArrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Merge Sorted Array");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void CombinationsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Combinations");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SmallestSufficientTeamFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Smallest Sufficient Team");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SmallestSufficientTeam.Test.TestSmallestSufficientTeam());
        }

        private static void ThreeSumClosestFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("3Sum Closest");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ThreeSumClosest.Test.TestThreeSumClosest());
        }

        private static void PartitionEqualSubsetSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Partition Equal Subset Sum");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PartitionEqualSubsetSum.Test.TestPartitionEqualSubsetSum());
        }

        private static void BusRoutesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bus Routes");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BusRoutes.Test.TestBusRoutes());
        }

        private static void CourseScheduleIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Course Schedule II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CourseScheduleII.Test.TestCourseScheduleII());
        }

        private static void BasicCalculatorIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Basic Calculator II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BasicCalculatorII.Test.TestBasicCalculatorII());
        }

        private static void CombinationSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Combination Sum");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CombinationSum.Test.TestCases());
        }

        private static void RotateListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Rotate List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SpiralMatrixFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Spiral Matrix");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SpiralMatrix.Test.TestSpiralMatrix());
        }

        private static void SpiralMatrixIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Spiral Matrix II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SpiralMatrixII.Test.TestSpiralMatrixII());
        }

        private static void CopyListwithRandomPointerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Copy List with Random Pointer");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ArithmeticSubarraysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Arithmetic Subarrays");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ArithmeticSubarrays.Test.TestCases());
        }

        private static void SeatReservationManagerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Seat Reservation Manager");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void LastDayWhereYouCanStillCrossFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Last Day Where You Can Still Cross");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.LastDayWhereYouCanStillCross.Test.TestLastDayWhereYouCanStillCroww());
        }

        private static void TopKFrequentWordsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Top K Frequent Words");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.TopKFrequentWords.Test.TestTopKFrequentWords());
        }

        private static void NextGreaterElementIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Next Greater Element II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NextGreaterElementII.Test.TestNextGreaterElementII());
        }

        private static void OnlineElectionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Online Election");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ConstructQuadTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Construct Quad Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MinimumGeneticMutationFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Genetic Mutation");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumGeneticMutation.Test.TestMinimumGeneticMutation());
        }

        private static void IntervalListIntersectionsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Interval List Intersections");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.IntervalListIntersections.Test.TestIntervalListIntersections());
        }

        private static void LinkedListinBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Linked List in Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void KnightProbabilityinChessboardFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Knight Probability in Chessboard");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.KnightProbabilityinChessboard.Test.TestKnightProbabilityinChessboard());
        }

        private static void PossibleBipartitionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Possible Bipartition");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void AllPossibleFullBinaryTreesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("All Possible Full Binary Trees");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void PopulatingNextRightPointersinEachNodeIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Populating Next Right Pointers in Each Node I");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void PopulatingNextRightPointersinEachNodeIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Populating Next Right Pointers in Each Node II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ShortestPathtoGetAllKeysFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Path to Get All Keys");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ShortestPathtoGetAllKeys.Test.TestShortestPathtoGetAllKeys());
        }

        private static void WaterandJugProblemFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Water and Jug Problem");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.WaterandJugProblem.Test.TestWaterandJugProblem());
        }

        private static void MaximumNumberofAchievableTransferRequestsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Achievable Transfer Requests");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumNumberofAchievableTransferRequests.Test.TestMaximumNumberofAchievableTransferRequests());
        }

        private static void DesignBrowserHistoryFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Design Browser History");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void CountGoodNodesinBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Good Nodes in Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void DataStreamasDisjointIntervalsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Data Stream as Disjoint Intervals");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MinimumTimetoCollectAllApplesinaTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Time to Collect All Apples in a Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void IntersectionofTwoArraysIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Intersection of Two Arrays II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.IntersectionofTwoArraysII.Test.TestIntersectionofTwoArraysII());
        }

        private static void StrangePrinterFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Strange Printer");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.StrangePrinter.Test.TestStrangePrinter());
        }

        private static void TopKFrequentElementsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Top K Frequent Elements");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.TopKFrequentElements.Test.TestTopKFrequentElements());
        }

        private static void MaximumWidthofBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Width of Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SearchSuggestionsSystemFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search Suggestions System");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SearchSuggestionsSystem.Test.TestSearchSuggestionsSystem());
        }

        private static void FirstMissingPositiveFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("First Missing Positive");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FirstMissingPositive.Test.TestFirstMissingPositive());
        }

        private static void CheapestFlightsWithinKStopsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Cheapest Flights Within K Stops");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.CheapestFlightsWithinKStops.Test.TestCheapestFlightsWithinKStops());
        }

        private static void PredicttheWinnerFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Predict the Winner");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PredicttheWinner.Test.TestPredicttheWinner());
        }

        private static void ConcatenatedWordsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Concatenated Words");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ConcatenatedWords.Test.TestConcatenatedWords());
        }
        
        private static void PathwithMaximumProbabilityFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Pathwith Maximum Probability");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PathwithMaximumProbability.Test.TestPathwithMaximumProbability());
        }

        private static void SubarrayProductLessThanKFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subarray Product Less Than K");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SubarrayProductLessThanK.Test.TestSubarrayProductLessThanK());
        }
        
        private static void MaximumSideLengthofaSquarewithSumLessthanorEqualtoThresholdFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Side Length of a Square with Sum Less than or Equal to Threshold");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumSideLengthofaSquarewithSumLessthanorEqualtoThreshold.Test.TestMaximumSideLengthofaSquarewithSumLessthanorEqualtoThreshold());
        }
        
        private static void NthTribonacciNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Nth Tribonacci Number");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NthTribonacciNumber.Test.TestNthTribonacciNumber());
        }

        private static void NondecreasingSubsequencesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Non-decreasing Subsequences");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NondecreasingSubsequences.Test.TestNondecreasingSubsequences());
        }

        private static void LFUCacheFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("LFU Cache");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MiddleoftheLinkedListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Middle of the Linked List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SumofDistancesinTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Distances in Tree");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SumofDistancesinTree.Test.TestSumofDistancesinTree());
        }

        private static void AlternatingDigitSumFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Alternating Digit Sum");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.AlternatingDigitSum.Test.TestCase());
        }

        private static void ImplementQueueusingStacksFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Implement Queue using Stacks");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void InvertBinaryTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Invert Binary Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void PascalsTriangleFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Pascals Triangle");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ConstructBinaryTreefromInorderandPostorderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Construct Binary Tree from In order and Post order Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void MaximumSubarrayFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Subarray");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MaximumSubarray.Test.TestMaximumSubarray());
        }

        private static void RemoveNthNodeFromEndofListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Nth Node From End of List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void LetterCombinationsofaPhoneNumberFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Letter Combinations of a Phone Number");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ZigzagConversionFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Zigzag Conversion");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.ZigzagConversion.Test.TestZigzagConversion());
        }

        private static void AddTwoNumbersFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Two Numbers");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void BuddyStringsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Buddy Strings");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BuddyStrings.Test.TestCase());
        }

        private static void SurroundedRegionsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Surrounded Regions");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SurroundedRegions.Test.TestCases());
        }

        private static void BullsandCowsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bulls and Cows");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.BullsandCows.Test.TestCases());
        }

        private static void MinimumRemovetoMakeValidParenthesesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Remove to Make Valid Parentheses");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.MinimumRemovetoMakeValidParentheses.Test.TestCases());
        }

        private static void FindEventualSafeStatesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Eventual Safe States");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindEventualSafeStates.Test.TestCases());
        }

        private static void NaryTreeLevelOrderTraversalFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("N-ary Tree Level Order Traversal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void FlattenNestedListIteratorFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Flatten Nested List Iterator");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SingleNumberIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Single Number II");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SingleNumberII.Test.TestCases());
        }

        private static void UniqueBinarySearchTreesIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Unique Binary Search Trees II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void NumberofMusicPlaylistsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Music Playlists");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.NumberofMusicPlaylists.Test.TestCases());
        }

        private static void FindLatestGroupofSizeMFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Latest Group of Size M");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.FindLatestGroupofSizeM.Test.TestCases());
        }

        private static void ReorderListFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reorder List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void ShortestPathVisitingAllNodesFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Path Visiting All Nodes");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SortCharactersByFrequencyFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort Characters By Frequency");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SortCharactersByFrequency.Test.TestCases());
        }

        private static void UglyNumberIIIFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ugly Number III");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.UglyNumberIII.Test.TestCases());
        }

        private static void SumofMutatedArrayClosesttoTargetFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Mutated Array Closest to Target");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.SumofMutatedArrayClosesttoTarget.Test.TestCases());
        }

        private static void IntersectionofTwoLinkedListsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Intersection of Two Linked Lists");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void SubsetsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subsets");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.Subsets.Test.TestCases());
        }

        private static void GroupAnagramsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Group Anagrams");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.GroupAnagrams.Test.TestCases());
        }

        private static void PartitionLabelsFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Partition Labels");
            ResultTester.CheckSolution(ProblemOrigin.LeetCode, LeetCode.PartitionLabels.Test.TestCases());
        }

        private static void SubtreeofAnotherTreeFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subtree of Another Tree");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }

        private static void RotateImageFunc()
        {
            StyleHelper.Space();
            StyleHelper.Title("Rotate Image");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode);
        }
    }
}