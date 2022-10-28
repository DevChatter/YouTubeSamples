namespace CSharpSamples;
public static class ForEach
{
    public static void NormalLoop()
    {
        foreach (var item in new[] { 1, 2, 3, 4, 5 })
        {
            Console.WriteLine($"Collection:{item}");
        }
    }

    public static void EnumerableLoop()
    {
        IEnumerable<int> enumerable = GetItems();
        foreach (var item in enumerable)
        {
            Console.WriteLine($"Enumerable:{item}");
        }
    }
    private static IEnumerable<int> GetItems()
    {
        for (int i = 1; i < 6; i++)
        {
            yield return i;
        }
    }

    public static void SillyLoop()
    {
        Silly silly = new();
        foreach (var item in silly)
        {
            Console.WriteLine($"Silly:{item}");
        }
    }
    private class Silly
    {
        private int value = 1;
        public IEnumerator<int> GetEnumerator()
        {
            while (value < 6)
            {
                yield return value++;
            }
        }
    }
}
