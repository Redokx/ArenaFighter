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
    }
public class Game
{
     
    private List<Player> player_list = new List<Player>();


    
public void PlayGame()
        {
        
        Console.WriteLine("Gracz1:"+"Wybierz swoją klasę postaci \n 1.Warrior \n 2.Mage");
        int klasa1 = int.Parse(Console.ReadLine());
        
        if (klasa1 ==1)
        {
            player_list.Add(new Warrior());
            
            
        }
        else
        {
            player_list.Add(new Mage() );
        }

        
        Console.WriteLine("Gracz2:" + "Wybierz swoją klasę postaci \n 1.Warrior \n 2.Mage");
        int klasa2 = int.Parse(Console.ReadLine());
        if (klasa2 == 1)
        {
            player_list.Add(new Warrior());
        }
        else
        {
            player_list.Add(new Mage());
        }
        

        
        player_list.Add(new Player { });
            player_list.Add(new Player { });
            player_list.Add(new Player { });



        Console.WriteLine();

        Console.WriteLine("\nPlayers:");

        foreach (var players in player_list)
        {
            Console.WriteLine(players);
        }
            Console.ReadKey();
        }
    }


