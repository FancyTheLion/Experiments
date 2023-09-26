namespace Task_12_Upgrade_Task_11_
{
    internal class Program
    {
        #region Ограничения длительности циклов

        private const int LimitationCycle_1 = 50;
        private const int LimitationCycle_2 = 100;

        #endregion
        async static Task Main(string[] args)
        {
            Task.WaitAll(AsyncValueCycleFive(), AsyncValueCycleTen());

        }

        /// <summary>
        /// Отображение n + 5 чисел
        /// </summary>
        public static async Task AsyncValueCycleFive()
        {
            for (int i = 0; i <= LimitationCycle_1; i += 5)
            {
                Console.WriteLine($"Число а: {i}");

                await Task.Delay(300);
            }
        }

        /// <summary>
        /// Отображение n + 10 чисел
        /// </summary>
        public static async Task AsyncValueCycleTen()
        {
            for (int i = 0; i <= LimitationCycle_2; i += 10)
            {
                Console.WriteLine($"Число b: {i}");

                await Task.Delay(300);
            }
        }

    }
}