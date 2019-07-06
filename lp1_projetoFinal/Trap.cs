namespace lp1_projetoFinal
{
     internal class Trap : CurrentMapObjects
    {

        internal int DamageLevel;
        internal int MaxDamage;
        internal string TrapInfo;
      
        internal Trap(Position position, Chars name, string info, int damageLevel, int maxDamage) : base(position, name, info)
        {
            DamageLevel = damageLevel;
            MaxDamage = maxDamage;
            TrapInfo = info;
        }
        
        internal bool FallenInto(Player player)
        { 
            return false;
        }

        

    }
}
