using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Warrior : Player
    {

        public Warrior(int id, int hitPoints, int maxHitPoints, int staminaPoints, int maxStamina, int experiencePoints, int level, string nickName)
        {
            ID = id;
            HitPoints = hitPoints;
            MaxHitPoints = maxHitPoints;
            MaxStamina = maxStamina;
            StaminaPoints = staminaPoints;
            ExperiencePoints = experiencePoints;
            Level = level;
            NickName = nickName;
        }

        public static Warrior CreateDefaultWarrior()
        {
            Warrior warrior = new Warrior(1, 1000, 1000, 1000, 1000, 0, 1, "");
            return warrior;
        }



        //public void SwordAttack(int stamina)
        //{
        //    while( async)
        //    { 
        //    int damageToPlayer = RandomNumberGenerator.NumberBetween(100, 200);
        //    int staminaPoints = -50;
        //    }
        //}

        public void ChangeNickName(string nickName)
        {
            Console.WriteLine("Podaj swój nick: ");
            NickName = Console.ReadLine();
        }
    }
}
