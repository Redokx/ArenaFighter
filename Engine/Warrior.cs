using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Warrior : Player
    {
       
        public Warrior(int id, int hitPoints, int maxHitPoints,int staminaPoints,int maxStamina, int experiencePoints, int level)
        {
            id = RandomNumberGenerator.NumberBetween(0, 100000000);
            hitPoints = 1000;
            maxHitPoints = 1000;
            maxStamina = 1000;
            staminaPoints = 1000;
            experiencePoints = 0;
            level = 0;
            

        }

        public static int staminaPoints { get; private set; }

        public void SwordAttack(int stamina)
        {
            int damageToPlayer = RandomNumberGenerator.NumberBetween(100, 200);
            Warrior.staminaPoints -= 50;
        }

    }
}
