using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    internal class BoardCells
    {
        char name;

        internal BoardCells() : this(' ') { }

        internal BoardCells(char name)
        {
            this.name = name;
        }

        internal virtual void Render()
        {
            Console.Write(name);
        }

       
    }
}