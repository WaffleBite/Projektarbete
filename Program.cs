using System;

namespace Projektarbete
{
    class Program
    {
        static void Main(string[] args)
        {

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

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:

                        isRunning = false;

                        break;
                }
            }

        }
    }
}
