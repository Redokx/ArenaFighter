using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class ConsoleHelper
    {
        public static int MultipleChoice(bool canCancel, params string[] options)
        {
            const int startX = 5;
            const int startY = 5;
            const int optionsPerLine = 3;
            const int spacingPerLine = 14;

            int currentSelection = 0;

            ConsoleKey key;

            Console.CursorVisible = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Choose your class:");
                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);

                    if (i == currentSelection)
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(options[i]);

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (currentSelection % optionsPerLine > 0)
                                currentSelection--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (currentSelection % optionsPerLine < optionsPerLine - 2)
                                currentSelection++;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            if (canCancel)
                                return -1;
                            break;
                        }
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;
            Console.Clear();
            return currentSelection;
        }
        public static int ChooseAction(bool canCancel, params string[] options)
        {
            
            const int startX = 5;
            const int startY = 5;
            const int optionsPerLine = 50;
            const int spacingPerLine = 50;

            int currentAction = 0;

            ConsoleKey key;

            Console.CursorVisible = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Choose your action: ");
                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);
                    
                    if (i == currentAction)
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(options[i]);
                    
                    Console.ResetColor();
                }
                
                key = Console.ReadKey(true).Key;
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (currentAction % optionsPerLine > 0)
                                currentAction--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (currentAction % optionsPerLine < optionsPerLine - 3)
                                currentAction++;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            if (canCancel)
                                return -1;
                            break;
                        }
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;
            Console.Clear();
            return currentAction;
        }
    }
}
