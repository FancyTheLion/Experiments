namespace Task_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print(GetSquare(42));

            Console.ReadKey();
        }


        private static double GetSquare(double t)
        {
            double a;

            return a = Math.Pow(t, 2);
        }

        private static void Print(double t)
        {
            Console.WriteLine(t);
        }
    }
}