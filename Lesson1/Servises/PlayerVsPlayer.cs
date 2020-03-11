using System;
using System.Collections.Generic;
using System.Text;
using Lesson1.Interfaces;
using Lesson1.Models;

namespace Lesson1.Servises
{
    public class PlayerVsPlayer : IPlayerVsPlayer
    {
        Person p1;
        Person p2;

        public PlayerVsPlayer(Person p1,Person p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }


        public string WhoWin()
        {
            Console.WriteLine("Дерутся " + p1.Name + " и " + p2.Name);
            Console.WriteLine("Fight !");
            Console.WriteLine();
            Console.WriteLine(p1.Name + " : " + "Тикай з села");
            Console.WriteLine(p2.Name + " : " + "К тебе прийду");
            bool checker = true;


            while(checker)
            {
                p2.HealthPoint = CheckDamage(p1.Damage, p2.HealthPoint);
                Console.WriteLine(p2.Name + " - " + p2.Damage + "HP" + ". Осталось HP " + p2.HealthPoint);
                if(p2.HealthPoint < p1.Damage)
                {
                    checker = false;
                }
                p1.HealthPoint = CheckDamage(p2.Damage, p1.HealthPoint);
                Console.WriteLine(p1.Name + " - " + p1.Damage + "HP" + ". Осталось HP " + p1.HealthPoint);
                if (p1.HealthPoint < p2.Damage)
                {
                    checker = false;
                }

            }
            if (p1.HealthPoint <= 0)
            {
                if(!CheckSkillPower(p1.SkillPower, p2.SkillPower))
                {
                    Console.WriteLine(p2.Name + " Fatatity !!!!!!");
                }
                Console.WriteLine();
                return p2.Name + " Победил";
            }
            else
            {
                if (CheckSkillPower(p1.SkillPower, p2.SkillPower))
                {
                    Console.WriteLine(p1.Name + " Fatatity !!!!!!");
                }
                Console.WriteLine();
                return p1.Name + " Победил";
            }
        }

        public int CheckDamage(int Damage, int HealhtPoint)
        {
            return HealhtPoint - Damage;
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
