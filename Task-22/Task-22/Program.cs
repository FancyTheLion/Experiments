namespace Task_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsCorrectMove("a1", "d4");
            IsCorrectMove("f4", "e7");
            IsCorrectMove("a1", "a4");

            Console.ReadKey();
        }

        public static bool IsCorrectMove(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали

            return (dx != 0 || dy != 0) && (dx == dy || dx * dy == 0);
        }
    }
}