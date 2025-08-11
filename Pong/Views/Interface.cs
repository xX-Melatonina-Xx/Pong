using System;
using System.Collections.Generic;

namespace Pong.Views
{
    class Interface
    {                                                                                                                                                   
        public static List<string> interfaceLayer0 = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "|", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public static List<string> interfaceLayer1 = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public static List<string> interfaceLayer2 = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "|", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public static List<string> interfaceLayer3 = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public static List<string> interfaceLayer4 = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "|", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public static List<string> interfaceLayer5 = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " , " "};
        public static List<string> interfaceLayer6 = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "|", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public static List<string> interfaceLayer7 = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public static List<string> interfaceLayer8 = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "|", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public static List<string> interfaceLayer9 = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public static List<string> interfaceLayer10 = new List<string> { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "|", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };



        public static List<List<string>> Layers = new List<List<string>>
        {
            interfaceLayer0,
            interfaceLayer1,
            interfaceLayer2,
            interfaceLayer3,
            interfaceLayer4,
            interfaceLayer5,
            interfaceLayer6,
            interfaceLayer7,
            interfaceLayer8,
            interfaceLayer9,
            interfaceLayer10,
        };


        public static void DisplayGameArena(int scorePlayer, int scoreRival, string winner)
        {
            Console.WriteLine($"     {scorePlayer}                  {scoreRival}");
            Console.WriteLine("==============================");
                for (int i = 0; i < Layers.Count; i++)
                {
                    foreach (string pixel in Layers[i])
                    {
                        Console.Write(pixel);
                    }

                    Console.WriteLine();
                }
            Console.WriteLine("==============================");
            Console.WriteLine($"       {winner}");
        }


        public static void SelectGameMode()
        {
            Console.WriteLine();
            Console.WriteLine("   _____   ____  _   _  _____ ");
            Console.WriteLine("  |  __ \\ / __ \\| \\ | |/ ____|");
            Console.WriteLine("  | |__) | |  | |  \\| | |  __ ");
            Console.WriteLine("  |  ___/| |  | | . ` | | |_ |");
            Console.WriteLine("  | |    | |__| | |\\  | |__| |");
            Console.WriteLine("  |_|     \\____/|_| \\_|\\_____|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Wybierz tryb:");
            Console.WriteLine("1) gracz vs gracz (W/S UP/DOWN)");
            Console.WriteLine("2) gracz vs bot (W/S)");
        }
    }
}                           