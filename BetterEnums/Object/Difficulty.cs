namespace BetterEnums.Object;

public class Difficulty
{
    public static Difficulty Easy { get; } = new Difficulty(1, "Just the Story!", "Enjoy a Smooth Ride Through the World");
    public static Difficulty Normal { get; } = new Difficulty(2, "Sword and Story!", "You're Happy to be Challenged");
    public static Difficulty Hard { get; } = new Difficulty(3, "Blood and Broken Bones!", "You're a Seasoned, Demanding Gamer");
    public static Difficulty VeryHard { get; } = new Difficulty(4, "Death March!", "You're Truly Insane and Loving It");

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