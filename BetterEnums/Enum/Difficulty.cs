using System.ComponentModel;

namespace BetterEnums.Enum;

public enum Difficulty
{
    [Description("Just the Story!")]
    Easy,
    [Description("Sword and Story!")]
    Normal,
    [Description("Blood and Broken Bones!")]
    Hard,
    [Description("Death March!")]
    VeryHard
}