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
            Console.Write("Choisissez une option:");
        }
    }
}
