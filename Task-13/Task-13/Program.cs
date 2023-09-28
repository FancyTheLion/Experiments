using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using System;

namespace Task_13
{
    public class Program
    {
        static void Main(string[] args)
        {
            BigCats bigCat = new BigCats()
            {
                PantheraGenus = "Лев",
                Predator = "Хищное млекопитающее",
                AverageLifeExpectancy = 15
            };

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };

            string jsonStringBigCat = JsonSerializer.Serialize(bigCat, options);

            File.WriteAllText(@"C:\Users\Fancy\Lessons\Experiments\Task-13\bigcats.json", jsonStringBigCat);

            Console.WriteLine(jsonStringBigCat);

            //BigCats restoredBigCat = JsonSerializer.Deserialize<BigCats>(jsonStringBigCat);

            //Console.WriteLine(restoredBigCat.PantheraGenus);
            //Console.WriteLine(restoredBigCat.Predator);
            //Console.WriteLine(restoredBigCat.AverageLifeExpectancy);



            Console.ReadLine();
        }
    }
}