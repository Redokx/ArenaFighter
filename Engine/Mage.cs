using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Mage : Player
    {
        public Mage(int id, int hitPoints, int maxHitPoints, int staminaPoints, int maxStamina, int manaPoints, int maxManaPoints, int experiencePoints, int level, string nickName)
        {
           ID = id;
           HitPoints = hitPoints;
           MaxHitPoints = maxHitPoints;
           StaminaPoints = staminaPoints;
           MaxStamina = maxStamina;
           ManaPoints = manaPoints;
           MaxManaPoints = maxManaPoints;
           ExperiencePoints = experiencePoints;
           Level = level;
           NickName = nickName;

        }
        
        //public void FireBall(int mana)
        //{
        //    int damageToPlayer = RandomNumberGenerator.NumberBetween(200, 300);
            
        //}
        
    }
}
