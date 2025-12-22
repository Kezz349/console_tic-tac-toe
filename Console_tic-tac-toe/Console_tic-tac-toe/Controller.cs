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
            if (Game.playerName1 == "" || Game.playerName2 == "")
            {
                View.ChoosePlayerNames();
            }
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                View.ShowInfo();
                View.ShowGrid();

                int playeyTurn = Game.DecidePlayerTurn(Game.turnNumber);
                
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Game.PlacePlayer(1, playeyTurn);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Game.PlacePlayer(2, playeyTurn);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Game.PlacePlayer(3, playeyTurn);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Game.PlacePlayer(4, playeyTurn);
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Game.PlacePlayer(5, playeyTurn);
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Game.PlacePlayer(6, playeyTurn);
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        Game.PlacePlayer(7, playeyTurn);
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        Game.PlacePlayer(8, playeyTurn);
                        break;
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        Game.PlacePlayer(9, playeyTurn);
                        break;
                    case ConsoleKey.Escape:
                        exit = true;
                        break;
                    default:
                        break;
                }
                Game.CheckForEndGame();
            }
        }
    }
}
