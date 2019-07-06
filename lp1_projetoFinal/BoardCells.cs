using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    internal class BoardCells
    {
        char name;

        internal BoardCells(char name)
        {
            this.name = name;
        }

        internal virtual void Render()
        {
            if (name == (char)Chars.player)
            { 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(name);
            Console.ResetColor();
            }

            else if (name == (char)Chars.path)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(name);
                Console.ResetColor();
            }
            else Console.Write(name);
        }

       
    }
}