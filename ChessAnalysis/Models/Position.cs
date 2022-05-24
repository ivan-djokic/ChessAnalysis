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
        public Position(char[][] board, NextPlayer nextPlayer, Castling castlingBlack, Castling castlingWhite, string enPassant, int halfMoves, int round, BestMove bestMove)
        {
            BestMove = bestMove;
            Board = board;
            CastlingBlack = castlingBlack;
            CastlingWhite = castlingWhite;
            EnPassant = enPassant;
            HalfMoves = halfMoves;
            NextPlayer = nextPlayer;
            Round = round;
        }

        public BestMove BestMove { get; set; }

        public char[][] Board { get; set; }

        public Castling CastlingBlack { get; set; }

        public Castling CastlingWhite { get; set; }

        public string EnPassant { get; set; }

        public int HalfMoves { get; set; }

        public NextPlayer NextPlayer { get; set; }

        public int Round { get; set; }
    }
}
