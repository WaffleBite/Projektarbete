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
            bool isValidCode = true;

            int securityCode = 1234;

            while (!isValidCode)
            {
                Console.WriteLine("Security code: ");

                if (securityCode == 1234)
                {
                    isValidCode = true;
                }
                else
                {
                    Console.WriteLine("Denied");
                }
            }
        }

        private static void ListAttacks()
        {
            throw new NotImplementedException();
        }

        private static void AddCoordinates()
        {
            bool isCorrect = false;
            do
            {
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


                Console.WriteLine("\nDo you want to add this target? [Y]es  [N]o");

                ConsoleKeyInfo keyPressed;

                bool isValidKey = false;

                do
                {
                    keyPressed = Console.ReadKey(true);

                    isValidKey = keyPressed.Key == ConsoleKey.J ||
                                 keyPressed.Key == ConsoleKey.N;

                } while (!isValidKey);

                if (keyPressed.Key == ConsoleKey.J)
                {
                    //lägg till i listan med targets (targetList)
                }
            } while (!isCorrect);

            Console.ReadKey();
        }
    }
}
