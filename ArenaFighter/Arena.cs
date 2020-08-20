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
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Round: " + Round);
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
            Console.ResetColor();

            Console.Write(first.Get_NickName() + " have ");
            Console.WriteLine(first.Get_Mana() + " mana ");
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

            Console.Write(second.Get_NickName() + " have ");
            Console.WriteLine(second.Get_Mana() + " mana ");
            Console.WriteLine("");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadKey();
        }

        private void PrintMesseage(string message)
        {
            Console.WriteLine(message);
        }
        public void PlayArena()
        {
            Player p1 = first;
            Player p2 = second;
            int firstMove = 0;

            int die1 = 0;
            int die2 = 0;


            while (firstMove == 0)
            {
                die1 = RandomNumberGenerator.NumberBetween(1, 6);
                die2 = RandomNumberGenerator.NumberBetween(1, 6);
                Console.WriteLine(p1.Get_NickName() + " rolled: " + die1);
                Console.WriteLine(p2.Get_NickName() + " rolled: " + die2);
                if (die1 > die2)
                {

                    Console.WriteLine();
                    Console.WriteLine("Player1 goes first");
                    firstMove = 1;
                }
                if (die1 < die2)
                {

                    Console.WriteLine();
                    Console.WriteLine("Player2 goes first");
                    firstMove = 2;

                }
                if (die1 == die2)
                {
                    Console.WriteLine("Both players rolled same number. Press Enter to roll again.");
                    die1 = RandomNumberGenerator.NumberBetween(1, 6);
                    die2 = RandomNumberGenerator.NumberBetween(1, 6);
                    Console.ReadKey();
                }


            }
            Console.WriteLine("Ready, Set...Fight!");
            Render();
            Console.Clear();



            while (p1.Alive() && p2.Alive()) //player1 have first move
            {
                
                if (p1.Alive() && firstMove == 1)
                {
                    
                    //Console.WriteLine(p1.Get_NickName() + "Chose your action: ");
                    //Task.Delay(2000);
                    
                    if (p1.Get_ID() == 2)
                    {
                        int currentAction = ConsoleHelper.ChooseAction(true, "Basic Attack(25-100dmg and -10 stamina)", "Fire Ball(200-1000dmg and -60 mana)" , "Rest and skip a turn");
                        if (currentAction == 0)
                        {
                            p1.BasicAttack(p2); //player1 attack player1
                        }
                        if (currentAction == 1)
                        {
                            p1.FireBall(p2);//player2 use skill on player1
                        }
                        if (currentAction == 2)
                        {
                            p1.Rest();
                            PrintMesseage(p1.GetLastMessage());
                        }
                        Round++;
                        Render();
                    }
                    else
                    {
                        int currentAction = ConsoleHelper.ChooseAction(true, "Basic Attack(25-100dmg and -10 stamina)", "Tripple Swing(200-600dmg and -60 mana)", "Rest and skip a turn");


                        if (currentAction == 0)
                        {
                            p1.BasicAttack(p2); //player1 attack player2
                        }
                        if (currentAction == 1)
                        {
                            p1.FireBall(p2);//player2 use skill on player1
                        }
                        if (currentAction == 2)
                        {
                            p1.Rest();
                            PrintMesseage(p1.GetLastMessage());
                        }
                        Round++;
                        Render();
                    }
                    
                    firstMove = 2;
                }


                if (p2.Alive() && firstMove == 2)
                {
                    
                    //Console.WriteLine(p1.Get_NickName() + "Chose your action: ");
                    //Task.Delay(800);

                    
                    if(p2.Get_ID() == 4)
                    {
                        int currentAction = ConsoleHelper.ChooseAction(true, "Basic Attack(25-100dmg and -10 stamina)", "Fire Ball(400-1000dmg and -60 mana )", "Rest and skip a turn");
                        if (currentAction == 0)
                        {
                            p2.BasicAttack(p1); //player1 attack player1
                        }
                        if (currentAction == 1)
                        {
                            p2.FireBall(p1);//player2 use skill on player1
                        }
                        if (currentAction == 2)
                        {
                            p2.Rest();
                            PrintMesseage(p2.GetLastMessage());
                        }
                        Round++;
                        Render();
                    }else
                    {
                        int currentAction = ConsoleHelper.ChooseAction(true, "Basic Attack(25-100dmg and -10 stamina)", "Tripple Swing(200-600dmg and -60 mana)" ,"Rest and skip a turn");


                        if (currentAction == 0)
                        {
                            p2.BasicAttack(p1); //player1 attack player2
                        }
                        if (currentAction == 1)
                        {
                            p2.FireBall(p1);//player2 use skill on player1
                        }
                        if (currentAction == 2)
                        {
                            p2.Rest();
                            PrintMesseage(p2.GetLastMessage());
                        }
                        Round++;
                        Render();
                        
                    }
                    
                    firstMove = 1;
                }
                if (p1.Get_Hp() < 0)
                {
                    p1.Dead();
                    PrintMesseage(p1.GetLastMessage());
                    Console.ResetColor();
                }
                if (p2.Get_Hp() < 0)
                {
                    p2.Dead();
                    PrintMesseage(p2.GetLastMessage());
                    Console.ResetColor();
                }
                

                
            }
            
            


        }

    }
}

        //public void PlayArena()
        //{

        //    Player p1 = first;
        //    Player p2 = second;

        //    Console.WriteLine();
        //    Render();
        //    while (p1.Alive() && p2.Alive())
        //    {
        //        p1.BasicAttack(p2); //player1 attack player2
        //        Round++;
        //        Render();
                
        //        if (p1.Get_Hp() < 0)
        //        {
        //            p1.Dead();
        //            PrintMesseage(p1.GetLastMessage());
        //            Console.ResetColor();
        //        }
                
        //        Console.Clear();
        //        if (p2.Alive())
        //        {
        //            p2.BasicAttack(p1);//player2 attack player1
        //            Round++;
        //            Render();

        //        }
                
        //        Console.Clear();
        //        if(p2.Get_Hp() < 0)
        //        {
        //            p2.Dead();
        //            PrintMesseage(p2.GetLastMessage());
        //        }
                
        //    }
        //    Console.ReadLine();
            

        //    Console.WriteLine("Do you want to restart the game? Y=Yes , N=No");
        //    string reset = Console.ReadLine();
        //    switch (reset)
        //    {
        //        case "Y":
        //            System.Diagnostics.Process.Start(Environment.GetCommandLineArgs()[0], Environment.GetCommandLineArgs().Length > 1 ? string.Join(" ", Environment.GetCommandLineArgs().Skip(1)) : null);
        //            break;

        //        case "N":
        //            break;

        //        default:
        //            Console.WriteLine(" You did not type Y or N");
        //            Console.WriteLine();
        //            Console.ReadLine();
        //            break;
        //    }
        //}



