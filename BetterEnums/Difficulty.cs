using System.ComponentModel;

namespace BetterEnums;

public enum Difficulty
{
    [Description("Just the Story!")]
    Easy,
    [Description("Sword and Story!")]
    Medium,
    [Description("")]
    Hard,
    [Description("")]
    VeryHard
}