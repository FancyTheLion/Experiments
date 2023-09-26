namespace Task_11
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            Task.Run(AsyncValueCycleFive);

            Task.Run (AsyncValueCycleTen);

            Console.ReadLine();

        }

        /// <summary>
        /// Отображение n + 5 числа 
        /// </summary>
        public static async Task AsyncValueCycleFive()
        {
            for (int i = 0; true; i += 5)
            {
                Console.WriteLine($"Число а: {i}");

                await Task.Delay(500);
            }
        }

        /// <summary>
        /// Отображение n + 10 числа
        /// </summary>
        public static async Task AsyncValueCycleTen()
        {

            for (int i = 0; true; i += 10)
            {
                Console.WriteLine($"Число b: {i}");

                await Task.Delay(501);
            }
        }

    }



}