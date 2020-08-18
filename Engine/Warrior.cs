using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Warrior  : Player
    {
        
        public Warrior(int id, int hitPoints, int maxHitPoints, int staminaPoints, int maxStamina, int experiencePoints, int level, string nickName)
        {
            ID = id;
            HitPoints = hitPoints;
            MaxHitPoints = maxHitPoints;
            StaminaPoints = staminaPoints;
            MaxStamina = maxStamina;
            ExperiencePoints = experiencePoints;
            Level = level;
            NickName = nickName;
        }
        

        //public void SwordAttack(int stamina)
        //{
        //    while( async)
        //    { 
        //    int damageToPlayer = RandomNumberGenerator.NumberBetween(100, 200);
        //    int staminaPoints = -50;
        //    }
        //}
        
    }
}
