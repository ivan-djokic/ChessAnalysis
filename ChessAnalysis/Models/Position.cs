namespace ChessAnalysis.Models
{
    [Flags]
    public enum Castling
    {
        None,
        King,
        Queen
    }

    public enum NextPlayer
    {
        Black,
        White
    }

    public class Position
    {
        public BestMove BestMove { get; set; }

        public Castling CastlingBlack { get; set; }

        public Castling CastlingWhite { get; set; }

        public string EnPassant { get; set; }

        public string Fen { get; set; }

        public int HalfMoves { get; set; }

        public NextPlayer NextPlayer { get; set; }

        public int Round { get; set; }
    }
}
