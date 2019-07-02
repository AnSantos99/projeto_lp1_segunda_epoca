using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialise new GameLoop to run the application
            GameLoop loop = new GameLoop();

            // call the Loop function to begin new game loop
            loop.Loop();
        }
    }
}
