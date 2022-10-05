namespace Indenting.CustomGuards
{
    public static class Guard
    {
        public static void AgainstNull<T>(T argument, string argumentName)
        {
            if (argument == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        public static void AgainstInvalid(UserData userData, string argumentName)
        {
            if (!userData.IsValid())
            {
                throw new ArgumentException("Invalid Info", nameof(userData));
            }
        }

        public static void AgainstInvalidEnum<T>(T tier, string argumentName)
            where T : Enum
        {
            if (!Enum.IsDefined(typeof(T), tier))
            {
                throw new ArgumentOutOfRangeException(argumentName);
            }
        }
    }
}
