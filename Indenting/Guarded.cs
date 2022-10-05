using Indenting.CustomGuards;

namespace Indenting
{
    public class Guarded
    {
        public decimal GetInitialPayment(UserData userData, PriceTier tier)
        {
            Guard.AgainstNull(userData, nameof(userData));
            Guard.AgainstInvalid(userData, nameof(userData));
            Guard.AgainstInvalidEnum(tier, nameof(tier));

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
