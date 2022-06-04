using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_PingPong.Classes
{
    public class Pong
    {
        public delegate void Handler();
        public event Handler Notify;
        public void Play()
        {
            Random rnd = new Random();
            int magicNumber = rnd.Next(0, 10);
            if (magicNumber > 2)
            {
                Console.WriteLine("Ping получил Pong");
                Notify?.Invoke();
            }
            else
            {
                Console.WriteLine("Pong промахнулся! Победил Ping");
            }
        }
    }
}
