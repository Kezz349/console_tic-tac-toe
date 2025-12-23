using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
        public static bool CheckForPlayerWin(int playerNumber)
        {
            if (gameGrid[0, 0] == playerNumber && gameGrid[0, 1] == playerNumber && gameGrid[0, 2] == playerNumber)
            {
                return true;
            }
            else if (gameGrid[1, 0] == playerNumber && gameGrid[1, 1] == playerNumber && gameGrid[1, 2] == playerNumber)
            {
                return true;
            }
            else if (gameGrid[2, 0] == playerNumber && gameGrid[2, 1] == playerNumber && gameGrid[2, 2] == playerNumber)
            {
                return true;
            }
            else if (gameGrid[0, 0] == playerNumber && gameGrid[1, 0] == playerNumber && gameGrid[2, 0] == playerNumber)
            {
                return true;
            }
            else if (gameGrid[0, 1] == playerNumber && gameGrid[1, 1] == playerNumber && gameGrid[2, 1] == playerNumber)
            {
                return true;
            }
            else if (gameGrid[0, 2] == playerNumber && gameGrid[1, 2] == playerNumber && gameGrid[2, 2] == playerNumber)
            {
                return true;
            }
            else if (gameGrid[0, 0] == playerNumber && gameGrid[1, 1] == playerNumber && gameGrid[2, 2] == playerNumber)
            {
                return true;
            }
            else if (gameGrid[2, 0] == playerNumber && gameGrid[1, 1] == playerNumber && gameGrid[0, 2] == playerNumber)
            {
                return true;
            }
            else
            {
                return false;
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
        public static bool CheckForDraw()
        {
            for (int y = 0; y < gameGrid.GetLength(0); y++)
            {
                for (int x = 0; x < gameGrid.GetLength(1); x++)
                {
                    if (gameGrid[y, x] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static void SaveGame()
        {
            string gridContent = "";

            for (int y = 0; y < gameGrid.GetLength(0); y++)
            {
                for (int x = 0; x < gameGrid.GetLength(1); x++)
                {
                    gridContent += gameGrid[y, x];
                    if (y < gameGrid.GetLength(0) - 1 || x < gameGrid.GetLength(1) - 1)
                    {
                        gridContent += ",";
                    }
                }
            }

            File.WriteAllText("save.txt", $"{playerName1},{playerName2},{player1Score},{player2Score},{turnNumber}");
            File.AppendAllText("save.txt", $"\n{gridContent}");
        }
        public static void LoadGame()
        {
            string[] fullSavedContent = File.ReadAllLines("save.txt");

            string[] scoreNameContent = fullSavedContent[0].Split(',');
            playerName1 = scoreNameContent[0];
            playerName2 = scoreNameContent[1];
            player1Score = Convert.ToInt32(scoreNameContent[2]);
            player2Score = Convert.ToInt32(scoreNameContent[3]);
            turnNumber = Convert.ToInt32(scoreNameContent[4]);

            string[] stringGameGrid = fullSavedContent[1].Split(',');
            int counter = 0;
            for (int y = 0; y < gameGrid.GetLength(0); y++)
            {
                for (int x = 0; x < gameGrid.GetLength(1); x++)
                {
                    gameGrid[y, x] = Convert.ToInt32(stringGameGrid[counter]);
                    counter++;
                }
            }
        }
        public static void ResetInfo()
        {
            playerName1 = "";
            playerName2 = "";
            player1Score = 0;
            player2Score = 0;
            turnNumber = 1;
        }
        public static string ReadName()
        {
            while (true)
            {
                string name = Console.ReadLine()!;
                if (String.IsNullOrWhiteSpace(name))
                {
                    return name;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Veuillez inscrire un nom valide.");
                }
            }
        }
    }
}
