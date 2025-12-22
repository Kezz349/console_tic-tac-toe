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

        public static int[,] gameGrid =
        {
            {0, 0, 0},
            {0, 0, 0},
            {0, 0, 0}
        };
        public static int ReadNumber()
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine);
                    if (number >= 1 && number <= 9)
                    {
                        return number;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Veuillez écrire un entier valide entre 1 et 9.");
                }
            }
        }



    }
}
