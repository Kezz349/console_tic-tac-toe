using System;
using System.Collections.Generic;
using System.Text;

namespace Console_tic_tac_toe
{
    internal class Controller
    {
        public static void MenuController()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                View.ShowMainMenu();
                string menuInput = Console.ReadLine();
                switch (menuInput)
                {
                    case "1":
                        Controller.GameController();
                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        View.ShowInvalidOption();
                        break;
                }
            }
        }
        public static void GameController()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                View.ShowInfo();
                View.ShowGrid();

                ConsoleKeyInfo input = Console.ReadKey();

                switch (input.Key)
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

                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:

                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:

                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:

                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:

                        break;
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:

                        break;
                    case ConsoleKey.Escape:
                        exit = true;
                        break;
                    default:
                        break;


                }
        }
    }
}
