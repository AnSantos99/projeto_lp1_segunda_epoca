using System;

namespace lp1_projetoFinal
{
    internal class BoardCells
    {
        char name;
        bool visited;

        internal BoardCells(char name, bool visited)
        {
            this.name = name;
            this.visited = visited;
        }

        internal virtual void Render()
        {
            if(visited)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(name);
                Console.ResetColor();
            }

            else if (name == (char)Chars.player)
            { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(name);
                Console.ResetColor();
            }

            else if (name == (char)Chars.exit)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(name);
                Console.ResetColor();
            }

            else if (name == (char)Chars.map)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(name);
                Console.ResetColor();
            }

           
            else Console.Write(name);
        }

       
    }
}