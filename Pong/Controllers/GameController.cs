using Pong.Views;
using Pong.Models;
using System;

namespace Pong.Controllers
{
    class GameController
    {
        public static int scorePlayer = 0;
        public static int scoreRival = 0;
        public static ConsoleKey gamemode;

        public static void InputManager()
        {
            Interface.SelectGameMode();
            do
            {
                gamemode = Console.ReadKey(true).Key;

                switch (gamemode)
                {
                    case ConsoleKey.D1:
                        {
                            while (true)
                            {
                                ConsoleKey action = Console.ReadKey(true).Key;

                                if (action == ConsoleKey.W || action == ConsoleKey.S)
                                {
                                    Player.PlayerMovement(action);
                                }
                                else if (action == ConsoleKey.UpArrow || action == ConsoleKey.DownArrow)
                                {
                                    Rival.ActAsPlayer2(action);
                                }
                            }
                        }

                    case ConsoleKey.D2:
                        {
                            Thread rivalBot = new Thread(() => Rival.ActAsBot());
                            rivalBot.Start();
                            while (true)
                            {
                                Player.PlayerMovement(Console.ReadKey(true).Key);
                            }

                        }

                    default:
                        break;
                }
            } while (gamemode != ConsoleKey.D1 && gamemode != ConsoleKey.D2);
        }
        public static void UpdateBallPosition()
        {
            int oldBallX = Ball.xAxis;
            int oldBallY = Ball.yAxis;

            Ball.MoveBall(Player.playerUpperY, Player.playerLowerY, Rival.rivalUpperY, Rival.rivalLowerY);

            if (Ball.xAxis == 0)
            {
                scoreRival++;
            }
            else if (Ball.xAxis == 29)
            {
                scorePlayer++;
            }

            Interface.Layers[oldBallY][oldBallX] = " ";
            Interface.Layers[Ball.yAxis][Ball.xAxis] = "@";
        }

        public static void UpdateGoaliePositon(int UpperY, int LowerY, int side)
        {
            for(int i = 0; i < Interface.Layers.Count; i++)
            {
                if (i >= UpperY && i <= LowerY)
                {
                    if (side == 0)
                    {
                        Interface.Layers[i][0] = "]";
                    }
                    else
                    {
                        Interface.Layers[i][29] = "[";
                    }
                }
                else
                {
                    if (side == 0)
                    {
                        Interface.Layers[i][0] = " ";
                    }
                    else
                    {
                        Interface.Layers[i][29] = " ";
                    }
                }
            }
        }
        public static async Task StartGame()
        {
            while (gamemode != ConsoleKey.D1 && gamemode != ConsoleKey.D2)
            Ball.movementVectorX = Ball.RandomVector();
            Ball.movementVectorY = Ball.RandomVector();

            while (scorePlayer != 10 && scoreRival != 10 )
            {
                Console.Clear();
                UpdateGoaliePositon(Player.playerUpperY, Player.playerLowerY, 0);
                UpdateGoaliePositon(Rival.rivalUpperY, Rival.rivalLowerY, 1);
                UpdateBallPosition();
                Interface.DisplayGameArena(scorePlayer, scoreRival, "");
                
                await Task.Delay(55);
            }

            if(scorePlayer == 10)
            {
                Interface.DisplayGameArena(scorePlayer, scoreRival, "Gracz 1 wygrywa!");
            }
            else if (gamemode == ConsoleKey.D2)
            {
                Interface.DisplayGameArena(scorePlayer, scoreRival, "  Bot wygrywa!");
            }
            else
            {
                Interface.DisplayGameArena(scorePlayer, scoreRival, "Gracz 2 wygrywa!");
            }
        }
    }
}
