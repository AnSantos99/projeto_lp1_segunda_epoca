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
            if (player.position.Row == this.Position.Row && player.position.Col == this.Position.Col)
                return true;
            return false;
        }

        

    }
}
