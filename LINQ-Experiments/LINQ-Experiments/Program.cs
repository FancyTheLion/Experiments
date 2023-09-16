namespace LINQ_Experiments
{
    public class Program
    {
        private static IReadOnlyCollection<Furry> _furries = new List<Furry>()
        {
            // Создаём объект класса Furry и сразу задаём его свойства (конструктора у Furry нет)
            new Furry()
            {
                Name = "Howler",
                Sex = Sex.Male,
                Yiffyness = 30
            },

            new Furry()
            {
                Name = "Goldfur",
                Sex = Sex.Herm,
                Yiffyness = 100
            },

            new Furry()
            {
                Name = "Lozi",
                Sex = Sex.Male,
                Yiffyness = 90
            },

            new Furry()
            {
                Name = "Jarvvitch",
                Sex = Sex.Female,
                Yiffyness = 40
            },

            new Furry()
            {
                Name = "Varra",
                Sex = Sex.Female,
                Yiffyness = 10
            },

            new Furry()
            {
                Name = "Varra Male",
                Sex = Sex.Male,
                Yiffyness = 10
            }
        };

        public static void Main(string[] args)
        {
            Console.WriteLine("Исходные фурри:");
            PrintFurries(_furries);

            Console.WriteLine("-----------------------------------------------------------------------");
            PrintMaleFurries();

            Console.WriteLine("-----------------------------------------------------------------------");
            PrintFurriesCount();

            Console.WriteLine("-----------------------------------------------------------------------");
            PrintFurriesOrderedByYiffynessDesc();

            Console.WriteLine("-----------------------------------------------------------------------");
            PrintFurriesWithLInName();

            Console.WriteLine("-----------------------------------------------------------------------");
            PrintTwoMostYiffyFurries();

            Console.WriteLine("-----------------------------------------------------------------------");
            PrintFemalesWithVarInName();

            // Добавить несколько фуррей в _furries

            // 1) Отсортировать фуррей по алфавиту, A в начале, Z в конце

            // 2) Посчитать суммарную йиффливость всех самок

            // 3) Сформировать СПИСОК СТРОК (не фуррей) с именами всех фуррей и распечатать его

            Console.ReadLine();
        }

        #region Здесь методы - задания, на одно задание по методу

        /// <summary>
        /// Выделить самцов
        /// </summary>
        private static void PrintMaleFurries()
        {
            Console.WriteLine("Самцы:");

            var maleFurries = _furries
                .Where(f => f.Sex == Sex.Male)
                .ToList();

            PrintFurries(maleFurries);
        }

        /// <summary>
        /// Посчитать число фуррей
        /// </summary>
        private static void PrintFurriesCount()
        {
            Console.WriteLine("Число фуррей:");

            var furriesCount = _furries
                .Count();

            Console.WriteLine(furriesCount);
        }

        /// <summary>
        /// Напечатать отсортированных по убыванию йиффливости фуррей
        /// </summary>
        private static void PrintFurriesOrderedByYiffynessDesc()
        {
            Console.WriteLine("Фурри по убыванию йиффливости");

            var orderedFurries = _furries
                .OrderByDescending(f => f.Yiffyness)
                .ToList();

            PrintFurries(orderedFurries);
        }

        /// <summary>
        /// Напечатать фуррей с буквой "l" в имени (маленькая l, не большая)
        /// </summary>
        private static void PrintFurriesWithLInName()
        {
            Console.WriteLine("Фурри с буквой l в имени");

            var furriesWithL = _furries
                .Where(f => f.Name.Contains("l"))
                .ToList();

            PrintFurries(furriesWithL);
        }

        /// <summary>
        /// Напечатать двух самых йиффливых фуррей
        /// </summary>
        private static void PrintTwoMostYiffyFurries()
        {
            Console.WriteLine("Два самых йиффливых фурря");

            var twoYiffiestFurries = _furries
                .OrderByDescending(f => f.Yiffyness)
                .Take(2)
                .ToList();

            PrintFurries(twoYiffiestFurries);
        }

        /// <summary>
        /// Напечатать всех самок с буквосочетанием Var в имени
        /// </summary>
        private static void PrintFemalesWithVarInName()
        {
            Console.WriteLine("Самки с Var в имени");

            var femalesWithVarInName = _furries
                .Where(f => f.Sex == Sex.Female)
                .Where(f => f.Name.Contains("Var"))
                .ToList();

            PrintFurries(femalesWithVarInName);
        }

        #endregion

        /// <summary>
        /// Метод, распечатывающий фуррей
        /// </summary>
        private static void PrintFurries(IReadOnlyCollection<Furry> furries)
        {
            foreach(var furry in furries)
            {
                Console.WriteLine($"Имя: { furry.Name }, Пол: { furry.Sex }, Йиффливость: { furry.Yiffyness }");
            }
        }
    }
}