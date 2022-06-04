using System;
using Lesson9_PingPong.Classes;


namespace Lesson9_PingPong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ping ping = new Ping();
            Pong pong = new Pong();
            ping.Notify += pong.Play;
            pong.Notify += ping.Play;
            ping.Play();
        }
    }
}