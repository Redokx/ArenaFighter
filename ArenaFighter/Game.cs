using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

namespace ArenaFighter
{
    public class Game
    {
        public static void Main(string[] args)
        {
            Player first;
            Player second;
            
            //choose class
            int selectedClass1 = ConsoleHelper.MultipleChoice(true, "Warrior", "Mage");
            if (selectedClass1 == 0)
            {
                first = new Warrior(1, 5000, 5000, 100, 100, 100, 100, 0, 0, "test");
            }
            else
            {
                first = new Mage(2, 2000, 2000, 100, 100, 100, 5, 0, 0, "test");
            }
            Console.WriteLine("Player1");
            first.ChangeNickName();
            
            
            int selectedClass2 = ConsoleHelper.MultipleChoice(true, "Warrior", "Mage");

            if (selectedClass2 == 0)
            {
                second = new Warrior(3, 5000, 5000, 100, 100, 100, 100, 0, 0, "test");
            }
            else
            {
                second = new Mage(4, 2000, 2000, 100, 100, 100, 5, 0, 0, "test");
            }

            Console.WriteLine( "Player2");
            second.ChangeNickName();
            
            Console.Clear();
            Arena arena = new Arena(first, second);
            arena.PlayArena();
        }
  
    }
}


    


