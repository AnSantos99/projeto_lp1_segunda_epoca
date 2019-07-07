namespace lp1_projetoFinal
{
    internal class Items : CurrentMapObjects
    {
        internal int Weight { set; get; }
        internal int Effect { set; get; }

        internal Items(Position position, Chars name, string info, int weight, int effect) : base(position, name, info)
        {
            Position = position;
            Name = name;
            Info = info;
            Weight = weight;
            Effect = effect;
        }
    }
}
