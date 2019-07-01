using System;

namespace lp1_projetoFinal
{
    class Program : GameBoard
    {
        
        static void Main(string[] args)
        {
             string oneo = args[0];
             int one = Convert.ToInt32(oneo);
             string twoo = args[1];
             int two = Convert.ToInt32(twoo);

            GameBoard board = new GameBoard();
            //board.RowSize = one;

            //board.ColSize = two;

            MainMenu menu = new MainMenu();
            menu.Menu();


        }
    }
}
