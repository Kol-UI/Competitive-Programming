Percentile Calculation

Case 1 : sequence = [15, 20, 35, 40, 50]
percentile = 50
Expected Output: 35.0

Case 2 : sequence = [20, 15, 40, 35, 50]
percentile = 40
Expected Output: 29.0

```cs
public class PercentileSolver
{
    // Approach 1: Safe approach (Copies and sorts)
    public double SolveSafe(IEnumerable<double> sequence, double percentile)
    {
        if (sequence == null || !sequence.Any())
            throw new ArgumentException("Sequence cannot be empty");

        if (percentile < 0 || percentile > 100)
            throw new ArgumentOutOfRangeException(nameof(percentile), "Percentile must be between 0 and 100");

        var sorted = sequence.OrderBy(x => x).ToArray();
        return CalculatePercentileInternal(sorted, percentile);
    }

    // Approach 2: In-place approach
    public double SolveInPlace(double[] array, double percentile)
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array cannot be empty");

        if (percentile < 0 || percentile > 100)
            throw new ArgumentOutOfRangeException(nameof(percentile), "Percentile must be between 0 and 100");

        Array.Sort(array);
        return CalculatePercentileInternal(array, percentile);
    }

    private double CalculatePercentileInternal(double[] sorted, double percentile)
    {
        int n = sorted.Length;
        if (n == 1) return sorted[0];

        // Calculate virtual index
        double index = (percentile / 100.0) * (n - 1);
        int lowerIdx = (int)Math.Floor(index);
        int upperIdx = (int)Math.Ceiling(index);

        if (lowerIdx == upperIdx)
            return sorted[lowerIdx];

        // Linear interpolation
        double weight = index - lowerIdx;
        return sorted[lowerIdx] + weight * (sorted[upperIdx] - sorted[lowerIdx]);
    }
}```