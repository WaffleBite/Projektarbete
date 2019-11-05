using Projektarbete.Data;
using Projektarbete.Domain.Models;
using System;
using System.Collections.Generic;

namespace Projektarbete
{
    class Program
    {
        static ProjektarbeteContext context = new ProjektarbeteContext();

        static void Main(string[] args)
        {
            List<Target> targetList = new List<Target>();

            Console.ForegroundColor = ConsoleColor.Cyan;

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("1. Add coordinates");
                Console.WriteLine("2. List attacks");
                Console.WriteLine("3. The big red button");
                Console.WriteLine("4. Exit");

                ConsoleKeyInfo keyPressed = Console.ReadKey(true);

                Console.Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        AddCoordinates();

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        ListAttacks();

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        Fire();

                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:

                        isRunning = false;

                        break;
                }
            }
        }

        private static void Fire()
        {
            bool isValidCode = false;

            

            while (!isValidCode)
            {
                Console.Clear();
                Console.WriteLine("Security code: ");
                int securityCode = int.Parse(Console.ReadLine());
                if (securityCode == 1234)
                {
                    isValidCode = true;
                    foreach (var target in context.Target)
                    {
                        Console.Clear();
                        Console.WriteLine("Attacking targets:")
                        target.TryAttack();
                        string result = target.IsDestroyed == true ? "Träff" : "Miss";

                        Console.WriteLine($"{target.Name}\tStatus: {result}");

                    }
                    context.SaveChanges();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Denied");
                    Console.ReadKey();
                }
                if (isValidCode) 
                {
           
                }
            }
        }

        private static void ListAttacks()
        {
            Console.Clear();
            foreach (var target in context.Target)
            {
                if (target == null) continue;
                Console.WriteLine($"{target.Name}\t{target.Description}\t\t{target.XCoordinate}.{target.YCoordinate}.{target.ZCoordinate}");
            }
            Console.ReadKey();
        }

        private static void AddCoordinates()
        {
            bool isCorrect = false;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("Name of the missile: ");

                Console.SetCursorPosition(3, 2);
                Console.WriteLine("Description: ");

                Console.SetCursorPosition(3, 4);
                Console.WriteLine("Please type in the coordinates here");

                Console.SetCursorPosition(4, 6);
                Console.WriteLine("X: ");

                Console.SetCursorPosition(4, 7);
                Console.WriteLine("Y: ");

                Console.SetCursorPosition(4, 8);
                Console.WriteLine("Z: ");

                Console.SetCursorPosition("Name of the missile: ".Length + 3, 1);
                string name = Console.ReadLine();

                Console.SetCursorPosition("Description: ".Length + 3, 2);
                string description = Console.ReadLine();

                Console.SetCursorPosition("X: ".Length + 4, 6);
                int xCoordinate = int.Parse(Console.ReadLine());

                Console.SetCursorPosition("Y: ".Length + 4, 7);
                int yCoordinate = int.Parse(Console.ReadLine());

                Console.SetCursorPosition("Z: ".Length + 4, 8);
                int zCoordinate = int.Parse(Console.ReadLine());

                Target newtarget = new Target(name, description, xCoordinate, yCoordinate, zCoordinate);
                Console.WriteLine("\nDo you want to add this target? [Y]es  [N]o");

                ConsoleKeyInfo keyPressed;

                bool isValidKey = false;

                do
                {
                    keyPressed = Console.ReadKey(true);

                    isValidKey = keyPressed.Key == ConsoleKey.J ||
                                 keyPressed.Key == ConsoleKey.N || 
                                 keyPressed.Key == ConsoleKey.Y;

                } while (!isValidKey);

                if (keyPressed.Key == ConsoleKey.J)
                {
                    context.Target.Add(newtarget);
                    context.SaveChanges();
                    isCorrect = true;
                }
                else if(keyPressed.Key == ConsoleKey.Y) 
                {
                    context.Target.Add(newtarget);
                    context.SaveChanges();
                    isCorrect = true;
                }
            } while (!isCorrect);

                   }
    }
}
