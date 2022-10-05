namespace Indenting
{
    public class SignUpFlattened
    {
        public decimal GetInitialPayment(UserData userData, PriceTier tier)
        {
            if (userData == null)
            {
                throw new ArgumentNullException(nameof(userData));
            }
            if (!userData.IsValid())
            {
                throw new ArgumentException("Invalid Info", nameof(userData));
            }
            if (tier == PriceTier.Personal)
            {
                return 0m; // No Payment Required
            }
            else if (tier == PriceTier.Professional)
            {
                return 5m; // Payment Required
            }
            else if (tier == PriceTier.Enterprise)
            {
                return 10m; // Payment Required
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(tier));
            }
        }
    }
}
