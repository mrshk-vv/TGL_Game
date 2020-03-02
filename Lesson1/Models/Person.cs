using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1.Models
{
    public abstract class Person
    {
        public string Name { get; set; }

        public int HealthPoint { get; set; }

        public int Damage { get; set; }

        public int SkillPower { get; set; }
    }
}
