using System;
using System.Collections.Generic;
using System.Text;

namespace Console_tic_tac_toe
{
    internal class View
    {
        public static void ShowMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔═══════════════════════════════════════╗");
            Console.WriteLine("║             Menu Principal            ║");
            Console.WriteLine("╠═══════════════════════════════════════╣");
            Console.WriteLine("║ 1. Jouer                              ║");
            Console.WriteLine("║ 2. Charger les scores et les noms     ║");
            Console.WriteLine("║ 3. Sauvegarder les scores et les noms ║");
            Console.WriteLine("║ 4. Quitter                            ║");
            Console.WriteLine("╚═══════════════════════════════════════╝");
            Console.WriteLine("Choisissez une option:");
            Console.ResetColor();
        }
        public static void ShowInvalidOption()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Option invalide. Veuillez réessayer");
            Thread.Sleep(3000);       
        }
        public static void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Jeu en cours...");
            Console.WriteLine($"Joueur 1 : {Game.playerName1} Score : {Game.player1Score} (Fait des X)");
            Console.WriteLine($"Joueur 2 : {Game.playerName2} Score : {Game.player2Score} (Fait des O)");
            Console.WriteLine();
            Console.WriteLine("Veuillez entrez le chiffre qui correspond à où vous voulez placer votre X ou votre O");
            Console.WriteLine("╔═╦═╦═╗");
            Console.WriteLine("║1║2║3║");
            Console.WriteLine("╠═╬═╬═║");
            Console.WriteLine("║4║5║6║");
            Console.WriteLine("╠═╬═╬═║");
            Console.WriteLine("║7║8║9║");
            Console.WriteLine("╚═╩═╩═╝");
            Console.WriteLine("Pesez sur Escape pour quitter");
            Console.ResetColor();
        }
        public static void ShowPlayer(int[,] gameGrid, int yPosition, int xPosition)
        {
            if (gameGrid[yPosition, xPosition] == 0)
            {
                Console.Write(" ");
            }
            else if (gameGrid[yPosition, xPosition] == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("X");
                Console.ResetColor();
            }
            else if (gameGrid[yPosition, xPosition] == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("O");
                Console.ResetColor();
            }
        }
        public static void ShowGrid()
        {
            Console.WriteLine("╔═╦═╦═╗");
            
            Console.Write("║");
            ShowPlayer(Game.gameGrid, 0, 0);
            Console.Write("║");
            ShowPlayer(Game.gameGrid, 0, 1);
            Console.Write("║");
            ShowPlayer(Game.gameGrid, 0, 2);
            Console.Write("║");
            
            Console.WriteLine("╠═╬═╬═║");
            
            Console.Write("║");
            ShowPlayer(Game.gameGrid, 1, 0);
            Console.Write("║");
            ShowPlayer(Game.gameGrid, 1, 1);
            Console.Write("║");
            ShowPlayer(Game.gameGrid, 1, 2);
            Console.Write("║");
            
            Console.WriteLine("╠═╬═╬═║");
            
            Console.Write("║");
            ShowPlayer(Game.gameGrid, 2, 0);
            Console.Write("║");
            ShowPlayer(Game.gameGrid, 2, 1);
            Console.Write("║");
            ShowPlayer(Game.gameGrid, 2, 2);
            Console.Write("║");
            
            Console.WriteLine("╚═╩═╩═╝");
        }
    }
}
