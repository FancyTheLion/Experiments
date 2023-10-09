namespace Task_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLastHalf("I love CSharp  !"));

            Console.ReadKey();
        }

        public static string GetLastHalf(string text)
        {
            text = text.Substring(text.Length/2);
            text = text.Replace(" ", null); //А как корректнее? Так или через Empty
            return text;
        }
    }
}