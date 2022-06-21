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

        public string Defense { get; set; }

        public string Opening { get; set; }

        public string Players { get; set; }

        public string Result { get; set; }
    }
}
