using CSharpSamples.Models;

namespace CSharpSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForEach.NormalLoop();
            ForEach.EnumerableLoop();
            ForEach.SillyLoop();

            // Person person = GetPerson();

            // if (person is null) 
            //     Console.WriteLine("Person is null.\n");
            // if (person == null) 
            //     Console.WriteLine("This won't run.\n");
        }

        private static Person GetPerson() => null;
    }
}
