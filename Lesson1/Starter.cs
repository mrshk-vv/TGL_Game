using Lesson1.Interfaces;
using Lesson1.Models;
using Lesson1.Servises;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    public class Starter
    {

        public delegate string WhoWin();
        public event WhoWin Notify;

        Players players = new Players();

        public Starter()
        {
            Person p1 = players.GetPlayer();
            Person p2 = players.GetPlayer();
            PlayerVsPlayer pvp = new PlayerVsPlayer(p1, p2);

            Notify += pvp.WhoWin;

           var output =  Notify.Invoke();

            Console.WriteLine(output);
        }


    }
}
