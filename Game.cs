using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Stone_Evan
{
    abstract class Game
    {
        //sets Esrb
        public string Esrb { get; set; }
        //sets Title 
        public string Title { get; set; }

        //sets up Game 
        public Game(string esrbParam, string titleParam)
        {
            Esrb = esrbParam;
            Title = titleParam;
        }

        //sets PlayGame
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting!");
        }
        //sets Describe
        public abstract string Describe();

    }
}
