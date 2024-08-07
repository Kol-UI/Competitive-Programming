using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DataStreamasDisjointIntervals
{
    public class Solution
    {
        // Given a data stream input of non-negative integers a1, a2, ..., an, summarize the numbers seen so far as a list of disjoint intervals.

        // Implement the SummaryRanges class:

        // SummaryRanges() Initializes the object with an empty stream.
        // void addNum(int value) Adds the integer value to the stream.
        // int[][] getIntervals() Returns a summary of the integers in the stream currently as a list of disjoint intervals [starti, endi]. The answer should be sorted by starti.
        

        // Example 1:

        // Input
        // ["SummaryRanges", "addNum", "getIntervals", "addNum", "getIntervals", "addNum", "getIntervals", "addNum", "getIntervals", "addNum", "getIntervals"]
        // [[], [1], [], [3], [], [7], [], [2], [], [6], []]
        // Output
        // [null, null, [[1, 1]], null, [[1, 1], [3, 3]], null, [[1, 1], [3, 3], [7, 7]], null, [[1, 3], [7, 7]], null, [[1, 3], [6, 7]]]

        // Explanation
        // SummaryRanges summaryRanges = new SummaryRanges();
        // summaryRanges.addNum(1);      // arr = [1]
        // summaryRanges.getIntervals(); // return [[1, 1]]
        // summaryRanges.addNum(3);      // arr = [1, 3]
        // summaryRanges.getIntervals(); // return [[1, 1], [3, 3]]
        // summaryRanges.addNum(7);      // arr = [1, 3, 7]
        // summaryRanges.getIntervals(); // return [[1, 1], [3, 3], [7, 7]]
        // summaryRanges.addNum(2);      // arr = [1, 2, 3, 7]
        // summaryRanges.getIntervals(); // return [[1, 3], [7, 7]]
        // summaryRanges.addNum(6);      // arr = [1, 2, 3, 6, 7]
        // summaryRanges.getIntervals(); // return [[1, 3], [6, 7]]
    

    
        // private SortedSet<int> values;
        // public SummaryRanges()
        // {
        //     values = new SortedSet<int>();
            
        // }

        // public void AddNum(int value) => values.Add(value);

        // public int[][] GetIntervals()
        // {
        //     if (values.Count == 0)
        //     {
        //         return new int[0][];
        //     }
        //     List<int[]> intervals = new List<int[]>();
        //     int left = -1;
        //     int right = -1;
        //     foreach (int value in values)
        //     {
        //         if (left < 0)
        //         {
        //             left = right = value;
        //         }
        //         else if (value == right + 1)
        //         {
        //             right = value;
        //         }
        //         else
        //         {
        //             intervals.Add(new int[] {left, right});
        //             left = right = value;
        //         }
        //     }
        //     intervals.Add(new int[] {left, right});
        //     return intervals.ToArray();
        // }

    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Data Stream as Disjoint Intervals");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}