using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter
{

    public class Arena
    {
       private Player first;
       private Player second;
       int Round;
        public Arena(Player first, Player second)
        {
             this.first = first;
             this.second = second;


        }



        private void Render()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Round: " +Round);
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Player1:");
            Console.ResetColor();

            Console.Write(first.Get_NickName() + " have ");
            Console.WriteLine(first.Get_Hp() + " HP");
            Console.ResetColor();

            Console.Write(first.Get_NickName() + " have ");
            Console.WriteLine(first.Get_Stamina() + " stamina ");
            Console.WriteLine("");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Player2:");
            Console.ResetColor();

            Console.Write(second.Get_NickName() + " have ");
            Console.WriteLine(second.Get_Hp() + " HP");
            Console.ResetColor();

            Console.Write(second.Get_NickName() + " have ");
            Console.WriteLine(second.Get_Stamina() + " stamina");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

        private void PrintMesseage(string message)
        {
            Console.WriteLine(message);
        }


        public void PlayArena()
        {

            Player p1 = first;
            Player p2 = second;

            Console.WriteLine();
            Render();
            while (p1.Alive() && p2.Alive())
            {
                
                
                

                p1.BasicAttack(p2); //player1 attack player2
                Round++;
                Render();
                
                if (p1.Get_Hp() < 0)
                {
                    p1.Dead();
                    PrintMesseage(p1.GetLastMessage());
                    Console.ResetColor();
                }
                
                if (p2.Alive())
                {
                    
                    p2.BasicAttack(p1);//player2 attack player1
                    Round++;
                    Render();
                    

                }
                if(p2.Get_Hp() < 0)
                {
                    p2.Dead();
                    PrintMesseage(p2.GetLastMessage());
                }
                
            }
            Console.ReadLine();
            
            Console.WriteLine("Do you want to restart the game? Y=Yes , N=No");
            string reset = Console.ReadLine();
            switch (reset)
            {
                case "Y":
                    System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0], Environment.GetCommandLineArgs().Length > 1 ? string.Join(" ", Environment.GetCommandLineArgs().Skip(1)) : null);
                    break;

                case "N":
                    
                    break;

                default:
                    Console.WriteLine(" You did not type Y or N");
                    Console.WriteLine();
                    Console.ReadLine();
                    break;

            }
}

            



        }
    }

