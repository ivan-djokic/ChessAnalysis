namespace ChessAnalysis.Models
{
    public class Comment
    {
        public Comment(string players, string result, string opening, string defense)
        {
            Defense = defense;
            Opening = opening;
            Players = players;
            Result = result;
        }

        public string Defense { get; }

        public string Opening { get; }

        public string Players { get; }

        public string Result { get; }
    }
}
