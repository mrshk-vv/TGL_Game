using Lesson1.Interfaces;
using Lesson1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1.Servises
{
    public class Players : IPlayers
    {
        public List<Person> AllPlayers =>
         new List<Person>
                {
                    new Draco
                    {
                        Name = "Draco",
                        Damage = 50,
                        HealthPoint = 500,
                        SkillPower =30
                    },
                    new Luco
                    {
                        Name = "Luco",
                        Damage = 45,
                        HealthPoint = 600,
                        SkillPower = 50
                    },
                    new Paul
                    {
                        Name = "Paul",
                        Damage = 40,
                        HealthPoint = 450,
                        SkillPower = 45
                    },
                    new Stan
                    {
                        Name = "Stan",
                        Damage = 70,
                        HealthPoint = 700,
                        SkillPower = 25
                    }
                };



        public Person GetPlayer()
        {
            Random random = new Random();
            int el = random.Next(0, AllPlayers.Count - 1);

            return AllPlayers[el];
        }
    }
}
