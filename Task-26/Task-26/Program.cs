using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_26
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] text = {" a", "  b", "    cd", "     efg", "        text", "            two worlds", "        two spaces",
                "   tabs", "        two tabs", "            Many spaces", "     ", "\n\r line breaks are spaces too" };

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i].TrimStart());
            }

            Console.ReadKey();
        }

        ////public static string RemoveStartSpaces(string text)
        //{
        //    //if (char.IsWhiteSpace(text[0]))

        //    //    return text.TrimStart();

        //    //else return text;


        //}

    }
}