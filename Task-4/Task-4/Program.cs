namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите построчно три числа");
            int a = EnterNumber("Число 1");
            int b = EnterNumber("Число 2");
            int c = EnterNumber("Число 3");
            int res1 = a + b + c;
            int res2 = a * b * c;
            Console.Write($"Сумма = { res1 } Произведение = { res2 }");
            Console.ReadKey();
        }

        public static int EnterNumber(string numberName)
        {
            Console.WriteLine($"Введите {numberName}:");

            while (true)
            {
                string enteredString = Console.ReadLine();

                int result;

                bool isSuccess = int.TryParse(enteredString, out result);// double.TryParse double это как книга в которой есть методы Pars и они неразделимы 

                if (isSuccess)
                {
                    return result;
                }

                Console.WriteLine("Не число!");
            }
        }
    }
}