namespace lp1_projetoFinal
{
    class Food : Items
    {

        internal Position Position { set; get; }
        internal Chars Name { set; get; }
        internal int Weight { set; get; }
        internal string Info { set; get; }
        internal int Effect { set; get; }
        internal int HPIncrease { set; get; }

        internal Food(Position position, Chars name, string info, int weight, int hpIncrease) : base(position, name, info, weight)
        {
            Position = position;
            Name = name;
            Weight = weight;
            Info = info;
   
            HPIncrease = hpIncrease;

        }
    }



}


