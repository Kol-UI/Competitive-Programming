Calculate median of a list.

```cs
public class Median
{
    // Approach 1: Sort then pick middle
    public double ComputeSorted(IEnumerable<double> numbers)
    {
        var sorted = numbers.OrderBy(x => x).ToList();
        if (sorted.Count == 0) throw new ArgumentException("Collection cannot be empty.");

        int mid = sorted.Count / 2;
        return sorted.Count % 2 == 1
            ? sorted[mid]
            : (sorted[mid - 1] + sorted[mid]) / 2.0;
    }

    // Approach 2: QuickSelect
    public double ComputeQuickSelect(IEnumerable<double> numbers)
    {
        var list = numbers.ToList();
        if (list.Count == 0) throw new ArgumentException("Collection cannot be empty.");

        int n = list.Count;
        if (n % 2 == 1)
            return QuickSelect(list, 0, n - 1, n / 2);

        // Even: average of the two middle elements
        return (QuickSelect(list, 0, n - 1, n / 2 - 1) +
                QuickSelect(list, 0, n - 1, n / 2)) / 2.0;
    }

    // QuickSelect helpers

    private double QuickSelect(List<double> list, int left, int right, int k)
    {
        if (left == right) return list[left];

        int pivot = Partition(list, left, right);
        if (k == pivot) return list[pivot];
        if (k < pivot) return QuickSelect(list, left, pivot - 1, k);
        return QuickSelect(list, pivot + 1, right, k);
    }

    private int Partition(List<double> list, int left, int right)
    {
        double pivot = list[right];
        int i = left;
        for (int j = left; j < right; j++)
        {
            if (list[j] <= pivot)
                (list[i], list[j]) = (list[j], list[i++]);
        }
        (list[i], list[right]) = (list[right], list[i]);
        return i;
    }
}```