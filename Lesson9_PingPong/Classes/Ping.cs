using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_PingPong.Classes
{
    public class Ping
    {
        public delegate void Handler();
        public event Handler Notify;
        public void Play()
        {
            Random rnd = new Random();
            int magicNumber = rnd.Next(0, 10);
            if (magicNumber > 2)
            {
                Console.WriteLine("Pong получил Ping");
                Notify?.Invoke();
            }
            else
            {
                Console.WriteLine("Ping промахнулся! Победил Pong");
            }
        }
    }
}
