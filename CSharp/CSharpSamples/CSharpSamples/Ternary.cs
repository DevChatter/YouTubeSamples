namespace CSharpSamples
{
    internal class Ternary
    {
        internal static void SayHello()
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            name = string.IsNullOrWhiteSpace(name) ? name : "World!";
            Console.WriteLine($"Hello, {name}");
        }

        internal static string GetAgeGroupName(int age)
        {
            if (age >= 18)
            {
                return "Adult";
            }
            return "Child";
        }
    }
}