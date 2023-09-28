using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using System;

namespace Task_13
{
    public class BigCat
    {
        public string PantheraGenus { get; set; }
        public string Predator { get; set; }
        public int AverageLifeExpectancy { get; set; }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            BigCat bigCat = new BigCat()
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

            Console.WriteLine(jsonStringBigCat);

            BigCat restoredBigCat = JsonSerializer.Deserialize<BigCat>(jsonStringBigCat);

            Console.WriteLine(restoredBigCat.PantheraGenus);
            Console.WriteLine(restoredBigCat.Predator);
            Console.WriteLine(restoredBigCat.AverageLifeExpectancy);

            Console.ReadLine();
        }
    }
}