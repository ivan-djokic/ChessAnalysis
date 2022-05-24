namespace ChessAnalysis.Models
{
    public class Comment
    {
        public Comment(string players, string timestamp, string opening, string defense)
        {
            Defense = defense;
            Opening = opening;
            Players = players;
            Timestamp = timestamp;
        }

        public string Defense { get; set; }

        public string Opening { get; set; }

        public string Players { get; set; }

        public string Timestamp { get; set; }
    }
}
