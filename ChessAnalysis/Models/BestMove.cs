namespace ChessAnalysis.Models
{
    public class BestMove
    {
        public Point Field { get; set; } = new Point(-1, -1);

        public char Piece { get; set; }

        public string Value { get; set; }

        public bool Match(char piece, int x, int y)
        {
            return Piece == piece && Field.X == x && Field.Y == y;
        }

        //public override string ToString()
        //{
        //    return Value;
        //}
    }
}
