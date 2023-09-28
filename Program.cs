using NLog;

namespace Nlog.test
{
     class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            try
            {
                int num1 = 2;
                int num2 = 3;
                int result = AddNumbers(num1, num2);

                Logger.Info($"Added {num1} and {num2} to get {result}");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "An error occurred while adding numbers.");
            }
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}