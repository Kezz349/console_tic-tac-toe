using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
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
            if (input == 7 && gameGrid[0, 0] == 0)
            {
                gameGrid[0, 0] = playerTurn;
                turnNumber++;
            }
            else if (input == 8 && gameGrid[0, 1] == 0)
            {
                gameGrid[0, 1] = playerTurn;
                turnNumber++;
            }
            else if (input == 9 && gameGrid[0, 2] == 0)
            {
                gameGrid[0, 2] = playerTurn;
                turnNumber++;
            }
            else if (input == 4 && gameGrid[1, 0] == 0)
            {
                gameGrid[1, 0] = playerTurn;
                turnNumber++;
            }
            else if (input == 5 && gameGrid[1, 1] == 0)
            {
                gameGrid[1, 1] = playerTurn;
                turnNumber++;
            }
            else if (input == 6 && gameGrid[1, 2] == 0)
            {
                gameGrid[1, 2] = playerTurn;
                turnNumber++;
            }
            else if (input == 1 && gameGrid[2, 0] == 0)
            {
                gameGrid[2, 0] = playerTurn;
                turnNumber++;
            }
            else if (input == 2 && gameGrid[2, 1] == 0)
            {
                gameGrid[2, 1] = playerTurn;
                turnNumber++;
            }
            else if (input == 3 && gameGrid[2, 2] == 0)
            {
                gameGrid[2, 2] = playerTurn;
                turnNumber++;
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
        public static void CheckForPlayerWin(int playerNumber)
        {
            if (gameGrid[0, 0] == playerNumber && gameGrid[0, 1] == playerNumber && gameGrid[0, 2] == playerNumber)
            {
                PlayerWin(playerNumber);
            }
            else if (gameGrid[1, 0] == playerNumber && gameGrid[1, 1] == playerNumber && gameGrid[1, 2] == playerNumber)
            {
                PlayerWin(playerNumber);
            }
            else if (gameGrid[2, 0] == playerNumber && gameGrid[2, 1] == playerNumber && gameGrid[2, 2] == playerNumber)
            {
                PlayerWin(playerNumber);
            }
            else if (gameGrid[0, 0] == playerNumber && gameGrid[1, 0] == playerNumber && gameGrid[2, 0] == playerNumber)
            {
                PlayerWin(playerNumber);
            }
            else if (gameGrid[0, 1] == playerNumber && gameGrid[1, 1] == playerNumber && gameGrid[2, 1] == playerNumber)
            {
                PlayerWin(playerNumber);
            }
            else if (gameGrid[0, 2] == playerNumber && gameGrid[1, 2] == playerNumber && gameGrid[2, 2] == playerNumber)
            {
                PlayerWin(playerNumber);
            }
            else if (gameGrid[0, 0] == playerNumber && gameGrid[1, 1] == playerNumber && gameGrid[2, 2] == playerNumber)
            {
                PlayerWin(playerNumber);
            }
            else if (gameGrid[2, 0] == playerNumber && gameGrid[1, 1] == playerNumber && gameGrid[0, 2] == playerNumber)
            {
                PlayerWin(playerNumber);
            }
        } 
        public static void PlayerWin(int playerNumber)
        {
            if (playerNumber == 1)
            {
                player1Score++;
                ResetGrid();
                View.ShowWinGame(playerNumber);
            }
            else if (playerNumber == 2)
            {
                player2Score++;
                ResetGrid();
                View.ShowWinGame(playerNumber);
            }
        }
        public static void ResetGrid()
        {
            for (int y = 0; y < gameGrid.GetLength(0); y++)
            {
                for (int x = 0; x < gameGrid.GetLength(1); x++)
                {
                    gameGrid[y, x] = 0;
                }
            }
        }
        public static void CheckForDraw()
        {

        }
    }
}
