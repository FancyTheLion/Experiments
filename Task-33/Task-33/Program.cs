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
            var argument1 = EnterArray();
            var argument2 = EnterArray();

            Console.WriteLine("Индекс подмассива:");
            Console.WriteLine(FindSubarrayStartIndex(argument1, argument2));

            Console.ReadLine();
        }

        public static int FindSubarrayStartIndex(int[] array, int[] subArray)
        {
            for (var i = 0; i < array.Length - subArray.Length + 1; i++)
            {
                if (ContainsAtIndex(array, subArray, i))
                {
                    return i;
                }
            }

            return -1;
        }

        public static bool ContainsAtIndex(int[] array, int[] subArray, int i)
        {
            for (int j = 0; j < subArray.Length; j++)
            {
                if (array[i + j] != subArray[j])
                {
                    return false;
                }
	        }

	        return true;
        }

        /// <summary>
        /// Метод ввода массива
        /// </summary>
        /// <returns></returns>
        public static int[] EnterArray()
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

            return myArray;
        }
    }
}