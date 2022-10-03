using CSharpSamples.Models;
using System;

namespace CSharpSamples
{
    internal class NullExamples
    {
        internal static string GetCity(Person person)
        {
            // Null Conditional Example
            return person?.City;
            // returns null
        }

        internal static string GetCityOrDefault(Person person)
        {
            // Null Coalescing Example
            return person.City ?? "Cleveland";
            // returns "Cleveland"
        }

        internal static string GetCityOrSetDefault(Person person)
        {
            // Null Coalescing Assignment Example
            return person.City ??= "Cleveland";
            // returns "Cleveland" after assigning to the `.City` property.
        }
    }
}
