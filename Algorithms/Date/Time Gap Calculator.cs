namespace CompetitiveProgramming.Algorithms;
// Represents a time interval with a start and end hour (ex: 9 to 11)
public record TimeInterval(int Start, int End);

public class TimeGapCalculator
{
    // Approach 1: Sorting and Iterating.
    public List<TimeInterval> FindGapsWithSorting(List<TimeInterval> Schedule, int DayStart, int DayEnd)
    {
        var Gaps = new List<TimeInterval>();
        if (Schedule == null || Schedule.Count == 0)
        {
            Gaps.Add(new TimeInterval(DayStart, DayEnd));
            return Gaps;
        }

        // Sort intervals by their start time
        var SortedSchedule = Schedule.OrderBy(I => I.Start).ToList();

        // Check gap before the first interval
        if (SortedSchedule[0].Start > DayStart)
        {
            Gaps.Add(new TimeInterval(DayStart, SortedSchedule[0].Start));
        }

        int CurrentEnd = SortedSchedule[0].End;

        // Find gaps between consecutive intervals
        for (int I = 1; I < SortedSchedule.Count; I++)
        {
            if (SortedSchedule[I].Start > CurrentEnd)
            {
                Gaps.Add(new TimeInterval(CurrentEnd, SortedSchedule[I].Start));
            }
            CurrentEnd = Math.Max(CurrentEnd, SortedSchedule[I].End);
        }

        // Check gap after the last interval
        if (CurrentEnd < DayEnd)
        {
            Gaps.Add(new TimeInterval(CurrentEnd, DayEnd));
        }

        return Gaps;
    }

    // Approach 2: Merging Overlaps First
    public List<TimeInterval> FindGapsWithMerge(List<TimeInterval> Schedule, int DayStart, int DayEnd)
    {
        if (Schedule == null || Schedule.Count == 0)
            return new List<TimeInterval> { new TimeInterval(DayStart, DayEnd) };

        var Sorted = Schedule.OrderBy(I => I.Start).ToList();
        var Merged = new List<TimeInterval>();
        
        // Step 1: Merge overlapping intervals
        var Current = Sorted[0];
        for (int I = 1; I < Sorted.Count; I++)
        {
            if (Sorted[I].Start <= Current.End)
            {
                Current = Current with { End = Math.Max(Current.End, Sorted[I].End) };
            }
            else
            {
                Merged.Add(Current);
                Current = Sorted[I];
            }
        }
        Merged.Add(Current);

        // Step 2: Calculate gaps from merged intervals
        var Gaps = new List<TimeInterval>();
        int LastEnd = DayStart;

        foreach (var Interval in Merged)
        {
            if (Interval.Start > LastEnd)
            {
                Gaps.Add(new TimeInterval(LastEnd, Interval.Start));
            }
            LastEnd = Math.Max(LastEnd, Interval.End);
        }

        if (LastEnd < DayEnd)
        {
            Gaps.Add(new TimeInterval(LastEnd, DayEnd));
        }

        return Gaps;
    }
}