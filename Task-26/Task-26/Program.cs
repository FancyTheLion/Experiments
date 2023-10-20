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

            //Console.WriteLine(RemoveStartSpaces("a"));
            //Console.WriteLine(RemoveStartSpaces(" b"));
            //Console.WriteLine(RemoveStartSpaces(" cd"));
            //Console.WriteLine(RemoveStartSpaces(" efg"));
            //Console.WriteLine(RemoveStartSpaces(" text"));
            //Console.WriteLine(RemoveStartSpaces(" two words"));
            //Console.WriteLine(RemoveStartSpaces("  two spaces"));
            //Console.WriteLine(RemoveStartSpaces("	tabs"));
            //Console.WriteLine(RemoveStartSpaces("		two	tabs"));
            //Console.WriteLine(RemoveStartSpaces("                             many spaces"));
            //Console.WriteLine(RemoveStartSpaces("               "));
            //Console.WriteLine(RemoveStartSpaces("\n\r line breaks are spaces too"));
        }

        ////public static string RemoveStartSpaces(string text)
        //{
        //    //if (char.IsWhiteSpace(text[0]))

        //    //    return text.TrimStart();

        //    //else return text;


        //}

    }
}