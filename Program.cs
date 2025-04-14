using Inheritance_Stone_Evan;
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //program #
            Console.WriteLine("Program 14");

            //hFPS - houston's FPS, sets and writes hFPS
            FPS hFPS = new FPS("E", "ZombCube");
            Console.WriteLine(hFPS.Describe());
            hFPS.PlayGame();

            // sets and writes halo
            FPS halo = new FPS("T", "Halo:Infinite");
            Console.WriteLine(halo.Describe());
            halo.PlayGame();
        }
    }
}