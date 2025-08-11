using System;

namespace Pong.Models
{
    class Player
    {
        public static int playerUpperY = 4;
        public static int playerLowerY = 6;
        public static void PlayerMovement(ConsoleKey action)
        {
                if (action == ConsoleKey.W && Player.playerUpperY != 0)
                {
                    Player.playerUpperY--;
                    Player.playerLowerY--;
                }

                if (action == ConsoleKey.S && Player.playerLowerY != 10)
                {
                    Player.playerUpperY++;
                    Player.playerLowerY++;
                }
            
        }
    }
}
