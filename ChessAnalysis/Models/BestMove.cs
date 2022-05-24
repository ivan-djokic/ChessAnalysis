namespace ChessAnalysis.Models
{
    public class BestMove
    {
        public BestMove(string value, char piece, Point field)
        {
            Field = field;
            Piece = piece;
            Value = value;
        }

        public Point Field { get; set; } = new Point(-1, -1);

        public char Piece { get; set; }

        public string Value { get; set; }

        public bool ContainsIn(char[,] fen)
        {
            return fen[Field.X, Field.Y] != Piece;
        }
    }
}
