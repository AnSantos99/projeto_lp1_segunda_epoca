namespace lp1_projetoFinal
{
     internal class Trap : CurrentMapObjects
    {
        internal int DamageLevel;
        internal int MaxDamage;
        internal string TrapInfo;
        internal bool Active = true;
      
        internal Trap(Position position, Chars name, string info, int damageLevel, int maxDamage) : base(position, name, info)
        {
            DamageLevel = damageLevel;
            MaxDamage = maxDamage;
            TrapInfo = info;
        }
        
        internal bool FallenInto(Player player)
        {
            if (Active && player.Position.Row == this.Position.Row && player.Position.Col == this.Position.Col)
                return true;
            return false;
        }
    }
}
