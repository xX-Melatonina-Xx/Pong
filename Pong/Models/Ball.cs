using Pong.Controllers;
using System;
using System.Security.Cryptography;

namespace Pong.Models
{
    class Ball
    {
        public static int xAxis = 14;
        public static int yAxis = 5;
        public static int movementVectorX;
        public static int movementVectorY;

        public static int RandomVector()
        {
            Random rng = new();
            return rng.Next(0, 2) == 0 ? -1 : 1;
        }
        public static void MoveBall(int playerUpperY, int playerLowerY, int rivalUpperY, int rivalLowerY)
        {

            if ((xAxis == 1 && (yAxis >= playerUpperY && yAxis <= playerLowerY)) || (xAxis == 28 && (yAxis >= rivalUpperY && yAxis <= rivalLowerY)))
            {
                movementVectorX *= -1;
                Console.Beep(500, 30);
            }
            else if (xAxis == 0 || xAxis == 29)
            {
                movementVectorX = RandomVector();
                xAxis = 14;
                yAxis = 5;
            }

            if (yAxis == 0 || yAxis == 10)
            {
                movementVectorY *= -1;
                Console.Beep(500, 30);
            }

            xAxis += movementVectorX;
            yAxis += movementVectorY;            
        }
    }
}
