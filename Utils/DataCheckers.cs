using System.Globalization;

namespace Utils
{
    public class DataCheckers
    {
        public static int IntegerCheck(string outputText, ConsoleColor color)
        {
            Assistance.SlowColorWriteLine(outputText, color);

            bool isCorrect;
            int data;
            CultureInfo culture = CultureInfo.InvariantCulture;

            do
            {
                isCorrect = int.TryParse(Console.ReadLine(), NumberStyles.Any, culture, out data);

                if (!isCorrect || data <= 0 || data >= 10)
                {
                    Assistance.SlowColorWriteLine("\nIncorrect data, please try again:\n-> ", color);
                }
            } while (!isCorrect || data <= 0 || data >= 10);

            return data;
        }
        public static double DoubleCheck(string outputText, ConsoleColor color)
        {
            Assistance.SlowColorWriteLine(outputText, color);

            bool isCorrect;
            double data;
            CultureInfo culture = CultureInfo.InvariantCulture;

            do
            {
                isCorrect = double.TryParse(Console.ReadLine(), NumberStyles.Any, culture, out data);

                if (!isCorrect || data < 0)
                {
                    Assistance.SlowColorWriteLine("\nIncorrect data, please try again:\n-> ", color);
                }
            } while (!isCorrect || data < 0);

            return data;
        }
    }
}
