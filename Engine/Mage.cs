using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Mage : Player
    {
        

        public Mage(int id, int hitPoints, int maxHitPoints, int staminaPoints, int maxStamina,int manaPoints,int maxManaPoints, int experiencePoints, int level,string nickName)
        {
            id = 1;
            hitPoints = 500;
            maxHitPoints = 500;
            staminaPoints = 1000;
            maxStamina = 1000;
            ManaPoints = manaPoints;
            maxManaPoints = 1000;
            experiencePoints = 0;
            level = 0;
            
            NickName = nickName;

        }
        
        //public void FireBall(int mana)
        //{
        //    int damageToPlayer = RandomNumberGenerator.NumberBetween(200, 300);
            
        //}

        public void ChangeNickName(string nickname)
        {
            Console.WriteLine("Podaj swój nick: ");
            NickName = Console.ReadLine();
        }
    }
}
