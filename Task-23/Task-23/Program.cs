namespace Task_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ShouldFire(true, "boss", 79));
            Console.WriteLine(ShouldFire2(true, "boss", 44));

            Console.ReadKey();
        }

        public static bool ShouldFire(bool enemyInFront, string enemyName, int robotHealth)
        {
            bool shouldFire = true;
            if (enemyInFront == true)
            {
                if (enemyName == "boss")
                {
                    if (robotHealth < 50) shouldFire = false;
                    if (robotHealth > 100) shouldFire = true;
                }
            }
            else
            {
                return false;
            }
            return shouldFire;
        }

        public static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
        {
            return ((enemyInFront == true) && (enemyName == "boss") && (robotHealth >= 50)) || ((enemyInFront == true) && (enemyName != "boss"));
        }
    }
}