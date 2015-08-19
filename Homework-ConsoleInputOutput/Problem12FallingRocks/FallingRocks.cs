//Problem 12.** Falling Rocks
//Implement the "Falling Rocks" game in the text console.
//A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
//A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
//Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
//Ensure a constant game speed by Thread.Sleep(150).
//Implement collision detection and scoring system.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

struct Object
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor colour;
 }

class FallingRocks
{
    static int dwarfPositionX = 0;
    static int dwarfPositionY = 0;

    static void Main()
    {
        Console.Title = "Falling Rocks";
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
        dwarfPositionX = Console.WindowWidth / 2;
        dwarfPositionY = Console.WindowHeight - 1;
        int score = 0;

        Random rangomGen = new Random();
        char[] symbols = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
        ConsoleColor[] color = { ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue, 
                                   ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta,
                               ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green,
                               ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow};

        List<Object> rockList = new List<Object>();

        while (true)
        {
            {
                int indexOfNumberPerRow = rangomGen.Next(0, 5); // 0 to 4 symbols per row max

                for (int i = 0; i < indexOfNumberPerRow; i++)
                {
                    int indexOfcolor = rangomGen.Next(0, color.Length);
                    int indexOfRand = rangomGen.Next(0, symbols.Length);

                    Object rock = new Object();
                    rock.colour = color[indexOfcolor];
                    rock.x = rangomGen.Next(0, Console.WindowWidth);
                    rock.y = 0;
                    rock.c = symbols[indexOfRand];
                    rockList.Add(rock);
                }
            }

            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressKey = Console.ReadKey(true);

                if (pressKey.Key == ConsoleKey.LeftArrow)
                {
                    MoveDwarfLeft();
                }
                else if (pressKey.Key == ConsoleKey.RightArrow)
                {
                    MoveDwarfRight();
                }
            }

            List<Object> newList = new List<Object>();

            for (int i = 0; i < rockList.Count; i++)
            {
                Object oldRock = rockList[i];
                Object newRock = new Object();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.c = oldRock.c;
                newRock.colour = oldRock.colour;

                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
                else
                {
                    score++;
                }

                if ((newRock.x == dwarfPositionX && newRock.y == dwarfPositionY) ||
                    (newRock.x == (dwarfPositionX + 1) && newRock.y == dwarfPositionY) ||
                    (newRock.x == (dwarfPositionX + 2) && newRock.y == dwarfPositionY))
                {
                    PrintOnScreen(Console.WindowWidth / 2 - 4, Console.WindowHeight - 15, "GAME OVER", ConsoleColor.Red);
                    PrintOnScreen(Console.WindowWidth / 2 - 7, Console.WindowHeight - 14, "YOUR SCORE IS:", ConsoleColor.Red);
                    PrintScore(Console.WindowWidth / 2 - 7 + 15, Console.WindowHeight - 14, score, ConsoleColor.Blue);
                    PrintOnScreen(Console.WindowWidth / 2 - 9, Console.WindowHeight - 13, "Press [enter] to exit", ConsoleColor.Red);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            rockList = newList;
            Console.Clear();
            DwarfSymbol();

            foreach (Object rock in rockList)
            {
                Print(rock.x, rock.y, rock.c, rock.colour);
            }

            Thread.Sleep(150);
        }
    }

    static void MoveDwarfRight()
    {
        if (dwarfPositionX < Console.WindowWidth - 4)
        {
            dwarfPositionX++;
        }
    }

    private static void MoveDwarfLeft()
    {
        if (dwarfPositionX > 0)
        {
            dwarfPositionX--;
        }
    }

    private static void DwarfSymbol()
    {
        Print(dwarfPositionX, dwarfPositionY, '(', ConsoleColor.DarkGray);
        Print(dwarfPositionX + 1, dwarfPositionY, '0', ConsoleColor.DarkGray);
        Print(dwarfPositionX + 2, dwarfPositionY, ')', ConsoleColor.DarkGray);
    }

    static void Print(int x, int y, char c, ConsoleColor color = ConsoleColor.Blue)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);

    }

    static void PrintOnScreen(int x, int y, string c, ConsoleColor color = ConsoleColor.Blue)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void PrintScore(int x, int y, int c, ConsoleColor color = ConsoleColor.Blue)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
}
