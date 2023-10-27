namespace Task_33
{
    internal class Program
    {
        /* Задача: поиск в массиве подмассива. "Попробуйте найти в массиве не один элемент, а целый подмассив!

Если подмассив найден в массиве, то вернуть нужно минимальный индекс, с которого начинается подмассив в исходном массиве.
Например, поиск подмассива "3,4" в массиве "1,2,3,4,3,4" должен вернуть 2.
        
         Вопрос: что в методе EnteringArrayValue нужно возвращать. И нужно ли. (Ввод значений массива с консоли пользователем) */
        static void Main(string[] args) 
        {
            //int[] argument1 = 
            //int[] argument2 = 

            Console.WriteLine(FindSubarrayStartIndex(argument1, argument2));

        }

        public static int FindSubarrayStartIndex(int[] array, int[] subArray)
        {
            for (var i = 0; i < array.Length - subArray.Length + 1; i++)
                if (ContainsAtIndex(array, subArray, i))
                    return i;
            return -1;
        }

        public static bool ContainsAtIndex(int[] array, int[] subArray, int i)
        {
            for (int j = 0; j < subArray.Length; j++)
            {
                if (array[i + j] != subArray[j]) return false;
	        }
	        return true;
        }

        /// <summary>
        /// Метод 
        /// </summary>
        /// <returns></returns>
        public static int EnteringArrayValue()
        {
            Console.WriteLine("Введите количество элементов массива:\t");

            int elementCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"\nВведите элемент массива под индексом {i}: \t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вывод массива:");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            return myArray[i];
        }

        //public static int EnterNumber(string numberName)
        //{
        //    Console.WriteLine($"Введите {numberName}:");

        //    while (true)
        //    {
        //        string enteredString = Console.ReadLine();

        //        int result;

        //        bool isSuccess = int.TryParse(enteredString, out result);

        //        if (isSuccess)
        //        {
        //            return result;
        //        }

        //        Console.WriteLine("Вы ввели не число, повторите ввод!");
        //    }
        //}
    }
}