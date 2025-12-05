using System.Linq;

namespace StatsApp;

public class StatisticsCalculator
{
    public double Mean(double[] numbers)
    {
        return numbers.Average();
    }

    public double Median(double[] numbers)
    {
        var sorted = numbers.OrderBy(x => x).ToArray();
        int n = sorted.Length;

        if (n % 2 == 1)
            return sorted[n / 2];

        return (sorted[n / 2 - 1] + sorted[n / 2]) / 2.0;
    }

    public double? Mode(double[] numbers)
    {
        var groups = numbers.GroupBy(n => n)
                            .Select(g => new { Value = g.Key, Count = g.Count() })
                            .ToList();

        int max = groups.Max(g => g.Count);

        if (max == 1)
            return null;

        return groups.First(g => g.Count == max).Value;
    }

    public StatsResult CalculateAll(double[] numbers)
    {
        return new StatsResult
        {
            Mean = Mean(numbers),
            Median = Median(numbers),
            Mode = Mode(numbers),
            Min = numbers.Min(),
            Max = numbers.Max()
        };
    }
}
