using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Mage : Player
    {
        public static string NickName { get; set; }
        public Mage(int id, int hitPoints, int maxHitPoints, int staminaPoints, int maxStamina,int manaPoints,int maxManaPoints, int experiencePoints, int level,string nickName)
        {
            id = RandomNumberGenerator.NumberBetween(0, 100000000);
            hitPoints = 500;
            maxHitPoints = 500;
            staminaPoints = 1000;
            maxStamina = 1000;
            manaPoints = 1000;
            maxManaPoints = 1000;
            experiencePoints = 0;
            level = 0;
            NickName = nickName;


        }

        public static int manaPoints { get; private set; }
        

        public void FireBall(int mana)
        {
            int damageToPlayer = RandomNumberGenerator.NumberBetween(200, 300);
            Mage.manaPoints -= 50;
        }

    }
}
