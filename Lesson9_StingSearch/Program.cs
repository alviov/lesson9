using System;
using Lesson9_StingSearch.Classes;
using System.Text.RegularExpressions;


namespace Lesson9_StingSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringSearcher stringsearch = new StringSearcher();
            OnConsole info = new OnConsole();
            List<string> stringlist = new List<string> { "Шла", "Саша", "по", "шоссе", "и", "Саша", "сосала", "сушку" };
            stringsearch.Notify += info.Show;
            stringsearch.Search(stringlist);
        }
    }
}