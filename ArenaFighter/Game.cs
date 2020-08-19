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
            new Mage(1, 50, 200, 200, 25, 5, 5, 5, 5, "test");
            //choose class

            int selectedClass1 = ConsoleHelper.MultipleChoice(true, "Warrior", "Mage");

            if (selectedClass1 == 0)
            {
                first = new Warrior(1, 150, 200, 200, 25, 5, 5, "test");
            }
            else
            {
                first = new Mage(1, 50, 200, 200, 25, 5, 5, 5, 5, "test");
            }
            Console.WriteLine("Player1");
            first.ChangeNickName();
            
            
            int selectedClass2 = ConsoleHelper.MultipleChoice(true, "Warrior", "Mage");

            if (selectedClass2 == 0)
            {
                second = new Warrior(2, 150, 200, 200, 25, 5, 5, "test");
            }
            else
            {
                second = new Mage(2, 50, 200, 200, 25, 5, 5, 5, 5, "test");
            }

            Console.WriteLine( "Player2");
            second.ChangeNickName();
            
            Console.Clear();
            Arena arena = new Arena(first, second);
            arena.PlayArena();
        }
  
    }
}


    


