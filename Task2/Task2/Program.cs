namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число для возведени в квадрат:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Квадрат числа = " + number * number);
            Console.ReadKey();
        }


    }
}