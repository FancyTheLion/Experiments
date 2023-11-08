namespace Task_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mesage =
            {
                "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ ",
                "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой ",
                "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть ",
                "если особенно упорно подойдешь к делу",
                " ",
                "будет Трудно конечнО ",
                "Код ведЬ не из простых ",
                "очень ХОРОШИЙ код",
                "то у тебя все получится",
                "и я буДу Писать тЕбЕ еще ",
                " ",
                "чао"
            };

            Console.WriteLine(DecodeMessage(mesage));

            Console.ReadLine();

        }

        private static string DecodeMessage(string[] lines)
        {
            List<string> trueMessage = new List<string>();
            string message = string.Join(" ", lines);
            string[] words = message.Split(' ');
            var result = words.Where(x => !string.IsNullOrWhiteSpace(x));


            for (int i = 0; i < result.ToArray().Length; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (Char.GetUnicodeCategory(result.ToArray()[i][j]) == Char.GetUnicodeCategory('A'))
                    {
                        trueMessage.Add(result.ToArray()[i]);
                    }
                }
            }
            trueMessage.Reverse();
            string finalAnswer = string.Join(" ", trueMessage);
            return finalAnswer;
        }
    }
}