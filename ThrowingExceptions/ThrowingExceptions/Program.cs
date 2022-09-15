namespace ThrowingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ThrowingMethod();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void ThrowingMethod()
        {
            throw new NotImplementedException();
        }
    }
}
