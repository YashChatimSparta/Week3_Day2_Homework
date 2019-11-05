﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to WarriorsX");

            Player player = new Player();
            Movement movement = new Movement();

            while (true)
            {
                Console.WriteLine("X: " + movement.positionX + " Y: " + movement.positionY + " Health: " + player.health);

                ConsoleKeyInfo enterKey = Console.ReadKey(true);

                if (enterKey.Key != ConsoleKey.Escape) 
                {

                    switch (enterKey.Key)
                    {
                        case ConsoleKey.Enter:
                            player.takeDamage();
                            break;

                        case ConsoleKey.W:
                            movement.jump();
                            break;

                        case ConsoleKey.S:
                            movement.duck();
                            break;

                        case ConsoleKey.D:
                            movement.moveRight();
                            break;

                        case ConsoleKey.A:
                            movement.moveLeft();
                            break;

                        case ConsoleKey.UpArrow:
                            movement.jump();
                            break;

                        case ConsoleKey.DownArrow:
                            movement.duck();
                            break;

                        case ConsoleKey.RightArrow:
                            movement.moveRight();
                            break;

                        case ConsoleKey.LeftArrow:
                            movement.moveLeft();
                            break;

                        default: 
                            try
                            {
                                int[] validKeys = { 13, 87, 83, 68, 65, 38, 40, 39, 37, 27 };

                                foreach (int i in validKeys)
                                {
                                    if ((int)enterKey.Key != i)
                                    {
                                        throw new InvalidUserKey();
                                    }
                                }
                            }

                            catch (InvalidUserKey)
                            {
                                Console.WriteLine("INVADLID KEY!!!! Please enter a valid key");
                                Console.WriteLine("Valid keys: W A S D UpArrow DownArrow RightArrow LeftArrow");
                            }
                            break;
                    }
                }
                
                if (enterKey.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Press Enter to quit");
                    break;
                }

                else if (player.health == 0)
                {
                    Console.WriteLine("Player's Health: " + player.health);
                    Console.WriteLine("Player dead");
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to restart");
                    Console.ReadLine();
                    player.health = 1000;
                }
            }

            Console.ReadLine();
        }
    }

    public class InvalidUserKey : Exception
    {
        public InvalidUserKey() { }
    }
}
