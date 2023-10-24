namespace Task_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteBoard(8);
            WriteBoard(1);
            WriteBoard(2);
            WriteBoard(3);
            WriteBoard(10);
            
            Console.ReadKey();
        }

        private static void WriteBoard(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((j + i) % 2 == 0)
                        Console.Write("#");
                    else Console.Write(".");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}