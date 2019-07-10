namespace lp1_projetoFinal
{
    internal class Items : CurrentMapObjects
    {
        internal int Weight { set; get; }
        internal int Effect { set; get; }
        internal int Index { get; set; }

        internal Items(Position position, Chars name, string info, int weight, int effect) : base(position, name, info)
        {
            Position = position;
            Name = name;
            Info = info;
            Weight = weight;
            Effect = effect;
            
        }

        internal Items(Position position, Chars name, string info, int weight, int effect, int index) : base(position, name, info)
        {
            Position = position;
            Name = name;
            Info = info;
            Weight = weight;
            Effect = effect;
            Index = index;
        }

        internal bool FallenInto(Player player)
        {
            if (player.Position.Row == this.Position.Row && player.Position.Col == this.Position.Col)
                return true;
            return false;
        }
    }
}
