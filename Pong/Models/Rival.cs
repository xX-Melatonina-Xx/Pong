using System;

namespace Pong.Models
{
    class Rival
    {
        public static int rivalUpperY = 4;
        public static int rivalLowerY = 6;
        private static int randomPrecison;

        public static async Task ActAsBot()
        {
            Random rng = new();

            while (true)
            {
                if (Ball.xAxis > 14)
                {
                    randomPrecison = rng.Next(130, 175);
                    if (Ball.yAxis - 1 < rivalUpperY && rivalUpperY != 0)
                    {
                        rivalUpperY--;
                        rivalLowerY--;
                    }

                    if (Ball.yAxis - 1 > rivalUpperY && rivalUpperY != 8)
                    {
                        rivalUpperY++;
                        rivalLowerY++;
                    }

                    
                    await Task.Delay(rng.Next(randomPrecison));
                }
            }
        }
        public static void ActAsPlayer2(ConsoleKey action)
        {
            if (action == ConsoleKey.UpArrow && Rival.rivalUpperY != 0)
            {
                Rival.rivalUpperY--;
                Rival.rivalLowerY--;
            }

            if (action == ConsoleKey.DownArrow && Rival.rivalLowerY != 10)
            {
                Rival.rivalUpperY++;
                Rival.rivalLowerY++;
            }            
        }
    }
}
