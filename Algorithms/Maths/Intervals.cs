namespace CompetitiveProgramming.Algorithms;

public class Intervals
{
	private static bool IsInInterval(int n, int a, int b) => n >= a && n <= b;
	private static bool IsStrictlyInInterval(int n, int a, int b) => n > a && n < b;
	private static bool IsOutOfInterval(int n, int a, int b) => n < a || n > b;
	private static bool IsStrictlyOutOfInterval(int n, int a, int b) => n <= a || n >= b;
	private static bool IsOnIntervalBoundary(int n, int a, int b) => n == a || n == b;
	private static bool IsBelowInterval(int n, int a, int b) => n < a;
	private static bool IsAboveInterval(int n, int a, int b) => n > b;

	// Check if interval is contained in another
	private static bool IsIntervalContained(int a, int b, int x, int y) => a >= x && b <= y;
	private static bool IsIntervalContained(int[] inner, int[] outer)
	{
		return inner[0] >= outer[0] && inner[1] <= outer[1];
	}

	private static bool DoIntervalsOverlap(int a, int b, int x, int y) => Math.Max(a, x) <= Math.Min(b, y);

	// Check that they are not overlapping
	private static bool AreDisjoint(int[] interval1, int[] interval2)
	{
		return interval1[1] < interval2[0] || interval2[1] < interval1[0];
	}

	private static bool IsPointInInterval(int[] interval, int point)
	{
		return point >= interval[0] && point <= interval[1];
	}

	private static List<int[]> MergeOverlappingIntervals(List<int[]> intervals)
	{
		if (intervals == null || intervals.Count == 0) return new List<int[]>();

		intervals.Sort((a, b) => a[0].CompareTo(b[0]));

		List<int[]> merged = new List<int[]>();
		int[] currentInterval = intervals[0];
		merged.Add(currentInterval);

		foreach (var interval in intervals)
		{
			if (interval[0] <= currentInterval[1])
			{
				currentInterval[1] = Math.Max(currentInterval[1], interval[1]);
			}
			else
			{
				currentInterval = interval;
				merged.Add(currentInterval);
			}
		}

		return merged;
	}

	public static int[][] MergeOverlappingIntervals(int[][] intervals)
	{
		if (intervals == null || intervals.Length == 0) return new int[0][];

		Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

		List<int[]> merged = new List<int[]>();
		int[] currentInterval = intervals[0];
		merged.Add(currentInterval);

		foreach (var interval in intervals)
		{
			if (interval[0] <= currentInterval[1])
			{
				currentInterval[1] = Math.Max(currentInterval[1], interval[1]);
			}
			else
			{
				currentInterval = interval;
				merged.Add(currentInterval);
			}
		}

		return merged.ToArray();
	}

	private static bool IsIntervalSorted(int[][] intervals)
	{
		for (int i = 1; i < intervals.Length; i++)
		{
			if (intervals[i][0] < intervals[i - 1][0])
			{
				return false;
			}
		}
		return true;
	}

	private static int CalculateTotalLengthOfIntervals(int[][] intervals)
	{
		var merged = MergeOverlappingIntervals(intervals);
		int totalLength = 0;
		foreach (var interval in merged)
		{
			totalLength += interval[1] - interval[0];
		}
		return totalLength;
	}

	// Get Number of overlapping intervals
	private static int CountOverlappingIntervals(int[][] intervals, int[] targetInterval)
	{
		int count = 0;
		foreach (var interval in intervals)
		{
			if (Math.Max(interval[0], targetInterval[0]) <= Math.Min(interval[1], targetInterval[1]))
			{
				count++;
			}
		}
		return count;
	}

	private static bool AreAllIntervalsDistinct(int[][] intervals)
	{
		for (int i = 0; i < intervals.Length; i++)
		{
			for (int j = i + 1; j < intervals.Length; j++)
			{
				if (Math.Max(intervals[i][0], intervals[j][0]) <= Math.Min(intervals[i][1], intervals[j][1]))
				{
					return false;
				}
			}
		}
		return true;
	}

    private static void PrintIntervals(List<int[]> intervals)
    {
        foreach (var interval in intervals)
        {
            Console.WriteLine($"[{interval[0]}, {interval[1]}]");
        }
    }

    private static void PrintIntervals(int[][] intervals)
    {
        foreach (var interval in intervals)
        {
            Console.WriteLine($"[{interval[0]}, {interval[1]}]");
        }
    }

    private static int[] FindBiggestInterval(List<int[]> intervals)
    {
        return intervals.OrderByDescending(interval => interval[1] - interval[0]).First();
    }

    private static int[] FindBiggestInterval(int[][] intervals)
    {
        return intervals.OrderByDescending(interval => interval[1] - interval[0]).First();
    }

    private static bool AreAllEven(List<int[]> intervals)
    {
        return intervals.All(interval => interval[0] % 2 == 0 && interval[1] % 2 == 0);
    }

    private static bool AreAllEven(int[][] intervals)
    {
        return intervals.All(interval => interval[0] % 2 == 0 && interval[1] % 2 == 0);
    }

    private static bool AreAllOdds(List<int[]> intervals)
    {
        return intervals.All(interval => interval[0] % 2 != 0 && interval[1] % 2 != 0);
    }

    private static bool AreAllOdds(int[][] intervals)
    {
        return intervals.All(interval => interval[0] % 2 != 0 && interval[1] % 2 != 0);
    }

    private static bool AreAllPositive(List<int[]> intervals)
    {
        return intervals.All(interval => interval[0] > 0 && interval[1] > 0);
    }

    private static bool AreAllPositive(int[][] intervals)
    {
        return intervals.All(interval => interval[0] > 0 && interval[1] > 0);
    }

    private static bool AreAllNegative(List<int[]> intervals)
    {
        return intervals.All(interval => interval[0] < 0 && interval[1] < 0);
    }

    private static bool AreAllNegative(int[][] intervals)
    {
        return intervals.All(interval => interval[0] < 0 && interval[1] < 0);
    }
}