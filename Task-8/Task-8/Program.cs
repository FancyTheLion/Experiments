namespace Task_8
{
    internal class Program
    {
        private const int ElementsCount = 6;

        static void Main(string[] args)
        {
            int number = 235640;
            int numberCopy = number;

            int[] didgits = new int[ElementsCount];

            for (int i = 0; i < ElementsCount; i++)
            {
                didgits[i] = number % 10;
                number = number / 10;
            }

            int elementsHalfCount = ElementsCount / 2;

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < elementsHalfCount; i++)
            {
                sum1 += didgits[i];
                sum2 += didgits[i + elementsHalfCount];
            }

            if (sum1 == sum2)
            {
                Console.WriteLine($"Билет с номером {numberCopy} счастливый!");
            }
            else
            {
                Console.WriteLine($"Билет с номером {numberCopy} несчастливый.");
            }

            Console.ReadKey();
        }



        //int luckyNumber;
        //Console.WriteLine("Введите шестизначное число:");

        //if (!int.TryParse(Console.ReadLine(), out luckyNumber))
        //{
        //    Console.WriteLine("Введено не число!");
        //    Console.ReadKey();
        //    return;
        //}

        //int luckyNumber1 = luckyNumber / 100000;
        //int luckyNumber2 = luckyNumber / 10000 % 10;
        //int luckyNumber3 = luckyNumber / 1000 % 10;
        //int luckyNumber4 = luckyNumber / 100 % 10;
        //int luckyNumber5 = luckyNumber / 10 % 10;
        //int luckyNumber6 = luckyNumber % 10;

        //if (luckyNumber1 + luckyNumber2 + luckyNumber3 == luckyNumber4 + luckyNumber5 + luckyNumber6)
        //{
        //    Console.WriteLine($"Билет с номером {luckyNumber} счастливый!");
        //}
        //else
        //{
        //    Console.WriteLine($"Билет с номером {luckyNumber} несчастливый");
        //}
    }
}