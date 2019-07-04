using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
     internal class Trap : CurrentMapObjects
    {
        internal int DamageLevel;
        internal Position Position;
        internal int MaxDamage;
        internal string TrapInfo;
        internal char Name;

        internal void Set(int damageLevel, Position position, int maxDamage, string trapInfo, char name)
        {
            Position = position;
            MaxDamage = maxDamage;
            TrapInfo = trapInfo;
            Name = name;
            DamageLevel = damageLevel;
        }

    }

    /*tres armadilhas cada uma num sitio diff com uma posicao diff e max damage diff random enrtre 0 e max
        help mostra os varios tipos
    trapinfo aparece no help dependendo das armadilhas q estiverem no nivel
        */
}
