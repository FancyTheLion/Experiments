namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = EnterNumber("количество школьников");
            int k = EnterNumber("количество яблок");
            Console.WriteLine($"Школьники: {n} Яблоки: {k}");

            int result = n / k;

            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static int EnterNumber(string numberName)
        {
            Console.WriteLine($"Введите {numberName}:");

            while (true)
            {
                string enteredString = Console.ReadLine();

                int result;

                bool isSuccess = int.TryParse(enteredString, out result);

                if (isSuccess)
                {
                    return result;
                }

                Console.WriteLine("Не число!");
            }
        }
    }
}