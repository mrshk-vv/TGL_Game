using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public uint HealthPoint { get; set; }
        public uint Damage { get; set; }
        public double Reload { get; set; }
    }
}
