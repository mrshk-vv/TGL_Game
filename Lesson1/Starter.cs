using Lesson1.Interfaces;
using Lesson1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    public class Starter
    {
        Draco draco = new Draco();
        Luco luco = new Luco();
        Paul paul = new Paul();
        Stan stan = new Stan();

        public List<Person> people = new List<Person>();

        public delegate void WhoWin(string args);
        public event WhoWin Notify;


        public Starter()
        {
            people.Add(draco);
            people.Add(luco);
            people.Add(paul);
            people.Add(stan);
        }

        public (Person p1, Person p2) SelectFighters()
        {
            Random rnd = new Random();
            return (people[rnd.Next(0, people.Count)], people[rnd.Next(0, people.Count)]);
        }

        public void StartFight()
        {
            var figthers = SelectFighters();

        }
    }
}
