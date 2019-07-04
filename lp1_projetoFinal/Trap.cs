using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
     internal class Trap 
    {
        internal int DamageLevel;
        internal Position Position;
        internal int MaxDamage;
        internal string TrapInfo;
        internal char Name;
        

        internal Trap(int damageLevel, Position position, int maxDamage, string trapInfo, char name)
        {
            DamageLevel = damageLevel;
            Position = position;
            MaxDamage = maxDamage;
            TrapInfo = trapInfo;
            Name = name;
        }

        internal bool FallenInto(Player player)
        {
            if (player.position == this.Position)
                return true;

            return false;
        }

    }
}
