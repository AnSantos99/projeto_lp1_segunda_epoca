namespace lp1_projetoFinal
{
    internal class Items : CurrentMapObjects
    {
        internal int Weight { set; get; }

        internal Items(Position position, Chars name, string info, int weight) : base(position, name, info)
        {
            Position = position;
            Name = name;
            Info = info;
            Weight = weight;
        }
    }
}
