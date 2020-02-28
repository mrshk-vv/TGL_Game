using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1.Interfaces
{
    public interface IPlayerVsPlayer
    {
        int CheckDamage(int p1Damage, int p2Damage, uint p1HealthPoint, uint p2HealthPoint);
        bool CheckSkillPower(int p1SkilPower, int p2SkilPower);
    }
}
