using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
    internal struct GameScore
    {
        public int Score { get; set; }
        public string Frase { get; set; }

        public GameScore(string frase, int score)
        {
            Frase = frase;
            Score = score;
        }
    }
}
