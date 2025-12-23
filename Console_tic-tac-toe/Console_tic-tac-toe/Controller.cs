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
                        try
                        {
                            Game.LoadGame();
                            View.ShowLoadGame();
                        }
                        catch (Exception)
                        {
                            View.LoadGameError();
                        }
                        break;
                    case "3":
                        Game.SaveGame();
                        View.ShowSaveGame();
                        break;
                    case "4":
                        Game.ResetGrid();
                        Game.ResetInfo();
                        View.ShowResetGame();
                        break;
                    case "5":
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

                int playerTurn = Game.DecidePlayerTurn(Game.turnNumber);
                
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Game.PlacePlayer(1, playerTurn);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Game.PlacePlayer(2, playerTurn);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Game.PlacePlayer(3, playerTurn);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Game.PlacePlayer(4, playerTurn);
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Game.PlacePlayer(5, playerTurn);
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Game.PlacePlayer(6, playerTurn);
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        Game.PlacePlayer(7, playerTurn);
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        Game.PlacePlayer(8, playerTurn);
                        break;
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        Game.PlacePlayer(9, playerTurn);
                        break;
                    case ConsoleKey.Escape:
                        exit = true;
                        break;
                    default:
                        break;
                }
                if (Game.CheckForPlayerWin(1))
                {
                    Game.player1Score++;
                    Game.ResetGrid();
                    View.ShowWinGame(1);
                }
                else if (Game.CheckForPlayerWin(2))
                {
                    Game.player2Score++;
                    Game.ResetGrid();
                    View.ShowWinGame(2);
                }
                else if (Game.CheckForDraw())
                {
                    Game.ResetGrid();
                }
            }
        }
    }
}
