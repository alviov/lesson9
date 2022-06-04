using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lesson9_StingSearch.Classes
{
    public class StringSearcher
    {
        public delegate void Handler(string result);
        public event Handler Notify;
        public event Handler Stop;
        Regex regex = new Regex("Саша");
        internal string test = "Да";
        public void Search(List<string> stringlist)
        {

            MatchCollection matches = regex.Matches(stringlist[1]);
            foreach (string str in stringlist)
            {
                matches = regex.Matches(str);
                for (int i=0; i < matches.Count;i++)
                {
                    if (test != "Нет" && test != "нет")
                    {
                        Notify?.Invoke(matches[i].ToString());
                        Console.WriteLine("Продолжить поиск?(Да/Нет)");
                        test = Console.ReadLine();
                    }
                }
            }
        }
    }
}
