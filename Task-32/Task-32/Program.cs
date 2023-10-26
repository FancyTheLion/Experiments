namespace Task_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arg1= {1, 2, 2, 10, 10, 10, 20};
            int arg2 = EnterNumber("Какое число хочешь, 2 или 10? ;)");
            Console.WriteLine(GetElementCount(arg1, arg2));

            Console.ReadKey();
        }

        public static int GetElementCount(int[] items, int itemToCount)
        {
            int count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == itemToCount)
                {
                    count++;
                }
            }
            return count;
        }

        public static int EnterNumber(string numberName)
        {
            // Здесь мы пытаемся что-то сделать
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

                Console.WriteLine("Вы ввели не число, повторите ввод!");
            }
        }

    }
}