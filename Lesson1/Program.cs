using Lesson1.Models;
using System;
using System.Collections.Generic;


namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {

            Starter start = new Starter();

            start.Notify += OnNotify;
            start.StartFight();
        }

        private static void OnNotify(string args)
        {
            Console.WriteLine(args);
        }
    }
}
