namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число ");


            //int number1 = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{ number1 } и { number2 }");

            double number1 = EnterNumber("Число 1");
            double number2 = EnterNumber("Число 2");
            double number3 = number1;
            number1 = number2;
            number2 = number3;
            Console.WriteLine($"Значения после перестановки: { number1} {number2}");
            Console.ReadKey();
        }

        public static double EnterNumber(string numberName)
        {
            Console.WriteLine($"Введите {numberName}:");

            while (true)
            {
                string enteredString = Console.ReadLine();

                double result;

                bool isSuccess = double.TryParse(enteredString, out result);// double.TryParse double это как книга в которой есть методы Pars и они неразделимы 

                if (isSuccess)
                {
                    return result;
                }

                Console.WriteLine("Не число!");
            }
        }
    }
}