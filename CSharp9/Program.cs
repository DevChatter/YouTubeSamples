using static System.Console;

Person me = new("Brendoneus", Color: "Yellow");

if (me.Age is not null and >= 0 and < 150)
{
    WriteLine($"Age: {me.Age}");
}


public record Person
    (string Name, string Color, int? Age = null)
{
}