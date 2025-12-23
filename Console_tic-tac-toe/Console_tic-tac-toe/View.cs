using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
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
            Console.WriteLine("║ 4. Réinitialiser la partie            ║");
            Console.WriteLine("║ 5. Quitter                            ║");
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
            Console.WriteLine("Jeu en cours - Pesez sur Escape pour quitter");

            Console.Write($"Joueur 1 : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{Game.playerName1, -25}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" | Score : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{Game.player1Score, -2}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" | Pose des ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("X");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            Console.Write($"Joueur 2 : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{Game.playerName2, -25}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" | Score : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{Game.player2Score, -2}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" | Pose des ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("O");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            Console.WriteLine("Cadrillage avec les options de placement :");
            Console.WriteLine("╔═╦═╦═╗");
            Console.WriteLine("║7║8║9║");
            Console.WriteLine("╠═╬═╬═╣");
            Console.WriteLine("║4║5║6║");
            Console.WriteLine("╠═╬═╬═╣");
            Console.WriteLine("║1║2║3║");
            Console.WriteLine("╚═╩═╩═╝");
            Console.WriteLine("Veuillez entrez le chiffre qui correspond à où vous voulez placer votre X ou votre O");
            Console.ResetColor();
            if (Game.DecidePlayerTurn(Game.turnNumber) == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Tour de : ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Game.playerName1);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Placement de ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("X");
                Console.WriteLine();
                Console.ResetColor();
            }
            else if (Game.DecidePlayerTurn(Game.turnNumber) == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Tour de : ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(Game.playerName2);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Placement de ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("O");
                Console.WriteLine();
                Console.ResetColor();
            }
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
            Console.WriteLine();
            
            Console.WriteLine("╠═╬═╬═╣");
            
            Console.Write("║");
            ShowPlayer(Game.gameGrid, 1, 0);
            Console.Write("║");
            ShowPlayer(Game.gameGrid, 1, 1);
            Console.Write("║");
            ShowPlayer(Game.gameGrid, 1, 2);
            Console.Write("║");
            Console.WriteLine();

            Console.WriteLine("╠═╬═╬═╣");
            
            Console.Write("║");
            ShowPlayer(Game.gameGrid, 2, 0);
            Console.Write("║");
            ShowPlayer(Game.gameGrid, 2, 1);
            Console.Write("║");
            ShowPlayer(Game.gameGrid, 2, 2);
            Console.Write("║");
            Console.WriteLine();

            Console.WriteLine("╚═╩═╩═╝");
        }
        public static void ChoosePlayerNames()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Veuillez inscire le nom du joueur 1 :");
            Game.playerName1 = Game.ReadName();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Veuillez inscire le nom du joueur 2 :");
            Game.playerName2 = Game.ReadName();
            Console.ResetColor();
        }
        public static void ShowWinGame(int playerNumber)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (playerNumber == 1)
            {
                Console.Write($"Bravo! ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Game.playerName1);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($" a gagné la partie. Son total de point(s) est maintenant de {Game.player1Score} point(s)");
            }
            else if (playerNumber == 2)
            {
                Console.Write($"Bravo! ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(Game.playerName2);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($" a gagné la partie. Son total de point(s) est maintenant de {Game.player2Score} point(s)");
            }
            Console.WriteLine("Pesez sur un bouton pour recommencer une nouvelle partie.");
            Console.ResetColor();
            Console.ReadKey();
        }
        public static void ShowLoadGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Votre partie à été chargé avec succès!");
            Thread.Sleep(3000);
        }
        public static void ShowSaveGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Votre partie à été sauvegardé avec succès!");
            Thread.Sleep(3000);
        }
        public static void ShowResetGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Votre partie a été réinitialisé avec succès!");
            Thread.Sleep(3000);
        }
        public static void LoadGameError()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Vous n'avez pas de partie à charger, veuillez jouer en premier.");
            Console.ResetColor();
            Thread.Sleep(3000);
        }
    }
}
