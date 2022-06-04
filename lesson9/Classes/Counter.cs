using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson9.Classes;


namespace lesson9.Classes
{
    public class Counter
    {
        public delegate void Handler();
        public event Handler Notify;
        public class EventArgs
        {
            public string Message { get; }
            public int i { get; }
            public EventArgs(string mes, int i)
            {
                Message = mes;
                this.i = i;
            }
        }
        public void Run(int Number)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == Number)
                {
                    Notify();
                }
            }
        }
    }
}
