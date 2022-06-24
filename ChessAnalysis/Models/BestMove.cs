namespace ChessAnalysis.Models
{
	public class BestMove
	{
		public BestMove(string input, char piece, Point field)
		{
			Field = field;
			Piece = piece;
			Value = input;
		}

		public Point Field { get; }

		public char Piece { get; set; }

		public string Value { get; }
	}
}
