namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = EnterNumber("число 1");
            int number2 = EnterNumber("число 2");

            if (number1 > number2)
            {
                Console.WriteLine($" Число 1 больше числа 2: {number1} > {number2}");
            }
            else if (number2 > number1)
            {
                Console.WriteLine($"Число 2 больше числа 1: {number2} > {number1}");
            }
            else
            {
                Console.WriteLine($"Число 1 и число 2 равны: {number1} = {number2} ");
            }


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