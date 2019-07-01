using System;

namespace lp1_projetoFinal
{
    class GameLoop
    {
        public void Loop()
        {
            do
            {
                MainMenu menu = new MainMenu();
                menu.Menu();
                
            }
            while (true);
        }
    }

}