using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Engine
{
    public class Player
    {

        protected int ID;//(generowane automatycznie i unikalne dla każdego nowo stworzonego gracza)
        protected string NickName;//(pseudonim gracza)

        protected int HitPoints { get; set; }//(punkty życia)
        protected int MaxHitPoints { get; set; }//(maksymalna ilość życia)
        protected int StaminaPoints { get; set; }//(wytrzymałość gracza)
        protected int MaxStamina { get; set; }//(maksymalna wytrzymałość)
        protected int ManaPoints { get; set; }//(punkty many)
        protected int MaxManPoints { get; set; }//(maksymalna ilość many)
        protected int ExperiencePoints { get; set; }//(ilość punktów doświadczenia)
        protected int Level { get; set; }//(Poziom)

        public String ToString()
        {
            return NickName;
        }

        public void BassicAttack(Player enemy)
        {
            int hit = RandomNumberGenerator.NumberBetween(25, 100);
            Console.WriteLine(NickName + "attacked with" + hit + "damage");
            enemy.WasHit(hit);
            StaminaPoints -= 5;

        }

        public bool alive()
        {
            return (HitPoints > 0);
        }
        
        public void WasHit(int hit)
        {
            int injury = hit;
            if (injury>0)
            {
                HitPoints -= injury;
                Console.WriteLine(NickName + "got " + injury +"damage");
            }
        }
        
       

    }
    
}
