using System;
using System.Collections.Generic;
using System.Text;

namespace Console_tic_tac_toe
{
    internal class Game
    {
        public static string playerName1 = "";
        public static string playerName2 = "";

        public static int player1Score = 0;
        public static int player2Score = 0;

        public static int turnNumber = 1;

        public static int[,] gameGrid =
        {
            {0, 0, 0},
            {0, 0, 0},
            {0, 0, 0}
        };
        public static void PlacePlayer(int input, int playerTurn)
        {
            switch (input)
            {
                case 1:
                    gameGrid[0, 0] = playerTurn;
                    turnNumber++;
                    break;
                case 2:
                    gameGrid[0, 1] = playerTurn;
                    turnNumber++;
                    break;
                case 3:
                    gameGrid[0, 2] = playerTurn;
                    turnNumber++;
                    break;
                case 4:
                    gameGrid[1, 0] = playerTurn;
                    turnNumber++;
                    break;
                case 5:
                    gameGrid[1, 1] = playerTurn;
                    turnNumber++;
                    break;
                case 6:
                    gameGrid[1, 2] = playerTurn;
                    turnNumber++;
                    break;
                case 7:
                    gameGrid[2, 0] = playerTurn;
                    turnNumber++;
                    break;
                case 8:
                    gameGrid[2, 1] = playerTurn;
                    turnNumber++;
                    break;
                case 9:
                    gameGrid[2, 2] = playerTurn;
                    turnNumber++;
                    break;
                default:
                    break;
            }
        }
        public static int DecidePlayerTurn(int turnNumber)
        {
            if (turnNumber % 2 == 0)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
    }
}
