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
		public Position(NextPlayer nextPlayer, (Castling Black, Castling White) castling, 
			string enPassant, int halfMoves, int round, char[][] board, BestMove bestMove)
		{
			BestMove = bestMove;
			Board = board;
			CastlingBlack = castling.Black;
			CastlingWhite = castling.White;
			EnPassant = enPassant;
			HalfMoves = halfMoves;
			NextPlayer = nextPlayer;
			Round = round;
		}

		public BestMove BestMove { get; }

		public char[][] Board { get; }

		public Castling CastlingBlack { get; }

		public Castling CastlingWhite { get; }

		public string EnPassant { get; }

		public int HalfMoves { get; }

		public NextPlayer NextPlayer { get; }

		public int Round { get; }
	}
}
