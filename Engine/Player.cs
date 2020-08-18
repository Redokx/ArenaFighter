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
        protected int HitPoints;//(punkty życia)
        protected int MaxHitPoints;//(maksymalna ilość życia)
        protected int StaminaPoints;//(wytrzymałość gracza)
        protected int MaxStamina;//(maksymalna wytrzymałość)
        protected int ManaPoints;//(punkty many)
        protected int MaxManaPoints;//(maksymalna ilość many)
        protected int ExperiencePoints;//(ilość punktów doświadczenia)
        protected int Level;//(Poziom)
        protected string message;
        protected string message2;

        public string Nickname { get; private set; }

       

        public void BasicAttack(Player enemy) //attack enemy player
        {
            
            int hit = RandomNumberGenerator.NumberBetween(25, 100);
            Console.WriteLine(NickName + " attacked with " + hit + " damage");
            
            enemy.WasHit(hit);
            StaminaPoints -= 5;
            
        }

        public bool Alive()
        {
            return (HitPoints > 0);
        }
        
        public void WasHit(int hit)
        {
            int injury = hit;
            if (injury>0)
            {
                HitPoints -= injury;
                message = (NickName + " got " + injury +" damage" );
 
            }
            else
            SetMessage(message);
        }

        public void Dead()
        {
            if (HitPoints <= 0)
            {
                HitPoints = 0;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game Over");
                message += " and died \n" + Get_NickName() + " lost the battle";
                
            }
            SetMessage(message);

        }

        

public int Get_Hp()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return HitPoints;
            

        }

        public int Get_Stamina()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return StaminaPoints;
        }
        public string Get_NickName()
        { 
            return NickName;
        }

        public string ChangeNickName()
        {
            Console.WriteLine("Write you nick name: ");
            NickName = Console.ReadLine();
            return NickName;
        }

        protected void SetMessage(string message)
        {
            this.message = message;
            
            
        }

        public string GetLastMessage()
        {
            
            
            return message;
            
        }
        
    }
        
       

}
    

