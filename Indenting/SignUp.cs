namespace Indenting
{
    public class SignUp
    {
        public decimal GetInitialPayment(UserData userData, PriceTier tier)
        {
            if (userData != null)
            {
                if (userData.IsValid())
                {
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
                else
                {
                    throw new ArgumentException("Invalid Info", nameof(userData));
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(userData));
            }
        }
    }
}
