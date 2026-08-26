namespace CompetitiveProgramming.Algorithms;
public class Mean
{
    // Approach 1: Iterative loop
    public double ComputeIterative(IEnumerable<double> numbers)
    {
        var list = numbers.ToList();
        if (list.Count == 0) throw new ArgumentException("Collection cannot be empty.");

        double sum = 0;
        foreach (var n in list)
            sum += n;

        return sum / list.Count;
    }

    // Approach 2: LINQ built-in Average
    public double ComputeLinq(IEnumerable<double> numbers)
    {
        var list = numbers.ToList();
        if (list.Count == 0) throw new ArgumentException("Collection cannot be empty.");

        return list.Average();
    }

    // Approach 3: Kahan compensated summation (better floating-point accuracy)
    public double ComputeKahan(IEnumerable<double> numbers)
    {
        var list = numbers.ToList();
        if (list.Count == 0) throw new ArgumentException("Collection cannot be empty.");

        double sum = 0, compensation = 0;
        foreach (var n in list)
        {
            double y = n - compensation;
            double t = sum + y;
            compensation = (t - sum) - y;
            sum = t;
        }

        return sum / list.Count;
    }
}