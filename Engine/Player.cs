using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Engine
{
    public class Player
    {

        private int ID { get; set; }//(generowane automatycznie i unikalne dla każdego nowo stworzonego gracza)
        private string NickName { get; set; }//(pseudonim gracza)

        private int HitPoints { get; set; }//(punkty życia)
        private int MaxHitPoints { get; set; }//(maksymalna ilość życia)
        private int StaminaPoints { get; set; }//(wytrzymałość gracza)
        private int MaxStamina { get; set; }//(maksymalna wytrzymałość)
        private int ManaPoints { get; set; }//(punkty many)
        private int MaxManPoints { get; set; }//(maksymalna ilość many)
        private int ExperiencePoints { get; set; }//(ilość punktów doświadczenia)
        private int Level { get; set; }//(Poziom)


        public void BassicAttack()
        {
            int damageToPlayer = RandomNumberGenerator.NumberBetween(25, 100);
            StaminaPoints -= 5;

        }

        
        
       

    }
    
}
