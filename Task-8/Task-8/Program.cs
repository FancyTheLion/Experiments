namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luckyNumber;
            Console.WriteLine("Введите шестизначное число:");

            if (!int.TryParse(Console.ReadLine(), out luckyNumber)) ;
            {
                Console.WriteLine("Введено не число, повторить ввод");
                return;
            }

            int luckyNumber1 = luckyNumber / 100000;
            int luckyNumber2 = luckyNumber / 10000 % 10;
            int luckyNumber3 = luckyNumber / 1000 % 10;
            int luckyNumber4 = luckyNumber / 100 % 10;
            int luckyNumber5 = luckyNumber / 10 % 10;
            int luckyNumber6 = luckyNumber % 10;

            if (luckyNumber1 + luckyNumber2 + luckyNumber3 == luckyNumber4 + luckyNumber5 + luckyNumber6)
            {
                Console.WriteLine($"Билет с номером {luckyNumber} счастливый!");
            }
            Console.WriteLine($"Билет с номером {luckyNumber} несчастливый");

            Console.ReadKey();

        }


    }
}