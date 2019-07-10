namespace lp1_projetoFinal
{
    internal class Enemy : CurrentMapObjects
    {
        internal int Health;
        internal int AttackPower;
        internal int MaxDamage;
        internal string enemyInfo;
        internal bool Active = true;

        /*
        internal Enemy(int health, int attackPower)
        {
            Health = health;
            AttackPower = attackPower;

        }*/

        internal Enemy(Position position, Chars name, string info, int maxDamage) : base(position, name, info)
        {
            enemyInfo = info;
            MaxDamage = maxDamage;
        }

        /*
        internal bool FallenInto(Player player)
        {
            if (Active && player.Position.Row == this.Position.Row && player.Position.Col == this.Position.Col)
                return true;
            return false;
        }*/
    }
}
