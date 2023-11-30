namespace Utils
{
    public class Assistance
    {
        public static void DrawHeart() // Рисуем сердечко
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  /\\  /\\");
            Console.WriteLine(" /  \\/  \\");
            Console.WriteLine("/        \\");
            Console.WriteLine("\\        /");
            Console.WriteLine(" \\      /");
            Console.WriteLine("  \\    /");
            Console.WriteLine("   \\  /");
            Console.WriteLine("    \\/");
            Console.ResetColor();
        }
        public static void SlowColorWriteLine(string? inputText, ConsoleColor color)
        {
            if (string.IsNullOrEmpty(inputText))
                throw new ArgumentNullException("Input text is null or empty.");

            var defaulColor = Console.ForegroundColor;
            Console.ForegroundColor = color;

            foreach (var c in inputText)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }

            Console.ForegroundColor = defaulColor;
        }
    }
}
