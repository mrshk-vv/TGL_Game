using System;
using System.Collections.Generic;
using System.Text;
using Lesson1.Interfaces;

namespace Lesson1.Servises
{
    public class PlayerVsPlayer : IPlayerVsPlayer
    {
        public uint CheckDamage(int p1Damage, int p2Damage, uint p1HealthPoint, uint p2HealthPoint)
        {
            if(p1Damage > p2Damage)
            {
                if(p1Damage > p2HealthPoint)
                {
                    return p2HealthPoint;
                }
                else
                {
                    return p2HealthPoint - p1Damage;
                }
                
            }
            else
            {
                if (p2Damage > p1HealthPoint)
                {
                    return (int)p1HealthPoint;
                }
                else
                {
                    return (int)p1HealthPoint - p2Damage;
                }  
            }

        }

        public bool CheckSkillPower(int p1SkilPower, int p2SkilPower)
        {
            if(p1SkilPower > p2SkilPower)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
