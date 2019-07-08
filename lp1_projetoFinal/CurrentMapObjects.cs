namespace lp1_projetoFinal
{
    internal class CurrentMapObjects
    {
        internal Position Position { set; get; }
        internal Chars Name { set; get; }
        internal string Info { set; get; }
       
        /// <summary>
        /// this constructor serves the mere purpose of storing an object present
        /// in the current map of a certain type, to be able to manipulate them
        /// with the moore look around feature
        /// </summary>
        /// <param name="position"> item's map placement</param>
        /// <param name="name">item's char to distinguish from others</param>
        /// <param name="info">item's info for the help text if on board</param>
        internal CurrentMapObjects(Position position, Chars name, string info)
        {
            Position = position;
            Name = name;
            Info = info;
        }
    }
}