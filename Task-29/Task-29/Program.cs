namespace Task_29
{
    internal class Program
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            foreach (var item in GetFirstEvenNumbers(count))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static int[] GetFirstEvenNumbers(int count)
        {
            int[] array = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i + 1) * 2;
            }
            return array;
        }
    }
}