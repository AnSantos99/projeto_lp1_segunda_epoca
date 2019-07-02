using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    class Program : GameBoard
    {
        static void Main(string[] args)
        {
            GameLoop loop = new GameLoop();

            loop.Loop();

            /*
            uint rowArgCheck;
            rowArgCheck = Convert.ToUInt32(args[1]);

            uint colArgCheck;
            colArgCheck = Convert.ToUInt32(args[3]);

            Dictionary<string, uint> userArgs2 = new Dictionary<string, uint>();

            userArgs2.Add("-r", rowArgCheck);
            userArgs2.Add("-c", colArgCheck);

            for (uint i = 0; i < rowArgCheck; i++)
            {
                Console.WriteLine("~~~~~");
            }



            /* ------Works half
            Dictionary<string, uint> userArgs = new Dictionary<string, uint>();

            uint row = Convert.ToUInt32(args[1]);
            uint col = Convert.ToUInt32(args[3]);

            userArgs["-r"] = Convert.ToUInt32(args[0]);
            userArgs["-c"] = Convert.ToUInt32(args[2]);

            

            if (userArgs.ContainsKey("-r") != userArgs.ContainsKey("-r"))
            {
                Console.WriteLine("ERROR");
            }

            for (uint i = 0; i < row; i++)
            {
                Console.WriteLine(" ~~~~~ ");
            }

            for (uint i = 0; i < col; i++)
            {
                Console.WriteLine("|");
            }
            */




        }
    }
}
