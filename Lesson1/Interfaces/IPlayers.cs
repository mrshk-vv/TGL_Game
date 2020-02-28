using Lesson1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1.Interfaces
{
    public interface IPlayers
    {
        List<Person> AllPlayers { get;}
        Person GetPlayer();
    }
}
