using System;
using System.Collections.Generic;


namespace lp1_projetoFinal
{
    internal class BoardCells
    {
        internal char name;
        internal bool visited;

        internal Position position;


        /// <summary>
        /// Constructor to get acess to name and visited boardcells 
        /// </summary>
        /// <param name="name"> Get the name of 
        /// </param>
        /// <param name="visited"></param>
        internal BoardCells(char name, bool visited, Position position)
        {
            this.name = name;
            this.visited = visited;
            this.position = position;
        }

        /// <summary>
        /// 
        /// </summary>
        internal virtual void Render()
        {
      
                if (visited)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(name);
                    Console.ResetColor();
                }

                else if (name == (char)Chars.trap)
                {

                    Console.Write(name);


                }

                else if (name == (char)Chars.enemy)
                {

                    Console.Write(name);


                }

                else if (name == (char)Chars.player || name == (char)Chars.exit)
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