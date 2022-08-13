using System.ComponentModel;

namespace BetterEnums.Enum;

public enum Difficulty
{
    [Description("Just the Story!")]
    Easy,
    [Description("Sword and Story!")]
    Medium,
    [Description("Blood and Broken Bones!")]
    Hard,
    [Description("Death March!")]
    VeryHard
}