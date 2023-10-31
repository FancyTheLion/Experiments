namespace Task_34
{
    public class Program
    {
        enum Suits
        {
            Wands,
            Coins,
            Cups,
            Swords
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetSuit(Suits.Wands));
            Console.WriteLine(GetSuit(Suits.Coins));
            Console.WriteLine(GetSuit(Suits.Cups));
            Console.WriteLine(GetSuit(Suits.Swords));

            Console.ReadLine();
        }

        private static string GetSuit(Suits suit)
        {
            return suit == Suits.Swords ? "мечей" : (suit == Suits.Coins ? "монет" : (suit == Suits.Cups ? "кубков" : "жезлов"));
        }
    }
}