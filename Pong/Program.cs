using Pong.Controllers;
using Pong.Models;
using Pong.Views;
using System;
using System.Threading;

namespace Pong
{
    class Program
    {
        static void Main()
        {   
            Console.SetWindowSize(33, 16);
            Console.SetBufferSize(33, 16);
            Console.Title = "Pong";
            Console.CursorVisible = false;
            
            Thread Gameloop = new Thread(() =>GameController.StartGame());
            Thread InputStream = new Thread(() => GameController.InputManager());

            InputStream.Start();
            Gameloop.Start();
        }
    }
}
