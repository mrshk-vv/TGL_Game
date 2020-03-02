using Lesson1.Interfaces;
using Lesson1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    public class Starter
    {

        public delegate void WhoWin(string args);
        public event WhoWin Notify;


        public Starter()
        {
            Notify.Invoke("Хуй");
        }

    }
}
