namespace BetterEnums.Object;

public class Difficulty
{
    public static Difficulty Easy { get; } = new Difficulty(1, "Just the Story!", "");
    public static Difficulty Medium { get; } = new Difficulty(2, "Sword and Story!", "");
    public static Difficulty Hard { get; } = new Difficulty(3, "Blood and Broken Bones!", "");
    public static Difficulty VeryHard { get; } = new Difficulty(4, "Death March!", "");

    private Difficulty(int id, string title, string description)
    {
        Id = id;
        Title = title;
        Description = description;
    }

    public int Id { get; init; }
    public string Title { get; init; }
    public string Description { get; init; }
}