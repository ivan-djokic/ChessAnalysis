namespace ChessAnalysis.Models
{
    public class Data
    {
        public Data(Position position, string id, Comment comment, string input)
        {
            Comment = comment;
            Id = id;
            Input = input;
            Position = position;
        }

        public Comment Comment { get; set; }

        public string Id { get; set; }

        public string Input { get; set; }

        public Position Position { get; set; }
    }
}
