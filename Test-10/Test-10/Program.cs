namespace Test_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите максимальное четное число для отображения каждого четного числа:");

            int.TryParse(Console.ReadLine(), out int numberEven);

            for (int i = 1; i <= numberEven; i++) 
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();

            //int.TryParse(Console.ReadLine(), out int numberEven);

            //for (int i = 2;  i <= numberEven; i = i + 2)
            //{
            //    Console.WriteLine($"Число {i} четное!");
            //}
        }
    }
}