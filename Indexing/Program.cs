// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var letters = new [] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };

Console.WriteLine(letters[letters.Length -1]);
Console.WriteLine(letters[^1]);
Console.WriteLine(letters[^3]);
Console.WriteLine(letters[^5]);
Console.WriteLine(letters[^7]);
Console.WriteLine(letters[^9]);

Console.WriteLine(letters[^5..^1]);
