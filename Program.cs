using TetrisConsoleApp.Models;
using System;
using System.Threading;
using System.Diagnostics;

namespace TetrisConsoleApp
{
    public class Program
    {
        //settings
        private static readonly int _width = 10;
        private static readonly int _height = 20;

        //values
        private static int score = 0;
        private static int timer = 0; //czas do upuszczenia klocka nie moze byc wiekszy niz height

        //live figure values
        static int currX = 0;
        static int currY = 0;
        static int rotation = 0;

        //user input
        private static ConsoleKeyInfo input;
        //private static Thread inputThread = new Thread(Input);
        //inputThread.Start();

        static void Main()
        {
            Field gameField = new(_width, _height);

            //Game loop
            while (true)
            {
                Console.WriteLine("test");
            }
        }
    }
}
