namespace CSharpSamples;

// Aggregate:
// "to form or group into a class or cluster."
public static class AggregateExample
{
    public static void Sample()
    {
        int[] numbers = new[] { 4, 8, 15, 16, 23, 42 };

        int aggSum = numbers.Aggregate((accumulate, next) => accumulate + next);
        int sumSum = numbers.Sum();
        Console.WriteLine(aggSum);
        Console.WriteLine(sumSum);

        int aggMax = numbers.Aggregate(0, (max, next) => max > next ? max : next);
        int maxMax = numbers.Max();
        Console.WriteLine(aggMax);
        Console.WriteLine(maxMax);

        int product = numbers.Aggregate((accumulate, next) => accumulate * next);
        Console.WriteLine(product);

        string[] strings = new[] { "4", "8", "15", "16", "23", "42" };

        string csv = strings.Aggregate((accumulate, next) => $"{accumulate}, {next}");
        string joined = string.Join(", ", strings);
        Console.WriteLine(csv);
        Console.WriteLine(joined);
    }
}