namespace lp1_projetoFinal
{
    internal class Enemy : CurrentMapObjects
    {
        internal int Health;
        internal int AttackPower;
        internal int MaxDamage;
        internal string enemyInfo;
        internal bool Active = true;

        internal Enemy(Position position, Chars name, string info, int maxDamage) : base(position, name, info)
        {
            enemyInfo = info;
            MaxDamage = maxDamage;
        }

 
        
    }
}
