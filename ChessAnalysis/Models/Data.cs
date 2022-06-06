namespace ChessAnalysis.Models
{
    public class Data
    {
        private string m_input;

        public Data(Position position, string id, Comment comment, string input)
        {
            Comment = comment;
            Id = id;
            Position = position;
            m_input = input;
        }

        public Comment Comment { get; set; }

        public string Id { get; set; }

        public Position Position { get; set; }

        public override string ToString()
        {
            return m_input;
        }
    }
}
