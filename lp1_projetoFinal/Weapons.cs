using System;

namespace lp1_projetoFinal
{
    class Weapons : Items
    {
        internal Position Position { set; get; }
        internal Chars Name { set; get; }
        internal int Weight { set; get; }
        internal string Info { set; get; }
        internal int AttackPower { set; get; }
        internal int Durability { set; get; }

        internal Weapons(Position position, Chars name, string info, int weight, int attackPower, int durability) : base(position, name, info, weight)
        {
            Position = position;
            Name = name;
            Weight = weight;
            Info = info;
            AttackPower = attackPower;
            Durability = durability;

        }

        internal bool FallenInto(Player player)
        {
            if (player.Position.Row == this.Position.Row && player.Position.Col == this.Position.Col)
                return true;
            return false;
        }
    



}


}
