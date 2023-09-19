namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца от 1 до 5:");

            int.TryParse(Console.ReadLine(), out int month);


                switch (month) // думал как ввести проверку. не смог :( 
                {
                    case 1: Console.WriteLine($"Количество дней в {month} месяце: 31"); break;
                    case 2: Console.WriteLine($"Количество дней в {month} месяце: 30"); break;
                    case 3: Console.WriteLine($"Количество дней в {month} месяце: 29"); break;
                    case 4: Console.WriteLine($"Количество дней в {month} месяце: 28"); break;
                    case 5: Console.WriteLine($"Количество дней в {month} месяце: 28()"); break;
                    default: Console.WriteLine("Не корректный ввод"); break;
                }




            Console.ReadKey();
        }
    }
}