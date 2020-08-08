using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

namespace ArenaFighter
{
    class Program
    {

        static void Main(string[] args)
        {
            Game My_game = new Game();
            My_game.PlayGame();

        }
    }
    public class Game
    {

        private List<Player> player_list = new List<Player>();



        public void PlayGame()
        {

            player_list.Add(new Player());
             


            Console.WriteLine("\n\n Welcome to the dartgame! \n" +
                          "\n Game Rules: Each player throws 3 darts at a time." +
                          "\n Every throw can be worth 0-20 points." +
                          "\n Whoever gets 301 points first is the winner!");

        Console.WriteLine("\nPlayers:");

        foreach (var players in player_list)
        {
            Console.WriteLine(players);
        }
            Console.ReadKey();
        }
    }
}

