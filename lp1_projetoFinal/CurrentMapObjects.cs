namespace lp1_projetoFinal
{
    internal class CurrentMapObjects
    {
        internal Position Position { set; get; }
        internal Chars Name { set; get; }
        internal string Info { set; get; }
       
        internal CurrentMapObjects(Position position, Chars name, string info)
        {
            Position = position;
            Name = name;
            Info = info;
        }



    }
}