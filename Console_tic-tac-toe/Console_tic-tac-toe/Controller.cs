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
                
            }
        }
    }
}
