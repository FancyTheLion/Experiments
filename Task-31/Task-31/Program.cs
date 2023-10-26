namespace Task_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] a = {1, 5, 20, 40};

            Console.WriteLine(MaxIndex(a));

            Console.ReadKey();
        }

        public static int MaxIndex(double[] array)
        {
            int maxI = 0;
            double maxValue = double.MinValue;
            int i = 0;
            foreach (var item in array)
            {
                if (item > maxValue)
                {
                    maxValue = item;
                    maxI = i;
                }
                i++;
            }
            if (array.Length == 0)
            {
                return -1;
            }
            return maxI;
        }
    }
}