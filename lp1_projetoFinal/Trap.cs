/*
using System;
using System.Collections.Generic;
using System.Text;

namespace lp1_projetoFinal
{
     internal class Trap : CurrentMapObjects
    {

        
         
        internal int DamageLevel;
        internal int MaxDamage;
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
*/