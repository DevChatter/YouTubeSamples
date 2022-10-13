namespace CSharpSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AggregateExample.Sample();

            // Null Conditional
            Console.WriteLine(NullExamples.GetCity(null));
            // Null Coalescing
            Console.WriteLine(NullExamples.GetCityOrDefault(null));
            // Null Coalescing Assignment
            Console.WriteLine(NullExamples.GetCityOrSetDefault(null));

            // Ternary
            Console.WriteLine(Ternary.GetAgeGroupName(25));
            Ternary.SayHello();
        }
    }
}
