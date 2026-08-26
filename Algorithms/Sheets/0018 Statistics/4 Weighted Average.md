Weighted Average

```cs

/*
var values = new double[] { 85, 90, 75 };

var weights = new double[] { 0.2, 0.5, 0.3 }; // Total weight = 1.0

// (85*0.2 + 90*0.5 + 75*0.3) / 1.0 = 17 + 45 + 22.5 = 84.5

double expected = 84.5;
*/

public class WeightedAverageSolver
{
    // Approach 1: Classic iterative loop
    public double SolveIterative(IList<double> values, IList<double> weights)
    {
        if (values == null || weights == null || values.Count != weights.Count)
            throw new ArgumentException("Values and weights must have the same non-zero length");

        if (values.Count == 0)
            throw new ArgumentException("Datasets cannot be empty");

        double totalSum = 0;
        double weightSum = 0;

        for (int i = 0; i < values.Count; i++)
        {
            totalSum += values[i] * weights[i];
            weightSum += weights[i];
        }

        // Prevent division by zero
        if (weightSum == 0)
            throw new DivideByZeroException("Sum of weights cannot be zero");

        return totalSum / weightSum;
    }

    // Approach 2: LINQ Zip approach
    public double SolveLinq(IEnumerable<double> values, IEnumerable<double> weights)
    {
        if (values == null || weights == null || values.Count() != weights.Count())
            throw new ArgumentException("Values and weights must have the same non-zero length");

        if (!values.Any())
            throw new ArgumentException("Datasets cannot be empty");

        double weightSum = weights.Sum();
        if (weightSum == 0)
            throw new DivideByZeroException("Sum of weights cannot be zero");

        // Multiply each element by its weight and sum them up
        double totalSum = values.Zip(weights, (v, w) => v * w).Sum();

        return totalSum / weightSum;
    }
}```