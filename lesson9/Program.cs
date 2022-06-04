using System;
using lesson9.Classes;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter count = new Counter();
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();
            count.Notify += handler2.OnConsole;
            count.Notify += handler1.OnConsole;
            count.Run(77);

            string result;
            List<string> stringlist = new List<string> { "1", "2", "3" };

        }
    }
}