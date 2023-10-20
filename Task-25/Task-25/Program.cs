namespace Task_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(GetMinPowerOfTwoLargerThan(2)); // => 4
            Console.WriteLine(GetMinPowerOfTwoLargerThan(15)); // => 16
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-2)); // => 1
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-100));
            Console.WriteLine(GetMinPowerOfTwoLargerThan(100));

            Console.ReadKey();
        }

        private static int GetMinPowerOfTwoLargerThan(int number)
        {
            int result = 1;
            while (result <= number)
            result *= 2;
            return result;
        }
    }
}