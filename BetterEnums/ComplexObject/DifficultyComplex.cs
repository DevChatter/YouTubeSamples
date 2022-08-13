namespace BetterEnums.ComplexObject;

public class Difficulty
{
    public static Difficulty Easy { get; } = new Difficulty(1, nameof(Easy), "Just the Story!", "Enjoy a Smooth Ride Through the World", 0.5, 1, 1);
    public static Difficulty Normal { get; } = new Difficulty(2, nameof(Normal), "Sword and Story!", "You're Happy to be Challenged", 1.1, 1.4, 1);
    public static Difficulty Hard { get; } = new Difficulty(3, nameof(Hard), "Blood and Broken Bones!", "You're a Seasoned, Demanding Gamer", 1.2, 2.3, 0.9);
    public static Difficulty VeryHard { get; } = new Difficulty(4, nameof(VeryHard), "Death March!", "You're Truly Insane and Loving It", 1.8, 3.3, 0.8);

    private Difficulty(int id, string name, string title, string description, double enemyHealthMod, double enemyDamageBonus, double expGain)
    {
        Id = id;
        Name = name;
        Title = title;
        Description = description;
        EnemyHealthMod = enemyHealthMod;
        EnemyDamageBonus = enemyDamageBonus;
        ExpGain = expGain;
    }

    public int Id { get; init; }
    public string Title { get; init; }
    public string Description { get; init; }
    public double EnemyHealthMod { get; init; }
    public double EnemyDamageBonus { get; init; }
    public double ExpGain { get; init; }
    public string Name { get; init; }
}
