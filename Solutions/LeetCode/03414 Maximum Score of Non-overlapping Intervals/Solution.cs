// Maximum Score of Non-overlapping Intervals
namespace CompetitiveProgramming.LeetCode.MaximumScoreofNonoverlappingIntervals;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
using System;
using System.Collections.Generic;

public class Solution {
    const int KMax = 4;
    
    struct IntervalData : IComparable<IntervalData> {
        public int Start, End;
        public long Weight;
        public int Idx;
        
        public int CompareTo(IntervalData other) {
            if (End != other.End) return End.CompareTo(other.End);
            return Start.CompareTo(other.Start);
        }
    }
    
    struct DpState : IComparable<DpState> {
        public long TotWeight;
        public int[] Idxs;
        public int Cnt;
        
        public int CompareTo(DpState other) {
            if (TotWeight != other.TotWeight) 
                return TotWeight.CompareTo(other.TotWeight);
            
            if (Cnt == 0 && other.Cnt == 0) return 0;
            if (Cnt == 0) return -1;
            if (other.Cnt == 0) return 1;
            
            for (int i = 0; i < Cnt && i < other.Cnt; i++) {
                if (Idxs[i] != other.Idxs[i])
                    return other.Idxs[i].CompareTo(Idxs[i]);
            }
            return other.Cnt.CompareTo(Cnt);
        }
        
        public DpState CopyAndAdd(long weight, int idx) {
            var next = new DpState {
                TotWeight = this.TotWeight + weight,
                Idxs = new int[KMax],
                Cnt = this.Cnt
            };
            if (this.Cnt > 0) Array.Copy(this.Idxs, next.Idxs, this.Cnt);
            next.Idxs[next.Cnt++] = idx;
            Array.Sort(next.Idxs, 0, next.Cnt);
            return next;
        }
    }

    public int[] MaximumWeight(IList<IList<int>> intervals) {
        int n = intervals.Count;
        var augIntervals = new IntervalData[n];
        
        for (int i = 0; i < n; i++) {
            augIntervals[i] = new IntervalData {
                Start = intervals[i][0],
                End = intervals[i][1],
                Weight = intervals[i][2],
                Idx = i
            };
        }
        
        Array.Sort(augIntervals);
        
        var dp = new DpState[n, KMax + 1];
        
        for (int i = 0; i < n; i++) {
            var curr = augIntervals[i];
            
            int left = 0, right = i - 1, prevIdx = -1;
            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (augIntervals[mid].End < curr.Start) {
                    prevIdx = mid;
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
            }
            
            for (int k = 1; k <= KMax; k++) {
                var skipState = i > 0 ? dp[i - 1, k] : new DpState();
                var takePrev = prevIdx >= 0 ? dp[prevIdx, k - 1] : new DpState();
                
                var takeState = takePrev.CopyAndAdd(curr.Weight, curr.Idx);
                
                dp[i, k] = skipState.CompareTo(takeState) >= 0 ? skipState : takeState;
            }
        }
        
        var bestState = dp[n - 1, KMax];
        var result = new int[bestState.Cnt];
        if (bestState.Cnt > 0) Array.Copy(bestState.Idxs, result, bestState.Cnt);
        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Score of Non-overlapping Intervals");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}