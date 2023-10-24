namespace Task_27
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
        }

        private static void WriteTextWithBorder(string text)
        {
            for (int i = 0; i < 1; i++) Console.Write("+");
            for (int j = 1; j <= text.Length + 2; j++) Console.Write("-");
            for (int i = 0; i < 1; i++) Console.Write("+\n" + "| " + text + " |");
            for (int i = 0; i < 1; i++) Console.Write("\n+");
            for (int j = 1; j <= text.Length + 2; j++) Console.Write("-");
            for (int i = 0; i < 1; i++) Console.Write("+\n");
        }
    }
}