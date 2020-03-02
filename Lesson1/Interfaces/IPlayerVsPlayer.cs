using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1.Interfaces
{
    public interface IPlayerVsPlayer
    {
        string WhoWin();
        int CheckDamage(int p1Damage, int p2Damage);
        bool CheckSkillPower(int p1SkilPower, int p2SkilPower);
    }
}
