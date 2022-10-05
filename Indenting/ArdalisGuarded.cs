using Ardalis.GuardClauses;

namespace Indenting
{
    public class ArdalisGuarded
    {
        public decimal GetInitialPayment(UserData userData, PriceTier tier)
        {
            Guard.Against.Null(userData, nameof(userData));
            Guard.Against.InvalidInput(userData, nameof(userData), x => x.IsValid());
            Guard.Against.EnumOutOfRange(tier, nameof(tier));

            if (tier == PriceTier.Professional)
            {
                return 5m; // Payment Required
            }

            if (tier == PriceTier.Enterprise)
            {
                return 10m; // Payment Required
            }

            return 0m; // No Payment Required
        }
    }
}
